using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Funcao
{
    public partial class frmFuncao : Modelos.ModeloPadrao
    {
        public frmFuncao()
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
                BLL.Funcao obj = new BLL.Funcao(); // <<<<<<<<<<<<<<<<



                this.dgv.DataSource = obj.Listar().Tables[0];





                this.dgv.Columns[0].HeaderText = "Cód Função";
                this.dgv.AutoResizeColumn(0);
                this.dgv.Columns[1].HeaderText = "Função";
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
                if (this.dgv.RowCount == 0) { MessageBox.Show("Nenhuma Função cadastrada!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                this.txtCodigo.Text = this.dgv.CurrentRow.Cells[0].Value.ToString();
                this.txtFuncao.Text = this.dgv.CurrentRow.Cells[1].Value.ToString();

                operacao = 1;
                this.txtFuncao.Enabled = true;
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

                BLL.Funcao obj = new BLL.Funcao(); //<<<<<<<<<<<<<
                if (this.dgv.SelectedRows.Count < 2)
                {
                    MessageBox.Show("Essa operação pode ocasionar na perda de dados e até mesmo no mal funcionamento do sistema!", "ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                    if (MessageBox.Show("Deseja Excluir " + this.dgv.CurrentRow.Cells[1].Value.ToString() + "?", "Código " + this.dgv.CurrentRow.Cells[0].Value.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    obj.ID_FUNCAO = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                    if (this.dgv.CurrentRow.Cells[0].Value.ToString() == "0" || this.dgv.CurrentRow.Cells[0].Value.ToString() == "1")
                    {
                        MessageBox.Show("Não é possivel deletar a função " + this.dgv.CurrentRow.Cells[1].Value.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }//<<<<<<<<
                    dr = obj.VerificarFuncionario();
                    if (dr.Read())
                    {
                        MessageBox.Show("Existe um funcionário vinculado á função " + this.dgv.CurrentRow.Cells[1].Value.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    obj.Funcao_crud('D');

                    BLL.Log LOG = new BLL.Log();
                    LOG.ID_FUNC = idFunc;
                    LOG.ID_MODIFICADO = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                    LOG.TABELA_LOG = "FUNÇÕES";
                    LOG.TIPO_LOG = "EXCLUSÃO"; LOG.DESCRICAO= this.dgv.CurrentRow.Cells[1].Value.ToString();
                    LOG.Log_crud('D');
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
                    Oracle.DataAccess.Client.OracleDataReader dr;

                    foreach (DataGridViewRow linha in dgv.Rows)
                    {
                        if (linha.Selected)
                        {
                            obj.ID_FUNCAO = Convert.ToInt32(linha.Cells[0].Value); //<<<<<<<<

                            if (linha.Cells[0].Value.ToString()=="0" || linha.Cells[0].Value.ToString() == "1")
                            {
                                MessageBox.Show("Não é possivel deletar a função " + linha.Cells[1].Value.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }


                            dr = obj.VerificarFuncionario();
                            if (dr.Read())
                            {
                                MessageBox.Show("Existe um funcionário vinculado á função " + linha.Cells[1].Value.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            obj.Funcao_crud('D');

                            BLL.Log LOG = new BLL.Log();
                            LOG.ID_FUNC = idFunc;
                            LOG.ID_MODIFICADO = Convert.ToInt32(linha.Cells[0].Value);
                            LOG.TABELA_LOG = "FUNÇÕES";
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



                if (this.txtFuncao.Text == String.Empty)
                {
                    this.erro.SetError(this.txtFuncao, "Função não preenchida!");
                    this.txtFuncao.Focus();
                    return;
                }
                else
                {
                    this.erro.SetError(this.txtFuncao, String.Empty);
                }



                //FIM DOS TRATAMENTOS DE ERROS



                if (MessageBox.Show("Deseja Salvar?", "ATENÇÃO ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; }
                BLL.Funcao func = new BLL.Funcao();
                BLL.Log log = new BLL.Log();
                btnSalvar.Cursor = Cursors.AppStarting;
                string M= this.txtFuncao.Text.Substring(0,1).ToUpper() + this.txtFuncao.Text.Substring(1,this.txtFuncao.Text.Length-1);
                func.FUNCAO =  M.Trim();
                log.ID_FUNC = idFunc;
               
                log.TABELA_LOG = "FUNÇÕES";


                switch (operacao)
                {
                    case 0: //inclusao

                        func.Funcao_crud('I');
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
                        func.ID_FUNCAO = codigo;
                        func.Funcao_crud('A');
                        log.TIPO_LOG = "ALTERAÇÃO";
                        log.Log_crud('A');

                        break;
                }

                MessageBox.Show("Operação realizada com sucesso!");

                btnSalvar.Cursor = Cursors.Hand;

                CarregarGrid();
                this.txtFuncao.Enabled = false;
                this.pbAdicionar.Enabled = true; this.btnAdicionar.Enabled = true;
                this.btnAlterar.Enabled = true; this.pbAlterar.Enabled = true;
                this.btnExcluir.Enabled = true; this.pbExcluir.Enabled = true;

                this.dgv.Enabled = true;
                this.txtCodigo.Text = string.Empty;
                this.txtFuncao.Text = string.Empty;
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
            this.txtFuncao.Enabled = false;
            this.pbAdicionar.Enabled = true; this.btnAdicionar.Enabled = true;
            this.btnAlterar.Enabled = true; this.pbAlterar.Enabled = true;
            this.btnExcluir.Enabled = true; this.pbExcluir.Enabled = true;

            this.dgv.Enabled = true;
            this.txtCodigo.Text = string.Empty;
            this.txtFuncao.Text = string.Empty;
            this.btnSalvar.Enabled = false; this.pbSalvar.Enabled = false;
            this.btnCancelar.Enabled = false; this.pbCancelar.Enabled = false;
        }

        private void Adicionar(object sender, EventArgs e)
        {
            operacao = 0;

            this.dgv.Enabled = false;
            this.txtCodigo.Text = string.Empty;
            this.txtFuncao.Text = string.Empty;
            this.txtFuncao.Enabled = true;

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

    
        ///////////////////////////////

    }
    
}
