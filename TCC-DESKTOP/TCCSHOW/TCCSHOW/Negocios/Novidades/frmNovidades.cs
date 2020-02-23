using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Novidades
{
    public partial class frmNovidades : Modelos.ModeloPadrao
    {
        public frmNovidades()
        {
            InitializeComponent();
        }

     //   int rbN = 0;




        String imageLocation = "";
        private void ProcurarImagem(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.pngg| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pbImagem.ImageLocation = imageLocation;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void RemoverImagem(object sender, EventArgs e)
        {
            this.pbImagem.Image = Properties.Resources.LogoComCortina2;
            imageLocation = string.Empty;
        }

        private void ConsultarTamanho() {
            Oracle.DataAccess.Client.OracleDataReader dr;
            dr = nov.ConsultarTamanho();
            if (dr.Read())
            {
                if (dr["MAX"].ToString() == "0")
                {
                    // MessageBox.Show("Nenhuma novidade cadastrada!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.tbNovidades.Visible = false;
                    this.tbNovidades.Maximum = 0;
                    this.tbNovidades.Value = 0;
                }
                else
                {
                    tbNovidades.Maximum = Convert.ToInt32(dr["MAX"].ToString());
                    this.tbNovidades.Visible = true;
                }

            }
        }
        private void CarregarCampos(object sender, EventArgs e)
        {
            CarregarBanner();
        }
        private void CarregarBanner() {
            try
            {
                ConsultarTamanho();

                this.nupPosicao.Maximum = this.tbNovidades.Maximum;
                this.nupPosicao.Value = tbNovidades.Value;
                Oracle.DataAccess.Client.OracleDataReader dr;
                nov.INDEX_BANNER = this.tbNovidades.Value;
                dr = nov.Consultar();
                if (dr.Read())
                {
                    this.txtCodigo.Text = dr["ID_BANNER"].ToString();
                    this.pbImagem.ImageLocation = dr["URL_IMG"].ToString();
                    if (dr["ATIVO"].ToString() == "1")
                    {
                        this.chkAtivo.Checked = true;
                    }
                    else
                    {
                        this.chkAtivo.Checked = false;
                    }
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }
        private void MudarDeNovidade(object sender, EventArgs e)
        {
            this.nupPosicao.Maximum = this.tbNovidades.Maximum;
            this.nupPosicao.Value = tbNovidades.Value;
            Oracle.DataAccess.Client.OracleDataReader dr;
            nov.INDEX_BANNER = this.tbNovidades.Value;
            dr = nov.Consultar();
            if (dr.Read())
            {
                this.txtCodigo.Text = dr["ID_BANNER"].ToString();
                
                if (dr["URL_IMG"].ToString()==string.Empty)
                {
                    this.pbImagem.Image = Properties.Resources.LogoComCortina2;
                    imageLocation = string.Empty;
                }
                else
                {
                    this.pbImagem.ImageLocation = dr["URL_IMG"].ToString();
                }
                if (dr["ATIVO"].ToString() == "1")
                {
                    this.chkAtivo.Checked = true;
                }
                else
                {
                    this.chkAtivo.Checked = false;
                }
            }
        }

        private void Adicionar(object sender, EventArgs e)
        {
            operacao = 0;

            this.nupPosicao.Enabled = false;
            this.chkAtivo.Checked = true;
            this.nupPosicao.Maximum = tbNovidades.Maximum + 1;
           
            this.nupPosicao.Value = this.nupPosicao.Maximum;

            this.tbNovidades.Enabled = false;
            this.txtCodigo.Text = string.Empty;

            this.pbImagem.Image = Properties.Resources.LogoComCortina2;
            imageLocation = string.Empty;
            this.btnSalvar.Enabled = true; this.pnSC.Visible = true; this.pbSalvar.Enabled = true;
            this.btnCancelar.Enabled = true; this.pbCancelar.Enabled = true;
            this.gbNovidades.Enabled = true;

            this.pbAdicionar.Enabled = false; this.btnAdicionar.Enabled = false;
            this.btnAlterar.Enabled = false; this.pbAlterar.Enabled = false;
            this.btnExcluir.Enabled = false; this.pbExcluir.Enabled = false;

        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.gbNovidades.Enabled = false;
            this.pbAdicionar.Enabled = true; this.btnAdicionar.Enabled = true;
            this.btnAlterar.Enabled = true; this.pbAlterar.Enabled = true;
            this.btnExcluir.Enabled = true; this.pbExcluir.Enabled = true;

            this.tbNovidades.Enabled = true;
            this.txtCodigo.Text = string.Empty;
            this.btnSalvar.Enabled = false; this.pnSC.Visible = false; this.pbSalvar.Enabled = false;
         
            this.btnCancelar.Enabled = false; this.pbCancelar.Enabled = false;

            this.nupPosicao.Maximum = this.tbNovidades.Maximum;
            this.nupPosicao.Value = tbNovidades.Value;
            Oracle.DataAccess.Client.OracleDataReader dr;
            nov.INDEX_BANNER = this.tbNovidades.Value;
            dr = nov.Consultar();
            if (dr.Read())
            {
                this.txtCodigo.Text = dr["ID_BANNER"].ToString();

                if (dr["URL_IMG"].ToString() == string.Empty)
                {
                    this.pbImagem.Image = Properties.Resources.LogoComCortina2;
                    imageLocation = string.Empty;
                }
                else
                {
                    this.pbImagem.ImageLocation = dr["URL_IMG"].ToString();
                }
                if (dr["ATIVO"].ToString() == "1")
                {
                    this.chkAtivo.Checked = true;
                }
                else
                {
                    this.chkAtivo.Checked = false;
                }
            }
        }

        int IndexAntiga;

        BLL.Novidades nov = new BLL.Novidades();
        private void Alterar(object sender, EventArgs e)
        {
            try
            {
                this.nupPosicao.Enabled = true;
                IndexAntiga = -1;
                if (this.tbNovidades.Maximum < 0) { MessageBox.Show("Nenhuma novidade cadastrada!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                this.gbNovidades.Enabled = true;
                this.nupPosicao.Maximum = this.tbNovidades.Maximum;
                this.nupPosicao.Value = tbNovidades.Value;
                IndexAntiga = Convert.ToInt32(nupPosicao.Value);
                Oracle.DataAccess.Client.OracleDataReader dr;
                nov.INDEX_BANNER = this.tbNovidades.Value;
                dr = nov.Consultar();
                if (dr.Read())
                {
                    this.txtCodigo.Text = dr["ID_BANNER"].ToString();
                    this.pbImagem.ImageLocation = dr["URL_IMG"].ToString();
                    if (dr["ATIVO"].ToString()=="1")
                    {
                        this.chkAtivo.Checked = true;
                    }
                    else
                    {
                        this.chkAtivo.Checked = false;
                    }
                }
              
              
                operacao = 1;
                this.btnSalvar.Enabled = true; this.pnSC.Visible = true; this.pbSalvar.Enabled = true;
             
                this.btnCancelar.Enabled = true; this.pbCancelar.Enabled = true;


                this.tbNovidades.Enabled = false;

                this.pbAdicionar.Enabled = false; this.btnAdicionar.Enabled = false;
                this.btnAlterar.Enabled = false; this.pbAlterar.Enabled = false;
                this.btnExcluir.Enabled = false; this.pbExcluir.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }

        private void Salvar(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Deseja Salvar?", "ATENÇÃO ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; }
                Oracle.DataAccess.Client.OracleDataReader dr;
                if (this.chkAtivo.Checked)
                {
                    nov.ATIVO = 1;
                }
                else
                {
                    nov.ID_BANNER = Convert.ToInt32(this.txtCodigo.Text);
                    dr = nov.ConsultarAtivo();
                    if (!dr.Read())
                    {
                        MessageBox.Show("O Banner necessita de pelo menos uma Novidade ativa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.chkAtivo.Checked = true;
                        return;
                    }
                    nov.ATIVO = 0;
                }
                nov.URL_IMG = this.pbImagem.ImageLocation;
                nov.INDEX_BANNER = Convert.ToInt32(this.nupPosicao.Value);
                switch (operacao)
                {
                    case 0:
                        nov.Novidades_crud('I');
                        break;
                    case 1:
                        nov.ID_BANNER = Convert.ToInt32
                            (this.txtCodigo.Text);
                        
                        nov.INDEX_BANNER = Convert.ToInt32(this.nupPosicao.Value);
                        dr = nov.Consultar();
                        if (dr.Read())
                        {
                        
                            if (dr["ID_BANNER"].ToString() != this.txtCodigo.Text)
                            {
                                nov.MudarDeLugar(IndexAntiga);
                                //if (this.tbNovidades.Value == this.tbNovidades.Maximum)
                                //{
                                //    int NovoIndex = this.tbNovidades.Value - 1;
                                //}
                                //else
                                //{
                                //    int NovoIndex = this.tbNovidades.Value + 1;
                                //}
                            }
                            nov.Novidades_crud('A');
                        }
                        
                        break;
                }
                MessageBox.Show("Operação realizada com sucesso!");

                btnSalvar.Cursor = Cursors.Hand;
                ConsultarTamanho();

                this.pbAdicionar.Enabled = true; this.btnAdicionar.Enabled = true;
                this.btnAlterar.Enabled = true; this.pbAlterar.Enabled = true;
                this.btnExcluir.Enabled = true; this.pbExcluir.Enabled = true;
                this.pbImagem.Image = Properties.Resources.LogoComCortina2;
                imageLocation = string.Empty;
                this.tbNovidades.Enabled = true;
                this.txtCodigo.Text = string.Empty;
                this.btnSalvar.Enabled = false; this.pnSC.Visible = false; this.pbSalvar.Enabled = false;
                this.btnCancelar.Enabled = false; this.pbCancelar.Enabled = false;
              
                this.gbNovidades.Enabled = false;

                CarregarBanner();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void Excluir(object sender, EventArgs e)
        {
            try
            {
                if (this.tbNovidades.Maximum==0)
                {
                    MessageBox.Show("O Banner necessita de pelo menos uma Novidade!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                MessageBox.Show("Essa operação pode ocasionar na perda de dados e até mesmo no mal funcionamento do sistema!", "ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (MessageBox.Show("Deseja Excluir?", "ATENÇÃO ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; }
                

                nov.ID_BANNER = Convert.ToInt32(this.txtCodigo.Text);
                nov.INDEX_BANNER = Convert.ToInt32(this.nupPosicao.Value);                  
                if (this.nupPosicao.Value != this.tbNovidades.Maximum)
                {
                    for (int Index = Convert.ToInt32(this.nupPosicao.Value); Index < nupPosicao.Maximum; Index++)
                    {
                        nov.INDEX_BANNER = Index+1;
                        nov.MudarDeLugar(Index);
                    }
                   
                }

                nov.Novidades_crud('D');
                MessageBox.Show("Operação realizada com sucesso!");
                CarregarBanner();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }






        //////////////////////////////
    }
}
