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
    public partial class FormNovoItem : Form
    {
        public FormNovoItem()
        {
            InitializeComponent();
        }

        private void FormNovoItem_Load(object sender, EventArgs e)
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
                cbxProduto.DataSource = new BindingSource(Produtos, null);

            }

        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto p = this.cbxProduto.SelectedItem as Produto;
            txtValorUnit.Text = p.Preco.ToString();
        }

    }
}
