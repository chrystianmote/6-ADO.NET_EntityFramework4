using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marcos.Trabalho
{
    public class ItemPedido
    {
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }

        public string NomeProduto
        {
            get { return Produto.Nome; }
        }

        public decimal Subtotal
        {
            get { return Quantidade * ValorUnitario; }
        }
    }
}
