using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Contas
{
    public partial class frmContasRelatorio : Modelos.ModeloPadrao
    {
        public frmContasRelatorio()
        {
            InitializeComponent();
            
        }

        private void CarregarCampos(object sender, EventArgs e)
        {
            this.dtpIngressosMax.MinDate = this.dtpIngressosMin.Value;
            this.dtpIngressosMin.MaxDate = this.dtpIngressosMax.Value;

            this.dtpIngressosMax.Value = Convert.ToDateTime(DateTime.Now.AddMonths(1).ToString().Substring(3, 7));
            this.dtpIngressosMin.Value = Convert.ToDateTime(DateTime.Now.AddMonths(-1).ToString().Substring(3, 7));

            this.dtpContasMax.MinDate = this.dtpContasMin.Value;
            this.dtpContasMin.MaxDate = this.dtpContasMax.Value;

            this.dtpContasMax.Value = Convert.ToDateTime(DateTime.Now.AddMonths(1).ToString().Substring(3, 7));
            this.dtpContasMin.Value = Convert.ToDateTime(DateTime.Now.AddMonths(-1).ToString().Substring(3, 7));
            CarregarContas();

        }

        private void ExibirGeral(object o, EventArgs e) {
            try
            {
                var b = (DateTimePicker)o;
                if (b.Name.IndexOf("Contas") > 0)
                {
                    
                    this.dtpContasMax.MinDate = this.dtpContasMin.Value;
                    this.dtpContasMin.MaxDate = this.dtpContasMax.Value;
                    CarregarContas();

                }
                else
                {
                   
                    this.dtpIngressosMax.MinDate = this.dtpIngressosMin.Value;
                    this.dtpIngressosMin.MaxDate = this.dtpIngressosMax.Value;
                    CarregarIngressos();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
           
        }
        private void CarregarContas()
        {
            try
            {
                chartContas.Series[0].Points.Clear();

                BLL.Contas c = new BLL.Contas();
                System.Data.DataTable dt;
                c.DataListarInicio = Convert.ToDateTime(this.dtpContasMin.Value.ToString().Substring(0, 10));
                c.DataListarFinal = Convert.ToDateTime(this.dtpContasMax.Value.ToString().Substring(0, 10));
                dt = c.ListarGrafico();
                double total = 0;
                foreach (DataRow linha in dt.Rows)
                {
                    chartContas.Series[0].Points.AddXY(linha["DATA_CONTA"], linha["VALOR"]);
                    if (linha["TIPO_CONTA"].ToString()=="Pagar")
                    {
                        chartContas.Series[0].Points[chartContas.Series[0].Points.Count-1].Color = Color.Red;
                        total = total - Convert.ToDouble(linha["VALOR"]);
                    }
                    else
                    {
                        chartContas.Series[0].Points[chartContas.Series[0].Points.Count-1].Color = Color.LimeGreen;
                        total = total + Convert.ToDouble(linha["VALOR"]);
                    }

                    

                }
                if (total > 0 )
                {
                    this.lblTotalContas.ForeColor = Color.LimeGreen;
                }
                else if(total < 0)
                {
                    this.lblTotalContas.ForeColor = Color.Red;
                }
                else {
                    this.lblTotalContas.ForeColor = Color.LightGray;
                }
                this.lblTotalContas.Text = "R$" + total.ToString();
             

                chartContas.Update();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void chkContas3D_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkContas3D.Checked)
            {
                this.chartContas.ChartAreas[0].Area3DStyle.Enable3D = true;
             
            }
            else
            {
                this.chartContas.ChartAreas[0].Area3DStyle.Enable3D = false;
               
            }
        }

        private void CheckedChangedContas(object sender, EventArgs e)
        {
            if (this.rbBarraContas.Checked)
            {
                this.chartContas.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            }
            else
            {
                this.chartContas.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
        }




        private void CarregarIngressos()
        {
            try
            {
                chartIngressos.Series[0].Points.Clear();

                BLL.Ingresso c = new BLL.Ingresso();
                System.Data.DataTable dt;
                c.DataListarInicio = Convert.ToDateTime(this.dtpIngressosMin.Value.ToString().Substring(0, 10));
                c.DataListarFinal = Convert.ToDateTime(this.dtpIngressosMax.Value.ToString().Substring(0, 10));
                dt = c.ListarGrafico();
                double total = 0;
                foreach (DataRow linha in dt.Rows)
                {
                    chartIngressos.Series[0].Points.AddXY(linha["DATA_CONTA"], Convert.ToInt32(linha["QTDE"]));
                  

                    total = total + Convert.ToDouble(linha["VALOR"]);

                }
                if (total > 0)
                {
                    this.lblTotalIngressos.ForeColor = Color.LimeGreen;
                }
                else if (total < 0)
                {
                    this.lblTotalIngressos.ForeColor = Color.Red;
                }
                else
                {
                    this.lblTotalIngressos.ForeColor = Color.LightGray;
                }
                this.lblTotalIngressos.Text = "R$" + total.ToString();


                chartIngressos.Update();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void chkIngressos3D_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkIngressos3D.Checked)
            {
                this.chartIngressos.ChartAreas[0].Area3DStyle.Enable3D = true;

            }
            else
            {
                this.chartIngressos.ChartAreas[0].Area3DStyle.Enable3D = false;

            }
        }

        private void CheckedChangedIngressos(object sender, EventArgs e)
        {
            if (this.rbBarraIngresso.Checked)
            {
                this.chartIngressos.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            }
            else
            {
                this.chartIngressos.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
        }





        //////////////////////////////////////////////////
    }
}
