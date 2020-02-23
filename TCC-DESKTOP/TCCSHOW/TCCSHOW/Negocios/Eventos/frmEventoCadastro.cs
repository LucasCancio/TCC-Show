using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Eventos
{
    public partial class frmEventoCadastro : Modelos.ModeloCadastroPadrao
    {
        public frmEventoCadastro()
        {
            InitializeComponent();

            //if (this.FormBorderStyle == FormBorderStyle.None)
            //{
            //    this.btnSalvar.Location = new Point(612, 712);
            //    this.pbSalvar.Location = new Point(620, 728);
            //}
            tipo = "Nome";
            WPTotal = this.txtPesquisar.Width;
            WPData = txtPesquisar.Width - this.dtpHorarioInicio.Width - 20;


         
           
        }

        public DateTime DataDoEvento;

        public string HorarioMinimo, HorarioMaximo;
        public string DuracaoMaxima="06:00",DuracaoMinima="00:30";
       
        
        double WPTotal, WPData;
        string tTemp;
        public string tipo3 = "Ambos", tCod;
        public string tipo, tipo2;
        public int ativo = 2;
        string HorarioFinal;

        private void dgv_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Index == 3 || e.Column.Index == 4)

            {
                e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;


            }
        }
        private void CarregarCampos(object sender, EventArgs e)
        {
            try
            {
                HorarioMinimo = "18:00";
                HorarioMaximo = "00:00";
                if (operacao == 0 && DataDoEvento.ToString() == "01/01/0001 00:00:00")
                {
                    this.rbBilheteria.Checked = true;
                    this.gbCodigo.Visible = false;
                    this.dtpDataEventoDMY.MinDate = Convert.ToDateTime(DateTime.Now.ToString().Substring(0, 10));
                    this.dtpDataEventoDMY.Value = DateTime.Now;

                }
                else if (operacao == 0)
                {
                    this.rbBilheteria.Checked = true;
                    this.gbCodigo.Visible = false;
                    this.dtpDataEventoDMY.MinDate = Convert.ToDateTime(DateTime.Now.ToString().Substring(0, 10));
                    this.dtpDataEventoDMY.Value = Convert.ToDateTime(DataDoEvento);

                }
                this.mtbDuracao.MaxDate = Convert.ToDateTime(DateTime.Now.ToString().Substring(0, 10) +" "+ DuracaoMaxima);
                this.mtbDuracao.MinDate = Convert.ToDateTime(DateTime.Now.ToString().Substring(0, 10) +" "+DuracaoMinima);

                CarregarGridArtistas();
                this.dgvArtistas.AutoResizeColumn(0);
                this.dgvArtistas.AutoResizeColumn(1);
                this.dgvArtistas.AutoResizeColumn(2);
                this.dgvArtistas.AutoResizeColumn(3);
                this.dgvArtistas.AutoResizeColumn(4);
                this.dgvArtistas.AutoResizeColumn(5);
                this.dgvArtistas.AutoResizeColumn(6);
                this.dgvArtistas.AutoResizeColumn(7);
                this.dgvArtistas.AutoResizeColumn(8);



                this.txtCodigo.Enabled = false;
                if (operacao != Convert.ToByte(BLL.Operacao.Inclusao))
                {
                    BLL.Evento medi = new BLL.Evento();
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    medi.ID_EVENTO = codigo;
                    dr = medi.Consultar();
                    // MessageBox.Show("teste CarregarCampo");
                    if (dr.Read())
                    {

                        this.txtCodigo.Text = Convert.ToString(codigo);
                        this.txtCodigo.Enabled = false;
                        if (DataDoEvento == Convert.ToDateTime("01 / 01 / 0001 00:00:00"))
                        {
                            string data = (dr["DATA_EVENTO"].ToString());
                            this.dtpDataEventoDMY.Value = Convert.ToDateTime(data);
                        }
                        else
                        {
                            this.dtpDataEventoDMY.Value = DataDoEvento;
                        }

                        if (dr["ATIVO"].ToString() == "1"&& this.dtpDataEventoDMY.Value >= Convert.ToDateTime(DateTime.Now.ToString().Substring(0, 10)))
                        {
                            this.chkAtivo.Checked = true;
                        }
                        else
                        {
                            this.chkAtivo.Checked = false;
                        }
                        if (dr["TIPO_PAG"].ToString() == "Bilheteria")
                        {
                            this.rbBilheteria.Checked = true;
                        }                        
                        else
                        {
                        this.rbCache.Checked = true;
                        }
                        if (operacao==5)
                        {
                            lblTipoPag.Text = dr["TIPO_PAG"].ToString();
                        }
                        this.txtDescricao.Text = dr["DESCRICAO"].ToString();
                        //this.picImagem.ImageLocation = @dr["LOCALIMAGEMTURMA"].ToString();
                        this.txtTitulo.Text = dr["TITULO"].ToString();
                        this.txtValor.Text = dr["VALOR_EVENTO"].ToString();
                        this.mtbHorario_INICIO.Text = dr["HORARIO_INICIO"].ToString();
                        this.mtbDuracao.Text = dr["DURACAO"].ToString();
                        this.mtbHorario_FINAL.Text = dr["HORARIO_FINAL"].ToString();
                        HorarioFinal= dr["HORARIO_FINAL"].ToString();

                        dgvArtInv.DataSource = medi.ListarArtistasDoEvento().Tables[0];

                        CarregarArtSelec();

                       



                    }





                }//




                BLL.Evento evento = new BLL.Evento();
  

                if (operacao == 0)
                {
                    if (DataDoEvento!=null && DataDoEvento.ToString()!= "01/01/0001 00:00:00")
                    {
                        this.dgvHorario.DataSource = evento.ListarDIA(dtpDataEventoDMY.Value.ToString().Substring(0, 10), '0').Tables[0];
                    }
                    else
                    {
                        this.dgvHorario.DataSource = evento.ListarDIA(DateTime.Today.ToString(), '0').Tables[0];
                    }
                   
                }
                else
                {
                    evento.ID_EVENTO = Convert.ToInt32(this.txtCodigo.Text);
                    this.dgvHorario.DataSource = evento.ListarDIA(dtpDataEventoDMY.Value.ToString().Substring(0,10),'1').Tables[0];
                }
               
                this.dgvHorario.Columns[0].HeaderText = "Cód";
                this.dgvHorario.AutoResizeColumn(0);
                this.dgvHorario.Columns[1].HeaderText = "Título";
                this.dgvHorario.AutoResizeColumn(1);
                this.dgvHorario.Columns[2].HeaderText = "Data Do Evento";
                this.dgvHorario.AutoResizeColumn(2);
                this.dgvHorario.Columns[3].HeaderText = "Descrição";
                this.dgvHorario.AutoResizeColumn(3);
                this.dgvHorario.Columns[4].HeaderText = "Horário Inicial";
                this.dgvHorario.AutoResizeColumn(4);
                this.dgvHorario.Columns[5].HeaderText = "Horário Final";
                this.dgvHorario.AutoResizeColumn(5);
                this.dgvHorario.Columns[6].HeaderText = "Duração";
                this.dgvHorario.AutoResizeColumn(6);
                this.dgvHorario.Columns[7].HeaderText = "Quantidade de Artistas";
                this.dgvHorario.AutoResizeColumn(7);
                this.dgvHorario.Columns[8].HeaderText = "Tipo de Pagamento";
                this.dgvHorario.AutoResizeColumn(8);
                this.dgvHorario.Columns[9].HeaderText = "Ativo";
                this.dgvHorario.AutoResizeColumn(9);
                this.dgvHorario.Columns[10].HeaderText = "Valor do Evento";
                this.dgvHorario.AutoResizeColumn(10);

                if (operacao==0)
                {
                    ProcurarHorario();

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }

        private void Limpar(object sender, EventArgs e)
        {
            try
            {
                this.chkAtivo.Checked = true;
                foreach (Control item in pageArtistas.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = string.Empty;
                    }
                }
                foreach (Control item in pageDetalhes.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = string.Empty;
                    }
                }

                this.dtpDataEventoDMY.Value = DateTime.Now;
                this.dgvArtistasSelect.Rows.Clear();
                this.erro.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void ConsultarEvento(object sender, EventArgs e)
        {//INCLUIR ALTERAR CONSULTAR
            try
            {
                frmEventoCadastro f = new frmEventoCadastro
                {
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size,
                    idFunc = this.idFunc
                };
                
                f.NivelAcesso = NivelAcesso;
               

               
                    f.dtpDataEventoDMY.MinDate = new System.DateTime(2017, 1, 1, 1, 1, 1);
                    f.codigo = Convert.ToInt32(this.dgvHorario.CurrentRow.Cells[0].Value);
                    f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);
                f.chkAtivo.Enabled = false;
                f.txtDescricao.Enabled = false;
                f.mtbHorario_INICIO.Enabled = false;

                f.txtValor.Enabled = false;
                f.btnCadastrarArt.Visible = false;
                f.pbCadastrarArt.Visible = false;
                f.chkAtivo.Enabled = false;
                f.pbPesquisar.Enabled = false;
                f.txtPesquisar.Enabled = false;
                f.rbBilheteria.Visible = false;
                f.rbCache.Visible = false;
                f.lblTipoPag.Visible = true;
                f.pnFiltro.Enabled = false;
                f.mtbDuracao.Enabled = false;
                f.pbConsultarEvent.Visible = false;
                f.btnConsultarEvent.Visible = false;

                f.btnSalvar.Enabled = false; f.pbSalvar.Enabled = false;
                f.txtTitulo.Enabled = false;
                f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible = false; f.btnLimpar.Visible = false;
                f.dtpDataEventoDMY.Enabled = false;

                f.btnAdicionar.Enabled = false;
                f.btnExcluir.Enabled = false;

                f.operacao = Convert.ToByte(BLL.Operacao.Consulta);


                f.TopMost = true;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.idFunc = this.idFunc; f.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }
        private void CarregarArtSelec()
        {
            try
            {

                this.dgvArtistasSelect.Columns.Add("ID_ARTISTA_GERAL", "Código do Artista");
                this.dgvArtistasSelect.Columns.Add("NOME", "Nome");
                this.dgvArtistasSelect.Columns.Add("TIPO_PESSOA", "Tipo Artista");
                this.dgvArtistasSelect.Columns.Add("SEXO", "Sexo");
                this.dgvArtistasSelect.Columns.Add("FACEBOOK", "Facebook");
                this.dgvArtistasSelect.Columns.Add("TWITTER", "Twitter");
                this.dgvArtistasSelect.Columns.Add("INSTAGRAM", "Instagram");
                this.dgvArtistasSelect.Columns.Add("ATIVO", "Ativo");
                this.dgvArtistasSelect.Columns.Add("DATA_CRIACAO", "Data de Criação");

                foreach (DataGridViewRow linha in dgvArtInv.Rows)
                {
                   
                    dgvArtistasSelect.Rows.Add(adicionar(linha));
                    if (linha.Cells[2].Value.ToString() == "ARTISTA-FIXO")
                    {
                        this.rbBilheteria.Enabled = false;
                        this.rbBilheteria.Checked = false;
                        this.rbCache.Checked = true;
                    }


                }

                this.dgvArtistasSelect.AutoResizeColumn(0);
                this.dgvArtistasSelect.AutoResizeColumn(1);
                this.dgvArtistasSelect.AutoResizeColumn(2);
                this.dgvArtistasSelect.AutoResizeColumn(3);
                this.dgvArtistasSelect.AutoResizeColumn(4);
                this.dgvArtistasSelect.AutoResizeColumn(5);
                this.dgvArtistasSelect.AutoResizeColumn(6);
                this.dgvArtistasSelect.AutoResizeColumn(7);
                this.dgvArtistasSelect.AutoResizeColumn(8);
         
   




            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }



        private DataGridViewRow adicionar(DataGridViewRow row) {
            DataGridViewRow newRow = (DataGridViewRow)row.Clone();
            newRow.Cells[0].Value = row.Cells[0].Value;
            newRow.Cells[1].Value = row.Cells[1].Value;
            newRow.Cells[2].Value = row.Cells[2].Value;
            newRow.Cells[3].Value = row.Cells[3].Value;
            newRow.Cells[4].Value = row.Cells[4].Value;
            newRow.Cells[5].Value = row.Cells[5].Value;
            newRow.Cells[6].Value = row.Cells[6].Value;
            newRow.Cells[7].Value = row.Cells[7].Value;
            newRow.Cells[8].Value = row.Cells[8].Value;
        
       
            //newRow.Cells.Remove(newRow.Cells[0]);
            return newRow;
        }

        private void mtbHorario_INICIO_TextChanged(object sender, EventArgs e)
        {
            this.erro.SetError(this.mtbHorario_INICIO, string.Empty);
            this.erro.SetError(this.mtbHorario_FINAL, string.Empty);
            if (operacao != 5)
            {
                try
                {


                    this.mtbHorario_FINAL.Value = this.mtbHorario_INICIO.Value.AddHours(Convert.ToDouble(this.mtbDuracao.Value.ToString().Substring(11, 2).Replace(":", ","))).AddMinutes(Convert.ToDouble(this.mtbDuracao.Value.ToString().Substring(14, 2).Replace(":", ",")));

                    if (this.mtbHorario_INICIO.Value < Convert.ToDateTime(this.mtbHorario_INICIO.Value.ToString().Substring(0, 10) + " " + HorarioMinimo))
                    {
                        if (Convert.ToDouble(this.mtbHorario_INICIO.Value.ToString().Substring(10, 6).Replace(":", ",").Trim()) >= 0 &&
                            Convert.ToDouble(this.mtbHorario_INICIO.Value.ToString().Substring(10, 6).Replace(":", ",").Trim()) < Convert.ToDouble(HorarioMaximo.Replace(":", ",")))
                        {
                            //if (this.mtbHorario_INICIO.Value < Convert.ToDateTime(this.mtbHorario_INICIO.Value.ToString().Substring(0, 10) + " " + HorarioMinimo))
                            //{
                            //    this.erro.SetError(this.mtbHorario_INICIO, "O horario minimo é " + HorarioMinimo);
                            //    this.Focus();
                            //    return;
                            //}
                            if (this.mtbHorario_INICIO.Value.AddDays(1) < Convert.ToDateTime(this.mtbHorario_INICIO.Value.ToString().Substring(0, 10) + " " + HorarioMinimo))
                            {
                                this.erro.SetError(this.mtbHorario_INICIO, "O horario minimo é " + HorarioMinimo);
                                this.Focus();
                                return;
                            }

                        }
                        else
                        {
                            this.erro.SetError(this.mtbHorario_INICIO, "O horario minimo é " + HorarioMinimo);
                            this.Focus();
                            return;
                        }

                    }
                    else
                    {
                        this.erro.SetError(this.mtbHorario_INICIO, String.Empty);
                    }

                    this.erro.SetError(this.mtbHorario_FINAL, string.Empty);

                    if (Convert.ToDouble(this.mtbHorario_FINAL.Value.ToString().Substring(10, 6).Trim().Replace(":", ",")) >= 0 &&
                        Convert.ToDouble(this.mtbHorario_FINAL.Value.ToString().Substring(10, 6).Trim().Replace(":", ",")) <= Convert.ToDouble(HorarioMinimo.Replace(":", ",")))
                    {
                        if (this.mtbHorario_FINAL.Value > Convert.ToDateTime(this.mtbHorario_FINAL.Value.ToString().Substring(0, 10) + " " + HorarioMaximo))
                        {
                            this.erro.SetError(this.mtbHorario_FINAL, "O horario maximo é " + HorarioMaximo);
                            this.Focus();

                            return;
                        }
                        //if (this.mtbHorario_FINAL.Value.AddDays(1) > Convert.ToDateTime(this.mtbHorario_FINAL.Value.ToString().Substring(0, 10) + " " + HorarioMaximo))
                        //{
                        //    this.erro.SetError(this.mtbHorario_FINAL, "O horario maximo é " + HorarioMaximo);
                        //    this.Focus();

                        //    return;
                        //}
                    }
                    else
                    {
                        if (Convert.ToDouble(this.mtbHorario_FINAL.Value.ToString().Substring(10, 6).Trim().Replace(":", ",")) > Convert.ToDouble(HorarioMaximo.Replace(":", ",")))
                        {
                            if (Convert.ToDouble(HorarioMaximo.Replace(":", ",")) >= 0 &&
                            Convert.ToDouble(HorarioMaximo.Replace(":", ",")) <= Convert.ToDouble(HorarioMinimo.Replace(":", ",")))
                            {
                                if (this.mtbHorario_FINAL.Value > Convert.ToDateTime(this.mtbHorario_FINAL.Value.AddDays(1).ToString().Substring(0, 10) + " " + HorarioMaximo))
                                {
                                    this.erro.SetError(this.mtbHorario_FINAL, "O horario maximo é " + HorarioMaximo);
                                    this.Focus();

                                    return;
                                }
                            }
                            else
                            {
                                this.erro.SetError(this.mtbHorario_FINAL, "O horario maximo é " + HorarioMaximo);
                                this.Focus();
                                return;
                            }


                        }
                    }








                    if (this.dgvHorario.Rows.Count >= 1)
                    {
                        if (VerificarHorario() == false)
                        {

                            this.erro.SetError(this.mtbHorario_INICIO, "O horario escolhido é pertencente á um evento!");
                            this.Focus();
                            return;
                        }


                    }



                    if (ValidarHorario() == false)
                    {
                        this.erro.SetError(this.mtbHorario_INICIO, "O horario escolhido não está mais disponivel!");
                        this.Focus();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }


        }

        private bool ValidarHorario() {
            bool retornar=true;
            DateTime HoraAtual = Convert.ToDateTime(DateTime.Now.ToString().Substring(11, 5));
            if (operacao == 0)
            {
               
                if (Convert.ToDateTime(dtpDataEventoDMY.Value.ToString().Substring(0, 10) + " " + mtbHorario_FINAL.Value.ToString().Substring(11, 5)) < HoraAtual)
                {
                    if (mtbHorario_FINAL.Value.ToString().Substring(11, 5).Trim() != HorarioMaximo)
                    {
                        retornar = false;
                    }

                }
            }
            else if(operacao!=0 && operacao!=5)
            {
                if (mtbHorario_FINAL.Value.ToString().Substring(11, 5)!=HorarioFinal)
                {
                    if (Convert.ToDateTime(dtpDataEventoDMY.Value.ToString().Substring(0,10)+" "+mtbHorario_FINAL.Value.ToString().Substring(11, 5)) < HoraAtual)
                    {

                        if (mtbHorario_FINAL.Value.ToString().Substring(11, 5).Trim() != HorarioMaximo)
                        {
                            retornar = false;
                        }
                    }
                }
            }


            return retornar;
        }
        private bool VerificarHorario()
        {
            bool retornar = true;
            if (operacao != 0)
            {
                retornar = true;
            }
            string horarioInicio = string.Empty;
            string horarioFinal = string.Empty;
            if (operacao != 0)
            {
                foreach (DataGridViewRow item in dgvHorario.Rows)
                {
                    if (Convert.ToString(item.Cells[0].Value) != this.txtCodigo.Text && Convert.ToString(item.Cells[0].Value) !=string.Empty)
                    {
                        horarioInicio = item.Cells[4].Value.ToString();
                        horarioFinal = item.Cells[5].Value.ToString();
                        string horario = this.mtbHorario_INICIO.Value.ToString().Substring(11, 5);
                        if (Convert.ToDateTime(horario) < Convert.ToDateTime(horarioFinal) && Convert.ToDateTime(horario) > Convert.ToDateTime(horarioInicio) || Convert.ToDateTime(horario) == Convert.ToDateTime(horarioInicio) && retornar==true)
                        {

                            retornar = false;
                        }
                        
                    }

                }
            }
            else
            {
                if (this.dgvHorario.Rows.Count > 0)
                {

                    foreach (DataGridViewRow item in dgvHorario.Rows)
                    {
                        if (Convert.ToString(item.Cells[0].Value) != this.txtCodigo.Text && Convert.ToString(item.Cells[0].Value) != string.Empty)
                        {
                            horarioInicio = item.Cells[4].Value.ToString();
                            horarioFinal = item.Cells[5].Value.ToString();
                            string horario = this.mtbHorario_INICIO.Value.ToString().Substring(11, 5);
                            if (Convert.ToDateTime(horario) < Convert.ToDateTime(horarioFinal) && Convert.ToDateTime(horario) > Convert.ToDateTime(horarioInicio) || Convert.ToDateTime(horario) == Convert.ToDateTime(horarioInicio) && retornar == true)
                            {

                                retornar = false;
                            }

                        }

                    }



                    //    for (int i = 1; i < this.dgvHorario.Rows.Count + 1; i++)
                    //    {
                    //        horarioInicio = this.dgvHorario.Rows[this.dgvHorario.Rows.Count - i].Cells[4].Value.ToString().Trim();
                    //        horarioFinal = this.dgvHorario.Rows[this.dgvHorario.Rows.Count - i].Cells[5].Value.ToString().Trim();
                    //        string horario = this.mtbHorario_INICIO.Value.ToString().Substring(11, 5);
                    //        if (Convert.ToDateTime(horario) < Convert.ToDateTime(horarioFinal) && Convert.ToDateTime(horario) > Convert.ToDateTime(horarioInicio) || Convert.ToDateTime(horario) == Convert.ToDateTime(horarioInicio) && retornar==true)
                    //        {

                    //            retornar = false;
                    //        }

                    //    }

                }
               
            }



            return retornar;
        }
        private void Salvar()
        {

            try
            {
                //MessageBox.Show("Horario final: "+this.mtbHorario_FINAL.Text.Trim().Replace(".", "").Replace(":", "")+ "   Horário Inicial:"+ this.mtbHorario_INICIO.Text.Trim().Replace(".", "").Replace(":", ""));
                BLL.Evento func = new BLL.Evento();
                BLL.Log log = new BLL.Log();

                this.erro.SetError(this.mtbHorario_INICIO, string.Empty);
                if (this.dgvHorario.Rows.Count >= 1)
                {
                    if (VerificarHorario() == false)
                    {

                        this.erro.SetError(this.mtbHorario_INICIO, "O horario escolhido é pertencente á um evento!");
                        this.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.mtbHorario_INICIO, string.Empty);
                    }


                }

                this.erro.SetError(this.mtbHorario_INICIO, string.Empty);
                this.erro.SetError(this.mtbHorario_FINAL, string.Empty);
                if (operacao != 5)
                {
                    try
                    {


                        this.mtbHorario_FINAL.Value = this.mtbHorario_INICIO.Value.AddHours(Convert.ToDouble(this.mtbDuracao.Value.ToString().Substring(11, 2).Replace(":", ","))).AddMinutes(Convert.ToDouble(this.mtbDuracao.Value.ToString().Substring(14, 2).Replace(":", ",")));

                        if (this.mtbHorario_INICIO.Value < Convert.ToDateTime(this.mtbHorario_INICIO.Value.ToString().Substring(0, 10) + " " + HorarioMinimo))
                        {
                            if (Convert.ToDouble(this.mtbHorario_INICIO.Value.ToString().Substring(10, 6).Replace(":", ",").Trim()) >= 0 &&
                                Convert.ToDouble(this.mtbHorario_INICIO.Value.ToString().Substring(10, 6).Replace(":", ",").Trim()) < Convert.ToDouble(HorarioMaximo.Replace(":", ",")))
                            {
                                //if (this.mtbHorario_INICIO.Value < Convert.ToDateTime(this.mtbHorario_INICIO.Value.ToString().Substring(0, 10) + " " + HorarioMinimo))
                                //{
                                //    this.erro.SetError(this.mtbHorario_INICIO, "O horario minimo é " + HorarioMinimo);
                                //    this.Focus();
                                //    return;
                                //}
                                if (this.mtbHorario_INICIO.Value.AddDays(1) < Convert.ToDateTime(this.mtbHorario_INICIO.Value.ToString().Substring(0, 10) + " " + HorarioMinimo))
                                {
                                    this.erro.SetError(this.mtbHorario_INICIO, "O horario minimo é " + HorarioMinimo);
                                    this.Focus();
                                    return;
                                }

                            }
                            else
                            {
                                this.erro.SetError(this.mtbHorario_INICIO, "O horario minimo é " + HorarioMinimo);
                                this.Focus();
                                return;
                            }

                        }
                        else
                        {
                            this.erro.SetError(this.mtbHorario_INICIO, String.Empty);
                        }

                        this.erro.SetError(this.mtbHorario_FINAL, string.Empty);

                        if (Convert.ToDouble(this.mtbHorario_FINAL.Value.ToString().Substring(10, 6).Trim().Replace(":", ",")) >= 0 &&
                            Convert.ToDouble(this.mtbHorario_FINAL.Value.ToString().Substring(10, 6).Trim().Replace(":", ",")) <= Convert.ToDouble(HorarioMinimo.Replace(":", ",")))
                        {
                            if (this.mtbHorario_FINAL.Value > Convert.ToDateTime(this.mtbHorario_FINAL.Value.ToString().Substring(0, 10) + " " + HorarioMaximo))
                            {
                                this.erro.SetError(this.mtbHorario_FINAL, "O horario maximo é " + HorarioMaximo);
                                this.Focus();

                                return;
                            }
                            //if (this.mtbHorario_FINAL.Value.AddDays(1) > Convert.ToDateTime(this.mtbHorario_FINAL.Value.ToString().Substring(0, 10) + " " + HorarioMaximo))
                            //{
                            //    this.erro.SetError(this.mtbHorario_FINAL, "O horario maximo é " + HorarioMaximo);
                            //    this.Focus();

                            //    return;
                            //}
                        }
                        else
                        {
                            if (Convert.ToDouble(this.mtbHorario_FINAL.Value.ToString().Substring(10, 6).Trim().Replace(":", ",")) > Convert.ToDouble(HorarioMaximo.Replace(":", ",")))
                            {
                                if (Convert.ToDouble(HorarioMaximo.Replace(":", ",")) >= 0 &&
                                Convert.ToDouble(HorarioMaximo.Replace(":", ",")) <= Convert.ToDouble(HorarioMinimo.Replace(":", ",")))
                                {
                                    if (this.mtbHorario_FINAL.Value > Convert.ToDateTime(this.mtbHorario_FINAL.Value.AddDays(1).ToString().Substring(0, 10) + " " + HorarioMaximo))
                                    {
                                        this.erro.SetError(this.mtbHorario_FINAL, "O horario maximo é " + HorarioMaximo);
                                        this.Focus();

                                        return;
                                    }
                                }
                                else
                                {
                                    this.erro.SetError(this.mtbHorario_FINAL, "O horario maximo é " + HorarioMaximo);
                                    this.Focus();
                                    return;
                                }


                            }
                        }








                        if (this.dgvHorario.Rows.Count >= 1)
                        {
                            if (VerificarHorario() == false)
                            {

                                this.erro.SetError(this.mtbHorario_INICIO, "O horario escolhido é pertencente á um evento!");
                                this.Focus();
                                return;
                            }


                        }



                        if (ValidarHorario() == false)
                        {
                            this.erro.SetError(this.mtbHorario_INICIO, "O horario escolhido não está mais disponivel!");
                            this.Focus();
                            return;
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        //throw;
                    }
                }///VALIDAR HORARIO



                if (this.txtTitulo.Text == String.Empty)
                {
                    this.erro.SetError(this.lblTituloEvento, "O Titulo é obrigatório!");
                    this.txtTitulo.Focus();
                    return;
                }
                else
                {
                    this.erro.SetError(this.lblTituloEvento, String.Empty);
                }
                if (this.txtValor.Text == String.Empty)
                {
                    this.erro.SetError(this.lblValor, "O Valor é obrigatório!");
                    this.txtValor.Focus();
                    return;
                }
                else
                {
                    this.erro.SetError(this.lblValor, String.Empty);
                }
                if (this.dgvArtistasSelect.RowCount == 0)
                {
                    
                        this.erro.SetError(this.lblNomesArtistas, "O evento precisa ter pelo menos um Artista!");
                    
                   
                    this.dgvArtistasSelect.Focus();
                    return;
                }
                else
                {
                    this.erro.SetError(this.lblNomesArtistas, string.Empty);

                }




                if (MessageBox.Show("Deseja Salvar ?", "ATENÇÃO ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;

                btnSalvar.Cursor = Cursors.AppStarting;
                //MessageBox.Show("Data: " + this.dtpDataEventoDMY.Value.ToString().Substring(0, 10) + "   " );

                func.Descricao = this.txtDescricao.Text.ToUpper(); 

                func.DataEvento = Convert.ToDateTime(this.dtpDataEventoDMY.Value.ToString().Substring(0, 10));
                func.HorarioINICIO = Convert.ToDateTime(this.mtbHorario_INICIO.Text);
                func.HorarioFINAL = Convert.ToDateTime(this.mtbHorario_FINAL.Text);
                func.Titulo = txtTitulo.Text;
                func.Duracao= this.mtbDuracao.Text;
                log.ID_FUNC = idFunc;
                log.ID_MODIFICADO = codigo;
                log.TABELA_LOG = "EVENTOS";

                if (dtpDataEventoDMY.Value < DateTime.Today)
                {
                    this.chkAtivo.Checked = false;
                }

                func.Ativo = 0;
                if (this.chkAtivo.Checked)
                {
                    func.Ativo = 1;
                }
                if (this.rbBilheteria.Checked)
                {
                    func.Tipo_Pag = "Bilheteria";
                }
                else
                {
                    func.Tipo_Pag = "Cachê Fixo";
                }
                func.N_ARTISTAS = dgvArtistasSelect.Rows.Count;

                func.Valor_Evento = Convert.ToDouble(this.txtValor.Text);


                switch (operacao)
                {
                    case 0: //inclusao


                        func.Evento_crud('I');


                        int i = dgvArtistasSelect.Rows.Count;
                        int contagem = 1;
                        while (i != i - i)
                        {
                            // MessageBox.Show("i: " +i.ToString() + ",artistaid: " + this.dgvArtistasSelect.Rows[this.dgvArtistasSelect.Rows.Count - 1].Cells[0].Value.ToString());
                            func.ID_ARTISTA_GERAL = Convert.ToInt32(this.dgvArtistasSelect.Rows[this.dgvArtistasSelect.Rows.Count - contagem].Cells[0].Value);
                            func.IncluirEventoArtista();
                            i = i - 1;
                            contagem = contagem + 1;

                        }

                        Oracle.DataAccess.Client.OracleDataReader dr;
                        dr = func.ConsultarValorMaximo();
                        log.TIPO_LOG = "INSERÇÃO";
                        if (dr.Read())
                        {
                            log.ID_MODIFICADO = Convert.ToInt32(dr["ID"]);
                        }
                        log.Log_crud('I');

                        break;
                    case 1: //alteracao
                        func.ID_EVENTO = Convert.ToInt32(this.txtCodigo.Text);
                        
                        func.Evento_crud('A');
                        func.ExcluirArtista();
                        int i2 = dgvArtistasSelect.Rows.Count;
                        int contagem2 = 1;
                        while (i2 != i2 - i2)
                        {

                            func.ID_ARTISTA_GERAL = Convert.ToInt32(this.dgvArtistasSelect.Rows[this.dgvArtistasSelect.Rows.Count - contagem2].Cells[0].Value);
                            
                            
                            func.AdicionarEventoArtista();
                            i2 = i2 - 1;
                            contagem2 = contagem2 + 1;

                        }

                        log.TIPO_LOG = "ALTERAÇÃO";
                        log.Log_crud('A');
                       

                        break;
                }



                btnSalvar.Cursor = Cursors.Hand;

                MessageBox.Show("Operação realizada com sucesso!");



                this.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        private void ProcurarHorario()
        {
            try
            {
                if (operacao==0)
                {
                    this.mtbHorario_INICIO.Focus();
                    this.mtbHorario_INICIO.Text = "18:00";
                }
                if(dgvHorario.Rows.Count != 1 && operacao!=0)
                {
                    var horariofinal = this.dgvHorario.Rows[this.dgvHorario.Rows.Count - 2].Cells[5].Value;
                    var horarioinicial = this.dgvHorario.Rows[this.dgvHorario.Rows.Count - 2].Cells[4].Value;
                    var data = this.dgvHorario.Rows[this.dgvHorario.Rows.Count - 2].Cells[2].Value;
                    this.mtbHorario_INICIO.Focus();
                    this.mtbHorario_INICIO.Text = horariofinal.ToString();
                    this.dtpDataEventoDMY.Value = Convert.ToDateTime(data);
                    // MessageBox.Show(horariofinal.ToString(), "Valor Da coluna 'Nome'", MessageBoxButtons.OK);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        private void CarregarSalvar(Object o, EventArgs e)
        {
            Salvar();
        }

        private void CarregarGridArtistas() {
            try
            {
                BLL.Artista obj = new BLL.Artista(); // <<<<<<<<<<<<<<<<
                int ativo = 0;


                ativo = 1;

                switch (tipo2)
                {
                    case "Contratação":
                        tipo2 = "P.DATA_CRIACAO";
                        break;
                    case "Nascimento":
                        tipo2 = "P.DATA_NASC";
                        break;
                    case null: case "":
                        break;
                }


                switch (tipo)
                {
                    case "CPFEmpresario":
                    case "CNPJEmpresario":
                        tipo = "AGT.DOCUMENTO";
                        break;
                    case "CPF":
                        tipo = "AF.CPF";
                        break;
                    case "NomeEmpresario":
                        tipo = "AGT.NOME_PRINCIPAL";
                        break;
                    case "Telefone":
                        tipo = "AF.TELEFONE";
                        break;
                    case "Email":
                        tipo = "AF.EMAIL";
                        break;

                    case "Nome":
                    case null: case "":
                        tipo = "P.NOME";
                        break;
                    case "Codigo":
                        tipo = "AG.ID_ARTISTA_GERAL";
                        break;

                }

                switch (tipo3)
                {
                    case "Ambos":
                        if (tipo2 != string.Empty && tipo2 != null)
                        {
                            obj.DataListarInicio = Convert.ToDateTime(this.dtpHorarioInicio.Value.ToString().Substring(0, 10));
                            obj.DataListarFinal = Convert.ToDateTime(this.dtpHorarioFinal.Value.ToString().Substring(0, 10));
                            this.dgvArtistas.DataSource = obj.ListarGeral(tipo3, txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, tipo2).Tables[0];
                        }
                        else
                        {
                            this.dgvArtistas.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, "").Tables[0];
                        }

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
                        break;
                    case "Artista":
                        if (tipo2 != string.Empty && tipo2 != null)
                        {
                            obj.DataListarInicio = Convert.ToDateTime(this.dtpHorarioInicio.Value.ToString().Substring(0, 10));
                            obj.DataListarFinal = Convert.ToDateTime(this.dtpHorarioFinal.Value.ToString().Substring(0, 10));
                            if (tipo.IndexOf("DOCUMENTO") >= 0)
                            {
                                this.dgvArtistas.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Replace(".", "").ToUpper(), ativo, tipo, tipo2).Tables[0];
                            }
                            else
                            {
                                this.dgvArtistas.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, tipo2).Tables[0];
                            }


                        }
                        else
                        {
                            if (tipo.IndexOf("DOCUMENTO") >= 0)
                            {
                                this.dgvArtistas.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Replace(".", "").ToUpper(), ativo, tipo, "").Tables[0];
                            }
                            else
                            {
                                this.dgvArtistas.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, "").Tables[0];
                            }


                        }

                        this.dgvArtistas.Columns[0].HeaderText = "Cód";
                        this.dgvArtistas.AutoResizeColumn(0);
                        this.dgvArtistas.Columns[1].HeaderText = "Nome";
                        this.dgvArtistas.AutoResizeColumn(1);
                        this.dgvArtistas.Columns[2].HeaderText = "Tipo Artista";
                        this.dgvArtistas.AutoResizeColumn(2);
                        this.dgvArtistas.Columns[3].HeaderText = "Sexo";
                        this.dgvArtistas.AutoResizeColumn(3);
                        this.dgvArtistas.Columns[4].HeaderText = "Nome Empresário";
                        this.dgvArtistas.AutoResizeColumn(4);
                        this.dgvArtistas.Columns[5].HeaderText = "Documento Empresário";
                        this.dgvArtistas.AutoResizeColumn(5);
                        this.dgvArtistas.Columns[6].HeaderText = "Facebook";
                        this.dgvArtistas.AutoResizeColumn(6);
                        this.dgvArtistas.Columns[7].HeaderText = "Twiiter";
                        this.dgvArtistas.AutoResizeColumn(7);
                        this.dgvArtistas.Columns[8].HeaderText = "Instagram";
                        this.dgvArtistas.AutoResizeColumn(8);
                        this.dgvArtistas.Columns[9].HeaderText = "Ativo";
                        this.dgvArtistas.AutoResizeColumn(9);
                        this.dgvArtistas.Columns[10].HeaderText = "Data de Criação";
                        this.dgvArtistas.AutoResizeColumn(10);
                        break;
                    case "ArtistaFixo":
                        if (tipo2 != string.Empty && tipo2 != null)
                        {
                            obj.DataListarInicio = Convert.ToDateTime(this.dtpHorarioInicio.Value.ToString().Substring(0, 10));
                            obj.DataListarFinal = Convert.ToDateTime(this.dtpHorarioFinal.Value.ToString().Substring(0, 10));
                            if (tipo.IndexOf("CPF") >= 0 || tipo.IndexOf("TELEFONE") >= 0)
                            {
                                this.dgvArtistas.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Replace(".", "").Replace("(", "").Replace(")", "").ToUpper(), ativo, tipo, tipo2).Tables[0];
                            }
                            else
                            {
                                this.dgvArtistas.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, tipo2).Tables[0];
                            }
                        }
                        else
                        {
                            if (tipo.IndexOf("CPF") >= 0 || tipo.IndexOf("TELEFONE") >= 0)
                            {
                                this.dgvArtistas.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "").ToUpper(), ativo, tipo, "").Tables[0];
                            }
                            else
                            {
                                this.dgvArtistas.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, "").Tables[0];
                            }

                        }

                        this.dgvArtistas.Columns[0].HeaderText = "Cód";
                        this.dgvArtistas.AutoResizeColumn(0);
                        this.dgvArtistas.Columns[1].HeaderText = "Nome";
                        this.dgvArtistas.AutoResizeColumn(1);
                        this.dgvArtistas.Columns[2].HeaderText = "Tipo Artista";
                        this.dgvArtistas.AutoResizeColumn(2);
                        this.dgvArtistas.Columns[3].HeaderText = "Sexo";
                        this.dgvArtistas.AutoResizeColumn(3);
                        this.dgvArtistas.Columns[4].HeaderText = "CPF";
                        this.dgvArtistas.AutoResizeColumn(4);
                        this.dgvArtistas.Columns[5].HeaderText = "Facebook";
                        this.dgvArtistas.AutoResizeColumn(5);
                        this.dgvArtistas.Columns[6].HeaderText = "Twiiter";
                        this.dgvArtistas.AutoResizeColumn(6);
                        this.dgvArtistas.Columns[7].HeaderText = "Instagram";
                        this.dgvArtistas.AutoResizeColumn(7);
                        this.dgvArtistas.Columns[8].HeaderText = "Ativo";
                        this.dgvArtistas.AutoResizeColumn(8);
                        this.dgvArtistas.Columns[9].HeaderText = "Data de Criação";
                        this.dgvArtistas.AutoResizeColumn(9);
                        break;
                }



                this.txtPesquisar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }


        }
        private void LeaveMaisculo(object sender, EventArgs e)
        {
            var b = (TextBox)sender;
            b.Text = b.Text.ToUpper();
        }

        //int NArtiR;
        //int[] ArtistaRemovido = new int[1000];
        private void ExcluirArtista(Object o, EventArgs e)
        {
            if (this.dgvArtistasSelect.CurrentRow != null)
            {
                BLL.Evento func = new BLL.Evento();
                //NArtiR = NArtiR + 1;
                //ArtistaRemovido[NArtiR] = Convert.ToInt32(this.dgvArtistasSelect.CurrentRow.Cells[0].Value);
                if (this.dgvArtistasSelect.CurrentRow.Cells[2].Value.ToString() == "ARTISTA-FIXO")
                {
                    this.rbBilheteria.Visible = true;
                    
                }
                dgvArtistasSelect.Rows.Remove(this.dgvArtistasSelect.CurrentRow);
            }
            

        }

        private void TotalHorarioDia(object o, EventArgs e)
        {
            try
            {
                this.erro.SetError(mtbHorario_INICIO, string.Empty);
                BLL.Evento evento = new BLL.Evento();

                if (operacao == 0)
                {
                    this.dgvHorario.DataSource = evento.ListarDIA(dtpDataEventoDMY.Value.ToString().Substring(0, 10), '0').Tables[0];
                }
                else
                {
                    evento.ID_EVENTO = Convert.ToInt32(this.txtCodigo.Text);
                    this.dgvHorario.DataSource = evento.ListarDIA(dtpDataEventoDMY.Value.ToString().Substring(0, 10), '1').Tables[0];
                }
                //this.lblDiaHorario.Text = this.dtpDataEventoDMY.Value.ToString().Substring(0, 10);
                this.dgvHorario.Columns[0].HeaderText = "Cód";

                this.dgvHorario.AutoResizeColumn(0);
                this.dgvHorario.Columns[1].HeaderText = "Título";
                this.dgvHorario.AutoResizeColumn(1);
                this.dgvHorario.Columns[2].HeaderText = "DataDoEvento";
                this.dgvHorario.AutoResizeColumn(2);
                this.dgvHorario.Columns[3].HeaderText = "Descrição";
                this.dgvHorario.AutoResizeColumn(3);
                this.dgvHorario.Columns[4].HeaderText = "Horário Inicial";
                this.dgvHorario.AutoResizeColumn(4);
                this.dgvHorario.Columns[5].HeaderText = "Horário Final";
                this.dgvHorario.AutoResizeColumn(5);
                this.dgvHorario.Columns[6].HeaderText = "Duração";
                this.dgvHorario.AutoResizeColumn(6);
                this.dgvHorario.Columns[7].HeaderText = "Quantidade de Artistas";
                this.dgvHorario.AutoResizeColumn(7);
                this.dgvHorario.Columns[8].HeaderText = "Tipo de Pagamento";
                this.dgvHorario.AutoResizeColumn(8);
                this.dgvHorario.Columns[9].HeaderText = "Ativo";
                this.dgvHorario.AutoResizeColumn(9);
                this.dgvHorario.Columns[10].HeaderText = "Valor do Evento";
                this.dgvHorario.AutoResizeColumn(10);

                string HorarioFinal = this.mtbHorario_FINAL.Value.ToString().Substring(11, 5).Trim();
                if (HorarioFinal=="00:00")
                {
                    HorarioFinal = "23:59";
                }
                if (Convert.ToDateTime(this.dtpDataEventoDMY.Value.ToString().Substring(0, 10) + " " + HorarioFinal) >Convert.ToDateTime(DateTime.Now.ToString().Substring(0,10)))
                {
                    if (operacao!=5)
                    {
                        chkAtivo.Enabled = true;
                    }
                  
                }
                else
                {
                    if (operacao != 5)
                    {
                        chkAtivo.Enabled = false;
                    }
                    
                    chkAtivo.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }
        private void AdicionarArtista(object sender, EventArgs e)
        {
            try
            {


                BLL.Artista arti = new BLL.Artista();


               

                if (dgvArtistasSelect.ColumnCount == 0)
                {
                    this.dgvArtistasSelect.Columns.Add("ID_ARTISTA_GERAL", "Código do Artista");
                    this.dgvArtistasSelect.Columns.Add("NOME", "Nome");
                    this.dgvArtistasSelect.Columns.Add("TIPO_PESSOA", "Tipo Artista");
                    this.dgvArtistasSelect.Columns.Add("SEXO", "Sexo");
                    this.dgvArtistasSelect.Columns.Add("FACEBOOK", "Facebook");
                    this.dgvArtistasSelect.Columns.Add("TWITTER", "Twitter");
                    this.dgvArtistasSelect.Columns.Add("INSTAGRAM", "Instagram");
                    this.dgvArtistasSelect.Columns.Add("ATIVO", "Ativo");
                    this.dgvArtistasSelect.Columns.Add("DATA_CRIACAO", "Data de Criação");

                }
                var index = dgvArtistasSelect.Rows.Add();



                if (this.dgvArtistasSelect.RowCount > 1)
                {
                    if (ChecarExisteGrid(index))
                    {
                        this.dgvArtistasSelect.Rows[index].Cells["ID_ARTISTA_GERAL"].Value = this.dgvArtistas.CurrentRow.Cells[0].Value;
                        this.dgvArtistasSelect.Rows[index].Cells["NOME"].Value = this.dgvArtistas.CurrentRow.Cells[1].Value;
                        this.dgvArtistasSelect.Rows[index].Cells["TIPO_PESSOA"].Value = this.dgvArtistas.CurrentRow.Cells[2].Value;
                        this.dgvArtistasSelect.Rows[index].Cells["SEXO"].Value = this.dgvArtistas.CurrentRow.Cells[3].Value;
                        this.dgvArtistasSelect.Rows[index].Cells["FACEBOOK"].Value = this.dgvArtistas.CurrentRow.Cells[4].Value;
                        this.dgvArtistasSelect.Rows[index].Cells["TWITTER"].Value = this.dgvArtistas.CurrentRow.Cells[5].Value;
                        this.dgvArtistasSelect.Rows[index].Cells["INSTAGRAM"].Value = this.dgvArtistas.CurrentRow.Cells[6].Value;
                        this.dgvArtistasSelect.Rows[index].Cells["ATIVO"].Value = this.dgvArtistas.CurrentRow.Cells[7].Value;
                        this.dgvArtistasSelect.Rows[index].Cells["DATA_CRIACAO"].Value = this.dgvArtistas.CurrentRow.Cells[8].Value;
                       




                    }
                    else
                    {
                        this.dgvArtistasSelect.Rows.Remove(this.dgvArtistasSelect.Rows[index]);
                    }
                }
                else
                {

                    this.dgvArtistasSelect.Rows[index].Cells["ID_ARTISTA_GERAL"].Value = this.dgvArtistas.CurrentRow.Cells[0].Value;
                    this.dgvArtistasSelect.Rows[index].Cells["NOME"].Value = this.dgvArtistas.CurrentRow.Cells[1].Value;
                    this.dgvArtistasSelect.Rows[index].Cells["TIPO_PESSOA"].Value = this.dgvArtistas.CurrentRow.Cells[2].Value;
                    this.dgvArtistasSelect.Rows[index].Cells["SEXO"].Value = this.dgvArtistas.CurrentRow.Cells[3].Value;
                    this.dgvArtistasSelect.Rows[index].Cells["FACEBOOK"].Value = this.dgvArtistas.CurrentRow.Cells[4].Value;
                    this.dgvArtistasSelect.Rows[index].Cells["TWITTER"].Value = this.dgvArtistas.CurrentRow.Cells[5].Value;
                    this.dgvArtistasSelect.Rows[index].Cells["INSTAGRAM"].Value = this.dgvArtistas.CurrentRow.Cells[6].Value;
                    this.dgvArtistasSelect.Rows[index].Cells["ATIVO"].Value = this.dgvArtistas.CurrentRow.Cells[7].Value;
                    this.dgvArtistasSelect.Rows[index].Cells["DATA_CRIACAO"].Value = this.dgvArtistas.CurrentRow.Cells[8].Value;


                }

                if (this.dgvArtistas.CurrentRow.Cells[2].Value.ToString() == "ARTISTA-FIXO")
                {
                    this.rbBilheteria.Visible = false;
                    this.rbBilheteria.Checked = false;
                    this.rbCache.Checked = true;
                }

                this.dgvArtistas.AutoResizeColumn(0);
                this.dgvArtistas.AutoResizeColumn(1);
                this.dgvArtistas.AutoResizeColumn(2);
                this.dgvArtistas.AutoResizeColumn(3);
                this.dgvArtistas.AutoResizeColumn(4);
                this.dgvArtistas.AutoResizeColumn(5);
                this.dgvArtistas.AutoResizeColumn(6);
                this.dgvArtistas.AutoResizeColumn(7);
                this.dgvArtistas.AutoResizeColumn(8);
         

                this.dgvArtistasSelect.AutoResizeColumn(0);
                this.dgvArtistasSelect.AutoResizeColumn(1);
                this.dgvArtistasSelect.AutoResizeColumn(2);
                this.dgvArtistasSelect.AutoResizeColumn(3);
                this.dgvArtistasSelect.AutoResizeColumn(4);
                this.dgvArtistasSelect.AutoResizeColumn(5);
                this.dgvArtistasSelect.AutoResizeColumn(6);
                this.dgvArtistasSelect.AutoResizeColumn(7);
                this.dgvArtistasSelect.AutoResizeColumn(8);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }

        private bool ChecarExisteGrid(int idx)
        {
            bool ok = true;
            foreach (DataGridViewRow r in dgvArtistasSelect.Rows)
            {
                if (Convert.ToInt32(r.Cells["ID_ARTISTA_GERAL"].Value) == Convert.ToInt32(this.dgvArtistas.CurrentRow.Cells[0].Value))
                {
                    ok = false;

                }

            }

            return ok;
        }
        private void CadastrarArtista(object sender, EventArgs e)
        {
            Negocios.Artistas.frmArtistaCadastro f = new Artistas.frmArtistaCadastro
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                operacao = 0,
                TopMost= true
            };
            f.btnCancelar.Visible = true;
            f.pbCancelar.Visible = true;
            f.Size = new Size(f.Width+15, f.Height+15);
            
            f.idFunc = this.idFunc; f.ShowDialog();
            CarregarGridArtistas();
        }
        private void ConsultarArtista(object sender, EventArgs e)
        {
            Negocios.Artistas.frmArtistaCadastro f = new Artistas.frmArtistaCadastro
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true
            };
            f.txtNomeArti.Enabled = false;
            f.codigo = Convert.ToInt32(this.dgvArtistas.CurrentRow.Cells[0].Value);
            f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);
            f.Tipo_Art = this.dgvArtistas.CurrentRow.Cells[2].Value.ToString();
            f.Size = new Size(f.Width + 30, f.Height + 30);
            f.chkArtista_Fixo.Enabled = false;
            f.chkDataArti.Visible = false;
            f.chkArtista_Fixo.Visible = false;
            // f.txtComplemento.Enabled = false;
            f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;
            f.gbCodigo.Visible = true;
            // f.txtCidade.Enabled = false;
            // f.cbEstado.Enabled = false;
            f.cbSexo.Enabled = false;
            // f.nupIdade.Enabled = false;
            f.chkAtivo.Enabled = false;
            // f.txtBairro.Enabled = false;
            // f.nupNumeroCasa.Enabled = false;
            f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible=false; f.btnLimpar.Visible=false;
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
            f.chkTelFixo.Visible = false;
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
            f.btnCancelar.Visible = true;
            f.pbCancelar.Visible = true;
            f.idFunc = this.idFunc; f.ShowDialog();
        }

        private void dgvArtistasSelect_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void txtPesquisarMask_KeyPress(object sender, KeyPressEventArgs k)
        {
            if (!char.IsDigit(k.KeyChar) && k.KeyChar != (char)8 && tipo == "AG.ID_ARTISTA_GERAL")

            {

                k.Handled = true;

            }
            if (k.KeyChar == (char)13)
            {
                CarregarGridArtistas();
            }
            else if (k.KeyChar == (char)6)
            {
                Filtro();
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)

            {

                e.Handled = true;

            }
            else
            {
                
            }
            if (e.KeyChar == (char)44)
            {
                if (this.txtValor.Text == string.Empty)
                { e.Handled = true; }
                if (this.txtValor.Text.IndexOf(",") > 0 || this.txtValor.Text.IndexOf(",") == 0)
                {
                    e.Handled = true;
                }
            }
            if (e.KeyChar == (char)48)
            {
                var b = (TextBox)sender;
                if (b.Text.Replace("0", "") == string.Empty && b.Text.Length >= 1)
                {
                    e.Handled = true;
                }
            }
        }

        private void ExibirArts(object sender, EventArgs e)
        {
            CarregarGridArtistas();
           
        }

        private void dgvHorario_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (this.dgvHorario.Rows.Count >0)
            {
                this.btnConsultarEvent.Enabled = true;
                this.pbConsultarEvent.Enabled = true;
            }
            else
            {
                this.btnConsultarEvent.Enabled =false;
                this.pbConsultarEvent.Enabled = false;
            }
        }

        private void AbrirFiltro(object sender, EventArgs e)
        {
            Filtro();
        }
        private void Filtro()
        {
            if (this.dtpHorarioFinal.Visible == true || txtPesquisarMask.Visible == true)
            {
                this.txtPesquisar.Width = Convert.ToInt32(WPTotal);
                this.txtPesquisarMask.Width = Convert.ToInt32(WPTotal);

                this.dtpHorarioInicio.Visible = false;
                this.dtpHorarioFinal.Visible = false;
                this.lblHorarioFiltro.Visible = false;

            }

            Negocios.Filtros.frmArtistaFiltro filtro = new Negocios.Filtros.frmArtistaFiltro();
            filtro.tipo2 = tipo2;
            filtro.tipo3 = tipo3;
            filtro.tipo = tTemp;
            filtro.tCod = tCod;
            filtro.TopMost = true;
            filtro.ShowDialog();
            tTemp = filtro.tipo;

            tipo2 = filtro.tipo2;
            tipo3 = filtro.tipo3;
            tipo = filtro.tipo;
            tCod = filtro.tCod;

            switch (filtro.tipo)
            {
                case "CPFEmpresario":
                case "CPF":
                    this.txtPesquisar.Visible = false;
                    this.txtPesquisarMask.Visible = true;
                    this.txtPesquisarMask.Mask = "000000000-00";
                    this.txtPesquisarMask.ValidatingType = typeof(Int32);
                    break;
                case "CNPJEmpresario":
                    this.txtPesquisar.Visible = false;
                    this.txtPesquisarMask.Visible = true;
                    this.txtPesquisarMask.Mask = "00,000,000/0000-00";
                    this.txtPesquisarMask.ValidatingType = typeof(Int32);
                    break;
                case "Telefone":
                    this.txtPesquisar.Visible = false;
                    this.txtPesquisarMask.Visible = true;
                    this.txtPesquisarMask.Mask = "(00)000000000";
                    this.txtPesquisarMask.ValidatingType = typeof(Int32);
                    break;
                default:
                    this.txtPesquisar.Visible = true;
                    this.txtPesquisarMask.Visible = false;
                    break;
            }
            if (filtro.tipo2 != string.Empty && filtro.tipo2 != null)
            {
                this.txtPesquisar.Width = Convert.ToInt32(WPData);
                this.txtPesquisarMask.Width = Convert.ToInt32(WPData);

                this.dtpHorarioInicio.Visible = true;
                this.dtpHorarioFinal.Visible = true;
                this.lblHorarioFiltro.Visible = true;
            }
            else
            {

                this.dtpHorarioInicio.Visible = false;
                this.dtpHorarioFinal.Visible = false;
                this.lblHorarioFiltro.Visible = false;
            }
            CarregarGridArtistas();
        }
        ////////////////
    }
}
