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
    public partial class vibor : Form
    {
        SqlConnection ConnectionString = new SqlConnection("Data Source = (Local);Initial Catalog = Diplom;Integrated Security = True");

        public vibor()
        {
            InitializeComponent();
        }

        private void vibor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void vibor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet2.Описание_работы". При необходимости она может быть перемещена или удалена.
            this.описание_работыTableAdapter.Fill(this.diplomDataSet2.Описание_работы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet2.Работа". При необходимости она может быть перемещена или удалена.
            this.работаTableAdapter.Fill(this.diplomDataSet2.Работа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet2.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.diplomDataSet2.Пользователи);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionString.Open();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Заказы_администратора (Номер, Фамилия, Вид, Тип, Стоимость) VALUES (@Номер, @Фамилия,@Вид, @Тип, @Стоимость)", ConnectionString);
                command.Parameters.AddWithValue("Номер", "2");
                command.Parameters.AddWithValue("@Фамилия", comboBox1.Text);
                command.Parameters.AddWithValue("@Вид", comboBox2.Text);
                command.Parameters.AddWithValue("@Тип", comboBox3.Text);
                command.Parameters.AddWithValue("@Стоимость", comboBox4.Text);

                int regged = Convert.ToInt32(command.ExecuteNonQuery());
                ConnectionString.Close();

                MessageBox.Show("Ваш заказ готов!");

            }
            catch
            {
                MessageBox.Show("Такой заказ уже имеется!");

            }

            ConnectionString.Close();

        }
    }
}
