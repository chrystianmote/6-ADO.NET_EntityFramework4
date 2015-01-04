using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Marcos.Trabalho
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Pedido = new Pedido();
            Pedido.Itens = new List<ItemPedido>();
            dgvItens.AutoGenerateColumns = false;
        }
        private Pedido Pedido { get; set; }


        private void btnItem_Click(object sender, EventArgs e)
        {
            FormNovoItem form = new FormNovoItem();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ItemPedido ip = new ItemPedido()
                {
                    IdProduto = Convert.ToInt32(form.cbxProduto.SelectedValue),
                    Quantidade = Convert.ToInt32(form.txtQtde.Text),
                    ValorUnitario = Convert.ToDecimal(form.txtValorUnit.Text),
                    Produto = form.cbxProduto.SelectedItem as Produto
                };
                Pedido.Itens.Add(ip);

                dgvItens.DataSource = new BindingSource(Pedido.Itens, null);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Pedido.Cliente = txtCliente.Text;
            Pedido.DataHora = DateTime.Now;
            Pedido.Status = "Pendente";
            Pedido.VatorTotal = Pedido.Itens.Sum(x => x.Subtotal);
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Vendas.mdf;Integrated Security=True;User Instance=True"))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO Pedido ");
                sql.Append("VALUES (@DataHora, @Cliente, @ValorTotal, @Status);  SELECT SCOPE_IDENTITY(); ");

                con.Open();
                SqlTransaction trans = con.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand(sql.ToString(), con, trans);
                    cmd.Parameters.AddWithValue("@DataHora", Pedido.DataHora);
                    cmd.Parameters.AddWithValue("@Cliente", Pedido.Cliente);
                    cmd.Parameters.AddWithValue("@ValorTotal", Pedido.VatorTotal);
                    cmd.Parameters.AddWithValue("@Status", Pedido.Status);

                    int idPedido = Convert.ToInt32(cmd.ExecuteScalar());

                    SqlCommand cmditem = new SqlCommand("INSERT INTO ItemPedido VALUES(@IdPedido,@IdProduto,@Quantidade,@ValorUnitario)", con, trans);
                    foreach (ItemPedido ip in Pedido.Itens)
                    {
                        cmditem.Parameters.Clear();
                        cmditem.Parameters.AddWithValue("@IdPedido", idPedido);
                        cmditem.Parameters.AddWithValue("@IdProduto", ip.IdProduto);
                        cmditem.Parameters.AddWithValue("@Quantidade", ip.Quantidade);
                        cmditem.Parameters.AddWithValue("@ValorUnitario", ip.ValorUnitario);

                        cmditem.ExecuteNonQuery();

                    }
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();

                    MessageBox.Show(ex.Message, "Erro!");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FormProdutos form = new FormProdutos();
            form.ShowDialog();
        }

    }
}