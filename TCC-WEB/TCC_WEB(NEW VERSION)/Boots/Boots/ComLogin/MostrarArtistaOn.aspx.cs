using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.SqlServer.Server;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Boots.ComLogin
{
    public partial class MostrarArtistaOn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null && Request.QueryString["id"] != string.Empty && Request.QueryString["tipo"] != null && Request.QueryString["tipo"]!=string.Empty)
                {
                    CarregarInformações(Request.QueryString["tipo"].ToString());
                    DateTime data = new DateTime();
                    data = Convert.ToDateTime(DateTime.Now.AddMonths(2).ToString().Substring(0, 10));
                    dtpHorarioFinal.Text = data.ToString("yyyy-MM-dd");
                    data = Convert.ToDateTime(DateTime.Now.ToString().Substring(0, 10));
                    dtpHorarioInicial.Text = data.ToString("yyyy-MM-dd");
                    obj.DataListarInicio = Convert.ToDateTime(dtpHorarioInicial.Text.ToString().Substring(0, 10));
                    obj.DataListarFinal = Convert.ToDateTime(dtpHorarioFinal.Text.ToString().Substring(0, 10));

                    CarregarHistorico();
                }
                else
                {
                    Response.Redirect("HomeOn.aspx");
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
                if (tipo == "ARTISTA")
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
                    Title = dr["NOME"].ToString();
                    txtNome.Text = dr["NOME"].ToString();
                    //txtSexo.Text = dr["SEXO"].ToString();
                    if (tipo == "ARTISTA")
                    {
                        lblTituloEmpr.Text = "Empresário (Pessoa " + dr["TIPO_PESSOA"].ToString().ToLower().FirstCharToUpper()+")";
                        if (dr["TIPO_PESSOA"].ToString().ToLower().FirstCharToUpper() == "Jurídica")
                        {
                           
                           // lblNomePrincipal.v = "Razão Social";
                        }
                        else
                        {
                            //lblNomePrincipal.Text = "Nome Civil";
                        }
                        txtNomePrincipal.Text = dr["NOME_PRINCIPAL"].ToString();
                        txtEmail.Text = dr["EMAIL"].ToString();
                        txtFone.Text = dr["TELEFONE"].ToString();
                    }
                    else
                    {

                    }
                    txtFacebook.Text = dr["FACEBOOK"].ToString();
                    txtTwitter.Text = dr["TWITTER"].ToString();
                    txtInstagram.Text = dr["INSTAGRAM"].ToString();

                    // txtDataNasc.Attributes["type"] = "date";
                    DateTime data = new DateTime();
                    data = Convert.ToDateTime(dr["DATA_NASC"]);
                    txtDataNasc.Text = data.ToString("yyyy-MM-dd");

                    if (dr["URL_IMG"].ToString() == string.Empty)
                    {
                        imgArtista.Attributes.Add("src", "../img/PerfilIcone.png");
                    }
                    else
                    {
                        imgArtista.ImageUrl = "../img/" + dr["URL_IMG"].ToString().Substring(dr["URL_IMG"].ToString().LastIndexOf("\\") + 1);
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

        public void CarregarHistorico()
        {
            try
            {
                obj.ID_ARTISTA_GERAL = Convert.ToInt32(Request.QueryString["id"]);
                dtEventos.DataSource = obj.ListarHistorico().Tables[0];
                dtEventos.DataBind();

                //DataTable dt = new DataTable();
                //obj.ID_ARTISTA_GERAL = Convert.ToInt32(Request.QueryString["id"]);
                //dt = obj.ListarHistorico().Tables[0];
                //int total = dt.Rows.Count;
                //int contagem = 0;
                //string[] Titulo = new string[total];
                //string[] DatadoEvento = new string[total];
                //string[] Horario = new string[total];
                //string[] Duracao = new string[total];
                //string[] Descricao = new string[total];
                //int[] N_Artistas = new int[total];
                //int[] CodEvento = new int[total];
                //foreach (DataRow linha in dt.Rows)
                //{
                //    if (contagem != total)
                //    {
                //        Titulo[contagem] = Convert.ToString(linha["TITULO"]);
                //        DatadoEvento[contagem] = Convert.ToString(linha["DATA_EVENTO"].ToString().Substring(0, 10));
                //        Horario[contagem] = Convert.ToString(linha["HORARIO"]);
                       
                //        Duracao[contagem] = Convert.ToString(linha["DURACAO"]);
                //        Descricao[contagem] = Convert.ToString(linha["DESCRICAO"]);
                //        N_Artistas[contagem] = Convert.ToInt32(linha["N_ARTISTAS"]);
                //        CodEvento[contagem] = Convert.ToInt32(linha["ID_EVENTO"]);
                       
                //        if (contagem != 0)
                //        {
                //            if (CodEvento[contagem] == CodEvento[contagem - 1])
                //            {
                //                Titulo[contagem - 1] = string.Empty;
                //                DatadoEvento[contagem - 1] = string.Empty;
                //                Horario[contagem - 1] = string.Empty;
                //                Duracao[contagem - 1] = string.Empty;
                //                Descricao[contagem - 1] = string.Empty;
                //                N_Artistas[contagem - 1] = 0;
                //                CodEvento[contagem - 1] = 0;
                               
                               

                //            }
                //        }
                //        contagem = contagem + 1;
                //    }

                //}

                //if (dt.Rows.Count > 0)
                //{
                //    tvHistorico.Visible = true;
                //    tvHistorico.Nodes.Clear();
                //}
                //else
                //{
                //    tvHistorico.Visible = false;
                //}
                //while (contagem != 0)
                //{

                //    if (CodEvento[contagem - 1] != 0)
                //    {
                //        TreeNode rootNode = new TreeNode();

                        
                //        rootNode.Text = Titulo[contagem - 1];
                //        tvHistorico.Nodes.Add(rootNode);
                       

                //        rootNode.Value = CodEvento[contagem - 1].ToString();


                //        TreeNode statesData = new TreeNode();
                //        statesData.Text = "Data:";
                //        rootNode.ChildNodes.Add(statesData);

                //        TreeNode cData = new TreeNode();
                //        cData.Text = DatadoEvento[contagem - 1];
                //        statesData.ChildNodes.Add(cData);

                //        TreeNode statesHorario = new TreeNode();
                //        statesHorario.Text = "Horario:";
                //        rootNode.ChildNodes.Add(statesHorario);

                //        TreeNode cHorario = new TreeNode();
                //        cHorario.Text = Horario[contagem - 1];
                //        statesHorario.ChildNodes.Add(cHorario);

                //        TreeNode statesDuracao = new TreeNode();
                //        statesDuracao.Text = "Duração:";
                //        rootNode.ChildNodes.Add(statesDuracao);

                //        TreeNode cDuracao = new TreeNode();
                //        cDuracao.Text = Duracao[contagem - 1];
                //        statesDuracao.ChildNodes.Add(cDuracao);

                //        TreeNode statesDescricao = new TreeNode();
                //        statesDescricao.Text = "Descrição:";
                //        rootNode.ChildNodes.Add(statesDescricao);

                //        TreeNode cDescricao = new TreeNode();
                //        cDescricao.Text = Descricao[contagem - 1];
                //        statesDescricao.ChildNodes.Add(cDescricao);

                //        TreeNode statesN_Art = new TreeNode();
                //        statesN_Art.Text = "Número de Artistas:";
                //        rootNode.ChildNodes.Add(statesN_Art);

                //        TreeNode cN_Arts = new TreeNode();
                //        cN_Arts.Text = Convert.ToString(N_Artistas[contagem - 1]);
                //        statesN_Art.ChildNodes.Add(cN_Arts);







                //    }

                //    contagem = contagem - 1;
                //}
                //foreach (TreeNode n in tvHistorico.Nodes)
                //{

                //    n.SelectAction = TreeNodeSelectAction.Expand;



                //}
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void dtEventos_ItemDataBound(object sender, ListViewItemEventArgs e)
        {

            Image img = (Image)e.Item.FindControl("imgEvento");
            if (img != null)
            {
                if (img.ImageUrl == string.Empty)
                {
                    img.Attributes.Add("src", "../img/ComedyImagem.png");
                }
                else
                {
                    img.ImageUrl = "../img/" + img.ImageUrl.ToString().Substring(img.ImageUrl.ToString().LastIndexOf("\\") + 1);
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