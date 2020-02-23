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
    public partial class frmFuncionarioFiltro : Modelos.ModeloFiltro
    {
        public frmFuncionarioFiltro()
        {

            InitializeComponent();
            this.cbData.SelectedIndex = 0;
        }

        private string _tipo;
        public string tipo { get => _tipo; set => _tipo = value; }


        private string _tipo2;
        public string tipo2 { get => _tipo2; set => _tipo2 = value; }

      
        private string _tFuncao;
        public string tFuncao { get => _tFuncao; set => _tFuncao = value; }






        private void CarregarCampos(object o, EventArgs e)
        {
            CarregarCBFuncao();
            foreach (RadioButton Rb in this.gbPrincipal.Controls.OfType<RadioButton>())
            {
                Rb.Checked = false;
            }
            switch (_tipo)
            {
                case "Codigo":
                case "F.ID_FUNC":
                    this.rbCodigo.Checked = true;
                    break;
                case "Nome":
                case "P.NOME":
                    this.rbNome.Checked = true;
                    break;
                case "CPF":
                case "F.CPF":
                    this.rbCPF.Checked = true;
                    break;
                case "Email":
                case "F.EMAIL":
                    this.rbEmail.Checked = true;
                    break;
                case "Telefone":
                case "F.TELEFONE":
                    this.rbTelefone.Checked = true;
                    break;
            }

            if (_tipo2 != null && _tipo2 != string.Empty)
            {
                switch (_tipo2)
                {
                    case "P.DATA_CRIACAO":
                    case "Contratação":
                        _tipo2 = "Contratação";
                        break;
                    case "P.DATA_NASC":
                    case "Nascimento":
                        _tipo2 = "Nascimento";
                        break;
                    case null: case "":
                        break;
                }
                this.chkDataEsp.Checked = true;
                this.cbData.Text = _tipo2;

            }

            if (_tFuncao != null && _tFuncao != string.Empty)
            {
                this.chkFuncao.Checked = true;
                this.cbFuncao.Text = tFuncao.ToUpper();             

            }
        }




        private void chkFuncao_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkFuncao.Checked)
            {
                this.cbFuncao.Enabled = true;
            }
            else
            {
                this.cbFuncao.Enabled = false;
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

            
            if (this.chkFuncao.Checked)
            {
                _tFuncao = cbFuncao.Text;
            }
            else
            {
                _tFuncao = string.Empty;
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



        private void CarregarCBFuncao()
        {
            try
            {
                this.erro.SetError(this.cbFuncao, String.Empty);

                BLL.Funcao cont = new BLL.Funcao();


                this.cbFuncao.DataSource = cont.ListarComboBox().Tables[0];
                this.cbFuncao.DisplayMember = "FUNCAO".ToLower();
                this.cbFuncao.ValueMember = "ID_FUNCAO";
                this.cbFuncao.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                this.erro.SetError(this.cbFuncao, "Nenhuma Função cadastrada!");
                MessageBox.Show(ex.Message);




            }
        }

        ///////////////////////
    }
}
