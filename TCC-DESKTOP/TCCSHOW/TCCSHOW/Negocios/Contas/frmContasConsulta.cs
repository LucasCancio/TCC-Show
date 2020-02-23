using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Contas
{
    public partial class frmContasConsulta : Modelos.ModeloConsultaPadrao
    {
        public frmContasConsulta()
        {
            InitializeComponent();
            this.dgv.DefaultCellStyle.BackColor = Color.LightGray;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor =
  Color.Silver;
            tipo = "Descrição";
            tipo2 = "Todas";
            tData = "Pagamento/Recebimento";
            this.dtpHorarioFinal.Value = Convert.ToDateTime(DateTime.Now.AddMonths(1).ToString().Substring(0, 10));
            this.rbTodos.Checked = true;
            this.rbAtiva.Checked = false;
        }

        public string tipo, tipo2, tSit, tTipoPag, tData;


        private void Exibir(object sender, EventArgs e)
        {
            //if (cbTipo.Text == "Data de Recebimento/Vencimento" ||
            //    cbTipo.Text == "Data de Vencimento" ||
            //    cbTipo.Text == "Data de Recebimento")
            //{
            //    nupMes.Visible = true;
            //    lblmes.Visible = true;
            //}
            //else
            //{
            //    nupMes.Visible = false;
            //    lblmes.Visible = false;
            //}
            CarregarGrid();
           

            this.txtPesquisar.Focus();
        }

        private void MudarTipo(object sender, EventArgs e)
        {
            //this.cbTipo.Items.Clear();
            //this.cbTipo.Enabled = true;
            //switch (cbTipo2.Text)
            //{
            //    case "Ambas":
            //        this.cbTipo.Items.Add("Código");
            //        this.cbTipo.Items.Add("Descrição");
            //        this.cbTipo.Items.Add("Data de Recebimento/Vencimento");

            //        break;
            //    case "Contas a Receber":
            //        this.cbTipo.Items.Add("Código");
            //        this.cbTipo.Items.Add("Descrição");
            //        this.cbTipo.Items.Add("Data de Recebimento");
            //        break;
            //    case "Contas a Pagar":
            //        this.cbTipo.Items.Add("Código");
            //        this.cbTipo.Items.Add("Descrição");
            //        this.cbTipo.Items.Add("Data de Vencimento");

            //        break;
            //}
            //this.cbTipo.SelectedIndex = 0;
        }
        private void CarregarGrid()
        {
            try
            {
                BLL.Contas obj = new BLL.Contas(); // <<<<<<<<<<<<<<<<
                int ativo = 0;



                if (rbTodos.Checked) { ativo = 2; }
                else if (rbAtiva.Checked) { ativo = 1; }
                else if (rbDesativa.Checked) { ativo = 0; }


                switch (tipo)
                {
                    case "Codigo":
                        tipo = "C.ID_CONTAS";
                        break;
                    case "Departamento":

                        tipo = "C.DEPARTAMENTO";
                        break;
                    case "Descrição":
                    case null:
                    case "":
                        
                        tipo = "C.DESCRICAO";
                        break;
                    case "Valor":
                        tipo = "C.VALOR_TOTAL";
                        break;
                }
                switch (tData)
                {
                    case "Lançamento":
                        tData = "C.DATA_LANCAMENTO";
                        break;
                    case "Pagamento":
                    case "Recebimento":
                    case "Pagamento/Recebimento":
                        tData = "DC.DATA_CONTA";
                        break;
                    
                }

                obj.DataListarInicio = Convert.ToDateTime(dtpHorarioInicio.Value.ToString().Substring(0, 10));
                obj.DataListarFinal = Convert.ToDateTime(dtpHorarioFinal.Value.ToString().Substring(0, 10));


                this.dgv.DataSource = obj.ListarGeral(this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, tipo2, tSit, tData, tTipoPag).Tables[0];




                this.dgv.AutoResizeColumn(0);

                this.dgv.Columns[0].HeaderText = "Código da Conta";
                this.dgv.AutoResizeColumn(0);
                this.dgv.Columns[1].HeaderText = "Tipo da Conta";
                this.dgv.AutoResizeColumn(1);
                this.dgv.Columns[2].HeaderText = "Descrição";
                this.dgv.AutoResizeColumn(2);
                this.dgv.Columns[3].HeaderText = "Valor Total";
                this.dgv.AutoResizeColumn(3);
                this.dgv.Columns[4].HeaderText = "Data da Conta";
                this.dgv.AutoResizeColumn(4);
                this.dgv.Columns[5].HeaderText = "Situação";
                this.dgv.AutoResizeColumn(5);
                this.dgv.Columns[6].HeaderText = "Departamento";
                this.dgv.AutoResizeColumn(6);
                this.dgv.Columns[7].HeaderText = "Data de Lançamento";
                this.dgv.AutoResizeColumn(7);
                this.dgv.Columns[8].HeaderText = "Ativo";
                this.dgv.AutoResizeColumn(8);


                this.txtPesquisar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }

        private void frmContasConsulta_KeyPress(object sender, KeyPressEventArgs k)
        {
            if (!char.IsDigit(k.KeyChar) && k.KeyChar != (char)8 && tipo == "C.ID_CONTAS")

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
                if (this.dgv.RowCount == 0) { MessageBox.Show("Nenhuma Conta cadastrada!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                if (sender==this.btnAlterar || sender==this.pbAlterar)
                {
                    BLL.Contas c = new BLL.Contas();
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Selected)
                        {
                            
                            c.ID_CONTAS = Convert.ToInt32(row.Cells[0].Value);
                            dr = c.ConsultarVenda();
                            if (dr.Read())
                            {
                                MessageBox.Show("A Conta é proveniente de uma venda, e por isso não pode ser alterada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    
                }
                Contas.frmContasCadastro f = new Contas.frmContasCadastro
                {
                    operacao = Convert.ToByte(BLL.Operacao.Inclusao), idFunc=this.idFunc,
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size
                };

                f.Size = new Size(f.Width, f.Height + 15);

                f.operacao = Convert.ToByte(BLL.Operacao.Inclusao);
                //f.lblNomeTool.Text = lblNomeTool.Text; f.lblNomeTool.ForeColor= this.lblNomeTool.ForeColor; f.tool_ID.Text= this.tool_ID.Text;
                f.dtpData.Value = DateTime.Today;
                f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;


                if (sender == this.btnAlterar || sender == this.pbAlterar || sender == this.btnConsultar || sender == this.pbConsultar)
                {
                    f.lblTitulo.Text = "Consulta de";
                    f.codigo = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                    f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);
                    f.txtDesc.Enabled = true;
                    // f.txtValor.Enabled = true;
                    f.dtpData.Enabled = true;
                    f.rbPagar.Enabled = true;
                    f.rbReceber.Enabled = true;
                    f.txtCodigo.Enabled = true;
                    f.gbCodigo.Visible = true;
                    f.chkAtivo.Enabled = true;
                    f.btnSalvar.Visible = true; f.pbSalvar.Visible = true;
                    f.btnSalvar.Enabled = true; f.pbSalvar.Enabled = true;
                    f.btnSalvar.BackColor = Color.Lime;
                    if (sender == this.btnConsultar || sender == this.pbConsultar)
                    {
                        f.txtDesc.Enabled = false;
                        f.txtValor.Enabled = false;
                        f.dtpEntregue.Enabled = false;
                        f.cbSituacao.Enabled = false;
                        f.dtpData.Enabled = false;
                        f.rbPagar.Enabled = false;
                        f.rbReceber.Enabled = false;
                        f.txtDepart.Enabled = false;
                        f.cbFormaPag.Enabled = false;
                        f.cbSituacao.Enabled = false;
                        f.dtpDataLanc.Enabled = false;
                        foreach (Control item in f.gbFormaPag.Controls)
                        {
                            if (item is DataGridView)
                            {
                                item.Enabled = true;
                            }
                            else
                            {
                                item.Enabled = false;
                            }
                          
                        }
                        f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;
                        f.chkAtivo.Enabled = false;
                        f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible=false; f.btnLimpar.Visible=false;
                        f.btnSalvar.Enabled = false; f.pbSalvar.Enabled = false;

                        f.rbPagar.Visible = false;
                        f.rbReceber.Visible = false;
                        f.pbPagar.Visible = false;
                        f.pbReceber.Visible = false;


                        f.lblTituloConta.Visible = true;
                        f.lblTituloConta.Text = f.lblTituloConta.Text + this.dgv.CurrentRow.Cells[1].Value.ToString();
                        f.pbTituloConta.Visible = true;
                        if (this.dgv.CurrentRow.Cells[1].Value.ToString()=="Receber")
                        {
                            f.pbTituloConta.Image = Properties.Resources.MaisIcone;
                        }
                        else
                        {
                            f.pbTituloConta.Image = Properties.Resources.MenosIcone;
                        }


                        f.operacao = Convert.ToByte(BLL.Operacao.Consulta);
                    }
                }
                //var b = (Button)sender;
                //f.lblTitulo.Text =  b.Text;
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
                                nome = row.Cells[0].Value.ToString();
                            }
                            else
                            {
                                nome = row.Cells[0].Value.ToString() + " ,";
                            }

                        }
                        else if (i != dgv.SelectedRows.Count)
                        {
                            nome = nome + row.Cells[0].Value.ToString() + " , ";
                        }
                        else
                        {
                            nome = nome + row.Cells[0].Value.ToString();
                        }
                        ++i;
                    }


                }
                var b = (Button)o;
                if (MessageBox.Show("Deseja " + b.Text.ToLower() + " código(s) " + nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;
                BLL.Contas obj = new BLL.Contas(); //<<<<<<<<<<<<<
                BLL.Log LOG = new BLL.Log();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Selected)
                    {
                        obj.ID_CONTAS = Convert.ToInt32(row.Cells[0].Value); //<<<<<<<<
                        switch (b.Text)
                        {
                            case "Excluir":
                                obj.Contas_crud('D');

                                
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "CONTAS";
                                LOG.TIPO_LOG = "EXCLUSÃO"; LOG.DESCRICAO= row.Cells[6].Value.ToString();
                                LOG.Log_crud('D');
                                break;
                            case "Desativar":
                                if (Convert.ToInt32(row.Cells["Ativo"].Value) != 0)
                                {
                                    obj.Ativar(0);
                                }
                                else
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("A Conta " + row.Cells[0].Value.ToString() + " já está desativada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("A Conta já está desativada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "CONTAS";
                                LOG.TIPO_LOG = "ALTERAÇÃO";
                                LOG.Log_crud('A');
                                break;
                            case "Reativar":
                                if (Convert.ToInt32(row.Cells["Ativo"].Value) != 1)
                                {
                                    if (row.Cells["Situacao"].Value.ToString()=="Paga" || row.Cells["Situacao"].Value.ToString() == "Recebida")
                                    {

                                        BLL.Contas c = new BLL.Contas();
                                        Oracle.DataAccess.Client.OracleDataReader dr;
                                        c.ID_CONTAS = Convert.ToInt32(row.Cells[0].Value);
                                        dr = c.ConsultarVenda();
                                        if (dr.Read())
                                        {
                                            MessageBox.Show("A Conta é proveniente de uma venda, e por isso não pode ser reativada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }



                                        if (this.dgv.SelectedRows.Count>1)
                                        {
                                            if (MessageBox.Show("A conta "+row.Cells[0].Value.ToString() +" já esta " + row.Cells["Situacao"].Value.ToString() + "!" + Environment.NewLine + "Deseja ativá-la mesmo assim?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                                            {
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            if (MessageBox.Show("Essa conta já esta " + row.Cells["Situacao"].Value.ToString() + "!" + Environment.NewLine + "Deseja ativa-la mesmo assim?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.No) {
                                                return;
                                            }
                                        }
                                       
                                    }
                                    obj.Ativar(1);
                                }
                                else
                                {
                                    MessageBox.Show("A Conta já está ativa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "CONTAS";
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
        public int ID_VENDA;
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
                                nome = row.Cells[0].Value.ToString();
                            }
                            else
                            {
                                nome = row.Cells[0].Value.ToString() + " ,";
                            }

                        }
                        else if (i != dgv.SelectedRows.Count)
                        {
                            nome = nome + row.Cells[0].Value.ToString() + " , ";
                        }
                        else
                        {
                            nome = nome + row.Cells[0].Value.ToString();
                        }
                        ++i;
                    }


                }
                if (this.dgv.RowCount == 0) { MessageBox.Show("Nenhuma Conta cadastrada!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                var b = (PictureBox)o;
                if (MessageBox.Show("Deseja " + b.Name.Substring(2).Trim().ToLower() + " código(s) " + nome + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;
                BLL.Contas obj = new BLL.Contas(); //<<<<<<<<<<<<<
                BLL.Log LOG = new BLL.Log();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Selected)
                    {
                        obj.ID_CONTAS = Convert.ToInt32(row.Cells[0].Value); //<<<<<<<<
                        switch (b.Name.Replace("pb",""))
                        {
                            case "Excluir":
                                obj.Contas_crud('D');

                               
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "CONTAS";
                                LOG.TIPO_LOG = "EXCLUSÃO"; LOG.DESCRICAO= row.Cells[6].Value.ToString();
                                LOG.Log_crud('D');
                                break;
                            case "Desativar":
                                if (Convert.ToInt32(row.Cells["Ativo"].Value) != 0)
                                {
                                    obj.Ativar(0);
                                }
                                else
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("A Conta " + row.Cells[0].Value.ToString() + " já está desativada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("A Conta já está desativada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "CONTAS";
                                LOG.TIPO_LOG = "ALTERAÇÃO";
                                LOG.Log_crud('A');
                                break;
                            case "Reativar":
                                if (Convert.ToInt32(row.Cells["Ativo"].Value) != 1)
                                {
                                    if (row.Cells["Situacao"].Value.ToString() == "Paga" || row.Cells["Situacao"].Value.ToString() == "Recebida")
                                    {

                                        BLL.Contas c = new BLL.Contas();
                                        Oracle.DataAccess.Client.OracleDataReader dr;
                                        c.ID_CONTAS = Convert.ToInt32(row.Cells[0].Value);
                                        dr = c.ConsultarVenda();
                                        if (dr.Read())
                                        {
                                            MessageBox.Show("A Conta é proveniente de uma venda, e por isso não pode ser reativada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }




                                        if (this.dgv.SelectedRows.Count > 1)
                                        {
                                            if (MessageBox.Show("A conta " + row.Cells[0].Value.ToString() + " já esta " + row.Cells["Situacao"].Value.ToString() + "!" + Environment.NewLine + "Deseja ativá-la mesmo assim?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                                            {
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            if (MessageBox.Show("Essa conta já esta " + row.Cells["Situacao"].Value.ToString() + "!" + Environment.NewLine + "Deseja ativa-la mesmo assim?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                                            {
                                                return;
                                            }
                                        }

                                    }
                                    obj.Ativar(1);
                                }
                                else
                                {
                                    MessageBox.Show("A Conta já está ativa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "CONTAS";
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

        private void ConsultarVenda(object sender, EventArgs e)
        {
         
            foreach (DataGridViewRow linha in dgv.Rows)
            {
                if (linha.Selected)
                {
                    Negocios.Ingresso.frmIngresso f = new Negocios.Ingresso.frmIngresso
                    {
                        FormBorderStyle = FormBorderStyle.FixedToolWindow,
                        Size = this.Size,
                        idFunc = this.idFunc
                    };
                    f.MinimizeBox = true;
                    f.Size = new Size(f.Width, f.Height);
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.txtCodigo.Enabled = false; f.txtCodigo.Visible = true;

                   
                        f.gbCodigo.Visible = true;
                        f.codigo = Convert.ToInt32(ID_VENDA);
                        //f.Ativo = Convert.ToInt32(this.dgv.CurrentRow.Cells[4].Value);
                        f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);


                        f.txtCPF.Enabled = true;

                        f.txtCodigo.Enabled = true;
                        
                            f.btnImprimir.Visible = false;
                            f.pbImprimir.Visible = false;
                            f.gbImprimir.Visible = false;
                  

                            f.btnCancelar.Location = new Point(f.btnCancelar.Location.X + 180, f.btnCancelar.Location.Y);
                            f.pbCancelar.Location = new Point(f.pbCancelar.Location.X + 180, f.pbCancelar.Location.Y);
                        





                        
                            f.txtCPF.Enabled = false;
                            //f.txtNomeFunc.Enabled = false;
                            f.dtpDataNasc.Enabled = false;
                            f.txtCodigo.Enabled = false; f.txtCodigo.Visible = true;
                            f.dtpEvento.Enabled = false;
                            //f.cbSexo.Enabled = false;

                            //f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible = false; f.btnLimpar.Visible = false;


                            f.operacao = Convert.ToByte(BLL.Operacao.Consulta);

                        
                    
                    //var b = (Button)sender;
                    //f.lblTitulo.Text =  b.Text;

                    f.TopMost = true;
                    f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                    f.idFunc = this.idFunc; f.ShowDialog();

                }
            }
      
        }
        private void CheckedChange(object o, EventArgs e)
        {
            CarregarGrid();
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow linha in dgv.Rows)
            {
                if (linha.Cells[8].Value.ToString() == "0")
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
                    if (Convert.ToDateTime(linha.Cells[4].Value) <= DateTime.Now.AddDays(7) &&
                        Convert.ToDateTime(linha.Cells[4].Value) >= DateTime.Now)
                    {
                        //linha.DefaultCellStyle.BackColor = Color.Red;
                        //linha.DefaultCellStyle.BackColor = Color.FromArgb(192,192,0);
                        linha.DefaultCellStyle.BackColor = Color.FromArgb(240, 252, 64);
                        linha.DefaultCellStyle.SelectionForeColor = Color.LightYellow;
                    }
                    else
                    {
                        linha.DefaultCellStyle.BackColor = Color.LightGray;
                        dgv.AlternatingRowsDefaultCellStyle.BackColor =
              Color.Silver;
                        linha.DefaultCellStyle.ForeColor = Color.Black;
                        linha.DefaultCellStyle.SelectionForeColor = Color.Black;
                    }
                }

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
                if (this.dgv.CurrentRow==null)
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


            foreach (DataGridViewRow linha in dgv.Rows)
            {
                if (linha.Selected)
                {
                    BLL.Contas c = new BLL.Contas();
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    c.ID_CONTAS = Convert.ToInt32(linha.Cells[0].Value);
                    dr = c.ConsultarVenda();
                    if (dr.Read())
                    {
                        linha.ContextMenuStrip = menuVenda;
                        ID_VENDA = Convert.ToInt32(dr["ID_VENDA"]);
                    }

                       
                   
                }
                else
                {
                    linha.ContextMenuStrip = null;
                }
            }
        }



        private void AbrirFiltro(object sender, EventArgs e)
        {
            Filtro();
        }
        private void Filtro()
        {


            Negocios.Filtros.frmContasFiltro filtro = new Negocios.Filtros.frmContasFiltro();
            filtro.tipo2 = tipo2;
            filtro.tSit= tSit;
            filtro.tTipoPag = tTipoPag;
            filtro.tipo = tipo;
            filtro.tData = tData;
            filtro.TopMost = true;
            filtro.ShowDialog();

            tipo2 = filtro.tipo2;
            tSit = filtro.tSit;
            tTipoPag = filtro.tTipoPag;
            tipo = filtro.tipo;
            tData = filtro.tData;

            switch (filtro.tipo)
            {
                default:
                    break;
            }


            CarregarGrid();
        }



        //////////////////////////
    }
}
