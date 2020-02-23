using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boots
{
    public partial class ModeloOn : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IdCliente-LOGADO"] == null)
                Response.Redirect("~/ComLogin/Login.aspx");
            if (!Page.IsPostBack)
            {
                var page = (Page)HttpContext.Current.CurrentHandler;
                string url = page.AppRelativeVirtualPath;
                //switch (url.Substring(url.LastIndexOf("/")+1))
                //{
                    
                //    case "PerfilOn.aspx":
                //        lblPerfil.Attributes.Add("style", "background-color: white;color: black; ");
                //        break;
                //    case "AjudaOn.aspx":
                //        lblAjuda.Attributes.Add("style", "background-color: white;color: black; ");
                //        break;
                //    case "AgendaOn.aspx":
                //        lblAgenda.Attributes.Add("style", "background-color: white;color: black; ");
                //        break;
                //    case "ArtistaOn.aspx":
                //        lblArtista.Attributes.Add("style", "background-color: white;color: black; ");
                //        break;
                //}
                
            }




        }

        protected void LoginStatus1_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Session["IdCliente-LOGADO"] = null;
        }

        protected void LoginStatus1_LoggedOut(object sender, EventArgs e)
        {
            Session["IdCliente-LOGADO"] = null;
        }

     
    }
}