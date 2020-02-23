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
    public partial class frmContasFiltro : Modelos.ModeloFiltro
    {
        public frmContasFiltro()
        {
            
            InitializeComponent();
            this.rbTodos.Checked = true;
           
        }

        private string _tipo;
        public string tipo { get => _tipo; set => _tipo = value; }


        private string _tipo2;
        public string tipo2 { get => _tipo2; set => _tipo2 = value; }

        private string _tSit;
        public string tSit { get => _tSit; set => _tSit = value; }

        private string _tTipoPag;
        public string tTipoPag { get => _tTipoPag; set => _tTipoPag = value; }
       

        private string _tData;
        public string tData { get => _tData; set => _tData = value; }



        private void MudarSituacao(object sender, EventArgs e)
        {
            if (this.rbPagar.Checked)
            {
                this.chkSituacao.Enabled = true;
                this.chkSituacao.Visible = true;
                this.cbSituacao.Items.Clear();
                this.cbSituacao.Items.Add("Paga");
                this.cbSituacao.Items.Add("Nao paga");
                this.cbSituacao.SelectedIndex = 0;

                this.cbData.Items.Clear();
                this.cbData.Items.Add("Lançamento");
                this.cbData.Items.Add("Pagamento");
                this.cbData.SelectedIndex = 0;

            }
            else if(this.rbReceber.Checked)
            {
                this.chkSituacao.Enabled = true;
                this.chkSituacao.Visible = true;
                this.cbSituacao.Items.Clear();
                this.cbSituacao.Items.Add("Recebida");
                this.cbSituacao.Items.Add("Nao recebida");
                this.cbSituacao.SelectedIndex = 0;

                this.cbData.Items.Clear();
                this.cbData.Items.Add("Lançamento");
                this.cbData.Items.Add("Recebimento");
                this.cbData.SelectedIndex = 0;
            }
            else
            {
                this.chkSituacao.Checked = false;
                this.chkSituacao.Enabled = false;
                this.chkSituacao.Visible = false;

                this.cbData.Items.Clear();
                this.cbData.Items.Add("Lançamento");
                this.cbData.Items.Add("Pagamento/Recebimento");
                this.cbData.SelectedIndex = 0;

            }
            //foreach (RadioButton rb in gbTipoConta.Controls.OfType<RadioButton>())
            //{
            //    if (rb.Checked)
            //    {
            //        rb.ForeColor = Color.LightGreen;
            //    }
            //    else
            //    {
            //        rb.ForeColor = Color.White;
            //    }
            //}
           
        }

       
        private void AbrirSituacao(object sender, EventArgs e)
        {
            if (this.chkSituacao.Checked)
            {
                this.cbSituacao.Enabled = true;
            }
            else
            {
                this.cbSituacao.Enabled = false;
            }
        }

        private void AbrirTipoPag(object sender, EventArgs e)
        {
            if (this.chkTipoPag.Checked)
            {
                this.cbTipoPag.Enabled = true;
            }
            else
            {
                this.cbTipoPag.Enabled = false;
            }
        }

        private void CarregarCampos(object o, EventArgs e)
        {
            CarregarCBTipoPag();
            foreach (RadioButton Rb in this.gbPrincipal.Controls.OfType<RadioButton>())
            {
                Rb.Checked = false;
            }
            switch (_tipo)
            {
                case "Codigo":
                case "C.ID_CONTAS":
                    this.rbCodigo.Checked = true;
                    break;
                case "Departamento":
                case "C.DEPARTAMENTO":
                    this.rbDepartamento.Checked = true;
                    break;
                case "Valor":
                case "C.VALOR_TOTAL":
                    this.rbValor.Checked = true;
                    break;
                case "Descricao":
                case "C.DESCRICAO":
                    this.rbDescricao.Checked = true;
                    break;
            }
            switch (_tipo2)
            {
                case "Todas":
                    this.rbTodos.Checked = true;
                    this.rbReceber.Checked = false;
                    this.rbPagar.Checked = false;
                    break;
                case "Receber":
                    this.rbReceber.Checked = true;
                    this.rbTodos.Checked = false;
                    this.rbPagar.Checked = false;
                    break;
                case "Pagar":
                    this.rbPagar.Checked = true;
                    this.rbReceber.Checked = false;
                    this.rbTodos.Checked = false;
                    break;
            }

            if (_tTipoPag != string.Empty && _tTipoPag != null)
            {
                this.chkTipoPag.Checked = true;
                this.cbTipoPag.Text = _tTipoPag;

            }
            if (_tSit !=string.Empty && _tSit!=null)
            {
                this.chkSituacao.Checked = true;
                this.cbSituacao.Text = _tSit;
               
            }
            switch (_tData)
            {
                case "C.DATA_LANCAMENTO":
                    tData = "Lançamento";
                    break;
                case "DC.DATA_CONTA":
                    if (_tipo2=="Receber")
                    {
                        _tData = "Recebimento";
                    }
                    else if (_tipo2=="Pagar")
                    {
                        _tData = "Pagamento";
                    }
                    else
                    {
                        _tData = "Pagamento/Recebimento";
                    }
                    break;

            }

            this.cbData.Text = _tData;

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


            if (this.chkSituacao.Checked)
            {
                _tSit = this.cbSituacao.Text;

            }
            else
            {
                _tSit = string.Empty;
            }

            if (this.chkTipoPag.Checked)
            {
                _tTipoPag = this.cbTipoPag.Text;
            }
            else
            {
                _tTipoPag = string.Empty;
            }


            if (this.rbTodos.Checked)
            {
                _tipo2 = "Todas";
            }
            else if (this.rbPagar.Checked)
            {
                _tipo2 = "Pagar";
            }
            else
            {
                _tipo2 = "Receber";
            }
            
            _tData = this.cbData.Text;
            this.Dispose();
        }

        private void CarregarCBTipoPag()
        {
            try
            {
                this.erro.SetError(this.cbTipoPag, String.Empty);

                BLL.FormaPagamento cont = new BLL.FormaPagamento();


                this.cbTipoPag.DataSource = cont.ListarComboBox().Tables[0];
                this.cbTipoPag.DisplayMember = "FORMA_PAGAMENTO";
                this.cbTipoPag.ValueMember = "ID_FORMA_PAGAMENTO";
                this.cbTipoPag.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                this.erro.SetError(this.cbTipoPag, "Nenhuma Forma de Pagamento cadastrada!");
                MessageBox.Show(ex.Message);




            }
        }


        //////////////////////
    }
}
