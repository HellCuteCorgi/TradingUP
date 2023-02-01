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
    public partial class Form2 : Form
    {

        static string connectionString = @"Data Source=HELLCUTECORGI\SQLEXPRESS; Initial catalog=TradingUP; Integrated Security=True";
        public SqlConnection Connection = new SqlConnection(connectionString);

        public Form2(string type, string name)
        {
            InitializeComponent();
            nameL.Text = name;
            roleL.Text = type;

            if (type == "Менеджер" || type == "Продавец")
            {
                roleTC.Controls.Remove(staffTP);
                if (type == "Продавец")
                {
                    roleTC.Controls.Remove(ordersTP);
                }
            }
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            string s2 = productsDataGridView[1, productsDataGridView.CurrentRow.Index].Value.ToString();
            string s3 = productsDataGridView[2, productsDataGridView.CurrentRow.Index].Value.ToString();
            string s4 = productsDataGridView[3, productsDataGridView.CurrentRow.Index].Value.ToString();
            string ComAdd = " INSERT INTO [Товары] ([Наименование], [Единица измерения], [Розничная цена]) VALUES(N'" + s2 + "', N'" + s3 + "', '" + s4 + "')";

            SqlCommand cmd2 = new SqlCommand(ComAdd, Connection);
            Connection.Open();
            cmd2.ExecuteNonQuery();
            Connection.Close();
            this.товарыTableAdapter.Fill(this.tradingUPDataSet.Товары);
        }

        private void changeButt_Click(object sender, EventArgs e)
        {
            int row = productsDataGridView.CurrentCell.RowIndex;
            string s1 = productsDataGridView[0, row].Value.ToString();
            if (productsDataGridView[1, productsDataGridView.CurrentRow.Index].Selected == true)
            {
                string s2 = productsDataGridView[1, productsDataGridView.CurrentRow.Index].Value.ToString();
                string ComUp = " update [Товары] set [Наименование] = N'" + s2 + "' where [Артикул товара] = " + s1;
                SqlCommand cmd1 = new SqlCommand(ComUp, Connection);
                Connection.Open();
                cmd1.ExecuteNonQuery();
                Connection.Close();
            }
            else if (productsDataGridView[2, productsDataGridView.CurrentRow.Index].Selected == true)
            {
                string s2 = productsDataGridView[2, productsDataGridView.CurrentRow.Index].Value.ToString();
                string ComUp = " update [Товары] set [Единица измерения] = N'" + s2 + "' where [Артикул товара] = " + s1;
                SqlCommand cmd2 = new SqlCommand(ComUp, Connection);
                Connection.Open();
                cmd2.ExecuteNonQuery();
                Connection.Close();
            }
            else if (productsDataGridView[3, productsDataGridView.CurrentRow.Index].Selected == true)
            {
                string s2 = productsDataGridView[3, productsDataGridView.CurrentRow.Index].Value.ToString();
                string ComUp = " update [Товары] set [Розничная цена] = N'" + s2 + "' where [Артикул товара] = " + s1;
                SqlCommand cmd3 = new SqlCommand(ComUp, Connection);
                Connection.Open();
                cmd3.ExecuteNonQuery();
                Connection.Close();
            }
            this.товарыTableAdapter.Fill(this.tradingUPDataSet.Товары);
        }

        private void delButt_Click(object sender, EventArgs e)
        {
            int row = productsDataGridView.CurrentCell.RowIndex;
            string s1 = productsDataGridView[0, row].Value.ToString();
            string ComDel = " Delete from [Товары] where [Артикул товара] = " + s1;

            SqlCommand cmd1 = new SqlCommand(ComDel, Connection);
            Connection.Open();
            cmd1.ExecuteNonQuery();
            Connection.Close();
            this.товарыTableAdapter.Fill(this.tradingUPDataSet.Товары);
        }

        private void addButt2_Click(object sender, EventArgs e)
        {
            string s2 = ordersDataGridView[1, ordersDataGridView.CurrentRow.Index].Value.ToString();
            string s3 = ordersDataGridView[2, ordersDataGridView.CurrentRow.Index].Value.ToString();
            string s4 = ordersDataGridView[3, ordersDataGridView.CurrentRow.Index].Value.ToString();
            string s5 = ordersDataGridView[4, ordersDataGridView.CurrentRow.Index].Value.ToString();
            string ComAdd = " INSERT INTO [Отделы] ([Наименование], [ФИО заведующего], [Телефон], [Объем реализации в день]) VALUES(N'" + s2 + "', N'" + s3 + "', N'" + s4 + "', '" + s5 + "')";

            SqlCommand cmd2 = new SqlCommand(ComAdd, Connection);
            Connection.Open();
            cmd2.ExecuteNonQuery();
            Connection.Close();
            this.отделыViewTableAdapter.Fill(this.tradingUPDataSet.ОтделыView);
        }

        private void changeButt2_Click(object sender, EventArgs e)
        {
            int row = ordersDataGridView.CurrentCell.RowIndex;
            string s1 = ordersDataGridView[0, row].Value.ToString();
            if (ordersDataGridView[1, ordersDataGridView.CurrentRow.Index].Selected == true)
            {
                string s2 = ordersDataGridView[1, ordersDataGridView.CurrentRow.Index].Value.ToString();
                string ComUp = " update [Отделы] set [Наименование] = N'" + s2 + "' where [Код] = " + s1;
                SqlCommand cmd1 = new SqlCommand(ComUp, Connection);
                Connection.Open();
                cmd1.ExecuteNonQuery();
                Connection.Close();
            }
            else if (ordersDataGridView[2, ordersDataGridView.CurrentRow.Index].Selected == true)
            {
                string s2 = productsDataGridView[2, productsDataGridView.CurrentRow.Index].Value.ToString();
                string ComUp = " update [Отделы] set [ФИО заведующего] = '" + s2 + "' where [Код] = " + s1;
                SqlCommand cmd2 = new SqlCommand(ComUp, Connection);
                Connection.Open();
                cmd2.ExecuteNonQuery();
                Connection.Close();
            }
            else if (ordersDataGridView[3, ordersDataGridView.CurrentRow.Index].Selected == true)
            {
                string s2 = productsDataGridView[3, productsDataGridView.CurrentRow.Index].Value.ToString();
                string ComUp = " update [Отделы] set [Телефон] = N'" + s2 + "' where [Код] = " + s1;
                SqlCommand cmd3 = new SqlCommand(ComUp, Connection);
                Connection.Open();
                cmd3.ExecuteNonQuery();
                Connection.Close();
            }
            else if (ordersDataGridView[4, ordersDataGridView.CurrentRow.Index].Selected == true)
            {
                string s2 = productsDataGridView[4, productsDataGridView.CurrentRow.Index].Value.ToString();
                string ComUp = " update [Отделы] set [Объем реализации в день] = N'" + s2 + "' where [Код] = " + s1;
                SqlCommand cmd4 = new SqlCommand(ComUp, Connection);
                Connection.Open();
                cmd4.ExecuteNonQuery();
                Connection.Close();
            }
            this.отделыViewTableAdapter.Fill(this.tradingUPDataSet.ОтделыView);
        }

        private void delButt2_Click(object sender, EventArgs e)
        {
            int row = productsDataGridView.CurrentCell.RowIndex;
            string s1 = productsDataGridView[0, row].Value.ToString();
            string ComDel = " Delete from [Отделы] where [Код] = " + s1;

            SqlCommand cmd1 = new SqlCommand(ComDel, Connection);
            Connection.Open();
            cmd1.ExecuteNonQuery();
            Connection.Close();
            this.отделыViewTableAdapter.Fill(this.tradingUPDataSet.ОтделыView);
        }

        private void addButt4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void addButt3_Click(object sender, EventArgs e)
        {
            string s1 = staffDataGridView[0, staffDataGridView.CurrentRow.Index].Value.ToString();
            string s2 = staffDataGridView[1, staffDataGridView.CurrentRow.Index].Value.ToString();
            string s3 = staffDataGridView[2, staffDataGridView.CurrentRow.Index].Value.ToString();
            string s4 = staffDataGridView[3, staffDataGridView.CurrentRow.Index].Value.ToString();
            string ComAdd = " INSERT INTO [Сотрудники] ([Логин], [Пароль], [ФИО], [Должнсть]) VALUES(N'" + s1 + "', N'" + s2 + "', N'" + s3 + "', N'" + s4 + "')";

            SqlCommand cmd2 = new SqlCommand(ComAdd, Connection);
            Connection.Open();
            cmd2.ExecuteNonQuery();
            Connection.Close();
            this.сотрудникиTableAdapter.Fill(this.tradingUPDataSet.Сотрудники);
        }

        private void changeButt3_Click(object sender, EventArgs e)
        {
            int row = staffDataGridView.CurrentCell.RowIndex;
            string s1 = staffDataGridView[0, row].Value.ToString();
            if (staffDataGridView[1, staffDataGridView.CurrentRow.Index].Selected == true)
            {
                string s2 = staffDataGridView[1, staffDataGridView.CurrentRow.Index].Value.ToString();
                string ComUp = " update [Сотрудники] set [Пароль] = N'" + s2 + "' where [Логин] = " + s1;
                SqlCommand cmd1 = new SqlCommand(ComUp, Connection);
                Connection.Open();
                cmd1.ExecuteNonQuery();
                Connection.Close();
            }
            else if (staffDataGridView[2, staffDataGridView.CurrentRow.Index].Selected == true)
            {
                string s2 = staffDataGridView[2, staffDataGridView.CurrentRow.Index].Value.ToString();
                string ComUp = " update [Сотрудники] set [ФИО] = N'" + s2 + "' where [Логин] = " + s1;
                SqlCommand cmd2 = new SqlCommand(ComUp, Connection);
                Connection.Open();
                cmd2.ExecuteNonQuery();
                Connection.Close();
            }
            else if (staffDataGridView[3, staffDataGridView.CurrentRow.Index].Selected == true)
            {
                string s2 = staffDataGridView[3, staffDataGridView.CurrentRow.Index].Value.ToString();
                string ComUp = " update [Сотрудники] set [Должнсть] = N'" + s2 + "' where [Логин] = " + s1;
                SqlCommand cmd3 = new SqlCommand(ComUp, Connection);
                Connection.Open();
                cmd3.ExecuteNonQuery();
                Connection.Close();
            }
            else if (staffDataGridView[4, staffDataGridView.CurrentRow.Index].Selected == true)
            {
                string s2 = staffDataGridView[4, staffDataGridView.CurrentRow.Index].Value.ToString();
                string ComUp = " update [Сотрудники] set [Отдел] = N'" + s2 + "' where [Логин] = " + s1;
                SqlCommand cmd4 = new SqlCommand(ComUp, Connection);
                Connection.Open();
                cmd4.ExecuteNonQuery();
                Connection.Close();
            }
            this.сотрудникиTableAdapter.Fill(this.tradingUPDataSet.Сотрудники);
        }

        private void delButt3_Click(object sender, EventArgs e)
        {
            int row = staffDataGridView.CurrentCell.RowIndex;
            string s1 = staffDataGridView[0, row].Value.ToString();
            string ComDel = " Delete from [Сотрудники] where [Логин] = " + s1;

            SqlCommand cmd1 = new SqlCommand(ComDel, Connection);
            Connection.Open();
            cmd1.ExecuteNonQuery();
            Connection.Close();
            this.сотрудникиTableAdapter.Fill(this.tradingUPDataSet.Сотрудники);
        }

        private void changeButt4_Click(object sender, EventArgs e)
        {
            int row = versionsDataGridView.CurrentCell.RowIndex;
            string s1 = versionsDataGridView[0, row].Value.ToString();
            string s2 = versionsDataGridView[1, row].Value.ToString();
            string s3 = versionsDataGridView[2, row].Value.ToString();
            string s4 = versionsDataGridView[3, row].Value.ToString();
            Form4 form4 = new Form4(s1, s2, s3, s4);
            form4.Show();
        }

        private void delButt4_Click(object sender, EventArgs e)
        {
            int row = versionsDataGridView.CurrentCell.RowIndex;
            string s1 = versionsDataGridView[0, row].Value.ToString();
            string s2 = versionsDataGridView[1, row].Value.ToString();
            string s3 = versionsDataGridView[2, row].Value.ToString();
            string s4 = versionsDataGridView[3, row].Value.ToString();
            string ComDel = " Delete from [Продажи] where [Артикул товара] = " + s1 + " AND [Отдел] = '" + s2 + "'AND [Дата продажи] = " + s3 + "AND [Количество] = '" + s4;

            SqlCommand cmd1 = new SqlCommand(ComDel, Connection);
            Connection.Open();
            cmd1.ExecuteNonQuery();
            Connection.Close();
            this.продажиTableAdapter.Fill(this.tradingUPDataSet.Продажи);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void versionsDataGridView_Click(object sender, EventArgs e)
        {
            string unit, name, price;
            string nameK, director, phone, volume;
            int row = versionsDataGridView.CurrentCell.RowIndex;
            string s1 = versionsDataGridView[0, row].Value.ToString();
            SqlCommand command1 = new SqlCommand("SELECT [Наименование] FROM [Товары] WHERE [Артикул товара] = '" + s1 + "'", Connection);
            SqlCommand command2 = new SqlCommand("SELECT [Единица измерения] FROM [Сотрудники] WHERE [Артикул товара] = '" + s1 + "'", Connection);
            SqlCommand command3 = new SqlCommand("SELECT [Розничная цена] FROM [Сотрудники] WHERE [Артикул товара] = '" + s1 + "'", Connection);

            string s2 = versionsDataGridView[1, row].Value.ToString();
            SqlCommand command4 = new SqlCommand("SELECT [Наименование] FROM [Отделы] WHERE [Код] = '" + s2 + "'", Connection);
            SqlCommand command5 = new SqlCommand("SELECT [ФИО заведующего] FROM [Отделы] WHERE [Код] = '" + s2 + "'", Connection);
            SqlCommand command6 = new SqlCommand("SELECT [Телефон] FROM [Отделы] WHERE [Код] = '" + s2 + "'", Connection);
            SqlCommand command7 = new SqlCommand("SELECT [Объем реализации в день] FROM [Отделы] WHERE [Код] = '" + s2 + "'", Connection);

            Connection.Open();
            name = (string)command1.ExecuteScalar();
            unit = (string)command2.ExecuteScalar();
            price = (string)command3.ExecuteScalar();

            nameK = (string)command4.ExecuteScalar();
            director = (string)command5.ExecuteScalar();
            phone = (string)command6.ExecuteScalar();
            volume = (string)command7.ExecuteScalar();
            Connection.Close();

            staffL.Text = "Наименование: " + name + "\nЕдиница измерения: " + unit + "\nРозничная цена: " + price;
            orderL.Text = "Наименование: " + nameK + "\nФИО заведующего: " + director + "\nТелефон: " + phone + "\nОбъем реализации в день: " + volume;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradingUPDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.tradingUPDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradingUPDataSet.Продажи". При необходимости она может быть перемещена или удалена.
            this.продажиTableAdapter.Fill(this.tradingUPDataSet.Продажи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradingUPDataSet.ОтделыView". При необходимости она может быть перемещена или удалена.
            this.отделыViewTableAdapter.Fill(this.tradingUPDataSet.ОтделыView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradingUPDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.tradingUPDataSet.Товары);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.продажиTableAdapter.Fill(this.tradingUPDataSet.Продажи);
        }
    }
}
