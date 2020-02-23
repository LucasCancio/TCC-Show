using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Ingresso
{
    public partial class frmIngressoConsultar : Modelos.ModeloConsultaPadrao
    {
        public frmIngressoConsultar()
        {
            InitializeComponent();
            this.dgv.DefaultCellStyle.BackColor = Color.LightGray;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor =
  Color.Silver;

            tipo = "Titulo";
            tipo2 ="Venda";
           
        }

        public string tipo, tipo2, tFileira, tCategoria, tTipoAssento;
        public string tNumero;

        private void Exibir(object sender, EventArgs e)
        {
          
            CarregarGrid();

            this.txtPesquisar.Focus();
        }

        private void frmIngressoConsulta_KeyPress(object sender, KeyPressEventArgs k)
        {
            if (!char.IsDigit(k.KeyChar) && k.KeyChar != (char)8 && ( tipo == "TB_EVENTO_INGRESSO.PRECO_TOTAL"|| tipo== "TB_VENDA_INGRESSO.ID_VENDA"))

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
                BLL.Ingresso obj = new BLL.Ingresso(); // <<<<<<<<<<<<<<<<
                int situacao = 0;
                if (rbTodos.Checked) {
                    situacao = 2;
                }
                else if (rbPagos.Checked)
                {
                    situacao = 1;
                }
                else if (rbAPagar.Checked)
                {
                    situacao = 3;
                }

                switch (tipo2)
                {
                    case "Venda":
                        tipo2 = "TB_VENDA_INGRESSO.DATAVENDA";
                        break;
                    case "Evento":
                        tipo2 = "EV.DATA_EVENTO";
                        break;
                    case null: case "":
                        break;
                }

                switch (tipo)
                {
                    case "Valor":
                    case "TB_EVENTO_INGRESSO.PRECO_TOTAL":
                        tipo = "TB_EVENTO_INGRESSO.PRECO_TOTAL";
                        break;
                    case "Cod":
                    case "TB_VENDA_INGRESSO.ID_VENDA":
                        tipo = "TB_VENDA_INGRESSO.ID_VENDA";
                        break;
                  
                    case "Titulo":
                    case null: case "":
                        tipo = "EV.TITULO";
                        break;
                  
                }

                
                    obj.DataListarInicio = Convert.ToDateTime(this.dtpHorarioInicio.Value.ToString().Substring(0, 10));
                    obj.DataListarFinal = Convert.ToDateTime(this.dtpHorarioFinal.Value.ToString().Substring(0, 10));
                    this.dgv.DataSource = obj.ListarIngresso(txtPesquisar.Text.ToUpper(),situacao.ToString(),tipo,tipo2,tFileira,tNumero,tCategoria,tTipoAssento).Tables[0];

                    

                
              







                this.dgv.Columns[0].HeaderText = "Cód Venda";
                this.dgv.AutoResizeColumn(0);
                this.dgv.Columns[1].HeaderText = "Data da Venda";
                this.dgv.AutoResizeColumn(1);
                this.dgv.Columns[2].HeaderText = "Situação";
                this.dgv.AutoResizeColumn(2);
                this.dgv.Columns[3].HeaderText = "Preço Total";
                this.dgv.AutoResizeColumn(3);
                this.dgv.Columns[4].HeaderText = "Data do Evento";
                this.dgv.AutoResizeColumn(4);
                this.dgv.Columns[5].HeaderText = "Horário do Evento";
                this.dgv.AutoResizeColumn(5);
                this.dgv.Columns[6].HeaderText = "Título do Evento";
                this.dgv.AutoResizeColumn(6);
               




                this.txtPesquisar.Focus();
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
                if (this.dgv.RowCount == 0) { MessageBox.Show("Nenhum Ingresso comprado!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                frmIngresso f = new frmIngresso
                {
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size,
                    idFunc = this.idFunc
                };
                f.MinimizeBox = true;
                f.Size = new Size(f.Width, f.Height + 15);
                f.StartPosition = FormStartPosition.CenterScreen;
                f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;

                if (sender == this.btnAlterar || sender == this.pbAlterar || sender == this.btnConsultar || sender == this.pbConsultar)
                {
                    f.gbCodigo.Visible = true;
                    f.codigo = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                    //f.Ativo = Convert.ToInt32(this.dgv.CurrentRow.Cells[4].Value);
                    f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);
                   

                    f.txtCPF.Enabled = true;

                    f.txtCodigo.Enabled = true;
                    if (this.dgv.CurrentRow.Cells[2].Value.ToString()=="Cancelado")
                    {
                        f.btnImprimir.Visible = false;
                        f.pbImprimir.Visible = false;
                        f.gbImprimir.Visible = false;
                       

                        f.btnCancelar.Location = new Point(f.btnCancelar.Location.X + 180, f.btnCancelar.Location.Y);
                       f.pbCancelar.Location = new Point(f.pbCancelar.Location.X + 180, f.pbCancelar.Location.Y);
                    }


                    


                    if (sender == this.btnConsultar || sender == this.pbConsultar)
                    {
                        f.txtCPF.Enabled = false;
                        //f.txtNomeFunc.Enabled = false;
                        f.dtpDataNasc.Enabled = false;
                        f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;
                        f.dtpEvento.Enabled = false;
                        //f.cbSexo.Enabled = false;
                       
                        //f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible = false; f.btnLimpar.Visible = false;
                        

                        f.operacao = Convert.ToByte(BLL.Operacao.Consulta);

                    }
                }
                //var b = (Button)sender;
                //f.lblTitulo.Text =  b.Text;
              
                f.TopMost = true;
                f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
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

        private void CancelarVenda(object sender, EventArgs e)
        {
            try
            {
                Negocios.Ingresso.frmCancelarVenda f = new frmCancelarVenda();
                f.idFunc = this.idFunc;
                f.txtResponsavel.Text = this.Funcionario;
                foreach (DataGridViewRow linha in dgv.Rows)
                {
                    if (linha.Selected)
                    {
                        
                        f.ID_VENDA = Convert.ToInt32(linha.Cells[0].Value);
                        f.ShowDialog();
                    }
                }
               
                CarregarGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
               
                if (this.dgv.Rows.Count<=0)
                {
                    return;
                }
                if (this.dgv.SelectedRows.Count > 1)
                {
                    this.btnReembolso.Enabled = false;
                    this.pbReembolso.Enabled = false;
                }
                else
                {
                    this.btnReembolso.Enabled = true;
                    this.pbReembolso.Enabled = true;
                }
                foreach (DataGridViewRow linha in dgv.Rows)
                {
                    if (linha.Selected)
                    {
                        if (linha.Cells["SITUACAO"].Value.ToString() == "Cancelado")
                        {
                            if (NivelAcesso != 2)
                            {
                                this.btnReembolso.Visible = false;
                                this.pbReembolso.Visible = false;
                            }
                         
                            linha.ContextMenuStrip = menuReembolso;
                        }
                        else
                        {
                            if (NivelAcesso != 2)
                            {
                                this.pbReembolso.Visible = true;

                                this.btnReembolso.Visible = true;
                            }
                          
                           

                        }
                    }
                    else
                    {
                        linha.ContextMenuStrip = null;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
           

        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow linha in dgv.Rows)
            {
                if (linha.Cells["SITUACAO"].Value.ToString()=="Cancelado")
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

        private void ConsultarReembolso(object sender, EventArgs e)
        {
            Negocios.Ingresso.frmCancelarVenda f = new frmCancelarVenda();
            foreach (DataGridViewRow linha in dgv.Rows)
            {
                if (linha.Selected)
                {
                    f.ID_VENDA = Convert.ToInt32(linha.Cells[0].Value);
                }
            }
            f.operacao = 1;
            f.idFunc = idFunc;
            f.txtMotivo.Enabled = false;
            f.ShowDialog();
        }

        private void AbrirFiltro(object sender, EventArgs e)
        {
            Filtro();
        }
        private void Filtro()
        {
            if (this.dtpHorarioFinal.Visible == true || txtPesquisarMask.Visible == true)
            {
                

                this.dtpHorarioInicio.Visible = false;
                this.dtpHorarioFinal.Visible = false;
                this.lblHorario.Visible = false;

            }

            Negocios.Filtros.frmIngressoFiltro filtro = new Negocios.Filtros.frmIngressoFiltro();
            filtro.tipo2 = tipo2;
            filtro.tipo = tipo;
            filtro.tNumero = tNumero;
            filtro.tFileira = tFileira;
            filtro.tCategoria = tCategoria;
            filtro.tTipoAssento = tTipoAssento;
            filtro.TopMost = true;
            filtro.ShowDialog();

            tipo2 = filtro.tipo2;
            tipo = filtro.tipo;
            tFileira = filtro.tFileira;
            tCategoria = filtro.tCategoria;
            tNumero = filtro.tNumero;
            tTipoAssento = filtro.tTipoAssento;

            switch (filtro.tipo)
            {
                case "CPF":
                    this.txtPesquisar.Visible = false;
                    this.txtPesquisarMask.Visible = true;
                    this.txtPesquisarMask.Mask = "000000000-00";
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



        //////////////////////
    }
}
