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
using System.IO;

namespace Diolomnay_RABOTA
{
    public partial class logpas : Form
    {

        string ConnectionString = @"Data Source = (Local); Initial catalog = Diplom; Integrated security = True";

        public logpas()
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
                button2_Click(sender, e);
            }

            if (e.KeyCode == Keys.Tab)
            {
                button1_Click(sender, e);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection q = new SqlConnection(ConnectionString);
            q.Open();
            SqlCommand qw = new SqlCommand(" Select * from Пользователи", q);
            qw.CommandText = "Select * from Пользователи Where Логин = '" + textBox1.Text + "' and Пароль = '" + textBox2.Text + "'";
            SqlDataReader qwe = qw.ExecuteReader();
            if (qwe.HasRows == true)
            {
                while (qwe.Read())
                {
                    string a = qwe["Должность"].ToString();

                    if (a == "Администратор")
                    {
                        Form ad = new admin();
                        ad.Show();
                        this.Close();

                        MessageBox.Show("Поздравляю вас с тем, что вы вошли как администратор ВКР!", "Помощник");

                    }

                    if (a == "Сотрудник")
                    {
                        Form da = new sotrudnik();
                        da.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Ваших данных нет в дипломной работе!", "Ошибка!");

                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form df = new reg();
            df.Show();
            this.Close();

            MessageBox.Show("Пройдите два шага! Для первого шага, вам надо зарегистрироваться в системе!", "Помощник");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
    }
}

