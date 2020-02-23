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
    public partial class frmContasCadastro : Modelos.ModeloCadastroPadrao
    {
        public frmContasCadastro()
        {
            InitializeComponent();
            if (operacao==0)
            {
                this.gbCodigo.Visible = false;

                this.dtpEntregue.Value = DateTime.Now;
                this.dtpData.Value = DateTime.Now;
            }
            this.dtpEntregue.MaxDate = DateTime.Now;

            
            
        }

        public int idDataConta, idFormaPagamento;
        private void CheckedChanged(object sender, EventArgs e)
        {
            if (rbPagar.Checked)
            {
                
                lblData.Text = "Data de Vencimento";
                lblDataEntre.Text = "Data de Pagamento";
                
                gbConta.Enabled = true;
                foreach (Control item in gbFormaPag.Controls)
                {
                    if (operacao != (char)BLL.Operacao.Consulta)
                    {
                        item.Enabled = true;
                    }
                    
                }
                this.cbSituacao.Items.Clear();
                this.cbSituacao.Items.Add("Paga");
                this.cbSituacao.Items.Add("Nao paga");

               
               
            }
            else
            {
                
                lblData.Text = "Data para Recebimento";
                lblDataEntre.Text = "Data de Recebimento";
                gbConta.Enabled = true;
                foreach (Control item in gbFormaPag.Controls)
                {
                    if (operacao != (char)BLL.Operacao.Consulta)
                    {
                        item.Enabled = true;
                    }
                }
                this.cbSituacao.Items.Clear();
                this.cbSituacao.Items.Add("Recebida");
                this.cbSituacao.Items.Add("Nao recebida");


                
            }
            if (operacao!=5)
            {
                this.cbSituacao.Enabled = true;
            }
            this.cbSituacao.SelectedIndex = 0;
            
        }

        private void LeaveMaisculo(object sender, EventArgs e)
        {
            var b = (TextBox)sender;
            b.Text = b.Text.ToUpper();
        }
        private void Limpar(object sender, EventArgs e)
        {
            try
            {
                this.chkAtivo.Checked = true;

                foreach (Control item in gbConta.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = string.Empty;
                    }
                }
                this.dtpData.Value = DateTime.Now;
                this.cbSituacao.SelectedIndex = 0;
                this.dtpEntregue.Value = Convert.ToDateTime(DateTime.Now.ToString().Substring(0,10));
                this.txtValorTotal.Text = "R$0";
                this.dgvFormasPags.Rows.Clear();
                this.erro.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void CarregarCBFormaPag()
        {
            try
            {
                this.erro.SetError(this.cbFormaPag, String.Empty);

                BLL.FormaPagamento cont = new BLL.FormaPagamento();

              
                this.cbFormaPag.DataSource = cont.ListarComboBox().Tables[0];
                this.cbFormaPag.DisplayMember = "FORMA_PAGAMENTO";
                this.cbFormaPag.ValueMember = "ID_FORMA_PAGAMENTO";
                this.cbFormaPag.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                this.erro.SetError(this.cbFormaPag, "Nenhuma Forma de Pagamento cadastrada!");
                MessageBox.Show(ex.Message);
               



            }
        }
        private void CarregarCampos(object sender, EventArgs e)
        {
            try
            {
                if (operacao == 0)
                {

                    this.dtpData.MinDate = DateTime.Now.AddYears(-10);
                    this.dtpEntregue.MinDate = DateTime.Now.AddYears(-10);
                    this.dtpDataLanc.Value = System.DateTime.Now;
                }
                else
                {
                   // this.dtpData.Enabled = false;
                }
                this.txtCodigo.Enabled = false;
                CarregarCBFormaPag();
                //MessageBox.Show("codigo; " + codigo);
                if (operacao != Convert.ToByte(BLL.Operacao.Inclusao))
                {
                    BLL.Contas medi = new BLL.Contas();
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    medi.ID_CONTAS = codigo;
                    dr = medi.Consultar();
                    // MessageBox.Show("teste CarregarCampo");
                    if (dr.Read())
                    {

                        this.txtCodigo.Text = Convert.ToString(codigo);
                        this.txtCodigo.Enabled = false;
                        if (dr["TIPO_CONTA"].ToString() == "Pagar")
                        {
                            this.rbPagar.Checked = true;

                        }
                        else
                        {

                            this.rbReceber.Checked = true;
                        }
                        this.txtDesc.Text = dr["DESCRICAO"].ToString();
                        if (dr["ATIVO"].ToString() == "1")
                        {
                            this.chkAtivo.Checked = true;
                        }
                        else
                        {
                            this.chkAtivo.Checked = false;
                        }
                       
                        this.dtpDataLanc.Value = Convert.ToDateTime(dr["DATA_LANCAMENTO"]);
                        this.txtValorTotal.Text = "R$"+ dr["VALOR_TOTAL"].ToString();

                        idDataConta = Convert.ToInt32(dr["ID_DATA_CONTA"]);
                        this.dtpData.Value = Convert.ToDateTime(dr["DATA_CONTA"]);
                        
                        //this.cbFormaPag.SelectedValue = idFormaPagamento;
                        this.cbSituacao.Text = dr["SITUACAO"].ToString();
                        this.txtDepart.Text = dr["DEPARTAMENTO"].ToString();
                        if (dr["DATA_ENTREGUE"].ToString() == "01/01/0001 00:00:00" || dr["DATA_ENTREGUE"].ToString()==string.Empty)
                        {
                            this.dtpEntregue.Visible = false;
                        }
                        else
                        {
                            this.dtpEntregue.Visible = true;
                            this.dtpEntregue.Value = Convert.ToDateTime(dr["DATA_ENTREGUE"]);
                        }

                        CarregarGridPagamentos();
                    }
                    this.gbConta.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }

        private bool ChecarExisteGrid(int idx)
        {
            bool ok = true;
            

                    for (int i = 0; i < dgvFormasPags.Rows.Count; i++)
                    {
                        if (Convert.ToString(dgvFormasPags.Rows[i].Cells["FORMA_PAG"].Value) == cbFormaPag.Text.Trim())
                        {
                            ok = false;
                        }
                    }






            return ok;
        }

        private void AdicionarForma(object sender, EventArgs e)
        {
            if (this.txtValor.Text==string.Empty)
            {
                this.erro.SetError(txtValor, "Digite o valor!");
                txtValor.Focus();
                return;
            }
            else
            {
                this.erro.SetError(txtValor, string.Empty);
            }
            if (dgvFormasPags.ColumnCount == 0)
            {
                this.dgvFormasPags.Columns.Add("FORMA_PAG", "Forma de Pagamento");
                this.dgvFormasPags.Columns.Add("VALOR", "Valor");

            }
            var index = dgvFormasPags.Rows.Add();

            if (this.dgvFormasPags.RowCount > 1)
            {
                if (ChecarExisteGrid(index))
                {
                 

                    this.dgvFormasPags.Rows[index].Cells["FORMA_PAG"].Value = this.cbFormaPag.Text.Trim();
                    this.dgvFormasPags.Rows[index].Cells["VALOR"].Value = this.txtValor.Text.ToString();



                }
                else
                {
                    this.dgvFormasPags.Rows.Remove(this.dgvFormasPags.Rows[index]);
                    return;
                }
            }
            else
            {

                this.dgvFormasPags.Rows[index].Cells["FORMA_PAG"].Value = this.cbFormaPag.Text.Trim();
                this.dgvFormasPags.Rows[index].Cells["VALOR"].Value = this.txtValor.Text.ToString();
               

            }

            double valor = Convert.ToDouble(this.txtValorTotal.Text.Replace("R$",""));
            this.txtValorTotal.Text = "R$" + Convert.ToString(valor + Convert.ToDouble(this.txtValor.Text));

        }

        private void RemoverForma(object sender, EventArgs e)
        {
           
            if (this.dgvFormasPags.CurrentRow == null || Convert.ToString(this.dgvFormasPags.CurrentRow.Cells[0].Value) == string.Empty)
            {
                return;
            }
            else
            {
                foreach (DataGridViewRow linha in dgvFormasPags.Rows)
                {
                    if (linha.Selected)
                    {
                        double valor = Convert.ToDouble(this.txtValorTotal.Text.Replace("R$", ""));
                        this.txtValorTotal.Text ="R$"+ Convert.ToString(valor - Convert.ToDouble(linha.Cells["VALOR"].Value));
                        this.dgvFormasPags.Rows.Remove(linha);

                    }
                }



              

            }
        }
        public void CarregarGridPagamentos() {
            BLL.Contas c = new BLL.Contas();
            c.ID_CONTAS = Convert.ToInt32(txtCodigo.Text);
            DataSet ds = new DataSet();
            ds =c.ConsultarFormas();
            if (dgvFormasPags.ColumnCount == 0)
            {
                this.dgvFormasPags.Columns.Add("FORMA_PAG", "Forma de Pagamento");
                this.dgvFormasPags.Columns.Add("VALOR", "Valor");

            }
            



            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    var index = dgvFormasPags.Rows.Add();
                    this.dgvFormasPags.Rows[index].Cells["FORMA_PAG"].Value = dr["FORMA_PAGAMENTO"].ToString();
                    this.dgvFormasPags.Rows[index].Cells["VALOR"].Value = dr["VALOR"].ToString();

                }
            }
        }


        private void Salvar(object sender, EventArgs e)
        {

            {




                try
                {


                    if (this.txtDesc.Text == String.Empty)
                    {
                        this.erro.SetError(this.lblDescricao, "A descrição é obrigatória");
                        this.txtDesc.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.lblDescricao, String.Empty);
                    }

                   

                    if (this.txtValorTotal.Text == "R$0")
                    {
                        this.erro.SetError(this.txtValor, "É obrigatório informar o valor!");
                        this.txtDesc.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.txtValor, String.Empty);
                    }

                    //if (this.txtValor.Text != string.Empty)
                    //{
                    //    if (txtValor.Text.IndexOf(",") == txtValor.Text.Length - 1)
                    //    {
                    //        this.txtValor.Text = this.txtValor.Text.Substring(0, txtValor.Text.Length - 1);
                    //    }
                    //}
                    if (!rbPagar.Checked && !rbReceber.Checked)
                    {
                        this.erro.SetError(this.rbPagar, "Informe o tipo da Conta");
                        this.erro.SetError(this.rbReceber, "Informe o tipo da Conta");
                        this.rbPagar.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.rbPagar, String.Empty);
                        this.erro.SetError(this.rbReceber, String.Empty);
                    }

                    

                    //FIM DOS TRATAMENTOS DE ERROS



                    if (MessageBox.Show("Deseja Salvar?", "ATENÇÃO ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; }
                    BLL.Contas c = new BLL.Contas();
                    BLL.Log log = new BLL.Log();
                    btnSalvar.Cursor = Cursors.AppStarting;
                    c.Descricao = txtDesc.Text.Trim();
                    if (rbPagar.Checked)
                    {
                        if (this.cbSituacao.Text == "Paga")
                        {
                            c.Data_Entregue = dtpEntregue.Value.ToString().Substring(0, 10);
                        }
                        else
                        {
                            c.Data_Entregue = "01/01/0001 00:00";
                        }
                       
                        c.Valor_Total = Convert.ToDouble(txtValorTotal.Text.Trim().Replace("R$",""));
                        c.Tipo_Conta = "Pagar";
                        c.TipoData = "Vencimento";
                    }
                    else
                    {
                        if (this.cbSituacao.Text=="Recebida")
                        {
                            c.Data_Entregue = dtpEntregue.Value.ToString().Substring(0, 10);
                        }
                        else
                        {
                            c.Data_Entregue = "01/01/0001 00:00";
                        }

                        c.Valor_Total = Convert.ToDouble(txtValorTotal.Text.Trim().Replace("R$", ""));
                        c.Tipo_Conta = "Receber";
                        c.TipoData = "Recebimento";
                    }
                    c.Data = this.dtpData.Value.ToString().Substring(0, 10);
                    c.Departamento = txtDepart.Text.Trim().ToUpper();
                    c.Situacao = cbSituacao.Text;
                    c.ID_Forma_Pagamento = Convert.ToInt32(cbFormaPag.SelectedValue);

                    log.ID_FUNC = idFunc;
                    log.ID_MODIFICADO = codigo;
                    log.TABELA_LOG = "CONTAS";


                    c.Ativo = 0;
                    if (this.chkAtivo.Checked)
                    {
                        c.Ativo = 1;
                    }

                    switch (operacao)
                    {
                        case 0: //inclusao
                            c.Contas_crud('I');
                            foreach (DataGridViewRow linha in dgvFormasPags.Rows)
                            {
                                c.Forma_Pagamento = linha.Cells["FORMA_PAG"].Value.ToString();
                                c.IncluirFormaPag(Convert.ToDouble(linha.Cells["VALOR"].Value), 'I');
                            }
                            Oracle.DataAccess.Client.OracleDataReader dr;
                            dr = c.ConsultarValorMaximo();
                            log.TIPO_LOG = "INSERÇÃO";
                            if (dr.Read())
                            {
                                log.ID_MODIFICADO = Convert.ToInt32(dr["ID"]);
                            }
                            log.Log_crud('I');
                            break;
                        case 1: //alteracao
                            c.ID_CONTAS = codigo;
                            c.ID_DATACONTA = idDataConta;
                            c.Contas_crud('A');
                            c.ExcluirFormaPag();
                            foreach (DataGridViewRow linha in dgvFormasPags.Rows)
                            {
                                c.Forma_Pagamento = linha.Cells["FORMA_PAG"].Value.ToString();
                                c.IncluirFormaPag(Convert.ToDouble(linha.Cells["VALOR"].Value), 'A');
                            }
                            log.TIPO_LOG = "ALTERAÇÃO";
                            log.Log_crud('A');
                            break;
                    }



                    btnSalvar.Cursor = Cursors.Hand;

                    MessageBox.Show("Operação realizada com sucesso!");



                  
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    throw ex;

                }
            }
        }

        private void cbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.cbSituacao.Text=="Recebida" | this.cbSituacao.Text == "Paga" && operacao!=5
            if (this.cbSituacao.Text=="Recebida" || this.cbSituacao.Text == "Paga" )
            {
                this.dtpEntregue.Visible = true;
                this.lblDataEntreEstrela.Visible = true;
                this.lblDataEntre.Visible = true;
            }
            else
            {
                this.dtpEntregue.Visible = false;
                this.lblDataEntre.Visible = false;
                this.lblDataEntreEstrela.Visible = false;
               
            }
            if (this.cbSituacao.Text == "Recebida" || this.cbSituacao.Text == "Paga")
            {
                this.chkAtivo.Checked = false;
                this.chkAtivo.Enabled = false;
            }
            else
            {
                this.chkAtivo.Checked = true;
                this.chkAtivo.Enabled = true;

            }
        }

        private void MudarSituacao(object sender, EventArgs e)
        {
            
                if (dtpEntregue.Value > dtpData.Value || dtpEntregue.Value == dtpData.Value)
                {
                    if (this.rbPagar.Checked)
                    {
                        this.cbSituacao.Text = "Recebida";
                    }
                    else
                    {
                        this.cbSituacao.Text = "Paga";
                    }
                }
                else
                {
                    if (this.rbPagar.Checked)
                    {
                        this.cbSituacao.Text = "Nao recebida";
                    }
                    else
                    {
                        this.cbSituacao.Text = "Nao paga";
                    }
                }

            
        }

    

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            var b = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)

            {

                e.Handled = true;

            }
            if (e.KeyChar == (char)44)
            {
           
                if (b.Text == string.Empty)
                { e.Handled = true; }

                if (b.Text.IndexOf(",") > 0 || b.Text.IndexOf(",") == 0)
                {
                    e.Handled = true;
                }
            }
            if (e.KeyChar == (char)48)
            {
                
                if (b.Text.Replace("0", "") == string.Empty && b.Text.Length >= 1)
                {
                    e.Handled = true;
                }
            }
        }


        ////////////////////////////////////
    }
}
