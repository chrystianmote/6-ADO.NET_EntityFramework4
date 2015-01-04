using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;

namespace WindowsApp
{
    public partial class FormCadastro : Form
    {
        private object Clients;

        public FormCadastro( object Cli = null)
        {
            InitializeComponent();
            if (Cli != null)
            {
                Clients = Cli;
                using (VendasEntities modelo = new VendasEntities())
                {
                    txtNome.Text = (Cli as Cliente).Nome;
                    txtRenda.Text = (Cli as Cliente).Renda.ToString();
                    dtpDataNasc.Value = (Cli as Cliente).DataNasc;
                }
                btnEnviar.Text = "Alterar";

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Cancelar?", "Confirmação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                using (VendasEntities Modelo = new VendasEntities())
                {
                    if (btnEnviar.Text == "Alterar")
                    {
                        Cliente cli = Clients as Cliente;
                        Cliente c = Modelo.Cliente.First(cl => cli.IdCliente == cl.IdCliente);
                        c.Nome = txtNome.Text;
                        c.Renda = Convert.ToDecimal(txtRenda.Text);
                        c.DataNasc = dtpDataNasc.Value;
                        Modelo.SaveChanges();
                    }
                    else
                    {
                        Cliente c = new Cliente()
                        {
                            Nome = txtNome.Text,
                            Renda = Convert.ToDecimal(txtRenda.Text),
                            DataNasc = dtpDataNasc.Value
                        };
                        Modelo.AddToCliente(c);
                        Modelo.SaveChanges();
                    }

                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cadastro Não Realizado.");
            }


        }
    }
}
