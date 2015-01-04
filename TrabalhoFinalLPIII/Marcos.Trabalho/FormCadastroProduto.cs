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
    public partial class FormCadastroProduto : Form
    {
        public object AlterarProduto;

        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            this.AlterandoNoFormulario();
        }

        private void AlterandoNoFormulario()
        {
            if (this.AlterarProduto != null)
            {
                Produto prod = AlterarProduto as Produto;
                txtId.Enabled = false;
                txtId.Text = prod.IdProduto.ToString();
                txtNome.Text = prod.Nome.ToString();
                txtPreco.Text = prod.Preco.ToString();
                txtEstoque.Text = prod.Estoque.ToString();
            }
        }


        private void bnCadastrar_Click(object sender, EventArgs e)
        {
            if (this.AlterarProduto != null)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Vendas.mdf;Integrated Security=True;User Instance=True"))
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append("UPDATE Produto SET ");
                    sql.Append("Nome = @Nome, Preco = @Preco, Estoque = @Estoque ");
                    sql.Append("WHERE IdProduto = @IdProduto;");

                    SqlCommand cmd = new SqlCommand(sql.ToString(), con);
                    cmd.Parameters.AddWithValue("@IdProduto", Convert.ToInt32(txtId.Text));
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@Preco", Convert.ToDecimal(txtPreco.Text));
                    cmd.Parameters.AddWithValue("@Estoque", Convert.ToInt32(txtEstoque.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Vendas.mdf;Integrated Security=True;User Instance=True"))
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append("INSERT INTO Produto (IdProduto, Nome, Preco, Estoque) ");
                    sql.Append("VALUES (@IdProduto, @Nome, @Preco, @Estoque)");

                    SqlCommand cmd = new SqlCommand(sql.ToString(), con);
                    cmd.Parameters.AddWithValue("@IdProduto", Convert.ToInt32(txtId.Text));
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@Preco", Convert.ToDecimal(txtPreco.Text));
                    cmd.Parameters.AddWithValue("@Estoque", Convert.ToInt32(txtEstoque.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            this.Close();
        }

        
    }
}
