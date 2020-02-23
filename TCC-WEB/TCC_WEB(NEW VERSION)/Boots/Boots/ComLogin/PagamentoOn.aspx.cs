
using dotnetraptors.Brazil.Boleto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;


namespace Boots.ComLogin
{
    public partial class PagamentoOn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["ValorTotal"] == null)
                {


                    Response.Redirect("~/ComLogin/HomeOn.aspx");
                }
                this.lblValorTotal.Text = String.Format("{0:c}", Convert.ToDouble(Session["ValorTotal"].ToString()));
                //this.txtValorPagar.Text = String.Format("{0:c}", Convert.ToDouble(Session["ValorTotal"].ToString()));
            }
            else
            {

            }

            if (Request.QueryString["id_ev"] == null)
            {
                if (Session["ValorTotal"] == null)
                {


                    Response.Redirect("~/ComLogin/HomeOn.aspx");
                }
                else
                {
                    Response.Redirect("~/ComLogin/HomeOn.aspx");
                }

            }


        }

        protected void lblTermos_Click(object sender, EventArgs e)
        {
            if (pnTermos.Visible)
            {
                pnTermos.Visible = false;
            }
            else
            {
                pnTermos.Visible = true;
            }
        }

        protected void ddlParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (ddlParcelas.Text)
            //{
            //    case"1x":
            //        this.txtValorPagar.Text = String.Format("{0:c}", Convert.ToDouble(Session["ValorTotal"].ToString()));
            //        break;
            //    case "2x":
            //        this.txtValorPagar.Text = String.Format("{0:c}", Convert.ToDouble(Session["ValorTotal"].ToString())/2);
            //        break;
            //    case "3x":
            //        this.txtValorPagar.Text = String.Format("{0:c}", Convert.ToDouble(Session["ValorTotal"].ToString())/3);
            //        break;
            //}
        }



        public int Id_Pagamento, Id_EI, Id_Venda, Id_Conta;

        protected void ckTermos_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTermos.Checked)
            {
                btnComprar.Enabled = true;
            }
            else
            {
                btnComprar.Enabled = false;
            }
        }

        protected void MudarForma(object sender, EventArgs e)
        {
            try
            {
                if (rbCredito.Checked)
                {
                    pnCartao.Visible = true;
                    pnParcelas.Visible = true;
                    pnBoleto.Visible = false;
                }
                else if (rbDebito.Checked)
                {
                    pnCartao.Visible = true;
                    pnParcelas.Visible = false;
                    pnBoleto.Visible = false;
                }
                else
                {
                    pnCartao.Visible = false;
                    pnBoleto.Visible = true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        protected void VerificarCep(object sender, EventArgs e)
        {
            try
            {
                this.txtLogradouro.Text = string.Empty;
                this.txtCidade.Text = string.Empty;
                this.txtBairro.Text = string.Empty;
                pnErro2.Visible = false;
                if (txtCEP.Text.Trim() == string.Empty)
                {
                    pnErro2.Visible = true;
                    lblErro2.Text = "Preencha o campo <b>CEP</b>!";
                    return;
                }

                BLL.CEP obj = new BLL.CEP();
                System.Data.SqlClient.SqlDataReader dr;
                obj.Cep = txtCEP.Text.Replace("-", "").Trim();
                dr = obj.Consultar();
                if (dr.Read())
                {
                    this.txtLogradouro.Text = dr["DESCRICAO"].ToString();
                    this.txtCidade.Text = dr["CIDADE"].ToString();
                    this.txtBairro.Text = dr["BAIRRO"].ToString();
                    this.ddlEstados.SelectedValue = dr["UF"].ToString();
                }
                else
                {
                    pnErro2.Visible = true;
                    lblErro2.Text = "<b>CEP</b> inválido!";
                    return;
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        protected void VerificarDesconto(object sender, EventArgs e)
        {
            try
            {


                if (this.txtCodPromo.Text != string.Empty)
                {
                    if (btnVerificar.Text == "Remover")
                    {
                        ViewState["IdDesconto"] = null;
                        this.txtDesconto.Text = "0";
                        this.txtCodPromo.Text = string.Empty;
                        this.txtCodPromo.Enabled = true;
                        this.txtPorct.Text = string.Empty;
                        this.btnVerificar.Text = "Verificar";
                        this.pnDesconto.Visible = false;
                    }
                    else
                    {
                        this.pnErro.Visible = false;
                        BLL.Desconto obj = new BLL.Desconto();
                        System.Data.SqlClient.SqlDataReader dr;
                        obj.COD_PROMOCIONAL = this.txtCodPromo.Text.ToUpper();
                        dr = obj.Consultar();

                        if (dr.Read())
                        {
                            ViewState["IdDesconto"] = Convert.ToInt32(dr["ID_DESCONTO"]);
                            string porcentagem = dr["DESCONTO"].ToString();
                            this.txtPorct.Text = porcentagem + "%";
                            string texto = Convert.ToString((Convert.ToDouble(lblValorTotal.Text.Replace("R$", "").ToString()) * Convert.ToDouble(porcentagem.Replace("%", ""))) / 100);
                            this.txtDesconto.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", texto);
                            this.btnVerificar.Text = "Remover";
                            this.txtCodPromo.Text = txtCodPromo.Text.ToUpper();
                            this.txtCodPromo.Enabled = false;
                            this.pnDesconto.Visible = true;
                        }
                        else
                        {
                            pnErro.Visible = true; pnErro.Focus();
                            lblErro.Text = "Esse código <b>não existe</b> ou está <b>desabilitado!</b>";
                            return;
                        }
                    }

                }
                else
                {
                    pnErro.Visible = true; pnErro.Focus();

                    lblErro.Text = "<b>Código Promocional</b> não está preenchido!";
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void Finalizar(object sender, EventArgs e)
        {

            try
            {
                pnErro2.Visible = false;

                if (!rbBoleto.Checked)
                {
                    if (!rbVisa.Checked && !rbMasterCard.Checked)
                    {
                        pnErro2.Visible = true;
                        lblErro2.Text = "Selecione uma <b>Bandeira</b>!";
                        return;
                    }
                }
                else
                {
                    if (txtCEP.Text.Trim()==string.Empty)
                    {
                        pnErro2.Visible = true;
                        lblErro2.Text = "Preencha o campo <b>CEP</b>!";
                        return;
                    }
                    if (txtLogradouro.Text.Trim() == string.Empty)
                    {
                        pnErro2.Visible = true;
                        lblErro2.Text = "Preencha o campo <b>Logradouro</b>!";
                        return;
                    }
                    if (txtCidade.Text.Trim() == string.Empty)
                    {
                        pnErro2.Visible = true;
                        lblErro2.Text = "Preencha o campo <b>Cidade</b>!";
                        return;
                    }
                    if (txtBairro.Text.Trim() == string.Empty)
                    {
                        pnErro2.Visible = true;
                        lblErro2.Text = "Preencha o campo <b>Bairro</b>!";
                        return;
                    }
                    if (txtNumero.Text.Trim()==string.Empty)
                    {
                        pnErro2.Visible = true;
                        lblErro2.Text = "Preencha o campo <b>Número</b>!";
                        return;

                    }
                    else
                    {

                        if (Convert.ToDouble(txtNumero.Text.Trim()) <= 0)
                        {
                            pnErro2.Visible = true;
                            lblErro2.Text = "<b>Número</b> inválido!";
                            return;
                        }
                    }
                }

                if (!rbBoleto.Checked)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openMessageBox();", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openBoletoBox();", true);
                }

             



            }
            catch (Exception ex)
            {
                pnErro2.Visible = true;
                lblErro2.Text = "<b>Erro: </b>" + ex.Message + " <b>Favor contatar o gerente!</b>";
                return;

            }

        }

       
        protected void EfetuarCompra(object o, EventArgs e)
        {
            try
            {
                if (rbBoleto.Checked)
                {
                    BLL.Evento obj = new BLL.Evento();
                    BLL.Cliente obj2 = new BLL.Cliente();
                    System.Data.SqlClient.SqlDataReader dr;
                    obj2.ID_LOGIN = Convert.ToInt32(Session["IdLogin-LOGADO"]);
                    obj.ID_EVENTO = Convert.ToInt32(Request.QueryString["id_ev"]);
                    dr = obj.Consultar();
                    if (dr.Read())
                    {
                        ViewState["DATA_EVENTO"] = dr["DATA_EVENTO"].ToString().Substring(0, 10);
                    }
                    dr = obj2.Consultar();
                    if (dr.Read())
                    {
                        ViewState["CPF"] = dr["CPF"];
                        ViewState["NOME"] = dr["NOME"];
                    }

                    DateTime data = Convert.ToDateTime(ViewState["DATA_EVENTO"]);
                    GerarBoleto();

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "AbrirBoleto();", true);
                }
                try
                {
                    pnErro2.Visible = false;
                    int[] Id_Assento = (int[])Session["IdAssentos[]"];


                    BLL.Contas cont = new BLL.Contas();
                    BLL.Ingresso func = new BLL.Ingresso();
                    BLL.Assento ass = new BLL.Assento();
                    BLL.Desconto dsc = new BLL.Desconto();
                    System.Data.SqlClient.SqlDataReader dr;
                    func.ID_CLIENTE = Convert.ToInt32(Session["IdCliente-LOGADO"]);

                    func.Ativo = 1;

                    func.ID_EVENTO = Convert.ToInt32(Request.QueryString["id_ev"]);
                    dr = func.ConsultarPorCliente();
                    if (dr.Read())
                    {


                        Id_EI = Convert.ToInt32(dr["ID_EI"]);
                        Id_Venda = Convert.ToInt32(dr["ID_VENDA"]);
                        Id_Pagamento = Convert.ToInt32(dr["ID_PAGAMENTO"]);

                    }
                    func.Situacao = "A Pagar";
                    func.Preco_Total = this.lblValorTotal.Text.Replace("R$", "").Replace(" ", "");
                    func.ID_EI = Id_EI;
                    func.ID_VENDA = Id_Venda;
                    func.ID_PAGAMENTO = Id_Pagamento;
                    cont.ID_CONTAS = Id_Conta;
                    func.Desconto = txtDesconto.Text.Replace("R$", "").Replace(" ", "");
                    func.Preco_Total_Pago = this.lblValorTotal.Text.Replace("R$", "").Replace(" ", "");
                    func.Troco = "0";
                    cont.Valor_Total = Convert.ToDouble(this.lblValorTotal.Text.Replace("R$", "").Replace(" ", ""));
                    cont.Tipo_Conta = "Receber";
                    cont.Ativo = 1;
                    cont.Descricao = "Ingresso de " + Session["TotalAssentos"] + " assento(s), Vendido no WebSite";
                    cont.Data = Session["DataDoEvento"].ToString();
                    cont.Departamento = "BILHETERIA-WEB";
                    cont.Situacao = "Nao recebida";
                    cont.Data_Entregue = DateTime.Now.ToString().Substring(0, 10);

                    if (rbVisa.Checked)
                    {
                        func.BANDEIRA = "VISA";
                    }
                    else if (rbMasterCard.Checked)
                    {
                        func.BANDEIRA = "MASTERCARD";
                    }



                    // MessageBox.Show("teste Salvar"+ operacao);


                    func.IncluirVendaIngresso();
                    int contagem = 1;
                    string Tipo_Pag;
                    if (this.rbBoleto.Checked)
                    {
                        Tipo_Pag = "BOLETO";
                    }
                    else if (this.rbDebito.Checked)
                    {
                        Tipo_Pag = "CARTAO DE DEBITO";
                    }
                    else
                    {
                        Tipo_Pag = "CARTAO DE CREDITO";
                    }
                    string Valor = Convert.ToString(Convert.ToDouble(lblValorTotal.Text.Replace("R$", "")) - Convert.ToDouble(txtDesconto.Text.Replace("R$", "")));
                    if (Tipo_Pag != string.Empty)
                    {
                        func.IncluirPagamento(Tipo_Pag, Valor);
                    }

                    contagem = contagem + 1;

                    int n;


                    func.IncluirEventoIngresso();


                    n = Convert.ToInt32(Session["TotalAssentos"]);


                    while (n != n - n)//assento
                    {

                        func.IncluirAssentoCliente(Id_Assento[n - 1]);
                        func.IncluirItemVenda(Id_Assento[n - 1]);



                        n = n - 1;
                    }


                    if (rbCredito.Checked)
                    {
                        func.QTDE_PARCELAS = Convert.ToInt32(ddlParcelas.Text.Replace("x", ""));
                        func.IncluirDetalhePag("Cred");
                    }
                    else if (rbDebito.Checked)
                    {
                        func.IncluirDetalhePag("Deb");
                    }



                    cont.Data = Convert.ToString(DateTime.Now).Substring(0, 10);
                    cont.TipoData = "Recebimento";


                    cont.Contas_crud('I');

                    cont.IncluirVenda();
                    if (txtCodPromo.Text.Trim() != string.Empty && txtCodPromo.Enabled == false)
                    {
                        dsc.ID_DESCONTO = Convert.ToInt32(ViewState["IdDesconto"]);
                        dsc.ID_CLIENTE = Convert.ToInt32(Session["IdCliente-LOGADO"]);
                        dsc.Descontos_crud('U');
                    }

                    System.Data.SqlClient.SqlDataReader dr2;
                    dr2 = ass.ConsultarValorMaximo();
                    if (dr2.Read())
                    {
                        Id_Venda = Convert.ToInt32(dr2["ID"]);
                    }


                    if (this.rbBoleto.Checked)
                    {
                        //Response.Redirect("~/BoletoBancario.aspx", "_blank", "menubar=0,scrollbars=1,width=780,height=900,top=10");
                        //Response.Redirect("~/ComLogin/HomeOn.aspx");
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                    }

                  







                }
                catch (Exception ex)
                {

                    pnErro2.Visible = true;
                    lblErro2.Text = "<b>Erro: </b>" + ex.Message + " <b>Favor contatar o gerente!</b>";
                    return;
                }

            }
            catch (Exception ex)
            {

                pnErro2.Visible = true;
                lblErro2.Text = "<b>Erro: </b>" + ex.Message + " <b>Favor contatar o gerente!</b>";
                return;
            }
        }
       
        public void GerarBoleto() {

          

            Boleto boletoBB = new BoletoBrasil();
            boletoBB.Aceite = true;
            boletoBB.CedenteAgencia = "1000";
            boletoBB.CedenteConta = "22507";
            boletoBB.CedenteContaDV = "6";
            boletoBB.CedenteDocumento = "85.547.831/0001-30";
            boletoBB.CedenteNome = "Comedy House ltda.";
            boletoBB.Carteira = 16;
            boletoBB.Instrucao1 = "SR(A) CAIXA, NÃO RECEBER APÓS O VENCIMENTO!";
            boletoBB.Sequencial = 123456;
            boletoBB.Documento = "0001";
            boletoBB.DtDocumento = DateTime.Now;
            boletoBB.DtEmissao = DateTime.Now;
            boletoBB.DtProcessamento = DateTime.Now;
            boletoBB.DtVencimento = DateTime.Now.AddDays(7);
            boletoBB.Valor = float.Parse(lblValorTotal.Text.Replace("R$",""))- float.Parse(txtDesconto.Text.Replace("R$", ""));
            boletoBB.SacadoNome = ViewState["NOME"].ToString();
            boletoBB.SacadoEndereco = txtLogradouro.Text;
            boletoBB.SacadoCPF_CNPJ = ViewState["CPF"].ToString();
            boletoBB.SacadoCidade = txtCidade.Text;
            boletoBB.SacadoUF = ddlEstados.SelectedValue;
            boletoBB.SacadoBairro = txtBairro.Text;
            boletoBB.SacadoCEP = txtCEP.Text;
            HTMLBoleto boleto = new HTMLBoleto();
            boleto.ImagesFolder = "../imgBoleto";
            boleto.AddBoleto(boletoBB);
            Session["boleto"] = boleto.ToString();
            //boleto.SaveToFile("ComLogin/BoletoSantader.aspx");
          
           
            //Response.Write(boleto.ToString())









        }

    }
    public static class ResponseHelper
    {
        public static void Redirect(this HttpResponse response, string url, string target, string windowFeatures)
        {

            if ((String.IsNullOrEmpty(target) || target.Equals("_self", StringComparison.OrdinalIgnoreCase)) && String.IsNullOrEmpty(windowFeatures))
            {
                response.Redirect(url);
            }
            else
            {
                Page page = (Page)HttpContext.Current.Handler;

                if (page == null)
                {
                    throw new InvalidOperationException("Cannot redirect to new window outside Page context.");
                }
                url = page.ResolveClientUrl(url);

                string script;
                if (!String.IsNullOrEmpty(windowFeatures))
                {
                    script = @"window.open(""{0}"", ""{1}"", ""{2}"");";
                }
                else
                {
                    script = @"window.open(""{0}"", ""{1}"");";
                }
                script = String.Format(script, url, target, windowFeatures);
                ScriptManager.RegisterStartupScript(page, typeof(Page), "Redirect", script, true);
            }
        }
    }
}