using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Services;
using System.Web.Security;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExtensionMethods;

namespace Boots.ComLogin
{
    public partial class PerfilOn : System.Web.UI.Page
    {
        BLL.Cliente obj = new BLL.Cliente(); // <<<<<<<<<<<<<<<<
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["Senha-LOGADO"] =Session["Senha-LOGADO"];

                ViewState["codigo"] = Convert.ToInt32(Session["IdLogin-LOGADO"]);

                DateTime data = new DateTime();
                data = Convert.ToDateTime(DateTime.Now.AddMonths(2).ToString().Substring(0, 10));
                dtpHorarioFinal.Text = data.ToString("yyyy-MM-dd");
                data = Convert.ToDateTime(DateTime.Now.AddMonths(-3).ToString().Substring(0, 10));
                dtpHorarioInicial.Text = data.ToString("yyyy-MM-dd");
                obj.DataListarInicio = Convert.ToDateTime(dtpHorarioInicial.Text.ToString().Substring(0, 10));
                obj.DataListarFinal = Convert.ToDateTime(dtpHorarioFinal.Text.ToString().Substring(0, 10));

               


                obj.ID_LOGIN = Convert.ToInt32(ViewState["codigo"]);

                CarregarInformações();

                CarregarHistorico();




            }

        }

        public void CarregarHistorico()
        {
            try
            {


                DataTable dt = new DataTable();
                obj.ID_LOGIN = Convert.ToInt32(ViewState["codigo"]);
                dt = obj.ListarHistorico().Tables[0];
                int total = dt.Rows.Count;
                int contagem = 0;
                string[] DatadoEvento = new string[total];
                string[] DatadaVenda = new string[total];
                string[] Horario = new string[total];
                string[] Titulo = new string[total];
                string[] Assento = new string[total];
                string[] Situacao = new string[total];
                string[] URL_IMG = new string[total];
                int[] CodEvento = new int[total];
                int[] CodVenda = new int[total];
                foreach (DataRow linha in dt.Rows)
                {
                    if (contagem != total)
                    {

                        DatadoEvento[contagem] = Convert.ToString(linha["DATA_EVENTO"].ToString().Substring(0, 10));
                        DatadaVenda[contagem] = Convert.ToString(linha["DATAVENDA"].ToString().Substring(0, 16));
                        Horario[contagem] = Convert.ToString(linha["HORARIO"]);
                        Titulo[contagem] = Convert.ToString(linha["TITULO"]);
                        Assento[contagem] = Convert.ToString(linha["ASSENTO"]);
                        CodEvento[contagem] = Convert.ToInt32(linha["ID_EVENTO"]);
                        CodVenda[contagem] = Convert.ToInt32(linha["ID_VENDA"]);
                        Situacao[contagem] = Convert.ToString(linha["SITUACAO"]);
                        URL_IMG[contagem] = Convert.ToString(linha["URL_IMG"]);
                        if (contagem != 0)
                        {
                            if (CodVenda[contagem] == CodVenda[contagem - 1])
                            {
                                DatadoEvento[contagem - 1] = string.Empty;
                                DatadaVenda[contagem - 1] = string.Empty;
                                Horario[contagem - 1] = string.Empty;
                                CodVenda[contagem - 1] = 0;
                                Titulo[contagem - 1] = string.Empty;
                                Situacao[contagem - 1] = string.Empty;
                                CodEvento[contagem - 1] = 0;
                                URL_IMG[contagem - 1] = string.Empty;
                                Assento[contagem] = Assento[contagem - 1] + "," + Assento[contagem];

                                Assento[contagem - 1] = string.Empty;

                            }
                        }
                        contagem = contagem + 1;
                    }

                }

                if (dt.Rows.Count > 0)
                {
                    tvHistorico.Visible = true;
                    tvHistorico.Nodes.Clear();
                }
                else
                {
                    tvHistorico.Visible = false;
                }
                while (contagem != 0)
                {

                    if (CodVenda[contagem - 1] != 0)
                    {
                        TreeNode rootNode = new TreeNode();

                        if (Situacao[contagem - 1] == "Cancelado")
                        {
                            rootNode.Text = "Dia " + DatadaVenda[contagem - 1] + "- Cancelado";
                            tvHistorico.Nodes.Add(rootNode);
                        }
                        else
                        {
                            rootNode.Text = "Dia " + DatadaVenda[contagem - 1];
                            tvHistorico.Nodes.Add(rootNode);
                        }

                        rootNode.Value = CodVenda[contagem - 1].ToString();


                        TreeNode statesEvento = new TreeNode();
                        statesEvento.Text = "Evento:";
                        rootNode.ChildNodes.Add(statesEvento);

                        TreeNode cData = new TreeNode();
                        cData.Text = "Data: " + DatadoEvento[contagem - 1];
                        statesEvento.ChildNodes.Add(cData);

                        TreeNode cHorario = new TreeNode();
                        cHorario.Text = "Horario: " + Horario[contagem - 1];
                        statesEvento.ChildNodes.Add(cHorario);

                        TreeNode cTitulo = new TreeNode();
                        cTitulo.Text = "Titulo: " + Titulo[contagem - 1];
                        statesEvento.ChildNodes.Add(cTitulo);


                        TreeNode statesAssento = new TreeNode();
                        statesAssento.Text = "Assento(s):";
                        rootNode.ChildNodes.Add(statesAssento);

                        TreeNode cAssento = new TreeNode();
                        if (Assento[contagem - 1].IndexOf(",") > 0)
                        {
                            cAssento.Text = Assento[contagem - 1].Substring(0, Assento[contagem - 1].IndexOf(","));
                            statesAssento.ChildNodes.Add(cAssento);
                            while (Assento[contagem - 1].IndexOf(",") > 0)
                            {
                                Assento[contagem - 1] = Assento[contagem - 1].Substring(Assento[contagem - 1].IndexOf(",") + 1, Assento[contagem - 1].Length - Assento[contagem - 1].IndexOf(",") - 1);
                                if (Assento[contagem - 1].IndexOf(",") == -1)
                                {
                                    
                                    cAssento = new TreeNode();
                                    cAssento.Text = Assento[contagem - 1];
                                    statesAssento.ChildNodes.Add(cAssento);
                                }
                                else
                                {
                                    cAssento.Text = Assento[contagem - 1].Substring(0, Assento[contagem - 1].IndexOf(","));
                                    statesAssento.ChildNodes.Add(cAssento);
                                }

                            }
                        }
                        else
                        {
                            cAssento.Text = Assento[contagem - 1];
                            statesAssento.ChildNodes.Add(cAssento);
                        }








                    }

                    contagem = contagem - 1;
                }
                foreach (TreeNode n in tvHistorico.Nodes)
                {

                    n.SelectAction = TreeNodeSelectAction.Expand;



                }
             
            }
            catch (Exception ex)
            {

                lblErroHist.Text = "Error: <b>" + ex.Message + "</b>, favor consultar o gerente!";
                pnErroHist.Visible = true; pnErroHist.Focus();
            }
        }

        public void CarregarInformações()
        {

            try
            {
                System.Data.SqlClient.SqlDataReader dr;
                dr = obj.Consultar();
                if (dr.Read())
                {
                    ViewState["IdPessoa"] = Convert.ToInt32(dr["ID_PESSOA"]);
                    txtNome.Text = dr["NOME"].ToString();
                    txtEmail.Text = dr["EMAIL"].ToString();
                    cbSexo.Text = dr["SEXO"].ToString();
                    txtUsuario.Text = dr["USUARIO"].ToString();
                   // txtSenha.Text = dr["SENHA"].ToString();
                    txtSenha.Attributes["type"] = "password";
                    txtPergunta.Text = dr["PERGUNTA"].ToString();
                   // txtResposta.Text = dr["RESPOSTA"].ToString();
                    txtResposta.Attributes["type"] = "password";
                    txtCPF.Text = dr["CPF"].ToString().Replace("-", "");
                    txtDataNasc.Attributes["type"] = "date";
                    DateTime data = new DateTime();
                    data = Convert.ToDateTime(dr["DATA_NASC"]);
                    txtDataNasc.Text = data.ToString("yyyy-MM-dd");





                }
            }
            catch (Exception ex)
            {
                TheModal.Attributes.Add("style","background-color: #d4edda; color: #155724");
                lblModal.Text = "Error: <b>" + ex.Message + "</b>, favor consultar o gerente!";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);

             
            }
        }


        [ScriptMethod, WebMethod]
       
        private bool ValidarCPF()
        {
            // this.lblErro.Text = string.Empty;
            string texto = txtCPF.Text.Trim().Replace(".", "").Replace("-", "");
            Boolean retornar = true;
            if (texto.Length <= 10)
            {
                lblErroInf.Text = "O <b>CPF</b> não está completo!";
                pnErroInf.Visible = true; pnErroInf.Focus();
                //this.lblErro.Text = "O CPF não está completo!";
                retornar = false;

            }
            else
            {
                this.txtCPF.Text = this.txtCPF.Text.Substring(0, 9) + "-" + txtCPF.Text.Substring(9, 2);
                if (!BLL.ValidadorCPF.CampoCPF(texto) ||
                    txtCPF.Text == "111111111-11" ||
                    txtCPF.Text == "222222222-22" ||
                    txtCPF.Text == "333333333-33" ||
                    txtCPF.Text == "444444444-44" ||
                    txtCPF.Text == "555555555-55" ||
                    txtCPF.Text == "666666666-66" ||
                    txtCPF.Text == "777777777-77" ||
                    txtCPF.Text == "888888888-88" ||
                    txtCPF.Text == "999999999-99" ||
                    txtCPF.Text == "000000000-00")
                {
                    //   this.lblErro.Text = "CPF Inválido!";
                    lblErroInf.Text = "<b>CPF</b> inválido!";
                    pnErroInf.Visible = true; pnErroInf.Focus();

                    this.txtCPF.Text = string.Empty;
                    this.txtCPF.Focus();
                    retornar = false;
                }
                else
                {
                    BLL.Cliente medi = new BLL.Cliente();
                    System.Data.SqlClient.SqlDataReader dr;

                    medi.CPF = this.txtCPF.Text;
                    dr = medi.ConsultarCPF();
                    if (dr.Read())
                    {

                        if (Session["IdCliente-LOGADO"].ToString() != dr["ID_CLIENTE"].ToString())
                        {
                            // this.lblErro.Text = "O CPF ja está sendo utilizado!";
                            lblErroInf.Text = "O <b>CPF</b> já está sendo utilizado!";
                            pnErroInf.Visible = true; pnErroInf.Focus();

                            this.txtCPF.Text = string.Empty;
                            this.txtCPF.Focus();
                            retornar = false;
                        }



                    }

                }


            }
            return retornar;
        }

        public static bool validarEmail(string Email)
        {
            bool ValidEmail = false;
            int indexArr = Email.IndexOf("@");
            if (indexArr > 0)
            {
                int indexDot = Email.IndexOf(".", indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < Email.Length)
                    {
                        string indexDot2 = Email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            ValidEmail = true;
                        }
                    }
                }
            }
            return ValidEmail;
        }

        protected void Salvar(object o, EventArgs e)
        {
            try
            {
                var b = (Button)o;
                if (b.ID== "btnSalvar_log")
                {
                    this.pnErroLog.Visible = false;

                    if (this.txtUsuario.Text == String.Empty)
                    {
                        lblErroLog.Text = "O <b>usuário</b> não foi preenchido!";
                        pnErroLog.Visible = true; pnErroLog.Focus();
                        return;
                    }

                    if (this.txtSenha.Text == String.Empty)
                    {
                        lblErroLog.Text = "A <b>senha</b> não foi preenchida!";
                        pnErroLog.Visible = true; pnErroLog.Focus();
                        return;
                    }

                    if (this.txtPergunta.Text == String.Empty)
                    {
                        lblErroLog.Text = "A <b>pergunta secreta</b> não foi preenchida!";
                        pnErroLog.Visible = true; pnErroLog.Focus();
                        return;
                    }


                    if (this.txtResposta.Text == String.Empty)
                    {
                        lblErroLog.Text = "A <b>resposta</b> não foi preenchida!";
                        pnErroLog.Visible = true; pnErroLog.Focus();
                        return;
                    }
                    VerificarUsuario();

                    ViewState["Salvar"] = "log";
                }
                else
                {
                    this.pnErroInf.Visible = false;

                    if (txtDataNasc.Text == string.Empty)
                    {
                        lblErroInf.Text = "A <b>data de nascimento</b> não foi preenchida!";
                        pnErroInf.Visible = true; pnErroInf.Focus();
                        return;
                        // this.lblErro.Text = " é obrigatória";

                    }
                    if (Convert.ToDateTime(txtDataNasc.Text) > Convert.ToDateTime(DateTime.Now.AddYears(-18).ToString().Substring(0, 10)))
                    {
                        lblErroInf.Text = "É obrigatório ter no mínimo <b>18 anos</b>!";
                        pnErroInf.Visible = true; pnErroInf.Focus();
                        return;
                        // this.lblErro.Text = "É obrigatório ter no mínimo 18 anos";

                    }
                    else if (Convert.ToDateTime(txtDataNasc.Text) < Convert.ToDateTime(DateTime.Now.AddYears(-100).ToString().Substring(0, 10)))
                    {
                        lblErroInf.Text = "A <b>data de nascimento</b> está inválida!";
                        pnErroInf.Visible = true; pnErroInf.Focus();
                        return;
                        //  this.lblErro.Text = "A data de nascimento está inválida";

                    }



                    if (this.txtNome.Text == String.Empty)
                    {
                        lblErroInf.Text = "O <b>nome</b> não foi preenchido!";
                        pnErroInf.Visible = true; pnErroInf.Focus();
                        return;
                        //this.lblErro.Text = "O Nome é obrigatório";

                    }



                    if (ValidarCPF() == false)
                    {

                        return;
                    }

                    if (this.txtEmail.Text != string.Empty && txtEmail.Text != "")
                    {
                        if (!validarEmail(this.txtEmail.Text))
                        {
                            lblErroInf.Text = "<b>Email</b> inválido!";
                            pnErroInf.Visible = true; pnErroInf.Focus();
                            return;
                        }

                    }
                    ViewState["Salvar"] = "inf";


                }
               
              

                          

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openMessageBox();", true);

                //Response.Redirect("~/Telas/Cliente/Logado/Default.aspx");

            }
            catch (Exception ex)
            {
                var b = (Button)o;
                if (b.ID == "btnSalvar_log")
                {
                    lblErroLog.Text = "Error: <b>" + ex.Message + "</b>, favor consultar o gerente!";
                    pnErroLog.Visible = true; pnErroLog.Focus();
                }
                else
                {
                    lblErroInf.Text = "Error: <b>" + ex.Message + "</b>, favor consultar o gerente!";
                    pnErroInf.Visible = true; pnErroInf.Focus();
                }
           

                //lblErro.Text = ex.Message;
            }
        }

        protected void SalvarAlteração(object o, EventArgs e) {
            try
            {
                var b = (Button)o;
                if (ViewState["Salvar"].ToString() == "log")
                {
                    pnErroLog.Visible = false;


                   
                    BLL.Login log = new BLL.Login();
                    BLL.PerguntaSecreta pg = new BLL.PerguntaSecreta();

                  
                    log.IdLogin = Convert.ToInt32(ViewState["codigo"]);
                 

                    log.RespostaPerguntaSecreta = this.txtResposta.Text;
                    log.Usuario = txtUsuario.Text;
                    log.Senha = txtSenha.Text;
                    log.Descricao = txtPergunta.Text;
                    log.Ativo = 1;

                    log.IdNivelAcesso = 3;

                    pg.Descricao = txtPergunta.Text;
                    pg.Resposta = txtResposta.Text;


                   
                    log.Login_crud('A');
                    



                }
                else
                {
                    pnErroInf.Visible = false;

                    BLL.Cliente c = new BLL.Cliente();
                    BLL.Pessoa p = new BLL.Pessoa();
                    c.ID_CLIENTE = Convert.ToInt32(Session["IdCliente-LOGADO"]);

                    p.NOME = txtNome.Text.Trim().ToUpper().RemoveAccents();
                    c.CPF = this.txtCPF.Text.Trim().Replace(".", "");
                    p.DATA_NASC = Convert.ToDateTime(this.txtDataNasc.Text.ToString());
                    p.ID_TIPO_PESSOA = 2;
                    p.SEXO = cbSexo.Text;
                    c.Ativo = 0;
                    c.Email = this.txtEmail.Text;
                    p.ID_PESSOA = Convert.ToInt32(ViewState["IdPessoa"]);
                    c.ID_PESSOA = Convert.ToInt32(ViewState["IdPessoa"]);
                    c.Ativo = 1;
                    p.ATIVO = 1;


                    p.Pessoa_crud('A');
                    c.Cliente_crud('A');
                }
                   

                

                FormsAuthentication.SetAuthCookie(txtNome.Text.ToString().RemoveAccents().ToUpper(), false);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                

            }
            catch (Exception ex)
            {

                var b = (Button)o;
                if (ViewState["Salvar"].ToString() == "log")
                {
                    lblErroLog.Text = "Error: <b>" + ex.Message + "</b>, favor consultar o gerente!";
                    pnErroLog.Visible = true; pnErroLog.Focus();
                }
                else
                {
                    lblErroInf.Text = "Error: <b>" + ex.Message + "</b>, favor consultar o gerente!";
                    pnErroInf.Visible = true; pnErroInf.Focus();
                }
            }
        }
        private void VerificarUsuario()
        {


            BLL.Login medi = new BLL.Login();
            System.Data.SqlClient.SqlDataReader dr;
            medi.Usuario = this.txtUsuario.Text;
            dr = medi.ConsultarUsuario("CLIENTE");
            if (dr.Read())
            {

                if (Session["IdCliente-LOGADO"].ToString() != dr["ID_CLIENTE"].ToString())
                {
                    lblErroLog.Text = "O <b>usuário</b> já está sendo utilizado!";
                    pnErroLog.Visible = true; pnErroLog.Focus();
                    return;

                }




            }

        }
        protected void dtpHorarioInicial_TextChanged(object sender, EventArgs e)
        {
            if (dtpHorarioInicial.Text.Length > 10 && dtpHorarioFinal.Text.Length > 10)
            {
                if (Convert.ToDateTime(dtpHorarioFinal) <= Convert.ToDateTime(DateTime.Now.ToString().Substring(0, 10)) && Convert.ToDateTime(dtpHorarioInicial) >= Convert.ToDateTime(DateTime.Now.AddDays(-180).ToString().Substring(0, 10)))
                {

                    obj.DataListarFinal = Convert.ToDateTime(dtpHorarioFinal.Text.Replace("-", "/"));
                    obj.DataListarInicio = Convert.ToDateTime(dtpHorarioInicial.Text.Replace("-", "/"));
                    CarregarHistorico();
                }
            }
        }

        protected void btnPesquisar_Click(object sender, ImageClickEventArgs e)
        {
            if (dtpHorarioInicial.Text.Length == 10 && dtpHorarioFinal.Text.Length == 10)
            {
                if (Convert.ToDateTime(dtpHorarioInicial.Text) <= Convert.ToDateTime(dtpHorarioFinal.Text))
                {

                    obj.DataListarFinal = Convert.ToDateTime(dtpHorarioFinal.Text.Replace("-", "/"));
                    obj.DataListarInicio = Convert.ToDateTime(dtpHorarioInicial.Text.Replace("-", "/"));
                    CarregarHistorico();
                }
            }
        }

        protected void VerificarSenha(object o, EventArgs e) {
            try
            {
                pnErroSenha.Visible = false;
                if (this.txtSenhaAtual.Text!= ViewState["Senha-LOGADO"].ToString())
                {
                    lblErroSenha.Text = "<b>Senha</b> não se coinscide com a senha atual";
                    pnErroSenha.Visible = true; pnErroSenha.Focus();
                }
                else
                {
                    pnLogin.Visible = true;
                    pnSenha.Visible = false;
                   
                   
                }
                
                
            }
            catch (Exception ex)
            {

                
                    lblErroSenha.Text = "Error: <b>" + ex.Message + "</b>, favor consultar o gerente!";
                    pnErroSenha.Visible = true; pnErroSenha.Focus();
                
               
            }
        }

        protected void tvHistorico_SelectedNodeChanged(object sender, EventArgs e)
        {

        }
    }
    
       

}
namespace ExtensionMethods
{
    public static class StringExtends
    {
        public static string RemoveAccents(this string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }
    }
}