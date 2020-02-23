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
    public class Novidades //OK
    {

        private static string SQL;
        private static SqlDataReader dr;

        private int _IdBanner;
        private string _UrlImg;
        private int _Ativo;
        private int _IndexBanner;

        public int IdBanner { get => _IdBanner; set => _IdBanner = value; }
        public string UrlImg { get => _UrlImg; set => _UrlImg = value; }
        public int Ativo { get => _Ativo; set => _Ativo = value; }
        public int IndexBanner { get => _IndexBanner; set => _IndexBanner = value; }

        public SqlDataReader Consultar()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT [ID_BANNER] , [URL_IMG], [INDEX_BANNER], [ATIVO] FROM [TB_BANNER] WHERE [INDEX_BANNER] = " + _IndexBanner;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listar() {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT * FROM TB_BANNER";
                return c.RetornarDataTable(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
