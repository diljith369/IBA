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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            cmbUserRole.SelectedIndex = 1;
            cmbUserRole.Enabled = (GlobalHandler.IsAdmin);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ConnectionManager oConnectionManager = new ConnectionManager();
            SqlConnection connActiveConnection = oConnectionManager.GetActiveConnection;
            int iRows = DBManager.GetInstance.AddUser(txtUserName.Text, txtPassword.Text,txtEmail.Text, GlobalHandler.IsAdmin, connActiveConnection);
            if(iRows > 0)
            {
                MessageBox.Show("User added successfully", "Add User", MessageBoxButtons.OK);
                txtUserName.Text = txtPassword.Text = txtConfirmPassword.Text = txtEmail.Text = string.Empty;
            }
        }
    }
}
