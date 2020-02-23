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
    public partial class ModeloGeralCompleto :Form
    {
        public ModeloGeralCompleto()
        {
            InitializeComponent();
           
        }

        private String _NomeTurma;

        public String NomeTurma
        {
            get { return _NomeTurma; }
            set { _NomeTurma = value; }
        }

        public int _CaracteresLinha = 0;
        public int _NumeroLinhas = 0;

        private void Form_KeyDown(Object o, KeyEventArgs e)
        {
          
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



     
        private void proximoControle(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = false;
                SendKeys.Send("{TAB}");
            }
            //no form passe a propriedade KeyPreview para True 
            // e no evento do form KeyPress
            // chame esse metodo proximoControle(e);

            //http://www.experts-exchange.com/Programming/Languages/C_Sharp/Q_21081811.html
            if (e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                GetNextControl(sender as Control, true).Focus();
                e.Handled = true;
            }

        }

        

        private void ModeloGeralCompleto_KeyPress(object sender, KeyPressEventArgs e)
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
