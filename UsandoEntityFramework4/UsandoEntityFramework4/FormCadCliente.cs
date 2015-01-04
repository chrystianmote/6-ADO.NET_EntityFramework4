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
    public partial class FormCadCliente : Form
    {
        public FormCadCliente()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (VendasEntities model = new VendasEntities())
            {
                Cliente c = new Cliente();
                c.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                c.Nome = txtNome.Text;
                c.LimiteCredito = Convert.ToDecimal(txtLimCred.Text);
                c.Telefone = txtTelefone.Text;
                c.Cidade = txtCidade.Text;
                c.Estado = cbxUF.SelectedItem.ToString();
                c.Email = txtEmail.Text;
                model.Clientes.AddObject(c);
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
