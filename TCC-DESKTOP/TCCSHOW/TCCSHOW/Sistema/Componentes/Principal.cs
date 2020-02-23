using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Sistema.Componentes
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }


        private void SubinharLbl(Object o, MouseEventArgs e)
        {
            try
            {
                var b = (Label)o;

                b.Font = new Font("Quicksand Bold", 27.749F, System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Bold);

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        private void DesSubinharLbl(Object o, EventArgs e)
        {
            try
            {
                var b = (Label)o;

                b.Font = new Font("Quicksand Bold", 27.749F, System.Drawing.FontStyle.Bold);

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        ////////////////////////////////////////
    }
}
