using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Common;

using System.Data;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;

using BLL;
using DAO;
using System.Configuration;
using System.Web.Security;

namespace TCC_Oficial.Telas.Cliente
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

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (Validar())
                {

                    FormsAuthentication.RedirectFromLoginPage( login.Nome , false);

                }
                else
                {
                    lblErro.Visible = true;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        BLL.Login obj = new BLL.Login();
        protected void btnEsqueceuSenha_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim()==string.Empty)
            {
                return;
            }

            obj.Usuario = txtUsuario.Text;
            System.Data.SqlClient.SqlDataReader dr;
            dr = obj.ConsultarUsuario("CLIENTE");
            if (dr.Read())
            {
                Session["IdLogin-LOGADO"] =dr["ID_LOGIN"];
                
                Session["Resposta-LOGADO"] = dr["RESPOSTA"];
                Session["Pergunta-LOGADO"] = dr["DESCRICAO"];
                Session["Usuario-LOGADO"] = txtUsuario.Text.Trim();
                Response.Redirect("~/Telas/Cliente/EsqueceuSenha.aspx");

            }
            else
            {
                Response.Write("Usuário não encontrado!");
               
            }



          
        }
    }
}