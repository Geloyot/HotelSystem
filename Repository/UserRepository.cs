using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem.Appdata;

namespace HotelReservationSystem
{
    public class UserRepository
    {
        private DBSYSEntities Database;

        public UserRepository() { 
            Database = new DBSYSEntities();
        }

        public void RegisterUser(UserAccount UserAcct, ref bool ActionSuccessful) {
            try 
            {
                Database.UserAccount.Add(UserAcct);
                Database.SaveChanges();
                ActionSuccessful = true;
            }    
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Account Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateUser(int? SpecificUserId, UserAccount UserAcct, ref bool ActionSuccessful) {
            try 
            {
                UserAccount SpecificUser = Database.UserAccount.Where(m => m.userId == SpecificUserId).FirstOrDefault();
                SpecificUser.userName = UserAcct.userName;
                SpecificUser.userPassword = UserAcct.userPassword;

                Database.SaveChanges();
                ActionSuccessful = true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Account Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveUser(int? SpecificUserId, ref bool ActionSuccessful) {
            try
            {
                UserAccount SpecificUser = Database.UserAccount.Where(m => m.userId == SpecificUserId).FirstOrDefault();
                Database.UserAccount.Remove(SpecificUser);
                Database.SaveChanges();
                ActionSuccessful = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Account Removal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public UserAccount GetUserByUsername(string SpecificUsername)
        {
            // Re-initialize db object because sometimes data in the list is not updated.
            Database = new DBSYSEntities();
            return Database.UserAccount.Where(m => m.userName == SpecificUsername).FirstOrDefault();
        }

        public UserAccount GetUserByUserID(int? UserID) 
        {
            Database = new DBSYSEntities();
            return Database.UserAccount.Where(u => u.userId == UserID).FirstOrDefault();
        }

        public List<UserAccount> GetUserAccountList()
        {
            Database = new DBSYSEntities();

            return Database.UserAccount.ToList();
        }
    }
}
