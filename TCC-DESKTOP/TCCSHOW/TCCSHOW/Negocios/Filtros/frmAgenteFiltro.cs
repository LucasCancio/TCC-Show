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
    public partial class frmAgenteFiltro : Modelos.ModeloFiltro
    {
        public frmAgenteFiltro()
        {
            InitializeComponent();
            this.chkEmpresa.Checked = true;
            this.chkEmpresario.Checked = true;
            this.rbNome.Checked = true;
            this.cbData.SelectedIndex = 0;
        }


        private string _tipo;
        public string tipo { get => _tipo; set => _tipo = value; }
       

        private string _tipo2;
        public string tipo2 { get => _tipo2; set => _tipo2 = value; }

        private string _tipo3;
        public string tipo3 { get => _tipo3; set => _tipo3 = value; }

        private string _tCod;
        public string tCod { get => _tCod; set => _tCod = value; }

     

       

        private void CarregarCampos(object o, EventArgs e) {
            switch (_tipo)
            {
                case "Codigo":

                    this.rbCodigo.Checked = true;
                    
                        foreach (RadioButton item in gbEmpresario.Controls.OfType<RadioButton>())
                        {
                            item.Checked = false;
                        }
                        foreach (RadioButton item in gbEmpresa.Controls.OfType<RadioButton>())
                        {
                            item.Checked = false;
                        }
                        if (tCod != string.Empty)
                        {
                            switch (tCod)
                            {
                                case "Empresa":
                                    this.chkEmpresa.Checked = true;
                                    this.chkEmpresario.Checked = false;
                                    break;
                                case "Empresario":
                                    this.chkEmpresario.Checked = true;
                                    this.chkEmpresa.Checked = false;
                                    break;
                            }

                        }
                    
                    break;

                case "CPF":
                    this.chkEmpresario.Checked = true;
                    this.chkEmpresa.Checked = false;
                    rbCodigo.Checked = false;
                    rbCPF.Checked = true;
                    break;
                case "NomeCivil":
                    this.chkEmpresario.Checked = true;
                    this.chkEmpresa.Checked = false;
                    rbCodigo.Checked = false;
                    rbNomeCivil.Checked = true;
                    break;
                case "NomeSocial":
                    this.chkEmpresario.Checked = true;
                    this.chkEmpresa.Checked = false;
                    rbCodigo.Checked = false;
                    rbNomeSocial.Checked = true;
                    break;
                case "CNPJ":
                    this.chkEmpresario.Checked = false;
                    this.chkEmpresa.Checked = true;
                    rbCodigo.Checked = false;
                    rbCNPJ.Checked = true;
                    break;
                case "NomeFant":
                    this.chkEmpresario.Checked = false;
                    this.chkEmpresa.Checked = true;
                    rbCodigo.Checked = false;
                    rbNomeFant.Checked = true;
                    break;
                case "RazSocial":
                    this.chkEmpresario.Checked = false;
                    this.chkEmpresa.Checked = true;
                    rbCodigo.Checked = false;
                    rbRazSocial.Checked = true;
                    break;
            }
            if (_tipo2!=null && _tipo2!=string.Empty)
            {
                this.chkDataEsp.Checked = true;
                this.cbData.Text = _tipo2;
            }
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

        private void CheckedChange(object sender, EventArgs e)
        {
            if (this.chkEmpresa.Checked && !this.chkEmpresario.Checked)
            {
                this.gbEmpresa.Enabled = true;
                this.gbEmpresario.Enabled = false;
                foreach (RadioButton item in gbEmpresario.Controls.OfType<RadioButton>())
                {
                    item.Checked = false;
                }

                this.rbNome.Checked = false;
                
                this.rbNome.Enabled = false;
                this.rbCodigo.Checked = true;

            }
            else if(chkEmpresario.Checked && !this.chkEmpresa.Checked)
            {
                this.gbEmpresa.Enabled = false;
                this.gbEmpresario.Enabled = true;
                foreach (RadioButton item in gbEmpresa.Controls.OfType<RadioButton>())
                {
                    item.Checked = false;
                }

                this.rbNome.Checked = false;
                
                this.rbNome.Enabled = false;
                this.rbCodigo.Checked = true;

            }
            else if (!chkEmpresario.Checked && !this.chkEmpresa.Checked)
            {
                this.chkEmpresa.Checked = true;
                this.chkEmpresario.Checked = true;
                this.rbCodigo.Checked = true;
            }
            else
            {
                this.gbEmpresa.Enabled = false;
                this.gbEmpresario.Enabled = false;
                foreach (RadioButton item in gbEmpresario.Controls.OfType<RadioButton>())
                {
                    item.Checked = false;
                }
                foreach (RadioButton item in gbEmpresa.Controls.OfType<RadioButton>())
                {
                    item.Checked = false;
                }

                this.rbNome.Enabled =true;
                this.rbCodigo.Checked = true;
              
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
                        if (this.rbCodigo.Checked)
                        {
                            foreach (RadioButton item in gbEmpresario.Controls.OfType<RadioButton>())
                            {
                                item.Checked = false;
                            }
                            foreach (RadioButton item in gbEmpresa.Controls.OfType<RadioButton>())
                            {
                                item.Checked = false;
                            }
                        }
                        break;
                    case "CPF":
                    case "NomeCivil":
                    case "NomeSocial":
                        rbCodigo.Checked = false;
                        break;
                    case "CNPJ":
                    case "NomeFant":
                    case "RazSocial":
                        rbCodigo.Checked = false;
                        break;
                }
                _tipo = b.Name.Replace("rb", "");
            }
           
        }

        private void Aplicar(object sender, EventArgs e)
        {
            foreach (RadioButton rb in gbEmpresario.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    _tipo = rb.Name.Replace("rb", "");
                }
            }
            foreach (RadioButton rb in gbEmpresa.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    _tipo = rb.Name.Replace("rb", "");
                }
            }
            foreach (RadioButton rb in pnFiltro.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    _tipo = rb.Name.Replace("rb", "");
                }
            }
          
            if (this.chkEmpresa.Checked && !this.chkEmpresario.Checked)
            {
                _tipo3 = "Empresa";
                _tCod = "Empresa";
            }
            else if (this.chkEmpresario.Checked && !this.chkEmpresa.Checked)
            {
                _tipo3 = "Empresario";
                _tCod = "Empresario";
            }
            else
            {
                _tipo3 = "Ambos";
                _tCod = string.Empty;
            }
            

            this.Dispose();
        }


        /////////////////////////
    }
}
