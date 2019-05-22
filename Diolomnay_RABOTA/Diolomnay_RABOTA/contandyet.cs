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
    public partial class contandyet : Form
    {
        SqlConnection ConnectionString = new SqlConnection("Data Source = (Local);Initial Catalog = Demo_ex;Integrated Security = True");
        DataSet ds;
        SqlDataAdapter sda;

        public contandyet()
        {
            InitializeComponent();
        }

        private void contandyet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet2.Заказы_сотрудников". При необходимости она может быть перемещена или удалена.
            this.заказы_сотрудниковTableAdapter.Fill(this.diplomDataSet2.Заказы_сотрудников);

        }

        private void contandyet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow items in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(items.Index);
            }
            this.button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "Select * from Заказы_сотрудников";

            sda = new SqlDataAdapter(query, ConnectionString);
            ds = new DataSet();

            DataSet changes = ds.GetChanges();
            if (changes != null)
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                builder.GetInsertCommand();
                int updateRows = sda.Update(changes, "Заказы_сотрудников");
                ds.AcceptChanges();
            }
        }
    }
}
