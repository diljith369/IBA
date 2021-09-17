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
    public partial class ViewAllForm : Form
    {
        public ViewAllForm()
        {
            InitializeComponent();
        }

        private void ViewAllForm_Load(object sender, EventArgs e)
        {
            try
            {
                GetAllUsers();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void GetAllUsers()
        {
            ConnectionManager oConnectionManager = new ConnectionManager();
            SqlConnection connActiveConnection = oConnectionManager.GetActiveConnection;
            DataSet dsUserDetails = DBManager.GetInstance.GetAllUsers(connActiveConnection);
            gvwViewAll.DataSource = dsUserDetails.Tables[0];
            if (connActiveConnection.State != ConnectionState.Closed)
            {
                connActiveConnection.Close();
            }
        }
    }
}

