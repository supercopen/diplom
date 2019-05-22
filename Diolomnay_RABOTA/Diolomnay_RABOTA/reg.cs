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
    public partial class reg : Form
    {
        SqlConnection ConnectionString = new SqlConnection("Data Source = (Local);Initial Catalog = Diplom;Integrated Security = True");

        public reg()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }

            if (e.KeyCode == Keys.Down)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBox1.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }

            if (e.KeyCode == Keys.Down)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBox2.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }

            if (e.KeyCode == Keys.Down)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBox3.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Focus();
            }

            if (e.KeyCode == Keys.Down)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBox4.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("Вы не правильно продублировали ваш пароль!", "Ошибка!");

                textBox5.Clear();
            }

            else
            {

                if ((textBox3.Text == "" && textBox5.Text == "") || (textBox3.Text == "" || textBox5.Text == ""))
                {
                    MessageBox.Show("Обязательно введите поля со звёздочкой!", "Ошибка!");
                }

                ConnectionString.Open();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Пользователи (Номер, Фамилия, Имя, Логин,Пароль,Должность) VALUES (@Номер, @Фамилия, @Имя, @Логин, @Пароль,@Должность)", ConnectionString);
                    command.Parameters.AddWithValue("Номер", "3");
                    command.Parameters.AddWithValue("@Фамилия", textBox1.Text);
                    command.Parameters.AddWithValue("@Имя", textBox2.Text);
                    command.Parameters.AddWithValue("@Логин", textBox3.Text);
                    command.Parameters.AddWithValue("@Пароль", textBox5.Text);
                    command.Parameters.AddWithValue("@Должность", "Сотрудник");
                    int regged = Convert.ToInt32(command.ExecuteNonQuery());
                    ConnectionString.Close();
                    MessageBox.Show("Пользователь успешно зарегистрировался!\n");

                    Form lp = new logpas();
                    lp.Show();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Такой пользователь существует!\n");

                }

                ConnectionString.Close();

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '0') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '0') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
    }
}
