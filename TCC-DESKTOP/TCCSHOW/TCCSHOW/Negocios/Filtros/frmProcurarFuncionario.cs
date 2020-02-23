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
    public partial class frmProcurarFuncionario : Modelos.ModeloGeral
    {
        public frmProcurarFuncionario()
        {
            InitializeComponent();

            this.dgv.DefaultCellStyle.BackColor = Color.LightGray;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor =
  Color.Silver;
            WPTotal = this.txtPesquisar.Width;
            WPData = txtPesquisar.Width - this.dtpHorarioInicio.Width - 10;
            tipo = "Nome";
        }
        double WPTotal, WPData;
        public string tipo, tipo2, tFuncao;

        private void Exibir(object sender, EventArgs e)
        {



            if (chkDataEsp.Checked == true)
            {

            }
            CarregarGrid();

            this.txtPesquisar.Focus();
        }

        private string _FormNome;
        public string FormNome { get => _FormNome; set => _FormNome = value; }

        private int _FormId;
        public int FormId { get => _FormId; set => _FormId = value; }


        private void CarregarGrid()
        {
            try
            {
                BLL.Funcionario obj = new BLL.Funcionario(); // <<<<<<<<<<<<<<<<
                int ativo = 0;


                ativo = 2;


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
                if (operacao==5)
                {
                    if (this.tFuncao==string.Empty || tFuncao==null)
                    {
                        tFuncao = "Gerente' OR FUNC.FUNCAO='Atendente";
                    }
                }
                switch (tipo)
                {
                    case "Codigo":
                        tipo = "F.ID_FUNC";
                        break;
                    case "Nome":
                    case null: case "":
                        tipo = "P.NOME";
                        break;
                    case "CPF":
                        tipo = "F.CPF";
                        break;
                    case "Usuario":
                        tipo = "LG.USUARIO";
                        break;
                    case "Telefone":
                        tipo = "F.TELEFONE";
                        break;
                }

                if (tipo2 != string.Empty && tipo2 != null)
                {
                    obj.DataListarInicio = Convert.ToDateTime(this.dtpHorarioInicio.Value.ToString().Substring(0, 10));
                    obj.DataListarFinal = Convert.ToDateTime(this.dtpHorarioFinal.Value.ToString().Substring(0, 10));
                    if (tipo == "F.CPF" || tipo == "F.TELEFONE")
                    {
                        if (this.txtPesquisarMask.MaskFull)
                        {
                            this.dgv.DataSource = obj.ListarGeral(txtPesquisarMask.Text.Trim().Replace(" ", "").ToUpper(), ativo, tipo, tipo2, tFuncao).Tables[0];
                        }
                        else
                        {
                            this.dgv.DataSource = obj.ListarGeral(txtPesquisarMask.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Replace(".", "").Replace("(", "").Replace(")", "").ToUpper(), ativo, tipo, tipo2, tFuncao).Tables[0];
                        }
                       
                    }
                    else
                    {

                        this.dgv.DataSource = obj.ListarGeral(txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, tipo2, tFuncao).Tables[0];

                    }

                }
                else
                {
                    if (tipo == "F.CPF" || tipo == "F.TELEFONE")
                    {
                        if (this.txtPesquisarMask.MaskFull)
                        {
                            this.dgv.DataSource = obj.ListarGeral(txtPesquisarMask.Text.Trim().Replace(" ", "").ToUpper(), ativo, tipo, "", tFuncao).Tables[0];
                        }
                        else
                        {
                            this.dgv.DataSource = obj.ListarGeral(txtPesquisarMask.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Replace(".", "").Replace("(", "").Replace(")", "").ToUpper(), ativo, tipo, "", tFuncao).Tables[0];
                        }
                           
                    }
                    else
                    {
                        this.dgv.DataSource = obj.ListarGeral(this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, "", tFuncao).Tables[0];
                    }

                }







                this.dgv.Columns[0].HeaderText = "Cód Funcionário";
                this.dgv.AutoResizeColumn(0);
                this.dgv.Columns[1].HeaderText = "Nome";
                this.dgv.AutoResizeColumn(1);
                this.dgv.Columns[2].HeaderText = "Sexo";
                this.dgv.AutoResizeColumn(2);
                this.dgv.Columns[3].HeaderText = "Data de Nascimento";
                this.dgv.AutoResizeColumn(3);
                this.dgv.Columns[4].HeaderText = "Ativo";
                this.dgv.AutoResizeColumn(4);
                this.dgv.Columns[5].HeaderText = "Função";
                this.dgv.AutoResizeColumn(5);
                this.dgv.Columns[6].HeaderText = "Telefone";
                this.dgv.AutoResizeColumn(6);
                this.dgv.Columns[7].HeaderText = "CPF";
                this.dgv.AutoResizeColumn(7);
                this.dgv.Columns[8].HeaderText = "Email";
                this.dgv.AutoResizeColumn(8);
                this.dgv.Columns[9].HeaderText = "Data de Contratação";
                this.dgv.AutoResizeColumn(9);
                this.dgv.Columns[10].HeaderText = "CEP";
                this.dgv.AutoResizeColumn(10);
                this.dgv.Columns[11].HeaderText = "Cód Endereço";
                this.dgv.AutoResizeColumn(11);




                this.txtPesquisar.Focus();
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

        private void frmFuncionarioConsulta_KeyPress(object sender, KeyPressEventArgs k)
        {
            if (!char.IsDigit(k.KeyChar) && k.KeyChar != (char)8 && tipo == "F.ID_FUNC")

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

        private void AbrirFormulario(object sender, EventArgs e)
        {//INCLUIR ALTERAR CONSULTAR
            try
            {
                if (this.dgv.RowCount == 0) { MessageBox.Show("Nenhum Funcionário cadastrado!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                Negocios.Funcionario.frmFuncionarioCadastro f = new Negocios.Funcionario.frmFuncionarioCadastro
                {
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size,
                    idFunc = this.idFunc
                };
                f.MinimizeBox = true;
                f.Size = new Size(f.Width + 15, f.Height + 25);
                f.StartPosition = FormStartPosition.CenterScreen;
                f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;

                f.lblTitulo.Text = "Consulta de";
                f.gbCodigo.Visible = true;
                    f.codigo = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                    //f.Ativo = Convert.ToInt32(this.dgv.CurrentRow.Cells[4].Value);
                    f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);
                    f.txtTelefone.Enabled = true;

                    f.txtCPF.Enabled = true;

                    f.txtCodigo.Enabled = true;
                    f.txtCep.Enabled = true;

                    f.btnProcurarCEP.Enabled = true;

                    f.cbSexo.Enabled = true;

                    f.chkAtivo.Enabled = true;
                    f.txtUsuario.Enabled = false;
                    f.txtSenha.Enabled = false;
                    f.btnSalvar.Visible = true; f.pbSalvar.Visible = true;
                    f.btnSalvar.Enabled = true; f.pbSalvar.Enabled = true;
                    f.btnSalvar.BackColor = Color.Lime;
                    f.btnValidarCPF.Image = Properties.Resources.ValidarIcone1;
                    f.btnValidarCPF.Enabled = true;


                    if (sender == this.btnConsultar || sender == this.pbConsultar)
                    {
                        f.txtCPF.Enabled = false;
                        f.txtNomeFunc.Enabled = false;
                        f.dtpDataNasc.Enabled = false;
                        f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;
                        f.cbSexo.Enabled = false;
                        f.chkAtivo.Enabled = false;
                        f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible = false; f.btnLimpar.Visible = false;
                        f.btnProcurarCEP.Enabled = false;
                        foreach (Control item in f.gbCep.Controls)
                        {
                            if (item is TextBox || item is MaskedTextBox || item is NumericUpDown)
                            {
                                item.Enabled = false;
                            }
                        }
                        foreach (Control item in f.gbLogin.Controls)
                        {
                            if (item is TextBox || item is MaskedTextBox || item is NumericUpDown)
                            {
                                item.Enabled = false;
                            }
                        }
                        f.btnValidarEmail.Enabled = false;
                        foreach (Control item in f.gbContato.Controls)
                        {
                            if (item is TextBox || item is MaskedTextBox || item is CheckBox)
                            {
                                item.Enabled = false;
                            }
                        }
                        f.cbFuncao.Enabled = false;

                        f.operacao = Convert.ToByte(BLL.Operacao.Consulta);

                    }
                
                //var b = (Button)sender;
                //f.lblTitulo.Text =  b.Text;
                f.btnCancelar.Visible = true;
                f.pbCancelar.Visible = true;
                f.TopMost = true;
                f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                f.idFunc = this.idFunc; f.ShowDialog();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }

       
        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (this.rbCodigo.Checked == true)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)

                {

                    e.Handled = true;

                }
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _FormNome = this.dgv.CurrentRow.Cells[1].Value.ToString();
            _FormId = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);


            this.Dispose();
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow linha in dgv.Rows)
            {
                if (linha.Cells["Ativo"].Value.ToString() == "0")
                {
                    linha.DefaultCellStyle.BackColor = Color.Red;
                    linha.DefaultCellStyle.SelectionForeColor = Color.Red;
                }
                else
                {
                    linha.DefaultCellStyle.BackColor = Color.LightGray;
                    dgv.AlternatingRowsDefaultCellStyle.BackColor =
          Color.Silver;
                    linha.DefaultCellStyle.ForeColor = Color.Black;
                }

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

            Negocios.Filtros.frmFuncionarioFiltro filtro = new Negocios.Filtros.frmFuncionarioFiltro();
            filtro.tipo2 = tipo2;
            filtro.tipo = tipo;
            filtro.tFuncao = tFuncao;
            filtro.TopMost = true;
            filtro.ShowDialog();

            tipo2 = filtro.tipo2;
            tipo = filtro.tipo;
            tFuncao = filtro.tFuncao;

            switch (filtro.tipo)
            {
                case "CPF":
                    this.txtPesquisar.Visible = false;
                    this.txtPesquisarMask.Visible = true;
                    this.txtPesquisarMask.Mask = "000000000-00";
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



        //////////////////////
    }
}
