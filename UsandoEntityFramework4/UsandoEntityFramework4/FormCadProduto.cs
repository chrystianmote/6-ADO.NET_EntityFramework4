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
    public partial class FormCadProduto : Form
    {
        public FormCadProduto()
        {
            InitializeComponent();
            VendasEntities model = new VendasEntities();
            cbxCategoria.DataSource = new BindingSource(model.Categorias, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (VendasEntities model = new VendasEntities())
            {
                Produto p = new Produto();
                p.Nome = txtNome.Text;
                p.Preco = Convert.ToDecimal(txtValor.Text);
                p.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                p.DataCadastro = DateTime.Now;
                model.Produtos.AddObject(p);
                model.SaveChanges();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
