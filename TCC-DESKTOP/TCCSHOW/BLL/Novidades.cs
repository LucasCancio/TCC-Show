using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace BLL
{
    public class Novidades
    {

        private static string SQL;
        private static OracleDataReader dr;

        private int _ID_BANNER;

        public int ID_BANNER
        {
            get { return _ID_BANNER; }
            set { _ID_BANNER = value; }
        }


   
        private string _URL_IMG;

        public string URL_IMG
        {
            get { return _URL_IMG; }
            set { _URL_IMG = value; }
        }

        private int _ATIVO;

        public int ATIVO
        {
            get { return _ATIVO; }
            set { _ATIVO = value; }
        }

        private int _INDEX_BANNER;

        public int INDEX_BANNER
        {
            get { return _INDEX_BANNER; }
            set { _INDEX_BANNER = value; }
        }

        public void MudarDeLugar(int Index) {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            SQL = "UPDATE TB_BANNER SET INDEX_BANNER='" + Index + "' WHERE INDEX_BANNER =" + _INDEX_BANNER;

            c.ExecutarComando(SQL);
        }

        public OracleDataReader Consultar()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT ID_BANNER , URL_IMG, INDEX_BANNER, ATIVO FROM TB_BANNER WHERE INDEX_BANNER = " + _INDEX_BANNER;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OracleDataReader ConsultarAtivo()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT ID_BANNER , URL_IMG, INDEX_BANNER, ATIVO FROM TB_BANNER WHERE ATIVO = 1 AND ID_BANNER !="+_ID_BANNER;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OracleDataReader ConsultarTamanho()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT MAX(INDEX_BANNER) as MAX FROM TB_BANNER";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public void Novidades_crud(char opr)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SP_NOVIDADE";
                List<OracleParameter> p = new List<OracleParameter>();
                p.Add(new OracleParameter("vID_BANNER", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ID_BANNER });
                p.Add(new OracleParameter("vURL_IMG", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _URL_IMG });
                p.Add(new OracleParameter("vINDEX_BANNER", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _INDEX_BANNER });
                p.Add(new OracleParameter("vATIVO", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ATIVO });
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
