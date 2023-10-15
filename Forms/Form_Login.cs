using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem.Appdata;
using HotelReservationSystem.Forms;

namespace HotelReservationSystem
{
    public partial class Form_Login : Form
    {
        UserRepository UserRepos;

        public Form_Login()
        {
            InitializeComponent();
            UserRepos = new UserRepository();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            Timer_Clock.Start();
        }
        
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string username = Txt_Username.Text;

            if (String.IsNullOrEmpty(username)) 
            {
                ErrorProviderInput.SetError(Txt_Username, "Username field is empty!");
                return;
            }
            if (String.IsNullOrEmpty(Txt_Password.Text))
            {
                ErrorProviderInput.SetError(Txt_Password, "Password field is empty!");
                return;
            }

            var LoginUser = UserRepos.GetUserByUsername(username);
            if (LoginUser != null)
            {
                if (username.Equals(LoginUser.userName) &&  Txt_Password.Text.Equals(LoginUser.userPassword)) 
                {
                    CurrentlyLoggedUser.GetInstance().CurrentUserAccount = LoginUser;
                    switch ((Roles)LoginUser.roleId) 
                    {
                        case Roles.Admin:
                            new Form_Dashboard_Admin().Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("Cannot login! User has no appropriate role!", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
            else 
            {
                MessageBox.Show("Login failed!", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer_Loading_Tick(object sender, EventArgs e)
        {
            if (ProgressBar_Loading.Value < 200)
            {
                ProgressBar_Loading.Value++;
                Label_Loading.Text = (ProgressBar_Loading.Value / 2) + "%";
            }
            else 
            {
                Timer_Loading.Stop();
                ProgressBar_Loading.Value = 0;

                Form_AcctManage AccountManagement = new Form_AcctManage();
                AccountManagement.Show();
                this.Hide();
            }
        }

        private void Checkbox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbox_ShowPass.Checked == true)
            {
                Txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                Txt_Password.UseSystemPasswordChar = true;
            }
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
                if (String.IsNullOrEmpty(Txt_Username.Text))
                {
                    Txt_Username.Focus();
                }
                else 
                {
                    Btn_Login_Click(sender, e);
                }
            } 
        }

        private void LinkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Form_Register FormRegister = new Form_Register()) 
            {
                FormRegister.ShowDialog();
            }
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            Label_Calendar.Text = DateTime.Now.ToString("d");
            Label_Clock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
    }
}
