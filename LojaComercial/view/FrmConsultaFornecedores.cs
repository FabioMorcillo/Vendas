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
    public partial class FrmConsultaFornecedores : Form
    {
        public FrmConsultaFornecedores()
        {
            InitializeComponent();

            this.Text = "Fornecedores";

            new ToolTip().SetToolTip(imgFechar, "Fechar");
            new ToolTip().SetToolTip(imgInsert, "Cadastrar fornecedor");
            new ToolTip().SetToolTip(imgEdit, "Editar fornecedor");
            new ToolTip().SetToolTip(imgDelete, "Deletar fornecedor");

            dataGridView1.AutoGenerateColumns = false;
        }

        private void atualizarRegistros()
        {
            dataGridView1.DataSource = FornecedorController.lista();
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
                MessageBox.Show("Nenhum fornecedor selecionado !");

                return;
            }

            if (id > 0)
            {
                DialogResult resultado = MessageBox.Show("Deletar fornecedor " + dataGridView1["nome", dataGridView1.CurrentRow.Index].Value.ToString() + " ?", "Confirmação", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    FornecedorController.deletar(new Fornecedor(id));

                    atualizarRegistros();
                }
            }
            else
            {
                MessageBox.Show("Nenhum fornecedor selecionado !");
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
                MessageBox.Show("Nenhum fornecedor selecionado !");

                return;
            }

            if (id > 0)
            {
                FrmFornecedor frmFornecedor = new FrmFornecedor();

                Fornecedor fornecedor = FornecedorController.busca(id);

                if (fornecedor != null)
                {
                    frmFornecedor.inicializar(fornecedor);

                    frmFornecedor.ShowDialog();

                    atualizarRegistros();
                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrado !");

                    atualizarRegistros();
                }
            }
            else
            {
                MessageBox.Show("Nenhum fornecedor selecionado !");
            }

        }

        private void imgInsert_Click(object sender, EventArgs e)
        {
            FrmFornecedor frmFornecedor = new FrmFornecedor();

            frmFornecedor.inicializar(null);

            frmFornecedor.ShowDialog();

            atualizarRegistros();

        }

        private void FrmConsultaFornecedores_Load(object sender, EventArgs e)
        {
            atualizarRegistros();
        }
    }
}
