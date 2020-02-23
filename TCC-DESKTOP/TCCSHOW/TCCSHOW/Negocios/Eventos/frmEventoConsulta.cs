using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Eventos
{
    public partial class frmEventoConsulta : Modelos.ModeloConsultaPadrao
    {
        public frmEventoConsulta()
        {
            InitializeComponent();
            this.dgv.DefaultCellStyle.BackColor = Color.LightGray;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor =
  Color.Silver;
            tipo = "Titulo";
            WPTotal = this.txtPesquisar.Width;
            WPData = txtPesquisar.Width - this.dtpHorarioInicio.Width - 20;
        }
        double WPTotal, WPData;
        public string tipo, tNome, tTipoPag;
        public int tNArt, tID;
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgv.SelectedRows.Count > 1)
            {
                this.btnAlterar.Enabled = false; this.pbAlterar.Enabled = false;
                this.btnConsultar.Enabled = false; this.pbConsultar.Enabled = false;
            }
            if (this.dgv.CurrentRow==null)
            {
                return;
            }
            else
            {
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

            CarregarGrid();
            //if (sender == this.btnApresentar)
            //{
            //    this.txtPesquisar.Text = string.Empty;
            //}

            this.txtPesquisar.Focus();
        }

        private void frmEventoConsulta_KeyPress(object sender, KeyPressEventArgs k)
        {
            if (!char.IsDigit(k.KeyChar) && k.KeyChar != (char)8 && tipo == "EV.ID_EVENTO" | tipo=="EV.VALOR_EVENTO")

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
        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (this.cbTipo.Text == "Código")
            //{
            //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)

            //    {

            //        e.Handled = true;

            //    }
            //}
        }
        private void CarregarGrid()
        {
            try
            {

                BLL.Evento obj = new BLL.Evento(); // <<<<<<<<<<<<<<<<
                int ativo = 1;
                

                if (rbTodos.Checked) { ativo = 2; }
                else if (rbAtiva.Checked) { ativo = 1; }
                else if (rbDesativa.Checked) { ativo = 0; }

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

                obj.DataListarInicio =Convert.ToDateTime(dtpHorarioInicio.Value.ToString().Substring(0,10));
                obj.DataListarFinal = Convert.ToDateTime(dtpHorarioFinal.Value.ToString().Substring(0, 10));


                this.dgv.DataSource = obj.ListarGeral(this.txtPesquisar.Text.Trim().ToUpper(), ativo, tipo,tID,tNArt,tTipoPag).Tables[0];
                

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

        private void AbrirFormulario(object sender, EventArgs e)
        {//INCLUIR ALTERAR CONSULTAR
            try
            {
                if (this.dgv.RowCount == 0)
                {
                    return;
                }
                frmEventoCadastro f = new frmEventoCadastro
                {
                    idFunc = this.idFunc,
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size
                };
                f.Size = new Size(f.Width + 30, f.Height + 30);
                //f.lblNomeTool.Text = lblNomeTool.Text; f.lblNomeTool.ForeColor= this.lblNomeTool.ForeColor; f.tool_ID.Text= //this.tool_ID.Text;
                f.NivelAcesso = NivelAcesso;
                // f.lblNomeTool.ForeColor = this.lblNomeTool.ForeColor;

                f.operacao = Convert.ToByte(BLL.Operacao.Inclusao);
                if (sender== this.btnAlterar || sender== this.pbAlterar)
                {
                    BLL.Evento obj = new BLL.Evento();
                    obj.ID_EVENTO = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    dr = obj.VerificarIngresso();
                    if (dr.Read())
                    {
                        MessageBox.Show("Existe(m) ingresso(s) não cancelado(s) vinculado(s) ao evento: " + this.dgv.CurrentRow.Cells[1].Value.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }



                //f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;

                if (sender == this.btnAlterar || sender == this.btnConsultar || sender== this.pbAlterar || sender== this.pbConsultar)
                {
                    f.lblTitulo.Text = "Consulta de";
                    f.dtpDataEventoDMY.MinDate = new System.DateTime(2017, 1, 1, 1, 1, 1);
                    f.codigo = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                    f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);
                    if (sender == this.btnConsultar || sender == this.pbConsultar)
                    {
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
                        f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible=false; f.btnLimpar.Visible=false;
                        f.dtpDataEventoDMY.Enabled = false;

                        f.btnAdicionar.Enabled = false;
                        f.btnExcluir.Enabled = false;

                        f.operacao = Convert.ToByte(BLL.Operacao.Consulta);
                    }
                }
                f.TopMost = true;
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

        private void dgv_Sorted(object sender, EventArgs e)
        {

          
        

        }

        private void dgv_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Index == 3 || e.Column.Index == 4)

            {
                e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
                

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
                if (MessageBox.Show("Deseja " + b.Text.ToLower() + " o Evento " + nome + "?", "Código " + this.dgv.CurrentRow.Cells[0].Value.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;
                Oracle.DataAccess.Client.OracleDataReader dr;
                BLL.Evento obj = new BLL.Evento(); //<<<<<<<<<<<<<
                BLL.Log LOG = new BLL.Log();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Selected)
                    {
                        obj.ID_EVENTO = Convert.ToInt32(row.Cells[0].Value); //<<<<<<<<
                        switch (b.Text)
                        {
                            case "Excluir":
                                dr = obj.VerificarIngresso();
                                if (dr.Read())
                                {
                                    MessageBox.Show("Já existe ingresso(s) não cancelados vinculado(s) ao evento: "+ row.Cells[1].Value.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                obj.Evento_crud('D');

                               
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "EVENTOS";
                                LOG.TIPO_LOG = "EXCLUSÃO"; LOG.DESCRICAO= row.Cells[1].Value.ToString();
                                LOG.Log_crud('D');
                                break;



                            case "Desativar":
                                dr = obj.VerificarIngresso();
                                if (dr.Read())
                                {
                                    MessageBox.Show("Já existe ingresso(s) não cancelados vinculado(s) ao evento: " + row.Cells[1].Value.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if (Convert.ToInt32(row.Cells["Ativo"].Value) != 0)
                                {
                                    obj.Ativar(0);
                                }
                                else
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("O Evento " + row.Cells[0].Value.ToString() + " já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Evento já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }

                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "EVENTOS";
                                LOG.TIPO_LOG = "ALTERAÇÃO";
                                LOG.Log_crud('A');


                                break;



                            case "Reativar":
                                
                                 if (row.Cells[4].Value.ToString()=="00:00")
                                {
                                    if (Convert.ToDateTime(row.Cells[2].Value.ToString().Substring(0, 10) + " " + row.Cells[4].Value).AddDays(1) < DateTime.Now)
                                    {
                                        if (this.dgv.SelectedRows.Count > 1)
                                        {
                                            MessageBox.Show("O evento " + row.Cells[0].Value.ToString() + " já aconteceu!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            MessageBox.Show("O evento já aconteceu!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }

                                        return;
                                    }
                                    else if (Convert.ToInt32(row.Cells["Ativo"].Value) != 1)
                                    {
                                       obj.DataEvento = Convert.ToDateTime(row.Cells[2].Value);
                                       dr = obj.Verificar(row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
                                        if (dr.Read())
                                        {
                                            MessageBox.Show("Já existe um evento ativo nesse horario!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                        obj.Ativar(1);///////////
                                    }
                                    else
                                    {
                                        if (this.dgv.SelectedRows.Count > 1)
                                        {
                                            MessageBox.Show("O Evento " + row.Cells[0].Value.ToString() + " já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            MessageBox.Show("O Evento já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        return;
                                    }
                                }
                                else if (Convert.ToDateTime(row.Cells[2].Value.ToString().Substring(0, 10) + " " + row.Cells[4].Value) < DateTime.Now)
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("O evento " + row.Cells[0].Value.ToString() + " já aconteceu!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O evento já aconteceu!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                    return;
                                }
                                else if (Convert.ToInt32(row.Cells["Ativo"].Value) != 1)
                                {
                                    obj.DataEvento = Convert.ToDateTime(row.Cells[2].Value);
                                    dr= obj.Verificar(row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
                                    if (dr.Read())
                                    {
                                        MessageBox.Show("Já existe um evento ativo nesse horario!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }

                                    obj.Ativar(1);///////////////////

                                }
                                else
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("O Evento " + row.Cells[0].Value.ToString() + " já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Evento já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "EVENTOS";
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

        private void FixarStatusPb(object o, EventArgs e)
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
                if (MessageBox.Show("Deseja " + b.Name.Replace("pb","").ToLower() + " o Evento " + nome + "?", "Código " + this.dgv.CurrentRow.Cells[0].Value.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;
                Oracle.DataAccess.Client.OracleDataReader dr;
                BLL.Evento obj = new BLL.Evento(); //<<<<<<<<<<<<<
                BLL.Log LOG = new BLL.Log();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Selected)
                    {
                        obj.ID_EVENTO = Convert.ToInt32(row.Cells[0].Value); //<<<<<<<<
                        switch (b.Name.Replace("pb",""))
                        {
                            case "Excluir":
                                dr = obj.VerificarIngresso();
                                if (dr.Read())
                                {
                                    MessageBox.Show("Já existe ingresso(s) não cancelados vinculado(s) ao evento: " + row.Cells[1].Value.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                obj.Evento_crud('D');

                                
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "EVENTOS";
                                LOG.TIPO_LOG = "EXCLUSÃO"; LOG.DESCRICAO= row.Cells[1].Value.ToString();
                                LOG.Log_crud('D');
                                break;
                            case "Desativar":
                                dr = obj.VerificarIngresso();
                                if (dr.Read())
                                {
                                    MessageBox.Show("Já existe ingresso(s) não cancelados vinculado(s) ao evento: " + row.Cells[1].Value.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if (Convert.ToInt32(row.Cells["Ativo"].Value) != 0)
                                {
                                    obj.Ativar(0);
                                }
                                else
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("O Evento " + row.Cells[0].Value.ToString() + " já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Evento já está desativado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "EVENTOS";
                                LOG.TIPO_LOG = "ALTERAÇÃO";
                                LOG.Log_crud('A');
                                break;
                            case "Reativar":
                                if (row.Cells[4].Value.ToString() == "00:00")
                                {
                                    if (Convert.ToDateTime(row.Cells[2].Value.ToString().Substring(0, 10) + " " + row.Cells[4].Value).AddDays(1) < DateTime.Now)
                                    {
                                        if (this.dgv.SelectedRows.Count > 1)
                                        {
                                            MessageBox.Show("O evento " + row.Cells[0].Value.ToString() + " já aconteceu!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            MessageBox.Show("O evento já aconteceu!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }

                                        return;
                                    }
                                    else if (Convert.ToInt32(row.Cells["Ativo"].Value) != 1)
                                    {
                                        obj.DataEvento = Convert.ToDateTime(row.Cells[2].Value);

                                        dr = obj.Verificar(row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
                                        if (dr.Read())
                                        {
                                            MessageBox.Show("Já existe um evento ativo nesse horario!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                        obj.Ativar(1);///////////
                                    }
                                    else
                                    {
                                        if (this.dgv.SelectedRows.Count > 1)
                                        {
                                            MessageBox.Show("O Evento " + row.Cells[0].Value.ToString() + " já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            MessageBox.Show("O Evento já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        return;
                                    }
                                }
                                else if (Convert.ToDateTime(row.Cells[2].Value.ToString().Substring(0, 10) + " " + row.Cells[4].Value) < DateTime.Now)
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("O evento " + row.Cells[0].Value.ToString() + " já aconteceu!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O evento já aconteceu!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                    return;
                                }
                                else if (Convert.ToInt32(row.Cells["Ativo"].Value) != 1)
                                {
                                    obj.DataEvento = Convert.ToDateTime(row.Cells[2].Value);
                                    dr = obj.Verificar(row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
                                    if (dr.Read())
                                    {
                                        MessageBox.Show("Já existe um evento ativo nesse horario!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }

                                    obj.Ativar(1);///////////////////

                                }
                                else
                                {
                                    if (this.dgv.SelectedRows.Count > 1)
                                    {
                                        MessageBox.Show("O Evento " + row.Cells[0].Value.ToString() + " já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Evento já está ativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    return;
                                }
                                LOG.ID_FUNC = idFunc;
                                LOG.ID_MODIFICADO = Convert.ToInt32(row.Cells[0].Value);
                                LOG.TABELA_LOG = "EVENTOS";
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




        /////////////////////////
    }
}
