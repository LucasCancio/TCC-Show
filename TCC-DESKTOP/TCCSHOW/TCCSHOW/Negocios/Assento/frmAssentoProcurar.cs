using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Assento
{
    public partial class frmAssentoProcurar : Modelos.ModeloPadrao
    {
        public frmAssentoProcurar()
        {
            
            InitializeComponent();
            this.dgvAssentos.DefaultCellStyle.BackColor = Color.LightGray;
            this.dgvAssentos.AlternatingRowsDefaultCellStyle.BackColor =
  Color.Silver;
            txtValorTotal.Text = String.Format("{0:c}", Convert.ToDouble(txtValorTotal.Text.Replace("R$","")));
        }

       

        public int Id_Evento, Id_Cliente, Id_Pagamento, Id_EI, Id_Venda, Id_Assento;
        public double ValorTotal, ValorAssento,AssentosDisponiveis;

        private void Concluir(object sender, EventArgs e)
        {
            
            if (this.dgvAssentos.Rows.Count<=0)
            {
                this.erro.SetError(btnConcluir, "Nenhum assento escolhido!");
                return;
            }
            else
            {
                this.erro.SetError(btnConcluir, string.Empty);
            }
            Retorno = true;
            this.Close();
        }

        private DataGridViewRow adicionar(DataGridViewRow row)
        {
            DataGridViewRow newRow = (DataGridViewRow)row.Clone();
            newRow.Cells[0].Value = row.Cells[0].Value;
            newRow.Cells[1].Value = row.Cells[1].Value;
            newRow.Cells[2].Value = row.Cells[2].Value;
            newRow.Cells[3].Value = row.Cells[3].Value;
            newRow.Cells[4].Value = row.Cells[4].Value;
           

            //newRow.Cells.Remove(newRow.Cells[0]);
            return newRow;
        }

        private void PressDelet(object sender, KeyEventArgs e)
        {
            if (this.dgvAssentos.Rows.Count > 0)
            {
                if (e.KeyCode==Keys.Delete)
                {
                    try
                    {
                        foreach (DataGridViewRow row in dgvAssentos.SelectedRows)
                        {
                            if (!row.IsNewRow)
                            {




                                ValorTotal = Convert.ToDouble(ValorTotal.ToString()) - Convert.ToDouble(this.dgvAssentos.CurrentRow.Cells["VALOR"].Value.ToString());

                                AssentosDisponiveis = AssentosDisponiveis + 1;
                                this.lblAssentosDisponiveis.Text = AssentosDisponiveis.ToString();


                                txtValorTotal.Text = ValorTotal.ToString();

                                string ob = this.dgvAssentos.CurrentRow.Cells["ASSENTO_FILEIRA"].Value.ToString() + this.dgvAssentos.CurrentRow.Cells["ASSENTO_NUMER"].Value.ToString();
                                if (this.dgvAssentos.CurrentRow.Cells["ASSENTO_TIPO"].Value.ToString() != "Simples")
                                {
                                    ob = this.dgvAssentos.CurrentRow.Cells["ASSENTO_FILEIRA"].Value.ToString() + this.dgvAssentos.CurrentRow.Cells["ASSENTO_NUMER"].Value.ToString().Replace(" ", "") + this.dgvAssentos.CurrentRow.Cells["ASSENTO_TIPO"].Value.ToString().Substring(0, 3).ToUpper();
                                }
                                var pbs = gbTelao.Controls.OfType<PictureBox>();
                                foreach (PictureBox rb in pbs)
                                {

                                    if (rb.Name == ob)
                                    {
                                        rb.Enabled = true;
                                        if (this.dgvAssentos.CurrentRow.Cells["ASSENTO_NUMER"].Value.ToString().IndexOf("e") > 0)
                                        {
                                            rb.Image = Properties.Resources.AssentoIconeDuplo;
                                        }
                                        else if (ob.Length == 6)
                                        {
                                            rb.Image = Properties.Resources.AssentoIconeEspecial;

                                        }
                                        else
                                        {
                                            rb.Image = Properties.Resources.AssentoIcone;
                                        }


                                    }
                                }
                                dgvAssentos.Rows.Remove(row);
                                txtValorTotal.Text = String.Format("{0:c}", Convert.ToDouble(txtValorTotal.Text.Replace("R$", "")));
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

     

        public string objeto;

       

        public void VOID(object o, EventArgs e) {

        }

        public bool Retorno = true;
        private void CarregarCampos(object sender, EventArgs e)
        {

            {
                try
                {
                   
                    AssentosDisponiveis = Convert.ToInt32(lblAssentosDisponiveis.Text);
                    //if (NivelAcesso != 1)
                    //{
                    //    this.lblEditarAssento.Visible = false;
                    //    this.btnEditarAssento.Visible = false;
                    //}

                    //if (this.dgvArtistas.DataSource == null)
                    //{
                    //    this.dgvArtistas.Rows.Clear();
                    //}

                    //if (Data != dtpEvento.Value && Data != Convert.ToDateTime(" 01 / 01 / 0001 00:00:00"))
                    //{
                    //    TipoAssento = string.Empty;
                    //    NumeroAssento = string.Empty;
                    //    Categoria = string.Empty;
                    //    Fileira = string.Empty;
                    //    Valor = string.Empty;
                    //    TipoPagamento = string.Empty;
                    //    Evento = string.Empty;
                    //    ValorTotal = 0;
                    //    ValorAssento = 0;

                    //    for (int i = 0; i < Valor2.Length; i++)
                    //    {
                    //        Valor2[i] = 0;
                    //    }
                    //    for (int i = 0; i < Tipo_Pag2.Length; i++)
                    //    {
                    //        Tipo_Pag2[i] = string.Empty;
                    //    }
                       


                    //   // Evento = null;
                    //}



                    //if (Evento == null)
                    //{
                        //this.txtValorTotal.Text = string.Empty;

                        //this.lblAssentosDisponiveis.Text = "170";
                        //AssentosDisponiveis = 170;

                        //foreach (DataGridViewRow row in dgvAssentos.SelectedRows)
                        //{
                        //    if (!row.IsNewRow)
                        //    {




                        //        ValorTotal = ValorTotal - Convert.ToInt32(this.dgvAssentos.CurrentRow.Cells["VALOR"].Value);




                        //        string ob = this.dgvAssentos.CurrentRow.Cells["ASSENTO_FILEIRA"].Value.ToString() + this.dgvAssentos.CurrentRow.Cells["ASSENTO_NUMER"].Value.ToString();
                        //        if (this.dgvAssentos.CurrentRow.Cells["ASSENTO_TIPO"].Value.ToString() != "Simples")
                        //        {
                        //            ob = this.dgvAssentos.CurrentRow.Cells["ASSENTO_FILEIRA"].Value.ToString() + this.dgvAssentos.CurrentRow.Cells["ASSENTO_NUMER"].Value.ToString().Replace(" ", "") + this.dgvAssentos.CurrentRow.Cells["ASSENTO_TIPO"].Value.ToString().Substring(0, 3).ToUpper();
                        //        }
                        //        var pbs = gbTelao.Controls.OfType<PictureBox>();
                        //        foreach (PictureBox rb in pbs)
                        //        {

                        //            if (rb.Name == ob)
                        //            {
                        //                rb.Enabled = true;
                        //                if (this.dgvAssentos.CurrentRow.Cells["ASSENTO_NUMER"].Value.ToString().IndexOf("e") > 0)
                        //                {
                        //                    rb.Image = Properties.Resources.AssentoIconeDuplo;
                        //                }
                        //                else if (ob.Length == 6)
                        //                {
                        //                    rb.Image = Properties.Resources.AssentoIconeEspecial;

                        //                }
                        //                else
                        //                {
                        //                    rb.Image = Properties.Resources.AssentoIcone;
                        //                }


                        //            }
                        //        }
                        //        dgvAssentos.Rows.Remove(row);
                        //    }

                        //}


                        //if (this.dgvArtistas.DataSource != null)
                        //{
                        //    this.dgvArtistas.DataSource = null;
                        //}
                        //else
                        //{
                        //    this.dgvArtistas.Rows.Clear();

                        //}
                        //CarregarCbEvento();

                   // }
                    //else if (this.Evento != this.cbEvento.Text)
                    //{
                    //    CarregarCbEvento();
                    //}
                    BLL.Ingresso func = new BLL.Ingresso();
                    BLL.Assento ass = new BLL.Assento();
                    System.Data.DataTable dt;

                    func.ID_EVENTO = Id_Evento;
                    dt = func.ConsultarPorEvento();


                    foreach (DataRow dr in dt.Rows)
                    {
                        Id_Assento = Convert.ToInt32(dr["ID_ASSENTO"]);
                        Id_Cliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                        string Assento_number = dr["ASSENTO_NUMER"].ToString();
                        string Assento_Fileira = dr["ASSENTO_FILEIRA"].ToString();
                        string Assento_Tipo = dr["TIPO_ASSENTO"].ToString();
                        string Assento_Categoria = dr["SETOR"].ToString();

                        string ob = Assento_Fileira + Assento_number;
                        if (Assento_Tipo.ToUpper() != "SIMPLES")
                        {
                            ob = Assento_Fileira + Assento_number.Replace(" ", "") + Assento_Tipo.Substring(0, 3).ToUpper();
                        }


                        var pbs = gbTelao.Controls.OfType<PictureBox>();
                        foreach (PictureBox rb in pbs)
                        {

                            if (rb.Name == ob)
                            {
                                if (rb.Name.Length == 9)//  10e11    13e14    15e16    18e19    21e22    24e25    27e28 
                                {

                                    rb.Image = Properties.Resources.AssentoIconeDuploRemovido;

                                }
                                else if (rb.Name.Length == 7)// 1e2     4e5    7e8  
                                {

                                    rb.Image = Properties.Resources.AssentoIconeDuploRemovido;

                                }
                                else
                                {
                                    if (rb.Name.IndexOf("ESP") > 0)
                                    {
                                        rb.Image = Properties.Resources.AssentoIconeEspecialRemovido;
                                    }
                                    else
                                    {
                                        rb.Image = Properties.Resources.AssentoRemovido;
                                    }

                                }
                                //rb.Image = Properties.Resources.AssentoRemovido;
                                rb.Name = Id_Cliente.ToString() + "e" + Id_Assento.ToString();
                                rb.Click += VOID;
                                AssentosDisponiveis = AssentosDisponiveis - 1;
                                this.lblAssentosDisponiveis.Text = AssentosDisponiveis.ToString();

                                BLL.Cliente cli = new BLL.Cliente();
                                Oracle.DataAccess.Client.OracleDataReader dr3;
                                //System.Data.OracleClient.OracleDataReader dr3;
                                cli.ID_CLIENTE = Convert.ToInt32(rb.Name.Substring(0, rb.Name.IndexOf("e")).Trim());
                                cli.ID_ASSENTO = Convert.ToInt32(rb.Name.Substring(rb.Name.IndexOf("e") + 1).Trim());
                                Id_Assento = Convert.ToInt32(rb.Name.Substring(rb.Name.IndexOf("e") + 1).Trim());
                                cli.ID_EVENTO = Id_Evento;
                                dr3 = cli.ConsultarPorCliente();
                                if (dr3.Read())
                                {
                                    
                                    ttCliente.SetToolTip(rb, "Assento ocupado por: " + dr3["NOME"].ToString());
                                    rb.ContextMenuStrip = menuAssento;
                                    rb.Name = rb.Name + "v" + dr3["ID_VENDA"].ToString();
                                    
                                }
                                rb.Cursor = Cursors.No;
                            }
                        }


                    }







                    this.lblAssentosDisponiveis.Text = AssentosDisponiveis.ToString();



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, ex.Source);
                }
            }
        }

        private void dgvAssentos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int Assentos = this.dgvAssentos.Rows.Count;
            lblNAssentos.Text = Assentos.ToString() + " Assento(s)";
        }

        private void dgvAssentos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int Assentos = this.dgvAssentos.Rows.Count;
            lblNAssentos.Text = Assentos.ToString() + " Assento(s)";
        }

        private void tsIngresso_Click(object sender, EventArgs e)
        {
            Control c = menuAssento.SourceControl;

            try
                {
                   
                    Ingresso.frmIngresso f = new Ingresso.frmIngresso
                    {
                        FormBorderStyle = FormBorderStyle.FixedToolWindow,
                       
                    };
                    f.MinimizeBox = true;
                    f.Size = new Size(f.Width, f.Height + 15);
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;

                    
                        f.gbCodigo.Visible = true;
                        f.codigo = Convert.ToInt32(c.Name.Substring(c.Name.IndexOf("v"), c.Name.Length - c.Name.IndexOf("v")).Replace("v",""));
                        //f.Ativo = Convert.ToInt32(this.dgv.CurrentRow.Cells[4].Value);
                        f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);


                        f.txtCPF.Enabled = true;

                        f.txtCodigo.Enabled = true;






                        
                            f.txtCPF.Enabled = false;
                            //f.txtNomeFunc.Enabled = false;
                            f.dtpDataNasc.Enabled = false;
                            f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;
                            f.dtpEvento.Enabled = false;
                f.pbConsultarCli.Visible = false;
                f.pbConsultarCli.Enabled = false;
                f.btnConsultarCli.Visible = false;
                f.btnConsultarCli.Enabled = false;
                            //f.cbSexo.Enabled = false;

                            //f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible = false; f.btnLimpar.Visible = false;


                            f.operacao = Convert.ToByte(BLL.Operacao.Consulta);



                    //var b = (Button)sender;
                    //f.lblTitulo.Text =  b.Text;
                    f.Width = f.Width + 10;
                    f.TopMost = true;
                    f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                    f.idFunc = this.idFunc; f.ShowDialog();
                     
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, ex.Source);
                }

            
        }

        private void tsCliente_Click(object sender, EventArgs e)
        {

                Control c = menuAssento.SourceControl;

                try
                {
                    
                    Cliente.frmClienteCadastro f = new Cliente.frmClienteCadastro
                    {
                        operacao = Convert.ToByte(BLL.Operacao.Inclusao),
                        idFunc = this.idFunc,
                        FormBorderStyle = FormBorderStyle.FixedToolWindow,
                       
                    };


                    f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;

                    
                        f.codigo = Convert.ToInt32(c.Name.Substring(0,c.Name.IndexOf("e")));
                        f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);
                        f.txtNome.Enabled = true;
                        f.gbCodigo.Visible = true;
                        // f.txtEndereco.Enabled = true;

                        // f.txtComplemento.Enabled = true;
                        f.txtCodigo.Enabled = true;
                        f.txtSenha.Enabled = false;
                        f.txtUsuario.Enabled = false;
                        // f.txtCidade.Enabled = true;
                        // f.cbEstado.Enabled = true;
                        f.cbSexo.Enabled = true;
                        // f.nupIdade.Enabled = true;
                        f.chkAtivo.Enabled = true;
                        // f.txtBairro.Enabled = true;
                        //  f.nupNumeroCasa.Enabled = true;
                        f.btnSalvar.Visible = true; f.pbSalvar.Visible = true;
                        f.btnSalvar.Enabled = true; f.pbSalvar.Enabled = true;

                        f.btnSalvar.BackColor = Color.Lime;



                       
                            f.txtNome.Enabled = false;

                            // f.txtEndereco.Enabled = false;

                            // f.txtComplemento.Enabled = false;
                            f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;
                            // f.txtCidade.Enabled = false;
                            // f.cbEstado.Enabled = false;
                            f.cbSexo.Enabled = false;
                f.txtEmail.Enabled = false;
                            // f.nupIdade.Enabled = false;
                            f.chkAtivo.Enabled = false;
                            f.txtUsuario.Enabled = false;
                            // f.txtBairro.Enabled = false;
                            // f.nupNumeroCasa.Enabled = false;
                            f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible = false; f.btnLimpar.Visible = false;
                            //f.btnCancelar.Location = new Point(365, 378);
                            //f.pbCancelar.Location = new Point(377, 385);
                            //f.btnCancelar.Text = "Voltar";
                            //f.btnCancelar.Font = new Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold);
                            // f.btnAdicionarContato.Visible = false;
                            f.txtPergunta.Enabled = false;
                            f.btnValidarCPF.Enabled = false;
                            f.txtCPF.Enabled = false;
                            f.txtResposta.Enabled = false;
                            f.dtpDataNasc.Enabled = false;



                            f.operacao = Convert.ToByte(BLL.Operacao.Consulta);
                        
                    
                    //var b = (Button)sender;
                    //f.lblTitulo.Text =  b.Text;
                    f.btnCancelar.Visible = true;
                    f.pbCancelar.Visible = true;
                    f.StartPosition = FormStartPosition.CenterScreen;
                f.Width = f.Width + 10;
                    f.idFunc = this.idFunc; f.ShowDialog();
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, ex.Source);
                }
            
        }

        private void menuAssento_Opening_1(object sender, CancelEventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;

            Control c = menuAssento.SourceControl;

            if (c.Name.IndexOf("0") == 0)
            {
                this.tsCliente.Visible = false;
            }
            else
            {
                this.tsCliente.Visible = true;
            }

        }







        private void AdicionarAssento(object sender, EventArgs e)
        {


            try
            {
                BLL.Artista arti = new BLL.Artista();







                if (this.txtNumero.Text == string.Empty)
                {
                    return;
                }



                if (dgvAssentos.ColumnCount == 0)
                {
                    this.dgvAssentos.Columns.Add("ASSENTO_NUMER", "Número");
                    this.dgvAssentos.Columns.Add("ASSENTO_FILEIRA", "Fileira");
                    this.dgvAssentos.Columns.Add("ASSENTO_TIPO", "Tipo");
                    this.dgvAssentos.Columns.Add("ASSENTO_SETOR", "Setor");
                    this.dgvAssentos.Columns.Add("VALOR", "Valor");


                }
                var index = dgvAssentos.Rows.Add();


                if (this.txtNumero.Text.Length == 7)// DUPLO
                {



                    this.dgvAssentos.Rows[index].Cells["ASSENTO_NUMER"].Value = this.txtNumero.Text;
                    this.dgvAssentos.Rows[index].Cells["ASSENTO_FILEIRA"].Value = this.txtFileira.Text;
                    this.dgvAssentos.Rows[index].Cells["ASSENTO_TIPO"].Value = this.cbTipo.Text;
                    this.dgvAssentos.Rows[index].Cells["ASSENTO_SETOR"].Value = this.cbCategoria.Text;
                    this.dgvAssentos.Rows[index].Cells["VALOR"].Value = this.txtValor.Text;







                }
                else
                {


                    this.dgvAssentos.Rows[index].Cells["ASSENTO_NUMER"].Value = this.txtNumero.Text;
                    this.dgvAssentos.Rows[index].Cells["ASSENTO_FILEIRA"].Value = this.txtFileira.Text;
                    this.dgvAssentos.Rows[index].Cells["ASSENTO_TIPO"].Value = this.cbTipo.Text;
                    this.dgvAssentos.Rows[index].Cells["ASSENTO_SETOR"].Value = this.cbCategoria.Text;
                    this.dgvAssentos.Rows[index].Cells["VALOR"].Value = this.txtValor.Text;



                }
                ValorTotal = ValorTotal + Convert.ToDouble(txtValor.Text);
                txtValorTotal.Text = ValorTotal.ToString();
                var pbs = gbTelao.Controls.OfType<PictureBox>();
                foreach (PictureBox rb in pbs)
                {

                    if (rb.Name == objeto)
                    {
                        if (objeto.Length == 9)//  10e11    13e14    15e16    18e19    21e22    24e25    27e28 
                        {

                            rb.Enabled = false;
                            rb.Image = Properties.Resources.AssentoIconeDuploSelect;

                        }
                        else if (objeto.Length == 7)// 1e2     4e5    7e8  
                        {

                            rb.Enabled = false;
                            rb.Image = Properties.Resources.AssentoIconeDuploSelect;

                        }
                        else
                        {
                            if (objeto.IndexOf("ESP")>0)
                            {
                                rb.Image = Properties.Resources.AssentoIconeEspecialSelect;
                            }
                            else
                            {
                                rb.Image = Properties.Resources.AssentoIconePadraoSelect;
                            }
                            rb.Enabled = false;
                           
                        }
                    }

                }

                AssentosDisponiveis = Convert.ToInt32(lblAssentosDisponiveis.Text);
                AssentosDisponiveis = AssentosDisponiveis - 1;
                this.lblAssentosDisponiveis.Text = AssentosDisponiveis.ToString();

                txtValorTotal.Text = String.Format("{0:c}", Convert.ToDouble(txtValorTotal.Text.Replace("R$","")));

                this.txtNumero.Text = string.Empty;
                this.txtFileira.Text = string.Empty;
                this.cbTipo.Text = string.Empty;
                this.cbCategoria.Text = string.Empty;
                this.txtValor.Text = string.Empty;
                this.txtPercent.Text = string.Empty;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }


        }
        private void ExcluirAssento(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvAssentos.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {



                        
                        ValorTotal = Convert.ToDouble(ValorTotal.ToString()) - Convert.ToDouble(this.dgvAssentos.CurrentRow.Cells["VALOR"].Value.ToString());

                        AssentosDisponiveis = AssentosDisponiveis + 1;
                        this.lblAssentosDisponiveis.Text = AssentosDisponiveis.ToString();


                        txtValorTotal.Text = ValorTotal.ToString();

                        string ob = this.dgvAssentos.CurrentRow.Cells["ASSENTO_FILEIRA"].Value.ToString() + this.dgvAssentos.CurrentRow.Cells["ASSENTO_NUMER"].Value.ToString();
                        if (this.dgvAssentos.CurrentRow.Cells["ASSENTO_TIPO"].Value.ToString() != "Simples")
                        {
                            ob = this.dgvAssentos.CurrentRow.Cells["ASSENTO_FILEIRA"].Value.ToString() + this.dgvAssentos.CurrentRow.Cells["ASSENTO_NUMER"].Value.ToString().Replace(" ", "") + this.dgvAssentos.CurrentRow.Cells["ASSENTO_TIPO"].Value.ToString().Substring(0, 3).ToUpper();
                        }
                        var pbs = gbTelao.Controls.OfType<PictureBox>();
                        foreach (PictureBox rb in pbs)
                        {

                            if (rb.Name == ob)
                            {
                                rb.Enabled = true;
                                if (this.dgvAssentos.CurrentRow.Cells["ASSENTO_NUMER"].Value.ToString().IndexOf("e") > 0)
                                {
                                    rb.Image = Properties.Resources.AssentoIconeDuplo;
                                }
                                else if (ob.Length == 6)
                                {
                                    rb.Image = Properties.Resources.AssentoIconeEspecial;

                                }
                                else
                                {
                                    rb.Image = Properties.Resources.AssentoIcone;
                                }


                            }
                        }
                        dgvAssentos.Rows.Remove(row);
                        txtValorTotal.Text = String.Format("{0:c}", Convert.ToDouble(txtValorTotal.Text.Replace("R$", "")));
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EscolherAssento(object sender, EventArgs e)
        {
            try
            {

                //this.txtNomeCliente.Text = string.Empty;
                //this.erro.SetError(this.txtNomeCliente, String.Empty);

                var b = (PictureBox)sender;
                switch (b.Name.Substring(0, 1))
                {
                    case "A":
                        this.txtFileira.Text = "A";
                        this.cbCategoria.Text = "Ouro";
                        break;
                    case "B":
                        this.txtFileira.Text = "B";
                        this.cbCategoria.Text = "Ouro";
                        break;
                    case "C":
                        this.txtFileira.Text = "C";
                        this.cbCategoria.Text = "Ouro";
                        break;
                    case "D":
                        this.txtFileira.Text = "D";
                        this.cbCategoria.Text = "Prata";
                        break;
                    case "E":
                        this.txtFileira.Text = "E";
                        this.cbCategoria.Text = "Prata";
                        break;
                    case "F":
                        this.txtFileira.Text = "F";
                        this.cbCategoria.Text = "Bronze";
                        break;
                    case "G":
                        this.txtFileira.Text = "G";
                        this.cbCategoria.Text = "Bronze";
                        break;
                    case "H":
                        this.txtFileira.Text = "H";
                        this.cbCategoria.Text = "Bronze";
                        break;
                }
                if (b.Name.Substring(0, 1) != "A" && b.Name.Substring(0, 1) != "B" && b.Name.Substring(0, 1) != "C" &&
                    b.Name.Substring(0, 1) != "D" && b.Name.Substring(0, 1) != "E" && b.Name.Substring(0, 1) != "F" &&
                    b.Name.Substring(0, 1) != "G" && b.Name.Substring(0, 1) != "H")
                {
                    //BLL.Cliente cli = new BLL.Cliente();
                    //Oracle.DataAccess.Client.OracleDataReader dr3;
                    ////System.Data.OracleClient.OracleDataReader dr3;
                    //cli.ID_CLIENTE = Convert.ToInt32(b.Name.Substring(0, b.Name.IndexOf("e")).Trim());
                    //cli.ID_ASSENTO = Convert.ToInt32(b.Name.Substring(b.Name.IndexOf("e") + 1).Trim());
                    //Id_Assento = Convert.ToInt32(b.Name.Substring(b.Name.IndexOf("e") + 1).Trim());
                    //cli.ID_EVENTO = Id_Evento;
                    //dr3 = cli.ConsultarPorCliente();
                    //if (dr3.Read())
                    //{

                    //    ttCliente.SetToolTip(b, "Assento ocupado por: "+ dr3["NOME"].ToString());

                    //}
                    //BLL.Assento asse = new BLL.Assento();

                    //asse.ID_ASSENTO = Convert.ToInt32(b.Name.Substring(b.Name.IndexOf("e") + 1).Trim());
                    //this.txtValor.Text = string.Empty;
                    //dr3 = asse.ConsultarAssento2();
                    //if (dr3.Read())
                    //{
                    //    if (dr3["ASSENTO_NUMER"].ToString().IndexOf("e") > 0)
                    //    {
                    //        txtNumero.Text = dr3["ASSENTO_NUMER"].ToString().Substring(0, 2) + " e " + dr3["ASSENTO_NUMER"].ToString().Substring(3, 2);
                    //    }
                    //    else
                    //    {
                    //        txtNumero.Text = dr3["ASSENTO_NUMER"].ToString();
                    //    }

                    //    txtFileira.Text = dr3["ASSENTO_FILEIRA"].ToString();
                    //    cbTipo.Text = dr3["TIPO_ASSENTO"].ToString().Substring(0, 1).ToUpper() + dr3["TIPO_ASSENTO"].ToString().Substring(1, dr3["TIPO_ASSENTO"].ToString().Length - 1).ToLower();
                    //    cbCategoria.Text = dr3["SETOR"].ToString().Substring(0, 1).ToUpper() + dr3["SETOR"].ToString().Substring(1, dr3["SETOR"].ToString().Length - 1).ToLower();

                    //}
                    return;
                }
                ///////////////
                if (b.Name.Length == 3 || b.Name.Length == 9 || b.Name.Length == 6)// 10 ATÉ 28 
                {
                    txtNumero.Text = b.Name.Substring(1, 2);
                    if (b.Name.Length == 6)
                    {
                        switch (b.Name.Substring(3, 3))
                        {
                            case "ESP":
                                cbTipo.Text = "Especial";
                                break;
                        }
                    }
                    else if (b.Name.IndexOf("e") > 0)
                    {
                        cbTipo.Text = "Duplo";
                        this.txtNumero.Text = b.Name.Substring(1, 2) + " e " + b.Name.Substring(4, 2);
                    }
                    else
                    {
                        cbTipo.Text = "Simples";
                    }
                }
                else if (b.Name.Length == 2 || b.Name.Length == 7)//0 ATÉ 9
                {
                    txtNumero.Text = b.Name.Substring(1, 1);
                    if (b.Name.Length == 5)
                    {
                        switch (b.Name.Substring(2, 3))
                        {
                            case "ESP":
                                cbTipo.Text = "Especial";
                                break;

                        }
                    }
                    if (b.Name.IndexOf("e") > 0)
                    {
                        cbTipo.Text = "Duplo";
                        this.txtNumero.Text = b.Name.Substring(1, 1) + " e " + b.Name.Substring(3, 1);
                    }
                    else
                    {
                        cbTipo.Text = "Simples";
                    }
                }

                objeto = b.Name;

                BLL.Assento medi = new BLL.Assento();
                Oracle.DataAccess.Client.OracleDataReader dr;
                medi.Assento_Fileira = this.txtFileira.Text;
                medi.Assento_Numer = this.txtNumero.Text.Replace(" ", "");
                dr = medi.ConsultarPercentual();
                if (dr.Read())
                {
                    double valor;
                    if (Convert.ToInt32(dr["PERC"]) == 0)
                    {
                       valor = Convert.ToDouble(txtValorEvento.Text.Replace("R$",""));
                    }
                    else
                    {
                        valor = (Convert.ToInt32(dr["PERC"]) * Convert.ToDouble(txtValorEvento.Text.Replace("R$","")) / 100) + Convert.ToDouble(txtValorEvento.Text.Replace("R$",""));
                        
                    }
                    this.txtPercent.Text = dr["PERC"].ToString() + "%";
                    this.txtValor.Text = valor.ToString();
                }

                ////////////////
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }
        private void Cancelar(object sender, EventArgs e)
        {
            Retorno = false;
            this.Close();
        }
    }
}
