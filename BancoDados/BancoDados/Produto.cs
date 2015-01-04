using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace BancoDados
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Inserir()
        {
            int afetados = 0;
            using (SqlConnection con = new SqlConnection(
                @"Data Source = .\SQLEXPRESS; Initial Catalog = Vendas;Integrated Security = true;"))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO Produto(Nome,Preco,DataCadastro) ");
                sql.Append("VALUES(@Nome,@Preco,@DataCadastro)");

                SqlCommand cmd = new SqlCommand(sql.ToString(), con);
                
                cmd.Parameters.AddWithValue("@Nome", this.Nome);
                cmd.Parameters.AddWithValue("@Preco", this.Preco);
                cmd.Parameters.AddWithValue("@DataCadastro", this.DataCadastro);
                con.Open();
                afetados = cmd.ExecuteNonQuery();
            }
            return (afetados > 0);
        }
        public bool Alterar()
        {
            int afetados = 0;
            using (SqlConnection con = new SqlConnection(
                @"Data Source = .\SQLEXPRESS; Initial Catalog = Vendas;Integrated Security = true;"))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE Produto set Nome = @Nome,Preco = @Preco,DataCadastro= @DataCadastro ");
                sql.Append("WHERE IdProduto = @IdProduto");

                SqlCommand cmd = new SqlCommand(sql.ToString(), con);

                cmd.Parameters.AddWithValue("@Nome", this.Nome);
                cmd.Parameters.AddWithValue("@Preco", this.Preco);
                cmd.Parameters.AddWithValue("@DataCadastro", this.DataCadastro);
                con.Open();
                afetados = cmd.ExecuteNonQuery();
            }
            return (afetados > 0);
        }
        public bool Excluir()
        {
            int afetados = 0;
            using (SqlConnection con = new SqlConnection(
                @"Data Source = .\SQLEXPRESS; Initial Catalog = Vendas;Integrated Security = true;"))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("DELETE FROM Produto ");
                sql.Append("WHERE IdProduto = @IdProduto");

                SqlCommand cmd = new SqlCommand(sql.ToString(), con);

                cmd.Parameters.AddWithValue("@IdProduto", this.IdProduto);

                con.Open();
                afetados = cmd.ExecuteNonQuery();
            }
            return (afetados > 0);
        }
        public List<Produto> ObterLista()
        {
            List<Produto> Produtos = new List<Produto>();
            using (SqlConnection con = new SqlConnection(
                @"Data Source = .\SQLEXPRESS; Initial Catalog = Vendas;Integrated Security = true;"))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM Produto");

                SqlCommand cmd = new SqlCommand(sql.ToString(), con);
                con.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                
                while (leitor.Read())
                {
                    Produto p = new Produto();
                    p.IdProduto = Convert.ToInt32(leitor["IdProduto"]);
                    p.Nome = leitor["Nome"].ToString();
                    p.Preco = Convert.ToInt32(leitor["Preco"]);
                    p.DataCadastro = Convert.ToDateTime(leitor["DataCadastro"]);
                    Produtos.Add(p);
                }
            }
            return Produtos;
        }

        public Produto ObterDetalhes(int idProduto)
        {
            Produto p = new Produto();
            using (SqlConnection con = new SqlConnection(
                @"Data Source = .\SQLEXPRESS; Initial Catalog = Vendas;Integrated Security = true;"))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM Produto ");
                sql.Append("WHERE IdProduto = @IdProduto");

                SqlCommand cmd = new SqlCommand(sql.ToString(), con);
                cmd.Parameters.AddWithValue("@IdProduto", idProduto);
                con.Open();

                SqlDataReader leitor = cmd.ExecuteReader();
                p.IdProduto = Convert.ToInt32(leitor["IdProduto"]);
                p.Nome = leitor["Nome"].ToString();
                p.Preco = Convert.ToInt32(leitor["Preco"]);
                p.DataCadastro = Convert.ToDateTime(leitor["DataCadastro"]);
                
            }
            return p;
        }
    }
}
