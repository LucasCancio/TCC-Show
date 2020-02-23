using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.OracleClient;
using System.Data;
using Oracle.DataAccess.Client;
namespace BLL
{
    public class Pessoa
    {
        private int _ID_PESSOA;
        public int ID_PESSOA { get => _ID_PESSOA; set => _ID_PESSOA = value; }

      
        private string _NOME;
        public string  NOME { get => _NOME; set => _NOME = value; }

        private int _ID_TIPO_PESSOA;
        public int ID_TIPO_PESSOA { get => _ID_TIPO_PESSOA; set =>  _ID_TIPO_PESSOA= value; }

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
                List<OracleParameter> p = new List<OracleParameter>();
                p.Add(new OracleParameter("vID_PESSOA", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = ID_PESSOA });
                p.Add(new OracleParameter("vNOME", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _NOME });
                p.Add(new OracleParameter("vDATA_NASC", Oracle.DataAccess.Client.OracleDbType.Date) { Value = _DATA_NASC });
                p.Add(new OracleParameter("vSEXO", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _SEXO });
                p.Add(new OracleParameter("vATIVO", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ATIVO });
                p.Add(new OracleParameter("vID_TIPO_PESSOA", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ID_TIPO_PESSOA });
                p.Add(new OracleParameter("vOPR", Oracle.DataAccess.Client.OracleDbType.Char) { Value = opr });
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
