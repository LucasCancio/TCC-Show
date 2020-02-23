using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Filtros
{
    public partial class frmProcurarConta : Modelos.ModeloGeral
    {
        public frmProcurarConta()
        {
            InitializeComponent();
            this.dgv.DefaultCellStyle.BackColor = Color.LightGray;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor =
  Color.Silver;
            tipo = "Descrição";
            tipo2 = "Todas";
            tData = "Pagamento/Recebimento";
            this.dtpHorarioFinal.Value = Convert.ToDateTime(DateTime.Now.AddMonths(1).ToString().Substring(0, 10));
        }

        public string tipo, tipo2, tSit, tTipoPag, tData;

       
        private int _FormId;
        public int FormId { get => _FormId; set => _FormId = value; }
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


        private void CarregarGrid()
        {
            try
            {
                BLL.Contas obj = new BLL.Contas(); // <<<<<<<<<<<<<<<<
                int ativo = 0;



                ativo = 2;


                switch (tipo)
                {
                    case "Codigo":
                        tipo = "C.ID_CONTAS";
                        break;
                    case "Departamento":

                        tipo = "C.DEPARTAMENTO";
                        break;
                    case "Descrição":
                    case null: case "":
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
                Contas.frmContasCadastro f = new Contas.frmContasCadastro
                {
                    operacao = Convert.ToByte(BLL.Operacao.Inclusao),
                    idFunc = this.idFunc,
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size
                };

                f.Size = new Size(f.Width, f.Height + 15);

                f.operacao = Convert.ToByte(BLL.Operacao.Inclusao);
                //f.lblNomeTool.Text = lblNomeTool.Text; f.lblNomeTool.ForeColor= this.lblNomeTool.ForeColor; f.tool_ID.Text= this.tool_ID.Text;
                f.dtpData.Value = DateTime.Today;
                f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;


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

                        f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;
                        f.chkAtivo.Enabled = false;
                        f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible = false; f.btnLimpar.Visible = false;
                        f.btnSalvar.Enabled = false; f.pbSalvar.Enabled = false;

                        f.rbPagar.Visible = false;
                        f.rbReceber.Visible = false;
                        f.pbPagar.Visible = false;
                        f.pbReceber.Visible = false;

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
                    f.lblTituloConta.Visible = true;
                        f.lblTituloConta.Text = f.lblTituloConta.Text + this.dgv.CurrentRow.Cells[1].Value.ToString();
                        f.pbTituloConta.Visible = true;
                        if (this.dgv.CurrentRow.Cells[1].Value.ToString() == "Receber")
                        {
                            f.pbTituloConta.Image = Properties.Resources.MaisIcone;
                        }
                        else
                        {
                            f.pbTituloConta.Image = Properties.Resources.MenosIcone;
                        }


                        f.operacao = Convert.ToByte(BLL.Operacao.Consulta);
                    }
                
                //var b = (Button)sender;
                //f.lblTitulo.Text =  b.Text;
                f.idFunc = this.idFunc; f.ShowDialog();
              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
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
                        linha.DefaultCellStyle.BackColor = Color.FromArgb(192, 192, 0);
                        linha.DefaultCellStyle.SelectionForeColor = Color.Gold;
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
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _FormId = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);



            this.Dispose();
        }

        private void AbrirFiltro(object sender, EventArgs e)
        {
            Filtro();
        }
        private void Filtro()
        {


            Negocios.Filtros.frmContasFiltro filtro = new Negocios.Filtros.frmContasFiltro();
            filtro.tipo2 = tipo2;
            filtro.tSit = tSit;
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

        private void Confirmar(Object o, EventArgs e)
        {
            if (this.dgv.RowCount == 0)
            {
                return;
            }

            _FormId = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);



            this.Dispose();

        }
        private void Cancelar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cancelar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; }
            this.Dispose();
        }

        //////////////////////////
    }
}
