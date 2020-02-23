using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    class Assento
    {
        private static string SQL;
        private static SqlDataReader dr;

        private int _IdAssento;
        private int _IdTipoAssento;
        private int _IdSetor;
        private string _Valor;
        private string _AssentoNumer;
        private string _AssentoFileira;

        public int IdAssento { get => _IdAssento; set => _IdAssento = value; }
        public int IdTipoAssento { get => _IdTipoAssento; set => _IdTipoAssento = value; }
        public int IdSetor { get => _IdSetor; set => _IdSetor = value; }
        public string Valor { get => _Valor; set => _Valor = value; }
        public string AssentoNumer { get => _AssentoNumer; set => _AssentoNumer = value; }
        public string AssentoFileira { get => _AssentoFileira; set => _AssentoFileira = value; }
    }
}


