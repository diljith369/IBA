using IBA.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBA
{
    public partial class UserSettingsForm : Form
    {
        public UserSettingsForm()
        {
            InitializeComponent();
        }

        private void UserSettingsForm_Load(object sender, EventArgs e)
        {
            cmbUserRole.SelectedIndex = (GlobalHandler.IsAdmin) ? 1 : 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionManager oConnectionManager = new ConnectionManager();
                SqlConnection connActiveConnection = oConnectionManager.GetActiveConnection;
                DBManager.GetInstance.EditUser(txtUserName.Text, txtPassword.Text, txtEmail.Text, GlobalHandler.IsAdmin, connActiveConnection);
                MessageBox.Show("User settings edited successfully", "Add User", MessageBoxButtons.OK);
                txtUserName.Text = txtPassword.Text = txtEmail.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
