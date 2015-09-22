namespace LojaComercial.view
{
    partial class FrmProduto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgCadastrar = new System.Windows.Forms.PictureBox();
            this.imgCancelar = new System.Windows.Forms.PictureBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtDataValidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecoCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.imgAddFornecedor = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgCadastrar);
            this.panel1.Controls.Add(this.imgCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 73);
            this.panel1.TabIndex = 11;
            // 
            // imgCadastrar
            // 
            this.imgCadastrar.Image = global::LojaComercial.Properties.Resources.Actions_ok_icon;
            this.imgCadastrar.Location = new System.Drawing.Point(16, 12);
            this.imgCadastrar.Name = "imgCadastrar";
            this.imgCadastrar.Size = new System.Drawing.Size(48, 48);
            this.imgCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCadastrar.TabIndex = 8;
            this.imgCadastrar.TabStop = false;
            this.imgCadastrar.Click += new System.EventHandler(this.imgCadastrar_Click);
            // 
            // imgCancelar
            // 
            this.imgCancelar.Image = global::LojaComercial.Properties.Resources.Close_2_icon;
            this.imgCancelar.Location = new System.Drawing.Point(547, 12);
            this.imgCancelar.Name = "imgCancelar";
            this.imgCancelar.Size = new System.Drawing.Size(48, 48);
            this.imgCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCancelar.TabIndex = 7;
            this.imgCancelar.TabStop = false;
            this.imgCancelar.Click += new System.EventHandler(this.imgCancelar_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(16, 354);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(273, 22);
            this.txtQuantidade.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 333);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(82, 17);
            this.label.TabIndex = 19;
            this.label.Text = "Quantidade";
            // 
            // txtDataValidade
            // 
            this.txtDataValidade.Location = new System.Drawing.Point(16, 294);
            this.txtDataValidade.Name = "txtDataValidade";
            this.txtDataValidade.Size = new System.Drawing.Size(273, 22);
            this.txtDataValidade.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data de Validade";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Location = new System.Drawing.Point(16, 232);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(579, 22);
            this.txtCodBarras.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Código de Barras";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(16, 113);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(579, 22);
            this.txtDescricao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Descrição";
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.Location = new System.Drawing.Point(16, 416);
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Size = new System.Drawing.Size(273, 22);
            this.txtPrecoCompra.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Preço de Compra";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(16, 476);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(273, 22);
            this.txtPrecoVenda.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Preço de Venda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fornecedor";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(16, 171);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(539, 24);
            this.cbFornecedor.TabIndex = 2;
            // 
            // imgAddFornecedor
            // 
            this.imgAddFornecedor.Image = global::LojaComercial.Properties.Resources.add_icon__1_;
            this.imgAddFornecedor.Location = new System.Drawing.Point(573, 173);
            this.imgAddFornecedor.Name = "imgAddFornecedor";
            this.imgAddFornecedor.Size = new System.Drawing.Size(22, 22);
            this.imgAddFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAddFornecedor.TabIndex = 25;
            this.imgAddFornecedor.TabStop = false;
            this.imgAddFornecedor.Click += new System.EventHandler(this.imgAddFornecedor_Click);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 515);
            this.Controls.Add(this.imgAddFornecedor);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecoCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtDataValidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduto";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgCadastrar;
        private System.Windows.Forms.PictureBox imgCancelar;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtDataValidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecoCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.PictureBox imgAddFornecedor;
    }
}