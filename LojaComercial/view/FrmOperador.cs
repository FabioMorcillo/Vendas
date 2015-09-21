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
    public partial class FrmOperador : Form
    {
        private Boolean isCadastro;
        private Operador operador;

        public FrmOperador()
        {
            InitializeComponent();

            new ToolTip().SetToolTip(imgCadastrar, "Cadastrar");
            new ToolTip().SetToolTip(imgCancelar, "Cancelar");
        }

        private void imgCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void imgCadastrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome do operador não informado !");
                txtNome.Focus();
            }

            if (String.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Endereço do operador não informado !");
                txtEndereco.Focus();
            }

            if (String.IsNullOrEmpty(txtTelefone.Text))
            {
                MessageBox.Show("Telefone do operador não informado !");
                txtTelefone.Focus();
            }

            if (String.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha do operador não informado !");
                txtSenha.Focus();
            }

            Operador operador = new Operador();

            operador.Nome       = txtNome.Text;
            operador.Endereco   = txtEndereco.Text;
            operador.Telefone   = txtTelefone.Text;
            operador.Senha      = txtSenha.Text;

            if (rb0.Checked)
                operador.Tipo = 0;
            else if (rb1.Checked)
                operador.Tipo = 1;
            else if (rb2.Checked)
                operador.Tipo = 2;

            if (isCadastro)
            {
                OperadorController.cadastrar(operador);
            }
            else
            {
                operador.Id = this.operador.Id;

                OperadorController.editar(operador);
            }

            this.Close();
        }

        public void inicializar(Operador operador)
        {
            this.operador = operador;

            isCadastro = operador == null;

            this.Text = "Operador - " + (isCadastro ? "Cadastro" : "Alteração");

            if (isCadastro)
            {
                txtNome.Text       = "";
                txtEndereco.Text   = "";
                txtTelefone.Text   = "";
                txtSenha.Text      = "";

                rb0.Checked = true;
            }
            else
            {
                txtNome.Text       = operador.Nome;
                txtEndereco.Text   = operador.Endereco;
                txtTelefone.Text   = operador.Telefone;
                txtSenha.Text      = operador.Senha;

                if (operador.Tipo == 0)
                    rb0.Checked = true;
                else if (operador.Tipo == 1)
                    rb1.Checked = true;
                else if (operador.Tipo == 2)
                    rb2.Checked = true;
            }

            txtNome.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb0_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
