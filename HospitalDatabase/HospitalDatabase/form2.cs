using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace HospitalDatabase
{
    public partial class form2 : Form
    {
        private string _userName;

        //передаю usaername пользователя на вторую форму
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; userName.Text = value; }
        }

        public form2()
        {
            InitializeComponent();
        }

        //загружаю на форму методы с таблицами
        private void form2_Load(object sender, EventArgs e)
        {
            Worker();
            Patients();
            Registration();
        }

        //метод для таблиц
        private DataTable GetData(string tableName)
        {
            DataTable dataTable = new DataTable();
            string connectionString = @"Data Source=DESKTOP-6OHMFQD;Initial Catalog=BOLNICA;Integrated Security=True";
            string query = $"SELECT * FROM {tableName}";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open(); // Открывается соединение

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при получении данных: " + ex.Message);
            }
            return dataTable;
        }

        private void Worker()
        {
            workerGrid.DataSource = GetData("Worker1");
        }

        private void Patients()
        {
            patients2Grid.DataSource = GetData("Patients");
        }

        private void Registration()
        {
            ApGrid2.DataSource = GetData("Appointments");
        }
    }
}