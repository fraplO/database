using System.Data.SqlClient;

namespace HospitalDatabase
{
    internal class Login
    {
        private BazaDan _database;

        public Login(BazaDan db)
        {
            _database = db;
        }

        public bool CheckLogin(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM _ADMIN WHERE _username = @username AND _password = @password";
            int count;

            using (SqlConnection connection = _database.getCon())
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                connection.Open();
                count = (int)cmd.ExecuteScalar();
            }
            return count > 0;
        }
    }
}