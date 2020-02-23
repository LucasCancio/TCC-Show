using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Oracle.DataAccess;
//using System.Data.OracleClient;
using System.Data;
using Oracle.DataAccess.Client;

namespace BLL
{
    public class Funcionario
    {
        private static string SQL;
        private static OracleDataReader dr;

       

        private string _Sexo;
        public string Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value.ToUpper(); }
        }
        private int _IdFuncionario;
        public int IdFuncionario
        {
            get { return _IdFuncionario; }
            set { _IdFuncionario = value; }
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
        private int _IdFuncao;
        public int IdFuncao
        {
            get { return _IdFuncao; }
            set { _IdFuncao = value; }
        }

        private int _IdEndereco;
        public int IdEndereco
        {
            get { return _IdEndereco; }
            set { _IdEndereco = value; }
        }

        private int _IdPessoa;
        public int IdPessoa
        {
            get { return _IdPessoa; }
            set { _IdPessoa = value; }
        }
        private string _Nome;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value.ToUpper(); }
        }

        

        private int _Ativo;

        public int Ativo
        {
            get { return _Ativo; }
            set { _Ativo = value; }
        }


        private string _DataNasc;

        public string DataNasc
        {
            get { return _DataNasc; }
            set { _DataNasc = value; }
        }

      

        private string _Telefone;
        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }


        private string _CPF;
        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }

        public OracleDataReader ConsultarPessoa()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT P.ATIVO,P.NOME FROM TB_FUNCIONARIO F INNER JOIN TB_PESSOA P ON P.ID_PESSOA= F.ID_PESSOA WHERE F.ID_FUNC = " + _IdFuncionario;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OracleDataReader ConsultarNomePessoa()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT F.ID_FUNC, P.ATIVO,P.NOME FROM TB_FUNCIONARIO F INNER JOIN TB_PESSOA P ON P.ID_PESSOA= F.ID_PESSOA WHERE P.NOME = '" + _Nome+"' ";
                return c.RetornarDataReader(SQL);
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
                SQL = "SELECT MAX(ID_FUNC) AS ID FROM TB_FUNCIONARIO";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Ativar(Byte Valor)
        { //Valor 1 = Reativar    Valor 0 = Desativar
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "UPDATE TB_PESSOA SET ATIVO = '" + Valor + "' WHERE ID_PESSOA = (SELECT ID_PESSOA FROM TB_FUNCIONARIO WHERE ID_FUNC= '" + _IdFuncionario+ "')";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

     

        public OracleDataReader Consultar()///COM LOGIN
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "  SELECT F.ID_FUNC,P.ID_PESSOA,P.NOME,P.SEXO, P.DATA_NASC,P.ATIVO,FC.FUNCAO, F.TELEFONE, F.CPF, F.EMAIL,E.ID_ENDERECO, E.CEP,C.UF, C.CIDADE,C.BAIRRO, C.DESCRICAO, E.NUMERO, E.COMPLEMENTO , L.USUARIO, L.SENHA ,PS.DESCRICAO AS PERGUNTA, PS.RESPOSTA, L.ID_LOGIN, PS.ID_PERGUNTASECRETA FROM TCCSHOW.TB_PESSOA P INNER JOIN TCCSHOW.TB_FUNCIONARIO F ON F.ID_PESSOA = P.ID_PESSOA INNER JOIN TCCSHOW.TB_FUNCAO FC ON FC.ID_FUNCAO = F.ID_FUNCAO INNER JOIN TCCSHOW.TB_ENDERECO E ON E.ID_ENDERECO = F.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP C ON C.CEP = E.CEP INNER JOIN TCCSHOW.TB_LOGIN L ON L.ID_PESSOA= P.ID_PESSOA INNER JOIN TCCSHOW.TB_PERGUNTASECRETA PS ON PS.ID_PERGUNTASECRETA = L.ID_PERGUNTASECRETA WHERE F.ID_FUNC= " + _IdFuncionario;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OracleDataReader ConsultarCPF()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "  SELECT F.ID_FUNC,F.CPF FROM TB_FUNCIONARIO F WHERE F.CPF= '" + _CPF+"' ";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public OracleDataReader Consultar2()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "  SELECT F.ID_FUNC ,P.ID_PESSOA,P.NOME,P.SEXO, P.DATA_NASC,P.ATIVO,FC.FUNCAO, F.TELEFONE, F.CPF, F.EMAIL,E.ID_ENDERECO, E.CEP,C.UF, C.CIDADE,C.BAIRRO, C.DESCRICAO, E.NUMERO, E.COMPLEMENTO FROM TCCSHOW.TB_PESSOA P INNER JOIN TCCSHOW.TB_FUNCIONARIO F ON F.ID_PESSOA = P.ID_PESSOA INNER JOIN TCCSHOW.TB_FUNCAO FC ON FC.ID_FUNCAO = F.ID_FUNCAO INNER JOIN TCCSHOW.TB_ENDERECO E ON E.ID_ENDERECO = F.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP C ON C.CEP = E.CEP WHERE F.ID_FUNC= " + _IdFuncionario;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }///SEM LOGIN


      

        public DataSet ListarGeral(string texto, int ativo, string tipo, string tipo2,string tFuncao)
        {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;
            string where = string.Empty;
            if (tFuncao !=string.Empty && tFuncao !=null)
            {
                where = " WHERE (FUNC.FUNCAO='"+tFuncao+"' ) AND ";
            }
            if (tipo2 != string.Empty && tipo2 != null)//COM DATA ESPECIFICA
            {
                if (ativo == 2 && texto.Length == 0)
                {

                    comando = " SELECT F.ID_FUNC ,P.NOME,P.SEXO, P.DATA_NASC,P.ATIVO, FUNC.FUNCAO, F.TELEFONE,F.CPF, F.EMAIL, P.DATA_CRIACAO ,E.CEP, E.ID_ENDERECO  FROM TCCSHOW.TB_PESSOA P INNER JOIN TB_FUNCIONARIO F ON F.ID_PESSOA= P.ID_PESSOA INNER JOIN TCCSHOW.TB_FUNCAO FUNC ON FUNC.ID_FUNCAO = F.ID_FUNCAO INNER JOIN TCCSHOW.TB_ENDERECO E ON E.ID_ENDERECO = F.ID_ENDERECO WHERE " + where.Replace("WHERE", "") + " " + tipo2 + " >= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipo2 + " <= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";

                    return c.RetornarDataSet(comando);
                }
                else if (ativo == 2 && texto.Length != 0)
                {
                    comando = " SELECT F.ID_FUNC ,P.NOME,P.SEXO, P.DATA_NASC,P.ATIVO, FUNC.FUNCAO, F.TELEFONE,F.CPF, F.EMAIL, P.DATA_CRIACAO ,E.CEP, E.ID_ENDERECO  FROM TCCSHOW.TB_PESSOA P INNER JOIN TB_FUNCIONARIO F ON F.ID_PESSOA= P.ID_PESSOA INNER JOIN TCCSHOW.TB_FUNCAO FUNC ON FUNC.ID_FUNCAO = F.ID_FUNCAO INNER JOIN TCCSHOW.TB_ENDERECO E ON E.ID_ENDERECO = F.ID_ENDERECO  WHERE  " + where.Replace("WHERE", "") + " " + tipo + " LIKE '%" + texto + "%' AND " + tipo2 + " >= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipo2 + " <= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                    return c.RetornarDataSet(comando);
                }
                else
                {
                    if (texto.Length == 0) // texto == null || texto == ""
                    {

                        comando = "SELECT F.ID_FUNC ,P.NOME,P.SEXO, P.DATA_NASC,P.ATIVO, FUNC.FUNCAO, F.TELEFONE,F.CPF, F.EMAIL, P.DATA_CRIACAO ,E.CEP, E.ID_ENDERECO  FROM TCCSHOW.TB_PESSOA P INNER JOIN TB_FUNCIONARIO F ON F.ID_PESSOA= P.ID_PESSOA INNER JOIN TCCSHOW.TB_FUNCAO FUNC ON FUNC.ID_FUNCAO = F.ID_FUNCAO INNER JOIN TCCSHOW.TB_ENDERECO E ON E.ID_ENDERECO = F.ID_ENDERECO WHERE " + where.Replace("WHERE", "") + " P.ATIVO=" + ativo + " AND " + tipo2 + " >= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipo2 + " <= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                        return c.RetornarDataSet(comando);
                    }
                    else
                    {
                        comando = "SELECT F.ID_FUNC ,P.NOME,P.SEXO, P.DATA_NASC,P.ATIVO, FUNC.FUNCAO, F.TELEFONE,F.CPF, F.EMAIL, P.DATA_CRIACAO ,E.CEP, E.ID_ENDERECO  FROM TCCSHOW.TB_PESSOA P INNER JOIN TB_FUNCIONARIO F ON F.ID_PESSOA= P.ID_PESSOA INNER JOIN TCCSHOW.TB_FUNCAO FUNC ON FUNC.ID_FUNCAO = F.ID_FUNCAO INNER JOIN TCCSHOW.TB_ENDERECO E ON E.ID_ENDERECO = F.ID_ENDERECO  WHERE " + where.Replace("WHERE", "") + " " + tipo + " LIKE '%" + texto + "%' AND P.ATIVO = " + ativo + " AND " + tipo2 + " >= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipo2 + " <= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                        return c.RetornarDataSet(comando);
                    }
                }
            }
            else///SEM DATA ESPECIFICA
            {
                if (ativo == 2 && texto.Length == 0)
                {

                    comando = " SELECT F.ID_FUNC ,P.NOME,P.SEXO, P.DATA_NASC,P.ATIVO, FUNC.FUNCAO, F.TELEFONE,F.CPF, F.EMAIL, P.DATA_CRIACAO ,E.CEP, E.ID_ENDERECO  FROM TCCSHOW.TB_PESSOA P INNER JOIN TB_FUNCIONARIO F ON F.ID_PESSOA= P.ID_PESSOA INNER JOIN TCCSHOW.TB_FUNCAO FUNC ON FUNC.ID_FUNCAO = F.ID_FUNCAO INNER JOIN TCCSHOW.TB_ENDERECO E ON E.ID_ENDERECO = F.ID_ENDERECO " + where.Replace("AND", "") + " ORDER BY " + tipo + "";

                    return c.RetornarDataSet(comando);
                }
                else if (ativo == 2 && texto.Length != 0)
                {
                    comando = " SELECT F.ID_FUNC ,P.NOME,P.SEXO, P.DATA_NASC,P.ATIVO, FUNC.FUNCAO, F.TELEFONE,F.CPF, F.EMAIL, P.DATA_CRIACAO ,E.CEP, E.ID_ENDERECO  FROM TCCSHOW.TB_PESSOA P INNER JOIN TB_FUNCIONARIO F ON F.ID_PESSOA= P.ID_PESSOA INNER JOIN TCCSHOW.TB_FUNCAO FUNC ON FUNC.ID_FUNCAO = F.ID_FUNCAO INNER JOIN TCCSHOW.TB_ENDERECO E ON E.ID_ENDERECO = F.ID_ENDERECO  WHERE  " + where.Replace("WHERE", "") + " " + tipo + " LIKE '%" + texto + "%' ORDER BY " + tipo + "";
                    return c.RetornarDataSet(comando);
                }
                else
                {
                    if (texto.Length == 0) // texto == null || texto == ""
                    {

                        comando = "SELECT F.ID_FUNC ,P.NOME,P.SEXO, P.DATA_NASC,P.ATIVO, FUNC.FUNCAO, F.TELEFONE,F.CPF, F.EMAIL, P.DATA_CRIACAO ,E.CEP, E.ID_ENDERECO  FROM TCCSHOW.TB_PESSOA P INNER JOIN TB_FUNCIONARIO F ON F.ID_PESSOA= P.ID_PESSOA INNER JOIN TCCSHOW.TB_FUNCAO FUNC ON FUNC.ID_FUNCAO = F.ID_FUNCAO INNER JOIN TCCSHOW.TB_ENDERECO E ON E.ID_ENDERECO = F.ID_ENDERECO WHERE " + where.Replace("WHERE", "") + " P.ATIVO=" + ativo + " ORDER BY " + tipo + "";
                        return c.RetornarDataSet(comando);
                    }
                    else
                    {
                        comando = "SELECT F.ID_FUNC ,P.NOME,P.SEXO, P.DATA_NASC,P.ATIVO, FUNC.FUNCAO, F.TELEFONE,F.CPF, F.EMAIL, P.DATA_CRIACAO ,E.CEP, E.ID_ENDERECO  FROM TCCSHOW.TB_PESSOA P INNER JOIN TB_FUNCIONARIO F ON F.ID_PESSOA= P.ID_PESSOA INNER JOIN TCCSHOW.TB_FUNCAO FUNC ON FUNC.ID_FUNCAO = F.ID_FUNCAO INNER JOIN TCCSHOW.TB_ENDERECO E ON E.ID_ENDERECO = F.ID_ENDERECO  WHERE " + where.Replace("WHERE", "") + " " + tipo + " LIKE '%" + texto + "%' AND P.ATIVO = " + ativo + " ORDER BY " + tipo + "";
                        return c.RetornarDataSet(comando);
                    }
                }
            }
            
        }



        public void Funcionario_crud(char opr)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SP_FUNCIONARIO";
                List<OracleParameter> p = new List<OracleParameter>();
                p.Add(new OracleParameter("vID_FUNC", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _IdFuncionario });
                p.Add(new OracleParameter("vID_FUNCAO", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _IdFuncao });
                p.Add(new OracleParameter("vID_ENDERECO", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _IdEndereco });
                p.Add(new OracleParameter("vCPF", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _CPF });
                p.Add(new OracleParameter("vEMAIL", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _Email });
                p.Add(new OracleParameter("vTELEFONE", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _Telefone });
                p.Add(new OracleParameter("vID_PESSOA", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _IdPessoa });
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
