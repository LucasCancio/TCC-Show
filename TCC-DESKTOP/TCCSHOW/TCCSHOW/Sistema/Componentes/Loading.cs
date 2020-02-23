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
    public partial class Loading : Form
    {
        public Loading()
        {
           
            InitializeComponent();
            
        }
        int x, y;
        Point Point = new Point();


  

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point = Control.MousePosition;
                Point.X -= x;
                Point.Y -= y;
                this.Location = Point;
                Application.DoEvents();
            }
        }

        

        int n = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (n==1000)///1000
            {
                this.Close();
                
           }
            else
            {
                n=n+100;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

    }
}
