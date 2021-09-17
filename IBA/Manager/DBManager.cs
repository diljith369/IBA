using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IBA.Manager
{
    public class DBManager
    {
        private static DBManager oDBManager;

        public static DBManager GetInstance
        {
            get
            {
                if (oDBManager == null)
                {
                    oDBManager = new DBManager();

                }
                return oDBManager;
            }
        }

        public DataSet GetUserDetails(String strUserName, string strPassword, SqlConnection connActiveConnection)
        {

            string strQuery = "SELECT * FROM userdetails WHERE username='" + strUserName + "' AND password='" + strPassword + "'";

            DataSet dsCurrent = new DataSet();
            SqlDataAdapter daUserDetails = new SqlDataAdapter();
            SqlCommand cmdUSerDetails = new SqlCommand(strQuery, connActiveConnection);
            daUserDetails.SelectCommand = cmdUSerDetails; // Set the select command for the DataAdapter
            daUserDetails.Fill(dsCurrent); // Fill the DataSet with the DataAdapter
            
            return dsCurrent;

        }

        public DataSet GetUserDetailsWithSP(String strUserName, string strPassword, SqlConnection connActiveConnection)
        {


            DataSet dsCurrent = new DataSet();
            SqlDataAdapter daUserDetails = new SqlDataAdapter();

            SqlCommand cmdGetUserChecked = new SqlCommand("userchecks", connActiveConnection);

            cmdGetUserChecked.CommandType = CommandType.StoredProcedure;

            cmdGetUserChecked.Parameters.Add(new SqlParameter("@uname", strUserName));
            cmdGetUserChecked.Parameters.Add(new SqlParameter("@pass", strPassword));




            daUserDetails.SelectCommand = cmdGetUserChecked; // Set the select command for the DataAdapter
            daUserDetails.Fill(dsCurrent); // Fill the DataSet with the DataAdapter

            return dsCurrent;

        }

        public DataSet GetUserDetailsWithPreparedStatement(String strUserName, string strPassword, SqlConnection connActiveConnection)
        {
            string strQuery = "SELECT * FROM userdetails WHERE username=@username AND password=@password";
           

            DataSet dsCurrent = new DataSet();
            SqlDataAdapter daUserDetails = new SqlDataAdapter();
            SqlCommand cmdUSerDetails = new SqlCommand(strQuery, connActiveConnection);
            cmdUSerDetails.Parameters.AddWithValue("@username", strUserName);
            cmdUSerDetails.Parameters.AddWithValue("@password", strPassword);

            daUserDetails.SelectCommand = cmdUSerDetails; // Set the select command for the DataAdapter
            daUserDetails.Fill(dsCurrent); // Fill the DataSet with the DataAdapter

            return dsCurrent;            

        }

        public DataSet GetTimeTable(string strEmail, SqlConnection connActiveConnection)
        {

            string strQuery = "SELECT * FROM timetable WHERE email='" + strEmail + "'";

            DataSet dsCurrent = new DataSet();
            SqlDataAdapter daTimeTable = new SqlDataAdapter();
            SqlCommand cmdUSerDetails = new SqlCommand(strQuery, connActiveConnection);
            daTimeTable.SelectCommand = cmdUSerDetails; // Set the select command for the DataAdapter
            daTimeTable.Fill(dsCurrent); // Fill the DataSet with the DataAdapter

            return dsCurrent;

        }

        public DataSet GetAllUsers(SqlConnection connActiveConnection)
        {

            string strQuery = "SELECT UserName,Password,Email FROM userdetails";

            DataSet dsCurrent = new DataSet();
            SqlDataAdapter daUserDetails = new SqlDataAdapter();
            SqlCommand cmdUSerDetails = new SqlCommand(strQuery, connActiveConnection);
            daUserDetails.SelectCommand = cmdUSerDetails; // Set the select command for the DataAdapter
            daUserDetails.Fill(dsCurrent); // Fill the DataSet with the DataAdapter

            return dsCurrent;

        }

        public int AddUser(String strUserName, string strPassword,string  strClientMail, bool bAdmin, SqlConnection connActiveConnection)
        {

            int iAffectedRows = 0;
            int isAdmin = (bAdmin) ? 1 : 0;
            string strAddUserQuery = "INSERT INTO userdetails VALUES('" + strUserName + "','" + strPassword + "','" + strClientMail + "','" + isAdmin + "')";
            SqlCommand cmdAddUser = new SqlCommand(strAddUserQuery, connActiveConnection);

            try
            {
                iAffectedRows =  cmdAddUser.ExecuteNonQuery();

            }
            catch (Exception)
            {
            }

            return iAffectedRows;

        }

        

        public int DeleteUser( string strClientMail, SqlConnection connActiveConnection)
        {

            int iAffectedRows = 0;
            SqlDataAdapter daUserDetails = new SqlDataAdapter();

            SqlCommand cmdDelUser = new SqlCommand("deleteuser", connActiveConnection);

            cmdDelUser.CommandType = CommandType.StoredProcedure;

            cmdDelUser.Parameters.Add(new SqlParameter("@email", strClientMail));

            daUserDetails.SelectCommand = cmdDelUser;

            try
            {
                iAffectedRows = cmdDelUser.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return iAffectedRows;

        }

        public int EditUser(String strUserName, string strPassword, string strClientMail, bool bAdmin, SqlConnection connActiveConnection)
        {

            int iAffectedRows = 0;
            int isAdmin = (bAdmin) ? 1 : 0;
            SqlDataAdapter daUserDetails = new SqlDataAdapter();

            SqlCommand cmdEditUser = new SqlCommand("edituser", connActiveConnection);

            cmdEditUser.CommandType = CommandType.StoredProcedure;

            cmdEditUser.Parameters.Add(new SqlParameter("@usrname", strUserName));
            cmdEditUser.Parameters.Add(new SqlParameter("@pswd", strPassword));
            cmdEditUser.Parameters.Add(new SqlParameter("@email", strClientMail));
            cmdEditUser.Parameters.Add(new SqlParameter("@admin", isAdmin));

            daUserDetails.SelectCommand = cmdEditUser;

            try
            {
                iAffectedRows = cmdEditUser.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return iAffectedRows;

        }

        public string GetConnectionString()
        {
            string strDBServer = ConfigurationManager.AppSettings["DBSERVER"].ToString();
            string strDBName = ConfigurationManager.AppSettings["DBNAME"].ToString();
            string strDBUser = ConfigurationManager.AppSettings["DBUSER"].ToString();


            return "Data Source = " + strDBServer + "; Initial Catalog=" + strDBName + "; User Id=" + strDBUser + "; Password=" + DecryptPassword() + ";Integrated Security=false";

        }

        private byte[] AESDecryptor(byte[] baEncryptedText, byte[] key, byte[] iv)
        {
            byte[] baResult;
            using (var aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;
                aes.Key = key;
                aes.IV = iv;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    baResult = GetDecryptedStream(baEncryptedText, decryptor);
                }
            }
            return baResult;
        }
        private byte[] GetDecryptedStream(byte[] data, ICryptoTransform cryptoTransform)
        {
            using (var ms = new MemoryStream())
            using (var cryptoStream = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write))
            {
                cryptoStream.Write(data, 0, data.Length);
                cryptoStream.FlushFinalBlock();

                return ms.ToArray();
            }
        }



        private string DecryptPassword()
        {
            string strDbPassword = ConfigurationManager.AppSettings["DBPASSWORD"].ToString();
            string strKeyVal = ConfigurationManager.AppSettings["KEY"].ToString();
            string strIV = ConfigurationManager.AppSettings["INTIVECTOR"].ToString();

            byte[] Key = Convert.FromBase64String(strKeyVal);
            byte[] IV = Convert.FromBase64String(strIV);

            byte[] baResult = AESDecryptor(Convert.FromBase64String(strDbPassword), Key, IV);
            return  Encoding.ASCII.GetString(baResult);

        }

    }
}
