namespace WindowsApp
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.mspInicio = new System.Windows.Forms.MenuStrip();
            this.cadastroConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsCadastroCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsListaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.mspInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspInicio
            // 
            this.mspInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroConsultaToolStripMenuItem,
            this.MenuItemWeb});
            this.mspInicio.Location = new System.Drawing.Point(0, 0);
            this.mspInicio.Name = "mspInicio";
            this.mspInicio.Size = new System.Drawing.Size(463, 24);
            this.mspInicio.TabIndex = 0;
            this.mspInicio.Text = "MenuInicial";
            // 
            // cadastroConsultaToolStripMenuItem
            // 
            this.cadastroConsultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsCadastroCliente,
            this.tmsListaClientes});
            this.cadastroConsultaToolStripMenuItem.Name = "cadastroConsultaToolStripMenuItem";
            this.cadastroConsultaToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.cadastroConsultaToolStripMenuItem.Text = "Cadastro/Consulta";
            // 
            // tmsCadastroCliente
            // 
            this.tmsCadastroCliente.Name = "tmsCadastroCliente";
            this.tmsCadastroCliente.Size = new System.Drawing.Size(180, 22);
            this.tmsCadastroCliente.Text = "Cadastro de Cliente";
            this.tmsCadastroCliente.Click += new System.EventHandler(this.tmsCadastroCliente_Click);
            // 
            // tmsListaClientes
            // 
            this.tmsListaClientes.Name = "tmsListaClientes";
            this.tmsListaClientes.Size = new System.Drawing.Size(180, 22);
            this.tmsListaClientes.Text = "Lista de Clientes";
            this.tmsListaClientes.Click += new System.EventHandler(this.tmsListaClientes_Click);
            // 
            // MenuItemWeb
            // 
            this.MenuItemWeb.Name = "MenuItemWeb";
            this.MenuItemWeb.Size = new System.Drawing.Size(41, 20);
            this.MenuItemWeb.Text = "Web";
            this.MenuItemWeb.Click += new System.EventHandler(this.MenuItemWeb_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 435);
            this.Controls.Add(this.mspInicio);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mspInicio;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.mspInicio.ResumeLayout(false);
            this.mspInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspInicio;
        private System.Windows.Forms.ToolStripMenuItem cadastroConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmsCadastroCliente;
        private System.Windows.Forms.ToolStripMenuItem tmsListaClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuItemWeb;
    }
}

