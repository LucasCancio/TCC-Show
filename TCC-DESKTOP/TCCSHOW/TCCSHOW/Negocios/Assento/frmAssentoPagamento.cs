using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Assento
{
    public partial class frmAssentoPagamento : Modelos.ModeloPadrao
    {
       // 
        public frmAssentoPagamento()
        {
           
            InitializeComponent();
            this.dgvFormasDePagar.DefaultCellStyle.BackColor = Color.LightGray;
            this.dgvFormasDePagar.AlternatingRowsDefaultCellStyle.BackColor =
  Color.Silver;
            this.cbTipoDePagamento.SelectedIndex = 0;
            txtValorTotal.Text = String.Format("{0:c}", Convert.ToDouble(txtValorTotal.Text.Replace("R$","").Replace("R$","")));
            txtValorPago.Text = String.Format("{0:c}", Convert.ToDouble(txtValorPago.Text.Replace("R$","").Replace("R$", "")));
            txtValorRestante.Text = String.Format("{0:c}", Convert.ToDouble(txtValorRestante.Text.Replace("R$","").Replace("R$", "")));
            txtDesconto.Text = String.Format("{0:c}", Convert.ToDouble(txtDesconto.Text.Replace("R$","").Replace("R$", "")));
            txtValorTroco.Text = String.Format("{0:c}", Convert.ToDouble(txtValorTroco.Text.Replace("R$","").Replace("R$", "")));

        }




        public bool retornar = true;


        public string Evento;

        public double ValorTotalDGV;

        public string DataDoEvento;
        public string HorarioDoEvento;

        public int NAssento;

        public int Id_Evento, Id_Cliente, Id_Pagamento, Id_EI, Id_Venda, Id_Assento, Id_Conta;

        public string CpfCli, NomeCli;

        public string[] Assento_Numero = new string[170];
        public string[] Assento_Fileira = new string[170];
        public double[] Assento_Valor = new double[170];
        public string[] Assento_Tipo = new string[170];
        public string[] Assento_Setor = new string[170];
        private void CarregarCBFormaPag(object o, EventArgs e)
        {
            try
            {
                this.erro.SetError(this.cbTipoDePagamento, String.Empty);

                BLL.FormaPagamento cont = new BLL.FormaPagamento();


                this.cbTipoDePagamento.DataSource = cont.ListarComboBox().Tables[0];
                this.cbTipoDePagamento.DisplayMember = "FORMA_PAGAMENTO";
                this.cbTipoDePagamento.ValueMember = "ID_FORMA_PAGAMENTO";
                this.cbTipoDePagamento.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                this.erro.SetError(this.cbTipoDePagamento, "Nenhuma Forma de Pagamento cadastrada!");
                MessageBox.Show(ex.Message);




            }
        }

        private void LeaveMaisculo(object sender, EventArgs e)
        {
            var b = (TextBox)sender;
            b.Text = b.Text.ToUpper();
        }
        private void Salvar(object sender, EventArgs e)
        {
            

            if (this.dgvFormasDePagar.RowCount == 0)
            {
                return;
            }

            try
            {
                //MessageBox.Show(this.cbSexo.SelectionLength.ToString());
                //if (this.cbEstado2.SelectedItem.ToString() != String.Empty) { MessageBox.Show("Estado: " + cbEstado2.SelectedItem.ToString()); return; }
                //else { MessageBox.Show("Estado Vazio"); return; }

                if (this.txtValorRestante.Text!= "R$ 0,00")
                {
                    this.erro.SetError(this.txtValorRestante, "Dinheiro insuficiente");
                    this.txtValorRestante.Focus();
                    return;
                }
                else
                {
                    this.erro.SetError(this.txtValorRestante, string.Empty);
                }



             


                //FIM DOS TRATAMENTOS DE ERROS

              
             



                if (MessageBox.Show("Deseja Salvar?", "ATENÇÃO ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; }
                BLL.Contas cont = new BLL.Contas();
                BLL.Ingresso func = new BLL.Ingresso();
                BLL.Assento ass = new BLL.Assento();
                BLL.Desconto dsc = new BLL.Desconto();
                Oracle.DataAccess.Client.OracleDataReader dr;
                func.ID_CLIENTE = Id_Cliente;
                if (Id_Cliente == 0)
                {
                    func.Ativo = 0;
                }
                else
                {
                    func.Ativo = 1;
                }
                func.ID_EVENTO = Id_Evento;
                dr = func.ConsultarPorCliente();
                if (dr.Read())
                {


                    Id_EI = Convert.ToInt32(dr["ID_EI"]);
                    Id_Venda = Convert.ToInt32(dr["ID_VENDA"]);
                    Id_Pagamento = Convert.ToInt32(dr["ID_PAGAMENTO"]);

                }
                func.Situacao = "Pago";
                btnSalvar.Cursor = Cursors.AppStarting;
                func.Preco_Total = this.txtValorTotal.Text.Replace("R$", "").Replace(" ", "");
                func.ID_EI = Id_EI;
                func.ID_VENDA = Id_Venda;
                func.ID_PAGAMENTO = Id_Pagamento;
                cont.ID_CONTAS = Id_Conta;
                func.Desconto = txtDesconto.Text.Replace("R$","").Replace(" ","");
                func.Preco_Total_Pago = this.txtValorPago.Text.Replace("R$", "").Replace(" ", "");
                func.Troco = this.txtValorTroco.Text.Replace("R$", "").Replace(" ", "");
                cont.Valor_Total = Convert.ToDouble(this.txtValorTotal.Text.Replace("R$", "").Replace(" ", ""));
                cont.Tipo_Conta = "Receber";
                cont.Ativo = 1;
                cont.Descricao = "Ingresso de " + NAssento + " assento(s), Vendido por: " + Funcionario;
                cont.Data = DataDoEvento;
                cont.Departamento = "BILHETERIA";
                cont.Situacao = "Recebida";
                cont.Data_Entregue = DateTime.Now.ToString().Substring(0, 10);

                // MessageBox.Show("teste Salvar"+ operacao);
                switch (operacao)
                {
                    case 0: //inclusao

                        
                        func.IncluirVendaIngresso();
                        int n = this.dgvFormasDePagar.RowCount;
                        int contagem = 1;
                        while (n != n - n)//pagamento
                        {
                            string Tipo_Pag = Convert.ToString(this.dgvFormasDePagar.Rows[this.dgvFormasDePagar.Rows.Count - contagem].Cells[0].Value);
                            string Valor = Convert.ToString(this.dgvFormasDePagar.Rows[this.dgvFormasDePagar.Rows.Count - contagem].Cells[1].Value);
                            if (Tipo_Pag != string.Empty)
                            {
                                func.IncluirPagamento(Tipo_Pag, Valor);
                            }

                            contagem = contagem + 1;
                            n = n - 1;
                        }

                        func.IncluirEventoIngresso();


                        n = NAssento;
                        contagem = 1;
                       
                        while (n != n - n)//assento
                        {
                            ass.Assento_Numer = Assento_Numero[n].Replace(" ", "");
                            ass.Assento_Fileira = Assento_Fileira[n];

                            dr = ass.ConsultarAssento();
                            if (dr.Read())
                            {


                                Id_Assento = Convert.ToInt32(dr["ID_ASSENTO"]);


                            }
                            func.IncluirAssentoCliente(Id_Assento);
                            func.IncluirItemVenda(Id_Assento);

                           

                            n = n - 1;
                        }
                        
                      




                        cont.Data = Convert.ToString(DateTime.Now).Substring(0, 10);
                        cont.TipoData = "Recebimento";
                        

                        cont.Contas_crud('I');
                        foreach (DataGridViewRow linha in dgvFormasDePagar.Rows)
                        {
                            cont.Forma_Pagamento = linha.Cells["FORMA"].Value.ToString();
                            cont.IncluirFormaPag(Convert.ToDouble(linha.Cells["VALOR"].Value.ToString()), 'I');
                        }
                        cont.IncluirVenda();
                        if (txtCodPromo.Text!=string.Empty)
                        {
                            dsc.ID_DESCONTO = IdDesconto;
                            dsc.ID_CLIENTE = Id_Cliente;
                            dsc.Descontos_crud('U');
                        }

                        Oracle.DataAccess.Client.OracleDataReader dr2;
                        dr2 = ass.ConsultarValorMaximo();
                        if (dr2.Read())
                        {
                            Id_Venda = Convert.ToInt32(dr2["ID"]);
                        }

                        if (MessageBox.Show("Gostaria de Imprimir os Ingressos?!", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            TipoDoc = "Ingresso";
                            Imprimir();

                        }

                        if (MessageBox.Show("Gostaria de Imprimir o Recibo?!", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {

                            TipoDoc = "Recibo";
                            Imprimir();
                        }


                        break;
                    
                }



                btnSalvar.Cursor = Cursors.Hand;

                MessageBox.Show("Operação realizada com sucesso!");



              

                retornar = false;
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void PressDelet(object sender, KeyEventArgs e)
        {
            if (this.dgvFormasDePagar.Rows.Count > 0)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    try
                    {
                        
                            this.pbAddValor.Enabled = true;
                            this.btnAddValor.Enabled = true;
                            if (this.dgvFormasDePagar.CurrentRow == null || Convert.ToString(this.dgvFormasDePagar.CurrentRow.Cells[0].Value) == string.Empty)
                            {
                                return;
                            }
                            else
                            {
                                foreach (DataGridViewRow linha in dgvFormasDePagar.Rows)
                                {
                                    if (linha.Selected)
                                    {
                                        this.erro.SetError(this.txtValorRestante, string.Empty);
                                        if (this.txtValorTotal.Text.Replace("R$", "") == string.Empty || this.txtValorTotal.Text.Replace("R$", "") == "0")
                                        {
                                            this.erro.SetError(this.txtValorTotal, "Nenhum Assento selecionado!");
                                            this.Focus();
                                            return;
                                        }

                                        BLL.Evento func = new BLL.Evento();
                                        //NFormR = NFormR + 1;
                                        ValorTotalDGV = ValorTotalDGV - Convert.ToDouble(linha.Cells[1].Value);


                                        this.txtValorPago.Text = ValorTotalDGV.ToString();

                                        this.txtValorRestante.Text = Convert.ToString(Convert.ToDouble(txtValorTotal.Text.Replace("R$","")) - (Convert.ToDouble(txtValorPago.Text.Replace("R$","")) + Convert.ToDouble(txtDesconto.Text.Replace("R$",""))));



                                        if ((Convert.ToDouble(txtValorPago.Text.Replace("R$","")) + Convert.ToDouble(txtDesconto.Text.Replace("R$","")))
                                            - Convert.ToDouble(txtValorTotal.Text.Replace("R$","")) <= 0)
                                        {
                                            this.txtValorTroco.Text = "0";
                                        }
                                        else
                                        {
                                            this.txtValorTroco.Text = Convert.ToString(Convert.ToDouble(txtValorPago.Text.Replace("R$","")) - Convert.ToDouble(txtValorTotal.Text.Replace("R$","")));
                                            this.txtValorRestante.Text = "0";
                                        }


                                        this.dgvFormasDePagar.Rows.Remove(linha);

                                    }
                                }




                                if (this.dgvFormasDePagar.RowCount == 0)
                                {


                                    this.pbExcluirValor.Enabled = false;
                                    this.btnExcluirValor.Enabled = false;
                                }

                            }

                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private bool ChecarExisteGrid(int idx, string tipo)
        {
            bool ok = true;
            switch (tipo)
            {
                case "Ingresso":



                    for (int i = 0; i < dgvFormasDePagar.Rows.Count; i++)
                    {
                        if (Convert.ToString(dgvFormasDePagar.Rows[i].Cells["FORMA"].Value) == cbTipoDePagamento.Text.Trim())
                        {
                            ok = false;
                        }
                    }





                    break;



            }


            return ok;
        }
        

        private void AdicionarValor(object sender, EventArgs e)
        {

            {
                try
                {
                    this.erro.SetError(this.txtValorRestante, string.Empty);
                    if (this.txtValorTotal.Text.Replace("R$", "") == string.Empty || this.txtValorTotal.Text.Replace("R$", "") == "0")
                    {
                        this.erro.SetError(this.txtValorTotal, "Nenhum Assento selecionado!");
                        this.Focus();
                        return;
                    }

                    if (txtValor.Text.IndexOf(",")==0)
                    {
                        this.erro.SetError(this.txtValor, "Digite o valor corretamente!");
                        this.Focus();
                        return;
                    }

                    BLL.Artista arti = new BLL.Artista();


                    if (this.txtValor.Text.Replace("0","").Replace(",","").Trim()==string.Empty)
                    {
                        this.erro.SetError(this.txtValor, "Digite um valor!");
                        this.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.txtValor, string.Empty);
                    }

                    if (this.txtValor.Text.Substring(txtValor.Text.Replace("R$","").Replace(" ","").Length-1)==",")
                    {

                        this.erro.SetError(this.txtValor, "Digite o valor corretamente!");
                        this.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.txtValor, string.Empty);
                    }

                    if (dgvFormasDePagar.ColumnCount == 0)
                    {

                        this.dgvFormasDePagar.Columns.Add("FORMA", "Forma");
                        this.dgvFormasDePagar.Columns.Add("VALOR", "Valor");

                    }
                    var index = dgvFormasDePagar.Rows.Add();



                    if (this.dgvFormasDePagar.RowCount > 1)
                    {
                        if (ChecarExisteGrid(index, "Ingresso"))
                        {
                            ValorTotalDGV = Convert.ToDouble(ValorTotalDGV.ToString()) + Convert.ToDouble(this.txtValor.Text.Replace("R$", "").ToString());

                            this.dgvFormasDePagar.Rows[index].Cells["FORMA"].Value = this.cbTipoDePagamento.Text.Trim();
                            this.dgvFormasDePagar.Rows[index].Cells["VALOR"].Value = this.txtValor.Text.Replace("R$", "");



                        }
                        else
                        {
                            this.dgvFormasDePagar.Rows.Remove(this.dgvFormasDePagar.Rows[index]);
                            return;
                        }
                    }
                    else
                    {

                        this.dgvFormasDePagar.Rows[index].Cells["FORMA"].Value = this.cbTipoDePagamento.Text.Trim();
                        this.dgvFormasDePagar.Rows[index].Cells["VALOR"].Value = this.txtValor.Text.ToString().Replace("R$","");
                        ValorTotalDGV = Convert.ToDouble(ValorTotalDGV.ToString()) + Convert.ToDouble(this.txtValor.Text.ToString().Replace("R$",""));
                        if (Convert.ToDouble(txtValorTroco.Text.Replace("R$","").Replace("R$", "").ToString()) > 0)
                        {
                            this.txtValorTroco.Text = Convert.ToDouble(txtValorTroco.Text.Replace("R$","").Replace("R$", "") + ValorTotalDGV).ToString();
                        }

                    }
                 


                    this.pbExcluirValor.Enabled = true;
                    this.btnExcluirValor.Enabled = true;

                    if (this.txtDesconto.Text == "R$0,0")
                    {
                        double total = Convert.ToDouble(txtValorTotal.Text.Replace("R$","").Replace("R$", "").ToString()) - Convert.ToDouble(txtValorRestante.Text.Replace("R$","").Replace("R$", "").ToString());
                        if (this.txtValorRestante.Text.Replace("R$", "").ToString() == txtValorTotal.Text.ToString().Replace("R$","") || Convert.ToDouble(this.txtValorRestante.Text.Replace("R$", "").ToString()) == Convert.ToDouble(this.txtValorTotal.Text.Replace("R$", "").ToString()))
                        {
                            this.txtValorRestante.Text = Convert.ToDouble(Convert.ToDouble(txtValorTotal.Text.Replace("R$","").Replace("R$", "")) - Convert.ToDouble(ValorTotalDGV.ToString())).ToString();
                            if (Convert.ToDouble(this.txtValorRestante.Text.ToString().Replace("R$",""))<=0)
                            {
                                this.txtValorRestante.Text = "0";
                                txtValorTroco.Text = Convert.ToString(Convert.ToDouble(ValorTotalDGV.ToString()) -Convert.ToDouble(txtValorTotal.Text.Replace("R$","")));
                                btnAddValor.Enabled = false;
                                pbAddValor.Enabled = false;
                            }
                        }
                        else
                        {
                            if (Convert.ToDouble(Convert.ToDouble(ValorTotalDGV.ToString()) - Convert.ToDouble(txtValorTotal.Text.Replace("R$","").Replace("R$", "").ToString())) > 0 )
                            {
                                this.txtValorTroco.Text = Convert.ToDouble(Convert.ToDouble(ValorTotalDGV.ToString()) - Convert.ToDouble(txtValorTotal.Text.Replace("R$","").Replace("R$", "").ToString())).ToString();
                            }
                            else
                            {
                                this.txtValorRestante.Text = Convert.ToString( Convert.ToDouble(txtValorTotal.Text.Replace("R$","").Replace("R$", "").ToString()) - Convert.ToDouble(Convert.ToDouble(ValorTotalDGV.ToString())) );
                            }
                         

                            if (Convert.ToDouble(this.txtValorRestante.Text.ToString().Replace("R$","")) < 0 || Convert.ToDouble(this.txtValorTroco.Text.ToString().Replace("R$",""))>0)
                            {
                                this.txtValorRestante.Text = "0";
                                txtValorTroco.Text = Convert.ToString(Convert.ToDouble(ValorTotalDGV.ToString()) - Convert.ToDouble(txtValorTotal.Text.Replace("R$","").ToString()));
                                btnAddValor.Enabled = false;
                                pbAddValor.Enabled = false;
                            }
                            
                        }

                    }
                    else
                    {
                        Descontar();
                    }
                    this.txtValorPago.Text = ValorTotalDGV.ToString();
                    this.dgvFormasDePagar.AutoResizeColumn(0);
                    this.dgvFormasDePagar.AutoResizeColumn(1);

                    txtValorPago.Text = String.Format("{0:c}", Convert.ToDouble(txtValorPago.Text.Replace("R$", "").Replace("R$", "")));
                    txtValorRestante.Text = String.Format("{0:c}", Convert.ToDouble(txtValorRestante.Text.Replace("R$", "").Replace("R$", "")));
                    txtDesconto.Text = String.Format("{0:c}", Convert.ToDouble(txtDesconto.Text.Replace("R$", "").Replace("R$", "")));
                    txtValorTroco.Text = String.Format("{0:c}", Convert.ToDouble(txtValorTroco.Text.Replace("R$", "").Replace("R$", "")));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }

            }
        }

        private void ExcluirPagamento(object sender, EventArgs e)
        {
            this.pbAddValor.Enabled = true;
            this.btnAddValor.Enabled = true;
            if (this.dgvFormasDePagar.CurrentRow == null || Convert.ToString(this.dgvFormasDePagar.CurrentRow.Cells[0].Value) == string.Empty)
            {
                return;
            }
            else
            {
                foreach (DataGridViewRow linha in dgvFormasDePagar.Rows)
                {
                    if (linha.Selected)
                    {
                        this.erro.SetError(this.txtValorRestante, string.Empty);
                        if (this.txtValorTotal.Text.Replace("R$", "") == string.Empty || this.txtValorTotal.Text.Replace("R$", "") == "0")
                        {
                            this.erro.SetError(this.txtValorTotal, "Nenhum Assento selecionado!");
                            this.Focus();
                            return;
                        }

                        BLL.Evento func = new BLL.Evento();
                        //NFormR = NFormR + 1;
                        ValorTotalDGV = ValorTotalDGV - Convert.ToDouble(linha.Cells[1].Value);


                        this.txtValorPago.Text = ValorTotalDGV.ToString();

                        this.txtValorRestante.Text = Convert.ToString(Convert.ToDouble(txtValorTotal.Text.Replace("R$","")) - (Convert.ToDouble(txtValorPago.Text.Replace("R$","")) + Convert.ToDouble(txtDesconto.Text.Replace("R$",""))));



                        if ((Convert.ToDouble(txtValorPago.Text.Replace("R$","")) + Convert.ToDouble(txtDesconto.Text.Replace("R$","")))
                            - Convert.ToDouble(txtValorTotal.Text.Replace("R$","")) <= 0)
                        {
                            this.txtValorTroco.Text = "0";
                        }
                        else
                        {
                            this.txtValorTroco.Text = Convert.ToString(Convert.ToDouble(txtValorPago.Text.Replace("R$","")) - Convert.ToDouble(txtValorTotal.Text.Replace("R$","")));
                            this.txtValorRestante.Text = "0";
                        }


                        this.dgvFormasDePagar.Rows.Remove(linha);

                    }
                }

            


                if (this.dgvFormasDePagar.RowCount == 0)
                {
               

                    this.pbExcluirValor.Enabled = false;
                    this.btnExcluirValor.Enabled = false;
                }

                txtValorPago.Text = String.Format("{0:c}", Convert.ToDouble(txtValorPago.Text.Replace("R$", "").Replace("R$", "")));
                txtValorRestante.Text = String.Format("{0:c}", Convert.ToDouble(txtValorRestante.Text.Replace("R$", "").Replace("R$", "")));
                txtDesconto.Text = String.Format("{0:c}", Convert.ToDouble(txtDesconto.Text.Replace("R$", "").Replace("R$", "")));
                txtValorTroco.Text = String.Format("{0:c}", Convert.ToDouble(txtValorTroco.Text.Replace("R$", "").Replace("R$", "")));

            }
        }
        private void Cancelar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cancelar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) {return; }
            retornar = true;
            this.Close();
        }


        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)

            {
                var b = (TextBox)sender;
                if (b.Name== "txtValorDesconto")
                {
                    if (e.KeyChar != (char)37)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
                

            }
            if (e.KeyChar == (char)44)
            {
                var b = (TextBox)sender;
                if (b.Text.IndexOf(",") > 0 ||b.Text.IndexOf(",") == 0)
                {
                    
                        e.Handled = true;


                }
                else
                {
                    
                    if (b.Text.Replace(".", "") == string.Empty)
                    {
                        e.Handled = true;
                    }
                }
                if (b.Text.Length == 4)
                {
                    e.Handled = true;
                }
            }
            if (e.KeyChar==(char)48)
            {
                var b = (TextBox)sender;
                if (b.Text.Replace("0", "") == string.Empty && b.Text.Replace("R$","").Replace("R$","").Replace(" ","").Length>=1)
                {
                    e.Handled = true;
                }
            }

            var txt = (TextBox)sender;
            switch (txt.Name)
            {
                case "txtValorDesconto":
                    this.txtCodPromo.Text = string.Empty;
                    this.txtPorct.Text = "0%";

                    break;
                
            }

            
        }

        private void Descontar()
        {
            if (this.txtValorDesconto.Text == string.Empty)
            {
                return;
            }

            if (this.txtValorRestante.Text.Replace("R$", "") != "0")
            {
                double descont = Convert.ToDouble(this.txtValor.Text.Replace("R$", "").ToString());
                double total = Convert.ToDouble(this.txtValorTotal.Text.Replace("R$", "").ToString());
                double total2 = Convert.ToDouble(txtValorTotal.Text.Replace("R$","").Replace("R$", "").ToString()) - Convert.ToDouble(txtValorRestante.Text.Replace("R$","").Replace("R$", "").ToString());
                descont = descont + total2;
                total = total - descont;
                this.txtValorRestante.Text =  total.ToString();
            }
            else
            {
                double descont = Convert.ToDouble(this.txtValor.Text.Replace("R$", "").ToString());
                double total = Convert.ToDouble(this.txtValorTotal.Text.Replace("R$", "").ToString());

                total = total - descont;
                this.txtValorRestante.Text =  total.ToString();
            }
          

        }



        private void dgvFormasDePagar_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (this.dgvFormasDePagar.Rows.Count<=0)
            {
               // this.pnDesconto.Enabled = false;
                this.txtValorDesconto.Text = "0";
            }
            else
            {
               // this.pnDesconto.Enabled = true;
            }
        }

        private void dgvFormasDePagar_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dgvFormasDePagar.Rows.Count <= 0)
            {
               // this.pnDesconto.Enabled = false;
                this.txtValorDesconto.Text = "0";
            }
            else
            {
               // this.pnDesconto.Enabled = true;
            }
        }


  
        private void Limpar(object sender, EventArgs e)
        {
            this.dgvFormasDePagar.Rows.Clear();
            this.txtValor.Text = "0";
            this.txtValorPago.Text = "R$ 0,00";
            this.txtValorDesconto.Text = "0";
            this.txtDesconto.Text = "R$ 0,00";
            this.txtValorTroco.Text = "R$ 0,00";
            this.txtValorRestante.Text = this.txtValorTotal.Text;
            this.ValorTotalDGV = 0;
            this.btnAddValor.Enabled = true;
            this.pbAddValor.Enabled = true;
            this.pbExcluirValor.Enabled = false;
            this.btnExcluirValor.Enabled = false;

            this.erro.SetError(txtValorDesconto, string.Empty);
            this.erro.SetError(txtCodPromo, string.Empty);

            this.txtValorDesconto.Text = "0";
            this.txtCodPromo.Enabled = true;
            this.txtValorDesconto.Enabled = true;
            this.txtCodPromo.Text = string.Empty;
            this.txtDesconto.Text = "0";
            IdDesconto = 0;
            this.btnAddDesconto.Visible = true;
            this.pbAddDesconto.Visible = true;
            this.txtPorct.Text = "0%";


            this.pbExcluirDesconto.Visible = false;
            this.btnExcluirDesconto.Visible = false;

        }

       

        private void txtValorRestante_TextChanged(object sender, EventArgs e)
        {


            if (Convert.ToDouble(this.txtValorRestante.Text.ToString().Replace("R$", "").Replace(" ","")) > Convert.ToDouble(this.txtValorTotal.Text.ToString().Replace("R$","")))
            {
                this.txtValorTroco.Text = Convert.ToString(Convert.ToDouble(this.txtValorRestante.Text.ToString().Replace("R$","")) - Convert.ToDouble(this.txtValorTotal.Text.ToString().Replace("R$","")));
                txtValorTroco.Text = String.Format("{0:c}", Convert.ToDouble(txtValorTroco.Text.Replace("R$", "").Replace("R$", "")));
            }

            if (Convert.ToDouble(this.txtValorRestante.Text.ToString().Replace("R$","").Replace(" ", "")) ==0 && this.dgvFormasDePagar.Rows.Count>0)
            {
                this.btnAddValor.Visible = false;
                this.pbAddValor.Visible = false;
                this.cbTipoDePagamento.KeyDown -= KeyEnterDelete;
                this.txtValor.KeyDown -= KeyEnterDelete;
            }
            else
            {
                this.btnAddValor.Visible = true;
                this.pbAddValor.Visible = true;
                this.cbTipoDePagamento.KeyDown += KeyEnterDelete;
                this.txtValor.KeyDown += KeyEnterDelete;
            }
            if (Convert.ToDouble(this.txtValorRestante.Text.ToString().Replace("R$","").Replace(" ", "")) <0)
            {
                this.txtValorTroco.Text = Convert.ToDouble(this.txtValorRestante.Text.Replace("-", "")).ToString();
                txtValorTroco.Text = String.Format("{0:c}", Convert.ToDouble(txtValorTroco.Text.Replace("R$", "").Replace("R$", "")));
                
                txtValorRestante.Text = "R$ 0,00";
            }
            else if(txtValorRestante.Text != "R$ 0,00")
            {
                this.txtValorTroco.Text = "0";
                txtValorTroco.Text = String.Format("{0:c}", Convert.ToDouble(txtValorTroco.Text.Replace("R$", "").Replace("R$", "")));
            }

            this.txtValorRestante.Text = txtValorRestante.Text.Replace("R$","").Replace(" ","").Length > 10 ? txtValorRestante.Text.Substring(0, 10) : txtValorRestante.Text;
            if (txtValorRestante.Text.Replace("R$","").Replace(" ","").Length >= 10)
            {
                if (txtValorRestante.Text.Substring(10) == ",")
                {
                    txtValorRestante.Text=txtValorRestante.Text.Replace(",", "");
                }
            }
           
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            if (txtDesconto.Text!=string.Empty)
            {
                if (Convert.ToDouble(this.txtValorTotal.Text.ToString().Replace("R$","")) - ((Convert.ToDouble(this.txtValorPago.Text.ToString().Replace("R$",""))) + (Convert.ToDouble(this.txtDesconto.Text.ToString().Replace("R$","")))) > 0)
                {
                    this.txtValorRestante.Text = Convert.ToString(Convert.ToDouble(this.txtValorTotal.Text.ToString().Replace("R$","")) - ((Convert.ToDouble(this.txtValorPago.Text.ToString().Replace("R$",""))) + (Convert.ToDouble(this.txtDesconto.Text.ToString().Replace("R$","")))));
                    txtValorRestante.Text = String.Format("{0:c}", Convert.ToDouble(txtValorRestante.Text.Replace("R$", "").Replace("R$", "")));
                }
                else
                {
                    this.txtValorRestante.Text = Convert.ToString(Convert.ToDouble(this.txtValorTotal.Text.ToString().Replace("R$","")) - ((Convert.ToDouble(this.txtValorPago.Text.ToString().Replace("R$",""))) + (Convert.ToDouble(this.txtDesconto.Text.ToString().Replace("R$","")))));
                    txtValorRestante.Text = String.Format("{0:c}", Convert.ToDouble(txtValorRestante.Text.Replace("R$", "").Replace("R$", "")));
                }

            }

            this.txtDesconto.Text = txtDesconto.Text.Replace("R$","").Replace(" ","").Length > 10 ? txtDesconto.Text.Substring(0, 10) : txtDesconto.Text;
            if (txtDesconto.Text.Replace("R$","").Replace(" ","").Length >= 10)
            {
                if (txtDesconto.Text.Substring(10) == ",")
                {
                    txtDesconto.Text=txtDesconto.Text.Replace(",", "");
                }
            }
          

        }

        int IdDesconto;
        private void AdicionarDesconto(object sender, EventArgs e)
        {
            try
            {


                erro.SetError(this.txtCodPromo, string.Empty);
                if (txtValorDesconto.Text.IndexOf(",") == 0)
                {
                    this.erro.SetError(this.txtValorDesconto, "Digite o valor corretamente!");
                    this.Focus();
                    return;
                }
                if (this.txtValorDesconto.Text.IndexOf("%")>0)
                {
                    if (Convert.ToDouble(txtValorDesconto.Text.Replace("%", "")) > 100)
                    {
                        this.erro.SetError(this.txtValorDesconto, "O percentual passou do limite!");
                        this.Focus();
                        return;
                    }
                }
                if (this.txtValorDesconto.Text.IndexOf("%") < 0)
                {
                    if (Convert.ToDouble(txtValorDesconto.Text) > Convert.ToDouble(txtValorTotal.Text.Replace("R$", "").Replace(" ", "")))
                    {
                        this.erro.SetError(this.txtValorDesconto, "O valor passou do limite!");
                        this.Focus();
                        return;
                    }
                }
                    

                if (this.txtCodPromo.Text!=string.Empty)
                {

                    BLL.Desconto obj = new BLL.Desconto();
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    obj.COD_PROMOCIONAL = this.txtCodPromo.Text.ToUpper();
                    dr = obj.Consultar();
                    
                    if (dr.Read())
                    {
                        IdDesconto = Convert.ToInt32(dr["ID_DESCONTO"]);
                        string porcentagem = dr["DESCONTO"].ToString();
                        this.txtPorct.Text = porcentagem+"%";
                        this.txtDesconto.Text = Convert.ToString((Convert.ToDouble(txtValorTotal.Text.Replace("R$","").ToString()) * Convert.ToDouble(porcentagem.Replace("%", ""))) / 100);

                    }
                    else
                    {
                        erro.SetError(this.txtCodPromo, "Esse código não existe ou está desabilitado!");
                        this.txtCodPromo.Focus();
                        return;
                    }
                }
                else
                {
                    if (this.txtValorDesconto.Text.Replace("0","").Replace(",","").Trim() == string.Empty)
                    {
                        this.erro.SetError(this.txtValorDesconto, "Digite um valor!");
                        this.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.txtValorDesconto, string.Empty);
                    }
                    if (txtValorDesconto.Text.IndexOf("%")>0)
                    {
                        this.txtDesconto.Text = Convert.ToString((Convert.ToDouble(txtValorTotal.Text.Replace("R$","").ToString()) * Convert.ToDouble(txtValorDesconto.Text.Replace("%", "").ToString())) / 100);
                       
                    }
                    else
                    {
                        this.txtDesconto.Text = this.txtValorDesconto.Text;
                    }
                   
                }
                this.btnAddDesconto.Visible = false;
                this.pbAddDesconto.Visible = false;
                this.txtValorDesconto.Enabled = false;
                this.pbExcluirDesconto.Visible = true;
                this.btnExcluirDesconto.Visible = true;
                this.txtCodPromo.Enabled = false;

                txtValorPago.Text = String.Format("{0:c}", Convert.ToDouble(txtValorPago.Text.Replace("R$", "").Replace("R$", "")));
                txtValorRestante.Text = String.Format("{0:c}", Convert.ToDouble(txtValorRestante.Text.Replace("R$", "").Replace("R$", "")));
                txtDesconto.Text = String.Format("{0:c}", Convert.ToDouble(txtDesconto.Text.Replace("R$", "").Replace("R$", "")));
                txtValorTroco.Text = String.Format("{0:c}", Convert.ToDouble(txtValorTroco.Text.Replace("R$", "").Replace("R$", "")));

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
           
        }

        private void RemoverDesconto(object sender, EventArgs e)
        {
            this.erro.SetError(txtValorDesconto,string.Empty);
            this.erro.SetError(txtCodPromo, string.Empty);

            this.txtValorDesconto.Text = "0";
            this.txtCodPromo.Enabled = true;
            this.txtValorDesconto.Enabled = true;
            this.txtCodPromo.Text = string.Empty;
            this.txtDesconto.Text = "0";
            this.txtPorct.Text = "0%";
            IdDesconto = 0;
            this.btnAddDesconto.Visible = true;
            this.pbAddDesconto.Visible = true;
          

            this.pbExcluirDesconto.Visible = false;
            this.btnExcluirDesconto.Visible = false;
            double valorTroco = Convert.ToDouble(txtValorPago.Text.Replace("R$","")) - Convert.ToDouble(txtValorTotal.Text.Replace("R$",""));
            if (valorTroco <= 0)
            {
                txtValorTroco.Text = "0";
            }
            else
            {
                txtValorTroco.Text = valorTroco.ToString();
            }

            txtValorPago.Text = String.Format("{0:c}", Convert.ToDouble(txtValorPago.Text.Replace("R$", "").Replace("R$", "")));
            txtValorRestante.Text = String.Format("{0:c}", Convert.ToDouble(txtValorRestante.Text.Replace("R$", "").Replace("R$", "")));
            txtDesconto.Text = String.Format("{0:c}", Convert.ToDouble(txtDesconto.Text.Replace("R$", "").Replace("R$", "")));
            txtValorTroco.Text = String.Format("{0:c}", Convert.ToDouble(txtValorTroco.Text.Replace("R$", "").Replace("R$", "")));

        }

        private void txtCodPromo_KeyPress(object sender, KeyPressEventArgs e)
        {

            this.txtValorDesconto.Text = "0";
        }

        private void KeyEnterDelete(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    this.erro.SetError(this.txtValorRestante, string.Empty);
                    if (this.txtValorTotal.Text.Replace("R$", "") == string.Empty || this.txtValorTotal.Text.Replace("R$", "") == "0")
                    {
                        this.erro.SetError(this.txtValorTotal, "Nenhum Assento selecionado!");
                        this.Focus();
                        return;
                    }
                    if (txtValor.Text.IndexOf(",") == 0)
                    {
                        this.erro.SetError(this.txtValor, "Digite o valor corretamente!");
                        this.Focus();
                        return;
                    }

                    BLL.Artista arti = new BLL.Artista();


                    if (this.txtValor.Text.Replace("0", "").Replace(",", "").Trim() == string.Empty)
                    {
                        this.erro.SetError(this.txtValor, "Digite um valor!");
                        this.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.txtValor, string.Empty);
                    }

                    if (this.txtValor.Text.Substring(txtValor.Text.Replace("R$", "").Replace(" ", "").Length - 1) == ",")
                    {

                        this.erro.SetError(this.txtValor, "Digite o valor corretamente!");
                        this.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.txtValor, string.Empty);
                    }

                    if (dgvFormasDePagar.ColumnCount == 0)
                    {

                        this.dgvFormasDePagar.Columns.Add("FORMA", "Forma");
                        this.dgvFormasDePagar.Columns.Add("VALOR", "Valor");

                    }
                    var index = dgvFormasDePagar.Rows.Add();



                    if (this.dgvFormasDePagar.RowCount > 1)
                    {
                        if (ChecarExisteGrid(index, "Ingresso"))
                        {
                            ValorTotalDGV = Convert.ToDouble(ValorTotalDGV.ToString()) + Convert.ToDouble(this.txtValor.Text.Replace("R$", "").ToString());

                            this.dgvFormasDePagar.Rows[index].Cells["FORMA"].Value = this.cbTipoDePagamento.Text.Trim();
                            this.dgvFormasDePagar.Rows[index].Cells["VALOR"].Value = this.txtValor.Text.Replace("R$", "");



                        }
                        else
                        {
                            this.dgvFormasDePagar.Rows.Remove(this.dgvFormasDePagar.Rows[index]);
                            return;
                        }
                    }
                    else
                    {

                        this.dgvFormasDePagar.Rows[index].Cells["FORMA"].Value = this.cbTipoDePagamento.Text.Trim();
                        this.dgvFormasDePagar.Rows[index].Cells["VALOR"].Value = this.txtValor.Text.ToString().Replace("R$", "");
                        ValorTotalDGV = Convert.ToDouble(ValorTotalDGV.ToString()) + Convert.ToDouble(this.txtValor.Text.ToString().Replace("R$", ""));
                        if (Convert.ToDouble(txtValorTroco.Text.Replace("R$", "").Replace("R$", "").ToString()) > 0)
                        {
                            this.txtValorTroco.Text = Convert.ToDouble(txtValorTroco.Text.Replace("R$", "").Replace("R$", "") + ValorTotalDGV).ToString();
                        }

                    }



                    this.pbExcluirValor.Enabled = true;
                    this.btnExcluirValor.Enabled = true;

                    if (this.txtDesconto.Text == "R$0,0")
                    {
                        double total = Convert.ToDouble(txtValorTotal.Text.Replace("R$", "").Replace("R$", "").ToString()) - Convert.ToDouble(txtValorRestante.Text.Replace("R$", "").Replace("R$", "").ToString());
                        if (this.txtValorRestante.Text.Replace("R$", "").ToString() == txtValorTotal.Text.ToString().Replace("R$", "") || Convert.ToDouble(this.txtValorRestante.Text.Replace("R$", "").ToString()) == Convert.ToDouble(this.txtValorTotal.Text.Replace("R$", "").ToString()))
                        {
                            this.txtValorRestante.Text = Convert.ToDouble(Convert.ToDouble(txtValorTotal.Text.Replace("R$", "").Replace("R$", "")) - Convert.ToDouble(ValorTotalDGV.ToString())).ToString();
                            if (Convert.ToDouble(this.txtValorRestante.Text.ToString().Replace("R$", "")) <= 0)
                            {
                                this.txtValorRestante.Text = "0";
                                txtValorTroco.Text = Convert.ToString(Convert.ToDouble(ValorTotalDGV.ToString()) - Convert.ToDouble(txtValorTotal.Text.Replace("R$", "")));
                                btnAddValor.Enabled = false;
                                pbAddValor.Enabled = false;
                            }
                        }
                        else
                        {
                            if (Convert.ToDouble(Convert.ToDouble(ValorTotalDGV.ToString()) - Convert.ToDouble(txtValorTotal.Text.Replace("R$", "").Replace("R$", "").ToString())) > 0)
                            {
                                this.txtValorTroco.Text = Convert.ToDouble(Convert.ToDouble(ValorTotalDGV.ToString()) - Convert.ToDouble(txtValorTotal.Text.Replace("R$", "").Replace("R$", "").ToString())).ToString();
                            }
                            else
                            {
                                this.txtValorRestante.Text = Convert.ToString(Convert.ToDouble(txtValorTotal.Text.Replace("R$", "").Replace("R$", "").ToString()) - Convert.ToDouble(Convert.ToDouble(ValorTotalDGV.ToString())));
                            }


                            if (Convert.ToDouble(this.txtValorRestante.Text.ToString().Replace("R$", "")) < 0 || Convert.ToDouble(this.txtValorTroco.Text.ToString().Replace("R$", "")) > 0)
                            {
                                this.txtValorRestante.Text = "0";
                                txtValorTroco.Text = Convert.ToString(Convert.ToDouble(ValorTotalDGV.ToString()) - Convert.ToDouble(txtValorTotal.Text.Replace("R$", "").ToString()));
                                btnAddValor.Enabled = false;
                                pbAddValor.Enabled = false;
                            }

                        }

                    }
                    else
                    {
                        Descontar();
                    }
                    this.txtValorPago.Text = ValorTotalDGV.ToString();
                    this.dgvFormasDePagar.AutoResizeColumn(0);
                    this.dgvFormasDePagar.AutoResizeColumn(1);

                    txtValorPago.Text = String.Format("{0:c}", Convert.ToDouble(txtValorPago.Text.Replace("R$", "").Replace("R$", "")));
                    txtValorRestante.Text = String.Format("{0:c}", Convert.ToDouble(txtValorRestante.Text.Replace("R$", "").Replace("R$", "")));
                    txtDesconto.Text = String.Format("{0:c}", Convert.ToDouble(txtDesconto.Text.Replace("R$", "").Replace("R$", "")));
                    txtValorTroco.Text = String.Format("{0:c}", Convert.ToDouble(txtValorTroco.Text.Replace("R$", "").Replace("R$", "")));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
            //if (this.dgvFormasDePagar.Rows.Count > 0)
            //{
            //    if (e.KeyCode == Keys.Delete)
            //    {
            //        try
            //        {
            //            this.pbAddValor.Enabled = true;
            //            this.btnAddValor.Enabled = true;
            //            if (this.dgvFormasDePagar.CurrentRow == null || Convert.ToString(this.dgvFormasDePagar.CurrentRow.Cells[0].Value) == string.Empty)
            //            {
            //                return;
            //            }
            //            else
            //            {
            //                foreach (DataGridViewRow linha in dgvFormasDePagar.Rows)
            //                {
            //                    if (linha.Selected)
            //                    {
            //                        this.erro.SetError(this.txtValorRestante, string.Empty);
            //                        if (this.txtValorTotal.Text.Replace("R$", "") == string.Empty || this.txtValorTotal.Text.Replace("R$", "") == "0")
            //                        {
            //                            this.erro.SetError(this.txtValorTotal, "Nenhum Assento selecionado!");
            //                            this.Focus();
            //                            return;
            //                        }

            //                        BLL.Evento func = new BLL.Evento();
            //                        //NFormR = NFormR + 1;
            //                        ValorTotalDGV = ValorTotalDGV - Convert.ToDouble(linha.Cells[1].Value);


            //                        this.txtValorPago.Text = ValorTotalDGV.ToString();

            //                        this.txtValorRestante.Text = Convert.ToString(Convert.ToDouble(txtValorTotal.Text.Replace("R$", "")) - (Convert.ToDouble(txtValorPago.Text.Replace("R$", "")) + Convert.ToDouble(txtDesconto.Text.Replace("R$", ""))));



            //                        if ((Convert.ToDouble(txtValorPago.Text.Replace("R$", "")) + Convert.ToDouble(txtDesconto.Text.Replace("R$", "")))
            //                            - Convert.ToDouble(txtValorTotal.Text.Replace("R$", "")) <= 0)
            //                        {
            //                            this.txtValorTroco.Text = "0";
            //                        }
            //                        else
            //                        {
            //                            this.txtValorTroco.Text = Convert.ToString(Convert.ToDouble(txtValorPago.Text.Replace("R$", "")) - Convert.ToDouble(txtValorTotal.Text.Replace("R$", "")));
            //                            this.txtValorRestante.Text = "0";
            //                        }


            //                        this.dgvFormasDePagar.Rows.Remove(linha);

            //                    }
            //                }




            //                if (this.dgvFormasDePagar.RowCount == 0)
            //                {


            //                    this.pbExcluirValor.Enabled = false;
            //                    this.btnExcluirValor.Enabled = false;
            //                }

            //                txtValorPago.Text = String.Format("{0:c}", Convert.ToDouble(txtValorPago.Text.Replace("R$", "").Replace("R$", "")));
            //                txtValorRestante.Text = String.Format("{0:c}", Convert.ToDouble(txtValorRestante.Text.Replace("R$", "").Replace("R$", "")));
            //                txtDesconto.Text = String.Format("{0:c}", Convert.ToDouble(txtDesconto.Text.Replace("R$", "").Replace("R$", "")));
            //                txtValorTroco.Text = String.Format("{0:c}", Convert.ToDouble(txtValorTroco.Text.Replace("R$", "").Replace("R$", "")));

            //            }
            //        }
            //        catch (Exception ex)
            //        {

            //            MessageBox.Show(ex.Message);
            //        }
            //    }
            //}

            
        }
        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {
            this.txtValorTotal.Text = txtValorTotal.Text.Replace("R$","").Replace(" ","").Length > 10 ? txtValorTotal.Text.Substring(0, 10) : txtValorTotal.Text;
            if (txtValorTotal.Text.Replace("R$","").Replace(" ","").Length >= 10)
            {
                if (txtValorTotal.Text.Substring(10) == ",")
                {
                    txtValorTotal.Text=txtValorTotal.Text.Replace(",", "");
                }
            }
        }
        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            this.txtValorPago.Text = txtValorPago.Text.Replace("R$", "").Replace(" ", "").Length > 10 ? txtValorPago.Text.Substring(0, 10) : txtValorPago.Text;
            if (txtValorPago.Text.Replace("R$", "").Replace(" ", "").Length >= 10)
            {
                if (txtValorPago.Text.Substring(10) == ",")
                {
                    txtValorPago.Text = txtValorPago.Text.Replace(",", "");
                    txtValorPago.Text = String.Format("{0:c}", Convert.ToDouble(txtValorPago.Text.Replace("R$", "").Replace("R$", "")));

                }
            }

        }

        private void txtValorTroco_TextChanged(object sender, EventArgs e)
        {
            this.txtValorTroco.Text = txtValorTroco.Text.Replace("R$", "").Replace(" ", "").Length > 10 ? txtValorTroco.Text.Substring(0, 10) : txtValorTroco.Text;
            if (txtValorTroco.Text.Replace("R$", "").Replace(" ", "").Length >= 10)
            {
                if (txtValorTroco.Text.Substring(10) == ",")
                {
                    txtValorTroco.Text = txtValorTroco.Text.Replace(",", "");
                }
            }


        }

        /// <summary>
        //////////////////////////////////// RELATORIO

        private void Imprimir()
        {
            try
            {
                printDialog1.Document = printDocument1;
                this.TopMost = false;

                //if (printDialog1.ShowDialog() == DialogResult.OK)
                //{
                //    this.printDocument1.Print();
                //}


                if (TipoDoc == "Recibo")
                {
                    printDialog1.Document = printDocument1;


                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        this.printDocument1.Print();
                    }
                    else
                    {
                        return;
                    }


                }
                else
                {
                    printDialog1.Document = printDocument1;


                    AssentosDGV = NAssento;
                    for (int i = 0; i < NAssento; i++)
                    {
                        print = false;
                        this.TopMost = false;
                        if (printDialog1.ShowDialog() == DialogResult.OK)
                        {

                            this.printDocument1.Print();
                            if (print)
                            {
                                if (AssentosDGV - 1 == 0)
                                {
                                    this.TopMost = true;
                                    MessageBox.Show("Ingresso " + NAssento + "/" + NAssento + " finalizado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                }
                                else
                                {
                                    this.TopMost = true;
                                    MessageBox.Show("Ingresso " + (AssentosDGV - 1) + "/" + NAssento + " finalizado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                }
                            }

                        }
                        else
                        {
                            return;
                        }



                        AssentosDGV = AssentosDGV - 1;
                    }

                }







                this.TopMost = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private Font bold = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
        private Font boldMenor = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
        private Font boldMini = new Font(FontFamily.GenericSansSerif, 6, FontStyle.Bold);
        private Font boldExtraMini = new Font(FontFamily.GenericSansSerif, 4, FontStyle.Bold);
        private Font regular = new Font(FontFamily.GenericSansSerif, 5, FontStyle.Regular);

       
        private Font regular2 = new Font(FontFamily.GenericSansSerif, 6, FontStyle.Regular);
        private Font regularItens = new Font(FontFamily.GenericSansSerif, 4, FontStyle.Regular);

        int AssentosDGV;

        string TipoDoc;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {



            if (TipoDoc == "Recibo")
            {
                Graphics graphics = e.Graphics;
                int offset = 105;

                //print header
                graphics.DrawString("Comedy House ltda", bold, Brushes.Black, 20, 0);
                graphics.DrawString("Rua Augusta" + " Nº " + "1129", regular, Brushes.Black, 20, 17);
                graphics.DrawString("CNPJ: 85.547.831/0001-30", regular, Brushes.Black, 100, 17);
                graphics.DrawLine(Pens.Black, 20, 30, 185, 30);
                graphics.DrawString("CUPOM NÃO FISCAL", bold, Brushes.Black, 30, 35);
                graphics.DrawLine(Pens.Black, 20, 50, 185, 50);
                graphics.DrawString("Código da Venda: " + this.Id_Venda.ToString(), boldMini, Brushes.Black, 65, 60);
                graphics.DrawLine(Pens.Black, 20, 75, 185, 75);


                //itens header
                graphics.DrawString("Forma Pagamento", boldMini, Brushes.Black, 20, 80);

                graphics.DrawString("Valor", boldMini, Brushes.Black, 145, 80);

                graphics.DrawLine(Pens.Black, 20, 95, 185, 95);

                //itens de venda
                foreach (DataGridViewRow linha in dgvFormasDePagar.Rows)
                {
                    string produto = linha.Cells[0].Value.ToString();
                    graphics.DrawString(produto.Replace("R$","").Replace(" ","").Length > 20 ? produto.Substring(0, 20) + "..." : produto, regularItens, Brushes.Black, 20, offset);
                    graphics.DrawString("R$" + linha.Cells[1].Value.ToString(), regularItens, Brushes.Black, 145, offset);

                    offset += 20;
                }


                //total
                graphics.DrawLine(Pens.Black, 20, offset, 185, offset);
                offset += 5;

                decimal total = 0;

                graphics.DrawString("TOTAL", bold, Brushes.Black, 20, offset);
                graphics.DrawString("R$" + this.txtValorTotal.Text, bold, Brushes.Black, 135, offset);

                offset += 20;

                graphics.DrawString("TOTAL DESCONTADO ", regular, Brushes.Black, 20, offset);
                graphics.DrawString("R$" + this.txtDesconto.Text, regular, Brushes.Black, 140, offset);

                offset += 15;

                graphics.DrawString("TOTAL PAGO ", regular, Brushes.Black, 20, offset);
                graphics.DrawString("R$" + this.txtValorPago.Text, regular, Brushes.Black, 140, offset);

                offset += 15;


                graphics.DrawString("TROCO ", regular, Brushes.Black, 20, offset);
                graphics.DrawString("R$" + this.txtValorTroco.Text, regular, Brushes.Black, 140, offset);

                offset += 15;

                graphics.DrawLine(Pens.Black, 20, offset, 185, offset);
                offset += 5;


                if (Id_Cliente != 0)
                {


                    graphics.DrawString("Nome:", boldMini, Brushes.Black, 60, offset);

                    offset += 2;

                    string nome = this.NomeCli;
                    graphics.DrawString(nome.Replace("R$","").Replace(" ","").Length > 20 ? nome.Substring(0, 20) + "..." : nome, regularItens, Brushes.Black, 90, offset);

                    offset += 15;


                    graphics.DrawString("CPF: ", boldMini, Brushes.Black, 60, offset);

                    offset += 2;

                    graphics.DrawString(CpfCli, regularItens, Brushes.Black, 90, offset);

                    offset += 15;

                    graphics.DrawLine(Pens.Black, 20, offset, 185, offset);



                    offset += 5;
                }




                graphics.DrawString("Foi um prazer recebe-lo", regularItens, Brushes.Black, 40, offset);

                offset -= 2;

                graphics.DrawString("Volte Sempre!!", boldMini, Brushes.Black, 110, offset);
                offset += 15;
                graphics.DrawLine(Pens.Black, 20, offset, 185, offset);
                offset += 5;



                //bottom
                graphics.DrawString("Emitido em: " + DateTime.Now.ToString("dd/MM/yyyy    HH:mm:ss"), regularItens, Brushes.Black, 60, offset);





                e.HasMorePages = false;





            }
            else//// INGRESSO
            {


                Graphics graphics = e.Graphics;
                int offset = 105;

                //print header
                graphics.DrawString("Comedy House ltda", bold, Brushes.Black, 20, 0);
                graphics.DrawString("Rua Augusta" + " Nº " + "1129", regular, Brushes.Black, 20, 17);
                graphics.DrawString("CNPJ: 85.547.831/0001-30", regular, Brushes.Black, 100, 17);
                graphics.DrawLine(Pens.Black, 20, 30, 185, 30);
                graphics.DrawString("INGRESSO", bold, Brushes.Black, 60, 35);
                graphics.DrawLine(Pens.Black, 20, 50, 185, 50);
                graphics.DrawString("Código da Venda: " + Id_Venda, boldMini, Brushes.Black, 65, 60);
                graphics.DrawLine(Pens.Black, 20, 75, 185, 75);


                //itens header
                graphics.DrawString("Evento:", regular2, Brushes.Black, 20, 80);

                graphics.DrawString(Evento.Replace("R$","").Replace(" ","").Length > 20 ? Evento.Substring(0, 20) + "..." : Evento, boldMini, Brushes.Black, 55, 80);

                graphics.DrawLine(Pens.Black, 20, 95, 185, 95);

                //Inf dos ingressos




                graphics.DrawString("Data:", regular2, Brushes.Black, 30, offset);
                graphics.DrawString("Setor:", regular2, Brushes.Black, 110, offset);

                offset += 20;

                graphics.DrawString(DataDoEvento, boldMini, Brushes.Black, 30, offset);
                graphics.DrawString(Assento_Setor[AssentosDGV], boldMini, Brushes.Black, 110, offset);

                offset += 20;

                graphics.DrawString("Fileira:", regular2, Brushes.Black, 30, offset);
                graphics.DrawString("Horario:", regular2, Brushes.Black, 110, offset);

                offset += 20;

                graphics.DrawString(Assento_Fileira[AssentosDGV], boldMini, Brushes.Black, 30, offset);
                graphics.DrawString(HorarioDoEvento, boldMini, Brushes.Black, 110, offset);

                offset += 20;

                graphics.DrawString("Tipo:", regular2, Brushes.Black, 30, offset);
                graphics.DrawString("Numero:", regular2, Brushes.Black, 110, offset);

                offset += 20;

                graphics.DrawString(Assento_Tipo[AssentosDGV], boldMini, Brushes.Black, 30, offset);
                graphics.DrawString(Assento_Numero[AssentosDGV], boldMini, Brushes.Black, 110, offset);

                offset += 20;


                //total
                graphics.DrawLine(Pens.Black, 20, offset, 185, offset);
                offset += 5;

                decimal total = 0;





                if (Id_Cliente != 0)
                {


                    graphics.DrawString("Nome:", boldMini, Brushes.Black, 60, offset);

                    offset += 2;

                    string nome = this.NomeCli;
                    graphics.DrawString(nome.Replace("R$","").Replace(" ","").Length > 20 ? nome.Substring(0, 20) + "..." : nome, regularItens, Brushes.Black, 90, offset);

                    offset += 15;


                    graphics.DrawString("CPF: ", boldMini, Brushes.Black, 60, offset);

                    offset += 2;

                    graphics.DrawString(CpfCli, regularItens, Brushes.Black, 90, offset);

                    offset += 15;

                    graphics.DrawLine(Pens.Black, 20, offset, 185, offset);



                    offset += 5;
                }




                graphics.DrawString("Foi um prazer recebe-lo", regularItens, Brushes.Black, 40, offset);

                offset -= 2;

                graphics.DrawString("Volte Sempre!!", boldMini, Brushes.Black, 110, offset);
                offset += 15;

                graphics.DrawString("(Guardar esse ingresso até o fim do evento!!)", boldExtraMini, Brushes.Black, 40, offset);

                offset += 15;

                graphics.DrawLine(Pens.Black, 20, offset, 185, offset);
                offset += 5;

                //bottom
                graphics.DrawString("Emitido em: " + DateTime.Now.ToString("dd/MM/yyyy    HH:mm:ss"), regularItens, Brushes.Black, 60, offset);



                e.HasMorePages = false;



            }




        }

        bool print = false;

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {

            if (!printDocument1.PrintController.IsPreview)
            {

                print = true;


            }




        }
        /// </summary>



        //////////////////////////////////////////////////////////////

    }
}
