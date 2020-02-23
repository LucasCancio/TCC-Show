using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TCC_Oficial.Telas.Cliente
{
    public partial class EsqueceuSenha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario-LOGADO"]==null)
            {
                return;
            }
            txtUsuario.Text = Session["Usuario-LOGADO"].ToString();
            Resposta= Session["Resposta-LOGADO"].ToString();
            txtPergunta.Text= Session["Pergunta-LOGADO"].ToString();
            IdLogin = Convert.ToInt32(Session["IdLogin-LOGADO"]);

        }

        BLL.Login obj = new BLL.Login();

        public int IdLogin;
        public string Resposta;
        protected void Salvar(object sender, EventArgs e)
        {
            try
            {
                lblErro.Visible = false;
             
                if (txtResposta.Text==string.Empty)
                {
                    return;
                }
                if (txtResposta.Text!=Resposta)
                {
                    lblErro.Text= "Resposta Inválida!";
                     lblErro.Visible = true;
                    return;
                }

                if (this.txtConfirmarSenha.Text != this.txtSenha.Text)
                {
                    lblErro.Text = "Senhas não se coincidem!";
                    lblErro.Visible = true;
                    return;
                }
                obj.IdLogin = IdLogin;
                obj.Senha = txtSenha.Text.Trim();
                obj.AlterarSenha("Login");
                Response.Redirect("~/Telas/Cliente/Logado/Login.aspx");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}