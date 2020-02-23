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
    public partial class frmProcurarAgente : Modelos.ModeloGeral
    {
        public frmProcurarAgente()
        {
            InitializeComponent();
            this.dgv.DefaultCellStyle.BackColor = Color.LightGray;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor =
  Color.Silver;
            this.rbAmbos.Checked = true;
            this.cbEmpresa.SelectedIndex = 0;
            this.cbAmbos.SelectedIndex = 0;
            this.cbEmpresario.SelectedIndex = 0;
            this.cbData.SelectedIndex = 0;
            tipo = "Nome";
            WPTotal = this.txtPesquisar.Width;
            WPData = txtPesquisar.Width - this.dtpHorarioInicio.Width - 10;
        }


        double WPTotal, WPData;
        string tTemp;
        public string tipo3 = "Ambos", tCod;

        private string _FormNome;
        public string FormNome { get => _FormNome; set => _FormNome = value; }

        private int _FormIdAgente;
        public int FormIdAgente { get => _FormIdAgente; set => _FormIdAgente = value; }

        private string _FormTipoPessoa;
        public string FormTipoPessoa { get => _FormTipoPessoa; set => _FormTipoPessoa = value; }

        private string _FormCPF;
        public string FormCPF { get => _FormCPF; set => _FormCPF = value; }

        private string _FormCNPJ;
        public string FormCNPJ { get => _FormCNPJ; set => _FormCNPJ = value; }

        private string _FormTelefone;
        public string FormTelefone { get => _FormTelefone; set => _FormTelefone = value; }

        private string _FormEmail;
        public string FormEmail { get => _FormEmail; set => _FormEmail = value; }

        private string _FormCep;
        public string FormCep { get => _FormCep; set => _FormCep = value; }

        private string _FormEstado;
        public string FormEstado { get => _FormEstado; set => _FormEstado = value; }

        private string _FormCidade;
        public string FormCidade { get => _FormCidade; set => _FormCidade = value; }

        private string _FormBairro;
        public string FormBairro { get => _FormBairro; set => _FormBairro = value; }

        private string _FormComplemento;
        public string FormComplemento { get => _FormComplemento; set => _FormComplemento = value; }

        private string _FormLogradouro;
        public string FormLogradouro { get => _FormLogradouro; set => _FormLogradouro = value; }

        private int _FormNumeroCasa;
        public int FormNumeroCasa { get => _FormNumeroCasa; set => _FormNumeroCasa = value; }
        private void Confirmar(Object o, EventArgs e) {

            if (this.dgv.RowCount==0)
            {
                return;
            }
            _FormNome = this.dgv.CurrentRow.Cells[1].Value.ToString();
            _FormIdAgente = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);

            _FormTipoPessoa = this.dgv.CurrentRow.Cells[3].Value.ToString();

          

            if (this.dgv.CurrentRow.Cells[4].Value.ToString().Replace(" ", "").Length == 12)
            {
                _FormCPF= this.dgv.CurrentRow.Cells[4].Value.ToString();
               

            }
            else
            {
                _FormCNPJ = this.dgv.CurrentRow.Cells[4].Value.ToString();
               

            }
          

            _FormTelefone = this.dgv.CurrentRow.Cells[5].Value.ToString();
            _FormEmail = this.dgv.CurrentRow.Cells[6].Value.ToString();


            _FormCep= this.dgv.CurrentRow.Cells[8].Value.ToString();
            _FormEstado= this.dgv.CurrentRow.Cells[9].Value.ToString();
            _FormCidade= this.dgv.CurrentRow.Cells[10].Value.ToString();
            _FormBairro= this.dgv.CurrentRow.Cells[11].Value.ToString();
            _FormNumeroCasa = Convert.ToInt32(this.dgv.CurrentRow.Cells[12].Value);
            _FormComplemento = this.dgv.CurrentRow.Cells[13].Value.ToString();
            _FormLogradouro = this.dgv.CurrentRow.Cells[14].Value.ToString();


          

            this.Dispose();
            
        }

        private void frmAgenteConsulta_KeyPress(object sender, KeyPressEventArgs k)
        {
            if (!char.IsDigit(k.KeyChar) && k.KeyChar != (char)8 && tipo == "TB_AGENTE.ID_AGENTE")

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



            if (chkDataEsp.Checked == true)
            {

            }
            CarregarGrid();

            this.txtPesquisar.Focus();
        }

        public string tipo = "", tipo2;

        public int ativo = 1;

        private void CarregarGrid()
        {
            try
            {
                BLL.Empresario obj = new BLL.Empresario();


                
                switch (tipo2)
                {
                    case "Contratação":
                        tipo2 = "TB_AGENTE.DATA_CRIACAO";
                        break;
                    case null: case "":
                        break;
                }
                //switch (tipo)
                //{
                //    case "CPF":
                //    case "NomeCivil":
                //    case "NomeSocial":
                //        tipo3 = "Empresario";
                //        break;
                //    case "CNPJ":
                //    case "NomeFant":
                //    case "RazSocial":
                //        tipo3 = "Empresa";
                //        break;
                //}



                switch (tipo)
                {
                    case "CPF":
                    case "CNPJ":
                        tipo = "TB_AGENTE.DOCUMENTO";
                        break;
                    case "NomeSocial":
                    case "RazSocial":
                        tipo = "TB_AGENTE.NOME_SECUNDARIO";
                        break;
                    case "NomeCivil":
                    case "NomeFant":
                    case "Nome":
                    case null: case "":
                        tipo = "TB_AGENTE.NOME_PRINCIPAL";
                        break;
                    case "Codigo":
                        tipo = "TB_AGENTE.ID_AGENTE";
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
                        this.dgv.Columns[1].HeaderText = "Nome Fantasia/Civil";
                        this.dgv.AutoResizeColumn(1);
                        this.dgv.Columns[2].HeaderText = "Razão/Nome Social";
                        this.dgv.AutoResizeColumn(2);
                        this.dgv.Columns[3].HeaderText = "Tipo Pessoa";
                        this.dgv.AutoResizeColumn(3);
                        this.dgv.Columns[4].HeaderText = "Documento";
                        this.dgv.AutoResizeColumn(4);
                        this.dgv.Columns[5].HeaderText = "Telefone";
                        this.dgv.AutoResizeColumn(5);
                        this.dgv.Columns[6].HeaderText = "Email";
                        this.dgv.AutoResizeColumn(6);
                        this.dgv.Columns[7].HeaderText = "Ativo";
                        this.dgv.AutoResizeColumn(7);
                        this.dgv.Columns[8].HeaderText = "CEP";
                        this.dgv.AutoResizeColumn(8);
                        this.dgv.Columns[9].HeaderText = "Estado";
                        this.dgv.AutoResizeColumn(9);
                        this.dgv.Columns[10].HeaderText = "Cidade";
                        this.dgv.AutoResizeColumn(10);
                        this.dgv.Columns[11].HeaderText = "Bairro";
                        this.dgv.AutoResizeColumn(11);
                        this.dgv.Columns[12].HeaderText = "Número";
                        this.dgv.AutoResizeColumn(12);
                        this.dgv.Columns[13].HeaderText = "Complemento";
                        this.dgv.AutoResizeColumn(13);
                        this.dgv.Columns[14].HeaderText = "Descrição";
                        this.dgv.AutoResizeColumn(14);
                        this.dgv.Columns[15].HeaderText = "Data de Criação";
                        this.dgv.AutoResizeColumn(15);
                        break;
                    case "Empresa":
                        if (tipo2 != string.Empty && tipo2 != null)
                        {
                            obj.DataListarInicio = Convert.ToDateTime(this.dtpHorarioInicio.Value.ToString().Substring(0, 10));
                            obj.DataListarFinal = Convert.ToDateTime(this.dtpHorarioFinal.Value.ToString().Substring(0, 10));
                            if (tipo.IndexOf("DOCUMENTO") >= 0)
                            {
                                if (this.txtPesquisarMask.MaskFull)
                                {
                                    this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").ToUpper(), ativo, tipo, tipo2).Tables[0];
                                }
                                else
                                {
                                    this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Replace(".", "").ToUpper(), ativo, tipo, tipo2).Tables[0];
                                }

                            }
                            else
                            {
                                this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, tipo2).Tables[0];
                            }


                        }
                        else
                        {
                            if (tipo.IndexOf("DOCUMENTO") >= 0)
                            {
                                if (this.txtPesquisarMask.MaskFull)
                                {
                                    this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").ToUpper(), ativo, tipo, "").Tables[0];
                                }
                                else
                                {
                                    this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Replace(".", "").ToUpper(), ativo, tipo, "").Tables[0];
                                }

                            }
                            else
                            {
                                this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, "").Tables[0];
                            }


                        }

                        this.dgv.Columns[0].HeaderText = "Cód";
                        this.dgv.AutoResizeColumn(0);
                        this.dgv.Columns[1].HeaderText = "Nome Fantasia";
                        this.dgv.AutoResizeColumn(1);
                        this.dgv.Columns[2].HeaderText = "Razão Social";
                        this.dgv.AutoResizeColumn(2);
                        this.dgv.Columns[3].HeaderText = "Tipo Pessoa";
                        this.dgv.AutoResizeColumn(3);
                        this.dgv.Columns[4].HeaderText = "CNPJ";
                        this.dgv.AutoResizeColumn(4);
                        this.dgv.Columns[5].HeaderText = "Telefone";
                        this.dgv.AutoResizeColumn(5);
                        this.dgv.Columns[6].HeaderText = "Email";
                        this.dgv.AutoResizeColumn(6);
                        this.dgv.Columns[7].HeaderText = "Ativo";
                        this.dgv.AutoResizeColumn(7);
                        this.dgv.Columns[8].HeaderText = "CEP";
                        this.dgv.AutoResizeColumn(8);
                        this.dgv.Columns[9].HeaderText = "Estado";
                        this.dgv.AutoResizeColumn(9);
                        this.dgv.Columns[10].HeaderText = "Cidade";
                        this.dgv.AutoResizeColumn(10);
                        this.dgv.Columns[11].HeaderText = "Bairro";
                        this.dgv.AutoResizeColumn(11);
                        this.dgv.Columns[12].HeaderText = "Número";
                        this.dgv.AutoResizeColumn(12);
                        this.dgv.Columns[13].HeaderText = "Complemento";
                        this.dgv.AutoResizeColumn(13);
                        this.dgv.Columns[14].HeaderText = "Descrição";
                        this.dgv.AutoResizeColumn(14);
                        this.dgv.Columns[15].HeaderText = "Data de Criação";
                        this.dgv.AutoResizeColumn(15);
                        break;
                    case "Empresario":
                        if (tipo2 != string.Empty && tipo2 != null)
                        {
                            obj.DataListarInicio = Convert.ToDateTime(this.dtpHorarioInicio.Value.ToString().Substring(0, 10));
                            obj.DataListarFinal = Convert.ToDateTime(this.dtpHorarioFinal.Value.ToString().Substring(0, 10));
                            if (tipo.IndexOf("DOCUMENTO") >= 0)
                            {
                                if (this.txtPesquisarMask.MaskFull)
                                {
                                    this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").ToUpper(), ativo, tipo, tipo2).Tables[0];
                                }
                                else
                                {
                                    this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Replace(".", "").ToUpper(), ativo, tipo, tipo2).Tables[0];
                                }

                            }
                            else
                            {
                                this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, tipo2).Tables[0];
                            }
                        }
                        else
                        {
                            if (tipo.IndexOf("DOCUMENTO") >= 0)
                            {
                                if (this.txtPesquisarMask.MaskFull)
                                {
                                    this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").ToUpper(), ativo, tipo, "").Tables[0];
                                }
                                else
                                {
                                    this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisarMask.Text.Trim().Replace(" ", "").Replace("-", "").ToUpper(), ativo, tipo, "").Tables[0];
                                }

                            }
                            else
                            {
                                this.dgv.DataSource = obj.ListarGeral(tipo3, this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, "").Tables[0];
                            }

                        }

                        this.dgv.Columns[0].HeaderText = "Cód";
                        this.dgv.AutoResizeColumn(0);
                        this.dgv.Columns[1].HeaderText = "Nome Civil";
                        this.dgv.AutoResizeColumn(1);
                        this.dgv.Columns[2].HeaderText = "Nome Social";
                        this.dgv.AutoResizeColumn(2);
                        this.dgv.Columns[3].HeaderText = "Tipo Pessoa";
                        this.dgv.AutoResizeColumn(3);
                        this.dgv.Columns[4].HeaderText = "CPF";
                        this.dgv.AutoResizeColumn(4);
                        this.dgv.Columns[5].HeaderText = "Telefone";
                        this.dgv.AutoResizeColumn(5);
                        this.dgv.Columns[6].HeaderText = "Email";
                        this.dgv.AutoResizeColumn(6);
                        this.dgv.Columns[7].HeaderText = "Ativo";
                        this.dgv.AutoResizeColumn(7);
                        this.dgv.Columns[8].HeaderText = "CEP";
                        this.dgv.AutoResizeColumn(8);
                        this.dgv.Columns[9].HeaderText = "Estado";
                        this.dgv.AutoResizeColumn(9);
                        this.dgv.Columns[10].HeaderText = "Cidade";
                        this.dgv.AutoResizeColumn(10);
                        this.dgv.Columns[11].HeaderText = "Bairro";
                        this.dgv.AutoResizeColumn(11);
                        this.dgv.Columns[12].HeaderText = "Número";
                        this.dgv.AutoResizeColumn(12);
                        this.dgv.Columns[13].HeaderText = "Complemento";
                        this.dgv.AutoResizeColumn(13);
                        this.dgv.Columns[14].HeaderText = "Descrição";
                        this.dgv.AutoResizeColumn(14);
                        this.dgv.Columns[15].HeaderText = "Data de Criação";
                        this.dgv.AutoResizeColumn(15);
                        break;

                }



                this.txtPesquisar.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Erro: Nenhum Contato Cadastrado!");              
                //Sistema.Hub h = new Sistema.Hub();
                //// h.lblNomeTool.ForeColor = this.lblNomeTool.ForeColor;
                //this.Dispose();
                //h.ShowDialog();



            }
        }

        private void AbrirFormulario(object sender, EventArgs e)
        {//INCLUIR ALTERAR CONSULTAR
            try
            {
                if (this.dgv.RowCount == 0) { MessageBox.Show("Nenhum Empresário cadastrado!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                Negocios.Agente.frmAgenteCadastro f = new Negocios.Agente.frmAgenteCadastro
                {
                    operacao = Convert.ToByte(BLL.Operacao.Inclusao), idFunc=this.idFunc,
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size
                };


                f.Size = new Size(f.Width + 15, f.Height + 20);
                f.TopMost = true;
                f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;
                //this.Hide();

                if ( sender == this.btnConsultar || sender == this.pbConsultar)
                {
                    f.lblTitulo.Text = "Consulta de";
                    f.gbCodigo.Visible = true;
                    f.codigo = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                    f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);

                    f.txtTelefone.Enabled = true;
                    // f.txtEndereco.Enabled = true;
                    f.txtCPF.Enabled = true;
                    // f.txtComplemento.Enabled = true;
                    f.txtCodigo.Enabled = true;
                    f.txtCep.Enabled = true;

                    f.btnProcurarCEP.Enabled = true;
                    // f.txtCidade.Enabled = true;
                    // f.cbEstado.Enabled = true;

                    // f.nupIdade.Enabled = true;
                    f.chkAtivo.Enabled = true;
                    // f.txtBairro.Enabled = true;
                    //  f.nupNumeroCasa.Enabled = true;
                    f.btnSalvar.Visible = true; f.pbSalvar.Visible = true;
                    f.btnSalvar.Enabled = true; f.pbSalvar.Enabled = true;
                    f.btnSalvar.BackColor = Color.Lime;

                    f.btnValidarCPF.Enabled = true;


                    if (sender == this.btnConsultar || sender == this.pbConsultar)
                    {


                        f.txtTelefone.Enabled = false;
                        // f.txtEndereco.Enabled = false;
                        f.txtCPF.Enabled = false;
                        // f.txtComplemento.Enabled = false;
                        f.txtCodigo.Enabled = false; f.txtCodigo.Visible = true;
                        f.chkTelFixo.Enabled = false;
                        f.txtCep.Enabled = false;
                        // f.txtCidade.Enabled = false;
                        // f.cbEstado.Enabled = false;
                        f.txtEmail.Enabled = false;
                        f.txtTelefone.Enabled = false;
                        f.txtNomeFant.Enabled = false;
                        f.txtRazaoSocial.Enabled = false;
                        f.txtNomeCivil.Enabled = false;
                        f.txtNomeSocial.Enabled = false;
                        // f.nupIdade.Enabled = false;
                        f.chkAtivo.Enabled = false;


                        f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible = false; f.btnLimpar.Visible = false;

                        f.nupNumeroCasa.Enabled = false;
                        f.txtComplemento.Enabled = false;


                        f.btnValidarCPF.Enabled = false;

                        f.txtEmail.Enabled = false;
                        f.txtNomeFant.Enabled = false;
                        f.txtRazaoSocial.Enabled = false;
                        f.txtNomeCivil.Enabled = false;
                        f.txtNomeSocial.Enabled = false;
                        f.txtCNPJ.Enabled = false;
                        f.rbPJuridica.Enabled = false;
                        f.rbPFisica.Enabled = false;
                        f.btnValidarCNPJ.Enabled = false;
                        f.btnProcurarCEP.Enabled = false;
                        f.btnValidarEmail.Enabled = false;

                        f.operacao = Convert.ToByte(BLL.Operacao.Consulta);
                    }
                }
                f.btnCancelar.Visible = true;
                f.pbCancelar.Visible = true;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Size = new Size(1191,750 );
                //f.Size = new Size(f.Width + 15, f.Height + 15);
                f.idFunc = this.idFunc; f.ShowDialog();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }
        private void Cancelar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cancelar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; }
            this.Dispose();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _FormNome = this.dgv.CurrentRow.Cells[1].Value.ToString();
            _FormIdAgente = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);

            _FormTipoPessoa = this.dgv.CurrentRow.Cells[3].Value.ToString();



            if (this.dgv.CurrentRow.Cells[4].Value.ToString().Replace(" ", "").Length == 12)
            {
                _FormCPF = this.dgv.CurrentRow.Cells[4].Value.ToString();


            }
            else
            {
                _FormCNPJ = this.dgv.CurrentRow.Cells[4].Value.ToString();


            }


            _FormTelefone = this.dgv.CurrentRow.Cells[5].Value.ToString();
            _FormEmail = this.dgv.CurrentRow.Cells[6].Value.ToString();


            _FormCep = this.dgv.CurrentRow.Cells[8].Value.ToString();
            _FormEstado = this.dgv.CurrentRow.Cells[9].Value.ToString();
            _FormCidade = this.dgv.CurrentRow.Cells[10].Value.ToString();
            _FormBairro = this.dgv.CurrentRow.Cells[11].Value.ToString();
            _FormNumeroCasa = Convert.ToInt32(this.dgv.CurrentRow.Cells[12].Value);
            _FormComplemento = this.dgv.CurrentRow.Cells[13].Value.ToString();
            _FormLogradouro = this.dgv.CurrentRow.Cells[14].Value.ToString();




            this.Dispose();
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

            Negocios.Filtros.frmAgenteFiltro filtro = new Negocios.Filtros.frmAgenteFiltro();
            filtro.tipo2 = tipo2;
            filtro.tipo = tTemp;
            filtro.tCod = tCod;
            filtro.TopMost = true;
            filtro.ShowDialog();

            tTemp = filtro.tipo;
            tipo = filtro.tipo;
            tipo2 = filtro.tipo2;
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

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && tipo == "Codigo")

            {

                e.Handled = true;

            }

        }

        ///////////////////////////////////////////////
    }
}
