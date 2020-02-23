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
    public partial class frmProcurarEvento : Modelos.ModeloGeral
    {
        public frmProcurarEvento()
        {
            InitializeComponent();
            tipo = "Titulo";
            WPTotal = this.txtPesquisar.Width;
            WPData = txtPesquisar.Width - this.dtpHorarioInicio.Width - 20;
            this.dtpHorarioFinal.MinDate = this.dtpHorarioInicio.Value;
            this.dtpHorarioInicio.MaxDate = this.dtpHorarioFinal.Value;
            this.dtpHorarioFinal.Value = Convert.ToDateTime(DateTime.Now.ToString().Substring(0, 10));
            this.dtpHorarioInicio.Value = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToString().Substring(0, 10));
        }
 
        double WPTotal, WPData;
        public string tipo, tNome, tTipoPag;
        public int tNArt, tID;
        private void Exibir(object sender, EventArgs e)
        {
            this.dtpHorarioFinal.MinDate = this.dtpHorarioInicio.Value;
            this.dtpHorarioInicio.MaxDate = this.dtpHorarioFinal.Value;

            CarregarGrid();
            //if (sender == this.btnApresentar)
            //{
            //    this.txtPesquisar.Text = string.Empty;
            //}

            this.txtPesquisar.Focus();
        }

        private void frmEventoConsulta_KeyPress(object sender, KeyPressEventArgs k)
        {
            if (!char.IsDigit(k.KeyChar) && k.KeyChar != (char)8 && tipo == "EV.ID_EVENTO" | tipo == "EV.VALOR_EVENTO")

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

                BLL.Evento obj = new BLL.Evento(); // <<<<<<<<<<<<<<<<
                int ativo = 2;



                switch (tipo)
                {
                    case "Codigo":
                        tipo = "EV.ID_EVENTO";
                        break;
                    case "Titulo":
                    case null: case "":
                        tipo = "EV.TITULO";
                        break;
                    case "Descrição":
                        tipo = "EV.DESCRICAO";
                        break;
                    case "Valor":
                        tipo = "EV.VALOR_EVENTO";
                        break;
                }

                obj.DataListarInicio = Convert.ToDateTime(dtpHorarioInicio.Value.ToString().Substring(0, 10));
                obj.DataListarFinal = Convert.ToDateTime(dtpHorarioFinal.Value.ToString().Substring(0, 10));


                this.dgv.DataSource = obj.ListarGeral(this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo, tID, tNArt, tTipoPag).Tables[0];


                //this.dgv.AutoResizeColumns();//
                this.dgv.Columns[0].HeaderText = "Cód";
                this.dgv.AutoResizeColumn(0);
                this.dgv.Columns[1].HeaderText = "Título";
                this.dgv.AutoResizeColumn(1);
                this.dgv.Columns[2].HeaderText = "Data Do Evento";
                this.dgv.AutoResizeColumn(2);
                this.dgv.Columns[3].HeaderText = "Horário Inicial";
                this.dgv.AutoResizeColumn(3);
                this.dgv.Columns[4].HeaderText = "Horário Final";
                this.dgv.AutoResizeColumn(4);
                this.dgv.Columns[5].HeaderText = "Duração";
                this.dgv.AutoResizeColumn(5);
                this.dgv.Columns[6].HeaderText = "Quantidade de Artistas";
                this.dgv.AutoResizeColumn(6);
                this.dgv.Columns[7].HeaderText = "Descrição";
                this.dgv.AutoResizeColumn(7);
                this.dgv.Columns[8].HeaderText = "Tipo de Pagamento";
                this.dgv.AutoResizeColumn(8);
                this.dgv.Columns[9].HeaderText = "Ativo";
                this.dgv.AutoResizeColumn(9);
                this.dgv.Columns[10].HeaderText = "Valor do Evento";
                this.dgv.AutoResizeColumn(10);


                this.txtPesquisar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }

        private void Cancelar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cancelar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; }
            this.Dispose();
        }

  

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _FormTitulo = this.dgv.CurrentRow.Cells[1].Value.ToString();
            _FormID = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);

            this.Dispose();
        }

        private void AbrirFormulario(object sender, EventArgs e)
        {//INCLUIR ALTERAR CONSULTAR
            try
            {
                if (this.dgv.RowCount == 0)
                {
                    return;
                }
                Negocios.Eventos.frmEventoCadastro f = new Negocios.Eventos.frmEventoCadastro
                {
                    idFunc = this.idFunc,
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size
                };
                //f.lblNomeTool.Text = lblNomeTool.Text; f.lblNomeTool.ForeColor= this.lblNomeTool.ForeColor; f.tool_ID.Text= //this.tool_ID.Text;
                f.NivelAcesso = NivelAcesso;
                // f.lblNomeTool.ForeColor = this.lblNomeTool.ForeColor;
                f.Size = new Size(f.Width + 180, f.Height + 220);
                f.TopMost = true;
                f.operacao = Convert.ToByte(BLL.Operacao.Inclusao);
                //f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;


                f.dtpDataEventoDMY.MinDate = new System.DateTime(2017, 1, 1, 1, 1, 1);
                f.codigo = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);
                if (sender == this.btnConsultar || sender == this.pbConsultar)
                {
                    f.lblTitulo.Text = "Consulta de";
                    f.chkAtivo.Enabled = false;
                    f.txtDescricao.Enabled = false;
                    f.mtbHorario_INICIO.Enabled = false;
                    f.mtbDuracao.Enabled = false;
                    f.txtValor.Enabled = false;
                    f.btnCadastrarArt.Visible = false;
                    f.pbCadastrarArt.Visible = false;
                    f.chkAtivo.Enabled = false;
                    f.pbPesquisar.Enabled = false;
                    f.txtPesquisar.Enabled = false;
                    f.rbBilheteria.Visible = false;
                    f.rbCache.Visible = false;
                    f.lblTipoPag.Visible = true;
                    f.pnFiltro.Enabled = false;
                    f.btnPesquisar.Enabled = false;
                    f.pbPesquisar.Enabled = false;
                    f.pbConsultarEvent.Visible = false;
                    f.btnConsultarEvent.Visible = false;

                    f.btnSalvar.Enabled = false; f.pbSalvar.Enabled = false;
                    f.txtTitulo.Enabled = false;
                    f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible = false; f.btnLimpar.Visible = false;
                    f.dtpDataEventoDMY.Enabled = false;

                    f.btnAdicionar.Enabled = false;
                    f.btnExcluir.Enabled = false;

                    f.operacao = Convert.ToByte(BLL.Operacao.Consulta);
                }

                f.TopMost = true;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.idFunc = this.idFunc; f.ShowDialog();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }

        private void AbrirFiltro(object sender, EventArgs e)
        {
            Filtro();
        }
        private void Filtro()
        {


            Negocios.Filtros.frmEventoFiltro filtro = new Negocios.Filtros.frmEventoFiltro();
            filtro.tID = tID;
            filtro.tNome = tNome;
            filtro.tNArt = tNArt;
            filtro.tTipoPag = tTipoPag;
            filtro.tipo = tipo;
            filtro.TopMost = true;
            filtro.ShowDialog();

            tID = filtro.tID;
            tNome = filtro.tNome;
            tNArt = filtro.tNArt;
            tTipoPag = filtro.tTipoPag;
            tipo = filtro.tipo;


            CarregarGrid();
        }
        private string _FormTitulo;

        public string FormTitulo { get => _FormTitulo; set => _FormTitulo = value; }


        private int _FormID;
        public int FormID { get => _FormID; set => _FormID = value; }
        
        private void Confirmar(Object o, EventArgs e)
        {
            if (this.dgv.RowCount == 0)
            {
                return;
            }
            _FormTitulo = this.dgv.CurrentRow.Cells[1].Value.ToString();
            FormID = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);

            this.Dispose();

        }

        ////////////////////
    }
}
