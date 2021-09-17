using IBA.Manager;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace IBA
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill missing fields !", "IBA login validation");
                this.DialogResult = DialogResult.None;
            } 
            else
            {
                if (VerifiedUserExistance())
                {
                    this.DialogResult = DialogResult.OK;
                } else
                {
                    MessageBox.Show("Invalid attempt !!!", "User verification", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.None;

                }
            }

            
        }

        private List<string> GetUserInfoFromRegistry()
        {
            List<string> lstUserInfo = new List<string>();
            RegistryKey rkeyIBA = Registry.CurrentUser.OpenSubKey("IBA");
            if (rkeyIBA != null)
            {

                lstUserInfo.Add(rkeyIBA.GetValue("username").ToString());
                lstUserInfo.Add(rkeyIBA.GetValue("password").ToString());
                lstUserInfo.Add(rkeyIBA.GetValue("email").ToString());
                lstUserInfo.Add(rkeyIBA.GetValue("isadmin").ToString());
                rkeyIBA.Close();
            }

            return lstUserInfo;

        }
              

        private bool GetUserInfofromDB(string strUserName, string strPassword, ref SqlConnection connActiveConnection)
        {
            bool userindb = false;
            DataSet dsUserDetails;
            if(cmbInjectionProtection.SelectedIndex == 0)
            {
                dsUserDetails = DBManager.GetInstance.GetUserDetails(strUserName, strPassword, connActiveConnection);

            }
            else if (cmbInjectionProtection.SelectedIndex == 1)
            {
                dsUserDetails = DBManager.GetInstance.GetUserDetailsWithPreparedStatement(strUserName, strPassword, connActiveConnection);

            }
            else
            {
                dsUserDetails = DBManager.GetInstance.GetUserDetailsWithSP(strUserName, strPassword, connActiveConnection);

            }
            if (dsUserDetails.Tables[0].Rows != null && dsUserDetails.Tables[0].Rows.Count > 0)
            {
                string strEmail;
                strUserName = dsUserDetails.Tables[0].Rows[0]["username"].ToString();
                strPassword = dsUserDetails.Tables[0].Rows[0]["password"].ToString();
                strEmail = dsUserDetails.Tables[0].Rows[0]["email"].ToString();
                //strIsAdmin = dsUserDetails.Tables[0].Rows[0]["isadmin"].ToString();
                GlobalHandler.IsAdmin = Convert.ToBoolean(dsUserDetails.Tables[0].Rows[0]["isadmin"]);
                GlobalHandler.LoggedInUser = strUserName;
                RegistryKey rkeyIBAUSer = Registry.CurrentUser.CreateSubKey("IBA");
                rkeyIBAUSer.SetValue("username", strUserName);
                rkeyIBAUSer.SetValue("password", Convert.ToBase64String(Encoding.ASCII.GetBytes(strPassword)));
                rkeyIBAUSer.SetValue("isadmin", GlobalHandler.IsAdmin.ToString());
                rkeyIBAUSer.SetValue("email", strEmail);
                rkeyIBAUSer.SetValue("LoggedInTime", DateTime.Now.ToString());
                rkeyIBAUSer.Close();
                userindb = true;
            }

            else
            {

                userindb = false;
                txtUserName.Text = txtPassword.Text = "";

            }

            return userindb;
        }

        private bool VerifiedUserExistance()
        {
            bool userexists = false;
            ConnectionManager oConnectionManager = new ConnectionManager();
            SqlConnection connActiveConnection = oConnectionManager.GetActiveConnection;
            List<string> lstRegUserInfo = GetUserInfoFromRegistry();
            if (lstRegUserInfo.Count == 4 && (lstRegUserInfo[0] == txtUserName.Text.Trim() && txtPassword.Text.Trim() == Encoding.ASCII.GetString(Convert.FromBase64String(lstRegUserInfo[1]))))
            {
                GlobalHandler.IsAdmin = Convert.ToBoolean(lstRegUserInfo[3]);
                GlobalHandler.LoggedInUser = lstRegUserInfo[0];

                //OpenForm(lstRegUserInfo[2], lstRegUserInfo[0], ref connActiveConnection);
                userexists = true;
            }
            else
            {
                userexists = GetUserInfofromDB(txtUserName.Text, txtPassword.Text, ref connActiveConnection);

            }
            if (connActiveConnection.State != ConnectionState.Closed)
            {
                connActiveConnection.Close();
            }

            return userexists;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmbInjectionProtection.SelectedIndex = 0;
        }
    }
}
