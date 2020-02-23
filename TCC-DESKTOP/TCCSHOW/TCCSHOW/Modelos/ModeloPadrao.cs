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
    public partial class ModeloPadrao : Form
    {
        public ModeloPadrao()
        {
            InitializeComponent();
            erro.Icon = Global.ResizeIcon(SystemIcons.Error, SystemInformation.IconSize);
            
        }

     

        private Int32 _idFunc;
        private Int32 _codigo;
        private string _titulo;
        private byte _operacao;
        private String _Funcionario;

        public static class Global
        {
            public static Icon ResizeIcon(Icon icon, Size size)
            {
                Bitmap bitmap = new Bitmap(size.Width, size.Height);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(icon.ToBitmap(), new Rectangle(Point.Empty, size));
                }
                return Icon.FromHandle(bitmap.GetHicon());
            }
        }
        public String Funcionario
        {
            get { return _Funcionario; }
            set { _Funcionario = value.ToUpper(); }
        }

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
        public Int32 codigo
        { get { return _codigo; } set { _codigo = value; } }

        public Int32 idFunc
        { get { return _idFunc; } set { _idFunc = value; } }


        public String titulo
        { get { return _titulo; } set { _titulo = value; } }

        public byte operacao
        { get { return _operacao; } set { _operacao = value; } }

       




    }
  
}
