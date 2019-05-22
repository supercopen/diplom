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
    public partial class sotrudnik : Form
    {
        public sotrudnik()
        {
            InitializeComponent();
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void заказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form g = new Form5();
            g.Show();
            this.Close();
        }
    }
}
