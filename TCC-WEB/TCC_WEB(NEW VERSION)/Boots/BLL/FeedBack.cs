using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BLL
{
   public class FeedBack
    {
        private static string SQL;
        private static SqlDataReader dr;

        private int _ID_FEEDBACK;

        private string _TITULO;
        public int ID_FEEDBACK { get => _ID_FEEDBACK; set => _ID_FEEDBACK = value; }
        public string MENSAGEM { get => _MENSAGEM; set => _MENSAGEM = value; }
        public int ID_CLIENTE { get => _ID_CLIENTE; set => _ID_CLIENTE = value; }
        public int AVALIACAO { get => _AVALIACAO; set => _AVALIACAO = value; }
        public string TITULO { get => _TITULO; set => _TITULO = value; }

        private string _MENSAGEM;

        private int _ID_CLIENTE;

        private int _AVALIACAO;

        public void IncluirMensagem()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "INSERT INTO TB_FEEDBACK( MENSAGEM, TITULO, AVALIACAO, ID_PESSOA, DATA_ENVIO) VALUES ( '" + _MENSAGEM + "', '"+_TITULO+"'  ,'" + _AVALIACAO + "', (SELECT ID_PESSOA FROM TB_CLIENTE WHERE ID_CLIENTE="+_ID_CLIENTE+"), GETDATE())";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public void AlterarMensagem()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "UPDATE TB_FEEDBACK SET MENSAGEM='"+_MENSAGEM+"', TITULO='"+_TITULO+"', AVALIACAO="+_AVALIACAO+" ,DATA_ENVIO= GETDATE() WHERE ID_FEEDBACK="+_ID_FEEDBACK;
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void RemoverMensagem()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "DELETE FROM TB_FEEDBACK WHERE ID_FEEDBACK="+_ID_FEEDBACK;
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }




    }
}
