using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Sistema_Comercial
{
    class Conexao
    {
        
        private static string _usuario;

            private static string _sevidor;

            private static string _database;

            private static string _senha;

            private static string _porta;

            public string usuario
            {
                get { return _usuario; }
                set { _usuario = value; }
            }
            public string servidor
            {
                get {return _sevidor;}
                set {_sevidor = value;}
            }
            public string database 
            {
                get { return _database; }
                set { _database = value; }
            }
            public string senha
            {
                get { return _senha; }
                set { _senha = value; }
            }
            public string porta
            {
                get { return _porta; }
                set { _porta = value; }
            }
            
            //metodos
            public int conexaoDB(string query)
            {
                return 0;
            }

            public int inserirDB(string query)
            {
                return 0;
            }

            public int alterarDB(string query)
            {
                return 0;
            }

            public int atualizarDB(string query)
            {
                return 0;
            }

            public int deletarDB(string query)
            {
                return 0;
            }
	 
    }
}
