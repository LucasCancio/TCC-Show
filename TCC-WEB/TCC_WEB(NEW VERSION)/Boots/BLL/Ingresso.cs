﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace BLL
{
    public class Ingresso
    {




        private static string SQL;
        private static SqlDataReader dr;



        private int _ID_FUNC;

        public int ID_FUNC
        {
            get { return _ID_FUNC; }
            set { _ID_FUNC = value; }
        }


        private int _ID_CLIENTE;

        public int ID_CLIENTE
        {
            get { return _ID_CLIENTE; }
            set { _ID_CLIENTE = value; }
        }



        private string _MOTIVO;

        public string MOTIVO
        {
            get { return _MOTIVO; }
            set { _MOTIVO = value; }
        }


        private int _ID_EVENTO;

        public int ID_EVENTO
        {
            get { return _ID_EVENTO; }
            set { _ID_EVENTO = value; }
        }

        private int _ID_EI;

        public int ID_EI
        {
            get { return _ID_EI; }
            set { _ID_EI = value; }
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

        private int _ID_VENDA;

        public int ID_VENDA
        {
            get { return _ID_VENDA; }
            set { _ID_VENDA = value; }
        }

        private int _ID_PAGAMENTO;

        public int ID_PAGAMENTO
        {
            get { return _ID_PAGAMENTO; }
            set { _ID_PAGAMENTO = value; }
        }

        private string _Preco_Total;

        public string Preco_Total
        {
            get { return _Preco_Total; }
            set { _Preco_Total = value; }
        }

        private string _Situacao;

        private string _BANDEIRA;

        private int _QTDE_PARCELAS;
        public string Situacao
        {
            get { return _Situacao; }
            set { _Situacao = value; }
        }

        private string _Preco_Total_Pago;

        public string Preco_Total_Pago
        {
            get { return _Preco_Total_Pago; }
            set { _Preco_Total_Pago = value; }
        }

        private string _Desconto;

        public string Desconto
        {
            get { return _Desconto; }
            set { _Desconto = value; }
        }

        private string _Troco;

        public string Troco
        {
            get { return _Troco; }
            set { _Troco = value; }
        }




        public int Ativo { get => _Ativo; set => _Ativo = value; }
        public string BANDEIRA { get => _BANDEIRA; set => _BANDEIRA = value; }
        public int QTDE_PARCELAS { get => _QTDE_PARCELAS; set => _QTDE_PARCELAS = value; }

        private int _Ativo;


        public void IncluirEventoIngresso()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "INSERT INTO TB_EVENTO_INGRESSO( PRECO_TOTAL, ID_EVENTO, ID_PAGAMENTO, DESCONTO, TROCO, PRECO_TOTAL_PAGO) VALUES ( " + _Preco_Total.Replace(",", ".") + " , " + _ID_EVENTO + " , (SELECT MAX(ID_PAGAMENTO) FROM TB_PAGAMENTO),  " + _Desconto.Replace(",", ".") + " , " + _Troco.Replace(",", ".") + " , " + _Preco_Total_Pago.Replace(",", ".") + " )";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IncluirPagamento(string FormaDePagamento, string Quantia)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "INSERT INTO TB_PAGAMENTO(ID_PAGAMENTO, ID_FORMA_PAGAMENTO, QUANTIA) VALUES ( (SELECT MAX(ID_VENDA) FROM TB_VENDA_INGRESSO), (SELECT ID_FORMA_PAGAMENTO FROM TB_FORMA_PAGAMENTO WHERE FORMA_PAGAMENTO='" + FormaDePagamento + "'), CAST('" + Quantia + "' AS NUMERIC))";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IncluirDetalhePag(string Tipo)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                if (Tipo=="Cred")
                {
                    SQL = "INSERT INTO TB_DETALHE_PGTO_CRED(ID_PAGAMENTO, ID_PAGAMENTO_GERAL, ID_BANDEIRA, QTDE_PARCELAS) VALUES ( (SELECT MAX(ID_VENDA) FROM TB_VENDA_INGRESSO), (SELECT MAX(ID_PAGAMENTO_GERAL) FROM TB_PAGAMENTO), (SELECT ID_BANDEIRA FROM TB_BANDEIRA WHERE DESC_BANDEIRA='" + BANDEIRA + "'), " + _QTDE_PARCELAS + " )";
                }
                else
                {
                    SQL = "INSERT INTO TB_DETALHE_PGTO_DEB(ID_PAGAMENTO, ID_PAGAMENTO_GERAL, ID_BANDEIRA) VALUES ( (SELECT MAX(ID_VENDA) FROM TB_VENDA_INGRESSO), (SELECT MAX(ID_PAGAMENTO_GERAL) FROM TB_PAGAMENTO), (SELECT ID_BANDEIRA FROM TB_BANDEIRA WHERE DESC_BANDEIRA='" + BANDEIRA + "') )";
                }
             
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void IncluirVendaIngresso()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "INSERT INTO TB_VENDA_INGRESSO( ID_CLIENTE, DATAVENDA, SITUACAO, ATIVO) VALUES ( '" + _ID_CLIENTE + "', GETDATE(), '" + _Situacao + "', " + _Ativo + ")";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void IncluirAssentoCliente(int Id_Assento)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "INSERT INTO TB_ASSENTO_CLI (ID_ASSENTO,ID_CLIENTE, ID_EVENTO, ATIVO) VALUES ('" + Id_Assento + "','" + _ID_CLIENTE + "', '" + _ID_EVENTO + "' , 1)";

                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IncluirItemVenda(int Id_Assento)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "INSERT INTO TB_ITEM_VENDA (ID_VENDA, ID_EI, ID_ASSENTO) VALUES ( (SELECT MAX(ID_VENDA) FROM TB_VENDA_INGRESSO), (SELECT MAX(ID_EI) FROM TB_EVENTO_INGRESSO), '" + Id_Assento + "')";

                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader ConsultarValidade()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT ATIVO FROM TB_VENDA_INGRESSO WHERE ID_VENDA='" + _ID_VENDA + "' ";

                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public void ValidarIngresso()
        //{
        //    try
        //    {
        //        DAO.ClasseConexao c = new DAO.ClasseConexao();
        //        SQL = "UPDATE TB_VENDA_INGRESSO SET ATIVO= 1 WHERE ID_VENDA='" + _ID_VENDA + "' ";

        //        c.ExecutarComando(SQL);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public void Cancelar(char opr)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SP_CANCELAR_VENDA";
                List<SqlParameter> p = new List<SqlParameter>();
                p.Add(new SqlParameter("@ID_VENDA", SqlDbType.Int) { Value = _ID_VENDA });
                p.Add(new SqlParameter("@MOTIVO", SqlDbType.VarChar) { Value = _MOTIVO });
                p.Add(new SqlParameter("@ID_FUNC", SqlDbType.Int) { Value = _ID_FUNC });
                p.Add(new SqlParameter("@OPR", SqlDbType.Char) { Value = opr });
                c.ExecutarStoredProcedureParametro(SQL, p.ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable ConsultarPorEvento()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT DISTINCT TB_VENDA_INGRESSO.ID_VENDA, TB_ASSENTO.ID_ASSENTO, TB_ASSENTO.ASSENTO_NUMER, TB_ASSENTO.ASSENTO_FILEIRA, TB_TIPO_ASSENTO.TIPO_ASSENTO, TB_SETOR.SETOR,"
                  + "TB_CLIENTE.ID_CLIENTE, TB_PESSOA.NOME,"
                  + "TB_EVENTO_INGRESSO.ID_EI, TB_EVENTO_INGRESSO.PRECO_TOTAL, TB_EVENTO_INGRESSO.ID_EVENTO, TB_EVENTO_INGRESSO.ID_PAGAMENTO "
                  + " FROM TB_ITEM_VENDA"
                  + " INNER JOIN TB_ASSENTO ON TB_ASSENTO.ID_ASSENTO = TB_ITEM_VENDA.ID_ASSENTO"
                  + " INNER JOIN TB_EVENTO_INGRESSO ON TB_EVENTO_INGRESSO.ID_EI = TB_ITEM_VENDA.ID_EI "
                  + " INNER JOIN TB_VENDA_INGRESSO ON TB_VENDA_INGRESSO.ID_VENDA = TB_ITEM_VENDA.ID_VENDA "
                  + " INNER JOIN TB_CLIENTE ON TB_CLIENTE.ID_CLIENTE = TB_VENDA_INGRESSO.ID_CLIENTE "
                  + " INNER JOIN TB_SETOR ON TB_SETOR.ID_SETOR = TB_ASSENTO.ID_SETOR "
                  + " INNER JOIN TB_TIPO_ASSENTO ON TB_TIPO_ASSENTO.ID_TIPO_ASSENTO = TB_ASSENTO.ID_TIPO_ASSENTO " +
                  "INNER JOIN TB_PESSOA ON TB_PESSOA.ID_PESSOA= TB_CLIENTE.ID_PESSOA"
                  + " INNER JOIN TB_ASSENTO_CLI ON TB_ASSENTO_CLI.ID_ASSENTO = TB_ITEM_VENDA.ID_ASSENTO WHERE TB_EVENTO_INGRESSO.ID_EVENTO = '" + _ID_EVENTO + "' AND TB_VENDA_INGRESSO.SITUACAO!='Cancelado' ";
                return c.RetornarDataTable(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader ConsultarReembolso()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT F.ID_FUNC, C.MOTIVO,C.DATA_CANCELAMENTO, P.NOME FROM TB_CANCELA_VENDA C INNER JOIN TB_FUNCIONARIO F ON F.ID_FUNC = C.ID_FUNC INNER JOIN TB_PESSOA P ON P.ID_PESSOA = F.ID_PESSOA WHERE C.ID_VENDA=" + _ID_VENDA;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SqlDataReader ConsultarPorCliente()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT TB_VENDA_INGRESSO.ID_VENDA, TB_ASSENTO.ID_ASSENTO, TB_ASSENTO.ASSENTO_NUMER,TB_ASSENTO.ASSENTO_FILEIRA, TB_ASSENTO.ID_TIPO_ASSENTO, TB_ASSENTO.ID_SETOR,TB_CLIENTE.ID_CLIENTE, TB_PESSOA.NOME, TB_CLIENTE.CPF, TB_EVENTO_INGRESSO.ID_EI, TB_EVENTO_INGRESSO.PRECO_TOTAL, TB_EVENTO_INGRESSO.ID_EVENTO, TB_EVENTO_INGRESSO.ID_PAGAMENTO FROM TB_ITEM_VENDA INNER JOIN TB_ASSENTO ON TB_ASSENTO.ID_ASSENTO = TB_ITEM_VENDA.ID_ASSENTO INNER JOIN TB_EVENTO_INGRESSO ON TB_EVENTO_INGRESSO.ID_EI = TB_ITEM_VENDA.ID_EI INNER JOIN TB_VENDA_INGRESSO ON TB_VENDA_INGRESSO.ID_VENDA = TB_ITEM_VENDA.ID_VENDA INNER JOIN TB_CLIENTE ON TB_CLIENTE.ID_CLIENTE = TB_VENDA_INGRESSO.ID_CLIENTE INNER JOIN TB_PESSOA ON TB_PESSOA.ID_PESSOA= TB_CLIENTE.ID_PESSOA WHERE TB_EVENTO_INGRESSO.ID_EVENTO = '" + _ID_EVENTO + "' AND TB_CLIENTE.ID_CLIENTE= '" + _ID_CLIENTE + "'";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataSet ListarIngresso(string texto, string situacao, string tipo, string tipo2, string fFileira, string fNumero, string fCategoria, string fTipoAssento)
        {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string where = string.Empty;
            if (fFileira != string.Empty && fFileira != "Todas" && fFileira != null)
            {
                if (where != string.Empty)
                {
                    where = where + " AND AST.ASSENTO_FILEIRA='" + fFileira + "' ";
                }
                else
                {
                    where = " AST.ASSENTO_FILEIRA='" + fFileira + "' ";
                }

            }
            if (fNumero != string.Empty && fNumero != "Todos" && fNumero != null)
            {
                if (where != string.Empty)
                {
                    where = where + " AND AST.ASSENTO_NUMER='" + fNumero + "' ";
                }
                else
                {
                    where = " AST.ASSENTO_NUMER='" + fNumero + "' ";

                }

            }
            if (fCategoria != string.Empty && fCategoria != "Todas" && fCategoria != null)
            {
                if (where != string.Empty)
                {
                    where = where + " AND ST.SETOR='" + fCategoria + "' ";
                }
                else
                {
                    where = " ST.SETOR='" + fCategoria + "' ";
                }

            }
            if (fTipoAssento != string.Empty && fTipoAssento != "Todos" && fTipoAssento != null)
            {
                if (where != string.Empty)
                {
                    where = where + " AND TPA.TIPO_ASSENTO='" + fTipoAssento + "' ";
                }
                else
                {
                    where = " TPA.TIPO_ASSENTO='" + fTipoAssento + "' ";
                }

            }

            string comando = string.Empty;
            switch (situacao)
            {
                case "0":///CANCELADOS
                    situacao = "AND TB_VENDA_INGRESSO.SITUACAO ='Cancelado'";
                    break;
                case "1":///PAGOS
                    situacao = "AND TB_VENDA_INGRESSO.SITUACAO ='Pago'";
                    break;
                case "3":///A PAGAR
                    situacao = "AND TB_VENDA_INGRESSO.SITUACAO ='A Pagar'";
                    break;
                case "2":
                    situacao = string.Empty;
                    break;

            }
            if (where != string.Empty)
            {
                where = where.ToUpper() + " AND ";
            }
            if (texto.Length != 0)
            {

                comando = "SELECT TB_VENDA_INGRESSO.ID_VENDA,FORMAT(TB_VENDA_INGRESSO.DATAVENDA, 'dd/MM/yyyy HH:mm'),TB_VENDA_INGRESSO.SITUACAO,TB_EVENTO_INGRESSO.PRECO_TOTAL,EV.DATA_EVENTO,CONCAT(CONCAT( FORMAT(EV.HORARIO_INICIO,'HH:mm') ,' até '),FORMAT(EV.HORARIO_FINAL,'HH:mm')) as HORARIO,EV.TITULO  FROM TB_PESSOA P INNER JOIN TB_CLIENTE CLI ON CLI.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_VENDA_INGRESSO ON TB_VENDA_INGRESSO.ID_CLIENTE= CLI.ID_CLIENTE INNER JOIN TB_ITEM_VENDA ITV ON ITV.ID_VENDA= TB_VENDA_INGRESSO.ID_VENDA INNER JOIN TB_EVENTO_INGRESSO ON TB_EVENTO_INGRESSO.ID_EI = ITV.ID_EI INNER JOIN TB_EVENTO EV ON EV.ID_EVENTO = TB_EVENTO_INGRESSO.ID_EVENTO INNER JOIN TB_ASSENTO AST ON AST.ID_ASSENTO= ITV.ID_ASSENTO WHERE " + tipo + " LIKE '%" + texto + "%' AND " + where + " CONVERT(DATETIME, " + tipo2 + ", 103) BETWEEN  CONVERT(DATETIME,'" + _DataListarInicio.ToString().Substring(0, 10) + "', 103) AND  CONVERT(DATETIME,'" + _DataListarFinal.ToString().Substring(0, 10) + "', 103) " + situacao + " GROUP BY TB_VENDA_INGRESSO.SITUACAO, TB_EVENTO_INGRESSO.PRECO_TOTAL,FORMAT(TB_VENDA_INGRESSO.DATAVENDA, 'dd/MM/yyyy HH:mm'),EV.DATA_EVENTO,CONCAT(CONCAT( FORMAT(EV.HORARIO_INICIO,'HH:mm') ,' até '),FORMAT(EV.HORARIO_FINAL,'HH:mm')) ,EV.TITULO,TB_VENDA_INGRESSO.ID_VENDA ORDER BY TB_VENDA_INGRESSO.ID_VENDA DESC";
            }
            else
            {
                comando = "SELECT TB_VENDA_INGRESSO.ID_VENDA,FORMAT(TB_VENDA_INGRESSO.DATAVENDA, 'dd/MM/yyyy HH:mm'),TB_VENDA_INGRESSO.SITUACAO,TB_EVENTO_INGRESSO.PRECO_TOTAL,EV.DATA_EVENTO,CONCAT(CONCAT( FORMAT(EV.HORARIO_INICIO,'HH:mm') ,' até '),FORMAT(EV.HORARIO_FINAL,'HH:mm')) as HORARIO,EV.TITULO  FROM TB_PESSOA P INNER JOIN TB_CLIENTE CLI ON CLI.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_VENDA_INGRESSO ON TB_VENDA_INGRESSO.ID_CLIENTE= CLI.ID_CLIENTE INNER JOIN TB_ITEM_VENDA ITV ON ITV.ID_VENDA= TB_VENDA_INGRESSO.ID_VENDA INNER JOIN TB_EVENTO_INGRESSO ON TB_EVENTO_INGRESSO.ID_EI = ITV.ID_EI INNER JOIN TB_EVENTO EV ON EV.ID_EVENTO = TB_EVENTO_INGRESSO.ID_EVENTO INNER JOIN TB_ASSENTO AST ON AST.ID_ASSENTO= ITV.ID_ASSENTO INNER JOIN TB_SETOR ST ON ST.ID_SETOR=AST.ID_SETOR INNER JOIN TB_TIPO_ASSENTO TPA ON TPA.ID_TIPO_ASSENTO= AST.ID_TIPO_ASSENTO WHERE " + where + " CONVERT(DATETIME, " + tipo2 + ", 103) BETWEEN  CONVERT(DATETIME,'" + _DataListarInicio.ToString().Substring(0, 10) + "', 103) AND  CONVERT(DATETIME,'" + _DataListarFinal.ToString().Substring(0, 10) + "', 103) " + situacao + " GROUP BY TB_VENDA_INGRESSO.SITUACAO, TB_EVENTO_INGRESSO.PRECO_TOTAL,FORMAT(TB_VENDA_INGRESSO.DATAVENDA, 'dd/MM/yyyy HH:mm'),EV.DATA_EVENTO,CONCAT(CONCAT( FORMAT(EV.HORARIO_INICIO,'HH:mm') ,' até '),FORMAT(EV.HORARIO_FINAL,'HH:mm')) ,EV.TITULO,TB_VENDA_INGRESSO.ID_VENDA ORDER BY TB_VENDA_INGRESSO.ID_VENDA DESC";
            }

            return c.RetornarDataSet(comando);

        }

        public DataSet ListarIngressoAssento()
        {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;
            comando = "SELECT CLI.ID_CLIENTE,TB_VENDA_INGRESSO.SITUACAO,  AST.ASSENTO_NUMER,AST.ASSENTO_FILEIRA, TB_TIPO_ASSENTO.TIPO_ASSENTO, TB_SETOR.SETOR,EV.ID_EVENTO,TB_VENDA_INGRESSO.ID_VENDA,TB_VENDA_INGRESSO.DATAVENDA,TB_EVENTO_INGRESSO.PRECO_TOTAL,EV.DATA_EVENTO,CONCAT(CONCAT( EV.HORARIO_INICIO ,' até '),EV.HORARIO_FINAL) as HORARIO,EV.TITULO  FROM TB_PESSOA P INNER JOIN TB_CLIENTE CLI ON CLI.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_VENDA_INGRESSO ON TB_VENDA_INGRESSO.ID_CLIENTE= CLI.ID_CLIENTE INNER JOIN TB_ITEM_VENDA ITV ON ITV.ID_VENDA= TB_VENDA_INGRESSO.ID_VENDA INNER JOIN TB_EVENTO_INGRESSO ON TB_EVENTO_INGRESSO.ID_EI = ITV.ID_EI INNER JOIN TB_EVENTO EV ON EV.ID_EVENTO = TB_EVENTO_INGRESSO.ID_EVENTO INNER JOIN TB_ASSENTO AST ON AST.ID_ASSENTO= ITV.ID_ASSENTO INNER JOIN TB_SETOR ON TB_SETOR.ID_SETOR= AST.ID_SETOR INNER JOIN TB_TIPO_ASSENTO ON TB_TIPO_ASSENTO.ID_TIPO_ASSENTO=AST.ID_TIPO_ASSENTO WHERE TB_VENDA_INGRESSO.ID_VENDA='" + _ID_VENDA + "'GROUP BY  CLI.ID_CLIENTE,AST.ASSENTO_NUMER,AST.ASSENTO_FILEIRA, TB_TIPO_ASSENTO.TIPO_ASSENTO, TB_SETOR.SETOR, EV.ID_EVENTO, TB_VENDA_INGRESSO.SITUACAO, TB_EVENTO_INGRESSO.PRECO_TOTAL,TB_VENDA_INGRESSO.DATAVENDA,EV.DATA_EVENTO,CONCAT(CONCAT( EV.HORARIO_INICIO ,' até '),EV.HORARIO_FINAL) ,EV.TITULO,TB_VENDA_INGRESSO.ID_VENDA ORDER BY TB_VENDA_INGRESSO.ID_VENDA";
            return c.RetornarDataSet(comando);

        }

        public DataSet ListarFormasPag()
        {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;
            comando = "SELECT TB_VENDA_INGRESSO.DATAVENDA,TB_FORMA_PAGAMENTO.FORMA_PAGAMENTO, TB_PAGAMENTO.QUANTIA, TB_EVENTO_INGRESSO.PRECO_TOTAL, TB_EVENTO_INGRESSO.DESCONTO,TB_EVENTO_INGRESSO.TROCO, TB_EVENTO_INGRESSO.PRECO_TOTAL_PAGO FROM TB_PESSOA P INNER JOIN TB_CLIENTE CLI ON CLI.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_VENDA_INGRESSO ON TB_VENDA_INGRESSO.ID_CLIENTE= CLI.ID_CLIENTE INNER JOIN TB_ITEM_VENDA ITV ON ITV.ID_VENDA= TB_VENDA_INGRESSO.ID_VENDA INNER JOIN TB_EVENTO_INGRESSO ON TB_EVENTO_INGRESSO.ID_EI = ITV.ID_EI INNER JOIN TB_EVENTO EV ON EV.ID_EVENTO = TB_EVENTO_INGRESSO.ID_EVENTO INNER JOIN TB_ASSENTO AST ON AST.ID_ASSENTO= ITV.ID_ASSENTO INNER JOIN TB_SETOR ON TB_SETOR.ID_SETOR= AST.ID_SETOR INNER JOIN TB_TIPO_ASSENTO ON TB_TIPO_ASSENTO.ID_TIPO_ASSENTO=AST.ID_TIPO_ASSENTO INNER JOIN TB_PAGAMENTO ON TB_PAGAMENTO.ID_PAGAMENTO = TB_EVENTO_INGRESSO.ID_PAGAMENTO INNER JOIN TB_FORMA_PAGAMENTO ON TB_FORMA_PAGAMENTO.ID_FORMA_PAGAMENTO = TB_PAGAMENTO.ID_FORMA_PAGAMENTO WHERE TB_VENDA_INGRESSO.ID_VENDA='" + _ID_VENDA + "'GROUP BY TB_VENDA_INGRESSO.DATAVENDA, TB_FORMA_PAGAMENTO.FORMA_PAGAMENTO, TB_PAGAMENTO.QUANTIA, TB_EVENTO_INGRESSO.PRECO_TOTAL, TB_EVENTO_INGRESSO.DESCONTO,TB_EVENTO_INGRESSO.TROCO, TB_EVENTO_INGRESSO.PRECO_TOTAL_PAGO ";
            return c.RetornarDataSet(comando);

        }


        public DataTable ListarGrafico()
        {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;
            comando = "SELECT SUM(C.VALOR_TOTAL) as VALOR, COUNT(C.VALOR_TOTAL) as QTDE, C.TIPO_CONTA, FORMAT(DC.DATA_CONTA , 'MM/yyyy') as DATA_CONTA FROM TB_CONTAS C INNER JOIN TB_DATA_CONTA DC ON DC.ID_DATA_CONTA= C.ID_DATA_CONTA INNER JOIN TB_DETALHE_CONTA_VENDA ON TB_DETALHE_CONTA_VENDA.ID_CONTAS= C.ID_CONTAS GROUP BY C.TIPO_CONTA, FORMAT(DC.DATA_CONTA , 'MM/yyyy') ,C.SITUACAO HAVING FORMAT(DC.DATA_CONTA , 'MM/yyyy') BETWEEN FORMAT(CAST('" + _DataListarInicio + "' AS DATETIME), 'MM/yyyy') AND FORMAT(CAST('" + _DataListarFinal + "' AS DATETIME), 'MM/yyyy') AND(C.SITUACAO='Paga' OR C.SITUACAO='Recebida') ";

            return c.RetornarDataTable(comando);


        }
    }
}
