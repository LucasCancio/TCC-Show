using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace BLL
{
    public class Funcao
    {

        private static string SQL;
        private static OracleDataReader dr;

        private int _ID_FUNCAO;

        public int ID_FUNCAO
        {
            get { return _ID_FUNCAO; }
            set { _ID_FUNCAO = value; }
        }

        private string _FUNCAO;

        public string FUNCAO
        {
            get { return _FUNCAO; }
            set { _FUNCAO = value; }
        }

        public OracleDataReader ConsultarPorId()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                string comando = string.Empty;
                comando = "SELECT ID_FUNCAO, FUNCAO FROM TB_FUNCAO WHERE ID_FUNCAO='" + _ID_FUNCAO + "'";
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
                SQL = "SELECT MAX(ID_FUNCAO) AS ID FROM TB_FUNCAO";
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
            comando = "SELECT ID_FUNCAO, FUNCAO FROM TB_FUNCAO ORDER BY ID_FUNCAO";
            return c.RetornarDataSet(comando);

        }

        public DataSet Listar()
        {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;

            comando = "SELECT ID_FUNCAO, FUNCAO FROM TB_FUNCAO ORDER BY ID_FUNCAO";
            return c.RetornarDataSet(comando);

        }

        public OracleDataReader VerificarFuncionario()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT F.ID_FUNC FROM TB_FUNCIONARIO F WHERE F.ID_FUNCAO = " + _ID_FUNCAO + " ";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Funcao_crud(char opr)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SP_FUNCAO";
                List<OracleParameter> p = new List<OracleParameter>();
                p.Add(new OracleParameter("vID_FUNCAO", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ID_FUNCAO });
                p.Add(new OracleParameter("vFUNCAO", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _FUNCAO });
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
