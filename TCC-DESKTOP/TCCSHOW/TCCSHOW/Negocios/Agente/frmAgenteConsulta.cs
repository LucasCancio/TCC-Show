using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Agente
{
    public partial class frmAgenteConsulta : Modelos.ModeloConsultaPadrao
    {
        public frmAgenteConsulta()
        {
            InitializeComponent();
            this.dgv.DefaultCellStyle.BackColor = Color.LightGray;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor =
  Color.Silver;
            tipo = "Nome";
            WPTotal = this.txtPesquisar.Width;
            WPData=  txtPesquisar.Width - this.dtpHorarioInicio.Width - 10;
        }

        double WPTotal, WPData;
        string tTemp;
        public string tipo3 = "Ambos", tCod;
        private void Exibir(object sender, EventArgs e)
        {
            if (NivelAcesso == 2 && this.btnExcluir.Visible != true)
            {
                this.btnExcluir.Visible = false;
                this.pbExcluir.Visible = false;
            }


            //if (chkDataEsp.Checked == true)
            //{

            //}
            CarregarGrid();

            this.txtPesquisar.Focus();
        }
        private void CarregarGrid()
        {
            try
            {
                BLL.Empresario obj = new BLL.Empresario();
                
               
                int ativo = 0;
                switch (tipo2)
                {
                    case "Contratação":
                        tipo2 = "TB_AGENTE.DATA_CRIACAO";
                        break;
                    case null: case "":
                        break;
                }
    


                if (this.rbTodos.Checked)
                {
                    ativo = 2;
                }
                else if (this.rbAtiva.Checked)
                {
                    ativo = 1;
                }
                else
                {
                    ativo = 0;
                }
               
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
                        if (tipo2!=string.Empty && tipo2!=null)
                        {
                            obj.DataListarInicio = Convert.ToDateTime(this.dtpHorarioInicio.Value.ToString().Substring(0, 10));
                            obj.DataListarFinal = Convert.ToDateTime(this.dtpHorarioFinal.Value.ToString().Substring(0, 10));
                            this.dgv.DataSource = obj.ListarGeral(tipo3,txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, tipo2).Tables[0];
                        }
                        else
                        {
                            this.dgv.DataSource = obj.ListarGeral(tipo3,this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, "").Tables[0];
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
                            obj.DataListarInicio =Convert.ToDateTime( this.dtpHorarioInicio.Value.ToString().Substring(0,10));
                            obj.DataListarFinal =Convert.ToDateTime( this.dtpHorarioFinal.Value.ToString().Substring(0,10));
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
                            if (tipo.IndexOf("DOCUMENTO")>=0)
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
                frmAgenteCadastro f = new frmAgenteCadastro
                {
                    operacao = Convert.ToByte(BLL.Operacao.Inclusao), idFunc=this.idFunc,
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size
            };

                f.Size = new Size(f.Width , f.Height + 15);

                f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;
                //this.Hide();

                if (sender == this.btnAlterar || sender == this.pbAlterar || sender == this.btnConsultar || sender == this.pbConsultar)
                {
                    f.lblTitulo.Text = "Consulta de";
                    f.codigo = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                    f.gbCodigo.Visible = true;
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
                    //f.btnSalvar.Visible = true; f.pbSalvar.Visible = true;
                    //f.btnSalvar.Enabled = true; f.pbSalvar.Enabled = true;
                    f.btnSalvar.BackColor = Color.Lime;

                    f.btnValidarCPF.Enabled = true;


                    if (sender == this.btnConsultar || sender == this.pbConsultar)
                    {

                        f.txtTelefone.Enabled = false;
                        // f.txtEndereco.Enabled = false;
                        f.txtCPF.Enabled = false;
                        // f.txtComplemento.Enabled = false;
                        f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;
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
                       

                        f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible=false; f.btnLimpar.Visible=false;

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
                            if (dgv.SelectedRows.Count==1)
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
                BLL.Empresario obj = new BLL.Empresario(); //<<<<<<<<<<<<<
                BLL.Log LOG = new BLL.Log();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Selected)
                    {
                        obj.ID_Agente = Convert.ToInt32(row.Cells[0].Value); //<<<<<<<<
                        switch (b.Name.Replace("btn", ""))
                        {
                            case "Excluir":
                                Oracle.DataAccess.Client.OracleDataReader dr;
                                dr = obj.VerificarArtista();
                                if (dr.Read())
                                {
                                    MessageBox.Show("Existe artista(s) vinculado á/ao " + row.Cells[1].Value.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                obj.Agente_crud('D');

                                
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "EMPRESÁRIOS";
                                LOG.TIPO_LOG = "EXCLUSÃO"; LOG.DESCRICAO= row.Cells[1].Value.ToString();
                                LOG.Log_crud('D');
                                break;
                            case "Desativar":

                                if (Convert.ToInt32(row.Cells[7].Value) != 0)
                                {
                                    obj.Ativar(0);
                                }
                                else
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("O Empresário "+row.Cells[0].Value.ToString()+" já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Empresário já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    
                                    
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "EMPRESÁRIOS";
                                LOG.TIPO_LOG = "ALTERAÇÃO";
                                LOG.Log_crud('A');
                                break;
                            case "Reativar":
                                if (Convert.ToInt32(row.Cells[7].Value) != 1)
                                {
                                    obj.Ativar(1);
                                }
                                else
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("O Empresário " + row.Cells[0].Value.ToString() + " já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Empresário já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "EMPRESÁRIOS";
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
                var b = (PictureBox)o;
                if (MessageBox.Show("Deseja " + b.Name.Replace("pb", "").ToLower() + " " + nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;
                BLL.Empresario obj = new BLL.Empresario();
                BLL.Log LOG = new BLL.Log();//<<<<<<<<<<<<<
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Selected)
                    {
                        obj.ID_Agente = Convert.ToInt32(row.Cells[0].Value); //<<<<<<<<
                        switch (b.Name.Replace("pb", ""))
                        {
                            case "Excluir":
                                Oracle.DataAccess.Client.OracleDataReader dr;
                                dr = obj.VerificarArtista();
                                if (dr.Read())
                                {
                                    MessageBox.Show("Existe artista(s) vinculado á/ao " + row.Cells[1].Value.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                obj.Agente_crud('D');
                                
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "EMPRESÁRIOS";
                                LOG.TIPO_LOG = "EXCLUSÃO"; LOG.DESCRICAO= row.Cells[1].Value.ToString();
                                LOG.Log_crud('D');
                                break;
                            case "Desativar":

                                if (Convert.ToInt32(row.Cells[7].Value) != 0)
                                {
                                    obj.Ativar(0);
                                }
                                else
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("O Empresário " + row.Cells[0].Value.ToString() + " já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Empresário já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "EMPRESÁRIOS";
                                LOG.TIPO_LOG = "ALTERAÇÃO";
                                LOG.Log_crud('A');
                                break;
                            case "Reativar":
                                if (Convert.ToInt32(row.Cells[7].Value) != 1)
                                {
                                    obj.Ativar(1);
                                }
                                else
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("O Empresário " + row.Cells[0].Value.ToString() + " já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Empresário já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "EMPRESÁRIOS";
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
            else
            {
                if (Convert.ToString(this.dgv.CurrentRow.Cells[7].Value)=="0")
                {
                    this.btnAlterar.Visible = false;
                    this.pbAlterar.Visible = false;
                }
                else
                {
                    this.btnAlterar.Visible = true;
                    this.pbAlterar.Visible = true ;
                }
                this.btnAlterar.Enabled = true; this.pbAlterar.Enabled = true;
                this.btnConsultar.Enabled = true; this.pbConsultar.Enabled = true;
            }

            
        }
        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            foreach (DataGridViewRow linha in dgv.Rows)
            {
                if (linha.Cells[7].Value.ToString() == "0")
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

        private void AbrirFiltro(object sender, EventArgs e) {
            Filtro();
        }
        private void Filtro()
        {
            if (this.dtpHorarioFinal.Visible==true || txtPesquisarMask.Visible==true)
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

            tipo2 = filtro.tipo2;
            tipo = filtro.tipo;
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
            if (filtro.tipo2!=string.Empty && filtro.tipo2!=null)
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

        private void frmAgenteConsulta_KeyPress(object sender, KeyPressEventArgs k)
        {
            if (!char.IsDigit(k.KeyChar) && k.KeyChar != (char)8 && tipo == "TB_AGENTE.ID_AGENTE")

            {

                k.Handled = true;

            }
            if (k.KeyChar == (char)13 )
            {
                CarregarGrid();
            }
            else if(k.KeyChar== (char)6)
            {
                Filtro();
            }
            
        }


        ////////////////
    }
}
