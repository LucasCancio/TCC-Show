using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.OracleClient;
using System.Data;
using Oracle.DataAccess.Client;

namespace BLL
{
   public class Empresario
    {
        
    
        
    
        private static string SQL;
        private static OracleDataReader dr;



        private int _ID_Agente;

        public int ID_Agente
        {
            get { return _ID_Agente; }
            set { _ID_Agente = value; }
        }

        private int _ID_PESSOA;

        public int ID_PESSOA
        {
            get { return _ID_PESSOA; }
            set { _ID_PESSOA = value; }
        }

        private int _ID_ENDERECO;

        public int ID_ENDERECO
        {
            get { return _ID_ENDERECO; }
            set { _ID_ENDERECO = value; }
        }

        

        

        private string _Documento;
        public string Documento
        {
            get { return _Documento; }
            set { _Documento = value; }
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

        private string _NomePrincipal;
        public string NomePrincipal
        {
            get { return _NomePrincipal; }
            set { _NomePrincipal = value; }
        }

        private string _NomeSecundario;
        public string NomeSecundario
        {
            get { return _NomeSecundario; }
            set { _NomeSecundario = value; }
        }

        private string _TipoPessoa;
        public string TipoPessoa
        {
            get { return _TipoPessoa; }
            set { _TipoPessoa = value.ToUpper(); }
        }

        private DateTime _DataDeCriacao;

        public DateTime DataDeCriacao
        {
            get { return _DataDeCriacao; }
            set { _DataDeCriacao = value; }
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

        private int _Ativo;

        public int Ativo
        {
            get { return _Ativo; }
            set { _Ativo = value; }
        }

       
      
     



       

        public void Ativar(Byte Valor)
        { //Valor 1 = Reativar    Valor 0 = Desativar
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "UPDATE TB_AGENTE SET ATIVO = '" + Valor + "' WHERE ID_AGENTE = " + _ID_Agente;
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public OracleDataReader VerificarArtista()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT * FROM TB_ARTISTA WHERE ID_AGENTE = " + _ID_Agente + " ";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OracleDataReader ConsultarGeral()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT TB_AGENTE.ID_AGENTE, TB_AGENTE.ID_ENDERECO, TB_AGENTE.TELEFONE,TB_AGENTE.TIPO_PESSOA,  TB_AGENTE.EMAIL, TB_AGENTE.DOCUMENTO, TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.DESCRICAO, TB_CEP.CIDADE, TB_CEP.BAIRRO, TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO FROM TB_AGENTE INNER JOIN TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE TB_AGENTE.ID_AGENTE= " + _ID_Agente;
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
                SQL = "SELECT MAX(ID_AGENTE) AS ID FROM TB_AGENTE";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public OracleDataReader ConsultarDocumento()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT TB_AGENTE.ID_AGENTE, TB_AGENTE.DOCUMENTO FROM TB_AGENTE WHERE TB_AGENTE.DOCUMENTO= '" + _Documento+"'";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

 


        public DataSet ListarGeral(string tipoPessoa, string texto, int ativo, string tipo, string tipodata) {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;
            switch (tipoPessoa)
            {
                case "Ambos":

                    if (tipodata != string.Empty && tipodata!= null)//COM DATA ESPECIFICA
                    {
                        if (ativo == 2 && texto.Length == 0)
                        {

                            comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE TB_AGENTE.ID_AGENTE != '0' AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                            //comando = "SELECT ID_ARTISTA, NOME, CPF, ATIVO, IDADE, CEP, SEXO, TELEFONE, NUMERO, COMPLEMENTO, DATADECRIACAO FROM TBARTISTA ORDER BY NOME";
                            
                        }
                        else if (ativo == 2 && texto.Length != 0)
                        {
                            comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE " + tipo + " LIKE '%" + texto + "%' AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') AND TB_AGENTE.ID_AGENTE != '0' ORDER BY " + tipo + "";
                           
                        }
                        else
                        {
                            if (texto.Length == 0) // texto == null || texto == ""
                            {

                                comando = "  SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE ATIVO=" + ativo + " AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') AND TB_AGENTE.ID_AGENTE != '0' ORDER BY " + tipo + "";
                                
                            }
                            else
                            {
                                comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE " + tipo + " LIKE '%" + texto + "%' AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') AND ATIVO = " + ativo + " AND TB_AGENTE.ID_AGENTE != '0' ORDER BY " + tipo + "";
                               
                            }
                        }
                    }
                    else//sem data especifica
                    {
                        if (ativo == 2 && texto.Length == 0)
                        {

                            comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE TB_AGENTE.ID_AGENTE != '0' ORDER BY " + tipo + "";
                            //comando = "SELECT ID_ARTISTA, NOME, CPF, ATIVO, IDADE, CEP, SEXO, TELEFONE, NUMERO, COMPLEMENTO, DATADECRIACAO FROM TBARTISTA ORDER BY NOME";
                           
                        }
                        else if (ativo == 2 && texto.Length != 0)
                        {
                            comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE " + tipo + " LIKE '%" + texto + "%' AND TB_AGENTE.ID_AGENTE != '0' ORDER BY " + tipo + "";
                            
                        }
                        else
                        {
                            if (texto.Length == 0) // texto == null || texto == ""
                            {

                                comando = "  SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE ATIVO=" + ativo + " AND TB_AGENTE.ID_AGENTE != '0' ORDER BY " + tipo + "";
                               
                            }
                            else
                            {
                                comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE " + tipo + " LIKE '%" + texto + "%' AND ATIVO = " + ativo + " AND TB_AGENTE.ID_AGENTE != '0' ORDER BY " + tipo + "";
                                
                            }
                        }
                    }


                    break;
                case "Empresario":


                    if (tipodata != string.Empty && tipodata!= null)//COM DATA ESPECIFICA
                    {
                        if (ativo == 2 && texto.Length == 0)
                        {

                            comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE TB_AGENTE.ID_AGENTE != '0' AND TB_AGENTE.TIPO_PESSOA= 'FÍSICA' AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                            //comando = "SELECT ID_ARTISTA, NOME, CPF, ATIVO, IDADE, CEP, SEXO, TELEFONE, NUMERO, COMPLEMENTO, DATADECRIACAO FROM TBARTISTA ORDER BY NOME";

                        }
                        else if (ativo == 2 && texto.Length != 0)
                        {
                            comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE " + tipo + " LIKE '%" + texto + "%' AND TB_AGENTE.TIPO_PESSOA= 'FÍSICA' AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') AND TB_AGENTE.ID_AGENTE != '0' ORDER BY " + tipo + "";

                        }
                        else
                        {
                            if (texto.Length == 0) // texto == null || texto == ""
                            {

                                comando = "  SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE ATIVO=" + ativo + " AND TB_AGENTE.TIPO_PESSOA= 'FÍSICA' AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') AND TB_AGENTE.ID_AGENTE != '0' ORDER BY " + tipo + "";

                            }
                            else
                            {
                                comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE " + tipo + " LIKE '%" + texto + "%' AND TB_AGENTE.TIPO_PESSOA= 'FÍSICA' AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') AND ATIVO = " + ativo + " AND TB_AGENTE.ID_AGENTE != '0' ORDER BY " + tipo + "";

                            }
                        }
                    }
                    else//sem data especifica
                    {
                        if (ativo == 2 && texto.Length == 0)
                        {

                            comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE TB_AGENTE.ID_AGENTE != '0' AND TB_AGENTE.TIPO_PESSOA= 'FÍSICA' ORDER BY " + tipo + "";
                            //comando = "SELECT ID_ARTISTA, NOME, CPF, ATIVO, IDADE, CEP, SEXO, TELEFONE, NUMERO, COMPLEMENTO, DATADECRIACAO FROM TBARTISTA ORDER BY NOME";

                        }
                        else if (ativo == 2 && texto.Length != 0)
                        {
                            comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE " + tipo + " LIKE '%" + texto + "%' AND TB_AGENTE.ID_AGENTE != '0' AND TB_AGENTE.TIPO_PESSOA= 'FÍSICA' ORDER BY " + tipo + "";

                        }
                        else
                        {
                            if (texto.Length == 0) // texto == null || texto == ""
                            {

                                comando = "  SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE ATIVO=" + ativo + " AND TB_AGENTE.ID_AGENTE != '0' AND TB_AGENTE.TIPO_PESSOA= 'FÍSICA' ORDER BY " + tipo + "";

                            }
                            else
                            {
                                comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE " + tipo + " LIKE '%" + texto + "%' AND ATIVO = " + ativo + " AND TB_AGENTE.ID_AGENTE != '0' AND TB_AGENTE.TIPO_PESSOA= 'FÍSICA' ORDER BY " + tipo + "";

                            }
                        }
                    }




                    break;
                case "Empresa":


                    if (tipodata != string.Empty && tipodata!= null)//COM DATA ESPECIFICA
                    {
                        if (ativo == 2 && texto.Length == 0)
                        {

                            comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE TB_AGENTE.ID_AGENTE != '0' AND TB_AGENTE.TIPO_PESSOA= 'JURÍDICA' AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') ORDER BY " + tipo + "";
                            //comando = "SELECT ID_ARTISTA, NOME, CPF, ATIVO, IDADE, CEP, SEXO, TELEFONE, NUMERO, COMPLEMENTO, DATADECRIACAO FROM TBARTISTA ORDER BY NOME";

                        }
                        else if (ativo == 2 && texto.Length != 0)
                        {
                            comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE " + tipo + " LIKE '%" + texto + "%' AND TB_AGENTE.TIPO_PESSOA= 'JURÍDICA' AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') AND TB_AGENTE.ID_AGENTE != '0' ORDER BY " + tipo + "";

                        }
                        else
                        {
                            if (texto.Length == 0) // texto == null || texto == ""
                            {

                                comando = "  SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE ATIVO=" + ativo + " AND TB_AGENTE.TIPO_PESSOA= 'JURÍDICA' AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') AND TB_AGENTE.ID_AGENTE != '0' ORDER BY " + tipo + "";

                            }
                            else
                            {
                                comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE " + tipo + " LIKE '%" + texto + "%' AND TB_AGENTE.TIPO_PESSOA= 'JURÍDICA' AND " + tipodata + ">= TO_DATE('" + _DataListarInicio + "', ' dd/mm/yyyy hh24:mi:ss') AND " + tipodata + "<= TO_DATE('" + _DataListarFinal + "', ' dd/mm/yyyy hh24:mi:ss') AND ATIVO = " + ativo + " AND TB_AGENTE.ID_AGENTE != '0' ORDER BY " + tipo + "";

                            }
                        }
                    }
                    else//sem data especifica
                    {
                        if (ativo == 2 && texto.Length == 0)
                        {

                            comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE TB_AGENTE.ID_AGENTE != '0' AND TB_AGENTE.TIPO_PESSOA= 'JURÍDICA' ORDER BY " + tipo + "";
                            //comando = "SELECT ID_ARTISTA, NOME, CPF, ATIVO, IDADE, CEP, SEXO, TELEFONE, NUMERO, COMPLEMENTO, DATADECRIACAO FROM TBARTISTA ORDER BY NOME";

                        }
                        else if (ativo == 2 && texto.Length != 0)
                        {
                            comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE " + tipo + " LIKE '%" + texto + "%' AND TB_AGENTE.ID_AGENTE != '0' AND TB_AGENTE.TIPO_PESSOA= 'JURÍDICA' ORDER BY " + tipo + "";

                        }
                        else
                        {
                            if (texto.Length == 0) // texto == null || texto == ""
                            {

                                comando = "  SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE ATIVO=" + ativo + " AND TB_AGENTE.ID_AGENTE != '0' AND TB_AGENTE.TIPO_PESSOA= 'JURÍDICA' ORDER BY " + tipo + "";

                            }
                            else
                            {
                                comando = "   SELECT TB_AGENTE.ID_AGENTE,TB_AGENTE.NOME_PRINCIPAL, TB_AGENTE.NOME_SECUNDARIO, TB_AGENTE.TIPO_PESSOA ,TB_AGENTE.DOCUMENTO, TB_AGENTE.TELEFONE, TB_AGENTE.EMAIL, TB_AGENTE.ATIVO, TB_CEP.CEP, TB_CEP.UF, TB_CEP.CIDADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO,TB_CEP.DESCRICAO, TB_AGENTE.DATA_CRIACAO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_ENDERECO = TB_AGENTE.ID_ENDERECO INNER JOIN TCCSHOW.TB_CEP ON TB_CEP.CEP = TB_ENDERECO.CEP WHERE " + tipo + " LIKE '%" + texto + "%' AND ATIVO = " + ativo + " AND TB_AGENTE.ID_AGENTE != '0' AND TB_AGENTE.TIPO_PESSOA= 'JURÍDICA' ORDER BY " + tipo + "";

                            }
                        }
                    }

                    break;
            }
            return c.RetornarDataSet(comando);
            
            
        }

       

        public void Agente_crud(char opr)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SP_AGENTE";
                List<OracleParameter> p = new List<OracleParameter>();
                p.Add(new OracleParameter("vID_AGENTE", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ID_Agente });
                p.Add(new OracleParameter("vID_ENDERECO", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _ID_ENDERECO });
                p.Add(new OracleParameter("vTELEFONE", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _Telefone });
                p.Add(new OracleParameter("vTIPO_PESSOA", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _TipoPessoa });
                p.Add(new OracleParameter("vDOCUMENTO", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _Documento });
                p.Add(new OracleParameter("vEMAIL", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _Email });
                p.Add(new OracleParameter("vNOME_PRINCIPAL", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _NomePrincipal });
                p.Add(new OracleParameter("vNOME_SECUNDARIO", Oracle.DataAccess.Client.OracleDbType.Varchar2) { Value = _NomeSecundario });
                p.Add(new OracleParameter("vATIVO", Oracle.DataAccess.Client.OracleDbType.Int32) { Value = _Ativo });
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
