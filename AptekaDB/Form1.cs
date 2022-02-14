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

namespace AptekaDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl2.DrawItem += new DrawItemEventHandler(tabControl2_DrawItem);
            tabControl3.DrawItem += new DrawItemEventHandler(tabControl3_DrawItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseworkDataSet.Сотрудники_с_высшим_образованием". При необходимости она может быть перемещена или удалена.
            this.сотрудники_с_высшим_образованиемTableAdapter.Fill(this.courseworkDataSet.Сотрудники_с_высшим_образованием);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseworkDataSet.Препараты_на_букву_Ф". При необходимости она может быть перемещена или удалена.
            this.препараты_на_букву_ФTableAdapter.Fill(this.courseworkDataSet.Препараты_на_букву_Ф);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseworkDataSet.Вывод_ближайших_поставок_препаратов". При необходимости она может быть перемещена или удалена.
            this.вывод_ближайших_поставок_препаратовTableAdapter.Fill(this.courseworkDataSet.Вывод_ближайших_поставок_препаратов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseworkDataSet.Вывод_ближайших_поставок_препаратов". При необходимости она может быть перемещена или удалена.
            this.вывод_ближайших_поставок_препаратовTableAdapter.Fill(this.courseworkDataSet.Вывод_ближайших_поставок_препаратов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseworkDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.courseworkDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseworkDataSet.Рецепты". При необходимости она может быть перемещена или удалена.
            this.рецептыTableAdapter.Fill(this.courseworkDataSet.Рецепты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseworkDataSet.Препараты_по_рецептам". При необходимости она может быть перемещена или удалена.
            this.препараты_по_рецептамTableAdapter.Fill(this.courseworkDataSet.Препараты_по_рецептам);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseworkDataSet.Препараты". При необходимости она может быть перемещена или удалена.
            this.препаратыTableAdapter.Fill(this.courseworkDataSet.Препараты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseworkDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.courseworkDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseworkDataSet.Поставляемые_препараты". При необходимости она может быть перемещена или удалена.
            this.поставляемые_препаратыTableAdapter.Fill(this.courseworkDataSet.Поставляемые_препараты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseworkDataSet.Поставки". При необходимости она может быть перемещена или удалена.
            this.поставкиTableAdapter.Fill(this.courseworkDataSet.Поставки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseworkDataSet.Отпуска". При необходимости она может быть перемещена или удалена.
            this.отпускаTableAdapter.Fill(this.courseworkDataSet.Отпуска);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseworkDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.courseworkDataSet.Отделы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseworkDataSet.Зарплаты". При необходимости она может быть перемещена или удалена.
            this.зарплатыTableAdapter.Fill(this.courseworkDataSet.Зарплаты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseworkDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.courseworkDataSet.Должности);

        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl2_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl2.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl2.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.LightGray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 11.5f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void tabControl3_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl3.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl3.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.LightGray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 11.5f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.;AttachDbFilename=C:\Database\AptekaDB\Coursework.mdf;Integrated Security=True;Connect Timeout=30";        
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("Insert Into Препараты (Препарат, Цена) Values(@Preparat, @Cena)", connection);
                command.Parameters.AddWithValue("@Preparat", textBox1.Text);
                command.Parameters.AddWithValue("@Cena", textBox2.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(
                    "Добавлена запись в таблицу Препараты",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                    );

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.;AttachDbFilename=C:\Database\AptekaDB\Coursework.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("DELETE FROM Препараты WHERE Препарат = @Preparat", connection);
                command.Parameters.AddWithValue("@Preparat", textBox4.Text);

                try
                {
                    command.ExecuteNonQuery();                    
                    MessageBox.Show(
                        "Удалена запись из таблицы Препараты",
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1
                        );
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Такого препарата нет в таблице!", ex);
                    throw error;                   
                }
                connection.Close();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.;AttachDbFilename=C:\Database\AptekaDB\Coursework.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("UPDATE Препараты SET Цена = @Cena WHERE Препарат = @Preparat", connection);
                command.Parameters.AddWithValue("@Preparat", textBox5.Text);
                command.Parameters.AddWithValue("@Cena", textBox3.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(
                    "Изменена запись в таблице Препараты",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                    );

            }
        }

        private void инфоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                    @"Файл C:\Database\AptekaDB\Coursework.mdf является исходником базы данных Аптека. База данных содержит 11 таблиц, 3 представления и 3 хранимых процедуры",
                    "Инфо",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                    );
        }
    } 
}
