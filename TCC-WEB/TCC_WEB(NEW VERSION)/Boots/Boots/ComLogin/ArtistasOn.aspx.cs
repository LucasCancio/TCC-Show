using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boots.ComLogin
{
    public partial class ArtistasOn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.dtArtistas.DataSource = obj.ListarGeral("Ambos", this.txtPesquisar.Text.Trim().ToUpper(), 1, "P.NOME", "").Tables[0];
                this.dtArtistas.DataBind();
            }
        }

        protected void dtArtistas_ItemCommand(object source, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "verMais")
            {
                string[] arg = new string[2];
                arg = e.CommandArgument.ToString().Split(';');
                Response.Redirect("MostrarArtistaOn.aspx?id=" + arg[0] + "&tipo=" + arg[1]);
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

        string tipo, tipo3;
        BLL.Artista obj = new BLL.Artista();

        protected void rb_CheckedChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        protected void btnPesquisar_Click(object sender, ImageClickEventArgs e)
        {
            Pesquisar();

        }

        public void Pesquisar()
        {
            try
            {
                if (rbTodos.Checked)
                {
                    rbTodos.Font.Bold = true;
                    rbArtista.Font.Bold = false;
                    rbArtistaFixo.Font.Bold = false;
                    tipo3 = "Ambos";
                    cbFiltro.Items.Remove("Nome do empresário");
                }
                else if (rbArtista.Checked)
                {
                    rbArtista.Font.Bold = true;
                    rbTodos.Font.Bold = false;
                    rbArtistaFixo.Font.Bold = false;
                    tipo3 = "Artista";
                    cbFiltro.Items.Add("Nome do empresário");
                }
                else
                {
                    rbArtistaFixo.Font.Bold = true;
                    rbArtista.Font.Bold = false;
                    rbTodos.Font.Bold = false;
                    tipo3 = "ArtistaFixo";
                    cbFiltro.Items.Remove("Nome do empresário");
                }



                switch (cbFiltro.Text)
                {
                    case "Nome":
                        tipo = "P.NOME";
                        break;
                    case "Nome do empresário":
                        tipo = "AGT.NOME_PRINCIPAL";
                        break;
                }

                switch (tipo3)
                {
                    case "Ambos":

                        this.dtArtistas.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), 1, tipo, "").Tables[0];


                        break;
                    case "Artista":


                        this.dtArtistas.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), 1, tipo, "").Tables[0];




                        break;
                    case "ArtistaFixo":


                        this.dtArtistas.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), 1, tipo, "").Tables[0];




                        break;
                }
                dtArtistas.DataBind();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}