using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
namespace BLL
{
   public class Desconto
    {
        private static string SQL;
        private static OracleDataReader dr;

        private int _ID_DESCONTO;

        public int ID_DESCONTO
        {
            get { return _ID_DESCONTO; }
            set { _ID_DESCONTO = value; }
        }


        private int _ID_CLIENTE;

        public int ID_CLIENTE
        {
            get { return _ID_CLIENTE; }
            set { _ID_CLIENTE = value; }
        }

        private double _DESCONTO;

        public double DESCONTO
        {
            get { return _DESCONTO; }
            set { _DESCONTO = value; }
        }

        private string _COD_PROMOCIONAL;

        public string COD_PROMOCIONAL
        {
            get { return _COD_PROMOCIONAL; }
            set { _COD_PROMOCIONAL = value; }
        }

        private int _N_USOS;

        public int N_USOS
        {
            get { return _N_USOS; }
            set { _N_USOS = value; }
        }


        private int _ATIVO;

        public int ATIVO
        {
            get { return _ATIVO; }
            set { _ATIVO = value; }
        }

        public OracleDataReader Consultar(){
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                string comando = string.Empty;
                comando = "SELECT ID_DESCONTO,DESCONTO, COD_PROMOCIONAL, ATIVO FROM TB_DESCONTOS WHERE COD_PROMOCIONAL='" + _COD_PROMOCIONAL+"' AND ATIVO=1";
                return c.RetornarDataReader(comando);
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }

        public OracleDataReader ConsultarPorId()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                string comando = string.Empty;
                comando = "SELECT ID_DESCONTO,DESCONTO,ATIVO, COD_PROMOCIONAL FROM TB_DESCONTOS WHERE ID_DESCONTO='" + _ID_DESCONTO + "'";
                return c.RetornarDataReader(comando);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public OracleDataReader ConsultarValorMaximo()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT MAX(ID_DESCONTO) AS ID FROM TB_DESCONTOS";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Listar()
        {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;

            comando = "SELECT ID_DESCONTO, DESCONTO, COD_PROMOCIONAL, N_USOS, ATIVO FROM TB_DESCONTOS ORDER BY ID_DESCONTO";
            return c.RetornarDataSet(comando);

        }

        public void Descontos_crud(char opr)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SP_DESCONTOS";
                List<OracleParameter> p = new List<OracleParameter>();
                p.Add(new OracleParameter("vID_FUNCAO", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ID_DESCONTO });
                p.Add(new OracleParameter("vDESCONTO", Oracle.DataAccess.Client.OracleDbType.Double) { Value = _DESCONTO });
                p.Add(new OracleParameter("vCOD_PROMOCIONAL", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _COD_PROMOCIONAL });
                p.Add(new OracleParameter("vATIVO", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ATIVO });
                p.Add(new OracleParameter("vID_CLIENTE", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ID_CLIENTE });
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
