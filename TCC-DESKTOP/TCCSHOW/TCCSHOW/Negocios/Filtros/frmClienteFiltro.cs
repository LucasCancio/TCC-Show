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
    public partial class frmClienteFiltro : Modelos.ModeloFiltro
    {
        public frmClienteFiltro()
        {
            InitializeComponent();
            this.cbData.SelectedIndex = 0;

        }



        private string _tipo;
        public string tipo { get => _tipo; set => _tipo = value; }


        private string _tipo2;
        public string tipo2 { get => _tipo2; set => _tipo2 = value; }

        private string _tTitulo;
        public string tTitulo { get => _tTitulo; set => _tTitulo = value; }

        private int _tID;
        public int tID { get => _tID; set => _tID = value; }


        private void RemoverEvento(object sender, EventArgs e)
        {
            this.txtTitulo.Text = string.Empty;
            _tID = 0;
            this.tTitulo = string.Empty;
            this.pbRemover.Visible = false;
            this.btnRemover.Visible = false;
        }

        private void CarregarCampos(object o, EventArgs e)
        {
            foreach (RadioButton Rb in this.gbPrincipal.Controls.OfType<RadioButton>())
            {
                Rb.Checked = false;
            }
            switch (_tipo)
            {
                case "Codigo":
                case "CLI.ID_CLIENTE":
                    this.rbCodigo.Checked = true;
                    break;
                case "Nome":
                case "P.NOME":
                    this.rbNome.Checked = true;
                    break;
                case "Usuario":
                case "LG.USUARIO":
                    this.rbUsuario.Checked = true;
                    break;
                case "CPF":
                case "CLI.CPF":
                    this.rbCPF.Checked = true;
                    break;
                case "Email":
                case "CLI.EMAIL":
                    this.rbEmail.Checked = true;
                    break;
            }

            if (_tipo2 != null && _tipo2 != string.Empty)
            {
                this.chkDataEsp.Checked = true;
                this.cbData.Text = _tipo2;
            }

            if (_tTitulo != null && _tTitulo != string.Empty)
            {

                this.txtTitulo.Text = _tTitulo;
                this.pbRemover.Visible = true;
                this.btnRemover.Visible = true;

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

        private void ProcurarEvento(object sender, EventArgs e)
        {
            Negocios.Filtros.frmProcurarEvento f = new Negocios.Filtros.frmProcurarEvento();
            f.TopMost = true;
            f.idFunc = this.idFunc; f.ShowDialog();
            if (f.FormTitulo!=null)
            {
                _tID = f.FormID;
                txtTitulo.Text = f.FormTitulo;
            }
           
           
            if (this.txtTitulo.Text.Replace(" ", "") != string.Empty)
            {
                this.pbRemover.Visible = true;
                this.btnRemover.Visible = true;

            }

        }

        private void Aplicar(object sender, EventArgs e)
        {

            _tipo = tipo;

            _tTitulo = txtTitulo.Text;
            

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

        private void chkDataEsp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkDataEsp.Checked)
            {
                this.gbDataEsp.Enabled = true;
                _tipo2 = this.cbData.Text;
            }
            else
            {
                this.gbDataEsp.Enabled = false;
                _tipo2 = string.Empty;
            }
        }



        ////////////////
    }
}
