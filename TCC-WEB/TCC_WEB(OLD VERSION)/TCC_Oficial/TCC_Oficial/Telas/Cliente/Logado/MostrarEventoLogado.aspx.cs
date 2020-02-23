using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TCC_Oficial.Telas.Cliente.Logado
{
    public partial class MostrarEventoLogado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"]!=null)
                {
                    CarregarInformações();
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
               
                this.dgvArtistasSelect.SelectedRow.Cells[0].Visible =false;

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
                    dtpData.Text = data.ToString("yyyy-MM-dd");

                 
                   
                  
                    this.lblDescricao.Text = dr["DESCRICAO"].ToString();
                    this.lblTitulo.Text = dr["TITULO"].ToString();
                    this.lblValor.Text = dr["VALOR_EVENTO"].ToString();
                    DateTime HorarioInicio = new DateTime();
                    HorarioInicio = Convert.ToDateTime(dr["HORARIO_INICIO"]);

                    DateTime HorarioFinal = new DateTime();
                    HorarioFinal = Convert.ToDateTime(dr["HORARIO_FINAL"]);

                    this.lblHorario.Text = HorarioInicio.ToString("HH:mm") +" á "+ HorarioFinal.ToString("HH:mm");

                    this.lblDuracao.Text = dr["DURACAO"].ToString();
                    if (dr["URL_IMG"].ToString() == string.Empty)
                    {
                       

                    }
                    else
                    {
                       
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

        protected void dgvArtistasSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.dgvArtistasSelect.SelectedRow.Cells[0].Text!=null)
            {
                
                Response.Redirect("DetalheArtista.aspx?id=" + this.dgvArtistasSelect.SelectedRow.Cells[0].Text + "&tipo=" + this.dgvArtistasSelect.SelectedRow.Cells[2].Text);
            
            }
            
        }
    }
}