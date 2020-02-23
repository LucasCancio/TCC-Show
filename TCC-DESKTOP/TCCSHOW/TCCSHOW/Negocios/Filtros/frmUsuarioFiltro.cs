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
    public partial class frmUsuarioFiltro : Modelos.ModeloFiltro
    {
        public frmUsuarioFiltro()
        {

            InitializeComponent();
            this.cbTipoPessoa.SelectedIndex = 0;
            this.cbData.SelectedIndex = 0;
        }

        private string _tipo;
        public string tipo { get => _tipo; set => _tipo = value; }

        private string _tipo2;
        public string tipo2 { get => _tipo2; set => _tipo2 = value; }


        private string _tTipoPessoa;
        public string tTipoPessoa { get => _tTipoPessoa; set => _tTipoPessoa = value; }


       

        private void CarregarCampos(object o, EventArgs e)
        {
            foreach (RadioButton Rb in this.gbPrincipal.Controls.OfType<RadioButton>())
            {
                Rb.Checked = false;
            }
            switch (_tipo)
            {
                case "Codigo":
                case "L.ID_LOGIN":
                    this.rbCodigo.Checked = true;
                    break;
                case "Nome":
                case "P.NOME":
                    this.rbNome.Checked = true;
                    break;
                case "Usuario":
                case "L.USUARIO":
                    this.rbUsuario.Checked = true;
                    break;
                case "Pergunta":
                case "PS.DESCRICAO":
                    this.rbPergunta.Checked = true;
                    break;
               
            }

            if (_tipo2 != null && _tipo2 != string.Empty)
            {
                switch (_tipo2)
                {
                    case "P.DATA_CRIACAO":
                        tipo2 = "Contratação";
                        break;
                    case "P.DATA_NASC":
                        tipo2 = "Nascimento";
                        break;
                    case null: case "":
                        break;
                }
                this.chkDataEsp.Checked = true;
                this.cbData.Text = tipo2;

            }

            if (_tTipoPessoa != null && _tTipoPessoa != string.Empty)
            {
                this.chkTipoPessoa.Checked = true;
                this.cbTipoPessoa.Text = _tTipoPessoa.ToUpper();

            }
        }




        private void chkTipoPessoa_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkTipoPessoa.Checked)
            {
                this.cbTipoPessoa.Enabled = true;
               
            }
            else
            {
                this.cbTipoPessoa.Enabled = false;
            }
        }


        private void chkDataEsp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkDataEsp.Checked)
            {
                this.gbDataEsp.Enabled = true;
            }
            else
            {
                this.gbDataEsp.Enabled = false;
            }
        }


        private void CheckedChangedGERAL(object sender, EventArgs e)
        {
            var b = (RadioButton)sender;
            if (b.Checked)
            {

                _tipo = b.Name.Replace("rb", "");
            }

        }

        private void Aplicar(object sender, EventArgs e)
        {

           
            if (this.chkTipoPessoa.Checked)
            {
                _tTipoPessoa = cbTipoPessoa.Text;
            }
            else
            {
                _tTipoPessoa = string.Empty;
            }
            if (this.chkDataEsp.Checked)
            {
                _tipo2 = this.cbData.Text;
            }
            else
            {
                _tipo2 = string.Empty;
            }

            this.Dispose();
        }

        private void cbTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.cbData.Items.Clear();
            if (cbTipoPessoa.Text=="Cliente")
            {
                this.cbData.Items.Add("Nascimento");
            }
            else
            {
                this.cbData.Items.Add("Nascimento");
                this.cbData.Items.Add("Contratação");

            }
            this.cbData.SelectedIndex = 0;
        }



        ///////////////////////
    }
}
