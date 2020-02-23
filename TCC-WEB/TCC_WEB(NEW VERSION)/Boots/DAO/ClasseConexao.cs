using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// adicionar em REFERENCES >> Sql.DataAccess a partir da PASTA e a DLL
// C:\oraclexe\app\oracle\product\11.2.0\server\odp.net\bin\4\Sql.DataAccess.dll
// declarar as namespaces abaixo
//using Sql.DataAccess.Client;
//using Sql.DataAccess.Types;
using System.Data; //using Sql.DataAccess.Client;
using System.Data.SqlClient;


namespace DAO
{

    public class ClasseConexao
    {
        private static SqlConnection cn;
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static SqlDataReader dr;
        private static SqlParameter p;
        private static SqlParameter q;
        private static DataSet ds;
        private static string SQL;
        private static string dado;
        private static DataTable dt;

        private static
             string strConexaoOra = "Data Source=LAPTOP-0Q711LEB\\TCCSHOW;Initial Catalog=TCCSHOW;Persist Security Info=True;User ID=sa;Password=123456";
        //     "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=LOCALHOST)(PORT=1521)))(CONNECT_DATA=(SID=xe)));User ID=sys;Password=123456; DBA Privilege=SYSDBA;";

        public static string Conexao()
        {
            string oradb = strConexaoOra;
            string info = "";
            try
            {
                cn = new SqlConnection(oradb);

                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    //cn.BeginTransaction();
                    info = "Conectado com a Versão Sql " + cn.ServerVersion + " Utilizando a fonte.DcataSource";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
            return info + " Estado da Conexao " + cn.State.ToString() + " OK";
        }

        public static DataTable ListarAlunos()
        {
            //SQL = @"SELECT * FROM MARCOS.TBALUNO";
            SQL = @"SELECT * FROM MARCOS.TBALUNO ORDER BY NOME";
            cmd = new SqlCommand(SQL, cn);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public static void FinalizarConexao()
        {
            cn.Close();
            cn.Dispose();
        }

        public static string PesquisarNomeAluno(string RMDigitado)
        {
            SQL = "SELECT NOME FROM MARCOS.TBALUNO WHERE TBALUNO.RM = :RMPesquisa"; //@RMPesquisa  > SQLServer

            cmd = new SqlCommand(SQL, cn);
            cmd.CommandType = CommandType.Text;

            p = new SqlParameter();
            p.ParameterName = "@RMPesquisa";
            p.DbType = DbType.String;
            p.Value = RMDigitado;
            cmd.Parameters.Add(p);

            cmd.CommandText = SQL;
            return cmd.ExecuteScalar().ToString();
        }

        public static string Verificar(string NomeDig, string SenhaDig)
        {

            SQL = "SELECT nome FROM MARCOS.tbaluno WHERE TBALUNO.NOME=:NomeDig AND TBALUNO.RM=:senhaDIg"; //@RMPesquisa  > SQLServer

            cmd = new SqlCommand(SQL, ConexaoBanco());
            cmd.CommandType = CommandType.Text;

            p = new SqlParameter();
            p.ParameterName = "@NomeDig";
            p.DbType = DbType.String;
            p.Value = NomeDig;
            cmd.Parameters.Add(p);

            q = new SqlParameter();
            q.ParameterName = "@senhaDIg";
            q.DbType = DbType.String;
            q.Value = SenhaDig;
            cmd.Parameters.Add(q);

            cmd.CommandText = SQL;

            //return cmd.ExecuteScalar().ToString();

            if (cmd.ExecuteScalar() == null)
            {
                dado = null;
            }
            else
            {
                dado = cmd.ExecuteScalar().ToString();
            }

            return dado;

        }

        public static void executarComando(string SQL)
        {
            Conexao();
            try
            {
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void CriarTablespace()
        {

            string pasta = AppDomain.CurrentDomain.BaseDirectory;   //criar em D    a pasta antes de executar o codigo
            string usuario = "TCCSHOW";
            string senha = "123456";
            string schema = "BANCO_DE_DADOS_TCCSHOW";
            cmd = cn.CreateCommand();
            cmd.CommandText = "CREATE TABLESPACE \"" + schema + "\" DATAFILE '" + pasta + schema + ".DBF' SIZE 10M AUTOEXTEND ON NEXT 1M";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "CREATE USER \"" + usuario + "\" IDENTIFIED BY \"" + senha + "\" DEFAULT TABLESPACE \"" + schema + "\" TEMPORARY TABLESPACE TEMP";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "GRANT CONNECT TO \"" + usuario + "\"";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "ALTER USER \"" + usuario + "\" QUOTA UNLIMITED ON \"" + schema + "\"";
            cmd.ExecuteNonQuery();
            //Finalizar();
        }



        /// <summary>
        /// Os métodos abaixo tomam como exemplo a Biblioteca/Classes apresentadas
        /// a partir do livro Aplicacoes Comerciais
        /// </summary>
        /// <returns></returns>
        public static SqlConnection ConexaoBanco()
        {
            try
            {
                cn = new SqlConnection(strConexaoOra);
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                return cn;
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FecharBanco(SqlConnection cn)
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader RetornarDataReader(string sqlComando)
        {
            try
            {
                //SqlDataReader dr;
                //SqlCommand cmd = new SqlCommand(sqlComando, abrirBanco());
                cmd = new SqlCommand(sqlComando, ConexaoBanco());
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable RetornarDataTable(string sqlComando)
        {
            try
            {
                DataTable dt = new DataTable();
                cmd = new SqlCommand(sqlComando, ConexaoBanco());
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet RetornarDataSet(string sqlComando)
        {
            try
            {
                ds = new DataSet();
                cmd = new SqlCommand(sqlComando, ConexaoBanco());
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ExecutarComando(string sqlComando)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sqlComando, ConexaoBanco());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ExecutarComandoParametro(string sqlComando, SqlParameter[] listaParametros)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = sqlComando;
                cmd.CommandType = CommandType.Text;
                if (listaParametros != null)
                {
                    foreach (SqlParameter p in listaParametros)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                cmd.Connection = ConexaoBanco();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ExecutarStoredProcedureParametro(string nomeProcedure, SqlParameter[] listaParametros)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = nomeProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                if (listaParametros != null)
                {
                    foreach (SqlParameter p in listaParametros)
                    {
                        if (p.Value == null)
                        {
                            if (p.DbType == DbType.DateTime)
                            {
                                p.Value = DateTime.Now.ToString().Substring(0, 10);
                            }
                            else
                            {
                                p.Value = "";
                            }

                        }
                        cmd.Parameters.Add(p);
                    }
                }
                cmd.Connection = ConexaoBanco();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int ExecutarComandoRetorno(string sqlComando)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = sqlComando;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = ConexaoBanco();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select @@Identity";
                dr = cmd.ExecuteReader();
                dr.Read();
                return Convert.ToInt32(dr[0]);
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataSet RetornarDatasetParametro(string nomeProcedure, SqlParameter[] listaParametros)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = nomeProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                if (listaParametros != null)
                {
                    foreach (SqlParameter p in listaParametros)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                cmd.Connection = ConexaoBanco();
                da = new SqlDataAdapter();
                ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharBanco(cn);
            }
        }

        public SqlDataReader RetornarDataReaderParametro(string nomeProcedure, SqlParameter[] listaParametros)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = nomeProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                if (listaParametros != null)
                {
                    foreach (SqlParameter p in listaParametros)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                cmd.Connection = ConexaoBanco();
                return cmd.ExecuteReader();
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public string RetornarStatusBancoDados()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    return "Fechado";
                }
                else
                {
                    return "Aberto";
                }
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string RetornarNomeServidor()
        {
            try
            {
                return cn.DataSource;
            }
            catch (SqlException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }







    }


}
