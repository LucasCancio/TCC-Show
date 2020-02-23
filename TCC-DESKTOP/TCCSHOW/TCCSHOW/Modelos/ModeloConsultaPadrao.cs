using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Modelos
{
    public partial class ModeloConsultaPadrao : ModeloPadrao
    {
        public ModeloConsultaPadrao()
        {
            InitializeComponent();
            this.dtpHorarioFinal.MinDate = this.dtpHorarioInicio.Value;
            this.dtpHorarioInicio.MaxDate = this.dtpHorarioFinal.Value;
            
            this.dtpHorarioFinal.Value = Convert.ToDateTime(DateTime.Now.AddDays(1).ToString().Substring(0,10));
            this.dtpHorarioInicio.Value = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToString().Substring(0, 10));
        }

        public string tipo = "", tipo2;

        private void dtpHorarioFinal_ValueChanged(object sender, EventArgs e)
        {
            this.dtpHorarioFinal.MinDate = this.dtpHorarioInicio.Value;
            this.dtpHorarioInicio.MaxDate = this.dtpHorarioFinal.Value;
        }

        private void ModeloConsultaPadrao_Load(object sender, EventArgs e)
        {
            if (NivelAcesso == 2)
            {
                this.btnExcluir.Visible = false;
                this.pbExcluir.Visible = false;
            }
        }

        private void AvisoExcluir(object sender, EventArgs e)
        {
            MessageBox.Show("Essa operação pode ocasionar na perda de dados e até mesmo no mal funcionamento do sistema!" , "ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1); 
        }

        private void AbrirFiltro2(object sender, EventArgs e)
            {

            //if (this.gbFiltro.Height != 91)// FECHAR
            //{
            //    pnDGV.Width = pnDGV.Width + gbFiltro.Width;
            //    gbFiltro.Height = 91;
            //}
            //else// ABRIR
            //{
            //    pnDGV.Width = pnDGV.Width - gbFiltro.Width;
            //    gbFiltro.Height = gbFiltro.Height + pnDGV.Height+8;
            //}


        }

    }
}
