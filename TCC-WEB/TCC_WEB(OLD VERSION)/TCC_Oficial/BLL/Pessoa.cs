using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;

namespace BLL
{
    public class Pessoa //OK
    {
        private int _ID_PESSOA;
        public int ID_PESSOA { get => _ID_PESSOA; set => _ID_PESSOA = value; }


        private string _NOME;
        public string NOME { get => _NOME; set => _NOME = value; }

        private int _ID_TIPO_PESSOA;
        public int ID_TIPO_PESSOA { get => _ID_TIPO_PESSOA; set => _ID_TIPO_PESSOA = value; }

        private DateTime _DATA_NASC;
        public DateTime DATA_NASC { get => _DATA_NASC; set => _DATA_NASC = value; }

        private DateTime _DATA_CRIACAO;
        public DateTime DATA_CRIACAO { get => _DATA_CRIACAO; set => _DATA_CRIACAO = value; }

        private string _SEXO;
        public string SEXO { get => _SEXO; set => _SEXO = value; }

        private int _ATIVO;
        public int ATIVO { get => _ATIVO; set => _ATIVO = value; }
        public void Pessoa_crud(char opr)
        {
            try
            {
                string SQL;
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SP_PESSOA";
                List<SqlParameter> p = new List<SqlParameter>();
                p.Add(new SqlParameter("@ID_PESSOA", SqlDbType.Int) { Value = ID_PESSOA });
                p.Add(new SqlParameter("@NOME", SqlDbType.VarChar) { Value = _NOME });
                p.Add(new SqlParameter("@DATA_NASC", SqlDbType.Date) { Value = _DATA_NASC });
                p.Add(new SqlParameter("@SEXO", SqlDbType.VarChar) { Value = _SEXO });
                p.Add(new SqlParameter("@ATIVO", SqlDbType.Int) { Value = _ATIVO });
                p.Add(new SqlParameter("@ID_TIPO_PESSOA", SqlDbType.Int) { Value = _ID_TIPO_PESSOA });
                p.Add(new SqlParameter("@OPR", SqlDbType.Char) { Value = opr });
                c.ExecutarStoredProcedureParametro(SQL, p.ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }











        ////////////////////////////////
    }
}





