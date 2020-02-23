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
    public partial class ModeloCadastroPadrao : Modelos.ModeloPadrao
    {
        public ModeloCadastroPadrao()
        {
            InitializeComponent();
            this.label6.Location = this.label6.Location;
            this.label4.Location = this.label4.Location;
            //if (operacao == 0)
            //{
            //    this.btnCancelar.Visible = false;
            //    this.pbCancelar.Visible = false;
            //    this.chkAtivo.Checked = true;
            //}
            //else
            //{
            //    this.btnCancelar.Visible = true;
            //    this.pbCancelar.Visible = true;
            //}

          
        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ModeloCadastroPadrao_Load(object sender, EventArgs e)
        {
            if (operacao==5)
            {
                btnCancelar.Location = btnSalvar.Location;
                pbCancelar.Location = pbSalvar.Location;

                this.chkAtivo.Visible = false;
                this.lblAtivo.Visible = true;
            }
            this.lblAtivo.Location = new Point(this.chkAtivo.Location.X-3, this.chkAtivo.Location.Y);
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkAtivo.Checked)
            {
                lblAtivo.Text = "Ativo";
                lblAtivo.ForeColor = Color.LimeGreen;
                lblAtivo.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else
            {
                lblAtivo.Text = "Desativado";
                lblAtivo.ForeColor = Color.Red;
                lblAtivo.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
    }
}
