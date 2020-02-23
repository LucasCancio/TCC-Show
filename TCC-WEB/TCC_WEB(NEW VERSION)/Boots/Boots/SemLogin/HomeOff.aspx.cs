using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boots.SemLogin
{
    public partial class HomeOff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lvNovidades_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            Image img = (Image)e.Item.FindControl("imgBanner");
            System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)e.Item.FindControl("divBanner");
            if (img != null)
            {
                if (img.ImageUrl == string.Empty)
                {
                    img.Attributes.Add("src", "../img/ComedyImagem.png");
                }
                else
                {
                    img.ImageUrl = "../img/" + img.ImageUrl.ToString().Substring(img.ImageUrl.ToString().LastIndexOf("\\") + 1);
                }
            }
            if (e.Item.DisplayIndex==0)
            {
                div.Attributes.Add("class", "carousel-item active");
            }
        }
    }
}