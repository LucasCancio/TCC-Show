using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Filtros
{
    public partial class frmProcurarArtista : Modelos.ModeloGeral
    {
        public frmProcurarArtista()
        {
            InitializeComponent();
            this.rbAmbos.Checked = true;
            this.cbEmpresa.SelectedIndex = 0;
            this.cbAmbos.SelectedIndex = 0;
            this.cbEmpresario.SelectedIndex = 0;
            this.cbData.SelectedIndex = 0;
            tipo = "Nome";

            WPTotal = this.txtPesquisar.Width;
            WPData = txtPesquisar.Width - this.dtpHorarioInicio.Width - 10;
            this.dtpHorarioFinal.Value = Convert.ToDateTime(DateTime.Now.ToString().Substring(0, 10));
            this.dtpHorarioInicio.Value = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToString().Substring(0, 10));
        }
   

        double WPTotal, WPData;
        string tTemp;
        public string tipo3 = "Ambos", tCod, tipo = "", tipo2;
        private void Cancelar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cancelar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; }
            this.Dispose();
        }

        private void frmEventoProcurar_KeyPress(object sender, KeyPressEventArgs k)
        {
            if (!char.IsDigit(k.KeyChar) && k.KeyChar != (char)8 && tipo == "AG.ID_ARTISTA_GERAL")

            {

                k.Handled = true;

            }
            if (k.KeyChar == (char)13)
            {
                CarregarGrid();
            }
            else if (k.KeyChar == (char)6)
            {
                Filtro();
            }

        }

        private void Exibir(object sender, EventArgs e)
        {
            this.dtpHorarioFinal.MinDate = this.dtpHorarioInicio.Value;
            this.dtpHorarioInicio.MaxDate = this.dtpHorarioFinal.Value;


            //if (this.cbTipo.Text == "Data de Criação")
            //{
            //    this.dtpDataDeCriacao.Visible = true;
            //    this.txtPesquisar.Enabled = false;
            //}
            //else
            //{
            //    this.dtpDataDeCriacao.Visible = false;
            //    this.txtPesquisar.Enabled = true;
            //}
            CarregarGrid();


            this.txtPesquisar.Focus();
        }

        private string _FormNome;
        public string FormNome { get => _FormNome; set => _FormNome = value; }
        public int FormId { get => _FormId; set => _FormId = value; }

        private int _FormId;

        private void Confirmar(Object o, EventArgs e)
        {
            if (this.dgv.RowCount == 0)
            {
                return;
            }
            _FormNome = this.dgv.CurrentRow.Cells[1].Value.ToString();
            _FormId = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);


            this.Dispose();

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _FormNome = this.dgv.CurrentRow.Cells[1].Value.ToString();
            _FormId = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);



            this.Dispose();
        }
        public int ativo = 1;
        private void CarregarGrid()
        {
            try
            {
                BLL.Artista obj = new BLL.Artista(); // <<<<<<<<<<<<<<<<
 


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
                            this.dgv.DataSource = obj.ListarGeral(tipo3, txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, tipo2).Tables[0];
                        }
                        else
                        {
                            this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, "").Tables[0];
                        }

                        this.dgv.Columns[0].HeaderText = "Cód";
                        this.dgv.AutoResizeColumn(0);
                        this.dgv.Columns[1].HeaderText = "Nome";
                        this.dgv.AutoResizeColumn(1);
                        this.dgv.Columns[2].HeaderText = "Tipo Artista";
                        this.dgv.AutoResizeColumn(2);
                        this.dgv.Columns[3].HeaderText = "Sexo";
                        this.dgv.AutoResizeColumn(3);
                        this.dgv.Columns[4].HeaderText = "Facebook";
                        this.dgv.AutoResizeColumn(4);
                        this.dgv.Columns[5].HeaderText = "Twitter";
                        this.dgv.AutoResizeColumn(5);
                        this.dgv.Columns[6].HeaderText = "Instagram";
                        this.dgv.AutoResizeColumn(6);
                        this.dgv.Columns[7].HeaderText = "Ativo";
                        this.dgv.AutoResizeColumn(7);
                        this.dgv.Columns[8].HeaderText = "Data de Criação";
                        this.dgv.AutoResizeColumn(8);
                        break;
                    case "Artista":
                        if (tipo2 != string.Empty && tipo2 != null)
                        {
                            obj.DataListarInicio = Convert.ToDateTime(this.dtpHorarioInicio.Value.ToString().Substring(0, 10));
                            obj.DataListarFinal = Convert.ToDateTime(this.dtpHorarioFinal.Value.ToString().Substring(0, 10));
                            if (tipo.IndexOf("DOCUMENTO") >= 0 || tipo.IndexOf("TELEFONE") >= 0)
                            {
                                if (this.txtPesquisarMask.MaskFull)
                                {
                                    this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").ToUpper(), ativo, tipo, tipo2).Tables[0];
                                }
                                else
                                {
                                    this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Replace(".", "").Replace("(", "").Replace(")", "").ToUpper(), ativo, tipo, tipo2).Tables[0];
                                }

                            }
                            else
                            {
                                this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, tipo2).Tables[0];
                            }


                        }
                        else
                        {
                            if (tipo.IndexOf("DOCUMENTO") >= 0 || tipo.IndexOf("TELEFONE") >= 0)
                            {
                                if (this.txtPesquisarMask.MaskFull)
                                {
                                    this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").ToUpper(), ativo, tipo, "").Tables[0];
                                }
                                else
                                {
                                    this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Replace(".", "").Replace("(", "").Replace(")", "").ToUpper(), ativo, tipo, "").Tables[0];
                                }

                            }
                            else
                            {
                                this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, "").Tables[0];
                            }


                        }

                        this.dgv.Columns[0].HeaderText = "Cód";
                        this.dgv.AutoResizeColumn(0);
                        this.dgv.Columns[1].HeaderText = "Nome";
                        this.dgv.AutoResizeColumn(1);
                        this.dgv.Columns[2].HeaderText = "Tipo Artista";
                        this.dgv.AutoResizeColumn(2);
                        this.dgv.Columns[3].HeaderText = "Sexo";
                        this.dgv.AutoResizeColumn(3);
                        this.dgv.Columns[4].HeaderText = "Nome Empresário";
                        this.dgv.AutoResizeColumn(4);
                        this.dgv.Columns[5].HeaderText = "Documento Empresário";
                        this.dgv.AutoResizeColumn(5);
                        this.dgv.Columns[6].HeaderText = "Facebook";
                        this.dgv.AutoResizeColumn(6);
                        this.dgv.Columns[7].HeaderText = "Twiiter";
                        this.dgv.AutoResizeColumn(7);
                        this.dgv.Columns[8].HeaderText = "Instagram";
                        this.dgv.AutoResizeColumn(8);
                        this.dgv.Columns[9].HeaderText = "Ativo";
                        this.dgv.AutoResizeColumn(9);
                        this.dgv.Columns[10].HeaderText = "Data de Criação";
                        this.dgv.AutoResizeColumn(10);
                        break;
                    case "ArtistaFixo":
                        if (tipo2 != string.Empty && tipo2 != null)
                        {
                            obj.DataListarInicio = Convert.ToDateTime(this.dtpHorarioInicio.Value.ToString().Substring(0, 10));
                            obj.DataListarFinal = Convert.ToDateTime(this.dtpHorarioFinal.Value.ToString().Substring(0, 10));
                            if (tipo.IndexOf("CPF") >= 0 || tipo.IndexOf("TELEFONE") >= 0)
                            {
                                if (this.txtPesquisarMask.MaskFull)
                                {
                                    this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").ToUpper(), ativo, tipo, tipo2).Tables[0];
                                }
                                else
                                {
                                    this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Replace(".", "").Replace("(", "").Replace(")", "").ToUpper(), ativo, tipo, tipo2).Tables[0];
                                }

                            }
                            else
                            {
                                this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, tipo2).Tables[0];
                            }
                        }
                        else
                        {
                            if (tipo.IndexOf("CPF") >= 0 || tipo.IndexOf("TELEFONE") >= 0)
                            {
                                if (this.txtPesquisarMask.MaskFull)
                                {
                                    this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").ToUpper(), ativo, tipo, "").Tables[0];
                                }
                                else
                                {
                                    this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "").ToUpper(), ativo, tipo, "").Tables[0];
                                }

                            }
                            else
                            {
                                this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, "").Tables[0];
                            }

                        }

                        this.dgv.Columns[0].HeaderText = "Cód";
                        this.dgv.AutoResizeColumn(0);
                        this.dgv.Columns[1].HeaderText = "Nome";
                        this.dgv.AutoResizeColumn(1);
                        this.dgv.Columns[2].HeaderText = "Tipo Artista";
                        this.dgv.AutoResizeColumn(2);
                        this.dgv.Columns[3].HeaderText = "Sexo";
                        this.dgv.AutoResizeColumn(3);
                        this.dgv.Columns[4].HeaderText = "CPF";
                        this.dgv.AutoResizeColumn(4);
                        this.dgv.Columns[5].HeaderText = "Facebook";
                        this.dgv.AutoResizeColumn(5);
                        this.dgv.Columns[6].HeaderText = "Twiiter";
                        this.dgv.AutoResizeColumn(6);
                        this.dgv.Columns[7].HeaderText = "Instagram";
                        this.dgv.AutoResizeColumn(7);
                        this.dgv.Columns[8].HeaderText = "Ativo";
                        this.dgv.AutoResizeColumn(8);
                        this.dgv.Columns[9].HeaderText = "Data de Criação";
                        this.dgv.AutoResizeColumn(9);
                        break;
                }



                this.txtPesquisar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
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
                this.lblHorario.Visible = false;

            }

            Negocios.Filtros.frmArtistaFiltro filtro = new Negocios.Filtros.frmArtistaFiltro();
            filtro.tipo2 = tipo2;
            filtro.tipo = tTemp;
            filtro.tipo3 = tipo3;
            filtro.tCod = tCod;
            filtro.TopMost = true;
            filtro.ShowDialog();
            tTemp = filtro.tipo;

            tipo2 = filtro.tipo2;
            tipo = filtro.tipo;
            tipo3 = filtro.tipo3;
            tCod = filtro.tCod;


            switch (filtro.tipo)
            {
                case "CPF":
                    this.txtPesquisar.Visible = false;
                    this.txtPesquisarMask.Visible = true;
                    this.txtPesquisarMask.Mask = "000000000-00";
                    this.txtPesquisarMask.ValidatingType = typeof(Int32);
                    break;
                case "CNPJ":
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
                this.lblHorario.Visible = true;
            }
            else
            {

                this.dtpHorarioInicio.Visible = false;
                this.dtpHorarioFinal.Visible = false;
                this.lblHorario.Visible = false;
            }
            CarregarGrid();
        }

        private void AbrirFormulario(object sender, EventArgs e)
        {//INCLUIR ALTERAR CONSULTAR
            try
            {
                if (this.dgv.RowCount == 0) { MessageBox.Show("Nenhum Artista cadastrado!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                Negocios.Artistas.frmArtistaCadastro f = new Negocios.Artistas.frmArtistaCadastro
                {
                    operacao = Convert.ToByte(BLL.Operacao.Inclusao), idFunc=this.idFunc,
                    FormBorderStyle = FormBorderStyle.FixedToolWindow
                };

                f.Size = new Size(f.Width + 15, f.Height + 15);
                f.TopMost = true;
                f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;


                f.gbCodigo.Visible = true;
                f.codigo = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);
                f.Tipo_Art = this.dgv.CurrentRow.Cells[2].Value.ToString();

                if (sender == this.btnConsultar || sender == this.pbConsultar)
                {
                    f.lblTitulo.Text = "Consulta de";
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
                    f.btnProcurarImg.Enabled = false;
                    f.pbProcurarImg.Enabled = false;
                    f.btnRemoverImg.Enabled = false;
                    f.pbRemoverImg.Enabled = false;
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
                }


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
