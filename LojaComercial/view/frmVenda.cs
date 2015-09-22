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
    public partial class FrmVenda : Form
    {
        private double total = 0;

        public FrmVenda()
        {
            InitializeComponent();

            new ToolTip().SetToolTip(imgLogOut, "LogOut");
            new ToolTip().SetToolTip(imgAddOperador, "Consulta operadores");
            new ToolTip().SetToolTip(imgAddProduto, "Consulta produtos");
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            lblOperador.Text = Global.Operador.Nome;

            if (Global.Operador.Tipo == 0)
            {
                imgAddOperador.Visible = true;
            }
            else
            {
                imgAddOperador.Visible = false;
            }

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

                lstProdutos.Items.Clear();

                total = 0;
                lblTotal.Text = "0,00";

                novoProduto();
            }
           
        }

        private void novoProduto()
        {
            txtQuantidade.Text = "1";
            txtProduto.Text = "";

            txtProduto.Focus();

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

        private void imgAddOperador_Click(object sender, EventArgs e)
        {
            FrmConsultaOperadores frmConsultaOperadores = new FrmConsultaOperadores();

            frmConsultaOperadores.ShowDialog();
        }

        private void imgAddProduto_Click(object sender, EventArgs e)
        {
            FrmConsultaProdutos frmConsultaProdutos = new FrmConsultaProdutos();

            Global.Produto = null;

            frmConsultaProdutos.ShowDialog();

            if (Global.Produto != null)
            {
                VendaProduto vendaProduto = new VendaProduto();

                vendaProduto.Produto    = Global.Produto;
                vendaProduto.PrecoVenda = Global.Produto.PrecoVenda;
                vendaProduto.Quantidade = Int32.Parse(txtQuantidade.Text);

                lstProdutos.Items.Add(vendaProduto);

                total += vendaProduto.Quantidade * vendaProduto.PrecoVenda;

                lblTotal.Text = total.ToString("N2");

                novoProduto();
            }
        }
    }
}
