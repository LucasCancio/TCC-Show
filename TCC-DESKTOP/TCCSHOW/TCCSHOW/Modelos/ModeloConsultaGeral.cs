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
    public partial class ModeloConsultaGeral : ModeloGeral
    {
        public ModeloConsultaGeral()
        {
            InitializeComponent();
        }

        private void Sair(Object sender, EventArgs e)
        {

        }

        private void Cancelar(Object o, EventArgs e) {
            txtPesquisar.Clear();
            //dgv.ClearSelection();
            txtPesquisar.Focus();
        }

        private void ModeloConsultaGeral_Load(object sender, EventArgs e)
        {

        }
    }
}
