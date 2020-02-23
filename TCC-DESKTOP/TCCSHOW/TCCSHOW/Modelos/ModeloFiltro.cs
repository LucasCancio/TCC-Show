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
    public partial class ModeloFiltro : Modelos.ModeloPadrao
    {
        public ModeloFiltro()
        {
            InitializeComponent();
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
       
        private void ModeloFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {

                this.TopMost = true;
                if (MessageBox.Show("Deseja Sair?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { this.TopMost = false; return; }
                Sistema.Login form = new Sistema.Login();

                this.Hide();

                form.ShowDialog();

            }
        }
    }
}
