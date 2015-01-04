using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsandoEntityFramework4
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FormListaCategorias form = new FormListaCategorias();
            form.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormListaProdutos form = new FormListaProdutos();
            form.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormListaClientes form = new FormListaClientes();
            form.ShowDialog();
        }
    }
}
