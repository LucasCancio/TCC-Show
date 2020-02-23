using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Descontos
{
    public partial class frmDescontos : Modelos.ModeloPadrao
    {
        public frmDescontos()
        {
            InitializeComponent();
            this.dgv.DefaultCellStyle.BackColor = Color.LightGray;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor =
  Color.Silver;
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
                }

            }
        }
        private void Exibir(object sender, EventArgs e)
        {

            CarregarGrid();
        }


        private void CarregarGrid()
        {
            try
            {
                BLL.Desconto obj = new BLL.Desconto(); // <<<<<<<<<<<<<<<<



                this.dgv.DataSource = obj.Listar().Tables[0];





                this.dgv.Columns[0].HeaderText = "Cód Desconto";
                this.dgv.AutoResizeColumn(0);
                this.dgv.Columns[1].HeaderText = "Desconto";
                this.dgv.AutoResizeColumn(1);
                this.dgv.Columns[2].HeaderText = "Cód Promocional";
                this.dgv.AutoResizeColumn(2);
                this.dgv.Columns[3].HeaderText = "Número de Utilizações";
                this.dgv.AutoResizeColumn(3);
                this.dgv.Columns[4].HeaderText = "Ativo";
                this.dgv.AutoResizeColumn(4);


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
                if (this.dgv.RowCount == 0) { MessageBox.Show("Nenhum Desconto cadastrado!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                this.txtCodigo.Text = this.dgv.CurrentRow.Cells[0].Value.ToString();
                this.txtDesconto.Text = this.dgv.CurrentRow.Cells[1].Value.ToString();
                this.txtCodProm.Text = this.dgv.CurrentRow.Cells[2].Value.ToString();
                if (this.dgv.CurrentRow.Cells[4].Value.ToString()=="1")
                {
                    this.chkAtivo.Checked = true;
                }
                else
                {
                    this.chkAtivo.Checked = false;
                }
                this.nupUsos.Value = Convert.ToInt32(this.dgv.CurrentRow.Cells[3].Value);
                operacao = 1;
                this.chkAtivo.Enabled = true;
                this.txtDesconto.Enabled = true;
                this.txtCodProm.Enabled = true;
                this.btnSalvar.Enabled = true; this.pbSalvar.Enabled = true;
                this.btnCancelar.Enabled = true; this.pbCancelar.Enabled = true;

                this.dgv.Enabled = false;

                this.pbAdicionar.Enabled = false; this.btnAdicionar.Enabled = false;
                this.btnAlterar.Enabled = false; this.pbAlterar.Enabled = false;
                this.btnExcluir.Enabled = false; this.pbExcluir.Enabled = false;
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

                BLL.Desconto obj = new BLL.Desconto(); //<<<<<<<<<<<<<
                if (this.dgv.SelectedRows.Count < 2)
                {
                    if (MessageBox.Show("Deseja Excluir " + this.dgv.CurrentRow.Cells[1].Value.ToString() + "?", "Código " + this.dgv.CurrentRow.Cells[0].Value.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;

                    obj.ID_DESCONTO= Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value); //<<<<<<<<
                    obj.Descontos_crud('D');
                }
                else
                {
                    string nome = string.Empty;
                    int i = 1;
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Selected)
                        {

                            if (nome == string.Empty)
                            {
                                nome = row.Cells[1].Value.ToString() + " ,";
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

                    MessageBox.Show("Essa operação pode ocasionar na perda de dados e até mesmo no mal funcionamento do sistema!", "ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                    if (MessageBox.Show("Deseja Excluir " + nome + "?", "Código " + this.dgv.CurrentRow.Cells[0].Value.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;

                    foreach (DataGridViewRow linha in dgv.Rows)
                    {
                        if (linha.Selected)
                        {
                            obj.ID_DESCONTO = Convert.ToInt32(linha.Cells[0].Value); //<<<<<<<<
                            obj.Descontos_crud('D');

                            BLL.Log LOG = new BLL.Log();
                            LOG.ID_FUNC = idFunc;
                            LOG.ID_MODIFICADO = Convert.ToInt32(linha.Cells[0].Value);
                            LOG.TABELA_LOG = "DESCONTOS";
                            LOG.TIPO_LOG = "EXCLUSÃO"; LOG.DESCRICAO= linha.Cells[1].Value.ToString();
                            LOG.Log_crud('D');
                        }

                    }
                }





                MessageBox.Show("Procedimento Deletar realizado com sucesso!");
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Salvar(object sender, EventArgs e)
        {




            try
            {



                if (this.txtDesconto.Text == String.Empty)
                {
                    this.erro.SetError(this.txtDesconto , "Desconto não preenchido!");
                    this.txtDesconto.Focus();
                    return;
                }
                else
                {
                    this.erro.SetError(this.txtDesconto, String.Empty);
                }

                if (this.txtCodProm.Text == String.Empty)
                {
                    this.erro.SetError(this.txtCodProm, "O Código Promocional é obrigatório!");
                    this.txtDesconto.Focus();
                    return;
                }
                else
                {
                    this.erro.SetError(this.txtCodProm, String.Empty);
                }

                if (this.txtDesconto.Text != string.Empty)
                {
                    if (txtDesconto.Text.IndexOf(",") == txtDesconto.Text.Length - 1)
                    {
                        this.txtDesconto.Text = this.txtDesconto.Text.Substring(0, txtDesconto.Text.Length - 1);
                    }
                }

                if (Convert.ToDouble(this.txtDesconto.Text) > 100)
                {
                    this.erro.SetError(this.txtDesconto, "Desconto maior que 100% !");
                    this.txtDesconto.Focus();
                    return;
                }
                else
                {
                    this.erro.SetError(this.txtDesconto, String.Empty);
                }


                //FIM DOS TRATAMENTOS DE ERROS



                if (MessageBox.Show("Deseja Salvar?", "ATENÇÃO ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; }
                BLL.Desconto func = new BLL.Desconto();
                BLL.Log log = new BLL.Log();
                btnSalvar.Cursor = Cursors.AppStarting;
                func.DESCONTO = Convert.ToDouble(this.txtDesconto.Text.ToUpper().Trim());
                func.COD_PROMOCIONAL= this.txtCodProm.Text.ToUpper().Trim();
                func.ATIVO = 1;
                log.ID_FUNC = idFunc;
                if (this.txtCodigo.Text!=string.Empty)
                {
                    log.ID_MODIFICADO = Convert.ToInt32(this.txtCodigo.Text);
                }
               
                log.TABELA_LOG = "DESCONTOS";
                if (!this.chkAtivo.Checked)
                {
                    func.ATIVO = 0;
                }

                switch (operacao)
                {
                    case 0: //inclusao

                        func.Descontos_crud('I');
                        Oracle.DataAccess.Client.OracleDataReader dr;
                        dr = func.ConsultarValorMaximo();
                        log.TIPO_LOG = "INSERÇÃO";
                        if (dr.Read())
                        {
                            log.ID_MODIFICADO = Convert.ToInt32(dr["ID"]);
                        }
                        log.Log_crud('I');


                        break;
                    case 1: //alteracao
                        codigo = Convert.ToInt32(this.txtCodigo.Text);
                        func.ID_DESCONTO = codigo;
                        func.Descontos_crud('A');
                        log.TIPO_LOG = "ALTERAÇÃO";
                        log.Log_crud('A');

                        break;
                }

                MessageBox.Show("Operação realizada com sucesso!");

                btnSalvar.Cursor = Cursors.Hand;

                CarregarGrid();
                this.txtDesconto.Text = string.Empty;
                this.txtDesconto.Enabled = false;
                this.txtCodProm.Text = string.Empty;
                this.nupUsos.Value = 0;
                this.txtCodProm.Enabled = false;
                this.chkAtivo.Enabled = false;
                this.pbAdicionar.Enabled = true; this.btnAdicionar.Enabled = true;
                this.btnAlterar.Enabled = true; this.pbAlterar.Enabled = true;
                this.btnExcluir.Enabled = true; this.pbExcluir.Enabled = true;

                this.dgv.Enabled = true;
                this.txtCodigo.Text = string.Empty;
                this.btnSalvar.Enabled = false; this.pbSalvar.Enabled = false;
                this.btnCancelar.Enabled = false; this.pbCancelar.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Cancelar(object sender, EventArgs e)
        {
           
            this.pbAdicionar.Enabled = true; this.btnAdicionar.Enabled = true;
            this.btnAlterar.Enabled = true; this.pbAlterar.Enabled = true;
            this.btnExcluir.Enabled = true; this.pbExcluir.Enabled = true;

            this.dgv.Enabled = true;
            this.txtCodigo.Text = string.Empty;
            
            this.txtDesconto.Text = string.Empty;
            this.txtDesconto.Enabled = false;
            this.txtCodProm.Text = string.Empty;
            this.nupUsos.Value = 0;
            this.txtCodProm.Enabled = false;
            this.chkAtivo.Enabled = false;
            this.btnSalvar.Enabled = false; this.pbSalvar.Enabled = false;
            this.btnCancelar.Enabled = false; this.pbCancelar.Enabled = false;
        }

        private void Adicionar(object sender, EventArgs e)
        {
            operacao = 0;

            this.dgv.Enabled = false;
            this.txtCodigo.Text = string.Empty;
            this.txtDesconto.Text = string.Empty;
            this.txtDesconto.Enabled = true;
            this.txtCodProm.Text = string.Empty;
            this.nupUsos.Value = 0;
            this.txtCodProm.Enabled = true;
            this.chkAtivo.Enabled = true;

            this.btnSalvar.Enabled = true; this.pbSalvar.Enabled = true;
            this.btnCancelar.Enabled = true; this.pbCancelar.Enabled = true;

            this.pbAdicionar.Enabled = false; this.btnAdicionar.Enabled = false;
            this.btnAlterar.Enabled = false; this.pbAlterar.Enabled = false;
            this.btnExcluir.Enabled = false; this.pbExcluir.Enabled = false;
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgv.SelectedRows.Count > 1)
            {
                this.btnAlterar.Enabled = false; this.pbAlterar.Enabled = false;
            }
            else
            {
                this.btnAlterar.Enabled = true; this.pbAlterar.Enabled = true;
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)

            {

                e.Handled = true;

            }
            if (e.KeyChar == (char)44)
            {
                if (this.txtDesconto.Text == string.Empty)
                { e.Handled = true; }
                if (this.txtDesconto.Text.IndexOf(",") > 0 || this.txtDesconto.Text.IndexOf(",") == 0)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            if (this.txtDesconto.Text!=string.Empty)
            {
                if (Convert.ToDouble(this.txtDesconto.Text)>100)
                {
                    
                        this.erro.SetError(this.txtDesconto, "Desconto maior que 100% !");
                        this.txtDesconto.Focus();
                        return;

                }
                else
                {
                    this.erro.SetError(this.txtDesconto, string.Empty);
                }
            }
        }

        ///////////////////////////////
    }
}
