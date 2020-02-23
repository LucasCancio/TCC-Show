using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace BLL
{
   public class Contas
    {
        
    

        
    
        
    
        private static string SQL;
        private static OracleDataReader dr;

        private int _ID_CONTAS;

        public int ID_CONTAS
        {
            get { return _ID_CONTAS; }
            set { _ID_CONTAS = value; }
        }

        private int _ID_VENDA;

        public int ID_VENDA
        {
            get { return _ID_VENDA; }
            set { _ID_VENDA = value; }
        }

        private int _ID_DATACONTA;

        public int ID_DATACONTA
        {
            get { return _ID_DATACONTA; }
            set { _ID_DATACONTA = value; }
        }
        private string _Data;

        public string Data
        {
            get { return _Data; }
            set { _Data = value; }
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


        private string _Data_Entregue;

        public string Data_Entregue
        {
            get { return _Data_Entregue; }
            set { _Data_Entregue = value; }
        }

        private string _Data_Lancamento;

        public string Data_Lacamento
        {
            get { return _Data_Lancamento; }
            set { _Data_Lancamento = value; }
        }

        private string _Tipo_Conta;

        public string Tipo_Conta
        {
            get { return _Tipo_Conta; }
            set { _Tipo_Conta= value; }
        }

        private string _TipoData;

        public string TipoData
        {
            get { return _TipoData; }
            set { _TipoData = value; }
        }

        private string _Descricao;

        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value.ToUpper(); }
        }

        private string _Departamento;

        public string Departamento
        {
            get { return _Departamento; }
            set { _Departamento = value.ToUpper(); }
        }

        private string _Forma_Pagamento;

        public string Forma_Pagamento
        {
            get { return _Forma_Pagamento; }
            set { _Forma_Pagamento = value; }
        }

        private string _Situacao;

        public string Situacao
        {
            get { return _Situacao; }
            set { _Situacao = value; }
        }


        private double _Valor_Total;

        public double Valor_Total
        {
            get { return _Valor_Total; }
            set { _Valor_Total = value; }
        }


        private int _Ativo;

        public int Ativo
        {
            get { return _Ativo; }
            set { _Ativo = value; }
        }

        private int _ID_Forma_Pagamento;

        public int ID_Forma_Pagamento
        {
            get { return _ID_Forma_Pagamento; }
            set { _ID_Forma_Pagamento = value; }
        }


        public OracleDataReader ConsultarValorMaximo()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT MAX(ID_CONTAS) AS ID FROM TB_CONTAS";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirFormaPag()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "DELETE FROM TB_DETALHE_CONTA WHERE ID_CONTAS ="+_ID_CONTAS;
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public void IncluirVenda()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "INSERT INTO TB_DETALHE_CONTA_VENDA (ID_DETALHE_VENDA, ID_CONTAS, ID_VENDA) VALUES ( SQ_DETALHE_CV.NEXTVAL,(SELECT MAX(ID_CONTAS) FROM TB_CONTAS), (SELECT MAX(ID_VENDA) FROM TB_VENDA_INGRESSO) )";

                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public void IncluirFormaPag(double ValorPag, char op) {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                if (op == 'I')//INCLUSÃO
                {
                    SQL = "INSERT INTO TB_DETALHE_CONTA (ID_DETALHE, ID_CONTAS, ID_FORMA_PAGAMENTO, VALOR) VALUES ( SQ_DETALHE_CONTA.NEXTVAL,(SELECT MAX(ID_CONTAS) FROM TB_CONTAS),  (SELECT ID_FORMA_PAGAMENTO FROM TB_FORMA_PAGAMENTO WHERE FORMA_PAGAMENTO= '"+_Forma_Pagamento+"'), '" + ValorPag + "')";
                }
                else//ALTERAÇÃO
                {
                    SQL = "INSERT INTO TB_DETALHE_CONTA (ID_DETALHE, ID_CONTAS, ID_FORMA_PAGAMENTO, VALOR) VALUES ( SQ_DETALHE_CONTA.NEXTVAL," + _ID_CONTAS + ", (SELECT ID_FORMA_PAGAMENTO FROM TB_FORMA_PAGAMENTO WHERE FORMA_PAGAMENTO= '" + _Forma_Pagamento + "'), " + ValorPag + ")";
                }
                
                c.ExecutarComando(SQL);
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
                SQL = "UPDATE TCCSHOW.TB_CONTAS SET ATIVO = '" + Valor + "' WHERE ID_CONTAS = " + _ID_CONTAS;
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      

 

        public DataSet ConsultarFormas()
        {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;

            comando = "SELECT FP.FORMA_PAGAMENTO, DT.VALOR FROM TB_DETALHE_CONTA DT INNER JOIN TB_FORMA_PAGAMENTO FP ON FP.ID_FORMA_PAGAMENTO= DT.ID_FORMA_PAGAMENTO WHERE ID_CONTAS="+_ID_CONTAS;
            return c.RetornarDataSet(comando);


        }
        public DataSet ListarGeral(string texto, int ativo, string tipo, string tipo2,string tSit, string tData, string tTipoPag)
        {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;

            string Where = string.Empty;
            if (tSit != string.Empty && tSit != null)
            {
                Where = " WHERE C.SITUACAO= '" + tSit+"' ";
            }
            if (tTipoPag != string.Empty && tTipoPag != null)
            {
                if (Where == string.Empty)
                {
                    Where = "WHERE FP.FORMA_PAGAMENTO= '" + tTipoPag + "' ";
                }
                else
                {
                    Where = Where + " AND FP.FORMA_PAGAMENTO= '" + tTipoPag + "'";
                }
            }
            if (tipo2!="Todas")
            {
                if (Where==string.Empty)
                {
                    Where = "WHERE C.TIPO_CONTA= '" + tipo2 + "'";
                }
                else
                {
                    Where = Where + " AND C.TIPO_CONTA= '" + tipo2 + "'";
                }
            }



   
                if (ativo == 2 && texto.Length == 0)
                {
                    if (Where != string.Empty)
                    {
                        comando = "SELECT DISTINCT C.ID_CONTAS,C.TIPO_CONTA, C.DESCRICAO , C.VALOR_TOTAL,DC.DATA_CONTA,C.SITUACAO, C.DEPARTAMENTO, C.DATA_LANCAMENTO, C.ATIVO  FROM TB_CONTAS C INNER JOIN TB_DATA_CONTA DC ON DC.ID_DATA_CONTA = C.ID_DATA_CONTA LEFT JOIN TB_DETALHE_CONTA ON TB_DETALHE_CONTA.ID_CONTAS= C.ID_CONTAS LEFT JOIN TB_FORMA_PAGAMENTO FP ON FP.ID_FORMA_PAGAMENTO= TB_DETALHE_CONTA.ID_FORMA_PAGAMENTO " + Where + " AND " + tData + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tData + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                    }
                    else
                    {
                        comando = "SELECT DISTINCT C.ID_CONTAS,C.TIPO_CONTA, C.DESCRICAO , C.VALOR_TOTAL,DC.DATA_CONTA,C.SITUACAO, C.DEPARTAMENTO, C.DATA_LANCAMENTO, C.ATIVO  FROM TB_CONTAS C INNER JOIN TB_DATA_CONTA DC ON DC.ID_DATA_CONTA = C.ID_DATA_CONTA LEFT JOIN TB_DETALHE_CONTA ON TB_DETALHE_CONTA.ID_CONTAS= C.ID_CONTAS LEFT JOIN TB_FORMA_PAGAMENTO FP ON FP.ID_FORMA_PAGAMENTO= TB_DETALHE_CONTA.ID_FORMA_PAGAMENTO WHERE " + tData + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tData + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                    }

                    //comando = "SELECT ID_ARTISTA, NOME, CPF, ATIVO, IDADE, CEP, SEXO, TELEFONE, NUMERO, COMPLEMENTO, DATADECRIACAO FROM TBARTISTA ORDER BY NOME";
                    return c.RetornarDataSet(comando);
                }
                else if (ativo == 2 && texto.Length != 0)
                {
                    if (Where != string.Empty)
                    {
                        comando = "SELECT DISTINCT C.ID_CONTAS,C.TIPO_CONTA, C.DESCRICAO , C.VALOR_TOTAL,DC.DATA_CONTA,C.SITUACAO, C.DEPARTAMENTO, C.DATA_LANCAMENTO, C.ATIVO  FROM TB_CONTAS C INNER JOIN TB_DATA_CONTA DC ON DC.ID_DATA_CONTA = C.ID_DATA_CONTA LEFT JOIN TB_DETALHE_CONTA ON TB_DETALHE_CONTA.ID_CONTAS= C.ID_CONTAS LEFT JOIN TB_FORMA_PAGAMENTO FP ON FP.ID_FORMA_PAGAMENTO= TB_DETALHE_CONTA.ID_FORMA_PAGAMENTO " + Where + " AND " + tipo + " LIKE '%" + texto + "%' AND " + tData + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tData+ "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                    }
                    else
                    {
                        comando = "SELECT DISTINCT C.ID_CONTAS,C.TIPO_CONTA, C.DESCRICAO , C.VALOR_TOTAL,DC.DATA_CONTA,C.SITUACAO, C.DEPARTAMENTO, C.DATA_LANCAMENTO, C.ATIVO  FROM TB_CONTAS C INNER JOIN TB_DATA_CONTA DC ON DC.ID_DATA_CONTA = C.ID_DATA_CONTA LEFT JOIN TB_DETALHE_CONTA ON TB_DETALHE_CONTA.ID_CONTAS= C.ID_CONTAS LEFT JOIN TB_FORMA_PAGAMENTO FP ON FP.ID_FORMA_PAGAMENTO= TB_DETALHE_CONTA.ID_FORMA_PAGAMENTO WHERE " + tipo + " LIKE '%" + texto + "%' AND " + tData + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tData + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                    }

                    return c.RetornarDataSet(comando);
                }
                else
                {
                    if (texto.Length == 0) // texto == null || texto == ""
                    {
                        if (Where != string.Empty)
                        {
                            comando = "SELECT DISTINCT C.ID_CONTAS,C.TIPO_CONTA, C.DESCRICAO , C.VALOR_TOTAL,DC.DATA_CONTA,C.SITUACAO, C.DEPARTAMENTO, C.DATA_LANCAMENTO, C.ATIVO  FROM TB_CONTAS C INNER JOIN TB_DATA_CONTA DC ON DC.ID_DATA_CONTA = C.ID_DATA_CONTA LEFT JOIN TB_DETALHE_CONTA ON TB_DETALHE_CONTA.ID_CONTAS= C.ID_CONTAS INNER JOIN TB_FORMA_PAGAMENTO FP ON FP.ID_FORMA_PAGAMENTO= TB_DETALHE_CONTA.ID_FORMA_PAGAMENTO " + Where + " AND C.ATIVO=" + ativo + " AND " + tData + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tData + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                        }
                        else
                        {
                            comando = "SELECT DISTINCT C.ID_CONTAS,C.TIPO_CONTA, C.DESCRICAO , C.VALOR_TOTAL,DC.DATA_CONTA,C.SITUACAO, C.DEPARTAMENTO, C.DATA_LANCAMENTO, C.ATIVO  FROM TB_CONTAS C INNER JOIN TB_DATA_CONTA DC ON DC.ID_DATA_CONTA = C.ID_DATA_CONTA LEFT JOIN TB_DETALHE_CONTA ON TB_DETALHE_CONTA.ID_CONTAS= C.ID_CONTAS LEFT JOIN TB_FORMA_PAGAMENTO FP ON FP.ID_FORMA_PAGAMENTO= TB_DETALHE_CONTA.ID_FORMA_PAGAMENTO WHERE C.ATIVO=" + ativo + " AND " + tData + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tData + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                        }


                        return c.RetornarDataSet(comando);
                    }
                    else
                    {
                        if (Where != string.Empty)
                        {
                            comando = "SELECT DISTINCT C.ID_CONTAS,C.TIPO_CONTA, C.DESCRICAO , C.VALOR_TOTAL,DC.DATA_CONTA,C.SITUACAO, C.DEPARTAMENTO, C.DATA_LANCAMENTO, C.ATIVO  FROM TB_CONTAS C INNER JOIN TB_DATA_CONTA DC ON DC.ID_DATA_CONTA = C.ID_DATA_CONTA LEFT JOIN TB_DETALHE_CONTA ON TB_DETALHE_CONTA.ID_CONTAS= C.ID_CONTAS LEFT JOIN TB_FORMA_PAGAMENTO FP ON FP.ID_FORMA_PAGAMENTO= TB_DETALHE_CONTA.ID_FORMA_PAGAMENTO " + Where + " AND " + tipo + " LIKE '%" + texto + "%' AND C.ATIVO = " + ativo + " AND " + tData + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tData + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                        }
                        else
                        {
                            comando = "SELECT DISTINCT C.ID_CONTAS,C.TIPO_CONTA, C.DESCRICAO , C.VALOR_TOTAL,DC.DATA_CONTA,C.SITUACAO, C.DEPARTAMENTO, C.DATA_LANCAMENTO, C.ATIVO  FROM TB_CONTAS C INNER JOIN TB_DATA_CONTA DC ON DC.ID_DATA_CONTA = C.ID_DATA_CONTA LEFT JOIN TB_DETALHE_CONTA ON TB_DETALHE_CONTA.ID_CONTAS= C.ID_CONTAS LEFT JOIN TB_FORMA_PAGAMENTO FP ON FP.ID_FORMA_PAGAMENTO= TB_DETALHE_CONTA.ID_FORMA_PAGAMENTO WHERE " + tipo + " LIKE '%" + texto + "%' AND C.ATIVO = " + ativo + " AND " + tData + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tData + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                        }

                        return c.RetornarDataSet(comando);
                    }
                }
            
           
        }


        public DataTable ListarGrafico()
        {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;
            comando = "SELECT SUM(C.VALOR_TOTAL) as VALOR, C.TIPO_CONTA, SUBSTR(DC.DATA_CONTA,4,7) as DATA_CONTA FROM TB_CONTAS C INNER JOIN TB_DATA_CONTA DC ON DC.ID_DATA_CONTA= C.ID_DATA_CONTA GROUP BY C.TIPO_CONTA, SUBSTR(DC.DATA_CONTA,4,7),C.SITUACAO HAVING TO_DATE(SUBSTR(DC.DATA_CONTA,4,7), 'mm/yy') BETWEEN TO_DATE('" + _DataListarInicio.ToString().Substring(3, 7) + "', 'mm/yy') AND TO_DATE('" + _DataListarFinal.ToString().Substring(3, 7) + "', 'mm/yy') AND(C.SITUACAO='Paga' OR C.SITUACAO='Recebida')";

            return c.RetornarDataTable(comando);
            
            
        }



        public OracleDataReader Consultar()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT TB_CONTAS.ID_CONTAS ,TB_CONTAS.ID_DATA_CONTA,TB_CONTAS.TIPO_CONTA, TB_CONTAS.DATA_LANCAMENTO,TB_CONTAS.DESCRICAO,TB_CONTAS.SITUACAO, TB_CONTAS.DEPARTAMENTO, TB_CONTAS.VALOR_TOTAL,TB_CONTAS.ATIVO,TB_DATA_CONTA.DATA_CONTA,TB_DATA_CONTA.TIPO_DATA, TB_CONTAS.DATA_ENTREGUE FROM TCCSHOW.TB_CONTAS INNER JOIN TCCSHOW.TB_DATA_CONTA ON TB_DATA_CONTA.ID_DATA_CONTA = TB_CONTAS.ID_DATA_CONTA WHERE ID_CONTAS = " + _ID_CONTAS;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OracleDataReader ConsultarVenda()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT TB_CONTAS.ID_CONTAS, DCV.ID_VENDA FROM TB_CONTAS INNER JOIN TCCSHOW.TB_DETALHE_CONTA_VENDA DCV ON DCV.ID_CONTAS = TB_CONTAS.ID_CONTAS INNER JOIN TB_DETALHE_CONTA DC ON DC.ID_CONTAS= TB_CONTAS.ID_CONTAS INNER JOIN TB_FORMA_PAGAMENTO ON TB_FORMA_PAGAMENTO.ID_FORMA_PAGAMENTO= DC.ID_FORMA_PAGAMENTO WHERE TB_CONTAS.ID_CONTAS = " + _ID_CONTAS;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Contas_crud(char opr)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SP_CONTAS";
                List<OracleParameter> p = new List<OracleParameter>();
                p.Add(new OracleParameter("vID_CONTAS", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ID_CONTAS });
                p.Add(new OracleParameter("vID_DATA_CONTA", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ID_DATACONTA });
                p.Add(new OracleParameter("vDATA_CONTA", Oracle.DataAccess.Client.OracleDbType.Date) { Value = _Data });
                p.Add(new OracleParameter("vTIPO_DATA", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _TipoData });
                p.Add(new OracleParameter("vTIPO_CONTA", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _Tipo_Conta });
                p.Add(new OracleParameter("vDATA_LANCAMENTO", Oracle.DataAccess.Client.OracleDbType.Date) { Value = _Data_Lancamento });
                p.Add(new OracleParameter("vDATA_ENTREGUE", Oracle.DataAccess.Client.OracleDbType.Date) { Value = Convert.ToDateTime(_Data_Entregue) });
                p.Add(new OracleParameter("vDESCRICAO", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _Descricao });
                p.Add(new OracleParameter("vSITUACAO", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _Situacao });
                p.Add(new OracleParameter("vDEPARTAMENTO", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _Departamento });
                p.Add(new OracleParameter("vVALOR_TOTAL", Oracle.DataAccess.Client.OracleDbType.Double) { Value = _Valor_Total });
                p.Add(new OracleParameter("vATIVO", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _Ativo });
                p.Add(new OracleParameter("vOPR", Oracle.DataAccess.Client.OracleDbType.Char) { Value = opr });
                c.ExecutarStoredProcedureParametro(SQL, p.ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        ///////////////////
    }
}
