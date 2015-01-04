using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void tmsCadastroCliente_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastroCliente = new FormCadastro();
            formCadastroCliente.ShowDialog();
        }

        private void tmsListaClientes_Click(object sender, EventArgs e)
        {
            FormListaClientes formListaCliente = new FormListaClientes();
            formListaCliente.ShowDialog();
        }

        private void MenuItemWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:49203/FormCliente.htm");
        }


    }
}
