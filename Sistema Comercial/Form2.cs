using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Comercial
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fx = new Form3();
            fx.MdiParent = this;
            fx.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fx = new Form4();
            fx.MdiParent = this;
            fx.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form5 fx = new Form5();
            fx.MdiParent = this;
            fx.Show();
        }

        private void financeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 fx = new Form6();
            fx.MdiParent = this;
            fx.Show();
        }
    }
}
