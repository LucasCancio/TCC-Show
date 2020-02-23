using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boots.ComLogin
{
    public partial class FeedbackOn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lvFeedBack_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)e.Item.FindControl("divAlerta");
            Label titulo = (Label)e.Item.FindControl("TituloAlerta");
            Label mensagem = (Label)e.Item.FindControl("MensagemAlerta");
            AjaxControlToolkit.Rating estrela = (AjaxControlToolkit.Rating)e.Item.FindControl("AvaliacaoAlerta");
            if (titulo.Text == string.Empty)
            {
                titulo.Visible = false;
                mensagem.Attributes.Add("class", "h5");
            }

            if (estrela.CurrentRating > 3)
            {
                div.Attributes.Add("class", "alert alert-success");
            }
            else if (estrela.CurrentRating < 3)
            {
                div.Attributes.Add("class", "alert alert-danger");
            }
            else
            {
                div.Attributes.Add("class", "alert alert-warning");
            }

        }


        protected void lvFeedBackCliente_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)e.Item.FindControl("divAlerta");
            Label titulo = (Label)e.Item.FindControl("TituloAlerta");
            Label mensagem = (Label)e.Item.FindControl("MensagemAlerta");
            AjaxControlToolkit.Rating estrela = (AjaxControlToolkit.Rating)e.Item.FindControl("AvaliacaoAlerta");
            if (titulo.Text == string.Empty)
            {
                titulo.Visible = false;
                mensagem.Attributes.Add("class", "h5");
            }

            if (estrela.CurrentRating > 3)
            {
                div.Attributes.Add("class", "alert alert-success");
            }
            else if (estrela.CurrentRating < 3)
            {
                div.Attributes.Add("class", "alert alert-danger");
            }
            else
            {
                div.Attributes.Add("class", "alert alert-warning");
            }

        }
        protected void Enviar(object sender, EventArgs e)
        {
            try
            {
                pnErro.Visible = false;
                if (txtEnviarMensagem.Text == string.Empty)
                {
                    pnErro.Visible = true; pnErro.Focus();
                    lblErro.Text = "<b>Mensagem</b> não preenchida!";
                    return;
                }
                if (Avaliacao.CurrentRating == 0)
                {
                    pnErro.Visible = true; pnErro.Focus();
                    lblErro.Text = "<b>Avaliação</b> não preenchida!";
                    return;
                }
                lblTituloSUC.Text = "FeedBack enviado com sucesso!";
                btnMSGBOX.Visible = true;
              
                btnREMOVER.Visible = false;
                lblMSGBOX.Text = "Deseja enviar o FeedBack?!";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openMessageBox();", true);

            }
            catch (Exception ex)
            {

                pnErro.Visible = true; pnErro.Focus();
                lblErro.Text = "<b>Erro:</b> " + ex.Message + " <b>Favor Contatar o gerente!</b>";
            }
        }
        protected void Enviar2(object o, EventArgs e)
        {
            try
            {

                pnErro.Visible = false;
                BLL.FeedBack obj = new BLL.FeedBack();
                obj.ID_CLIENTE = Convert.ToInt32(Session["IdCliente-LOGADO"]);

                obj.MENSAGEM = txtEnviarMensagem.Text.Trim();
                obj.TITULO = txtEnviarTitulo.Text.Trim().ToUpper();
                obj.AVALIACAO = Avaliacao.CurrentRating;
                obj.IncluirMensagem();

                lvFeedBack.DataBind();

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            }
            catch (Exception ex)
            {

                pnErro.Visible = true; pnErro.Focus();
                lblErro.Text = "<b>Erro:</b> " + ex.Message + " <b>Favor Contatar o gerente!</b>";
            }
        }

        protected void lvFeedBackCliente_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            ViewState["ID_FEEDBACK"] = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName=="Remover")
            {
                lblTituloSUC.Text = "Exclusão realizada com sucesso!";
                lblMSGBOX.Text = "Deseja excluir o FeedBack?!";
                btnMSGBOX.Visible = false;
               
                btnREMOVER.Visible = true;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openMessageBox();", true);
            }
          
        }

        protected void RemoverFeedBack(object o, EventArgs e) {
            try
            {
                BLL.FeedBack obj = new BLL.FeedBack();
                obj.ID_FEEDBACK = Convert.ToInt32(ViewState["ID_FEEDBACK"]);

                obj.RemoverMensagem();

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       
    }
}