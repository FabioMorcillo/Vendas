using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComercial.model
{
    class Operador
    {
        private int id;
        private String senha;
        private int tipo;
        private String nome;
        private String endereco;
        private String telefone;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Senha
        {
            get { return senha; }
            set { senha = value; }

        }
        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}
