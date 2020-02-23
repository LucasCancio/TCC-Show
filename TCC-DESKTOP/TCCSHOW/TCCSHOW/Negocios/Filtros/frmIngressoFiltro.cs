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
    public partial class frmIngressoFiltro : Modelos.ModeloFiltro
    {
        public frmIngressoFiltro()
        {
           
            InitializeComponent();
            this.cbData.SelectedIndex = 0;
            this.cbFileira.SelectedIndex = 0;
            this.cbNumero.SelectedIndex = 0;
            this.cbTipo.SelectedIndex = 0;
            this.cbCategoria.SelectedIndex = 0;
            cbNumero.DropDownHeight = cbNumero.ItemHeight * 5;
        }



        private string _tipo;
        public string tipo { get => _tipo; set => _tipo = value; }


        private string _tipo2;
        public string tipo2 { get => _tipo2; set => _tipo2 = value; }

        private string _tNumero;
        public string tNumero { get => _tNumero; set => _tNumero = value; }

        private string _tFileira;
        public string tFileira { get => _tFileira; set => _tFileira = value; }


        private string _tCategoria;
        public string tCategoria { get => _tCategoria; set => _tCategoria = value; }


        private string _tTipoAssento;
        public string tTipoAssento { get => _tTipoAssento; set => _tTipoAssento = value; }

        private void CarregarCampos(object o, EventArgs e)
        {

            foreach (RadioButton Rb in this.gbPrincipal.Controls.OfType<RadioButton>())
            {
                Rb.Checked = false;
            }
            switch (_tipo)
            {
                case "Valor Total":
                case "TB_EVENTO_INGRESSO.PRECO_TOTAL":
                    this.rbValor.Checked = true;
                    break;
                case "Titulo":
                case "EV.TITULO":
                    this.rbTitulo.Checked = true;
                    break;
                case "Cod":
                case "TB_VENDA_INGRESSO.ID_VENDA":
                    this.rbCod.Checked = true;
                    break;

            }

            if (_tipo2 != null && _tipo2 != string.Empty)
            {
                switch (_tipo2)
                {
                    case "TB_VENDA_INGRESSO.DATAVENDA":
                    case "Venda":
                        _tipo2 = "Venda";
                        break;
                    case "EV.DATA_EVENTO":
                    case "Evento":
                        _tipo2 = "Evento";
                        break;
                    case null: case "":
                        break;
                }
                this.cbData.Text = _tipo2;

            }
            if (_tNumero !=string.Empty && _tNumero!=null)
            {
                this.cbNumero.Text = _tNumero;
            }
            if (_tFileira !=string.Empty && _tFileira != null)
            {
                this.cbFileira.Text = _tFileira;
            }
            if (_tCategoria !=string.Empty && _tCategoria != null)
            {
                this.cbCategoria.Text = _tCategoria;
            }
            if (_tTipoAssento !=string.Empty && _tTipoAssento != null)
            {
                this.cbTipo.Text = _tTipoAssento;
            }
        }

        private void MudarColecoes(object sender, EventArgs e)
        {
            cbNumero.Items.Clear();
            cbCategoria.Items.Clear();
            cbTipo.Items.Clear();
            this.cbNumero.Items.Add("Todos");
            switch (cbFileira.Text)
            {
                case "A":
                    for (int i = 12; i < 17; i++)
                    {
                        this.cbNumero.Items.Add(i.ToString());
                    }
                    this.cbCategoria.Items.Add("Ouro");

                    this.cbTipo.Items.Add("Especial");

                    break;
                case "B":
                    for (int i = 1; i < 28; i++)
                    {
                        this.cbNumero.Items.Add(i.ToString());
                    }
                    this.cbCategoria.Items.Add("Ouro");

                    this.cbTipo.Items.Add("Simples");
                    break;
                case "C":
                    this.cbNumero.Items.Add("1e2");
                    this.cbNumero.Items.Add("4e5");
                    this.cbNumero.Items.Add("7e8");
                    this.cbNumero.Items.Add("10e11");
                    this.cbNumero.Items.Add("13e14");
                    this.cbNumero.Items.Add("15e16");
                    this.cbNumero.Items.Add("18e19");
                    this.cbNumero.Items.Add("21e22");
                    this.cbNumero.Items.Add("24e25");
                    this.cbNumero.Items.Add("27e28");

                    this.cbCategoria.Items.Add("Ouro");

                    this.cbTipo.Items.Add("Duplo");
                    break;
                case "D":
                    for (int i = 1; i < 28; i++)
                    {
                        this.cbNumero.Items.Add(i.ToString());
                    }
                    this.cbCategoria.Items.Add("Prata");

                    this.cbTipo.Items.Add("Simples");
                    break;
                case "E":
                    for (int i = 1; i < 28; i++)
                    {
                        this.cbNumero.Items.Add(i.ToString());
                    }
                    this.cbCategoria.Items.Add("Prata");

                    this.cbTipo.Items.Add("Todos");
                    this.cbTipo.Items.Add("Especial");
                    this.cbTipo.Items.Add("Simples");
                    break;
                case "F":
                    for (int i = 1; i < 28; i++)
                    {
                        this.cbNumero.Items.Add(i.ToString());
                    }
                    this.cbCategoria.Items.Add("Bronze");

                    this.cbTipo.Items.Add("Simples");
                    break;
                case "G":
                    for (int i = 1; i < 28; i++)
                    {
                        this.cbNumero.Items.Add(i.ToString());
                    }
                    this.cbCategoria.Items.Add("Bronze");

                    this.cbTipo.Items.Add("Simples");
                    break;
                case "H":
                    for (int i = 1; i < 28; i++)
                    {
                        this.cbNumero.Items.Add(i.ToString());
                    }
                    this.cbCategoria.Items.Add("Bronze");

                    this.cbTipo.Items.Add("Simples");
                    break;
                default://TODAS
                    
                    for (int i =1 ; i < 28; i++)
                    {
                        this.cbNumero.Items.Add(i.ToString());
                    }
                    this.cbCategoria.Items.Add("Todas");
                    this.cbCategoria.Items.Add("Ouro");
                    this.cbCategoria.Items.Add("Prata");
                    this.cbCategoria.Items.Add("Bronze");

                    this.cbTipo.Items.Add("Todos");
                    this.cbTipo.Items.Add("Duplo");
                    this.cbTipo.Items.Add("Especial");
                    this.cbTipo.Items.Add("Simples");

                    break;
            }
            this.cbNumero.SelectedIndex = 0;
            this.cbTipo.SelectedIndex = 0;
            this.cbCategoria.SelectedIndex = 0;
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
            _tFileira = cbFileira.Text;
            _tNumero = cbNumero.Text;
            _tTipoAssento = cbTipo.Text;
            _tCategoria = cbCategoria.Text;

            _tipo2 = this.cbData.Text;
          

            this.Close();
        }

        private void MudarCategoria(object sender, EventArgs e)
        {
            cbTipo.Items.Clear();
            switch (cbCategoria.Text)
            {
                case"Bronze":
                    this.cbTipo.Items.Add("Simples");
                    break;
                case "Prata":
                    this.cbTipo.Items.Add("Todos");
                    this.cbTipo.Items.Add("Especial");
                    this.cbTipo.Items.Add("Simples");
                    break;
                case "Ouro":
                    this.cbTipo.Items.Add("Todos");
                    this.cbTipo.Items.Add("Duplo");
                    this.cbTipo.Items.Add("Especial");
                    break;
                default:
                    this.cbTipo.Items.Add("Todos");
                    this.cbTipo.Items.Add("Duplo");
                    this.cbTipo.Items.Add("Especial");
                    this.cbTipo.Items.Add("Simples");
                    break;
            }
        }





        ///////////////////////
    }
}
