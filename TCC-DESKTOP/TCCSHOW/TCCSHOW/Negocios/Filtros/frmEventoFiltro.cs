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
    public partial class frmEventoFiltro : Modelos.ModeloFiltro
    {
        public frmEventoFiltro()
        {
            InitializeComponent();
            this.rbTitulo.Checked = true;
        }

        private string _tipo;
        public string tipo { get => _tipo; set => _tipo = value; }


        private string _tNome;
        public string tNome { get => _tNome; set => _tNome = value; }

        private string _tTipoPag;
        public string tTipoPag { get => _tTipoPag; set => _tTipoPag = value; }

        private int _tNArt;
        public int tNArt { get => _tNArt; set => _tNArt = value; }

        private int _tID;
        public int tID { get => _tID; set => _tID = value; }


  


        private void CarregarCampos(object o, EventArgs e)
        {
            foreach (RadioButton Rb in this.gbPrincipal.Controls.OfType<RadioButton>())
            {
                Rb.Checked = false;
            }
            switch (_tipo)
            {
                case "Codigo":
                case "EV.ID_EVENTO":
                    this.rbCodigo.Checked = true;
                    break;
                case "Titulo":
                case "EV.TITULO":
                    this.rbTitulo.Checked = true;
                    break;
                case "Valor":
                case "EV.VALOR_EVENTO":
                    this.rbValor.Checked = true;
                    break;
                case "Descricao":
                case "EV.DESCRICAO":
                    this.rbDescricao.Checked = true;
                    break;
            }

            if (_tTipoPag != string.Empty && _tTipoPag != null)
            {
                this.chkTipoPag.Checked = true;
                switch (_tTipoPag)
                {
                    case "Bilheteria":
                        this.rbBilheteria.Checked = true;
                        this.rbCache.Checked = false;
                        break;
                    case "Cachê Fixo":
                        this.rbBilheteria.Checked = false;
                        this.rbCache.Checked = true;
                        break;
                }

            }

            if (_tNArt > 0)
            {
                this.chkNArts.Checked = true;
                this.nupNArt.Value = _tNArt;
            }

            if (_tNome != null && _tNome != string.Empty)
            {

                this.txtNome.Text = _tNome;
                this.pbRemover.Visible = true;
                this.btnRemover.Visible = true;

            }
        }




        private void chkTipoPag_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkTipoPag.Checked)
            {
                foreach (RadioButton rb in gbTipoPag.Controls.OfType<RadioButton>())
                {
                    rb.Enabled = true;
                }
            }
            else
            {
                foreach (RadioButton rb in gbTipoPag.Controls.OfType<RadioButton>())
                {
                    rb.Enabled = false;
                }
            }
        }

        private void ProcurarArtista(object sender, EventArgs e)
        {
            frmProcurarArtista f = new frmProcurarArtista();
            f.TopMost = true;
            f.idFunc = this.idFunc; f.ShowDialog();
            if (f.FormNome!=null)
            {
                _tID = f.FormId;
                txtNome.Text = f.FormNome;
            }
          

            if (this.txtNome.Text.Replace(" ", "") != string.Empty)
            {
                this.pbRemover.Visible = true;
                this.btnRemover.Visible = true;

            }
        }

        private void RemoverArtista(object sender, EventArgs e)
        {
            this.txtNome.Text = string.Empty;
           _tNome = string.Empty;
            _tID = 0;
            this.pbRemover.Visible = false;
            this.btnRemover.Visible = false;

        }

        private void chkNArts_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkNArts.Checked)
            {
                this.gbNArts.Enabled = true;
            }
            else
            {
                this.gbNArts.Enabled = false;
            }
        }




        private void CheckedChangedGERAL(object sender, EventArgs e)
        {
            var b = (RadioButton)sender;
            if (b.Checked)
            {
                switch (b.Name.Replace("rb", ""))
                {
                    case "Codigo":

                        break;
                    case "Nome":

                        break;
                    case "Telefone":

                        break;


                }
                _tipo = b.Name.Replace("rb", "");
            }

        }

        private void Aplicar(object sender, EventArgs e)
        {

            

            _tNome = txtNome.Text;
            

            if (this.chkNArts.Checked)
            {
                _tNArt = Convert.ToInt32(nupNArt.Value);
            }
            else
            {
                _tNArt = 0;
            }
            if (this.chkTipoPag.Checked)
            {
                if (this.rbBilheteria.Checked)
                {
                    _tTipoPag = "Bilheteria";
                }
                else
                {
                    _tTipoPag = "Cachê Fixo";
                }
            }
            else
            {
               _tTipoPag = string.Empty;
            }
           
            this.Dispose();
        }


        ////////////////////
    }
}
