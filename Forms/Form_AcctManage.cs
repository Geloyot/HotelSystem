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
    public partial class Form_AcctManage : Form
    {
        private UserRepository UserRepos;
        private int? SelectedUserId = null;

        public bool HasLoggedOut = false;

        public Form_AcctManage()
        {
            InitializeComponent();
        }

        private void Form_AcctManage_Load(object sender, EventArgs e)
        {
            Timer_Clock.Start();
            UserRepos = new UserRepository();
            LoadUsersDatabase();
        }

        private void LoadUsersDatabase()
        {
            Dgv_AcctManage.DataSource = UserRepos.GetUserAccountList();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            string username = Txt_Username.Text;
            string password = Txt_Password.Text;

            if (String.IsNullOrEmpty(username)) 
            {
                ErrorProviderInput.SetError(Txt_Username, "Username field is empty!");
                return;
            } else if (String.IsNullOrEmpty(password)) 
            {
                ErrorProviderInput.SetError(Txt_Password, "Password field is empty!");
                return;
            }

            DBSYSEntities Database = new DBSYSEntities();
            Database.SP_NewUserAccount(username, password, 1, CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userId);
            
            LoadUsersDatabase();
            Txt_Username.Clear();
            Txt_Password.Clear();

            //UserAccount RegisteredUser = new UserAccount();
            //RegisteredUser.userName = username;
            //RegisteredUser.userPassword = password;
            //RegisteredUser.userStatus = "ACTIVE";

            //bool RegistrationSuccessful = false;
            //UserRepos.RegisterUser(RegisteredUser, ref RegistrationSuccessful);
            //if (RegistrationSuccessful)
            //{
            //    ErrorProviderInput.Clear();
            //    Txt_Username.Clear();
            //    Txt_Password.Clear();

            //    MessageBox.Show(username + " is successfully registered!", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    LoadUsersDatabase();
            //}
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            string username = Txt_Username.Text;
            string password = Txt_Password.Text;

            if (String.IsNullOrEmpty(username))
            {
                ErrorProviderInput.SetError(Txt_Username, "Username field is empty!");
                return;
            }
            else if (String.IsNullOrEmpty(password))
            {
                ErrorProviderInput.SetError(Txt_Password, "Password field is empty!");
                return;
            }

            UserAccount UpdatedUser = UserRepos.GetUserByUserID(SelectedUserId);
            UpdatedUser.userName = username;
            UpdatedUser.userPassword = password;

            bool RegistrationSuccessful = false;
            UserRepos.UpdateUser(SelectedUserId, UpdatedUser, ref RegistrationSuccessful);
            if (RegistrationSuccessful)
            {
                ErrorProviderInput.Clear();
                Txt_Username.Clear();
                Txt_Password.Clear();

                MessageBox.Show(username + " is successfully updated!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsersDatabase();
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult Action = MessageBox.Show("Are you sure you want to remove this account?\nThis action cannot be undone.", "Remove Account", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (Action == DialogResult.Yes)
            {
                string username = Txt_Username.Text;

                bool RegistrationSuccessful = false;
                UserRepos.RemoveUser(SelectedUserId, ref RegistrationSuccessful);
                if (RegistrationSuccessful)
                {
                    ErrorProviderInput.Clear();
                    Txt_Username.Clear();
                    Txt_Password.Clear();

                    MessageBox.Show(username + " is successfully removed!", "Removal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsersDatabase();
                }
            }
        }

        private void Dgv_AcctManage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                SelectedUserId = Convert.ToInt32(Dgv_AcctManage.Rows[e.RowIndex].Cells[0].Value);
                Txt_Username.Text = Dgv_AcctManage.Rows[e.RowIndex].Cells[1].Value.ToString();
                Txt_Password.Text = Dgv_AcctManage.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Cell Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Form_Login FormLogin = new Form_Login();
            FormLogin.ShowDialog();
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

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            Label_Calendar.Text = DateTime.Now.ToString("d");
            Label_Clock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void Form_AcctManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!HasLoggedOut)
            {
                Application.Exit();
            }
            else 
            {
                Form_Login FormLogin = new Form_Login();
                FormLogin.Show();
                this.Dispose();

                HasLoggedOut = false;
            }
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            HasLoggedOut = true;
            Form_AcctManage_FormClosed(sender, null);
        }
    }
}
