using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Usuarios
{
    public partial class frmUsuarioGerenciar : Modelos.ModeloConsultaPadrao
    {
        public frmUsuarioGerenciar()
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
        public string tipo, tipo2, tTipoPessoa;

        private void Exibir(object sender, EventArgs e)
        {
        

            CarregarGrid();
            //if (sender == this.btnApresentar)
            //{
            //    this.txtPesquisar.Text = string.Empty;
            //}

            this.txtPesquisar.Focus();
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            foreach (DataGridViewRow linha in dgv.Rows)
            {
                if (linha.Cells[5].Value.ToString() == "0")
                {
                    linha.DefaultCellStyle.BackColor = Color.Red;
                    linha.DefaultCellStyle.ForeColor = Color.Red;
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
        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (this.cbTipo.Text == "Código")
            //{
            //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)

            //    {

            //        e.Handled = true;

            //    }
            //}
        }

        private void frmUsuarioGerenciar_KeyPress(object sender, KeyPressEventArgs k)
        {
            if (!char.IsDigit(k.KeyChar) && k.KeyChar != (char)8 && tipo == "L.ID_LOGIN")

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
        private void CarregarGrid()
        {
            try
            {

                BLL.Login obj = new BLL.Login(); // <<<<<<<<<<<<<<<<
                int ativo = 1;

                if (rbTodos.Checked) { ativo = 2; }
                else if (rbAtiva.Checked) { ativo = 1; }
                else if (rbDesativa.Checked) { ativo = 0; }

                switch (tipo2)
                {
                    case "Contratação":
                    case "P.DATA_CRIACAO":
                        tipo2 = "P.DATA_CRIACAO";
                        break;
                    case "Nascimento":
                    case "P.DATA_NASC":
                        tipo2 = "P.DATA_NASC";
                        break;
                    case null: case "":
                        break;
                }

                switch (tipo)
                {
                    case "Codigo":
                        tipo = "L.ID_LOGIN";
                        break;
                    case "Nome":
                    case null: case "":
                        tipo = "P.NOME";
                        break;
                    case "Usuario":
                        tipo = "L.USUARIO";
                        break;
                    case "Pergunta":
                        tipo = "PS.DESCRICAO";
                        break;
                }



                if (tipo2 != string.Empty && tipo2 != null)
                {
                    obj.DataListarInicio = Convert.ToDateTime(this.dtpHorarioInicio.Value.ToString().Substring(0, 10));
                    obj.DataListarFinal = Convert.ToDateTime(this.dtpHorarioFinal.Value.ToString().Substring(0, 10));
                   
                        this.dgv.DataSource = obj.ListarGeral(txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, tipo2, tTipoPessoa).Tables[0];

                    

                }
                else
                {
                   
                        this.dgv.DataSource = obj.ListarGeral(this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, "", tTipoPessoa).Tables[0];
                    

                }
                
                

                //this.dgv.AutoResizeColumns();//
                this.dgv.Columns[0].HeaderText = "Cód";
                this.dgv.AutoResizeColumn(0);
                this.dgv.Columns[1].HeaderText = "Nome Completo";
                this.dgv.AutoResizeColumn(1);
                this.dgv.Columns[2].HeaderText = "Tipo Pessoa";
                this.dgv.AutoResizeColumn(2);
                this.dgv.Columns[3].HeaderText = "Usuario";
                this.dgv.AutoResizeColumn(3);
                this.dgv.Columns[4].HeaderText = "Pergunta Secreta";
                this.dgv.AutoResizeColumn(4);
                this.dgv.Columns[5].HeaderText = "Ativo";
                this.dgv.AutoResizeColumn(5);
         


                this.txtPesquisar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }

        private void AbrirFormulario(object sender, EventArgs e)
        {//INCLUIR ALTERAR CONSULTAR

            switch (txtTipoPessoa.Text)
            {
                case"CLIENTE":
                    try
                    {
                        if (this.dgv.RowCount == 0) { MessageBox.Show("Nenhum usuário cadastrado!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        Cliente.frmClienteCadastro f = new Cliente.frmClienteCadastro
                        {
                            operacao = Convert.ToByte(BLL.Operacao.Inclusao), idFunc=this.idFunc,
                            FormBorderStyle = FormBorderStyle.FixedToolWindow,
                            Size = this.Size
                        };


                        f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;

                        if (sender == this.btnAlterarU || sender == this.pbAlterarU || sender == this.btnConsultarU || sender == this.pbConsultarU)
                        {
                            f.lblTitulo.Text = "Consulta de";
                            f.gbCodigo.Visible = true;
                            f.codigo = IdCliente;
                            f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);
                            f.txtNome.Enabled = true;

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



                            if (sender == this.btnConsultarU || sender == this.pbConsultarU)
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
                                f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible=false; f.btnLimpar.Visible=false;
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
                        if (sender == this.btnAlterar || sender == this.pbAlterar)
                        {
                            CarregarGrid();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, ex.Source);
                    }
                    break;
                case "FUNCIONARIO":
                    try
                    {
                        if (this.dgv.RowCount == 0) { MessageBox.Show("Nenhum Funcionário cadastrado!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        Funcionario.frmFuncionarioCadastro f = new Funcionario.frmFuncionarioCadastro
                        {
                            FormBorderStyle = FormBorderStyle.FixedToolWindow,
                            Size = this.Size,
                            FuncIdLogin = this.idFunc
                        };
                        f.MinimizeBox = true;
                        f.Size = new Size(f.Width, f.Height + 15);
                        f.StartPosition = FormStartPosition.CenterScreen;
                        f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;

                        if (sender == this.btnAlterarU || sender == this.pbAlterarU || sender == this.btnConsultarU || sender == this.pbConsultarU)
                        {
                            f.lblTitulo.Text = "Consulta de";
                            f.gbCodigo.Visible = true;
                            f.codigo = IdFunc;
                            //f.Ativo = Convert.ToInt32(this.dgv.CurrentRow.Cells[4].Value);
                            f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);
                            f.txtTelefone.Enabled = true;

                            f.txtCPF.Enabled = true;

                            f.txtCodigo.Enabled = true;
                            f.txtCep.Enabled = true;

                            f.btnProcurarCEP.Enabled = true;

                            f.cbSexo.Enabled = true;

                            f.chkAtivo.Enabled = true;

                            f.btnSalvar.Visible = true; f.pbSalvar.Visible = true;
                            f.btnSalvar.Enabled = true; f.pbSalvar.Enabled = true;
                            f.btnSalvar.BackColor = Color.Lime;
                            f.btnValidarCPF.Image = Properties.Resources.ValidarIcone1;
                            f.btnValidarCPF.Enabled = true;


                            if (sender == this.btnConsultarU || sender == this.pbConsultarU)
                            {
                                f.txtCPF.Enabled = false;
                                f.txtNomeFunc.Enabled = false;
                                f.dtpDataNasc.Enabled = false;
                                f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;
                                f.cbSexo.Enabled = false;
                                f.chkAtivo.Enabled = false;
                                f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible=false; f.btnLimpar.Visible=false;
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
                        }
                        //var b = (Button)sender;
                        //f.lblTitulo.Text =  b.Text;
                        f.btnCancelar.Visible = true;
                        f.pbCancelar.Visible = true;
                        f.TopMost = true;
                        f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                        f.idFunc = this.idFunc; f.ShowDialog();
                        if (sender == this.btnAlterar || sender == this.pbAlterar)
                        {
                            CarregarGrid();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, ex.Source);
                    }
                    break;
               
            }
           
        }

        public int IdPerguntaSecreta, IdPessoa, IdCliente, IdFunc;

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkAtivo.Checked)
            {
                this.btnAlterarU.Visible = true;
                this.pbAlterarU.Visible = true;
            }
            else
            {
                this.btnAlterarU.Visible = false;
                this.pbAlterarU.Visible = false;
            }
        }

        private void CarregarCampos(object sender, EventArgs e)
        {
            try
            {
                if (this.dgv.Rows.Count>0)
                {
                    BLL.Login medi = new BLL.Login();
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    codigo = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                    medi.IdLogin = codigo;
                    if (this.dgv.CurrentRow.Cells[2].Value.ToString()=="FUNCIONARIO")
                    {
                        dr = medi.ConsultarFunc();
                        if (dr.Read())//FUNCIONARIO
                        {

                            this.txtCodigoUser.Text = Convert.ToString(codigo);
                            this.txtCodigoUser.Enabled = false;


                            if (dr["ATIVO"].ToString() == "1")
                            {
                                this.chkAtivo.Checked = true;
                            }
                            else
                            {
                                this.chkAtivo.Checked = false;
                            }
                            this.txtPergunta.Text = dr["DESCRICAO"].ToString();
                            this.txtUsuario.Text = dr["USUARIO"].ToString();
                            this.txtSenha.Text = dr["SENHA"].ToString();
                            this.txtNome.Text = dr["NOME"].ToString();
                            this.txtResposta.Text = dr["RESPOSTA"].ToString();
                            this.txtTipoPessoa.Text = dr["TIPO_PESSOA"].ToString();

                            IdPerguntaSecreta = Convert.ToInt32(dr["ID_PERGUNTASECRETA"]);
                            IdPessoa = Convert.ToInt32(dr["ID_PESSOA"]);
                            IdFunc = Convert.ToInt32(dr["ID_FUNC"]);

                        }

                    }
                    else
                    {
                        dr = medi.ConsultarCli();
                        if (dr.Read())//CLIENTE
                        {

                            this.txtCodigoUser.Text = Convert.ToString(codigo);
                            this.txtCodigoUser.Enabled = false;


                            if (dr["ATIVO"].ToString() == "1")
                            {
                                this.chkAtivo.Checked = true;
                            }
                            else
                            {
                                this.chkAtivo.Checked = false;
                            }
                            this.txtPergunta.Text = dr["DESCRICAO"].ToString();
                            this.txtUsuario.Text = dr["USUARIO"].ToString();
                            this.txtSenha.Text = dr["SENHA"].ToString();
                            this.txtNome.Text = dr["NOME"].ToString();
                            this.txtResposta.Text = dr["RESPOSTA"].ToString();
                            this.txtTipoPessoa.Text = dr["TIPO_PESSOA"].ToString();

                            IdPerguntaSecreta = Convert.ToInt32(dr["ID_PERGUNTASECRETA"]);
                            IdPessoa = Convert.ToInt32(dr["ID_PESSOA"]);
                            IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                        }
                    }
                    

                   

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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

            Negocios.Filtros.frmUsuarioFiltro filtro = new Negocios.Filtros.frmUsuarioFiltro();
            filtro.tipo2 = tipo2;
            filtro.tipo = tipo;
            filtro.tTipoPessoa = tTipoPessoa;
            filtro.TopMost = true;
            filtro.ShowDialog();

            tipo2 = filtro.tipo2;
            tipo = filtro.tipo;
            tTipoPessoa = filtro.tTipoPessoa;

            switch (filtro.tipo)
            {

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

        /////////////////////////
    }
}
