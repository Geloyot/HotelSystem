using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.Forms
{
    public partial class Form_Dashboard_Admin : Form
    {
        public Form_Dashboard_Admin()
        {
            InitializeComponent();
        }

        private void TS_MI_OpenUserEntryForm_Click(object sender, EventArgs e)
        {
            Form_AcctManage AccountManagement = new Form_AcctManage();
            AccountManagement.ShowDialog();
        }

        private void Form_Dashboard_Admin_Load(object sender, EventArgs e)
        {
            ToolStripStatus_CurrentUser.Text = "Current User: " + CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userName; 
        }
    }
}
