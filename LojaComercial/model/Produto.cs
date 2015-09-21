using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComercial.model
{
    public class Produto
    {
        private int         id;
        private String      codBarras;
        private String      descricao;
        private Fornecedor  fornecedor;
        private DateTime    dataValidade;
        private int         quantidade;
        private double      precoCompra;
        private double      precoVenda;

        public Produto() { }

        public Produto(int id)
        {
            this.id = id;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String CodBarras
        {
            get { return codBarras; }
            set { codBarras = value; }
        }
        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public Fornecedor Fornecedor
        {
            get { return fornecedor; }
            set { fornecedor = value; }
        }

        public DateTime DataValidade
        {
            get { return dataValidade; }
            set { dataValidade = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public double PrecoCompra
        {
            get { return precoCompra; }
            set { precoCompra = value; }
        }

        public double PrecoVenda
        {
            get { return precoVenda; }
            set { precoVenda = value; }
        }

    }
}
