using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer
{
    /// <summary>
    /// Summary description for FormSucesso
    /// </summary>
    public class FormSucesso : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            int Id = Convert.ToInt32(context.Request.QueryString["Id"]);
            using (VendasEntities ctx = new VendasEntities())
            {
                Cliente c = ctx.Cliente.FirstOrDefault(
                     x => x.IdCliente == Id);
                context.Response.Write("Cadastro de " + c.Nome + " efetuado com sucesso!");
                context.Response.Write("<br/><br/>");
                context.Response.Write("<a href=\"FormCliente.htm\">Cadastrar Outro</a>");
            }
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