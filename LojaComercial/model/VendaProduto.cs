using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComercial.model
{
    class VendaProduto
    {
        private Produto produto;
        private int     quantidade;
        private double  precoVenda;

        public Produto Produto
        {
            get { return produto; }
            set { produto = value; }
        }
                
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public double PrecoVenda
        {
            get { return precoVenda; }
            set { precoVenda = value; }
        }
    }
}
