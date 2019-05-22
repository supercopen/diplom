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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void выборToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form q = new vibor();
            q.Show();
            this.Close();
        }

        private void учётИКонтрольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form w = new contandyet();
            w.Show();
            this.Close();
        }
    }
}
