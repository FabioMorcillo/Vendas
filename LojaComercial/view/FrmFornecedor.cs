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
    public partial class FrmFornecedor : Form
    {
        private Boolean isCadastro;
        private Fornecedor fornecedor;

        public FrmFornecedor()
        {
            InitializeComponent();

            new ToolTip().SetToolTip(imgCadastrar, "Cadastrar");
            new ToolTip().SetToolTip(imgCancelar, "Cancelar");
        }

        private void imgCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgCadastrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome do fornecedor não informado !");
                txtNome.Focus();
            }

            Fornecedor fornecedor = new Fornecedor();

            fornecedor.Nome = txtNome.Text;

            if (isCadastro)
            {
                FornecedorController.cadastrar(fornecedor);
            }
            else
            {
                fornecedor.Id = this.fornecedor.Id;

                FornecedorController.editar(fornecedor);
            }

            this.Close();
        }

        public void inicializar(Fornecedor fornecedor)
        {
            this.fornecedor = fornecedor;

            isCadastro = fornecedor == null;

            this.Text = "Fornecedor - " + (isCadastro ? "Cadastro" : "Alteração");

            if (isCadastro)
            {
                txtNome.Text = "";
            }
            else
            {
                txtNome.Text = fornecedor.Nome;
            }

            txtNome.Focus();
        }
    }
}
