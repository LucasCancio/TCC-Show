using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boots.SemLogin
{
    public partial class FeedbackOff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void lvFeedBack_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)e.Item.FindControl("divAlerta");
            Label titulo = (Label)e.Item.FindControl("TituloAlerta");
            Label mensagem = (Label)e.Item.FindControl("MensagemAlerta");
            AjaxControlToolkit.Rating estrela = (AjaxControlToolkit.Rating)e.Item.FindControl("AvaliacaoAlerta");
            if (titulo.Text == string.Empty)
            {
                titulo.Visible = false;
                mensagem.Attributes.Add("class", "h5");
            }
            if (estrela.CurrentRating > 3)
            {
                div.Attributes.Add("class", "alert alert-success");
            }
            else if (estrela.CurrentRating < 3)
            {
                div.Attributes.Add("class", "alert alert-danger");
            }
            else
            {
                div.Attributes.Add("class", "alert alert-warning");
            }

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            FormsAuthentication.RedirectToLoginPage();
        }
    }
}