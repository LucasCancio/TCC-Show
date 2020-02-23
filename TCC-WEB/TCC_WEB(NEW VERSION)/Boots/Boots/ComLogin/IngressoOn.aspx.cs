using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boots.ComLogin
{
    public partial class IngressoOn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregarInformações();
                CarregarCampos();
                ViewState["ValorTotal"] = 0;
            }
        }


        private void AdicionarAssento()
        {


            try
            {
                BLL.Artista arti = new BLL.Artista();





                DataTable dtAssentos = new DataTable();


                if (ViewState["dtAssentos"] != null)
                {
                    dtAssentos = (DataTable)ViewState["dtAssentos"];

                }



                if (dtAssentos.Columns.Count == 0)
                {

                    dtAssentos.Columns.Add("ASSENTO_NUMER", typeof(string));
                    dtAssentos.Columns.Add("ASSENTO_FILEIRA", typeof(string));
                    dtAssentos.Columns.Add("ASSENTO_TIPO", typeof(string));
                    dtAssentos.Columns.Add("ASSENTO_SETOR", typeof(string));
                    dtAssentos.Columns.Add("VALOR", typeof(string));


                }

                DataRow dr = dtAssentos.NewRow();




                dr[0] = ViewState["Numero"];
                dr[1] = ViewState["Fileira"];
                dr[2] = ViewState["Tipo"];
                dr[3] = ViewState["Setor"];
                dr[4] = ViewState["Valor"];




                ViewState["dtAssentos"] = dtAssentos;
                dtAssentos.Rows.Add(dr);
                dgvAssentos.DataSource = dtAssentos;
                dgvAssentos.DataBind();

                ViewState["ValorTotal"] = Convert.ToDouble(ViewState["ValorTotal"].ToString()) + Convert.ToDouble(ViewState["Valor"].ToString());
                lblValorTotal.Text = ViewState["ValorTotal"].ToString();
                var pbs = pnAssentos.Controls.OfType<ImageButton>();
                foreach (ImageButton rb in pbs)
                {

                    if (rb.ID == ViewState["objeto"].ToString())
                    {
                        if (ViewState["objeto"].ToString().Length == 9)//  10e11    13e14    15e16    18e19    21e22    24e25    27e28 
                        {

                            rb.Enabled = false;
                            rb.ImageUrl = "~/img/AssentoIconeDuploSelect.png";
                            // rb.Image = TCCSHOWSQL.Properties.Resources.AssentoIconeDuploSelect;

                        }
                        else if (ViewState["objeto"].ToString().Length == 7)// 1e2     4e5    7e8  
                        {

                            rb.Enabled = false;
                            rb.ImageUrl = "~/img/AssentoIconeDuploSelect.png";
                            // rb.Image = TCCSHOWSQL.Properties.Resources.AssentoIconeDuploSelect;

                        }
                        else
                        {
                            if (ViewState["objeto"].ToString().IndexOf("ESP") > 0)
                            {
                                rb.ImageUrl = "~/img/AssentoIconeEspecialSelect.png";
                                // rb.Image = TCCSHOWSQL.Properties.Resources.AssentoIconeEspecialSelect;
                            }
                            else
                            {
                                rb.ImageUrl = "~/img/AssentoIconePadraoSelect.png";
                                // rb.Image = TCCSHOWSQL.Properties.Resources.AssentoIconePadraoSelect;
                            }
                            rb.Enabled = false;

                        }
                    }

                }

                ViewState["AssentosDisponiveis"] = Convert.ToInt32(lblAssentosDisponiveis.Text);
                ViewState["AssentosDisponiveis"] = Convert.ToInt32(ViewState["AssentosDisponiveis"]) - 1;
                this.lblAssentosDisponiveis.Text = ViewState["AssentosDisponiveis"].ToString();

                lblValorTotal.Text = String.Format("{0:c}", Convert.ToDouble(ViewState["ValorTotal"].ToString()));
                lblTotalEscolhido.Text = dgvAssentos.Rows.Count.ToString() + " Assentos";

                Session["ValorTotal"] = ViewState["ValorTotal"];

                ViewState["Numero"] = string.Empty;
                ViewState["Fileira"] = string.Empty;
                ViewState["Tipo"] = string.Empty;
                ViewState["Setor"] = string.Empty;
                ViewState["Valor"] = string.Empty;
                ViewState["Percent"] = string.Empty;


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw;
            }


        }







        protected void EscolherAssento(object sender, ImageClickEventArgs e)
        {
            try
            {


                //this.erro.SetError(this.txtNomeCliente, String.Empty);

                var b = (ImageButton)sender;
                switch (b.ID.Substring(0, 1))
                {
                    case "A":
                        ViewState["Fileira"] = "A";
                        ViewState["Setor"] = "Ouro";
                        break;
                    case "B":
                        ViewState["Fileira"] = "B";
                        ViewState["Setor"] = "Ouro";
                        break;
                    case "C":
                        ViewState["Fileira"] = "C";
                        ViewState["Setor"] = "Ouro";
                        break;
                    case "D":
                        ViewState["Fileira"] = "D";
                        ViewState["Setor"] = "Prata";
                        break;
                    case "E":
                        ViewState["Fileira"] = "E";
                        ViewState["Setor"] = "Prata";
                        break;
                    case "F":
                        ViewState["Fileira"] = "F";
                        ViewState["Setor"] = "Bronze";
                        break;
                    case "G":
                        ViewState["Fileira"] = "G";
                        ViewState["Setor"] = "Bronze";
                        break;
                    case "H":
                        ViewState["Fileira"] = "H";
                        ViewState["Setor"] = "Bronze";
                        break;
                }
                if (b.ID.Substring(0, 1) != "A" && b.ID.Substring(0, 1) != "B" && b.ID.Substring(0, 1) != "C" &&
                    b.ID.Substring(0, 1) != "D" && b.ID.Substring(0, 1) != "E" && b.ID.Substring(0, 1) != "F" &&
                    b.ID.Substring(0, 1) != "G" && b.ID.Substring(0, 1) != "H")
                {

                    return;
                }
                ///////////
                if (b.ID.Length == 3 || b.ID.Length == 9 || b.ID.Length == 6)// 10 ATÉ 28 
                {
                    ViewState["Numero"] = b.ID.Substring(1, 2);
                    if (b.ID.Length == 6)
                    {
                        switch (b.ID.Substring(3, 3))
                        {
                            case "ESP":
                                ViewState["Tipo"] = "Especial";
                                break;
                        }
                    }
                    else if (b.ID.IndexOf("e") > 0)
                    {
                        ViewState["Tipo"] = "Duplo";
                        ViewState["Numero"] = b.ID.Substring(1, 2) + " e " + b.ID.Substring(4, 2);
                    }
                    else
                    {
                        ViewState["Tipo"] = "Simples";
                    }
                }
                else if (b.ID.Length == 2 || b.ID.Length == 7)//0 ATÉ 9
                {
                    ViewState["Numero"] = b.ID.Substring(1, 1);
                    if (b.ID.Length == 5)
                    {
                        switch (b.ID.Substring(2, 3))
                        {
                            case "ESP":
                                ViewState["Tipo"] = "Especial";
                                break;

                        }
                    }
                    if (b.ID.IndexOf("e") > 0)
                    {
                        ViewState["Tipo"] = "Duplo";
                        ViewState["Numero"] = b.ID.Substring(1, 1) + " e " + b.ID.Substring(3, 1);
                    }
                    else
                    {
                        ViewState["Tipo"] = "Simples";
                    }
                }

                ViewState["objeto"] = b.ID;

                BLL.Assento medi = new BLL.Assento();
                System.Data.SqlClient.SqlDataReader dr;
                medi.Assento_Fileira = ViewState["Fileira"].ToString();
                medi.Assento_Numer = ViewState["Numero"].ToString().Replace(" ", "");
                dr = medi.ConsultarPercentual();
                if (dr.Read())
                {
                    double valor;
                    if (Convert.ToInt32(dr["PERC"]) == 0)
                    {
                        valor = Convert.ToDouble(ViewState["ValorEvento"].ToString().Replace("R$", ""));
                    }
                    else
                    {
                        valor = (Convert.ToInt32(dr["PERC"]) * Convert.ToDouble(ViewState["ValorEvento"].ToString().Replace("R$", "")) / 100) + Convert.ToDouble(ViewState["ValorEvento"].ToString().Replace("R$", ""));

                    }
                    ViewState["Percent"] = dr["PERC"].ToString() + "%";
                    ViewState["Valor"] = valor.ToString();
                    AdicionarAssento();
                }

                ////////////
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw;
            }

        }

        BLL.Evento obj = new BLL.Evento();
        public void CarregarInformações()
        {

            try
            {
                System.Data.SqlClient.SqlDataReader dr;
                obj.ID_EVENTO = Convert.ToInt32(Request.QueryString["id"]);
                dr = obj.Consultar();

                if (dr.Read())
                {

                    Session["DataDoEvento"] = dr["DATA_EVENTO"].ToString();




                    //this.lblDescricao.Text = dr["DESCRICAO"].ToString();
                    this.lblTitulo.Text = dr["TITULO"].ToString();
                    ViewState["ValorEvento"] = "R$ " + dr["VALOR_EVENTO"].ToString();

                }
                else
                {
                    Response.Redirect("HomeOn.aspx");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        private void CarregarCampos()
        {

            {
                try
                {

                    ViewState["AssentosDisponiveis"] = Convert.ToInt32(lblAssentosDisponiveis.Text);

                    BLL.Ingresso func = new BLL.Ingresso();
                    BLL.Assento ass = new BLL.Assento();
                    System.Data.DataTable dt;

                    func.ID_EVENTO = Convert.ToInt32(Request.QueryString["id"]);
                    dt = func.ConsultarPorEvento();


                    foreach (DataRow dr in dt.Rows)
                    {
                        ViewState["Id_Assento"] = Convert.ToInt32(dr["ID_ASSENTO"]);
                        ViewState["Id_Cliente"] = Convert.ToInt32(dr["ID_CLIENTE"]);
                        string Assento_number = dr["ASSENTO_NUMER"].ToString();
                        string Assento_Fileira = dr["ASSENTO_FILEIRA"].ToString();
                        string Assento_Tipo = dr["TIPO_ASSENTO"].ToString();
                        string Assento_Categoria = dr["SETOR"].ToString();

                        string ob = Assento_Fileira + Assento_number;
                        if (Assento_Tipo.ToUpper() != "SIMPLES")
                        {
                            ob = Assento_Fileira + Assento_number.Replace(" ", "") + Assento_Tipo.Substring(0, 3).ToUpper();
                        }


                        var pbs = pnAssentos.Controls.OfType<ImageButton>();
                        foreach (ImageButton rb in pbs)
                        {

                            if (rb.ID == ob)
                            {
                                if (rb.ID.Length == 9)//  10e11    13e14    15e16    18e19    21e22    24e25    27e28 
                                {

                                    rb.ImageUrl = "~/img/AssentoIconeDuploRemovido.png";

                                }
                                else if (rb.ID.Length == 7)// 1e2     4e5    7e8  
                                {
                                    rb.ImageUrl = "~/img/AssentoIconeDuploRemovido.png";
                                    //rb.Image = TCCSHOWSQL.Properties.Resources.AssentoIconeDuploRemovido;

                                }
                                else
                                {
                                    if (rb.ID.IndexOf("ESP") > 0)
                                    {
                                        rb.ImageUrl = "~/img/AssentoIconeEspecialRemovido.png";
                                        //rb.Image = TCCSHOWSQL.Properties.Resources.AssentoIconeEspecialRemovido;
                                    }
                                    else
                                    {
                                        rb.ImageUrl = "~/img/AssentoRemovido.png";
                                        //rb.Image = TCCSHOWSQL.Properties.Resources.AssentoRemovido;
                                    }

                                }
                                rb.ImageUrl = "~/img/AssentoRemovido.png";
                                //rb.Image = TCCSHOWSQL.Properties.Resources.AssentoRemovido;
                                rb.ID = Session["IdCliente-LOGADO"].ToString() + "e" + ViewState["Id_Assento"].ToString();
                                rb.Enabled = false;
                                rb.Click += VOID;
                                ViewState["AssentosDisponiveis"] = Convert.ToInt32(ViewState["AssentosDisponiveis"]) - 1;
                                this.lblAssentosDisponiveis.Text = ViewState["AssentosDisponiveis"].ToString();

                                BLL.Cliente cli = new BLL.Cliente();
                                System.Data.SqlClient.SqlDataReader dr3;
                                cli.ID_CLIENTE = Convert.ToInt32(rb.ID.Substring(0, rb.ID.IndexOf("e")).Trim());
                                cli.ID_ASSENTO = Convert.ToInt32(rb.ID.Substring(rb.ID.IndexOf("e") + 1).Trim());
                                ViewState["Id_Assento"] = Convert.ToInt32(rb.ID.Substring(rb.ID.IndexOf("e") + 1).Trim());
                                cli.ID_EVENTO = Convert.ToInt32(Request.QueryString["id"]);
                                dr3 = cli.ConsultarPorCliente();
                                if (dr3.Read())
                                {
                                    if (Session["IdCliente-LOGADO"] !=null)
                                    {
                                        if (dr3["ID_CLIENTE"].ToString() == Session["IdCliente-LOGADO"].ToString())
                                        {
                                            rb.ToolTip = "Assento comprado por você";
                                        }
                                    }
                                    // rb.ToolTip = "Assento ocupado por: " + dr3["NOME"].ToString();

                                    // rb.ContextMenuStrip = menuAssento;
                                    rb.ID = rb.ID + "v" + dr3["ID_VENDA"].ToString();

                                }
                                // rb.Cursor = Cursors.No;
                            }
                        }


                    }







                    this.lblAssentosDisponiveis.Text = ViewState["AssentosDisponiveis"].ToString();



                }
                catch (Exception ex)
                {
                    // MessageBox.Show("Erro: " + ex.Message, ex.Source);
                }
            }
        }

        private void VOID(object sender, ImageClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void dgvAssentos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //if (e.CommandName == "Delete")
            //{

            //}
        }



        protected void dgvAssentos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Index = e.RowIndex;





            try
            {





                ViewState["ValorTotal"] = Convert.ToDouble(ViewState["ValorTotal"].ToString()) - Convert.ToDouble(this.dgvAssentos.Rows[Index].Cells[4].Text.ToString());

                ViewState["AssentosDisponiveis"] = Convert.ToInt32(ViewState["AssentosDisponiveis"]) + 1;
                this.lblAssentosDisponiveis.Text = ViewState["AssentosDisponiveis"].ToString();


                lblValorTotal.Text = ViewState["ValorTotal"].ToString();
                string ob = this.dgvAssentos.Rows[Index].Cells[1].Text.ToString() + this.dgvAssentos.Rows[Index].Cells[0].Text.ToString();
                if (this.dgvAssentos.Rows[Index].Cells[2].Text.ToString() != "Simples")
                {
                    ob = this.dgvAssentos.Rows[Index].Cells[1].Text.ToString() + this.dgvAssentos.Rows[Index].Cells[0].Text.ToString().Replace(" ", "") + this.dgvAssentos.Rows[Index].Cells[2].Text.ToString().Substring(0, 3).ToUpper();
                }
                var pbs = pnAssentos.Controls.OfType<ImageButton>();
                foreach (ImageButton rb in pbs)
                {

                    if (rb.ID == ob)
                    {
                        rb.Enabled = true;
                        if (this.dgvAssentos.Rows[Index].Cells[0].Text.ToString().IndexOf("e") > 0)
                        {
                            rb.ImageUrl = "~/img/AssentoIconeDuplo.png";
                            // rb.Image = TCCSHOWSQL.Properties.Resources.AssentoIconeDuplo;
                        }
                        else if (ob.Length == 6)
                        {
                            rb.ImageUrl = "~/img/AssentoIconeEspecial.png";
                            // rb.Image = TCCSHOWSQL.Properties.Resources.AssentoIconeEspecial;

                        }
                        else
                        {
                            rb.ImageUrl = "~/img/AssentoIcone.png";
                            // rb.Image = TCCSHOWSQL.Properties.Resources.AssentoIcone;
                        }


                    }
                }

                lblValorTotal.Text = String.Format("{0:c}", Convert.ToDouble(ViewState["ValorTotal"].ToString()));





                DataTable dtAssentos = (DataTable)ViewState["dtAssentos"];

                dtAssentos.Rows.RemoveAt(Index);


                ViewState["dtAssentos"] = dtAssentos;

                this.dgvAssentos.DataSource = dtAssentos;
                this.dgvAssentos.DataBind();

                lblTotalEscolhido.Text = dgvAssentos.Rows.Count.ToString() + " Assentos";
                if (Convert.ToDouble(ViewState["ValorTotal"]) < 0)
                {
                    ViewState["ValorTotal"] = 0;
                }
                Session["ValorTotal"] = ViewState["ValorTotal"];

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }



        }
        BLL.Assento asse = new BLL.Assento();
        System.Data.SqlClient.SqlDataReader dr;
        int IdAssento;
        protected void btnAvancar_Click(object sender, EventArgs e)
        {
            Session["TotalAssentos"] = dgvAssentos.Rows.Count;
            int[] Id_Assento = new int[dgvAssentos.Rows.Count];
            foreach (GridViewRow linha in dgvAssentos.Rows)
            {
               
                asse.Assento_Numer = linha.Cells[0].Text.ToString();
                asse.Assento_Fileira = linha.Cells[1].Text.ToString();
                dr= asse.ConsultarAssento();
                
                if (dr.Read())
                {
                    IdAssento = Convert.ToInt32(dr["ID_ASSENTO"]);
                }
                Id_Assento[linha.RowIndex] = IdAssento;
                
            }
            Session["NomeProduto"] = "Ingresso(s) do evento: " + lblTitulo.Text;
            Session["IdAssentos[]"] = Id_Assento;
            Response.Redirect("~/ComLogin/PagamentoOn.aspx?id_ev="+ Request.QueryString["id"].ToString() );
        }

        
    }
}
