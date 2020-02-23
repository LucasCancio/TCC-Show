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
    public class Login //OK
    {

        private static string SQL;
        private static SqlDataReader dr;


        private int _IdLogin;
        private int _IdPessoa;
        private int _IdFunc;
        private int _IdCli;
        private string _Usuario;
        private string _Nome;
        private string _NivelAcesso;
        private int _IdNivelAcesso;
        private string _Senha;
        private DateTime _DataUltimoAcesso;

        private int _PerguntaSecretaId;
        private string _Descricao;
        private int _Ativo;

        public int PerguntaSecretaId
        {
            get { return _PerguntaSecretaId; }
            set { _PerguntaSecretaId = value; }
        }
        private string _RespostaPerguntaSecreta;






        public string RespostaPerguntaSecreta
        {
            get
            {
                return _RespostaPerguntaSecreta;
            }
            set
            {
                _RespostaPerguntaSecreta = value;
            }
        }





        public int IdLogin
        {
            get
            {
                return _IdLogin;
            }
            set
            {
                _IdLogin = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }
            set
            {
                _Usuario = value.ToUpper().Trim();
            }
        }

        public int IdNivelAcesso
        {
            get
            {
                return _IdNivelAcesso;
            }
            set
            {
                _IdNivelAcesso = value;
            }
        }

        public string Senha
        {
            get
            {
                return _Senha;
            }
            set
            {
                _Senha = value;
            }
        }



        public DateTime DataUltimoAcesso
        {
            get
            {
                return _DataUltimoAcesso;
            }
            set
            {
                _DataUltimoAcesso = value;
            }
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




        public string Descricao
        {
            get
            {
                return _Descricao;
            }

            set
            {
                _Descricao = value.ToUpper();
            }
        }

        public int Ativo
        {
            get
            {
                return _Ativo;
            }

            set
            {
                _Ativo = value;
            }
        }

        public int IdFunc
        {
            get
            {
                return _IdFunc;
            }

            set
            {
                _IdFunc = value;
            }
        }

        public string Nome
        {
            get
            {
                return _Nome;
            }

            set
            {
                _Nome = value;
            }
        }

        public string NivelAcesso { get => _NivelAcesso; set => _NivelAcesso = value; }

        public int IdCli { get => _IdCli; set => _IdCli = value; }



        public void RecuperarDadosTrocaSenha()
        {
            DAO.ClasseConexao objConexao = new DAO.ClasseConexao();

            SQL = "SELECT TB_LOGIN.ID_LOGIN , TB_LOGIN.Usuario, TB_LOGIN.ID_PERGUNTASECRETA, TB_PERGUNTASECRETA.RESPOSTA FROM TB_LOGIN INNER JOIN TB_PERGUNTASECRETA ON TB_PERGUNTASECRETA.ID_PERGUNTASECRETA= TB_LOGIN.ID_PERGUNTASECRETA WHERE Usuario ='" + _Usuario + "'";

            dr = objConexao.RetornarDataReader(SQL);
            dr.Read();
            if (dr.HasRows) //dr.Read()
            {
                IdLogin = Convert.ToInt16(dr[0]);
                PerguntaSecretaId = Convert.ToInt16(dr[2]);
                RespostaPerguntaSecreta = dr[3].ToString();
            }
            else
            {
                IdLogin = 0;
                PerguntaSecretaId = 0;
                RespostaPerguntaSecreta = "NÃO DEFINIDA";
            }
        }

        public DataSet ListarGeral(string texto, int ativo, string tipo, string tipo2, string tTipoPessoa)
        {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;
            string where = string.Empty;
            if (tTipoPessoa != string.Empty && tTipoPessoa != null)
            {
                where = " WHERE TP.TIPO_PESSOA='" + tTipoPessoa.ToUpper() + "' AND ";
            }
            if (tipo2 != string.Empty && tipo2 != null)//COM DATA ESPECIFICA
            {
                if (ativo == 2 && texto.Length == 0)
                {

                    comando = " SELECT L.ID_LOGIN, P.NOME, TP.TIPO_PESSOA, L.USUARIO, PS.DESCRICAO, P.ATIVO FROM TB_PESSOA P INNER JOIN TB_LOGIN L ON L.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_PERGUNTASECRETA PS ON PS.ID_PERGUNTASECRETA= L.ID_PERGUNTASECRETA INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA= P.ID_TIPO_PESSOA WHERE " + where.Replace("WHERE", "") + tipo2 + " >= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipo2 + " <= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss')   ORDER BY " + tipo;

                    return c.RetornarDataSet(comando);
                }
                else if (ativo == 2 && texto.Length != 0)
                {
                    comando = "SELECT L.ID_LOGIN, P.NOME, TP.TIPO_PESSOA, L.USUARIO, PS.DESCRICAO, P.ATIVO FROM TB_PESSOA P INNER JOIN TB_LOGIN L ON L.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_PERGUNTASECRETA PS ON PS.ID_PERGUNTASECRETA= L.ID_PERGUNTASECRETA INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA= P.ID_TIPO_PESSOA WHERE " + where.Replace("WHERE", "") + " " + tipo + " LIKE '%" + texto + "%' AND " + tipo2 + " >= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipo2 + " <= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                    return c.RetornarDataSet(comando);
                }
                else
                {
                    if (texto.Length == 0) // texto == null || texto == ""
                    {

                        comando = "SELECT L.ID_LOGIN, P.NOME, TP.TIPO_PESSOA, L.USUARIO, PS.DESCRICAO, P.ATIVO FROM TB_PESSOA P INNER JOIN TB_LOGIN L ON L.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_PERGUNTASECRETA PS ON PS.ID_PERGUNTASECRETA= L.ID_PERGUNTASECRETA INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA= P.ID_TIPO_PESSOA  WHERE " + where.Replace("WHERE", "") + " P.ATIVO=" + ativo + " AND " + tipo2 + " >= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipo2 + " <= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                        return c.RetornarDataSet(comando);
                    }
                    else
                    {
                        comando = "SELECT L.ID_LOGIN, P.NOME, TP.TIPO_PESSOA, L.USUARIO, PS.DESCRICAO, P.ATIVO FROM TB_PESSOA P INNER JOIN TB_LOGIN L ON L.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_PERGUNTASECRETA PS ON PS.ID_PERGUNTASECRETA= L.ID_PERGUNTASECRETA INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA= P.ID_TIPO_PESSOA  WHERE " + where.Replace("WHERE", "") + " " + tipo + " LIKE '%" + texto + "%' AND P.ATIVO = " + ativo + " AND " + tipo2 + " >= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipo2 + " <= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                        return c.RetornarDataSet(comando);
                    }
                }
            }
            else///SEM DATA ESPECIFICA
            {
                if (ativo == 2 && texto.Length == 0)
                {

                    comando = " SELECT L.ID_LOGIN, P.NOME, TP.TIPO_PESSOA, L.USUARIO, PS.DESCRICAO, P.ATIVO FROM TB_PESSOA P INNER JOIN TB_LOGIN L ON L.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_PERGUNTASECRETA PS ON PS.ID_PERGUNTASECRETA= L.ID_PERGUNTASECRETA INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA= P.ID_TIPO_PESSOA " + where.Replace("AND", "") + " ORDER BY " + tipo + "";

                    return c.RetornarDataSet(comando);
                }
                else if (ativo == 2 && texto.Length != 0)
                {
                    comando = "SELECT L.ID_LOGIN, P.NOME, TP.TIPO_PESSOA, L.USUARIO, PS.DESCRICAO, P.ATIVO FROM TB_PESSOA P INNER JOIN TB_LOGIN L ON L.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_PERGUNTASECRETA PS ON PS.ID_PERGUNTASECRETA= L.ID_PERGUNTASECRETA INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA= P.ID_TIPO_PESSOA WHERE " + where.Replace("WHERE", "") + " " + tipo + " LIKE '%" + texto + "%' ORDER BY " + tipo + "";
                    return c.RetornarDataSet(comando);
                }
                else
                {
                    if (texto.Length == 0) // texto == null || texto == ""
                    {

                        comando = "SELECT L.ID_LOGIN, P.NOME, TP.TIPO_PESSOA, L.USUARIO, PS.DESCRICAO, P.ATIVO FROM TB_PESSOA P INNER JOIN TB_LOGIN L ON L.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_PERGUNTASECRETA PS ON PS.ID_PERGUNTASECRETA= L.ID_PERGUNTASECRETA INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA= P.ID_TIPO_PESSOA  WHERE " + where.Replace("WHERE", "") + " P.ATIVO=" + ativo + " ORDER BY " + tipo + "";
                        return c.RetornarDataSet(comando);
                    }
                    else
                    {
                        comando = "SELECT L.ID_LOGIN, P.NOME, TP.TIPO_PESSOA, L.USUARIO, PS.DESCRICAO, P.ATIVO FROM TB_PESSOA P INNER JOIN TB_LOGIN L ON L.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_PERGUNTASECRETA PS ON PS.ID_PERGUNTASECRETA= L.ID_PERGUNTASECRETA INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA= P.ID_TIPO_PESSOA  WHERE " + where.Replace("WHERE", "") + " " + tipo + " LIKE '%" + texto + "%' AND P.ATIVO = " + ativo + " ORDER BY " + tipo + "";
                        return c.RetornarDataSet(comando);
                    }
                }
            }

        }


        public void AlterarSenha(string tipo)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                switch (tipo)
                {
                    case "Login":
                        SQL = "UPDATE TB_LOGIN SET SENHA = '" + _Senha + "' WHERE ID_lOGIN = '" + _IdLogin + "' ";
                        break;
                    case "Pergunta":
                        SQL = "UPDATE TB_PERGUNTASECRETA SET DESCRICAO= '" + _Descricao + "' WHERE ID_PERGUNTASECRETA = '" + _PerguntaSecretaId + "' ";
                        break;
                    case "Resposta":
                        SQL = "UPDATE TB_PERGUNTASECRETA SET RESPOSTA= '" + _RespostaPerguntaSecreta + "' WHERE ID_PERGUNTASECRETA = '" + _PerguntaSecretaId + "' ";
                        break;
                }

                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader ConsultarFunc()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = " SELECT F.ID_FUNC, L.ID_LOGIN, P.ID_PESSOA, PS.ID_PERGUNTASECRETA,  P.NOME, TP.TIPO_PESSOA, L.USUARIO, L.SENHA, PS.DESCRICAO, PS.RESPOSTA, P.ATIVO FROM TB_PESSOA P INNER JOIN TB_LOGIN L ON L.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_PERGUNTASECRETA PS ON PS.ID_PERGUNTASECRETA= L.ID_PERGUNTASECRETA INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA= P.ID_TIPO_PESSOA  INNER JOIN TB_FUNCIONARIO F ON F.ID_PESSOA=P.ID_PESSOA WHERE ID_LOGIN = " + _IdLogin;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader ConsultarCli()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = " SELECT CLI.ID_CLIENTE ,L.ID_LOGIN, P.ID_PESSOA, PS.ID_PERGUNTASECRETA,  P.NOME, TP.TIPO_PESSOA, L.USUARIO, L.SENHA, PS.DESCRICAO, PS.RESPOSTA, P.ATIVO FROM TB_PESSOA P INNER JOIN TB_LOGIN L ON L.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_PERGUNTASECRETA PS ON PS.ID_PERGUNTASECRETA= L.ID_PERGUNTASECRETA INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA= P.ID_TIPO_PESSOA INNER JOIN TB_CLIENTE CLI ON CLI.ID_PESSOA = P.ID_PESSOA WHERE ID_LOGIN = " + _IdLogin;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Logar()
        {

            // DAO.ClasseConexao objConexao = new DAO.ClasseConexao();
            DAO.ClasseConexao objConexao = new DAO.ClasseConexao();



            SQL = "select TB_LOGIN.ID_LOGIN, TB_PERGUNTASECRETA.DESCRICAO, TB_LOGIN.ID_NIVELACESSO, TB_PESSOA.ATIVO, TB_LOGIN.DATAULTIMOACESSO from TB_LOGIN INNER JOIN TB_PESSOA ON TB_PESSOA.ID_PESSOA= TB_LOGIN.ID_PESSOA INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=TB_PESSOA.ID_TIPO_PESSOA  INNER JOIN TB_PERGUNTASECRETA ON TB_PERGUNTASECRETA.ID_PERGUNTASECRETA= TB_LOGIN.ID_PERGUNTASECRETA where Usuario='" + _Usuario.ToUpper() + "' and SENHA='" + _Senha + "' AND TP.TIPO_PESSOA='CLIENTE' ";

            dr = objConexao.RetornarDataReader(SQL);
            dr.Read();
            if (dr.HasRows) //dr.Read()
            {
                IdLogin = Convert.ToInt16(dr["ID_LOGIN"]);
                Descricao = dr["DESCRICAO"].ToString();
                //TipoUsuario = dr[1].ToString();
                IdNivelAcesso = Convert.ToInt16(dr["ID_NIVELACESSO"]);
                int ativo;
                ativo = Convert.ToInt16(dr["ATIVO"]);
                if (dr["DATAULTIMOACESSO"].ToString() != string.Empty)
                {
                    DataUltimoAcesso = Convert.ToDateTime(dr["DATAULTIMOACESSO"].ToString());
                }


                SQL = "select TB_CLIENTE.ID_CLIENTE, TB_PESSOA.NOME from TB_CLIENTE INNER JOIN TB_PESSOA ON TB_PESSOA.ID_PESSOA= TB_CLIENTE.ID_PESSOA  inner join TB_LOGIN ON TB_LOGIN.ID_PESSOA= TB_CLIENTE.ID_PESSOA where TB_LOGIN.ID_LOGIN='" + Convert.ToInt16(dr["ID_LOGIN"]) + "'";
                dr = objConexao.RetornarDataReader(SQL);
                dr.Read();
                if (dr.HasRows)
                {
                  
                    Nome = dr["NOME"].ToString();
                    IdCli = Convert.ToInt32(dr["ID_CLIENTE"]);
                  
                }
                else
                {
                    return false;
                }
                if (ativo == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public void Login_crud(char opr)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SP_LOGIN";
                List<SqlParameter> p = new List<SqlParameter>();
                p.Add(new SqlParameter("@ID_LOGIN", SqlDbType.Int) { Value = _IdLogin });
                p.Add(new SqlParameter("@ID_NIVELACESSO", SqlDbType.Int) { Value = _IdNivelAcesso });
                p.Add(new SqlParameter("@ID_PERGUNTASECRETA", SqlDbType.Int) { Value = _PerguntaSecretaId });
                p.Add(new SqlParameter("@USUARIO", SqlDbType.VarChar) { Value = _Usuario });
                p.Add(new SqlParameter("@SENHA", SqlDbType.VarChar) { Value = _Senha });
                p.Add(new SqlParameter("@DATAULTIMOACESSO", SqlDbType.Date) { Value = _DataUltimoAcesso });
                p.Add(new SqlParameter("@ID_PESSOA", SqlDbType.Int) { Value = _IdPessoa });
                p.Add(new SqlParameter("@DESCRICAO", SqlDbType.VarChar) { Value = _Descricao });
                p.Add(new SqlParameter("@RESPOSTA", SqlDbType.VarChar) { Value = _RespostaPerguntaSecreta });
                p.Add(new SqlParameter("@OPR", SqlDbType.Char) { Value = opr });
                c.ExecutarStoredProcedureParametro(SQL, p.ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void SpIniciar(char opr)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SP_INICIAR";
                List<SqlParameter> p = new List<SqlParameter>();
                c.ExecutarStoredProcedureParametro(SQL, p.ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public SqlDataReader ConsultarUsuario(string tipo)
        {
            try
            {

                DAO.ClasseConexao c = new DAO.ClasseConexao();
                if (tipo == "FUNCIONARIO")
                {
                    SQL = "  SELECT FUNC.ID_FUNC,ID_LOGIN,USUARIO FROM TB_LOGIN INNER JOIN TB_PESSOA ON TB_PESSOA.ID_PESSOA= TB_LOGIN.ID_PESSOA INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=TB_PESSOA.ID_TIPO_PESSOA INNER JOIN TB_FUNCIONARIO FUNC ON FUNC.ID_PESSOA= TB_PESSOA.ID_PESSOA WHERE USUARIO= '" + _Usuario + "' AND TP.TIPO_PESSOA='" + tipo + "' ";
                }
                else
                {
                    SQL = "  SELECT CLI.ID_CLIENTE,TB_LOGIN.ID_LOGIN,TB_LOGIN.USUARIO,PG.DESCRICAO,PG.RESPOSTA FROM TB_LOGIN INNER JOIN TB_PESSOA ON TB_PESSOA.ID_PESSOA= TB_LOGIN.ID_PESSOA INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=TB_PESSOA.ID_TIPO_PESSOA INNER JOIN TB_CLIENTE CLI ON CLI.ID_PESSOA= TB_PESSOA.ID_PESSOA INNER JOIN TB_PERGUNTASECRETA PG ON PG.ID_PERGUNTASECRETA= TB_LOGIN.ID_PERGUNTASECRETA  WHERE USUARIO= '" + _Usuario + "' AND TP.TIPO_PESSOA='" + tipo + "' ";
                }

                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





    }
}

