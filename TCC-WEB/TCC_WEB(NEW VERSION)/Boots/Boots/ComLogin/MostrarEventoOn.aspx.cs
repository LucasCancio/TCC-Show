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

namespace Boots.ComLogin
{
    public partial class MostrarEventoOn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    LinkButton1.CommandArgument = Request.QueryString["id"].ToString();
                    CarregarInformações();

                }
                else
                {
                    if (Session["IdLogin-LOGADO"]==null)
                    {
                        FormsAuthentication.RedirectFromLoginPage("", false);
                    }
                    else
                    {
                        Response.Redirect("HomeOn.aspx");
                    }
                    
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
                    this.txtDataEvento.Text= data.ToString("yyyy-MM-dd");
                    Session["DataDoEvento"]= Convert.ToDateTime(dr["DATA_EVENTO"]);
                    // dtpData.Text = data.ToString("yyyy-MM-dd");


                    Title = dr["TITULO"].ToString();

                    this.txtDescricao.Text = dr["DESCRICAO"].ToString();
                    this.txtTitulo.Text = dr["TITULO"].ToString();
                    DateTime HorarioInicio = new DateTime();
                    HorarioInicio = Convert.ToDateTime(dr["HORARIO_INICIO"]);

                    DateTime HorarioFinal = new DateTime();
                    HorarioFinal = Convert.ToDateTime(dr["HORARIO_FINAL"]);

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
                Response.Redirect("IngressoOn.aspx?id=" + e.CommandArgument.ToString());
                
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
            }

           
        }

    


        protected void dtArtistas_ItemCommand(object source, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "verArtista")
            {
                string[] arg = new string[2];
                arg = e.CommandArgument.ToString().Split(';');
                Response.Redirect("~/ComLogin/MostrarArtistaOn.aspx?id=" + arg[0] + "&tipo=" + arg[1]);
                
            }
        }

        protected void dtArtistas_ItemCommand(object source, DataListCommandEventArgs e)
        {

        }
    }
}