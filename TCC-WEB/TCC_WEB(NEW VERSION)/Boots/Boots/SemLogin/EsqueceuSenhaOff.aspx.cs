using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boots.SemLogin
{
    public partial class EsqueceuSenhaOff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario-LOGADO"] == null)
                Response.Redirect("~/ComLogin/Login.aspx");

            
            txtUsuario.Text = Session["Usuario-LOGADO"].ToString();
            txtPergunta.Text = Session["Pergunta-LOGADO"].ToString();
            IdLogin = Convert.ToInt32(Session["IdLogin-LOGADO"]);

        }

        BLL.Login obj = new BLL.Login();

        public int IdLogin;
        protected void Salvar(object sender, EventArgs e)
        {
            try
            {
                pnErro.Visible = false;

               

                if (txtSenha.Text == string.Empty)
                {
                    pnErro.Visible = true; pnErro.Focus();
                    lblErro.Text = "Digite a <b>nova senha!</b>";
                    return;
                }

                if (txtConfirmarSenha.Text == string.Empty)
                {
                    pnErro.Visible = true; pnErro.Focus();
                    lblErro.Text = "Digite novamente a <b>nova senha!</b>";
                    return;
                }

                if (this.txtConfirmarSenha.Text != this.txtSenha.Text)
                {
                    pnErro.Visible = true; pnErro.Focus();
                    lblErro.Text = "<b>Senhas</b> não se coincidem!";
                    
                    return;
                }
                obj.IdLogin = Convert.ToInt32(Session["IdLogin-LOGADO"]);
                obj.Senha = txtSenha.Text.Trim();
                obj.AlterarSenha("Login");
                Response.Redirect("~/ComLogin/Login.aspx");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void Verificar(object sender ,EventArgs e) {
            try
            {
                pnErro.Visible = false;

                if (txtResposta.Text == string.Empty)
                {
                    pnErro.Visible = true; pnErro.Focus();
                    lblErro.Text = "Digite a <b>resposta!</b>";
                    return;
                }
                if (txtResposta.Text != Session["Resposta-LOGADO"].ToString())
                {
                    pnErro.Visible = true; pnErro.Focus();
                    lblErro.Text = "<b>Resposta</b> inválida!";

                    return;
                }

                pnSenha.Enabled = true;
                this.btnVerificar.Enabled = false;
                this.txtResposta.Enabled = false;
                this.btnSalvar.Enabled = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}