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
    public partial class FormListaClientes : Form
    {
        public FormListaClientes()
        {
            InitializeComponent();
            dgvLista.AutoGenerateColumns = false;

            VendasEntities model = new VendasEntities();
            dgvLista.DataSource = new BindingSource(model.Clientes, null);

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadCliente form = new FormCadCliente();
            form.ShowDialog();

            using (VendasEntities model = new VendasEntities())
            {
                dgvLista.DataSource = new BindingSource(model.Clientes, null);
            }
        }
    }
}
