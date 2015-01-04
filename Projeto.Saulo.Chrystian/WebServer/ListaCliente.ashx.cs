using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer
{
    /// <summary>
    /// Summary description for ListaCliente
    /// </summary>
    public class ListaCliente : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string CabecalhoEstatico = "<table border=\"1px\"><tr><th>ID</th><th>Nome</th><th>Data de Nascimento</th><th>Renda</th></tr>";
            string Conteudo = "";
            List<Cliente> clientes = ObterLista();
            for (int i = 0; i < clientes.Count; i++)
            {
                Conteudo += "<tr><td>" + clientes[i].IdCliente + "</td><td>" + clientes[i].Nome + "</td><td>"
                    + clientes[i].DataNasc.ToShortDateString() + "</td><td>" + "R$ " + clientes[i].Renda + "</td>";
            }
            context.Response.Write(CabecalhoEstatico + Conteudo + "</table>");
            context.Response.Write("<br/>" + "<a href=\"FormCliente.htm\">Voltar</a>");
        }

        public List<Cliente> ObterLista()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (VendasEntities ctx = new VendasEntities())
            {
                clientes = ctx.Cliente.ToList();
            }
            return clientes;
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}