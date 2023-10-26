using System.Data.SqlClient;

namespace HospitalDatabase
{
    internal class BazaDan
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-6OHMFQD;Initial Catalog=BOLNICA;Integrated Security=True");

        public void OpenSql()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void ClosedSql()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection getCon()
        {
            return connection;
        }
    }
}