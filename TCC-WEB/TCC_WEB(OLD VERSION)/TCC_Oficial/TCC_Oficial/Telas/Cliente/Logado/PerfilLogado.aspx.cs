using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TCC_Oficial.Telas.Cliente.Logado
{
    public partial class PerfilLogado : System.Web.UI.Page
    {
        BLL.Cliente obj = new BLL.Cliente(); // <<<<<<<<<<<<<<<<
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ViewState["codigo"] = Convert.ToInt32(Session["IdLogin-LOGADO"]);
               
                obj.DataListarFinal = Convert.ToDateTime(DateTime.Now.ToString().Substring(0, 10));

               

                obj.DataListarInicio = Convert.ToDateTime(DateTime.Now.AddDays(-30).ToString().Substring(0, 10));
                obj.DataListarFinal = Convert.ToDateTime(DateTime.Now.AddDays(180).ToString().Substring(0, 10));


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

                                Assento[contagem] = Assento[contagem - 1] + "," + Assento[contagem];

                                Assento[contagem - 1] = string.Empty;

                            }
                        }
                        contagem = contagem + 1;
                    }

                }

                if (dt.Rows.Count>0)
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

                throw ex;
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
                    ViewState["IdPessoa"]= Convert.ToInt32(dr["ID_PESSOA"]);
                    txtNome.Text = dr["NOME"].ToString();
                    txtEmail.Text = dr["EMAIL"].ToString();
                    cbSexo.Text = dr["SEXO"].ToString();
                    txtUsuario.Text = dr["USUARIO"].ToString();
                    txtSenha.Text = dr["SENHA"].ToString();
                    txtSenha.Attributes["type"] = "password";
                    txtPergunta.Text = dr["PERGUNTA"].ToString();
                    txtResposta.Text = dr["RESPOSTA"].ToString();
                    txtResposta.Attributes["type"] = "password";
                    txtCPF.Text = dr["CPF"].ToString().Replace("-","");
                    txtDataNasc.Attributes["type"] = "date";
                    DateTime data = new DateTime();
                    data = Convert.ToDateTime(dr["DATA_NASC"]);
                    txtDataNasc.Text = data.ToString("yyyy-MM-dd");





                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       

        public void CarregarDatePicks(string DataInicial,string DataFinal) {
            //System.Web.UI.HtmlControls.HtmlInputText dtpHorarioFinal;
            //dtpHorarioFinal = (System.Web.UI.HtmlControls.HtmlInputText)FindControl("ContentPlaceHolder1_dtpHorarioFinal");

            //System.Web.UI.HtmlControls.HtmlInputText dtpHorarioInicial;
            //dtpHorarioInicial = (System.Web.UI.HtmlControls.HtmlInputText)FindControl("ContentPlaceHolder1_dtpHorarioInicial");


            //var dtpHorarioInicial = this.Request.Form["ContentPlaceHolder1_dtpHorarioInicial"];
            //var dtpHorarioFinal =this.Request.Form["ContentPlaceHolder1_dtpHorarioFinal"];

            //if (dtpHorarioInicial != null && dtpHorarioFinal != null)
            //{
            //    if (Convert.ToDateTime(dtpHorarioFinal) <= Convert.ToDateTime(DateTime.Now.ToString().Substring(0, 10)) && Convert.ToDateTime(dtpHorarioInicial) >= Convert.ToDateTime(DateTime.Now.AddDays(-180).ToString().Substring(0, 10)))
            //    {

            obj.DataListarFinal = Convert.ToDateTime(DataFinal.Replace("-", "/"));
            obj.DataListarInicio = Convert.ToDateTime(DataInicial.Replace("-", "/"));
            CarregarHistorico();
            //    }
            //}





        }
        private bool ValidarCPF()
        {
            this.lblErro.Text = string.Empty;
            string texto = txtCPF.Text.Trim().Replace(".", "").Replace("-", "");
            Boolean retornar = true;
            if (texto.Length <= 10)
            {

                this.lblErro.Text = "O CPF não está completo!";
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
                    this.lblErro.Text = "CPF Inválido!";

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
                            this.lblErro.Text = "O CPF ja está sendo utilizado!";

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

        protected void Salvar(object o, EventArgs e) {
            try
            {
                this.lblErro.Text = string.Empty;
                if (txtDataNasc.Text==string.Empty)
                {
                    this.lblErro.Text = "A data de nascimento é obrigatória";
                    return;
                }
                if (Convert.ToDateTime(txtDataNasc.Text) > Convert.ToDateTime(DateTime.Now.AddYears(-18).ToString().Substring(0, 10)))
                {
                    this.lblErro.Text = "É obrigatório ter no mínimo 18 anos";
                    return;
                }
                else if (Convert.ToDateTime(txtDataNasc.Text) < Convert.ToDateTime(DateTime.Now.AddYears(-100).ToString().Substring(0, 10)))
                {
                    this.lblErro.Text = "A data de nascimento está inválida";
                    return;
                }



                if (this.txtNome.Text == String.Empty)
                {
                    this.lblErro.Text = "O Nome é obrigatório";
                    this.txtNome.Focus();
                    return;
                }



                //if (ValidarCPF() == false)
                //{

                //    return;
                //}


                if (this.txtUsuario.Text == String.Empty)
                {
                    this.lblErro.Text = "O usuario é obrigatório";

                    this.txtUsuario.Focus();
                    return;
                }

                if (this.txtPergunta.Text == String.Empty)
                {
                    this.lblErro.Text = "A pergunta é obrigatória";

                    this.txtPergunta.Focus();
                    return;
                }


                if (this.txtResposta.Text == String.Empty)
                {
                    this.lblErro.Text = "A resposta é obrigatória";

                    this.txtResposta.Focus();
                    return;
                }


                if (this.txtUsuario.Text == String.Empty)
                {
                    this.lblErro.Text = "O Usuario é obrigatório";

                    this.txtUsuario.Focus();
                    return;
                }

                if (this.txtSenha.Text != this.txtConfirmarSenha.Text)
                {
                    this.lblErro.Text = "As senhas não se coinscidem!";

                    this.txtSenha.Focus();
                    return;
                }

                if (this.txtEmail.Text != string.Empty && txtEmail.Text != "")
                {
                    if (!validarEmail(this.txtEmail.Text))
                    {
                        this.lblErro.Text = "Email inválido!";
                        this.txtEmail.Focus();
                        return;
                    }

                }
                
                BLL.Cliente c = new BLL.Cliente();
                BLL.Pessoa p = new BLL.Pessoa();
                BLL.Login log = new BLL.Login();
                BLL.Log Log = new BLL.Log();
                BLL.PerguntaSecreta pg = new BLL.PerguntaSecreta();

                c.ID_CLIENTE = Convert.ToInt32(Session["IdCliente-LOGADO"]);
                log.IdLogin = Convert.ToInt32(ViewState["codigo"]);
                p.NOME = txtNome.Text.Trim();
                c.CPF = this.txtCPF.Text;
                p.DATA_NASC = Convert.ToDateTime(this.txtDataNasc.Text.ToString());
                p.ID_TIPO_PESSOA = 2;
                p.SEXO = cbSexo.Text;
                c.Ativo = 0;
                c.Email = this.txtEmail.Text;
                p.ID_PESSOA = Convert.ToInt32(ViewState["IdPessoa"]);
                c.ID_PESSOA= Convert.ToInt32(ViewState["IdPessoa"]);
                c.Ativo = 1;
                p.ATIVO = 1;

                log.RespostaPerguntaSecreta = this.txtResposta.Text;
                log.Usuario = txtUsuario.Text;
                log.Senha = txtSenha.Text;
                log.Descricao = txtPergunta.Text;
                log.Ativo = 1;

                log.IdNivelAcesso = 3;

                pg.Descricao = txtPergunta.Text;
                pg.Resposta = txtResposta.Text;


                Log.TABELA_LOG = "CLIENTES";

                p.Pessoa_crud('A');
                log.Login_crud('A');
                c.Cliente_crud('A');

                FormsAuthentication.RedirectFromLoginPage(txtNome.Text, false);
                //Response.Redirect("~/Telas/Cliente/Logado/Default.aspx");

            }
            catch (Exception ex)
            {

                lblErro.Text = ex.Message;
            }
        }
    }
}