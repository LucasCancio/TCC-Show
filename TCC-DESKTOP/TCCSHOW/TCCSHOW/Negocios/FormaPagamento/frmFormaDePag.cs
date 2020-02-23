using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.FormaPagamento
{
    public partial class frmFormaDePag : Modelos.ModeloPadrao
    {
        public frmFormaDePag()
        {
            InitializeComponent();
            this.dgv.DefaultCellStyle.BackColor = Color.LightGray;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor =
  Color.Silver;
        }


        private void Exibir(object sender, EventArgs e)
        {

            CarregarGrid();
        }

      
        private void CarregarGrid()
        {
            try
            {
                BLL.FormaPagamento obj = new BLL.FormaPagamento(); // <<<<<<<<<<<<<<<<
               


                this.dgv.DataSource = obj.Listar().Tables[0];





                this.dgv.Columns[0].HeaderText = "Cód Forma Pag";
                this.dgv.AutoResizeColumn(0);
                this.dgv.Columns[1].HeaderText = "Forma Pagamento";
                this.dgv.AutoResizeColumn(1);

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
                if (this.dgv.RowCount == 0) { MessageBox.Show("Nenhuma Forma de Pagamento cadastrada!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                this.txtCodigo.Text = this.dgv.CurrentRow.Cells[0].Value.ToString();
                this.txtFormaDePag.Text = this.dgv.CurrentRow.Cells[1].Value.ToString();

                operacao = 1;
                this.txtFormaDePag.Enabled = true;
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

                BLL.FormaPagamento obj = new BLL.FormaPagamento(); //<<<<<<<<<<<<<
                if (this.dgv.SelectedRows.Count<2)
                {
                    MessageBox.Show("Essa operação pode ocasionar na perda de dados e até mesmo no mal funcionamento do sistema!", "ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                    if (MessageBox.Show("Deseja Excluir " + this.dgv.CurrentRow.Cells[1].Value.ToString() + "?", "Código " + this.dgv.CurrentRow.Cells[0].Value.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;

                    obj.ID_FORMA_PAGAMENTO = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value); //<<<<<<<<
                    obj.FormaDePag_crud('D');

                    BLL.Log LOG = new BLL.Log();
                    LOG.ID_FUNC = idFunc;
                    LOG.ID_MODIFICADO = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                    LOG.TABELA_LOG = "FORMAS PAGS";
                    LOG.TIPO_LOG = "EXCLUSÃO"; LOG.DESCRICAO = this.dgv.CurrentRow.Cells[1].Value.ToString();
                    LOG.Log_crud('D');
                }
                else
                {
                    string nome= string.Empty;
                    int i = 1;
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Selected)
                        {
                            
                                if (nome == string.Empty)
                                {
                                    nome = row.Cells[1].Value.ToString() + " ,";
                                }
                                else if(i!=dgv.SelectedRows.Count)
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
                            obj.ID_FORMA_PAGAMENTO = Convert.ToInt32(linha.Cells[0].Value); //<<<<<<<<
                            obj.FormaDePag_crud('D');

                            BLL.Log LOG = new BLL.Log();
                            LOG.ID_FUNC = idFunc;
                            LOG.ID_MODIFICADO = Convert.ToInt32(linha.Cells[0].Value);
                            LOG.TABELA_LOG = "FORMAS PAGS";
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



                if (this.txtFormaDePag.Text == String.Empty)
                {
                    this.erro.SetError(this.txtFormaDePag, "Forma de Pagamento não preenchida!");
                    this.txtFormaDePag.Focus();
                    return;
                }
                else
                {
                    this.erro.SetError(this.txtFormaDePag, String.Empty);
                }



                //FIM DOS TRATAMENTOS DE ERROS



                if (MessageBox.Show("Deseja Salvar?", "ATENÇÃO ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; } 
                BLL.FormaPagamento func = new BLL.FormaPagamento();
                BLL.Log log = new BLL.Log();
                btnSalvar.Cursor = Cursors.AppStarting;
                string M = this.txtFormaDePag.Text.Substring(0, 1).ToUpper() + this.txtFormaDePag.Text.Substring(1, this.txtFormaDePag.Text.Length - 1);
                func.FORMA_PAGAMENTO = M.Trim();
                log.ID_FUNC = idFunc;
                
                log.TABELA_LOG = "FORMAS PAGS";




                switch (operacao)
                {
                    case 0: //inclusao

                        func.FormaDePag_crud('I');

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
                        log.ID_MODIFICADO = Convert.ToInt32(this.txtCodigo.Text);
                        codigo = Convert.ToInt32(this.txtCodigo.Text);
                        func.ID_FORMA_PAGAMENTO = codigo;
                        func.FormaDePag_crud('A');
                        log.TIPO_LOG = "ALTERAÇÃO";
                        log.Log_crud('A');
                        break;
                }



                btnSalvar.Cursor = Cursors.Hand;
                MessageBox.Show("Operação realizada com sucesso!");
                CarregarGrid();
                this.txtFormaDePag.Enabled = false;
                this.pbAdicionar.Enabled = true; this.btnAdicionar.Enabled = true;
                this.btnAlterar.Enabled = true; this.pbAlterar.Enabled = true;
                this.btnExcluir.Enabled = true; this.pbExcluir.Enabled = true;

                this.dgv.Enabled = true;
                this.txtCodigo.Text = string.Empty;
                this.txtFormaDePag.Text = string.Empty;
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
            this.txtFormaDePag.Enabled = false;
            this.pbAdicionar.Enabled = true; this.btnAdicionar.Enabled = true;
            this.btnAlterar.Enabled = true; this.pbAlterar.Enabled = true;
            this.btnExcluir.Enabled = true; this.pbExcluir.Enabled = true;

            this.dgv.Enabled = true;
            this.txtCodigo.Text = string.Empty;
            this.txtFormaDePag.Text = string.Empty;
            this.btnSalvar.Enabled = false; this.pbSalvar.Enabled = false;
            this.btnCancelar.Enabled = false;this.pbCancelar.Enabled = false;
        }

        private void Adicionar(object sender, EventArgs e)
        {
            operacao = 0;

            this.dgv.Enabled = false;
            this.txtCodigo.Text = string.Empty;
            this.txtFormaDePag.Text = string.Empty;
            this.txtFormaDePag.Enabled = true;

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

        //////////////////////////
    }
    public static class StringExtends
    {
        public static string FirstCharToUpper(this string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("Insira uma palavra diferente de nula ou vazia");
            return input.Length > 1 ? char.ToUpper(input[0]) + input.Substring(1) : input.ToUpper();
        }
    }
}
