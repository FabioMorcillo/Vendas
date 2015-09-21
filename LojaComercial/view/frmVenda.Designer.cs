namespace LojaComercial.view
{
    partial class FrmVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOperador = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtNumeroNota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_Produto = new System.Windows.Forms.Panel();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_Total = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_Acao = new System.Windows.Forms.Panel();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.imgAddOperador = new System.Windows.Forms.PictureBox();
            this.imgLogOut = new System.Windows.Forms.PictureBox();
            this.imgAddProduto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel_Produto.SuspendLayout();
            this.panel_Total.SuspendLayout();
            this.panel_Acao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddOperador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 66);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.imgAddOperador);
            this.panel4.Controls.Add(this.lblHora);
            this.panel4.Controls.Add(this.lblData);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.imgLogOut);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(275, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(738, 66);
            this.panel4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Operador";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblOperador);
            this.panel2.Location = new System.Drawing.Point(118, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 44);
            this.panel2.TabIndex = 5;
            // 
            // lblOperador
            // 
            this.lblOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.ForeColor = System.Drawing.Color.White;
            this.lblOperador.Location = new System.Drawing.Point(3, 9);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(289, 25);
            this.lblOperador.TabIndex = 2;
            this.lblOperador.Text = "Teste";
            this.lblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 66);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOJA COMERCIAL";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(558, 35);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(153, 25);
            this.lblHora.TabIndex = 10;
            this.lblHora.Text = "10:10:10";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(558, 7);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(153, 25);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "01/01/2015";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel_Acao);
            this.panel5.Controls.Add(this.panel_Total);
            this.panel5.Controls.Add(this.panel_Produto);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(435, 457);
            this.panel5.TabIndex = 10;
            // 
            // lstProdutos
            // 
            this.lstProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.ItemHeight = 20;
            this.lstProdutos.Items.AddRange(new object[] {
            "1 x Item 1",
            "1 x Item 1",
            "1 x Item 1",
            "1 x Item 1",
            "1 x Item 1"});
            this.lstProdutos.Location = new System.Drawing.Point(435, 66);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(578, 457);
            this.lstProdutos.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtNumeroNota);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(435, 70);
            this.panel6.TabIndex = 18;
            // 
            // txtNumeroNota
            // 
            this.txtNumeroNota.Location = new System.Drawing.Point(14, 32);
            this.txtNumeroNota.Name = "txtNumeroNota";
            this.txtNumeroNota.Size = new System.Drawing.Size(109, 22);
            this.txtNumeroNota.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Número da Nota";
            // 
            // panel_Produto
            // 
            this.panel_Produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Produto.Controls.Add(this.imgAddProduto);
            this.panel_Produto.Controls.Add(this.txtQuantidade);
            this.panel_Produto.Controls.Add(this.label6);
            this.panel_Produto.Controls.Add(this.txtProduto);
            this.panel_Produto.Controls.Add(this.label5);
            this.panel_Produto.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Produto.Location = new System.Drawing.Point(0, 70);
            this.panel_Produto.Name = "panel_Produto";
            this.panel_Produto.Size = new System.Drawing.Size(435, 175);
            this.panel_Produto.TabIndex = 22;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(12, 49);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(109, 22);
            this.txtQuantidade.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quantidade";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(12, 107);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(372, 22);
            this.txtProduto.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Produto";
            // 
            // panel_Total
            // 
            this.panel_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Total.Controls.Add(this.lblTotal);
            this.panel_Total.Controls.Add(this.label7);
            this.panel_Total.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Total.Location = new System.Drawing.Point(0, 245);
            this.panel_Total.Name = "panel_Total";
            this.panel_Total.Size = new System.Drawing.Size(435, 112);
            this.panel_Total.TabIndex = 23;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(0, 23);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(433, 87);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "100,00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(433, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "TOTAL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Acao
            // 
            this.panel_Acao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Acao.Controls.Add(this.btnVender);
            this.panel_Acao.Controls.Add(this.btnCancelar);
            this.panel_Acao.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Acao.Location = new System.Drawing.Point(0, 357);
            this.panel_Acao.Name = "panel_Acao";
            this.panel_Acao.Size = new System.Drawing.Size(435, 64);
            this.panel_Acao.TabIndex = 24;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(300, 15);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(119, 36);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(14, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 36);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // imgAddOperador
            // 
            this.imgAddOperador.Image = global::LojaComercial.Properties.Resources.add_icon__1_;
            this.imgAddOperador.Location = new System.Drawing.Point(419, 14);
            this.imgAddOperador.Name = "imgAddOperador";
            this.imgAddOperador.Size = new System.Drawing.Size(32, 32);
            this.imgAddOperador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgAddOperador.TabIndex = 11;
            this.imgAddOperador.TabStop = false;
            // 
            // imgLogOut
            // 
            this.imgLogOut.Image = global::LojaComercial.Properties.Resources.logout_icon;
            this.imgLogOut.Location = new System.Drawing.Point(497, 11);
            this.imgLogOut.Name = "imgLogOut";
            this.imgLogOut.Size = new System.Drawing.Size(48, 48);
            this.imgLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLogOut.TabIndex = 6;
            this.imgLogOut.TabStop = false;
            this.imgLogOut.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imgAddProduto
            // 
            this.imgAddProduto.Image = global::LojaComercial.Properties.Resources.add_icon__1_;
            this.imgAddProduto.Location = new System.Drawing.Point(397, 107);
            this.imgAddProduto.Name = "imgAddProduto";
            this.imgAddProduto.Size = new System.Drawing.Size(22, 22);
            this.imgAddProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAddProduto.TabIndex = 19;
            this.imgAddProduto.TabStop = false;
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 523);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVenda_FormClosed);
            this.Load += new System.EventHandler(this.frmVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel_Produto.ResumeLayout(false);
            this.panel_Produto.PerformLayout();
            this.panel_Total.ResumeLayout(false);
            this.panel_Acao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAddOperador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgLogOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtNumeroNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_Produto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_Total;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_Acao;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox imgAddOperador;
        private System.Windows.Forms.PictureBox imgAddProduto;
    }
}