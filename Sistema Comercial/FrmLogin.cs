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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void tblUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUsuarioBindingSource.EndEdit();

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.tblUsuario' table. You can move, or remove it, as needed.
            //this.tblUsuarioTableAdapter.Fill(this.dBDataSet.tblUsuario);
            // TODO: This line of code loads data into the 'dBDataSet.tblUsuario' table. You can move, or remove it, as needed.
           // this.tblUsuarioTableAdapter.Fill(this.dBDataSet.tblUsuario);

        }

        private void tblUsuarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUsuarioBindingSource.EndEdit();

        }
    }
}
