using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.OracleClient;
using System.Data;
using Oracle.DataAccess.Client;
namespace BLL
{
   public class CEP
    {
        private static string SQL;
        private static OracleDataReader dr;

        private int _ID_ENDERECO;

        public int ID_ENDERECO
        {
            get { return _ID_ENDERECO; }
            set { _ID_ENDERECO = value; }
        }

        private string _Cep;
        public string Cep
        {
            get { return _Cep; }
            set { _Cep = value; }
        }

        private int _NUMERO;
        public int NUMERO
        {
            get { return _NUMERO; }
            set { _NUMERO = value; }
        }

        private string _Complemento;
        public string Complemento
        {
            get { return _Complemento; }
            set { _Complemento = value.ToUpper(); }
        }
        public OracleDataReader Consultar()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT * FROM TCCSHOW.TB_CEP WHERE CEP = " + _Cep;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    
        public void Endereco_crud(char opr)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SP_ENDERECO";
                List<OracleParameter> p = new List<OracleParameter>();
                p.Add(new OracleParameter("vID_ENDERECO", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ID_ENDERECO });
                p.Add(new OracleParameter("vCEP", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _Cep });
                p.Add(new OracleParameter("vNUMERO", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _NUMERO });
                p.Add(new OracleParameter("vCOMPLEMENTO", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _Complemento });
                p.Add(new OracleParameter("vOPR", Oracle.DataAccess.Client.OracleDbType.Char) { Value = opr });
                c.ExecutarStoredProcedureParametro(SQL, p.ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

  

    }
}
