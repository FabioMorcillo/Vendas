namespace LojaComercial.view
{
    partial class FrmFornecedor
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCancelar)).BeginInit();
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
            this.panel1.TabIndex = 33;
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
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 115);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(579, 22);
            this.txtNome.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nome";
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 167);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "FrmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFornecedor";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgCadastrar;
        private System.Windows.Forms.PictureBox imgCancelar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
    }
}