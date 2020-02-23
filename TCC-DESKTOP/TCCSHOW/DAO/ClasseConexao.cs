using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// adicionar em REFERENCES >> Oracle.DataAccess a partir da PASTA e a DLL
// C:\oraclexe\app\oracle\product\11.2.0\server\odp.net\bin\4\Oracle.DataAccess.dll
// declarar as namespaces abaixo
//using Oracle.DataAccess.Client;
//using Oracle.DataAccess.Types;
using System.Data;

//using System.Data.OracleClient;Client;
using Oracle.DataAccess.Client;


namespace DAO
{

    public class ClasseConexao
    {
        private static OracleConnection cn;
        private static OracleCommand cmd;
        private static OracleDataAdapter da;
        private static OracleDataReader dr;
        private static OracleParameter p;
        private static OracleParameter q;
        private static DataSet ds;
        private static string SQL;
        private static string dado;
        private static DataTable dt;

        private static
             string strConexaoOra = "Data Source=LOCALHOST;User Id=TCCSHOW;Password=123456;";
        //     "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=LOCALHOST)(PORT=1521)))(CONNECT_DATA=(SID=xe)));User ID=sys;Password=123456; DBA Privilege=SYSDBA;";

        public static string Conexao()
        {
            string oradb = strConexaoOra;
            string info = "";
            try
            {
                cn = new OracleConnection(oradb);

                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    //cn.BeginTransaction();
                    info = "Conectado com a Versão Oracle " + cn.ServerVersion + " Utilizando a fonte.DcataSource";
                }
            }
            catch (OracleException ex)
            {
                return ex.Message;
            }
            return info + " Estado da Conexao " + cn.State.ToString() + " OK";
        }

        public static DataTable ListarAlunos()
        {
            //SQL = @"SELECT * FROM MARCOS.TBALUNO";
            SQL = @"SELECT * FROM MARCOS.TBALUNO ORDER BY NOME";
            cmd = new OracleCommand(SQL, cn);
            cmd.CommandType = CommandType.Text;
            da = new OracleDataAdapter(cmd);
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

            cmd = new OracleCommand(SQL, cn);
            cmd.CommandType = CommandType.Text;

            p = new OracleParameter();
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

            cmd = new OracleCommand(SQL, cn);
            cmd.CommandType = CommandType.Text;

            p = new OracleParameter();
            p.ParameterName = "@NomeDig";
            p.DbType = DbType.String;
            p.Value = NomeDig;
            cmd.Parameters.Add(p);

            q = new OracleParameter();
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
                OracleCommand cmd = new OracleCommand(SQL, cn);
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
        public static OracleConnection ConexaoBanco()
        {
            try
            {
                cn = new OracleConnection(strConexaoOra);
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                return cn;
            }
            catch (OracleException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FecharBanco(OracleConnection cn)
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
            catch (OracleException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OracleDataReader RetornarDataReader(string sqlComando)
        {
            try
            {
                //OracleDataReader dr;
                //OracleCommand cmd = new OracleCommand(sqlComando, abrirBanco());
                cmd = new OracleCommand(sqlComando, ConexaoBanco());
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
                cmd = new OracleCommand(sqlComando, cn);
                da = new OracleDataAdapter(cmd);
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
                cmd = new OracleCommand(sqlComando, cn);
                da = new OracleDataAdapter(cmd);
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
                OracleCommand cmd = new OracleCommand(sqlComando, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        }

        public void ExecutarComandoParametro(string sqlComando, OracleParameter[] listaParametros)
        {
            try
            {
                cmd = new OracleCommand();
                cmd.CommandText = sqlComando;
                cmd.CommandType = CommandType.Text;
                if (listaParametros != null)
                {
                    foreach (OracleParameter p in listaParametros)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }

        public void ExecutarStoredProcedureParametro(string nomeProcedure, OracleParameter[] listaParametros)
        {
            try
            {
                cmd = new OracleCommand();
                cmd.CommandText = nomeProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                if (listaParametros != null)
                {
                    foreach (OracleParameter p in listaParametros)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException exOra)
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
                cmd = new OracleCommand();
                cmd.CommandText = sqlComando;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select @@Identity";
                dr = cmd.ExecuteReader();
                dr.Read();
                return Convert.ToInt32(dr[0]);
            }
            catch (OracleException exOra)
            {
                throw exOra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public DataSet RetornarDatasetParametro(string nomeProcedure, OracleParameter[] listaParametros)
        {
            try
            {
                cmd = new OracleCommand();
                cmd.CommandText = nomeProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                if (listaParametros != null)
                {
                    foreach (OracleParameter p in listaParametros)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                cmd.Connection = cn;
                da = new OracleDataAdapter();
                ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            catch (OracleException exOra)
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

        public OracleDataReader RetornarDataReaderParametro(string nomeProcedure, OracleParameter[] listaParametros)
        {
            try
            {
                cmd = new OracleCommand();
                cmd.CommandText = nomeProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                if (listaParametros != null)
                {
                    foreach (OracleParameter p in listaParametros)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                cmd.Connection = cn;
                return cmd.ExecuteReader();
            }
            catch (OracleException exOra)
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
            catch (OracleException exOra)
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
            catch (OracleException exOra)
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
