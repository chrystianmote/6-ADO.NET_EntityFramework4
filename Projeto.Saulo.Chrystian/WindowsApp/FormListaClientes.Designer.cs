namespace WindowsApp
{
    partial class FormListaClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dgvListarClientes = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "- Clique Duplo esquerdo para Alterar";
            // 
            // btnInserir
            // 
            this.btnInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInserir.Location = new System.Drawing.Point(689, 16);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(56, 25);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Novo";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dgvListarClientes
            // 
            this.dgvListarClientes.AllowUserToAddRows = false;
            this.dgvListarClientes.AllowUserToDeleteRows = false;
            this.dgvListarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNome,
            this.clnDataNasc,
            this.clnRenda,
            this.btnExcluir});
            this.dgvListarClientes.Location = new System.Drawing.Point(29, 57);
            this.dgvListarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListarClientes.Name = "dgvListarClientes";
            this.dgvListarClientes.ReadOnly = true;
            this.dgvListarClientes.RowTemplate.Height = 24;
            this.dgvListarClientes.Size = new System.Drawing.Size(716, 271);
            this.dgvListarClientes.TabIndex = 4;
            this.dgvListarClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarClientes_CellContentClick);
            this.dgvListarClientes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarClientes_CellMouseDoubleClick);
            // 
            // clmCodigo
            // 
            this.clmCodigo.DataPropertyName = "IdCliente";
            this.clmCodigo.Frozen = true;
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmNome
            // 
            this.clmNome.DataPropertyName = "Nome";
            this.clmNome.Frozen = true;
            this.clmNome.HeaderText = "Nome";
            this.clmNome.Name = "clmNome";
            this.clmNome.ReadOnly = true;
            this.clmNome.Width = 250;
            // 
            // clnDataNasc
            // 
            this.clnDataNasc.DataPropertyName = "DataNasc";
            this.clnDataNasc.Frozen = true;
            this.clnDataNasc.HeaderText = "Data Nascimento";
            this.clnDataNasc.Name = "clnDataNasc";
            this.clnDataNasc.ReadOnly = true;
            this.clnDataNasc.Width = 150;
            // 
            // clnRenda
            // 
            this.clnRenda.DataPropertyName = "Renda";
            this.clnRenda.Frozen = true;
            this.clnRenda.HeaderText = "Renda";
            this.clnRenda.Name = "clnRenda";
            this.clnRenda.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "Exclusão";
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.ReadOnly = true;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.ToolTipText = "Excluir";
            this.btnExcluir.UseColumnTextForButtonValue = true;
            this.btnExcluir.Width = 70;
            // 
            // FormListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dgvListarClientes);
            this.Name = "FormListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.FormListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView dgvListarClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRenda;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluir;
    }
}