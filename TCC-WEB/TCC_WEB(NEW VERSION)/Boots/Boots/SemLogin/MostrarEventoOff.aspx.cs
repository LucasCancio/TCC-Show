using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.SqlServer.Server;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

namespace Boots.SemLogin
{
    public partial class MostrarEventoOff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    CarregarInformações();
                }
                else
                {
                    Response.Redirect("HomeOff.aspx");
                }

               

            }
        }
        BLL.Evento obj = new BLL.Evento();
        public void CarregarInformações()
        {

            try
            {
                System.Data.SqlClient.SqlDataReader dr;
                obj.ID_EVENTO = Convert.ToInt32(Request.QueryString["id"]);
                dr = obj.Consultar();

                if (dr.Read())
                {

                    DateTime data = new DateTime();
                    data = Convert.ToDateTime(dr["DATA_EVENTO"]);
                    txtDataEvento.Text = data.ToString("yyyy-MM-dd");

                    Title = dr["TITULO"].ToString();


                    //this.lblDescricao.Text = dr["DESCRICAO"].ToString();
                    this.txtTitulo.Text = dr["TITULO"].ToString();
                    //this.lblValor.Text = "R$ "+ dr["VALOR_EVENTO"].ToString();
                    DateTime HorarioInicio = new DateTime();
                    HorarioInicio = Convert.ToDateTime(dr["HORARIO_INICIO"]);

                    DateTime HorarioFinal = new DateTime();
                    HorarioFinal = Convert.ToDateTime(dr["HORARIO_FINAL"]);
                    this.txtDescricao.Text = dr["DESCRICAO"].ToString();
                    this.txtHorario.Text = HorarioInicio.ToString("HH:mm") + " á " + HorarioFinal.ToString("HH:mm");

                    //this.lblDuracao.Text = dr["DURACAO"].ToString();
                    if (dr["URL_IMG"].ToString() == string.Empty)
                    {
                        imgEvento.Attributes.Add("src", "../img/ComedyImagem.png");
                    }
                    else
                    {
                        imgEvento.ImageUrl = "../img/" + dr["URL_IMG"].ToString().Substring(dr["URL_IMG"].ToString().LastIndexOf("\\") + 1);
                    }









                }
                else
                {
                    Response.Redirect("Default.aspx");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "ComprarIngresso")
            {
                FormsAuthentication.RedirectToLoginPage();
            }
        }

        protected void dtArtistas_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            Image img = (Image)e.Item.FindControl("imgArtista");
            if (img != null)
            {
                if (img.ImageUrl == string.Empty)
                {
                    img.Attributes.Add("src", "../img/PerfilIcone.png");
                }
                else
                {
                    img.ImageUrl = "../img/" + img.ImageUrl.ToString().Substring(img.ImageUrl.ToString().LastIndexOf("\\") + 1);
                }
               // img.url

            }
        }

        protected void dtArtistas_ItemCommand(object source, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "verArtista")
            {

                FormsAuthentication.RedirectToLoginPage();
            }
        }
    }
}