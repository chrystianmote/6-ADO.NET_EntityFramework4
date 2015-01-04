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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
            dgvProdutos.AutoGenerateColumns = false;
            AtualizarGrid();
        }


        private void AtualizarGrid()
        {
            List<Produto> Produtos = new List<Produto>();
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Vendas.mdf;Integrated Security=True;User Instance=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Produto", con);
                con.Open();
                SqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        Produto p = new Produto()
                        {
                            IdProduto = Convert.ToInt32(leitor["IdProduto"].ToString()),
                            Nome = leitor["Nome"].ToString(),
                            Preco = Convert.ToDecimal(leitor["Preco"].ToString()),
                            Estoque = Convert.ToInt32(leitor["Estoque"])

                        };
                        Produtos.Add(p);
                    }
                }
                dgvProdutos.DataSource = new BindingSource(Produtos, null);

            }
        }



        private void dgvProdutos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                // Clicando duas vezes com o botão  esquerdo
                Produto p = this.dgvProdutos.Rows[e.RowIndex].DataBoundItem as Produto;
                FormCadastroProduto formu = new FormCadastroProduto();
                formu.AlterarProduto = p;
                formu.ShowDialog();
            }
            if (MouseButtons.Right == e.Button)
            {
                // Clicando duas vezes com o botão  direito
                Produto p = this.dgvProdutos.Rows[e.RowIndex].DataBoundItem as Produto;
                using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Vendas.mdf;Integrated Security=True;User Instance=True"))
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append("DELETE FROM Produto WHERE IdProduto = @IdProduto;");

                    SqlCommand cmd = new SqlCommand(sql.ToString(), con);
                    cmd.Parameters.AddWithValue("@IdProduto", p.IdProduto);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            AtualizarGrid();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formulario = new FormCadastroProduto();
            formulario.ShowDialog();
        }



    }
}
