using LojaComercial.controller;
using LojaComercial.model;
using LojaComercial.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaComercial
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            inicializar();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Operador operador = new Operador();

            operador.Nome = txtOperador.Text;
            operador.Senha = txtSenha.Text;

            if (OperadorController.credencialValida(operador))
            {
                txtOperador.Focus();

                this.Hide();

                FrmVenda frmVenda = new FrmVenda();

                frmVenda.Show();
            }
            else
            {
                MessageBox.Show("Login invalido !");

                txtOperador.Focus();
            }
        }

        public void inicializar()
        {
            txtOperador.Text = "";
            txtSenha.Text = "";

            txtOperador.Focus();
        }
    }
}
