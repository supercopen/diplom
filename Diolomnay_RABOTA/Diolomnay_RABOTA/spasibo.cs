using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diolomnay_RABOTA
{
    public partial class spasibo : Form
    {
        public spasibo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form q = new Form5();
            q.Show();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form qwe = new picture();
            qwe.Show();

        }

        private void spasibo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form rt = new kontact();
            rt.Show();
        }
    }
}
