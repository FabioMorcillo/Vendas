﻿using LojaComercial.controller;
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
    public partial class FrmVenda : Form
    {
        public FrmVenda()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            NovaVenda();
        }

        private void NovaVenda()
        {
            int numeroUltimaNota = VendaController.numeroUltimaNota();

            if (numeroUltimaNota == -1)
            {
                MessageBox.Show("Erro ao localizar última nota !");
                return;
            }
            else
            {
                txtNumeroNota.Text = (numeroUltimaNota+1).ToString();
                txtQuantidade.Text = "1";
                txtProduto.Text = "";

                txtProduto.Focus();
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void FrmVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmLogin)Global.MainForm).inicializar();

            Global.MainForm.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            NovaVenda();
        }

        
    }
}