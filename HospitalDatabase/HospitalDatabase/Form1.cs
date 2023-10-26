using System;
using System.Windows.Forms;

namespace HospitalDatabase
{
    public partial class Form1 : Form
    {
        private BazaDan _bd;
        private Login l;

        public Form1()
        {
            _bd = new BazaDan();
            l = new Login(_bd); // Инициализируем здесь
            InitializeComponent();
            tbPas.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbPas.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbLogin.Text;
                string password = tbPas.Text;

                if (l.CheckLogin(username, password))
                {
                    form2 f2 = new form2();
                    f2.UserName = username;
                    f2.ShowDialog();
                    this.Hide();

                    MessageBox.Show("Успешная авторизация");
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                _bd.ClosedSql(); //закрываем соединение
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.worker1TableAdapter.Fill(this.dataSet1.Worker1);
        }
    }
}