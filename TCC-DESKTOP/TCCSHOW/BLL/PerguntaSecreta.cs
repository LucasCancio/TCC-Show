using System;
using System.Data;
using Oracle.DataAccess.Client;

namespace BLL
{
    public class PerguntaSecreta
    {
        DAO.ClasseConexao c = new DAO.ClasseConexao();
        private static string SQL;


        private int _PerguntaSecretaId;

        public int PerguntaSecretaId
        {
            get { return _PerguntaSecretaId; }
            set { _PerguntaSecretaId = value; }
        }

        private string _Descricao;

        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value.ToUpper(); }
        }

        private string _Resposta;

        public string Resposta
        {
            get { return _Resposta; }
            set { _Resposta = value; }
        }

        private int _Ativo;

        public int Ativo
        {
            get { return _Ativo; }
            set { _Ativo = value; }
        }


   

      

     

      
       

        public OracleDataReader Consultar()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT * FROM TCCSHOW.TB_PERGUNTASECRETA WHERE ID_PERGUNTASECRETA = " + _PerguntaSecretaId + " ";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
        }

       



    }
}
