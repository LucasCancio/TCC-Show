using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.OracleClient;
using System.Data; using Oracle.DataAccess.Client;


namespace BLL
{
   public class Artista
    {
        
    
        private static string SQL;
        private static OracleDataReader dr;

        private int _ID_ARTISTA_GERAL;

        public int ID_ARTISTA_GERAL
        {
            get { return _ID_ARTISTA_GERAL; }
            set { _ID_ARTISTA_GERAL = value; }
        }

        private int _ID_TIPO_PESSOA;

        public int ID_TIPO_PESSOA
        {
            get { return _ID_TIPO_PESSOA; }
            set { _ID_TIPO_PESSOA = value; }
        }

        private int _ID_PESSOA;

        public int ID_PESSOA
        {
            get { return _ID_PESSOA; }
            set { _ID_PESSOA = value; }
        }


        private int _ID_AGENTE;

        public int ID_AGENTE
        {
            get { return _ID_AGENTE; }
            set { _ID_AGENTE = value; }
        }

        private int _ID_ENDERECO;

        public int ID_ENDERECO
        {
            get { return _ID_ENDERECO; }
            set { _ID_ENDERECO = value; }
        }

        private int _ID_REDESOCIAL;

        public int ID_REDESOCIAL
        {
            get { return _ID_REDESOCIAL; }
            set { _ID_REDESOCIAL = value; }
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

        
        private string _Sexo;
        public string Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value.ToUpper(); }
        }

       

        private string _URL_IMG;
        public string URL_IMG
        {
            get { return _URL_IMG; }
            set { _URL_IMG = value.ToUpper(); }
        }

        
      

        private string _Telefone;
        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

      

      

        private string _Nome;
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value.ToUpper(); }
        }

        private string _Facebook;
        public string Facebook
        {
            get { return _Facebook; }
            set { _Facebook = value; }
        }

        private string _Twitter;
        public string Twitter
        {
            get { return _Twitter; }
            set { _Twitter = value; }
        }

        private string _INSTAGRAM;
        public string INSTAGRAM
        {
            get { return _INSTAGRAM; }
            set { _INSTAGRAM = value; }
        }

       

     

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

       
        private string _Social;
        public string Social
        {
            get { return _Social; }
            set { _Social = value; }
        }

       

        private DateTime _DataDeCriacao;

        public DateTime DataDeCriacao
        {
            get { return _DataDeCriacao; }
            set { _DataDeCriacao = value; }
        }

        private string _DataNasc;

        public string DataNasc
        {
            get { return _DataNasc; }
            set { _DataNasc = value; }
        }

        private int _Ativo;

        public int Ativo
        {
            get { return _Ativo; }
            set { _Ativo = value; }
        }

        private string _CPF;
        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }
  
 

        public OracleDataReader ConsultarValorMaximo()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT MAX(ID_ARTISTA_GERAL) AS ID FROM TB_ARTISTA_GERAL";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


       
        public OracleDataReader Verificar()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT P.NOME FROM TB_ARTISTA_GERAL INNER JOIN TB_PESSOA P ON P.ID_PESSOA=TB_ARTISTA_GERAL.ID_PESSOA INNER JOIN TB_EVENTO_ARTISTA ON TB_EVENTO_ARTISTA.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_EVENTO ON TB_EVENTO.ID_EVENTO = TB_EVENTO_ARTISTA.ID_EVENTO WHERE TB_EVENTO.ATIVO=1 AND TB_ARTISTA_GERAL.ID_ARTISTA_GERAL="+_ID_ARTISTA_GERAL;
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
                SQL = "UPDATE TB_PESSOA SET ATIVO = '" + Valor + "' WHERE ID_PESSOA = (SELECT ID_PESSOA FROM TB_ARTISTA_GERAL WHERE ID_ARTISTA_GERAL=" + _ID_ARTISTA_GERAL +")"; 
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


       

        public OracleDataReader ConsultarPessoa()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT P.ATIVO,P.NOME FROM TB_ARTISTA_GERAL AG INNER JOIN TB_PESSOA P ON P.ID_PESSOA= AG.ID_PESSOA WHERE AG.ID_ARTISTA_GERAL = " + _ID_ARTISTA_GERAL;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

     
        public OracleDataReader ConsultarNORMAL()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT P.ID_PESSOA, P.NOME,P.DATA_NASC, P.ATIVO, P.SEXO, AGT.ID_AGENTE, AGT.NOME_PRINCIPAL,AGT.DOCUMENTO, AGT.EMAIL, AGT.TELEFONE, AGT.ID_ENDERECO, E.CEP,C.UF, C.CIDADE,C.BAIRRO, C.DESCRICAO, E.NUMERO, E.COMPLEMENTO,TIPO_PESSOA,RD.ID_REDESOCIAL,RD.FACEBOOK, RD.INSTAGRAM, RD.TWITTER, AG.URL_IMG FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA  INNER JOIN TB_ARTISTA A ON A.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL  INNER JOIN TB_AGENTE AGT ON AGT.ID_AGENTE= A.ID_AGENTE  INNER JOIN TB_ENDERECO E ON E.ID_ENDERECO = AGT.ID_ENDERECO INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL = AG.ID_REDESOCIAL INNER JOIN TB_CEP C ON C.CEP= E.CEP WHERE AG.ID_ARTISTA_GERAL =" + _ID_ARTISTA_GERAL;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OracleDataReader ConsultarFIXO()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT P.ID_PESSOA,P.NOME,P.DATA_NASC, P.ATIVO, P.SEXO, AF.EMAIL, AF.TELEFONE,AF.CPF, AF.ID_ENDERECO, E.CEP,C.UF, C.CIDADE,C.BAIRRO, C.DESCRICAO, E.NUMERO, E.COMPLEMENTO,RD.ID_REDESOCIAL,RD.FACEBOOK, RD.INSTAGRAM, RD.TWITTER, AG.URL_IMG FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_ARTISTA_FIXO AF ON AF.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL INNER JOIN TB_ENDERECO E ON E.ID_ENDERECO = AF.ID_ENDERECO INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL = AG.ID_REDESOCIAL INNER JOIN TB_CEP C ON C.CEP= E.CEP WHERE AG.ID_ARTISTA_GERAL =" + _ID_ARTISTA_GERAL;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

     
     
        public DataSet ListarGeral(string tipoPessoa, string texto, int ativo, string tipo, string tipodata)
        {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;
            switch (tipoPessoa)
            {
                case "Ambos":
                    if (tipodata != string.Empty && tipodata != null)//COM DATA ESPECIFICA
                    {
                        if (ativo == 2 && texto.Length == 0)
                        {

                            comando = " SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO,  RD.FACEBOOK, RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA WHERE " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY AG.ID_ARTISTA_GERAL ";


                        }
                        else if (ativo == 2 && texto.Length != 0)
                        {
                            comando = "   SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO,  RD.FACEBOOK, RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA  WHERE " + tipo + " LIKE '%" + texto + "%' AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss')   ORDER BY " + tipo + "";

                        }
                        else
                        {
                            if (texto.Length == 0) // texto == null || texto == ""
                            {

                                comando = "    SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO,   RD.FACEBOOK, RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA WHERE P.ATIVO=" + ativo + "  AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";

                            }
                            else
                            {
                                comando = "  SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO,  RD.FACEBOOK, RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA WHERE " + tipo + " LIKE '%" + texto + "%' AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') AND P.ATIVO = " + ativo + " ORDER BY " + tipo + "";

                            }
                        }
                    }
                    else//sem data especifica
                    {
                        if (ativo == 2 && texto.Length == 0)
                        {

                            comando = " SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO,  RD.FACEBOOK, RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA ORDER BY AG.ID_ARTISTA_GERAL ";

                          
                        }
                        else if (ativo == 2 && texto.Length != 0)
                        {
                            comando = "   SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO,  RD.FACEBOOK, RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA  WHERE " + tipo + " LIKE '%" + texto + "%'   ORDER BY " + tipo + "";
                            
                        }
                        else
                        {
                            if (texto.Length == 0) // texto == null || texto == ""
                            {

                                comando = "    SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO,   RD.FACEBOOK, RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA WHERE P.ATIVO=" + ativo + " ORDER BY " + tipo + "";
                                
                            }
                            else
                            {
                                comando = "  SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO,  RD.FACEBOOK, RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA WHERE " + tipo + " LIKE '%" + texto + "%' AND P.ATIVO = " + ativo + " ORDER BY " + tipo + "";
                              
                            }
                        }
                    }
                        break;
                case "Artista":
                    if (tipodata != string.Empty && tipodata != null)//COM DATA ESPECIFICA
                    {
                        if (ativo == 2 && texto.Length == 0)
                        {

                            comando = " SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, AGT.NOME_PRINCIPAL, AGT.DOCUMENTO, RD.FACEBOOK,RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA INNER JOIN TB_ARTISTA ART ON ART.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL INNER JOIN TB_AGENTE AGT ON AGT.ID_AGENTE= ART.ID_AGENTE WHERE " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY AG.ID_ARTISTA_GERAL ";


                        }
                        else if (ativo == 2 && texto.Length != 0)
                        {
                            comando = " SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, AGT.NOME_PRINCIPAL, AGT.DOCUMENTO, RD.FACEBOOK,RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA INNER JOIN TB_ARTISTA ART ON ART.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL INNER JOIN TB_AGENTE AGT ON AGT.ID_AGENTE= ART.ID_AGENTE  WHERE " + tipo + " LIKE '%" + texto + "%'  AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss')  ORDER BY " + tipo + "";

                        }
                        else
                        {
                            if (texto.Length == 0) // texto == null || texto == ""
                            {

                                comando = "   SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, AGT.NOME_PRINCIPAL, AGT.DOCUMENTO, RD.FACEBOOK,RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA INNER JOIN TB_ARTISTA ART ON ART.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL INNER JOIN TB_AGENTE AGT ON AGT.ID_AGENTE= ART.ID_AGENTE WHERE P.ATIVO=" + ativo + " AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";

                            }
                            else
                            {
                                comando = "  SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, AGT.NOME_PRINCIPAL, AGT.DOCUMENTO, RD.FACEBOOK,RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA INNER JOIN TB_ARTISTA ART ON ART.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL INNER JOIN TB_AGENTE AGT ON AGT.ID_AGENTE= ART.ID_AGENTE WHERE " + tipo + " LIKE '%" + texto + "%' AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') AND P.ATIVO = " + ativo + " ORDER BY " + tipo + "";

                            }
                        }
                    }
                    else//sem data especifica
                    {
                        if (ativo == 2 && texto.Length == 0)
                        {

                            comando = " SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, AGT.NOME_PRINCIPAL, AGT.DOCUMENTO, RD.FACEBOOK,RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA INNER JOIN TB_ARTISTA ART ON ART.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL INNER JOIN TB_AGENTE AGT ON AGT.ID_AGENTE= ART.ID_AGENTE ORDER BY AG.ID_ARTISTA_GERAL ";


                        }
                        else if (ativo == 2 && texto.Length != 0)
                        {
                            comando = " SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, AGT.NOME_PRINCIPAL, AGT.DOCUMENTO, RD.FACEBOOK,RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA INNER JOIN TB_ARTISTA ART ON ART.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL INNER JOIN TB_AGENTE AGT ON AGT.ID_AGENTE= ART.ID_AGENTE  WHERE " + tipo + " LIKE '%" + texto + "%'   ORDER BY " + tipo + "";

                        }
                        else
                        {
                            if (texto.Length == 0) // texto == null || texto == ""
                            {

                                comando = "   SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, AGT.NOME_PRINCIPAL, AGT.DOCUMENTO, RD.FACEBOOK,RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA INNER JOIN TB_ARTISTA ART ON ART.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL INNER JOIN TB_AGENTE AGT ON AGT.ID_AGENTE= ART.ID_AGENTE WHERE P.ATIVO=" + ativo + " ORDER BY " + tipo + "";

                            }
                            else
                            {
                                comando = "  SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, AGT.NOME_PRINCIPAL, AGT.DOCUMENTO, RD.FACEBOOK,RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA INNER JOIN TB_ARTISTA ART ON ART.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL INNER JOIN TB_AGENTE AGT ON AGT.ID_AGENTE= ART.ID_AGENTE WHERE " + tipo + " LIKE '%" + texto + "%' AND P.ATIVO = " + ativo + " ORDER BY " + tipo + "";

                            }
                        }
                    }
                    break;
                case "ArtistaFixo":
                    if (tipodata != string.Empty && tipodata != null)//COM DATA ESPECIFICA
                    {
                        if (ativo == 2 && texto.Length == 0)
                        {

                            comando = " SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, AF.CPF, RD.FACEBOOK,RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA INNER JOIN TB_ARTISTA_FIXO AF ON AF.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL WHERE " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY AG.ID_ARTISTA_GERAL ";


                        }
                        else if (ativo == 2 && texto.Length != 0)
                        {
                            comando = " SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, AF.CPF, RD.FACEBOOK,RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA INNER JOIN TB_ARTISTA_FIXO AF ON AF.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL  WHERE " + tipo + " LIKE '%" + texto + "%' AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss')  ORDER BY " + tipo + "";

                        }
                        else
                        {
                            if (texto.Length == 0) // texto == null || texto == ""
                            {

                                comando = "   SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, AF.CPF, RD.FACEBOOK,RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA INNER JOIN TB_ARTISTA_FIXO AF ON AF.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL WHERE P.ATIVO=" + ativo + " AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";

                            }
                            else
                            {
                                comando = "  SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, AF.CPF, RD.FACEBOOK,RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA INNER JOIN TB_ARTISTA_FIXO AF ON AF.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL WHERE " + tipo + " LIKE '%" + texto + "%' AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') AND P.ATIVO = " + ativo + " ORDER BY " + tipo + "";

                            }
                        }
                    }
                    else//sem data especifica
                    {
                        if (ativo == 2 && texto.Length == 0)
                        {

                            comando = " SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, AF.CPF, RD.FACEBOOK,RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA INNER JOIN TB_ARTISTA_FIXO AF ON AF.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL ORDER BY AG.ID_ARTISTA_GERAL ";


                        }
                        else if (ativo == 2 && texto.Length != 0)
                        {
                            comando = " SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, AF.CPF, RD.FACEBOOK,RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA INNER JOIN TB_ARTISTA_FIXO AF ON AF.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL  WHERE " + tipo + " LIKE '%" + texto + "%'   ORDER BY " + tipo + "";

                        }
                        else
                        {
                            if (texto.Length == 0) // texto == null || texto == ""
                            {

                                comando = "   SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, AF.CPF, RD.FACEBOOK,RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA INNER JOIN TB_ARTISTA_FIXO AF ON AF.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL WHERE P.ATIVO=" + ativo + " ORDER BY " + tipo + "";

                            }
                            else
                            {
                                comando = "  SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, AF.CPF, RD.FACEBOOK,RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA INNER JOIN TB_ARTISTA_FIXO AF ON AF.ID_ARTISTA_GERAL= AG.ID_ARTISTA_GERAL WHERE " + tipo + " LIKE '%" + texto + "%' AND P.ATIVO = " + ativo + " ORDER BY " + tipo + "";

                            }
                        }
                    }
                    break;
            }
            return c.RetornarDataSet(comando);
        }


        public OracleDataReader VerificarEvento()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT EV_AR.ID_EVENTO FROM TB_EVENTO_ARTISTA EV_AR INNER JOIN  TB_PESSOA P ON P.ID_PESSOA= EV_AR.ID_PESSOA INNER JOIN TB_EVENTO EV ON EV.ID_EVENTO= EV_AR.ID_EVENTO  WHERE P.ID_PESSOA =(SELECT ID_PESSOA FROM TB_ARTISTA_GERAL WHERE ID_ARTISTA_GERAL= " + _ID_ARTISTA_GERAL + ") ";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Artista_crud(string opr)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SP_ARTISTA";
                List<OracleParameter> p = new List<OracleParameter>();
                p.Add(new OracleParameter("vID_ARTISTA_GERAL", Oracle.DataAccess.Client.OracleDbType.Int32){Value = _ID_ARTISTA_GERAL});
                p.Add(new OracleParameter("vID_REDESOCIAL", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ID_REDESOCIAL });
                p.Add(new OracleParameter("vFACEBOOK", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _Facebook });
                p.Add(new OracleParameter("vTWITTER", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _Twitter });
                p.Add(new OracleParameter("vINSTAGRAM", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _INSTAGRAM });
                p.Add(new OracleParameter("vID_PESSOA", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ID_PESSOA });
                
                p.Add(new OracleParameter("vID_TIPO_PESSOA", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ID_TIPO_PESSOA });
                p.Add(new OracleParameter("vURL_IMG", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _URL_IMG });
                p.Add(new OracleParameter("vID_AGENTE", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ID_AGENTE });
                p.Add(new OracleParameter("vID_ENDERECO", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ID_ENDERECO });
                p.Add(new OracleParameter("vTELEFONE", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _Telefone });
                p.Add(new OracleParameter("vCPF", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _CPF });
                p.Add(new OracleParameter("vEMAIL", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _Email});
                p.Add(new OracleParameter("vOPR", Oracle.DataAccess.Client.OracleDbType.Char) { Value = opr });
                c.ExecutarStoredProcedureParametro(SQL, p.ToArray());
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
                SQL = "  SELECT AF.ID_ARTISTA_GERAL,AF.CPF FROM TB_ARTISTA_FIXO AF WHERE AF.CPF= '" + _CPF + "' ";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //////////////////////////////////////////////////////
    }


}

