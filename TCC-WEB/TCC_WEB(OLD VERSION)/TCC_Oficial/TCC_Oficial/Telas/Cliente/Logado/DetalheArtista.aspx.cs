using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TCC_Oficial.Telas.Cliente.Logado
{
    public partial class DetalheArtista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null && Request.QueryString["id"] != string.Empty)
                {
                    CarregarInformações(Request.QueryString["tipo"].ToString());
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }


            }
        }

        BLL.Artista obj = new BLL.Artista();
        public void CarregarInformações(string tipo)
        {

            try
            {
                System.Data.SqlClient.SqlDataReader dr;
                obj.ID_ARTISTA_GERAL = Convert.ToInt32(Request.QueryString["id"]);
                if (tipo=="ARTISTA")
                {
                    dr = obj.ConsultarNORMAL();
                    pnEmpresario.Visible = true;
                }
                else
                {
                    dr = obj.ConsultarFIXO();
                    pnEmpresario.Visible = false;
                }
                
                if (dr.Read())
                {
                    txtNome.Text = dr["NOME"].ToString();
                    txtSexo.Text = dr["SEXO"].ToString();
                    if (tipo == "ARTISTA")
                    {
                        lblTipoPessoa.Text = "Pessoa "+dr["TIPO_PESSOA"].ToString().ToLower().FirstCharToUpper();
                        if (lblTipoPessoa.Text == "Jurídica")
                        {
                            lblNomePrincipal.Text = "Razão Social";
                        }
                        else
                        {
                            lblNomePrincipal.Text = "Nome Civil";
                        }
                        txtNomePrincipal.Text = dr["NOME_PRINCIPAL"].ToString();
                        txtEmail.Text = dr["EMAIL"].ToString();
                        txtTelefone.Text = dr["TELEFONE"].ToString();
                    }
                    else
                    {
                       
                    }
                    txtFacebook.Text= dr["FACEBOOK"].ToString();
                    txtTwitter.Text = dr["TWITTER"].ToString();
                    txtInstagram.Text = dr["INSTAGRAM"].ToString();

                    txtDataNasc.Attributes["type"] = "date";
                    DateTime data = new DateTime();
                    data = Convert.ToDateTime(dr["DATA_NASC"]);
                    txtDataNasc.Text = data.ToString("yyyy-MM-dd");





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


    }
    public static class StringExtends
    {
        public static string FirstCharToUpper(this string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("Insira uma palavra diferente de nula ou vazia");
            return input.Length > 1 ? char.ToUpper(input[0]) + input.Substring(1) : input.ToUpper();
        }
    }
}