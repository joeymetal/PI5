using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_Comercial
{
    class m_cliente
    {
        private int nCodigo;
        private string nNome;
        private string nCpf;
        private string nRg;
        private string nSexo;
        private string nEnd;
        private string nNumero;
        private string nComplemento_01;
        private string nBairro;
        private string nCidade;
        private string nUf;
        private string nCep;
        private string nTelefone;
        private string nTelefone_02;
        private string nEmail;
        private string nComplemento_02;
        //construção das propriedades
        public int codigo
        {
            get { return nCodigo; }
            set { nCodigo = value; }

        }

        public string nome
        {
            get { return nNome; }
            set { nNome = value; }
        }
        public string cpf
        {
            get { return nCpf; }
            set { nCpf = value; }
        }
        public string rg
        {
            get { return nRg; }
            set{ nRg =value;}
        }
        public string sexo
        {
            get { return nSexo; }
            set { nSexo = value; }
        }
        public string end
        {
            get { return nEnd; }
            set { nEnd = value; }
        }
        public string numero
        {
            get { return nNumero; }
            set { nNumero = value; }
        }
        public string complemento_01
        {
            get { return nComplemento_01; }
            set { nComplemento_01 = value; }
        }
        public string bairro
        {
            get { return nBairro; }
            set { nBairro = value; }
        }
        public string cidade
        {
            get { return nCidade; }
            set { nCidade = value; }
        }
        public string uf
        {
            get { return nUf; }
            set { nUf = value; }
        }
        public string cep
        {
            get { return nCep; }
            set { nCep = value; }
        }
        public string telefone
        {
            get { return nTelefone; }
            set { nTelefone = value; }
        }
        public string telefone_02
        {
            get { return nTelefone_02; }
            set { nTelefone_02 = value; }
        }
        public string email
        {
            get { return nEmail; }
            set { nEmail = value; }
        }
        public string complemento_02
        {
            get { return nComplemento_02; }
            set { nComplemento_02 = value; }
        }
    }
}