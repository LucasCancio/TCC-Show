using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAO;

namespace TCC_Oficial.Telas.Cliente
{
    public partial class Artistas : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "verMais")
            {
                string[] arg = new string[2];
                arg = e.CommandArgument.ToString().Split(';');
                Response.Redirect("DetalheArtista.aspx?id=" + arg[0] + "&tipo=" + arg[1]);
            }
        }

    }
}