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
    public partial class FrmConsultaOperadores : Form
    {
        public FrmConsultaOperadores()
        {
            InitializeComponent();

            this.Text = "Operadores";

            new ToolTip().SetToolTip(imgFechar, "Fechar");
            new ToolTip().SetToolTip(imgInsert, "Cadastrar operador");
            new ToolTip().SetToolTip(imgEdit, "Editar operador");
            new ToolTip().SetToolTip(imgDelete, "Deletar operador");

            dataGridView1.AutoGenerateColumns = false;
        }

        private void imgFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultaOperadores_Load(object sender, EventArgs e)
        {
            atualizarRegistros();
        }

        private void atualizarRegistros()
        {
            
            dataGridView1.DataSource = OperadorController.lista();
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
                MessageBox.Show("Nenhum operador selecionado !");

                return;
            }

            if (id > 0)
            {
                DialogResult resultado = MessageBox.Show("Deletar operador " + dataGridView1["nome", dataGridView1.CurrentRow.Index].Value.ToString() + " ?", "Confirmação", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    OperadorController.deletar(new Operador(id));

                    atualizarRegistros();
                }
            }            
            else
            {
                MessageBox.Show("Nenhum operador selecionado !");
            }
        }

        private void imgInsert_Click(object sender, EventArgs e)
        {
            FrmOperador frmOperador = new FrmOperador();

            frmOperador.inicializar(null);

            frmOperador.ShowDialog();
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
                MessageBox.Show("Nenhum operador selecionado !");

                return;
            }

            if (id > 0)
            {
                FrmOperador frmOperador = new FrmOperador();

                Operador operador = OperadorController.busca(id);

                if (operador != null)
                {
                    frmOperador.inicializar(operador);

                    frmOperador.ShowDialog();

                    atualizarRegistros();
                }
                else
                {
                    MessageBox.Show("Operador não encontrado !");

                    atualizarRegistros();
                }
            }
            else
            {
                MessageBox.Show("Nenhum operador selecionado !");
            }
            
        }
    }
}
