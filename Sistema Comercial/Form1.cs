using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_Comercial
{
    public partial class Form1 : Form
    {

        //SqlCeConnection sqlConn = null;
        //private string strConn = "Data Source="+@"C:\Users\Joey\Documents\SISCOM\Sistema Comercial\Sistema Comercial\DB.sdf";
        //private string strSql = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerificaStatusPessoa();
            //MessageBox.Show("Você esta conectado!");
           // Form2 a = new Form2();
            //a.Show();
        }

        //////

        public void VerificaStatusPessoa()
{
//SqlCeTransaction transacao;

    //string stringConexao = "Data Source=" + @"C:\Users\Joey\Documents\SISCOM\Sistema Comercial\Sistema Comercial\DB.sdf";
        string stringConexao =    @"Data Source=localhost;Initial Catalog=siscom;Integrated Security=True";
    SqlConnection conexao = new SqlConnection(stringConexao);

    try
    {
        conexao.Open();
        MessageBox.Show("Você esta conectado no banco!");

    }
    catch
    {
        MessageBox.Show("Não foi possível conectar no banco!");
        conexao.Close();
        Close();
    }

/*using (SqlCeDataAdapter a = new SqlCeDataAdapter(
"SELECT * FROM PESSOAS", conexao))
{
DataTable t = new DataTable();
a.Fill(t);
dgvReintegracao.DataSource = t;
}*/
}
        //////

        /*public void logar()
        {
            sqlConn = new SqlCeConnection(strConn);
            string usu;
            string pwd;
            //string tpu;
            try 
            {
                usu = txtLogin.Text;
                pwd = txtSenha.Text;
                //tbu = cbbTipo.Text;
               
                
                strSql = "SELECT COUNT(CodigoUsuario) FROM tblUsuario WHERE NomeUsuario = @NomeUsuario AND SenhaUsuario = @SenhaUsuario";
                SqlCeCommand cmd = new SqlCeCommand(strSql, sqlConn);
                cmd.Parameters.Add("@NomeUsuario", SqlDbType.NVarChar).Value = usu;
                cmd.Parameters.Add("@SenhaUsuario", SqlDbType.NVarChar).Value = pwd;
                sqlConn.Open();
                
                int v =(int)cmd.ExecuteScalar();
                if (v > 0)
                    {
                       MessageBox.Show("Logado ..");   
                    }
                    else
                    {
                    MessageBox.Show("Erro não logado");
                    } 
            }
            catch(SqlCeException error)
            {
                MessageBox.Show(error +" \n\nErro Banco ");
            }*/
        }
        //private void button1_Click(object sender, EventArgs e)
        //{

            /*/ if ()
             //{
                 MessageBox.Show("Você esta conectado!"); 
                 Form2 a = new Form2();
                 a.Show();
             /*/
             //else 
            // {
                 //MessageBox.Show("Você não esta conectado!"); 
             //}
            //logar();
            
        //}

    
}