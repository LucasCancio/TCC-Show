using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boots.ComLogin
{
    public partial class AgendaOn : System.Web.UI.Page
    {
        BLL.Evento obj = new BLL.Evento();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DateTime data = new DateTime();
                data = Convert.ToDateTime(DateTime.Now.AddMonths(2).ToString().Substring(0,10));
                dtpHorarioFinal.Text = data.ToString("yyyy-MM-dd");
                data = Convert.ToDateTime(DateTime.Now.ToString().Substring(0,10));
                dtpHorarioInicio.Text = data.ToString("yyyy-MM-dd");
                obj.DataListarInicio = Convert.ToDateTime(dtpHorarioInicio.Text.ToString().Substring(0, 10));
                obj.DataListarFinal = Convert.ToDateTime(dtpHorarioFinal.Text.ToString().Substring(0, 10));
                this.dtEventos.DataSource = obj.ListarGeral(this.txtPesquisar.Text.Trim().ToUpper(), 1, "EV.TITULO", 0,0,"").Tables[0];
                this.dtEventos.DataBind();
            }
        }

        protected void dtEventos_ItemCommand(object source, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "verMais")
            {
                Response.Redirect("MostrarEventoOn.aspx?id=" + e.CommandArgument.ToString());
            }
        }

        protected void dtEventos_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            
            Image img = (Image)e.Item.FindControl("imgEvento");
            if (img!=null)
            {
                if (img.ImageUrl == string.Empty)
                {
                    img.Attributes.Add("src", "../img/ComedyImagem.png");
                }
                else
                {
                    img.ImageUrl = "../img/" + img.ImageUrl.ToString().Substring(img.ImageUrl.ToString().LastIndexOf("\\")+1);
                }
            }
           
        }
        string tipo;
        int fId=0;
        protected void btnPesquisar_Click(object sender, ImageClickEventArgs e)
        {
            this.pnErro.Visible = false;
            if (dtpHorarioInicio.Text.Length!=10 || dtpHorarioFinal.Text.Length != 10)
            {
                this.pnErro.Visible = true;
                this.lblErro.Text = "<b>Data Inválida</b> ou <b>não preenchida</b>!";
                return;
            }
            if (txtPesquisar.Text.Trim() != string.Empty)
            {
                switch (cbFiltro.Text)
                {
                    case "Codigo":
                        tipo = "EV.ID_EVENTO";
                        break;
                    case "Titulo":
                    case null:
                    case "":
                        tipo = "EV.TITULO";
                        break;
                    case "Descrição":
                        tipo = "EV.DESCRICAO";
                        break;
                    case "Artista específico":

                        BLL.Artista art = new BLL.Artista();
                        System.Data.SqlClient.SqlDataReader dr;
                        art.Nome = txtPesquisar.Text.Trim();
                        dr = art.ConsultarPorNome();
                        if (dr.Read())
                        {
                            fId = Convert.ToInt32(dr[0]);
                        }
                        else
                        {
                            pnErro.Visible = true;
                            lblErro.Text = "<b>Artista</b> não encontrado!";
                            return;
                        }
                       
                        break;
                }
            }
            else
            {
                tipo = "EV.TITULO";
            }

            obj.DataListarInicio = Convert.ToDateTime(dtpHorarioInicio.Text.ToString().Substring(0, 10));
            obj.DataListarFinal = Convert.ToDateTime(dtpHorarioFinal.Text.ToString().Substring(0, 10));

            dtEventos.DataSource= obj.ListarGeral(this.txtPesquisar.Text.Trim().ToUpper(), 1, tipo, fId, 0, "").Tables[0];
            dtEventos.DataBind();
        }
    }
}