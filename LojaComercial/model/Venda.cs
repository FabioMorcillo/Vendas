using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComercial.model
{
    class Venda
    {
        private int         id;
        private int         codNota;
        private Operador    operador;
        private DateTime    data;
        private List<VendaProduto> vendaProdutos;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int CodNota
        {
            get { return codNota; }
            set { codNota = value; }
        }

        public Operador Operador
        {
            get { return operador; }
            set { operador = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public List<VendaProduto> VendaProdutos
        {
            get { return vendaProdutos; }
            set { vendaProdutos = value; }
        }
    }
}
