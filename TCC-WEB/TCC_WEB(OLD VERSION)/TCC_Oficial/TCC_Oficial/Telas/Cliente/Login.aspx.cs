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

namespace TCC_Oficial.Telas.Cliente
{
    public partial class Login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        public bool Validar()
        {
            try
            {
               bool Check = false;
               return Check;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnEntrar_log_Click(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.ConnectionStrings["TCCSHOWConnectionString"].ConnectionString;
            string SQL = "SELECT [USUARIO], [SENHA] FROM [TB_LOGIN] WHERE [ID_NIVELACESSO] = 3 AND [USUARIO] = [@USUARIO] AND [SENHA] = [@SENHA]";
            string ID = Request.QueryString["ID_LOGIN"];

            using (SqlConnection conn = new SqlConnection(strCon))
            {
                using (SqlCommand cmd = new SqlCommand(SQL, conn))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                        SqlDataReader dr = cmd.ExecuteReader();
                        
                    }
                }
            }



        }








    }
}