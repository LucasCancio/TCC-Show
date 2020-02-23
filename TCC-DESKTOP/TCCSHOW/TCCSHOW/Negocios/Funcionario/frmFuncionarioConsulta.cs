using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Funcionario
{
    public partial class frmFuncionarioConsulta : Modelos.ModeloConsultaPadrao
    {
        public frmFuncionarioConsulta()
        {
            InitializeComponent();
            this.cbNome.SelectedIndex = 0;
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

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgv.SelectedRows.Count > 1)
            {
                this.btnAlterar.Enabled = false; this.pbAlterar.Enabled = false;
                this.btnConsultar.Enabled = false; this.pbConsultar.Enabled = false;
            }
            else
            {
                if (this.dgv.CurrentRow == null)
                {
                    return;
                }
                if (Convert.ToString(this.dgv.CurrentRow.Cells["Ativo"].Value) == "0")
                {
                    this.btnAlterar.Visible = false;
                    this.pbAlterar.Visible = false;
                }
                else
                {
                    this.btnAlterar.Visible = true;
                    this.pbAlterar.Visible = true;
                }
                this.btnAlterar.Enabled = true; this.pbAlterar.Enabled = true;
                this.btnConsultar.Enabled = true; this.pbConsultar.Enabled = true;
            }


        }

        private void CarregarGrid()
        {
            try
            {
                BLL.Funcionario obj = new BLL.Funcionario(); // <<<<<<<<<<<<<<<<
                int ativo = 0;


                if (rbTodos.Checked) { ativo = 2; }
                else if (rbAtiva.Checked) { ativo = 1; }
                else if (rbDesativa.Checked) { ativo = 0; }

               
                switch (tipo2)
                {
                    case "Contratação":
                        tipo2 = "P.DATA_CRIACAO";
                        break;
                    case "Nascimento":
                        tipo2 = "P.DATA_NASC";
                        break;
                    case null: case "":
                        tipo2 = string.Empty;
                        break;
                }

                switch (tipo)
                {
                    case "Codigo":
                    case "F.ID_FUNC":
                        tipo = "F.ID_FUNC";
                        break;
                    case "P.NOME":
                    case "Nome":
                    case null: case "":
                        tipo = "P.NOME";                      
                        break;
                    case "CPF":
                    case "F.CPF":
                        tipo = "F.CPF";
                        break;
                    case "Usuario":
                    case "LG.USUARIO":
                        tipo = "LG.USUARIO";
                        break;
                    case "Telefone":
                    case "F.TELEFONE":
                        tipo = "F.TELEFONE";
                        break;
                }

                if (tipo2 != string.Empty && tipo2 != null)
                {
                    obj.DataListarInicio = Convert.ToDateTime(this.dtpHorarioInicio.Value.ToString().Substring(0, 10));
                    obj.DataListarFinal = Convert.ToDateTime(this.dtpHorarioFinal.Value.ToString().Substring(0, 10));
                    if (tipo=="F.CPF" || tipo=="F.TELEFONE")
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
                        this.dgv.DataSource = obj.ListarGeral(this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo,"",tFuncao).Tables[0];
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
                frmFuncionarioCadastro f = new frmFuncionarioCadastro
                {
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size,
                    FuncIdLogin = this.idFunc
                };
                f.MinimizeBox = true;
                f.Size = new Size(f.Width , f.Height+15);
                f.StartPosition = FormStartPosition.CenterScreen;
                f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;

                if (sender == this.btnAlterar || sender == this.pbAlterar || sender == this.btnConsultar || sender == this.pbConsultar)
                {
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
        }

        private void FixarStatus(Object o, EventArgs e)
        {
            try
            {
                if (this.dgv.RowCount == 0)
                {
                    return;
                }
                string nome = string.Empty;
                int i = 1;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Selected)
                    {

                        if (nome == string.Empty)
                        {
                            if (dgv.SelectedRows.Count == 1)
                            {
                                nome = row.Cells[1].Value.ToString();
                            }
                            else
                            {
                                nome = row.Cells[1].Value.ToString() + " ,";
                            }

                        }
                        else if (i != dgv.SelectedRows.Count)
                        {
                            nome = nome + row.Cells[1].Value.ToString() + " , ";
                        }
                        else
                        {
                            nome = nome + row.Cells[1].Value.ToString();
                        }
                        ++i;
                    }


                }
                var b = (Button)o;
                if (MessageBox.Show("Deseja " + b.Text.ToLower() + " " + nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;
                BLL.Funcionario obj = new BLL.Funcionario(); //<<<<<<<<<<<<<
                BLL.CEP c = new BLL.CEP();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Selected)
                    {
                        obj.IdFuncionario = Convert.ToInt32(row.Cells[0].Value); //<<<<<<<<
                        c.ID_ENDERECO = Convert.ToInt32(row.Cells[11].Value);
                        BLL.Login log = new BLL.Login();
                        BLL.Log LOG = new BLL.Log();
                        log.IdFunc = Convert.ToInt32(row.Cells[0].Value);

                        switch (b.Text)
                        {
                            case "Excluir":
                                obj.Funcionario_crud('D');

                                
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "FUNCIONÁRIOS";
                                LOG.TIPO_LOG = "EXCLUSÃO"; LOG.DESCRICAO= row.Cells[1].Value.ToString();
                                LOG.Log_crud('D');
                                break;
                            case "Desativar":
                                if (Convert.ToInt32(row.Cells[4].Value) != 0)
                                {
                                    obj.Ativar(0);
                                }
                                else
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("O Funcionário " + row.Cells[0].Value.ToString() + " já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Funcionário já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "FUNCIONÁRIOS";
                                LOG.TIPO_LOG = "ALTERAÇÃO";
                                LOG.Log_crud('A');
                                break;
                            case "Reativar":
                                if (Convert.ToInt32(row.Cells[4].Value) != 1)
                                {
                                    obj.Ativar(1);

                                }
                                else
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("O Funcionário " + row.Cells[0].Value.ToString() + " já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Funcionário já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "FUNCIONÁRIOS";
                                LOG.TIPO_LOG = "ALTERAÇÃO";
                                LOG.Log_crud('A');
                                break;
                        }
                    }
                }
                     
                MessageBox.Show("Procedimento " + b.Text + " realizado com sucesso!");
                CarregarGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FixarStatusPB(Object o, EventArgs e)
        {
            try
            {
                if (this.dgv.RowCount == 0)
                {
                    return;
                }
                string nome = string.Empty;
                int i = 1;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Selected)
                    {

                        if (nome == string.Empty)
                        {
                            if (dgv.SelectedRows.Count == 1)
                            {
                                nome = row.Cells[1].Value.ToString();
                            }
                            else
                            {
                                nome = row.Cells[1].Value.ToString() + " ,";
                            }

                        }
                        else if (i != dgv.SelectedRows.Count)
                        {
                            nome = nome + row.Cells[1].Value.ToString() + " , ";
                        }
                        else
                        {
                            nome = nome + row.Cells[1].Value.ToString();
                        }
                        ++i;
                    }


                }
                if (this.dgv.RowCount == 0) { MessageBox.Show("Nenhum Funcionario cadastrado!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                var b = (PictureBox)o;
                if (MessageBox.Show("Deseja " + b.Name.Replace("pb", "").Trim().ToLower() + " " + nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;
                BLL.Funcionario obj = new BLL.Funcionario(); //<<<<<<<<<<<<<
                BLL.CEP c = new BLL.CEP();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Selected)
                    {
                        obj.IdFuncionario = Convert.ToInt32(row.Cells[0].Value); //<<<<<<<<
                        c.ID_ENDERECO = Convert.ToInt32(row.Cells[11].Value);
                        BLL.Login log = new BLL.Login();
                        BLL.Log LOG = new BLL.Log();
                        log.IdFunc = Convert.ToInt32(row.Cells[0].Value);

                        switch (b.Name.Replace("pb",""))
                        {
                            case "Excluir":
                                obj.Funcionario_crud('D');

                                
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "FUNCIONÁRIOS";
                                LOG.TIPO_LOG = "EXCLUSÃO"; LOG.DESCRICAO= row.Cells[1].Value.ToString();
                                LOG.Log_crud('D');
                                break;
                            case "Desativar":
                                if (Convert.ToInt32(row.Cells[4].Value) != 0)
                                {
                                    obj.Ativar(0);
                                }
                                else
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("O Funcionário " + row.Cells[0].Value.ToString() + " já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Funcionário já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "FUNCIONÁRIOS";
                                LOG.TIPO_LOG = "ALTERAÇÃO";
                                LOG.Log_crud('A');
                                break;
                            case "Reativar":
                                if (Convert.ToInt32(row.Cells[4].Value) != 1)
                                {
                                    obj.Ativar(1);

                                }
                                else
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("O Funcionário " + row.Cells[0].Value.ToString() + " já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Funcionário já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "FUNCIONÁRIOS";
                                LOG.TIPO_LOG = "ALTERAÇÃO";
                                LOG.Log_crud('A');
                                break;
                        }
                    }
                }
                MessageBox.Show("Procedimento " + b.Text + " realizado com sucesso!");
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
