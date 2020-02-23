using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace TCC_Oficial.Telas.Cliente
{
    public partial class Agenda : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void dtEventos_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "verMais")
            {
                Response.Redirect("Logado/MostrarEventoLogado.aspx?id=" + e.CommandArgument.ToString());
            }
        }
      
    }
}