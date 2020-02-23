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
    class Ingresso
    {
        private static string SQL;
        private static SqlDataReader dr;

        private int _IdAssento;
        private int _IdCliente;
        private int _IdTipoAssento;
        private int _IdSetor;
        private int _IdEvento;
        private int _IdEi;
        private int _IdVenda;
        private int _IdPagamento;
        private string _PrecoTotal;
        private string _Desconto;
        private string _AssentoNumer;
        private string _Situacao;

        public int IdAssento { get => _IdAssento; set => _IdAssento = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public int IdTipoAssento { get => _IdTipoAssento; set => _IdTipoAssento = value; }
        public int IdSetor { get => _IdSetor; set => _IdSetor = value; }
        public int IdEvento { get => _IdEvento; set => _IdEvento = value; }
        public int IdEi { get => _IdEi; set => _IdEi = value; }
        public int IdVenda { get => _IdVenda; set => _IdVenda = value; }
        public int IdPagamento { get => _IdPagamento; set => _IdPagamento = value; }
        public string PrecoTotal { get => _PrecoTotal; set => _PrecoTotal = value; }
        public string Desconto { get => _Desconto; set => _Desconto = value; }
        public string AssentoNumer { get => _AssentoNumer; set => _AssentoNumer = value; }
        public string Situacao { get => _Situacao; set => _Situacao = value; }

        public void IncluirVendaIngresso()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "INSERT INTO [TB_VENDA_INGRESSO]([ID_VENDA], [ID_CLIENTE], [DATAVENDA], [SITUACAO]) VALUES (SQ_VENDA.NEXTVAL, '" + _IdCliente + "', GETDATE(), '" + _Situacao + "')";
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
                SQL = "INSERT INTO [TB_ASSENTO_CLI] ([ID_ASSENTO],[ID_CLIENTE], [ID_EVENTO], [ATIVO]) VALUES ('" + IdAssento + "','" + _IdCliente + "', '" + _IdEvento + "' , 1)";

                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IncluirEventoIngresso()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "INSERT INTO [TB_EVENTO_INGRESSO]([ID_EI], [PRECO_TOTAL], [ID_EVENTO], [ID_PAGAMENTO], [DESCONTO], [TROCO], [PRECO_TOTAL_PAGO]) VALUES (TCCSHOW.SQ_EVENTO_INGRESSO.NEXTVAL, '" + _PrecoTotal + "', '" + _IdEvento + "', (SELECT MAX([ID_PAGAMENTO]) FROM [TB_PAGAMENTO]),  '" + _Desconto + "', '" + " '0' " + "', '" + _PrecoTotal + "')";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
