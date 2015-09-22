using LojaComercial.controller;
using LojaComercial.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaComercial.view
{
    public partial class FrmProduto : Form
    {
        private Boolean isCadastro;
        private Produto produto;

        public FrmProduto()
        {
            InitializeComponent();

            new ToolTip().SetToolTip(imgCadastrar, "Cadastrar");
            new ToolTip().SetToolTip(imgCancelar, "Cancelar");

            new ToolTip().SetToolTip(imgAddFornecedor, "Cadastrar fornecedor");
        }

        private void imgCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgCadastrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Descrição do produto não informado !");
                txtDescricao.Focus();
            }

            if (String.IsNullOrEmpty(txtCodBarras.Text))
            {
                MessageBox.Show("Código de Barras do produto não informado !");
                txtCodBarras.Focus();
            }

            if (String.IsNullOrEmpty(txtDataValidade.Text))
            {
                MessageBox.Show("Data de validade do produto não informado !");
                txtDataValidade.Focus();
            }

            if (String.IsNullOrEmpty(txtQuantidade.Text))
            {
                MessageBox.Show("Quantidade do produto não informado !");
                txtQuantidade.Focus();
            }

            if (String.IsNullOrEmpty(txtPrecoCompra.Text))
            {
                MessageBox.Show("Preço de compra do produto não informado !");
                txtPrecoCompra.Focus();
            }

            if (String.IsNullOrEmpty(txtPrecoVenda.Text))
            {
                MessageBox.Show("Preço de venda do produto não informado !");
                txtPrecoVenda.Focus();
            }

            Produto produto = new Produto();

            produto.Descricao       = txtDescricao.Text;
            produto.Fornecedor      = (Fornecedor)cbFornecedor.SelectedItem;
            produto.CodBarras       = txtCodBarras.Text;
            produto.DataValidade    = DateTime.Parse(txtDataValidade.Text);
            produto.Quantidade      = Int32.Parse(txtQuantidade.Text);
            produto.PrecoCompra     = Double.Parse(txtPrecoCompra.Text);
            produto.PrecoVenda      = Double.Parse(txtPrecoVenda.Text);

            if (isCadastro)
            {
                ProdutoController.cadastrar(produto);
            }
            else
            {
                produto.Id = this.produto.Id;

                ProdutoController.editar(produto);
            }

            this.Close();
        }

        public void inicializar(Produto produto)
        {
            this.produto = produto;

            isCadastro = produto == null;

            this.Text = "Produto - " + (isCadastro ? "Cadastro" : "Alteração");

            atualizarFornecedor();

            if (isCadastro)
            {
                txtDescricao.Text           = "";
                cbFornecedor.SelectedIndex  = -1;
                txtCodBarras.Text           = "";
                txtDataValidade.Text        = "";
                txtQuantidade.Text          = "";
                txtPrecoCompra.Text         = "";
                txtPrecoVenda.Text          = "";
            }
            else
            {
                txtDescricao.Text           = produto.Descricao;
                cbFornecedor.SelectedIndex  = cbFornecedor.FindString(produto.Fornecedor.Nome);
                txtCodBarras.Text           = produto.CodBarras;
                txtDataValidade.Text        = produto.DataValidade.ToString("dd/MM/yyyy");
                txtQuantidade.Text          = produto.Quantidade.ToString();
                txtPrecoCompra.Text         = produto.PrecoCompra.ToString("N2");
                txtPrecoVenda.Text          = produto.PrecoVenda.ToString("N2");
            }

            txtDescricao.Focus();
        }

        private void atualizarFornecedor()
        {
            cbFornecedor.DataSource = FornecedorController.lista();
            cbFornecedor.DisplayMember = "Nome";
            cbFornecedor.ValueMember = "Id";
        }

        private void imgAddFornecedor_Click(object sender, EventArgs e)
        {
            FrmConsultaFornecedores frmConsultaFornecedores = new FrmConsultaFornecedores();

            frmConsultaFornecedores.ShowDialog();

            atualizarFornecedor();

        }
    }
}
