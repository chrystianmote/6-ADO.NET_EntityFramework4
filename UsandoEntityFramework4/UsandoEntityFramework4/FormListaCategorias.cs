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
    public partial class FormListaCategorias : Form
    {
        public FormListaCategorias()
        {
            InitializeComponent();
            VendasEntities model = new VendasEntities();
            dgvLista.DataSource = new BindingSource(model.Categorias, null);

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadCategoria form = new FormCadCategoria();
            form.ShowDialog();
            using (VendasEntities model = new VendasEntities())
            {
                dgvLista.DataSource = new BindingSource(model.Categorias, null);
            }
        }
    }
}
