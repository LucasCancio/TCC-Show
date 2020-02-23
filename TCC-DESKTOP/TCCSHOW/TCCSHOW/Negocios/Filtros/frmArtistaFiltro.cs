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
    public partial class frmArtistaFiltro : Modelos.ModeloFiltro
    {
        public frmArtistaFiltro()
        {
            InitializeComponent();

            this.chkArt.Checked = true;
            this.chkArtF.Checked = true;
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



        private void CarregarCampos(object o, EventArgs e)
        {
            switch (_tipo)
            {
                case "Codigo":

                    this.rbCodigo.Checked = true;

                    foreach (RadioButton item in gbArt.Controls.OfType<RadioButton>())
                    {
                        item.Checked = false;
                    }
                    foreach (RadioButton item in gbArtF.Controls.OfType<RadioButton>())
                    {
                        item.Checked = false;
                    }
                    this.chkDoc.Checked = false;
                    if (_tCod != string.Empty)
                    {
                        switch (_tCod)
                        {
                            case "Artista":
                                this.chkArt.Checked = true;
                                this.chkArtF.Checked = false;
                                break;
                            case "ArtistaFixo":
                                this.chkArtF.Checked = true;
                                this.chkArt.Checked = false;
                                break;
                        }

                    }

                    break;

                case "CPFEmpresario":
                    this.chkArt.Checked = true;
                    this.chkArtF.Checked = false;
                    rbCodigo.Checked = false;
                    chkDoc.Checked = true;
                    rbCPFEmpresario.Checked = true;
                    break;
                case "CNPJEmpresario":
                    this.chkArt.Checked = true;
                    this.chkArtF.Checked = false;
                    rbCodigo.Checked = false;
                    chkDoc.Checked = true;
                    rbCNPJEmpresario.Checked = true;
                    break;
                case "NomeEmpresario":
                    this.chkArt.Checked = true;
                    this.chkArtF.Checked = false;
                    rbCodigo.Checked = false;
                    rbNomeEmpresario.Checked = true;
                    break;

                case "Nome":
                    if (_tipo3 == "Artista")
                    {
                        this.chkArt.Checked = true;
                        this.chkArtF.Checked = false;
                        rbCodigo.Checked = false;
                        rbNome.Checked = true;
                    }
                    else if (_tipo3 == "ArtistaFixo")
                    {
                        this.chkArt.Checked = false;
                        this.chkArtF.Checked = true;
                        rbCodigo.Checked = false;
                        rbNome.Checked = true;
                    }
                    else
                    {
                        this.chkArt.Checked = true;
                        this.chkArtF.Checked = true;
                        rbCodigo.Checked = false;
                        rbNome.Checked = true;

                    }

                    break;

                case "CPF":
                    this.chkArtF.Checked = true;
                    this.chkArt.Checked = false;
                    rbCodigo.Checked = false;
                    rbCPF.Checked = true;
                    break;
                case "Telefone":
                    this.chkArtF.Checked = true;
                    this.chkArt.Checked = false;
                    rbCodigo.Checked = false;
                    rbTelefone.Checked = true;
                    break;
                case "Email":
                    this.chkArtF.Checked = true;
                    this.chkArt.Checked = false;
                    rbCodigo.Checked = false;
                    rbEmail.Checked = true;
                    break;
            }
            if (_tipo2 != null && _tipo2 != string.Empty)
            {
                if (_tipo2 == "P.DATA_NASC")
                {
                    this.cbData.Text = "Nascimento";
                }
                else
                {
                    this.cbData.Text = "Contratação";
                }
                this.chkDataEsp.Checked = true;


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

        private void chkDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkDoc.Checked)
            {
                this.gbDoc.Enabled = true;
                this.rbCPFEmpresario.Checked = true;
            }
            else
            {
                this.gbDoc.Enabled = false;
                this.rbCPFEmpresario.Checked = false;
                this.rbCNPJEmpresario.Checked = false;
                if (!this.rbNomeEmpresario.Checked && !this.rbNome.Checked)
                {
                    this.rbCodigo.Checked = true;
                }




            }
        }

        private void CheckedChange(object sender, EventArgs e)
        {
            if (this.chkArt.Checked && !this.chkArtF.Checked)
            {
                this.gbArt.Enabled = true;
                this.gbArtF.Enabled = false;
                foreach (RadioButton item in gbArt.Controls.OfType<RadioButton>())
                {
                    item.Checked = false;
                }



            }
            else if (chkArtF.Checked && !this.chkArt.Checked)
            {
                this.gbArt.Enabled = false;
                this.gbArtF.Enabled = true;
                foreach (RadioButton item in gbArtF.Controls.OfType<RadioButton>())
                {
                    item.Checked = false;
                }



            }
            else if (!chkArt.Checked && !this.chkArtF.Checked)
            {
                this.chkArt.Checked = true;
                this.chkArtF.Checked = true;
                this.rbCodigo.Checked = true;
            }
            else
            {
                this.gbArtF.Enabled = false;
                this.gbArt.Enabled = false;
                foreach (RadioButton item in gbArt.Controls.OfType<RadioButton>())
                {
                    item.Checked = false;
                }
                foreach (RadioButton item in gbArtF.Controls.OfType<RadioButton>())
                {
                    item.Checked = false;
                }
                this.chkDoc.Checked = false;
                this.rbNome.Enabled = true;
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
                            foreach (RadioButton item in gbArt.Controls.OfType<RadioButton>())
                            {
                                item.Checked = false;
                            }
                            foreach (RadioButton item in gbArtF.Controls.OfType<RadioButton>())
                            {
                                item.Checked = false;
                            }
                            this.chkDoc.Checked = false;
                        }
                        break;
                    case "Nome":
                        if (this.rbNome.Checked)
                        {
                            foreach (RadioButton item in gbArt.Controls.OfType<RadioButton>())
                            {
                                item.Checked = false;
                            }
                            foreach (RadioButton item in gbArtF.Controls.OfType<RadioButton>())
                            {
                                item.Checked = false;
                            }
                            this.chkDoc.Checked = false;


                        }
                        break;
                    case "CPF":
                    case "Email":
                    case "Telefone":
                        rbCodigo.Checked = false;
                        rbNome.Checked = false;
                        break;

                    case "NomeEmpresario":
                        this.chkDoc.Checked = false;
                        this.rbCodigo.Checked = false;
                        rbNome.Checked = false;
                        break;
                    case "CNPJEmpresario":
                    case "CPFEmpresario":
                        this.rbNomeEmpresario.Checked = false;

                        rbCodigo.Checked = false;
                        rbNome.Checked = false;
                        break;
                }
                _tipo = b.Name.Replace("rb", "");
            }

        }

        private void Aplicar(object sender, EventArgs e)
        {
            foreach (RadioButton rb in gbArt.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    _tipo = rb.Name.Replace("rb", "");
                }
            }
            foreach (RadioButton rb in gbArtF.Controls.OfType<RadioButton>())
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
           
            if (this.chkDataEsp.Checked)
            {
                _tipo2 = this.cbData.Text;
            }
            else
            {
                _tipo2 = string.Empty;
            }

            if (this.chkArt.Checked && !this.chkArtF.Checked)
            {
                _tipo3 = "Artista";
                _tCod = "Artista";
            }
            else if (this.chkArtF.Checked && !this.chkArt.Checked)
            {
                _tipo3 = "ArtistaFixo";
                _tCod = "ArtistaFixo";
            }
            else
            {
                _tipo3 = "Ambos";
                _tCod = string.Empty;
            }


            this.Dispose();
        }





    }
}
