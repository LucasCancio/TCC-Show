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
    public partial class frmAssentoPrincipal : Modelos.ModeloPadrao
    {
        public frmAssentoPrincipal()
        {
            InitializeComponent();
            if (operacao==0)
            {
                this.dtpEvento.MinDate = DateTime.Now;

            }
            this.dgvArtistas.DefaultCellStyle.BackColor = Color.LightGray;
            this.dgvArtistas.AlternatingRowsDefaultCellStyle.BackColor =
  Color.Silver;
            this.dgvAssentos.DefaultCellStyle.BackColor = Color.LightGray;
            this.dgvAssentos.AlternatingRowsDefaultCellStyle.BackColor =
  Color.Silver;
            this.chkClienteFalse.Image = Properties.Resources.CaixaValidar;
            this.tbCliente.TabPages.Remove(pageDocumento);
            this.tbCliente.TabPages.Remove(pageInfCliente);

        }


       









        public string objeto;
        public int AssentosDisponiveis;
        
        private void ProcurarAssento(object sender, EventArgs e)
        {
            frmAssentoProcurar f = new frmAssentoProcurar();

            if (this.dgvAssentos.Rows.Count>0)
            {
                f.dgvAssentos.Columns.Clear();
                f.dgvAssentos.Columns.Add("ASSENTO_NUMER", "Número");
                f.dgvAssentos.Columns.Add("ASSENTO_FILEIRA", "Fileira");
                f.dgvAssentos.Columns.Add("ASSENTO_TIPO", "Tipo");
                f.dgvAssentos.Columns.Add("ASSENTO_SETOR", "Setor");
                f.dgvAssentos.Columns.Add("VALOR", "Valor"); ;
                f.dgvAssentos.Rows.Clear();
                foreach (DataGridViewRow linha in dgvAssentos.Rows)
                {
                    f.dgvAssentos.Rows.Add(adicionar(linha));

                    var pbs = f.gbTelao.Controls.OfType<PictureBox>();
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
                                if (objeto.IndexOf("ESP") > 0)
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
                }
                
                f.txtValorTotal.Text = txtValorTotal.Text;
                f.ValorTotal = Convert.ToDouble(txtValorTotal.Text.Replace("R$",""));
                AssentosDisponiveis = 170 - dgvAssentos.Rows.Count;
                f.lblAssentosDisponiveis.Text = AssentosDisponiveis.ToString();


                

              
            }

            f.Id_Evento = Convert.ToInt32(this.cbEvento.SelectedValue);
     
            f.txtValorEvento.Text = String.Format("{0:c}", Convert.ToDouble(txtValor.Text)); 
            f.idFunc = this.idFunc; f.ShowDialog();
            if (f.Retorno)
            {
                dgvAssentos.Columns.Clear();
                dgvAssentos.Columns.Add("ASSENTO_NUMER", "Número");
                dgvAssentos.Columns.Add("ASSENTO_FILEIRA", "Fileira");
                dgvAssentos.Columns.Add("ASSENTO_TIPO", "Tipo");
                dgvAssentos.Columns.Add("ASSENTO_SETOR", "Setor");
                dgvAssentos.Columns.Add("VALOR", "Valor");

                dgvAssentos.Rows.Clear();
                foreach (DataGridViewRow linha in f.dgvAssentos.Rows)
                {
                    dgvAssentos.Rows.Add(adicionar(linha));
                }
                txtValorTotal.Text = f.txtValorTotal.Text;
            }
            
        }

        private DataGridViewRow adicionar(DataGridViewRow row)
        {
            DataGridViewRow newRow = (DataGridViewRow)row.Clone();
            newRow.Cells[0].Value = row.Cells[0].Value;
            newRow.Cells[1].Value = row.Cells[1].Value;
            newRow.Cells[2].Value = row.Cells[2].Value;
            newRow.Cells[3].Value = row.Cells[3].Value;
            newRow.Cells[4].Value = row.Cells[4].Value;
            if (row.Cells[2].Value.ToString()=="Especial")
            {
                objeto = row.Cells[1].Value.ToString() + row.Cells[0].Value.ToString() + row.Cells[2].Value.ToString().Substring(0, 3).ToUpper();
            }
            else if (row.Cells[2].Value.ToString() == "Duplo")
            {
                objeto = row.Cells[1].Value.ToString() + row.Cells[0].Value.ToString().Replace(" ","")+ row.Cells[2].Value.ToString().Substring(0,3).ToUpper();
              
            }
            
            else
            {
                objeto = row.Cells[1].Value.ToString() + row.Cells[0].Value.ToString();
            }
            

            //newRow.Cells.Remove(newRow.Cells[0]);
            return newRow;
        }

        public int IdEvento, IdAssento, IdCliente;

        private void CarregarCbEvento()
        {
            try
            {
                this.erro.SetError(this.dtpEvento, String.Empty);


                BLL.Evento resi = new BLL.Evento();
                this.cbEvento.DataSource = resi.ListarID_e_TITULO(dtpEvento.Value.ToString().Substring(0, 10)).Tables[0];
                this.cbEvento.DisplayMember = "TITULO";
                this.cbEvento.ValueMember = "ID_EVENTO";
                this.cbEvento.SelectedIndex = 0;

                this.pageArtistas.Enabled = true;
                this.pageInfo.Enabled = true;

                this.btnProcurarAssento.Enabled = true;
                this.pbProcurarAssento.Enabled = true;

                this.btnRemoverAssento.Enabled = true;
                this.pbRemoverAssento.Enabled = true;
                //CarregarArtistas();

            }
            catch (Exception ex)
            {
                this.erro.SetError(this.dtpEvento, "Nenhum Evento cadastrado ou ativo nesse dia!");
                this.dtpEvento.Focus();
                this.pageArtistas.Enabled = false;
                this.pageInfo.Enabled = false;

                this.btnAvancar.Enabled = false;
                this.pbAvancar.Enabled = false;

                this.btnProcurarAssento.Enabled = false;
                this.pbProcurarAssento.Enabled = false;

                this.btnRemoverAssento.Enabled = false;
                this.pbRemoverAssento.Enabled = false;

                this.dgvAssentos.Rows.Clear();
                this.dgvArtistas.DataSource = dgvAssentos.DataSource;
                this.dgvArtistas.Rows.Clear();
                this.txtValor.Text = string.Empty;
                this.txtDescricao.Text = string.Empty;
                this.txtValorTotal.Text = "0";


            }
        }

        private void CarregarCampos(object sender, EventArgs e)
        {

            {
                try
                {

                   


                    if (this.dgvArtistas.DataSource == null)
                    {
                        this.dgvArtistas.Rows.Clear();
                    }

                  
                       
                        CarregarCbEvento();

                    if (operacao!=0 && this.cbEvento.SelectedValue!=null)
                    {
                        BLL.Ingresso func = new BLL.Ingresso();
                        BLL.Assento ass = new BLL.Assento();
                        System.Data.DataTable dt;

                        func.ID_EVENTO = Convert.ToInt32(this.cbEvento.SelectedValue);
                        dt = func.ConsultarPorEvento();


                        foreach (DataRow dr in dt.Rows)
                        {
                            IdAssento = Convert.ToInt32(dr["ID_ASSENTO"]);
                            IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                            string Assento_number = dr["ASSENTO_NUMER"].ToString();
                            string Assento_Fileira = dr["ASSENTO_FILEIRA"].ToString();
                            string Assento_Tipo = dr["TIPO_ASSENTO"].ToString();
                            string Assento_Categoria = dr["SETOR"].ToString();

                            string ob = Assento_Fileira + Assento_number;
                            if (Assento_Tipo.ToUpper() != "SIMPLES")
                            {
                                ob = Assento_Fileira + Assento_number.Replace(" ", "") + Assento_Tipo.Substring(0, 3).ToUpper();
                            }

                        }
                    }
                    
                    



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, ex.Source);
                }
            }

        }
        private void CarregarTableEvento(object sender, EventArgs e)
        {
            try
            {
                this.txtValorTotal.Text = "0";
                this.dgvAssentos.Rows.Clear();
                if (this.cbEvento.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    BLL.Evento medi = new BLL.Evento();
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    medi.ID_EVENTO = Convert.ToInt32(cbEvento.SelectedValue);
                    dr = medi.Consultar();
                    // MessageBox.Show("teste CarregarCampo");
                    if (dr.Read())
                    {

                        this.txtDescricao.Text = dr["DESCRICAO"].ToString();
                        //this.picImagem.ImageLocation = @dr["LOCALIMAGEMTURMA"].ToString();
                        this.txtValor.Text = dr["VALOR_EVENTO"].ToString();
                        this.mtbHorario_INICIO.Text = dr["HORARIO_INICIO"].ToString();
                        this.mtbHorario_FINAL.Text = dr["HORARIO_FINAL"].ToString();
                        this.mtbDuracao.Text= dr["DURACAO"].ToString();


                        dgvArtistas.DataSource = medi.ListarArtistasDoEvento().Tables[0];
                        this.dgvArtistas.AutoResizeColumn(0);

                        this.dgvArtistas.Columns[0].HeaderText = "Cód";
                        this.dgvArtistas.AutoResizeColumn(0);
                        this.dgvArtistas.Columns[1].HeaderText = "Nome";
                        this.dgvArtistas.AutoResizeColumn(1);
                        this.dgvArtistas.Columns[2].HeaderText = "Tipo Artista";
                        this.dgvArtistas.AutoResizeColumn(2);
                        this.dgvArtistas.Columns[3].HeaderText = "Sexo";
                        this.dgvArtistas.AutoResizeColumn(3);
                        this.dgvArtistas.Columns[4].HeaderText = "Facebook";
                        this.dgvArtistas.AutoResizeColumn(4);
                        this.dgvArtistas.Columns[5].HeaderText = "Twiiter";
                        this.dgvArtistas.AutoResizeColumn(5);
                        this.dgvArtistas.Columns[6].HeaderText = "Instagram";
                        this.dgvArtistas.AutoResizeColumn(6);
                        this.dgvArtistas.Columns[7].HeaderText = "Ativo";
                        this.dgvArtistas.AutoResizeColumn(7);
                        this.dgvArtistas.Columns[8].HeaderText = "Data de Criação";
                        this.dgvArtistas.AutoResizeColumn(8);

                        this.btnProcurarAssento.Enabled = true;
                        this.pbProcurarAssento.Enabled = true;

                        this.btnConsultar.Enabled = true;
                        this.pbConsultar.Enabled = true;
                        this.dgvArtistas.Enabled = true;

                    }
                }
                  


             

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }

        private void ExcluirAssento(object sender, EventArgs e)
        {
            if (this.dgvAssentos.CurrentRow != null)
            {
                txtValorTotal.Text =Convert.ToString( Convert.ToDouble(txtValorTotal.Text.Replace("R$","")) - Convert.ToDouble(dgvAssentos.CurrentRow.Cells[4].Value));
                dgvAssentos.Rows.Remove(this.dgvAssentos.CurrentRow);
                txtValorTotal.Text = String.Format("{0:c}", Convert.ToDouble(txtValorTotal.Text.Replace("R$","")));
            }
        }

        //private void Limpar(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.chkAtivo.Checked = true;
        //        this.chkTelFixo.Checked = false;
        //        this.chkArtista_Fixo.Checked = false;
        //        this.chkDataArti.Checked = false;
        //        foreach (Control item in this.Controls)
        //        {
        //            if (item is TextBox || item is MaskedTextBox)
        //            {
        //                item.Text = string.Empty;
        //            }
        //        }
        //        this.txtAgente.Text = string.Empty;
        //        foreach (Control item in pageContato.Controls)
        //        {
        //            if (item is TextBox || item is MaskedTextBox)
        //            {
        //                item.Text = string.Empty;
        //            }
        //        }
        //        foreach (Control item in pageDocumentos.Controls)
        //        {
        //            if (item is TextBox || item is MaskedTextBox)
        //            {
        //                item.Text = string.Empty;
        //            }
        //        }
        //        foreach (Control item in pageResidencia.Controls)
        //        {
        //            if (item is TextBox || item is MaskedTextBox)
        //            {
        //                item.Text = string.Empty;
        //            }
        //        }
        //        foreach (Control item in gbRedeSocial.Controls)
        //        {
        //            if (item is TextBox || item is MaskedTextBox)
        //            {
        //                item.Text = string.Empty;
        //            }
        //        }
        //        this.nupNumeroCasa.Value = 0;
        //        this.erro.Clear();
        //        this.pbImagem.Image = Properties.Resources.User3Icone;
        //        imageLocation = string.Empty;
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}
        private void Avancar(object sender, EventArgs e)
        {
           erro.SetError(this.txtNomeCliente, string.Empty);
            if (this.chkClienteFalse.Name == "chkClienteTrue")
            {
                if (this.txtNomeCliente.Text==string.Empty)
                {
                    erro.SetError(this.txtNomeCliente, "Cliente não selecionado!");
                    txtNomeCliente.Focus();
                    return;
                }
                else
                {
                    erro.SetError(this.txtNomeCliente, string.Empty);
                }
            }
            frmAssentoPagamento f = new frmAssentoPagamento();
            f.txtValorTotal.Text = this.txtValorTotal.Text;
            f.txtValorRestante.Text = this.txtValorTotal.Text;
            f.NAssento = this.dgvAssentos.Rows.Count;
            f.Id_Evento = Convert.ToInt32(cbEvento.SelectedValue);
            f.DataDoEvento = this.dtpEvento.Value.ToString().Substring(0, 10);
            f.HorarioDoEvento = this.mtbHorario_INICIO.Value.ToString().Substring(11,5) + " até " + this.mtbHorario_FINAL.Value.ToString().Substring(11,5);
            f.Funcionario = Funcionario;
            f.Id_Cliente = IdCliente;
            if (IdCliente!=0)
            {
                f.NomeCli = this.txtNomeCliente.Text;
                f.CpfCli = this.txtCPF.Text;
            }
            f.Evento = this.cbEvento.Text;

            int i = dgvAssentos.Rows.Count;

            int contagem = 1;
            while (i != i - i)
            {


                f.Assento_Numero[i] = Convert.ToString(this.dgvAssentos.Rows[this.dgvAssentos.Rows.Count - contagem].Cells[0].Value);
                f.Assento_Fileira[i] = Convert.ToString(this.dgvAssentos.Rows[this.dgvAssentos.Rows.Count - contagem].Cells[1].Value);
                f.Assento_Tipo[i] = Convert.ToString(this.dgvAssentos.Rows[this.dgvAssentos.Rows.Count - contagem].Cells[2].Value);
                f.Assento_Setor[i] = Convert.ToString(this.dgvAssentos.Rows[this.dgvAssentos.Rows.Count - contagem].Cells[3].Value);
                f.Assento_Valor[i] = Convert.ToDouble(this.dgvAssentos.Rows[this.dgvAssentos.Rows.Count - contagem].Cells[4].Value);

                i = i - 1;
                contagem = contagem + 1;
            }

            f.idFunc = this.idFunc; f.ShowDialog();
            if (f.retornar == false)
            {
                dgvAssentos.Rows.Clear();
                txtValorTotal.Text = "0";
            }
          
            this.Refresh();

        }

        private void AdicionarEvento(object sender, EventArgs e)
        {

            Negocios.Eventos.frmEventoCadastro f = new Negocios.Eventos.frmEventoCadastro
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                operacao = 0,
                TopMost = true,
                idFunc = this.idFunc,
                DataDoEvento= Convert.ToDateTime(dtpEvento.Value.ToString().Substring(0, 10))
        };
            f.btnCancelar.Visible = true;
            f.pbCancelar.Visible = true;
            f.Size = new Size(f.Width + 15, f.Height + 15);
           // f.dtpDataEventoDMY.MinDate = DateTime.Now.AddDays(-1);
            f.dtpDataEventoDMY.Value = dtpEvento.Value;
              
            f.idFunc = this.idFunc; f.ShowDialog();
            this.Refresh();
            CarregarCbEvento();
        }

        private void AdicionarCliente(object sender, EventArgs e)
        {
            Negocios.Cliente.frmClienteCadastro f = new Negocios.Cliente.frmClienteCadastro
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                operacao = 0,
                TopMost = true,
               
            };
            f.idFunc = this.idFunc;
            f.btnCancelar.Visible = true;
            f.pbCancelar.Visible = true;
            f.Size = new Size(f.Width + 15, f.Height + 15);
            // f.dtpDataEventoDMY.MinDate = DateTime.Now.AddDays(-1);

            f.idFunc = this.idFunc; f.ShowDialog();
            this.Refresh();
            if (f.cadastrado==true)
            {
                this.tbCliente.TabPages.Remove(pageDocumento);
                this.tbCliente.TabPages.Remove(pageInfCliente);

                this.txtNomeCliente.Text = f.txtNome.Text;
                this.txtCPF.Text = f.txtCPF.Text;
                this.dtpDataNasc.Value = f.dtpDataNasc.Value;
                this.cbSexo.Text = f.cbSexo.Text;
                Oracle.DataAccess.Client.OracleDataReader dr;
                BLL.Cliente cli = new BLL.Cliente();
                dr = cli.ConsultarValorMaximo();
                if (dr.Read())
                {
                    this.IdCliente = Convert.ToInt32(dr["ID"].ToString());
                }


                this.tbCliente.TabPages.Add(pageInfCliente);
                this.tbCliente.TabPages.Add(pageDocumento);
            }
            
            
        
        }

        private void dgvAssentos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dgvAssentos.Rows.Count<1)
            {
                this.btnAvancar.Enabled = false;
                this.pbAvancar.Enabled = false;


            }
            int Assentos = this.dgvAssentos.Rows.Count;
            lblNAssentos.Text = Assentos.ToString() + " Assento(s)";
        }

        private void ClickChanged(object sender, EventArgs e)
        {
            if (this.chkClienteFalse.Name== "chkClienteFalse")/// FOI SELECIONADO
            {
                this.chkClienteFalse.Image = Properties.Resources.ValidarIcone;
                this.chkClienteFalse.Name = "chkClienteTrue";
                this.tbCliente.Enabled = true;
                this.tbCliente.Visible = true;
            }
            else/// FOI DESELECIONADO
            {
                this.chkClienteFalse.Image = TCCSHOW.Properties.Resources.CaixaValidar;
                this.chkClienteFalse.Name = "chkClienteFalse";
                this.tbCliente.Enabled = false;
                this.tbCliente.Visible = false;
            }
        }

        private void ProcurarCliente(object sender, EventArgs e)
        {
            Negocios.Filtros.frmProcurarCliente f = new Negocios.Filtros.frmProcurarCliente();
            f.TopMost = true;
            f.idFunc = this.idFunc; f.ShowDialog();
            if (f.FormNome != null) {
                this.tbCliente.TabPages.Remove(pageDocumento);
                this.tbCliente.TabPages.Remove(pageInfCliente);

                txtNomeCliente.Text = f.FormNome;
                IdCliente = f.FormId;
                dtpDataNasc.Value = f.FormDataNasc;
                txtCPF.Text = f.FormCPF;
                cbSexo.Text = f.FormSexo;

                this.tbCliente.TabPages.Add(pageInfCliente);
                this.tbCliente.TabPages.Add(pageDocumento);
            }
            

            if (this.txtNomeCliente.Text!=string.Empty)
            {
                btnRemover.Enabled = true;
                btnRemover.Enabled = true;
            }
        }

        private void Limpar(object sender, EventArgs e)
        {
            try
            {
                this.dgvAssentos.Rows.Clear();
                this.dgvArtistas.DataSource = dgvAssentos.DataSource; 
                this.dgvArtistas.Rows.Clear();
                this.txtValor.Text = string.Empty;
                this.txtDescricao.Text = string.Empty;
                this.txtNomeCliente.Text = string.Empty;
                this.txtCPF.Text = string.Empty;
                this.cbSexo.Text = string.Empty;
                this.tbCliente.TabPages.Remove(pageDocumento);
                this.tbCliente.TabPages.Remove(pageInfCliente);
                this.dtpEvento.Value = DateTime.Now;
                IdCliente = 0;
                this.chkClienteFalse.Image = TCCSHOW.Properties.Resources.CaixaValidar;
                this.chkClienteFalse.Name = "chkClienteFalse";
                this.tbCliente.Enabled = false;
                this.tbCliente.Visible = false;
                this.txtValorTotal.Text = "R$ 0,00";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void RemoverCliente(object sender, EventArgs e)
        {
            btnRemover.Enabled = false;
            pbRemover.Enabled = false;

            this.txtNomeCliente.Text = string.Empty;
            this.txtCPF.Text = string.Empty;
            this.cbSexo.Text = string.Empty;
            IdCliente = 0;

            this.tbCliente.TabPages.Remove(pageDocumento);
            this.tbCliente.TabPages.Remove(pageInfCliente);

        }

        private void dgvAssentos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (this.dgvAssentos.Rows.Count >= 1)
            {
                this.btnAvancar.Enabled = true;
                this.pbAvancar.Enabled = true;
                int Assentos = this.dgvAssentos.Rows.Count;
                lblNAssentos.Text = Assentos.ToString() + " Assento(s)";
            }
        }

        private void ConsultarArtista(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvArtistas.RowCount == 0) { return; }
                Negocios.Artistas.frmArtistaCadastro f = new Negocios.Artistas.frmArtistaCadastro
                {
                    operacao = Convert.ToByte(BLL.Operacao.Inclusao),
                    idFunc = this.idFunc,
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size
                };


                f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;

                f.lblTitulo.Text = "Consulta de";
                f.gbCodigo.Visible = true;
                    f.codigo = Convert.ToInt32(this.dgvArtistas.CurrentRow.Cells[0].Value);
                    f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);
                    f.Tipo_Art = this.dgvArtistas.CurrentRow.Cells[2].Value.ToString();
                    f.txtNomeArti.Enabled = true;

                    // f.txtEndereco.Enabled = true;

                    // f.txtComplemento.Enabled = true;
                    f.txtCodigo.Enabled = true;

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



                      f.txtNomeArti.Enabled = false;

                        // f.txtEndereco.Enabled = false;

                        // f.txtComplemento.Enabled = false;
                        f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;
                        f.chkArtista_Fixo.Enabled = false;
                        // f.txtCidade.Enabled = false;
                        // f.cbEstado.Enabled = false;
                        f.cbSexo.Enabled = false;
                        // f.nupIdade.Enabled = false;
                        f.chkAtivo.Enabled = false;
                        f.chkTelFixo.Visible = false;
                        f.chkArtista_Fixo.Visible = false;
                        f.chkDataArti.Visible = false;

                        // f.txtBairro.Enabled = false;
                        // f.nupNumeroCasa.Enabled = false;
                        f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible = false; f.btnLimpar.Visible = false;
                        //f.btnCancelar.Location = new Point(365, 378);
                        //f.pbCancelar.Location = new Point(377, 385);
                        //f.btnCancelar.Text = "Voltar";
                        //f.btnCancelar.Font = new Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold);
                        // f.btnAdicionarContato.Visible = false;
                        f.btnProcurarAgente.Visible = false;
                        f.pbProcurarAgente.Visible = false;
                        f.txtFacebook.Enabled = false;
                        f.txtTwitter.Enabled = false;
                        f.txtInstagram.Enabled = false;

                        f.btnValidarCPF.Enabled = false;
                        f.btnValidarEmail.Enabled = false;
                        f.btnProcurarImg.Visible = false;
                        f.pbProcurarImg.Visible = false;
                        f.btnRemoverImg.Visible = false;
                        f.pbRemoverImg.Visible = false;
                        f.dtpDataNasc.Enabled = false;

                        foreach (Control item in f.pageContato.Controls)
                        {
                            if (item is TextBox || item is MaskedTextBox || item is CheckBox)
                            {
                                item.Enabled = false;
                            }

                        }
                        foreach (Control item in f.pageDocumentos.Controls)
                        {
                            if (item is MaskedTextBox || item is PictureBox)
                            {
                                item.Enabled = false;
                            }
                        }
                        foreach (Control item in f.pageResidencia.Controls)
                        {
                            if (item is TextBox || item is MaskedTextBox || item is PictureBox || item is NumericUpDown || item is ComboBox)
                            {
                                item.Enabled = false;
                            }
                        }
                        f.chkTelFixo.Enabled = false;
                        f.chkDataArti.Enabled = false;

                        f.operacao = Convert.ToByte(BLL.Operacao.Consulta);
                    
                
                //var b = (Button)sender;
                //f.lblTitulo.Text =  b.Text;
                f.btnCancelar.Visible = true;
                f.pbCancelar.Visible = true;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.idFunc = this.idFunc; f.ShowDialog();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }
       
    }
}
