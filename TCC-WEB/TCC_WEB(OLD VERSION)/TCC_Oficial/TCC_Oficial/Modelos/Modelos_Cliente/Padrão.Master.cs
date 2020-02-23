using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TCC_Oficial.Modelos_Cliente
{
    public partial class Padrão : System.Web.UI.MasterPage
    {
        private Int32 _codigo;
        public Int32 codigo
        { get { return _codigo; } set { _codigo = value; } }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}