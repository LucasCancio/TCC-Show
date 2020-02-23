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
    public partial class ModeloGeral : Form
    {
       
        public ModeloGeral()
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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }








        ///////////////////////////////////////////////////////////

        private int _NivelAcesso;

        public int NivelAcesso
        {
            get
            {
                return _NivelAcesso;
            }

            set
            {
                _NivelAcesso = value;
            }
        }

        public int NomeUser
        {
            get
            {
                return _NomeUser;
            }

            set
            {
                _NomeUser = value;
            }
        }

        private int _NomeUser; 

        

        private void Form_KeyDown(Object o, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                
                if (MessageBox.Show("Deseja Sair?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; }
                this.Dispose();

            }
        }

     


        //private void btnDeslogar_MouseMove(object sender, MouseEventArgs e)
        //{
        //    btnDeslogar.Image = Properties.Resources.BotaoDeslogar1;
        //}

        //private void btnDeslogar_MouseLeave(object sender, EventArgs e)
        //{
        //    btnDeslogar.Image = Properties.Resources.BotaoDeslogar;
        //}
        
        public void Deslogar(Object o, EventArgs e)
        {
            this.Dispose();

            //sair.btnSair.Click += Sair;
            //sair.ShowDialog();


        }

       


      
        private void ModeloGeral_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }


        private Int32 _idLogin;
        private Int32 _codigo;
        private string _titulo;
        private byte _operacao;
        private String _Funcionario;


        public String Funcionario
        {
            get { return _Funcionario; }
            set { _Funcionario = value.ToUpper(); }
        }

        public Int32 codigo
        { get { return _codigo; } set { _codigo = value; } }

        public Int32 idFunc
        { get { return _idLogin; } set { _idLogin = value; } }


        public String titulo
        { get { return _titulo; } set { _titulo = value; } }

    

        public byte operacao
        { get { return _operacao; } set { _operacao = value; } }


     

      



    }
}
