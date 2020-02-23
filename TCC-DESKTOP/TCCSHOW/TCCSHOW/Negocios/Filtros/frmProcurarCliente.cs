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
    public partial class frmProcurarCliente : Modelos.ModeloGeral
    {
        public frmProcurarCliente()
        {
            InitializeComponent();
            WPTotal = this.txtPesquisar.Width;
            WPData = txtPesquisar.Width - this.dtpHorarioInicio.Width - 10;
            tipo = "Nome";
        }


        double WPTotal, WPData;
        public string tipo, tipo2, tTitulo;
        public int tID;
        private void Cancelar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cancelar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; }
            this.Dispose();
        }

        private void frmClienteConsulta_KeyPress(object sender, KeyPressEventArgs k)
        {
            if (!char.IsDigit(k.KeyChar) && k.KeyChar != (char)8 && tipo == "CLI.ID_CLIENTE")

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
        public DateTime FormDataNasc { get => _FormDataNasc; set => _FormDataNasc = value; }
        public string FormCPF { get => _FormCPF; set => _FormCPF = value; }
        public string FormSexo { get => _FormSexo; set => _FormSexo = value; }

        private int _FormId;

        private DateTime _FormDataNasc;

        private string _FormCPF;

        private string _FormSexo;
        private void Confirmar(Object o, EventArgs e)
        {
            if (this.dgv.RowCount == 0)
            {
                return;
            }
            _FormNome = this.dgv.CurrentRow.Cells[1].Value.ToString();
            _FormId = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
            _FormDataNasc = Convert.ToDateTime(this.dgv.CurrentRow.Cells[3].Value);
            _FormCPF = this.dgv.CurrentRow.Cells[5].Value.ToString();
            _FormSexo = this.dgv.CurrentRow.Cells[2].Value.ToString();

            this.Dispose();

        }
        private void CarregarGrid()
        {
            try
            {
                BLL.Cliente obj = new BLL.Cliente(); // <<<<<<<<<<<<<<<<
                int ativo = 0;


                ativo = 1;

                switch (tipo2)
                {
                    case "NASCIMENTO":
                        tipo2 = "P.DATA_NASC";
                        break;
                    case null: case "":
                        break;
                }


                switch (tipo)
                {
                    case "Codigo":
                        tipo = "CLI.ID_CLIENTE";
                        break;
                    case "Nome":
                    case null: case "":
                        tipo = "P.NOME";
                        break;
                    case "Usuario":
                        tipo = "LG.USUARIO";
                        break;
                    case "CPF":
                        tipo = "CLI.CPF";
                        break;
                    case "Email":
                        tipo = "CLI.EMAIL";
                        break;
                }
                if (tipo.IndexOf("CPF") > 0)
                {
                    if (tipo2 != string.Empty && tipo2 != null)
                    {
                        obj.DataListarInicio = Convert.ToDateTime(this.dtpHorarioInicio.Value.ToString().Substring(0, 10));
                        obj.DataListarFinal = Convert.ToDateTime(this.dtpHorarioFinal.Value.ToString().Substring(0, 10));
                        if (txtPesquisarMask.MaskFull)
                        {
                            this.dgv.DataSource = obj.ListarGeral(this.txtPesquisarMask.Text.Trim().Replace(" ", "").ToUpper(), ativo, tipo, tipo2, tTitulo, tID).Tables[0];
                        }
                        else
                        {
                            this.dgv.DataSource = obj.ListarGeral(this.txtPesquisarMask.Text.Trim().Replace(" ", "").Replace("-", "").ToUpper(), ativo, tipo, tipo2, tTitulo, tID).Tables[0];
                        }
                       
                    }
                    else
                    {
                        if (txtPesquisarMask.MaskFull)
                        {
                            this.dgv.DataSource = obj.ListarGeral(this.txtPesquisarMask.Text.Trim().Replace(" ", "").ToUpper(), ativo, tipo, "", tTitulo, tID).Tables[0];
                        }
                        else
                        {
                            this.dgv.DataSource = obj.ListarGeral(this.txtPesquisarMask.Text.Trim().Replace(" ", "").Replace("-", "").ToUpper(), ativo, tipo, "", tTitulo, tID).Tables[0];
                        }
                       
                    }
                }
                else
                {
                    if (tipo2 != string.Empty && tipo2 != null)
                    {
                        obj.DataListarInicio = Convert.ToDateTime(this.dtpHorarioInicio.Value.ToString().Substring(0, 10));
                        obj.DataListarFinal = Convert.ToDateTime(this.dtpHorarioFinal.Value.ToString().Substring(0, 10));
                      
                            this.dgv.DataSource = obj.ListarGeral(this.txtPesquisar.Text.ToUpper(), ativo, tipo, tipo2, tTitulo, tID).Tables[0];
                        
                       
                    }
                    else
                    {
                        
                            this.dgv.DataSource = obj.ListarGeral(this.txtPesquisar.Text.ToUpper(), ativo, tipo, tipo2, tTitulo, tID).Tables[0];
                        
                    }
                }
                //if (chkDataEsp.Checked)
                //{
                //    //this.dgv.DataSource = obj.ListarGeral(this.dtpDataDeCriacao.Value.ToString().Substring(3, 7), ativo, tipo).Tables[0];
                //}
                //else
                //{

                //}


                this.dgv.Columns[0].HeaderText = "Cód";
                this.dgv.AutoResizeColumn(0);
                this.dgv.Columns[1].HeaderText = "Nome";
                this.dgv.AutoResizeColumn(1);
                this.dgv.Columns[2].HeaderText = "Sexo";
                this.dgv.AutoResizeColumn(2);
                this.dgv.Columns[3].HeaderText = "Data de Nascimento";
                this.dgv.AutoResizeColumn(3);
                this.dgv.Columns[4].HeaderText = "Ativo";
                this.dgv.AutoResizeColumn(4);
                this.dgv.Columns[5].HeaderText = "CPF";
                this.dgv.AutoResizeColumn(5);
                this.dgv.Columns[6].HeaderText = "Email";
                this.dgv.AutoResizeColumn(6);
                this.dgv.Columns[7].HeaderText = "Data de Criação";
                this.dgv.AutoResizeColumn(7);



                this.txtPesquisar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _FormNome = this.dgv.CurrentRow.Cells[1].Value.ToString();
            _FormId = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
            _FormDataNasc = Convert.ToDateTime(this.dgv.CurrentRow.Cells[3].Value);
            _FormCPF = this.dgv.CurrentRow.Cells[5].Value.ToString();
            _FormSexo = this.dgv.CurrentRow.Cells[2].Value.ToString();

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

            frmClienteFiltro filtro = new frmClienteFiltro();
            filtro.tipo2 = tipo2;
            filtro.tipo = tipo;
            filtro.tID = tID;
            filtro.tTitulo = tTitulo;
            filtro.TopMost = true;
            filtro.ShowDialog();

            tipo2 = filtro.tipo2;
            tipo = filtro.tipo;
            tID = filtro.tID;
            tTitulo = filtro.tTitulo;

            switch (filtro.tipo)
            {
                case "CPF":
                    this.txtPesquisar.Visible = false;
                    this.txtPesquisarMask.Visible = true;
                    this.txtPesquisarMask.Mask = "000000000-00";
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
                if (this.dgv.RowCount == 0) { MessageBox.Show("Nenhum Cliente cadastrado!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                Cliente.frmClienteCadastro f = new Cliente.frmClienteCadastro
                {
                    operacao = Convert.ToByte(BLL.Operacao.Inclusao), idFunc=this.idFunc,
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size
                };
                f.Size = new Size(f.Width + 180, f.Height + 220);

                f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;

                if ( sender == this.btnConsultar || sender == this.pbConsultar)
                {
                    f.lblTitulo.Text = "Consulta de";
                    f.codigo = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                    f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);
                    f.txtNome.Enabled = true;

                    // f.txtEndereco.Enabled = true;

                    // f.txtComplemento.Enabled = true;
                    f.txtCodigo.Enabled = true;
                    f.txtCodigo.Visible = true;
                    // f.txtCidade.Enabled = true;
                    // f.cbEstado.Enabled = true;
                    f.cbSexo.Enabled = true;
                    // f.nupIdade.Enabled = true;
                    f.chkAtivo.Enabled = true;
                    // f.txtBairro.Enabled = true;
                    //  f.nupNumeroCasa.Enabled = true;
                    f.txtCodigo.Visible = true;
                    f.btnSalvar.Visible = true; f.pbSalvar.Visible = true;
                    f.btnSalvar.Enabled = true; f.pbSalvar.Enabled = true;

                    f.btnSalvar.BackColor = Color.Lime;



                    if (sender == this.btnConsultar || sender == this.pbConsultar)
                    {
                        f.txtNome.Enabled = false;
                        f.txtEmail.Enabled = false;
                        f.btnValidarEmail.Enabled = false;
                        // f.txtEndereco.Enabled = false;

                        // f.txtComplemento.Enabled = false;
                        f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;
                        // f.txtCidade.Enabled = false;
                        // f.cbEstado.Enabled = false;
                        f.cbSexo.Enabled = false;
                        // f.nupIdade.Enabled = false;
                        f.chkAtivo.Enabled = false;
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
                    }
                }
                //var b = (Button)sender;
                //f.lblTitulo.Text =  b.Text;
                f.TopMost = true;
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



        /////////////////
    }
}
