using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.SqlClient;
using System.Data; //using Sql.DataAccess.Client;
using System.Data.SqlClient;
namespace BLL
{
   public class CEP
    {
        private static string SQL;
        private static SqlDataReader dr;

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
        public SqlDataReader Consultar()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT * FROM TB_CEP WHERE CEP = " + _Cep;
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
                List<SqlParameter> p = new List<SqlParameter>();
                p.Add(new SqlParameter("@ID_ENDERECO", SqlDbType.Int) { Value = _ID_ENDERECO });
                p.Add(new SqlParameter("@CEP", SqlDbType.VarChar) { Value = _Cep });
                p.Add(new SqlParameter("@NUMERO", SqlDbType.Int) { Value = _NUMERO });
                p.Add(new SqlParameter("@COMPLEMENTO", SqlDbType.VarChar) { Value = _Complemento });
                p.Add(new SqlParameter("@OPR", SqlDbType.Char) { Value = opr });
                c.ExecutarStoredProcedureParametro(SQL, p.ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

  

    }
}
