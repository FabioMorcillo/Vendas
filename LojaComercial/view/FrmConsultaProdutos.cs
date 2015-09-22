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
    public partial class FrmConsultaProdutos : Form
    {
        public FrmConsultaProdutos()
        {
            InitializeComponent();

            this.Text = "Produtos";

            new ToolTip().SetToolTip(imgFechar, "Fechar");
            new ToolTip().SetToolTip(imgInsert, "Cadastrar produto");
            new ToolTip().SetToolTip(imgEdit, "Editar produto");
            new ToolTip().SetToolTip(imgDelete, "Deletar produto");

            dataGridView1.AutoGenerateColumns = false;
        }

        private void imgFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgDelete_Click(object sender, EventArgs e)
        {
            int id = 0;

            try
            {
                id = Int32.Parse(dataGridView1["id", dataGridView1.CurrentRow.Index].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Nenhum produto selecionado !");

                return;
            }

            if (id > 0)
            {
                DialogResult resultado = MessageBox.Show("Deletar produto " + dataGridView1["descricao", dataGridView1.CurrentRow.Index].Value.ToString() + " ?", "Confirmação", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    ProdutoController.deletar(new Produto(id));

                    atualizarRegistros();
                }
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado !");
            }
        }

        private void imgEdit_Click(object sender, EventArgs e)
        {
            int id = 0;

            try
            {
                id = Int32.Parse(dataGridView1["id", dataGridView1.CurrentRow.Index].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Nenhum produto selecionado !");

                return;
            }

            if (id > 0)
            {
                FrmProduto frmProduto = new FrmProduto();

                Produto produto = ProdutoController.busca(id);

                if (produto != null)
                {
                    frmProduto.inicializar(produto);

                    frmProduto.ShowDialog();

                    atualizarRegistros();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado !");

                    atualizarRegistros();
                }
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado !");
            }
        }

        private void imgInsert_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();

            frmProduto.inicializar(null);

            frmProduto.ShowDialog();

            atualizarRegistros();
        }

        private void FrmConsultaProdutos_Load(object sender, EventArgs e)
        {
            atualizarRegistros();
        }

        private void atualizarRegistros()
        {
            dataGridView1.DataSource = ProdutoController.lista();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;

            try
            {
                id = Int32.Parse(dataGridView1["id", dataGridView1.CurrentRow.Index].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Nenhum produto selecionado !");

                return;
            }

            if (id > 0)
            {
                FrmProduto frmProduto = new FrmProduto();

                Produto produto = ProdutoController.busca(id);

                if (produto != null)
                {
                    Global.Produto = produto;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado !");

                    atualizarRegistros();
                }
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado !");
            }
        }
    }
}
