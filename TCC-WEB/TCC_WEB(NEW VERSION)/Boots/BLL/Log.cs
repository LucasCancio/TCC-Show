using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; //using Sql.DataAccess.Client;
using System.Data.SqlClient;

namespace BLL
{
    public class Log
    {

        private static string SQL;
        private static SqlDataReader dr;

        private int _ID_LOG;

        public int ID_LOG
        {
            get { return _ID_LOG; }
            set { _ID_LOG = value; }
        }

        private string _TIPO_LOG;

        public string TIPO_LOG
        {
            get { return _TIPO_LOG; }
            set { _TIPO_LOG = value; }
        }

        private string _DESCRICAO;

        public string DESCRICAO
        {
            get { return _DESCRICAO; }
            set { _DESCRICAO = value; }
        }
        private DateTime _DATA_LOG;

        public DateTime DATA_LOG
        {
            get { return _DATA_LOG; }
            set { _DATA_LOG = value; }
        }


        private int _ID_FUNC;

        public int ID_FUNC
        {
            get { return _ID_FUNC; }
            set { _ID_FUNC = value; }
        }

        private int _ID_MODIFICADO;

        public int ID_MODIFICADO
        {
            get { return _ID_MODIFICADO; }
            set { _ID_MODIFICADO = value; }
        }

        private string _TABELA_LOG;

        public string TABELA_LOG
        {
            get { return _TABELA_LOG; }
            set { _TABELA_LOG = value; }
        }

        private DateTime _DataListarFinal;

        public DateTime DataListarFinal
        {
            get { return _DataListarFinal; }
            set { _DataListarFinal = value; }
        }

        private DateTime _DataListarInicio;

        public DateTime DataListarInicio
        {
            get { return _DataListarInicio; }
            set { _DataListarInicio = value; }
        }





        public DataSet Listar(char tipo, string tSetor, int tId)
        {
            string Where = string.Empty;
            if (tId != 0)
            {
                switch (tipo)
                {
                    case 'A':
                        Where = " LOG_ALTER.ID_ALTERADO= " + tId + " ";
                        break;
                    case 'I':
                        Where = " LOG_INSER.ID_INSERIDO= " + tId + " ";
                        break;
                }

            }

            if (tSetor != string.Empty && tSetor != null && tSetor != "Todos")
            {


                if (tSetor == "Formas de Pagamento")
                {
                    tSetor = "Formas Pags";
                }

                if (Where == string.Empty)
                {
                    Where = " TB.TABELA= '" + tSetor.ToUpper() + "' AND ";
                }
                else
                {
                    Where = Where + " AND TB.TABELA= '" + tSetor.ToUpper() + "' AND ";
                }
            }
            if (tipo == 'L')
            {
                Where = string.Empty;
                if (tId != 0)
                {
                    Where = " LOG.ID_FUNC= " + tId + " AND ";

                }
            }
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;
            switch (tipo)
            {
                case 'A':
                    comando = "SELECT LOG.DATA_LOG, TIPO_LOG.TIPO_LOG, P.NOME,TB.TABELA, LOG_ALTER.ID_ALTERADO FROM TB_LOG LOG INNER JOIN TB_FUNCIONARIO FUNC ON FUNC.ID_FUNC = LOG.ID_FUNC INNER JOIN TB_PESSOA P ON P.ID_PESSOA= FUNC.ID_PESSOA INNER JOIN TB_TIPO_LOG TIPO_LOG ON TIPO_LOG.ID_TIPO_LOG = LOG.ID_TIPO_LOG INNER JOIN TB_LOG_ALTERACAO LOG_ALTER ON LOG_ALTER.ID_LOG = LOG.ID_LOG INNER JOIN TB_TABELAS_LOG TB ON TB.ID_TABELA_LOG = LOG_ALTER.ID_TABELA_LOG WHERE " + Where.Replace("WHERE", "") + " CONVERT(DATETIME,LOG.DATA_LOG, 103) BETWEEN  CONVERT(DATETIME,'" + _DataListarInicio.ToString().Substring(0, 10) + "', 103) AND  CONVERT(DATETIME,'" + _DataListarFinal.ToString().Substring(0, 10) + "', 103) ORDER BY LOG.DATA_LOG DESC";
                    break;
                case 'E':
                    comando = "SELECT LOG.DATA_LOG, TIPO_LOG.TIPO_LOG, P.NOME,TB.TABELA, LOG_EXCL.ID_EXCLUIDO, LOG_EXCL.DESCRICAO FROM TB_LOG LOG  INNER JOIN TB_FUNCIONARIO FUNC ON FUNC.ID_FUNC = LOG.ID_FUNC INNER JOIN TB_PESSOA P ON P.ID_PESSOA= FUNC.ID_PESSOA INNER JOIN TB_TIPO_LOG TIPO_LOG ON TIPO_LOG.ID_TIPO_LOG= LOG.ID_TIPO_LOG INNER JOIN TB_LOG_EXCLUSAO LOG_EXCL ON LOG_EXCL.ID_LOG= LOG.ID_LOG INNER JOIN TB_TABELAS_LOG TB ON TB.ID_TABELA_LOG= LOG_EXCL.ID_TABELA_LOG WHERE " + Where.Replace("WHERE", "") + " CONVERT(DATETIME,LOG.DATA_LOG, 103) BETWEEN  CONVERT(DATETIME,'" + _DataListarInicio.ToString().Substring(0, 10) + "', 103) AND  CONVERT(DATETIME,'" + _DataListarFinal.ToString().Substring(0, 10) + "', 103) ORDER BY LOG.DATA_LOG DESC ";
                    break;
                case 'I':
                    comando = "SELECT LOG.DATA_LOG, TIPO_LOG.TIPO_LOG, P.NOME,TB.TABELA, LOG_INSER.ID_INSERIDO FROM TB_LOG LOG INNER JOIN TB_FUNCIONARIO FUNC ON FUNC.ID_FUNC = LOG.ID_FUNC INNER JOIN TB_PESSOA P ON P.ID_PESSOA= FUNC.ID_PESSOA INNER JOIN TB_TIPO_LOG TIPO_LOG ON TIPO_LOG.ID_TIPO_LOG= LOG.ID_TIPO_LOG INNER JOIN TB_LOG_INSERCAO LOG_INSER ON LOG_INSER.ID_LOG= LOG.ID_LOG INNER JOIN TB_TABELAS_LOG TB ON TB.ID_TABELA_LOG= LOG_INSER.ID_TABELA_LOG WHERE " + Where.Replace("WHERE", "") + " CONVERT(DATETIME,LOG.DATA_LOG, 103) BETWEEN  CONVERT(DATETIME,'" + _DataListarInicio.ToString().Substring(0, 10) + "', 103) AND  CONVERT(DATETIME,'" + _DataListarFinal.ToString().Substring(0, 10) + "', 103) ORDER BY LOG.DATA_LOG DESC ";
                    break;
                case 'L':
                    comando = "SELECT LOG.DATA_LOG, TIPO_LOG.TIPO_LOG, P.NOME FROM TB_LOG LOG INNER JOIN TB_FUNCIONARIO FUNC ON FUNC.ID_FUNC = LOG.ID_FUNC INNER JOIN TB_PESSOA P ON P.ID_PESSOA= FUNC.ID_PESSOA INNER JOIN TB_TIPO_LOG TIPO_LOG ON TIPO_LOG.ID_TIPO_LOG= LOG.ID_TIPO_LOG WHERE " + Where.Replace("WHERE", "") + " (TIPO_LOG.TIPO_LOG= 'LOGON' OR TIPO_LOG.TIPO_LOG='LOGOFF') AND CONVERT(DATETIME,LOG.DATA_LOG, 103) BETWEEN  CONVERT(DATETIME,'" + _DataListarInicio.ToString().Substring(0, 10) + "', 103) AND  CONVERT(DATETIME,'" + _DataListarFinal.ToString().Substring(0, 10) + "', 103) ORDER BY LOG.DATA_LOG DESC";
                    break;
                default:
                    comando = "SELECT  LOG.DATA_LOG, TIPO_LOG.TIPO_LOG, P.NOME FROM TB_LOG LOG INNER JOIN TB_FUNCIONARIO FUNC ON FUNC.ID_FUNC = LOG.ID_FUNC INNER JOIN TB_PESSOA P ON P.ID_PESSOA= FUNC.ID_PESSOA INNER JOIN TB_TIPO_LOG TIPO_LOG ON TIPO_LOG.ID_TIPO_LOG= LOG.ID_TIPO_LOG WHERE CONVERT(DATETIME,LOG.DATA_LOG, 103) BETWEEN  CONVERT(DATETIME,'" + _DataListarInicio.ToString().Substring(0, 10) + "', 103) AND  CONVERT(DATETIME,'" + _DataListarFinal.ToString().Substring(0, 10) + "', 103) ORDER BY LOG.DATA_LOG DESC ";
                    break;
            }

            return c.RetornarDataSet(comando);

        }

        public SqlDataReader ConsultarExcluido(string tabela)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT DESCRICAO FROM TB_LOG_EXCLUSAO WHERE ID_TABELA_LOG= (SELECT ID_TABELA_LOG FROM TB_TABELAS_LOG WHERE TABELA='" + tabela + "') AND ID_EXCLUIDO=" + _ID_MODIFICADO;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Log_crud(char opr)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SP_LOG";
                List<SqlParameter> p = new List<SqlParameter>();
                p.Add(new SqlParameter("@TIPO_LOG", SqlDbType.VarChar) { Value = _TIPO_LOG });
                p.Add(new SqlParameter("@ID_FUNC", SqlDbType.Int) { Value = _ID_FUNC });
                p.Add(new SqlParameter("@TABELA_LOG", SqlDbType.VarChar) { Value = _TABELA_LOG });
                p.Add(new SqlParameter("@ID_MODIFICADO", SqlDbType.Int) { Value = _ID_MODIFICADO });
                p.Add(new SqlParameter("@DESCRICAO", SqlDbType.VarChar) { Value = _DESCRICAO });
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
