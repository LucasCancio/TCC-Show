using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Cliente
{
    public partial class frmClienteConsulta : Modelos.ModeloConsultaPadrao
    {
        public frmClienteConsulta()
        {
            InitializeComponent();
            WPTotal = this.txtPesquisar.Width;
            WPData = txtPesquisar.Width - this.dtpHorarioInicio.Width - 10;
            tipo = "Nome";
        }
        double WPTotal, WPData;
        public string tipo,tipo2, tTitulo;
        public int tID;
        private void Exibir(object sender, EventArgs e)
        {
            if (NivelAcesso == 2 && this.btnExcluir.Visible != true)
            {
                this.btnExcluir.Visible = false;
                this.pbExcluir.Visible = false;
            }
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

        private void CarregarGrid()
        {
            try
            {
                BLL.Cliente obj = new BLL.Cliente(); // <<<<<<<<<<<<<<<<
                int ativo = 0;


                if (rbTodos.Checked) { ativo = 2; }
                else if (rbAtiva.Checked) { ativo = 1; }
                else if (rbDesativa.Checked) { ativo = 0; }

                switch (tipo2)
                {
                    case "Nascimento":
                        tipo2 = "P.DATA_NASC";
                        break;
                    case null: case "":
                        break;
                }


                switch (tipo)
                {
                    case "Codigo":
                       tipo= "CLI.ID_CLIENTE";
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
                if (tipo.IndexOf("CPF")>0)
                {
                    if (tipo2!=string.Empty || tipo2!=null)
                    {
                        
                        obj.DataListarInicio = Convert.ToDateTime(this.dtpHorarioInicio.Value.ToString().Substring(0, 10));
                        obj.DataListarFinal = Convert.ToDateTime(this.dtpHorarioFinal.Value.ToString().Substring(0, 10));
                        if (this.txtPesquisarMask.MaskFull)
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
                        if (this.txtPesquisarMask.MaskFull)
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


        private void AbrirFormulario(object sender, EventArgs e)
        {//INCLUIR ALTERAR CONSULTAR
            try
            {
                if (this.dgv.RowCount == 0) { MessageBox.Show("Nenhum Cliente cadastrado!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                frmClienteCadastro f = new frmClienteCadastro
                {
                    operacao = Convert.ToByte(BLL.Operacao.Inclusao), idFunc=this.idFunc,
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size
                };


                f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;

                if (sender == this.btnAlterar || sender == this.pbAlterar || sender == this.btnConsultar || sender == this.pbConsultar)
                {
                    f.lblTitulo.Text = "Consulta de";
                    f.codigo = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
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
                        f.txtUsuario.Enabled = false;
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
                if (MessageBox.Show("Deseja " + b.Text.ToLower() + " " + nome + "?", "Código " + this.dgv.CurrentRow.Cells[0].Value.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;
                BLL.Cliente obj = new BLL.Cliente();
                BLL.Log LOG = new BLL.Log();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Selected)
                    {
                        obj.ID_CLIENTE = Convert.ToInt32(row.Cells[0].Value); //<<<<<<<<
                        BLL.Login log = new BLL.Login();
                        log.IdCli = Convert.ToInt32(row.Cells[0].Value);
                        switch (b.Text)
                        {
                            case "Excluir":
                                obj.Cliente_crud('D');

                                
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "CLIENTES";
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
                                        MessageBox.Show("O Cliente " + row.Cells[0].Value.ToString() + " já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Cliente já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "CLIENTES";
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
                                        MessageBox.Show("O Cliente " + row.Cells[0].Value.ToString() + " já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Cliente já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "CLIENTES";
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

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgv.SelectedRows.Count > 1)
            {
                this.btnAlterar.Enabled = false; this.pbAlterar.Enabled = false;
                this.btnConsultar.Enabled = false; this.pbConsultar.Enabled = false;
            }
            if (this.dgv.CurrentRow==null)
            {
                return;
            }
            else
            {
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
                var b = (PictureBox)o;
                if (MessageBox.Show("Deseja " + b.Name.Replace("pb", "").ToLower() + " " + nome + "?", "Código " + this.dgv.CurrentRow.Cells[0].Value.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;
                BLL.Cliente obj = new BLL.Cliente();
                BLL.Log LOG = new BLL.Log();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Selected)
                    {
                        obj.ID_CLIENTE = Convert.ToInt32(row.Cells[0].Value); //<<<<<<<<
                        BLL.Login log = new BLL.Login();
                        log.IdCli = Convert.ToInt32(row.Cells[0].Value);
                        switch (b.Name.Replace("pb",""))
                        {
                            case "Excluir":
                                obj.Cliente_crud('D');

                               
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "CLIENTES";
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
                                        MessageBox.Show("O Cliente " + row.Cells[0].Value.ToString() + " já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Cliente já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "CLIENTES";
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
                                        MessageBox.Show("O Cliente " + row.Cells[0].Value.ToString() + " já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Cliente já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "CLIENTES";
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

            Negocios.Filtros.frmClienteFiltro filtro = new Negocios.Filtros.frmClienteFiltro();
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


        /////////////////////
    }
}
