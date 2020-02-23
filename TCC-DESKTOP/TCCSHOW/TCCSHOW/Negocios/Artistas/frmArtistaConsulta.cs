using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Artistas
{
    public partial class frmArtistaConsulta : Modelos.ModeloConsultaPadrao
    {
        public frmArtistaConsulta()
        {
            InitializeComponent();
            this.rbCodigo.Checked = true;
            this.dgv.DefaultCellStyle.BackColor = Color.LightGray;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor =
  Color.Silver;
            tipo = "Nome";
            WPTotal = this.txtPesquisar.Width;
            WPData = txtPesquisar.Width - this.dtpHorarioInicio.Width - 20;
        }
        double WPTotal, WPData;
        string tTemp;
        public string tipo3 = "Ambos", tCod;
        public string tipo, tipo2;
        public int ativo = 2;



        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            foreach (DataGridViewRow linha in dgv.Rows)
            {
                if (linha.Cells[7].Value.ToString() == "0")
                {
                    //linha.DefaultCellStyle.BackColor = Color.Red;
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



        
        private void CarregarGrid()
        {
            try
            {
                BLL.Artista obj = new BLL.Artista(); // <<<<<<<<<<<<<<<<
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
                        break;
                }


                switch (tipo)
                {
                    case "CPFEmpresario":
                    case "CNPJEmpresario":
                    case "AGT.DOCUMENTO":
                        tipo= "AGT.DOCUMENTO";
                        break;
                    case "CPF":
                    case "AF.CPF":
                        tipo = "AF.CPF";
                        break;
                    case "NomeEmpresario":
                    case "AGT.NOME_PRINCIPAL":
                        tipo = "AGT.NOME_PRINCIPAL";
                        break;
                    case "Telefone":
                    case "AF.TELEFONE":
                        tipo = "AF.TELEFONE";
                        break;
                    case "Email":
                    case "AF.EMAIL":
                        tipo = "AF.EMAIL";
                        break;
          
                    case "NomeArt":
                    case "NomeArtF":
                    case "P.NOME":
                        tipo = "P.NOME";
                        break;
                    case "Codigo":
                    case "AG.ID_ARTISTA_GERAL":
                        tipo = "AG.ID_ARTISTA_GERAL";
                        break;
                    case "":
                    case null:
                        tipo = "P.NOME";
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
                            if (tipo.IndexOf("DOCUMENTO") >= 0 || tipo.IndexOf("TELEFONE")>=0 )
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

        private void frmArtistaConsulta_KeyPress(object sender, KeyPressEventArgs k)
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
        private void AbrirFormulario(object sender, EventArgs e)
        {//INCLUIR ALTERAR CONSULTAR
            try
            {
                if (this.dgv.RowCount == 0) { MessageBox.Show("Nenhum Artista cadastrado!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                frmArtistaCadastro f = new frmArtistaCadastro
                {
                    operacao = Convert.ToByte(BLL.Operacao.Inclusao), idFunc=this.idFunc,
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size
                };
               
             
                f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;

                if (sender == this.btnAlterar || sender == this.pbAlterar || sender == this.btnConsultar || sender == this.pbConsultar)
                {
                    f.lblTitulo.Text = "Consulta de";
                    f.gbCodigo.Visible = true;
                    f.codigo = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                    f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);
                    f.Tipo_Art = this.dgv.CurrentRow.Cells[2].Value.ToString();
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



                    if (sender == this.btnConsultar || sender == this.pbConsultar)
                    {
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
                if (MessageBox.Show("Deseja " + b.Text.ToLower() + " " +nome + "?", "Código " + this.dgv.CurrentRow.Cells[0].Value.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;
                Oracle.DataAccess.Client.OracleDataReader dr;
                BLL.Artista obj = new BLL.Artista();
                BLL.Log LOG = new BLL.Log();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Selected)
                    {
                        obj.ID_ARTISTA_GERAL = Convert.ToInt32(row.Cells[0].Value); //<<<<<<<<

                        if (row.Cells[2].Value.ToString() == "ARTISTA")
                        {
                            obj.ID_TIPO_PESSOA = 3;
                        }
                        else
                        {
                            obj.ID_TIPO_PESSOA = 4;
                        }
                        switch (b.Name.Replace("btn", ""))
                        {
                            case "Excluir":
                                dr = obj.VerificarEvento();
                                if (dr.Read())
                                {
                                    MessageBox.Show("Existe um evento vinculado á/ao "+row.Cells[1].Value.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                obj.Artista_crud("D");

                                
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "ARTISTAS";
                                LOG.TIPO_LOG = "EXCLUSÃO"; LOG.DESCRICAO= row.Cells[1].Value.ToString();
                                LOG.Log_crud('D');

                                break;
                            case "Desativar":

                                if (Convert.ToInt32(row.Cells[7].Value) != 0)
                                {
                                    
                                    dr = obj.Verificar();
                                    if (dr.Read())
                                    {
                                        MessageBox.Show("O artista está ativo em um evento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    obj.Ativar(0);
                                }
                                else
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("O Artista " + row.Cells[0].Value.ToString() + " já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Artista já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "ARTISTAS";
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
                                        MessageBox.Show("O Artista " + row.Cells[0].Value.ToString() + " já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Artista já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "ARTISTAS";
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
                if (MessageBox.Show("Deseja " + b.Name.Replace("pb", "").ToLower() + " " + nome + "?", "Código " + this.dgv.CurrentRow.Cells[0].Value.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;
                Oracle.DataAccess.Client.OracleDataReader dr;
                BLL.Artista obj = new BLL.Artista();
                BLL.Log LOG = new BLL.Log();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Selected)
                    {
                        obj.ID_ARTISTA_GERAL = Convert.ToInt32(row.Cells[0].Value); //<<<<<<<<

                        if (row.Cells[2].Value.ToString() == "ARTISTA")
                        {
                            obj.ID_TIPO_PESSOA = 3;
                        }
                        else
                        {
                            obj.ID_TIPO_PESSOA = 4;
                        }
                        switch (b.Name.Replace("pb", ""))
                        {
                            case "Excluir":
                                dr = obj.VerificarEvento();
                                if (dr.Read())
                                {
                                    MessageBox.Show("Existe um evento ativo vinculado á/ao " + row.Cells[1].Value.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                obj.Artista_crud("D");

                                
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "ARTISTAS";
                                LOG.TIPO_LOG = "EXCLUSÃO"; LOG.DESCRICAO= row.Cells[1].Value.ToString();
                                LOG.Log_crud('D');

                                break;
                            case "Desativar":

                                if (Convert.ToInt32(row.Cells[7].Value) != 0)
                                {
                                   
                                    dr = obj.Verificar();
                                    if (dr.Read())
                                    {
                                        MessageBox.Show("O artista está ativo em um evento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    obj.Ativar(0);
                                }
                                else
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("O Artista " + row.Cells[0].Value.ToString() + " já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Artista já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "ARTISTAS";
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
                                        MessageBox.Show("O Artista " + row.Cells[0].Value.ToString() + " já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Artista já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "ARTISTAS";
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


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            bool _found = false;

            foreach (Form _openForm in Application.OpenForms)

            {

                if (_openForm is Negocios.Artistas.frmArtistaCadastro)

                {

                    _openForm.Focus();

                    _found = true;

                }

            }

            if (!_found)

            {

                Negocios.Artistas.frmArtistaCadastro _form2 = new Negocios.Artistas.frmArtistaCadastro();
                _form2.TopMost = true;
                _form2.Show();


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




    }
}
