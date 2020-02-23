using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Ingresso
{
    public partial class frmIngresso : Modelos.ModeloPadrao
    {
        public frmIngresso()
        {
            InitializeComponent();
        }



        private string _Situacao;


        private int _idCliente;
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
      

        private int _idEvento;
        public int IdEvento { get => _idEvento; set => _idEvento = value; }


        private void ConsultarCliente(object sender, EventArgs e)
        {//INCLUIR ALTERAR CONSULTAR
            try
            {
                Cliente.frmClienteCadastro f = new Cliente.frmClienteCadastro
                {
                    operacao = Convert.ToByte(BLL.Operacao.Inclusao), idFunc=this.idFunc,
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size
                };

                f.TopMost = true;
                f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;

                if (sender == this.btnConsultarCli || sender == this.pbConsultarCli)
                {
                    f.codigo = _idCliente;
                    f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);
                    f.txtNome.Enabled = true;

                    // f.txtEndereco.Enabled = true;

                    // f.txtComplemento.Enabled = true;
                    f.txtCodigo.Enabled = true;
                    f.gbCodigo.Visible = true;
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



                    if (sender == this.btnConsultarCli || sender == this.pbConsultarCli)
                    {
                        f.txtNome.Enabled = false;

                        // f.txtEndereco.Enabled = false;

                        // f.txtComplemento.Enabled = false;
                        f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;
                        f.txtEmail.Enabled = false;
                        // f.txtCidade.Enabled = false;
                        // f.cbEstado.Enabled = false;
                        f.cbSexo.Enabled = false;
                        // f.nupIdade.Enabled = false;
                        f.chkAtivo.Enabled = false;
                        // f.txtBairro.Enabled = false;
                        // f.nupNumeroCasa.Enabled = false;
                        f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible = false; f.btnLimpar.Visible = false;
                        f.btnConsultar.Visible = false;
                        f.pbConsultar.Visible = false;
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
                    }
                }
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
        private void ConsultarArtista(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvArtistas.RowCount == 0) { MessageBox.Show("Nenhum Artista cadastrado!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                Negocios.Artistas.frmArtistaCadastro f = new Negocios.Artistas.frmArtistaCadastro
                {
                    operacao = Convert.ToByte(BLL.Operacao.Inclusao), idFunc=this.idFunc,
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size
                };


                f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;

               
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
                f.TopMost = true;
                f.pbCancelar.Visible = true;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.idFunc = this.idFunc; f.ShowDialog();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }



        private void CarregarCampos(object sender, EventArgs e)
        {

            try
            {
                _Situacao = string.Empty;
                BLL.Ingresso obj = new BLL.Ingresso();
                DataTable dt = new DataTable();
                this.txtCodigo.Text = codigo.ToString();
                obj.ID_VENDA = codigo;
                dt = obj.ListarIngressoAssento().Tables[0];
                dgvAssentos.Columns.Add("ASSENTO_NUMER", "Número");
                dgvAssentos.Columns.Add("ASSENTO_FILEIRA", "Fileira");
                dgvAssentos.Columns.Add("ASSENTO_TIPO", "Tipo");
                dgvAssentos.Columns.Add("ASSENTO_SETOR", "Setor");
               
                foreach (DataRow linha in dt.Rows)
                {
                    var index = dgvAssentos.Rows.Add();
                    _idCliente = Convert.ToInt32(linha["ID_CLIENTE"]);
                    _idEvento= Convert.ToInt32(linha["ID_EVENTO"]);
                    _Situacao = Convert.ToString(linha["SITUACAO"]);

                    dgvAssentos.Rows[index].Cells["ASSENTO_NUMER"].Value = linha["ASSENTO_NUMER"].ToString();
                    dgvAssentos.Rows[index].Cells["ASSENTO_FILEIRA"].Value = linha["ASSENTO_FILEIRA"].ToString();
                    dgvAssentos.Rows[index].Cells["ASSENTO_TIPO"].Value = linha["TIPO_ASSENTO"].ToString();
                    dgvAssentos.Rows[index].Cells["ASSENTO_SETOR"].Value = linha["SETOR"].ToString();
                }
                
                   
                CarregarCliente();
                CarregarEvento();
                CarregarArtistas();
                CarregarTransacao();

                if (_Situacao=="Cancelado")
                {
                    lblCancelado.Visible = true;
                    this.pbImprimir.Visible = false;
                    this.btnImprimir.Visible = false;
                    this.gbImprimir.Visible = false;
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }

       
        private void CarregarCliente()
        {
            try
            {
               

                BLL.Cliente cont = new BLL.Cliente();
                Oracle.DataAccess.Client.OracleDataReader dr;
                cont.ID_CLIENTE= _idCliente;
                if (_idCliente==0)
                {
                    this.tabela.TabPages.Remove(pageCliente);
                }
                else
                {
                   
                    dr = cont.Consultar();

                    if (dr.Read())
                    {
                        this.txtNomeCliente.Text = dr["NOME"].ToString();
                        this.txtCPF.Text = dr["CPF"].ToString();
                        this.dtpDataNasc.Value = Convert.ToDateTime(dr["DATA_NASC"]);
                    }

                }
               



            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);

            }
        }
        private void CarregarEvento() {
            try
            {


                BLL.Evento cont = new BLL.Evento();
                Oracle.DataAccess.Client.OracleDataReader dr;
                cont.ID_EVENTO = _idEvento;
                dr = cont.Consultar();

                if (dr.Read())
                {
                    this.txtTitulo.Text = dr["TITULO"].ToString();
                    this.mtbHorario_INICIO.Value = Convert.ToDateTime(dr["HORARIO_INICIO"]);
                    this.mtbHorario_FINAL.Value = Convert.ToDateTime(dr["HORARIO_FINAL"]);
                    this.dtpEvento.Value = Convert.ToDateTime(dr["DATA_EVENTO"]);
                    this.mtbDuracao.Text= dr["DURACAO"].ToString();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        private void CarregarArtistas() {
            try
            {
                BLL.Evento obj = new BLL.Evento(); // <<<<<<<<<<<<<<<<
                obj.ID_EVENTO = _idEvento;
                dgvArtistas.DataSource = obj.ListarArtistasDoEvento().Tables[0];
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }

        private void CarregarTransacao()
        {
            BLL.Ingresso obj = new BLL.Ingresso();
            DataTable dt = new DataTable();
            obj.ID_VENDA = codigo;
            dt = obj.ListarFormasPag().Tables[0];
            dgvFormasPag.Columns.Add("TIPO_PAGAMENTO", "Tipo de Pagamento");
            dgvFormasPag.Columns.Add("QUANTIA", "Quantia");


            foreach (DataRow linha in dt.Rows)
            {
                var index = dgvFormasPag.Rows.Add();
                txtValorTotal.Text = linha["PRECO_TOTAL"].ToString();
                dtpDataCompra.Value = Convert.ToDateTime(linha["DATAVENDA"].ToString());
                txtDesconto.Text = linha["DESCONTO"].ToString();
                txtTroco.Text= linha["TROCO"].ToString();
                txtValorTotalPago.Text = linha["PRECO_TOTAL_PAGO"].ToString();

                dgvFormasPag.Rows[index].Cells["TIPO_PAGAMENTO"].Value = linha["FORMA_PAGAMENTO"].ToString();
                dgvFormasPag.Rows[index].Cells["QUANTIA"].Value = linha["QUANTIA"].ToString();

            }
        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.Dispose();
        }





        //////////////////////////////////// RELATORIO

        private void Imprimir(object sender, EventArgs e)
        {
            try
            {
                printDialog1.Document = printDocument1;
                this.TopMost = false;

                //if (printDialog1.ShowDialog() == DialogResult.OK)
                //{
                //    this.printDocument1.Print();
                //}


                if (rbComprovante.Checked)
                {
                    printDialog1.Document = printDocument1;


                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        this.printDocument1.Print();
                    }
                    else
                    {
                        return;
                    }


                }
                else
                {
                    printDialog1.Document = printDocument1;

               
                    AssentosDGV = this.dgvAssentos.RowCount;
                    foreach (DataGridViewRow linha in dgvAssentos.Rows)
                    {
                        print = false;
                        this.TopMost = false;
                        if (printDialog1.ShowDialog() == DialogResult.OK)
                        {
                           
                            this.printDocument1.Print();
                            if (print)
                            {
                                if (AssentosDGV -1 == 0)
                                {
                                    this.TopMost = true;
                                    MessageBox.Show("Ingresso " + this.dgvAssentos.RowCount + "/" + this.dgvAssentos.RowCount + " finalizado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                  
                                }
                                else
                                {
                                    this.TopMost = true;
                                    MessageBox.Show("Ingresso " + (AssentosDGV - 1) + "/" + this.dgvAssentos.RowCount + " finalizado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                  
                                }
                            }
                            
                        }
                        else 
                        {
                            return;
                        }
                       


                        AssentosDGV = AssentosDGV - 1;
                    }
                }







                this.TopMost = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private Font bold = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
        private Font boldMenor = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
        private Font boldMini = new Font(FontFamily.GenericSansSerif, 6, FontStyle.Bold);
        private Font boldExtraMini = new Font(FontFamily.GenericSansSerif, 4, FontStyle.Bold);
        private Font regular = new Font(FontFamily.GenericSansSerif, 5, FontStyle.Regular);
        private Font regular2 = new Font(FontFamily.GenericSansSerif, 6, FontStyle.Regular);
        private Font regularItens = new Font(FontFamily.GenericSansSerif, 4, FontStyle.Regular);

        int AssentosDGV ;
   

      
     
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {



            if (rbComprovante.Checked)///RECIBO
            {
                Graphics graphics = e.Graphics;
                int offset = 105;

                //print header
                graphics.DrawString("Comedy House ltda", bold, Brushes.Black, 20, 0);
                graphics.DrawString("Rua Augusta" + " Nº " + "1129", regular, Brushes.Black, 20, 17);
                graphics.DrawString("CNPJ: 85.547.831/0001-30", regular, Brushes.Black, 100, 17);
                graphics.DrawLine(Pens.Black, 20, 30, 185, 30);
                graphics.DrawString("CUPOM NÃO FISCAL", bold, Brushes.Black, 30, 35);
                graphics.DrawLine(Pens.Black, 20, 50, 185, 50);
                graphics.DrawString("Código da Venda: " + this.txtCodigo.Text, boldMini, Brushes.Black, 65, 60);
                graphics.DrawLine(Pens.Black, 20, 75, 185, 75);


                //itens header
                graphics.DrawString("Forma Pagamento", boldMini, Brushes.Black, 20, 80);

                graphics.DrawString("Valor", boldMini, Brushes.Black, 145, 80);

                graphics.DrawLine(Pens.Black, 20, 95, 185, 95);

                //itens de venda
                foreach (DataGridViewRow linha in dgvFormasPag.Rows)
                {
                    string produto = linha.Cells[0].Value.ToString();
                    graphics.DrawString(produto.Length > 20 ? produto.Substring(0, 20) + "..." : produto, regularItens, Brushes.Black, 20, offset);
                    graphics.DrawString("R$" + linha.Cells[1].Value.ToString(), regularItens, Brushes.Black, 145, offset);

                    offset += 20;
                }


                //total
                graphics.DrawLine(Pens.Black, 20, offset, 185, offset);
                offset += 5;

                decimal total = 0;

                graphics.DrawString("TOTAL", bold, Brushes.Black, 20, offset);
                graphics.DrawString("R$"+this.txtValorTotal.Text, bold, Brushes.Black, 135, offset);

                offset += 20;

                graphics.DrawString("TOTAL DESCONTADO ", regular, Brushes.Black, 20, offset);
                graphics.DrawString("R$" + this.txtDesconto.Text, regular, Brushes.Black, 140, offset);

                offset += 15;

                graphics.DrawString("TOTAL PAGO ", regular, Brushes.Black, 20, offset);
                graphics.DrawString("R$" + this.txtValorTotalPago.Text, regular, Brushes.Black, 140, offset);

                offset += 15;


                graphics.DrawString("TROCO ", regular, Brushes.Black, 20, offset);
                graphics.DrawString("R$" + this.txtTroco.Text, regular, Brushes.Black, 140, offset);

                offset += 15;

                graphics.DrawLine(Pens.Black, 20, offset, 185, offset);
                offset += 5;


                if (_idCliente!=0)
                {


                    graphics.DrawString("Nome:", boldMini, Brushes.Black, 60, offset);

                    offset += 2;

                    string nome = this.txtNomeCliente.Text;
                    graphics.DrawString(nome.Length > 20 ? nome.Substring(0, 20) + "..." : nome, regularItens, Brushes.Black, 90, offset);

                    offset += 15;


                    graphics.DrawString("CPF: ", boldMini, Brushes.Black, 60, offset);

                    offset += 2;

                    graphics.DrawString(this.txtCPF.Text, regularItens, Brushes.Black, 90, offset);

                    offset += 15;

                    graphics.DrawLine(Pens.Black, 20, offset, 185, offset);



                    offset += 5;
                }




                graphics.DrawString("Foi um prazer recebê-lo", regularItens, Brushes.Black, 40, offset);

                offset -= 2;

                graphics.DrawString("Volte Sempre!!", boldMini, Brushes.Black, 110, offset);
                offset += 15;
                graphics.DrawLine(Pens.Black, 20, offset, 185, offset);
                offset += 5;



                //bottom
                graphics.DrawString("Emitido em: " + DateTime.Now.ToString("dd/MM/yyyy    HH:mm:ss"), regularItens, Brushes.Black, 60, offset);





                e.HasMorePages = false;
            }
            else//// INGRESSO
            {

                Graphics graphics = e.Graphics;
                int offset = 105;

                //print header
                graphics.DrawString("Comedy House ltda", bold, Brushes.Black, 20, 0);
                graphics.DrawString("Rua Augusta" + " Nº " + "1129", regular, Brushes.Black, 20, 17);
                graphics.DrawString("CNPJ: 85.547.831/0001-30", regular, Brushes.Black, 100, 17);
                graphics.DrawLine(Pens.Black, 20, 30, 185, 30);
                graphics.DrawString("INGRESSO", bold, Brushes.Black, 60, 35);
                graphics.DrawLine(Pens.Black, 20, 50, 185, 50);
                graphics.DrawString("Código da Venda: " + this.txtCodigo.Text, boldMini, Brushes.Black, 55, 60);
                graphics.DrawLine(Pens.Black, 20, 75, 185, 75);


                //itens header
                graphics.DrawString("Evento:", regular2, Brushes.Black, 20, 80);

                graphics.DrawString(txtTitulo.Text.Length > 20 ? txtTitulo.Text.Substring(0, 20) + "..." : txtTitulo.Text, boldMini, Brushes.Black, 55, 80);

                graphics.DrawLine(Pens.Black, 20, 95, 185, 95);

                //Inf dos ingressos

               

                graphics.DrawString("Data:", regular2, Brushes.Black, 30, offset);
                graphics.DrawString("Setor:", regular2, Brushes.Black, 110, offset);

                offset += 20;

                graphics.DrawString(this.dtpEvento.Value.ToString().Substring(0,10), boldMini, Brushes.Black, 30, offset);
                graphics.DrawString(this.dgvAssentos.Rows[AssentosDGV-1].Cells["ASSENTO_SETOR"].Value.ToString(), boldMini, Brushes.Black, 110, offset);

                offset += 20;

                graphics.DrawString("Fileira:", regular2, Brushes.Black, 30, offset);
                graphics.DrawString("Horário:", regular2, Brushes.Black, 110, offset);

                offset += 20;

                graphics.DrawString(this.dgvAssentos.Rows[AssentosDGV-1].Cells["ASSENTO_FILEIRA"].Value.ToString(), boldMini, Brushes.Black, 30, offset);
                graphics.DrawString(this.mtbHorario_INICIO.Value.ToString().Substring(11,5) + " até " + this.mtbHorario_FINAL.Value.ToString().Substring(11, 5), boldMini, Brushes.Black, 110, offset);

                offset += 20;

                graphics.DrawString("Tipo:", regular2, Brushes.Black, 30, offset);
                graphics.DrawString("Número:", regular2, Brushes.Black, 110, offset);

                offset += 20;

                graphics.DrawString(this.dgvAssentos.Rows[AssentosDGV-1].Cells["ASSENTO_TIPO"].Value.ToString(), boldMini, Brushes.Black, 30, offset);
                graphics.DrawString(this.dgvAssentos.Rows[AssentosDGV-1].Cells["ASSENTO_NUMER"].Value.ToString(), boldMini, Brushes.Black, 110, offset);

                offset += 20;


                //total
                graphics.DrawLine(Pens.Black, 20, offset, 185, offset);
                offset += 5;

                decimal total = 0;





                if (_idCliente != 0)
                {


                    graphics.DrawString("Nome:", boldMini, Brushes.Black, 60, offset);

                    offset += 2;

                    string nome = this.txtNomeCliente.Text;
                    graphics.DrawString(nome.Length > 20 ? nome.Substring(0, 20) + "..." : nome, regularItens, Brushes.Black, 90, offset);

                    offset += 15;


                    graphics.DrawString("CPF: ", boldMini, Brushes.Black, 60, offset);

                    offset += 2;

                    graphics.DrawString(this.txtCPF.Text, regularItens, Brushes.Black, 90, offset);

                    offset += 15;

                    graphics.DrawLine(Pens.Black, 20, offset, 185, offset);



                    offset += 5;
                }




                graphics.DrawString("Foi um prazer recebê-lo", regularItens, Brushes.Black, 40, offset);

                offset -= 2;

                graphics.DrawString("Volte Sempre!!", boldMini, Brushes.Black, 110, offset);
                offset += 15;

                graphics.DrawString("(Guardar esse ingresso até o fim do evento!!)", boldExtraMini, Brushes.Black, 40, offset);

                offset += 15;

                graphics.DrawLine(Pens.Black, 20, offset, 185, offset);
                offset += 5;

                //bottom
                graphics.DrawString("Emitido em: " + DateTime.Now.ToString("dd/MM/yyyy    HH:mm:ss"), regularItens, Brushes.Black, 60, offset);





               
                    e.HasMorePages = false;
                



            }

         


        }
        bool print = false;

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            
                if (!printDocument1.PrintController.IsPreview) {

                print = true;
                

                }
                   

                
            
        }




        //////////////////////////////////////////////////////////////
    }
}
