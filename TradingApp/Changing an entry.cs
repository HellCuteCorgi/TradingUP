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
    public partial class Form4 : Form
    {

        static string connectionString = @"Data Source=HELLCUTECORGI\SQLEXPRESS; Initial catalog=TradingUP; Integrated Security=True";
        public SqlConnection Connection = new SqlConnection(connectionString);

        public Form4(string s1, string s2, string s3, string s4)
        {
            InitializeComponent();
            orderComboBox.Text = s1;
            comboBox1.Text = s2;
            executionDateTimePicker.Text = s3;
            domainUpDown1.Text = s4;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
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

          //string ComandAdd = " update [Продажи] set [Артикул товара] = ' " + s1 + " ', [Отдел] = ' " + s2 + " ', [Дата продажи] = ' " + s3 + " ', [Количество] = ' " + s4 + " ' where [Артикул товара] = ' " + s1;



        }
    }
}
