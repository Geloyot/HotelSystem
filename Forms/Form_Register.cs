
using HotelReservationSystem.Appdata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class Form_Register : Form
    {
        private DBSYSEntities Database;

        public Form_Register()
        {
            InitializeComponent();
            Database = new DBSYSEntities();
        }

        private void Form_Register_Load(object sender, EventArgs e)
        {
            Timer_Clock.Start();
            LoadCbBoxRoles();
        }

        private void LoadCbBoxRoles() 
        {
            var User_Roles = Database.Role.ToList();
            CbBox_Role.ValueMember = "roleId";
            CbBox_Role.DisplayMember = "roleName";
            CbBox_Role.DataSource = User_Roles;
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            Label_Calendar.Text = DateTime.Now.ToString("d");
            Label_Clock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void Txt_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Txt_Password.Focus();
            }
        }

        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Txt_PasswordConfirm.Focus();
            }
        }

        private void Txt_PasswordConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (String.IsNullOrEmpty(Txt_Username.Text))
                {
                    Txt_Username.Focus();
                }
                else
                {
                    Btn_Register_Click(sender, e);
                }
            }
        }

        private void LinkLabel_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Username.Text)) 
            {
                ErrorProviderInput.SetError(Txt_Username, "Username field is empty!");
                return;
            }
            if (String.IsNullOrEmpty(Txt_Password.Text))
            {
                ErrorProviderInput.SetError(Txt_Password, "Password field is empty!");
                return;
            }
            if (String.IsNullOrEmpty(Txt_PasswordConfirm.Text)) 
            {
                ErrorProviderInput.SetError(Txt_PasswordConfirm, "Confirm Password field is empty!");
                return;
            }
            if (!Txt_Password.Text.Equals(Txt_PasswordConfirm.Text)) 
            {
                ErrorProviderInput.SetError(Txt_PasswordConfirm, "Password fields do not match!");
                return;
            }

            UserAccount NewUserAccount = new UserAccount();
            NewUserAccount.userName = Txt_Username.Text;
            NewUserAccount.userPassword = Txt_Password.Text;
            NewUserAccount.roleId = Convert.ToInt32(CbBox_Role.SelectedValue);
            NewUserAccount.userStatus = "ACTIVE";

            string username = Txt_Username.Text;

            Database.UserAccount.Add(NewUserAccount);
            Database.SaveChanges();

            Txt_Username.Clear();
            Txt_Password.Clear();
            Txt_PasswordConfirm.Clear();
            MessageBox.Show("Registration successful!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CbBox_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
