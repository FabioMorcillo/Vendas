namespace LojaComercial.view
{
    partial class FrmConsultaProdutos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgDelete = new System.Windows.Forms.PictureBox();
            this.imgEdit = new System.Windows.Forms.PictureBox();
            this.imgInsert = new System.Windows.Forms.PictureBox();
            this.imgFechar = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 73);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(780, 427);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgDelete);
            this.panel1.Controls.Add(this.imgEdit);
            this.panel1.Controls.Add(this.imgInsert);
            this.panel1.Controls.Add(this.imgFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 73);
            this.panel1.TabIndex = 2;
            // 
            // imgDelete
            // 
            this.imgDelete.Image = global::LojaComercial.Properties.Resources.trash_icon;
            this.imgDelete.Location = new System.Drawing.Point(192, 12);
            this.imgDelete.Name = "imgDelete";
            this.imgDelete.Size = new System.Drawing.Size(48, 48);
            this.imgDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDelete.TabIndex = 10;
            this.imgDelete.TabStop = false;
            this.imgDelete.Click += new System.EventHandler(this.imgDelete_Click);
            // 
            // imgEdit
            // 
            this.imgEdit.Image = global::LojaComercial.Properties.Resources.edit_file_icon;
            this.imgEdit.Location = new System.Drawing.Point(102, 12);
            this.imgEdit.Name = "imgEdit";
            this.imgEdit.Size = new System.Drawing.Size(48, 48);
            this.imgEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEdit.TabIndex = 9;
            this.imgEdit.TabStop = false;
            this.imgEdit.Click += new System.EventHandler(this.imgEdit_Click);
            // 
            // imgInsert
            // 
            this.imgInsert.Image = global::LojaComercial.Properties.Resources.add_icon;
            this.imgInsert.Location = new System.Drawing.Point(12, 12);
            this.imgInsert.Name = "imgInsert";
            this.imgInsert.Size = new System.Drawing.Size(48, 48);
            this.imgInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInsert.TabIndex = 8;
            this.imgInsert.TabStop = false;
            this.imgInsert.Click += new System.EventHandler(this.imgInsert_Click);
            // 
            // imgFechar
            // 
            this.imgFechar.Image = global::LojaComercial.Properties.Resources.logout_icon;
            this.imgFechar.Location = new System.Drawing.Point(720, 12);
            this.imgFechar.Name = "imgFechar";
            this.imgFechar.Size = new System.Drawing.Size(48, 48);
            this.imgFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFechar.TabIndex = 7;
            this.imgFechar.TabStop = false;
            this.imgFechar.Click += new System.EventHandler(this.imgFechar_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "descricao";
            this.Nome.HeaderText = "DESCRIÇÃO";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // FrmConsultaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConsultaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaProdutos";
            this.Load += new System.EventHandler(this.FrmConsultaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgDelete;
        private System.Windows.Forms.PictureBox imgEdit;
        private System.Windows.Forms.PictureBox imgInsert;
        private System.Windows.Forms.PictureBox imgFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}