using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Diolomnay_RABOTA
{
    public partial class shag_two : Form
    {
        SqlConnection ConnectionString = new SqlConnection("Data Source = (Local);Initial Catalog = Diplom;Integrated Security = True");

        public shag_two()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet1.Описание_работы". При необходимости она может быть перемещена или удалена.
            this.описание_работыTableAdapter.Fill(this.diplomDataSet1.Описание_работы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet1.Работа". При необходимости она может быть перемещена или удалена.
            this.работаTableAdapter1.Fill(this.diplomDataSet1.Работа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Работа". При необходимости она может быть перемещена или удалена.
            this.работаTableAdapter.Fill(this.diplomDataSet.Работа);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                ConnectionString.Open();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Заказы_сотрудников (Номер, Вид, Тип, Стоимость, Время) VALUES (@Номер, @Вид, @Тип, @Стоимость, @Время)", ConnectionString);
                    command.Parameters.AddWithValue("Номер", "3");
                    command.Parameters.AddWithValue("@Вид", comboBox1.Text);
                    command.Parameters.AddWithValue("@Тип", comboBox2.Text);
                    command.Parameters.AddWithValue("@Стоимость", comboBox3.Text);
                    command.Parameters.AddWithValue("@Время", comboBox4.Text);
                    int regged = Convert.ToInt32(command.ExecuteNonQuery());
                    ConnectionString.Close();

                    Form fg = new spasibo();
                    fg.Show();
                    this.Close();

                }
                catch
                {
                    MessageBox.Show("Такой заказ уже имеется!");

                }

                ConnectionString.Close();

        }

    }
}
