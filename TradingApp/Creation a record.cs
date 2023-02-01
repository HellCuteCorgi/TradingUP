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
    public partial class Form3 : Form
    {

        static string connectionString = @"Data Source=HELLCUTECORGI\SQLEXPRESS; Initial catalog=TradingUP; Integrated Security=True";
        public SqlConnection Connection = new SqlConnection(connectionString);

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradingUPDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.tradingUPDataSet.Отделы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradingUPDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.tradingUPDataSet.Товары);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = orderComboBox.SelectedValue.ToString();
            string s2 = comboBox1.SelectedValue.ToString();
            string s3 = executionDateTimePicker.Value.ToString();
            string s4 = domainUpDown1.Text;

            string ComandAdd = "INSERT INTO [Продажи] ([Артикул товара], [Отдел], [Дата продажи], [Количество]) VALUES('" + s1 + "', '" + s2 + "', '" + s3 + "', '" + s4 + "')";

            SqlCommand cmd = new SqlCommand(ComandAdd, Connection);
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            executionDateTimePicker.Value = DateTime.Now;
            domainUpDown1.Text = "0";
        }
    }
}
