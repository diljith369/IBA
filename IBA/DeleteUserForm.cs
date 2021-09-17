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
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm()
        {
            InitializeComponent();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionManager oConnectionManager = new ConnectionManager();
                SqlConnection connActiveConnection = oConnectionManager.GetActiveConnection;
                if (MessageBox.Show("Do you want to delete the user ?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DBManager.GetInstance.DeleteUser(txtEmail.Text, connActiveConnection);
                    MessageBox.Show("User settings edited successfully", "Add User", MessageBoxButtons.OK);

                }
                txtEmail.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
