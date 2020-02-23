using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Boots
{
    public partial class ModeloOff : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IdCliente-LOGADO"] != null)
            {
                Response.Redirect("~/ComLogin/HomeOn.aspx");
            }
        }
    }
}