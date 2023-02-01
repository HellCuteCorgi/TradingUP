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

namespace TradingApp
{
    public partial class Form1 : Form
    {

        static string connectionString = @"Data Source=HELLCUTECORGI\SQLEXPRESS; Initial catalog=TradingUP; Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void passSeeBtn_Click(object sender, EventArgs e)
        {
            if (passSeeBtn.Text == "Показать пароль")
            {
                passTB.UseSystemPasswordChar = false;
                passSeeBtn.Text = "Скрыть пароль";
            }
            else
            {
                passTB.UseSystemPasswordChar = true;
                passSeeBtn.Text = "Показать пароль";
            }
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            string type, name;
            SqlConnection MainCon = new SqlConnection(connectionString);
            MainCon.Open();
            string findCom = "select count(*) from [Сотрудники] where [Логин] = @log and [Пароль] = @pass";
            SqlCommand findCmd = new SqlCommand(findCom, MainCon);
            SqlParameter log = new SqlParameter("@log", logTB.Text);
            SqlParameter pass = new SqlParameter("@pass", passTB.Text);
            findCmd.Parameters.Add(log);
            findCmd.Parameters.Add(pass);
            if (Convert.ToInt32(findCmd.ExecuteScalar()) == 1)
            {
                SqlCommand command1 = new SqlCommand("SELECT [ФИО] FROM [Сотрудники] WHERE [Логин] = '" + logTB.Text + "'", MainCon);
                SqlCommand command2 = new SqlCommand("SELECT [Должность] FROM [Сотрудники] WHERE [Логин] = '" + logTB.Text + "'", MainCon);
                name = (string)command1.ExecuteScalar();
                type = Convert.ToString(command2.ExecuteScalar());

                Form2 test = new Form2(type, name);
                logTB.Clear();
                passTB.Clear();
                test.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильно введен логин или пароль. Проверьте введенные данные и повторите заново", "Ошибка!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
