
using System.Data.SqlClient;


namespace IBA.Manager
{
    public class ConnectionManager
    {
        private  SqlConnection sqlCurrentConnection;

        public  ConnectionManager ()
        {
           
        }

        public SqlConnection GetActiveConnection
        {
            get {
                sqlCurrentConnection = new SqlConnection(DBManager.GetInstance.GetConnectionString());
                sqlCurrentConnection.Open();
                return sqlCurrentConnection; 
            }
        }

      
    }
}
