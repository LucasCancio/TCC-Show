using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace BLL
{
    public class Assento
    {

        private static string SQL;
        private static SqlDataReader dr;

        private int _ID_ASSENTO;

        public int ID_ASSENTO
        {
            get { return _ID_ASSENTO; }
            set { _ID_ASSENTO = value; }
        }

        private int _ID_TIPOASSENTO;

        public int ID_TIPOASSENTO
        {
            get { return _ID_TIPOASSENTO; }
            set { _ID_TIPOASSENTO = value; }
        }

        private int _ID_SETOR;

        public int ID_SETOR
        {
            get { return _ID_SETOR; }
            set { _ID_SETOR = value; }
        }

        private string _Valor;
        public string Valor
        {
            get
            {
                return _Valor;
            }

            set
            {
                _Valor = value;
            }
        }

        private string _Assento_Numer;

        public string Assento_Numer
        {
            get { return _Assento_Numer; }
            set { _Assento_Numer = value; }
        }

        private string _Assento_Fileira;
        public string Assento_Fileira
        {
            get { return _Assento_Fileira; }
            set { _Assento_Fileira = value.ToUpper(); }
        }

        public void AlterarPrecos()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "UPDATE TB_PRECOS SET PERC= '" + _Valor + "' WHERE ID_SETOR='" + _ID_SETOR + "' AND ID_TIPO_ASSENTO='" + _ID_TIPOASSENTO + "'";

                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SqlDataReader ConsultarPercentual()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = " SELECT TB_PRECOS.ID_SETOR, TB_PRECOS.ID_TIPO_ASSENTO, TB_PRECOS.PERC, TB_ASSENTO.ASSENTO_NUMER, TB_ASSENTO.ASSENTO_FILEIRA FROM TB_PRECOS INNER JOIN TB_ASSENTO ON TB_ASSENTO.ID_SETOR = TB_PRECOS.ID_SETOR AND TB_ASSENTO.ID_TIPO_ASSENTO = TB_PRECOS.ID_TIPO_ASSENTO WHERE ASSENTO_NUMER ='" + _Assento_Numer + "' AND ASSENTO_FILEIRA ='" + _Assento_Fileira + "' ";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader ConsultarValor2()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = " SELECT TB_PRECOS.ID_SETOR, TB_PRECOS.ID_TIPO_ASSENTO, TB_PRECOS.PERC, TB_ASSENTO.ASSENTO_NUMER, TB_ASSENTO.ASSENTO_FILEIRA FROM TB_PRECOS INNER JOIN TB_ASSENTO ON TB_ASSENTO.ID_SETOR = TB_PRECOS.ID_SETOR AND TB_ASSENTO.ID_TIPO_ASSENTO = TB_PRECOS.ID_TIPO_ASSENTO WHERE TB_PRECOS.ID_TIPO_ASSENTO ='" + _ID_TIPOASSENTO + "' AND TB_PRECOS.ID_SETOR ='" + _ID_SETOR + "' ";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader ConsultarAssento()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = " SELECT TB_ASSENTO.ID_ASSENTO FROM TB_ASSENTO WHERE ASSENTO_NUMER ='" + _Assento_Numer + "' AND ASSENTO_FILEIRA ='" + _Assento_Fileira + "' ";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader ConsultarValorMaximo()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT MAX(ID_VENDA) AS ID FROM TB_VENDA_INGRESSO";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


