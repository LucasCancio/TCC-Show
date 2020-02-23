using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boots.SemLogin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }



        BLL.Login login = new BLL.Login();

        public bool Validar()
        {
            try
            {

                bool Check = false;


                login.Usuario = txtUsuario.Text.ToUpper().Trim();
                login.Senha = txtSenha.Text.Trim();

                Check = login.Logar();
                if (Check)
                {
                    Session["IdCliente-LOGADO"] = login.IdCli;
                    Session["IdLogin-LOGADO"] = login.IdLogin;
                    Session["Nome-LOGADO"] = login.Nome;
                    Session["Senha-LOGADO"] = login.Senha;
                    Session["Usuario-LOGADO"] = login.Usuario;
                    Session["Pergunta-LOGADO"] = login.Descricao;
                }



                return Check;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void Entrar(object sender, EventArgs e)
        {
            try
            {
              pnErro.Visible = false;
                if (this.txtUsuario.Text.Trim()==string.Empty)
                {
                    lblErro.Text = "<b>Usuário</b> não preenchido!";
                    pnErro.Visible = true; pnErro.Focus();
                    return;

                }
                if (this.txtSenha.Text.Trim() == string.Empty)
                {
                    lblErro.Text = "<b>Senha</b> não preenchida!";
                    pnErro.Visible = true; pnErro.Focus();
                    return;

                }
                if (Validar())
                {
                    if (Request.QueryString["ReturnUrl"] != null)
                    {
                        FormsAuthentication.SetAuthCookie(login.Nome, true);
                        Response.Redirect("~" + Request.QueryString["ReturnUrl"].ToString().Replace("Off", "On").Replace("SemLogin", "ComLogin"));

                    }
                    else
                    {
                        FormsAuthentication.RedirectFromLoginPage(login.Nome, false);
                    }


                }
                else
                {
                    lblErro.Text = "<b>Usuário</b> ou <b>Senha</b> estão incorretos!";
                    pnErro.Visible = true; pnErro.Focus();

                }

            }
            catch (Exception ex)
            {

                lblErro.Text = "Error: <b>" + ex.Message + "</b>, favor consultar o gerente!";
                pnErro.Visible = true; pnErro.Focus();
            }
        }


        BLL.Login obj = new BLL.Login();
    

        protected void btnEsqueceuSenha_Click1(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == string.Empty)
            {
                pnErro.Visible = true; pnErro.Focus();
                lblErro.Text = "Digite o <b>usuário!</b>";
                return;
            }
            pnErro.Visible = false;

            obj.Usuario = txtUsuario.Text;
            System.Data.SqlClient.SqlDataReader dr;
            dr = obj.ConsultarUsuario("CLIENTE");
            if (dr.Read())
            {
                Session["IdLogin-LOGADO"] = dr["ID_LOGIN"];

                Session["Resposta-LOGADO"] = dr["RESPOSTA"];
                Session["Pergunta-LOGADO"] = dr["DESCRICAO"];
                Session["Usuario-LOGADO"] = txtUsuario.Text.Trim();
                Response.Redirect("~/SemLogin/EsqueceuSenhaOff.aspx");

            }
            else
            {
                pnErro.Visible = true; pnErro.Focus();
                lblErro.Text = "<b>Usuário</b> não encontrado!";

            }

        }

      
    }
}