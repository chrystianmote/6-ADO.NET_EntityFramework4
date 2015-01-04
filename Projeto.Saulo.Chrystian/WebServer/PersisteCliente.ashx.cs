using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer
{
    /// <summary>
    /// Summary description for PersisteCliente
    /// </summary>
    public class PersisteCliente : IHttpHandler
    {
        int Id = 0;
        public void ProcessRequest(HttpContext context)
        {
            string Nome = context.Request.Form["txtNome"];
            DateTime DataNasc = Convert.ToDateTime(context.Request.Form["txtDataNasc"]);
            decimal Renda = decimal.Parse(context.Request.Form["txtRenda"]);
            Id = InsereCliente(Nome, DataNasc, Renda);
            context.Response.Redirect("FormSucesso.ashx?Id=" + Id);
        }

        private static int InsereCliente(string Nome, DateTime DataNasc, decimal Renda)
        {
            int Id = 0;
            using (VendasEntities ctx = new VendasEntities())
            {
                Cliente c = new Cliente();
                c.Nome = Nome;
                c.DataNasc = DataNasc;
                c.Renda = Renda;
                ctx.Cliente.AddObject(c);
                ctx.SaveChanges();
                Id = c.IdCliente;
            }
            return Id;
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