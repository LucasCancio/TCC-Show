using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace BLL
{
   public class FormaPagamento
    {

        private static string SQL;
        private static OracleDataReader dr;

        private int _ID_FORMA_PAGAMENTO;

        public int ID_FORMA_PAGAMENTO
        {
            get { return _ID_FORMA_PAGAMENTO; }
            set { _ID_FORMA_PAGAMENTO = value; }
        }

        private string _FORMA_PAGAMENTO;

        public string FORMA_PAGAMENTO
        {
            get { return _FORMA_PAGAMENTO; }
            set { _FORMA_PAGAMENTO = value; }
        }

        public OracleDataReader ConsultarPorId()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                string comando = string.Empty;
                comando = "SELECT ID_FORMA_PAGAMENTO, FORMA_PAGAMENTO FROM TB_FORMA_PAGAMENTO WHERE ID_FORMA_PAGAMENTO='" + _ID_FORMA_PAGAMENTO + "'";
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
                SQL = "SELECT MAX(ID_FORMA_PAGAMENTO) AS ID FROM TB_FORMA_PAGAMENTO";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ListarComboBox()
        {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;
            comando = "SELECT ID_FORMA_PAGAMENTO, FORMA_PAGAMENTO FROM TB_FORMA_PAGAMENTO ORDER BY ID_FORMA_PAGAMENTO";
            return c.RetornarDataSet(comando);
            
        }

        public DataSet Listar()
        {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;
            
                comando = "SELECT ID_FORMA_PAGAMENTO, FORMA_PAGAMENTO FROM TB_FORMA_PAGAMENTO ORDER BY ID_FORMA_PAGAMENTO";
                return c.RetornarDataSet(comando);
           
        }

        public void FormaDePag_crud(char opr)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SP_FORMA_PAGAMENTO";
                List<OracleParameter> p = new List<OracleParameter>();
                p.Add(new OracleParameter("vID_FORMA_PAGAMENTO", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ID_FORMA_PAGAMENTO });
                p.Add(new OracleParameter("vFORMA_PAGAMENTO", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _FORMA_PAGAMENTO });
                p.Add(new OracleParameter("vOPR", Oracle.DataAccess.Client.OracleDbType.Char) { Value = opr });
                c.ExecutarStoredProcedureParametro(SQL, p.ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /////////////////////////////////////////////
    }
}
