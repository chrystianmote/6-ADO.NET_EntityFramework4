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
    public partial class FormListaClientes : Form
    {
        public FormListaClientes()
        {
            InitializeComponent();
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            AtualizarListaNoGrid();
        }
        private void AtualizarListaNoGrid()
        {
            using (VendasEntities Modelo = new VendasEntities())
            {
                this.dgvListarClientes.DataSource =
                    new BindingSource(Modelo.Cliente.ToList(), null);
            }
        }


        private void dgvListarClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Alterar?", "Confirmação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (VendasEntities modelo = new VendasEntities())
                {
                    Cliente cli = this.dgvListarClientes.Rows[e.RowIndex].DataBoundItem as Cliente;
                    FormCadastro f = new FormCadastro(cli);
                    f.ShowDialog();
                }
                AtualizarListaNoGrid();
            }

        }


        private void dgvListarClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (VendasEntities modelo = new VendasEntities())
            {
                if (MessageBox.Show("Deseja realmente Excluir?", "Confirmação", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cliente cli = this.dgvListarClientes.Rows[e.RowIndex].DataBoundItem as Cliente;
                    Cliente c = modelo.Cliente.FirstOrDefault(cl => cli.IdCliente == cl.IdCliente);
                    modelo.Cliente.DeleteObject(c);
                    modelo.SaveChanges();
                }
            }
            AtualizarListaNoGrid();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro();
            form.ShowDialog();
            AtualizarListaNoGrid();
        }

    }
}
