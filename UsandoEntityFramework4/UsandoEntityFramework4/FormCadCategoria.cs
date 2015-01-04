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
    public partial class FormCadCategoria : Form
    {
        public FormCadCategoria()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (VendasEntities model = new VendasEntities())
            {
                Categoria c = new Categoria();
                c.Descricao = txtDescricao.Text;

                model.Categorias.AddObject(c);
                model.SaveChanges();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
