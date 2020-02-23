using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; //using Sql.DataAccess.Client;
using System.Data.SqlClient;
namespace BLL
{
    public class Evento
    {





        private static string SQL;
        private static SqlDataReader dr;

        private int _ID_EVENTO;

        public int ID_EVENTO
        {
            get { return _ID_EVENTO; }
            set { _ID_EVENTO = value; }
        }

        private string _URL_IMG;

        public string URL_IMG
        {
            get => _URL_IMG;
            set => _URL_IMG = value;
        }

        private int _ID_ARTISTA_GERAL;

        public int ID_ARTISTA_GERAL
        {
            get { return _ID_ARTISTA_GERAL; }
            set { _ID_ARTISTA_GERAL = value; }
        }

        private DateTime _DataEvento;

        public DateTime DataEvento
        {
            get { return _DataEvento; }
            set { _DataEvento = value; }
        }


        private DateTime _HorarioINICIO;

        public DateTime HorarioINICIO
        {
            get { return _HorarioINICIO; }
            set { _HorarioINICIO = value; }
        }

        private string _Titulo;

        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value.ToUpper(); }
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

        private DateTime _HorarioFINAL;

        public DateTime HorarioFINAL
        {
            get { return _HorarioFINAL; }
            set { _HorarioFINAL = value; }
        }

        private string _Duracao;

        public string Duracao
        {
            get { return _Duracao; }
            set { _Duracao = value; }
        }
        private string _Descricao;

        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value.ToUpper(); }
        }

        private string _Tipo_Pag;

        public string Tipo_Pag
        {
            get { return _Tipo_Pag; }
            set { _Tipo_Pag = value; }
        }

        private int _Ativo;

        public int Ativo
        {
            get { return _Ativo; }
            set { _Ativo = value; }
        }

        private int _N_ARTISTAS;

        public int N_ARTISTAS
        {
            get { return _N_ARTISTAS; }
            set { _N_ARTISTAS = value; }
        }

        private double _Valor_Evento;

        public double Valor_Evento
        {
            get { return _Valor_Evento; }
            set { _Valor_Evento = value; }
        }



        public SqlDataReader ConsultarValorMaximo()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT MAX(ID_EVENTO) AS ID FROM TB_EVENTO";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void IncluirEventoArtista()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();//                                                                                        
                SQL = "INSERT INTO TB_EVENTO_ARTISTA(ID_PESSOA, ID_EVENTO) VALUES( (SELECT ID_PESSOA FROM TB_ARTISTA_GERAL WHERE ID_ARTISTA_GERAL='" + _ID_ARTISTA_GERAL + "'),(SELECT MAX(ID_EVENTO) FROM TB_EVENTO))";
                // SQL="INSERT INTO TBEVENTO_ARTISTA(ID_ARTISTA, ID_EVENTO) VALUES('1', (SELECT MAX(ID_EVENTO) FROM TBEVENTO))";
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void AdicionarEventoArtista()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                //  SQL = "UPDATE TBEVENTO SET NOME='"+_Nome+"', CPF ='"+_CPF+ "', DATADECRIACAO = CONVERT(DATETIME,'" + _DataDeCriacao + "', 103), IDADE= " + _IDADE+", CEP='"+_CEP+"', SEXO='"+_Sexo+"', TELEFONE='"+_Telefone+"', ENDERECO='"+_Endereco+"', CIDADE='"+_Cidade+"', ESTADO='"+_Estado+"', COMPLEMENTO='"+_Complemento+"', ATIVO= " + _Ativo + " WHERE ID_ARTISTA= " + _ID_ARTISTA;
                SQL = "INSERT INTO TB_EVENTO_ARTISTA(ID_PESSOA,ID_EVENTO) VALUES ((SELECT ID_PESSOA FROM TB_ARTISTA_GERAL WHERE ID_ARTISTA_GERAL= '" + _ID_ARTISTA_GERAL + "'), '" + _ID_EVENTO + "')";
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
                SQL = "UPDATE TB_EVENTO SET ATIVO = '" + Valor + "' WHERE ID_EVENTO = " + _ID_EVENTO;
                c.ExecutarComando(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirArtista()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                //SQL = "DELETE FROM TB_EVENTO_ARTISTA WHERE ID_EVENTO='"+ _ID_EVENTO +"' AND ID_PESSOA=(SELECT ID_PESSOA FROM TB_ARTISTA_GERAL WHERE ID_ARTISTA_GERAL= '"+_ID_ARTISTA_GERAL+"') ";
                SQL = "DELETE FROM TB_EVENTO_ARTISTA WHERE ID_EVENTO='" + _ID_EVENTO + "' ";
                c.ExecutarComando(SQL);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SqlDataReader Consultar()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT * FROM TB_EVENTO WHERE ID_EVENTO = " + _ID_EVENTO;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public SqlDataReader Verificar(string HorarioInicio, string HorarioFinal)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT CONVERT(DATETIME,'22:15', 114),ID_EVENTO, TITULO, DATA_EVENTO, DESCRICAO, SUBSTRING(CAST(HORARIO_INICIO AS VARCHAR), 10, 5),SUBSTRING(CAST(HORARIO_FINAL AS VARCHAR), 10, 5),DURACAO, N_ARTISTAS,TIPO_PAG, ATIVO, VALOR_EVENTO FROM TB_EVENTO WHERE DATA_EVENTO= CONVERT(DATETIME,'" + _DataEvento + "', 103)AND( CONVERT(DATETIME,SUBSTRING(CAST(HORARIO_INICIO AS VARCHAR),10,5), 114) BETWEEN CONVERT(DATETIME,'" + HorarioInicio + "', 114)AND CONVERT(DATETIME,'" + HorarioFinal + "', 114) OR CONVERT(DATETIME,SUBSTRING(CAST(HORARIO_FINAL AS VARCHAR),10,5), 114) BETWEEN CONVERT(DATETIME,'" + HorarioInicio + "', 114) AND  CONVERT(DATETIME,'" + HorarioFinal + "', 114) ) AND ATIVO=1";
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public SqlDataReader VerificarIngresso()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SELECT V.ID_VENDA, TB_ITEM_VENDA.ID_EI FROM TB_VENDA_INGRESSO V INNER JOIN  TB_ITEM_VENDA ON TB_ITEM_VENDA.ID_VENDA= V.ID_VENDA INNER JOIN TB_EVENTO_INGRESSO ON TB_EVENTO_INGRESSO.ID_EI= TB_ITEM_VENDA.ID_EI WHERE V.SITUACAO!='Cancelado' AND TB_EVENTO_INGRESSO.ID_EVENTO=" + _ID_EVENTO;
                return c.RetornarDataReader(SQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ListarID_e_TITULO(string texto)
        {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;

            comando = "SELECT ID_EVENTO,TITULO FROM TB_EVENTO WHERE DATA_EVENTO=CONVERT(DATETIME,'" + texto + "', 103) AND ATIVO=1";
            return c.RetornarDataSet(comando);


        }

        public DataSet ListarDIA(string texto, char op)
        {
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;
            switch (op)
            {
                case '0'://incluir
                    comando = "SELECT ID_EVENTO,TITULO, DATA_EVENTO, DESCRICAO, SUBSTRING(CAST(HORARIO_INICIO AS VARCHAR),10,5), SUBSTRING(CAST(HORARIO_FINAL AS VARCHAR),10,5),DURACAO, N_ARTISTAS,TIPO_PAG, ATIVO,VALOR_EVENTO FROM TB_EVENTO  WHERE DATA_EVENTO LIKE CONVERT(DATETIME,'" + texto + "', 103)AND ATIVO=1 ORDER BY HORARIO_INICIO";
                    break;
                case '1'://alterar
                    comando = "SELECT ID_EVENTO,TITULO, DATA_EVENTO, DESCRICAO, SUBSTRING(CAST(HORARIO_INICIO AS VARCHAR),10,5), SUBSTRING(CAST(HORARIO_FINAL AS VARCHAR),10,5),DURACAO, N_ARTISTAS,TIPO_PAG, ATIVO,VALOR_EVENTO FROM TB_EVENTO  WHERE DATA_EVENTO LIKE CONVERT(DATETIME,'" + texto + "', 103) AND ID_EVENTO != '" + _ID_EVENTO + "' AND ATIVO=1 ORDER BY HORARIO_INICIO";
                    break;

                default:
                    break;
            }

            return c.RetornarDataSet(comando);

        }


        public DataSet ListarGeral(string texto, int ativo, string tipo, int fID, int fNArt, string fTipoPag)
        {
            string Where = string.Empty;
            if (fNArt != 0)
            {
                Where = " WHERE EV.N_ARTISTAS= " + fNArt;
            }

            if (fTipoPag != string.Empty && fTipoPag != null)
            {
                if (Where == string.Empty)
                {
                    Where = "WHERE EV.TIPO_PAG= '" + fTipoPag + "' ";
                }
                else
                {
                    Where = Where + " AND EV.TIPO_PAG= '" + fTipoPag + "'";
                }
            }

            if (fID != 0)
            {
                if (Where == string.Empty)
                {
                    Where = "INNER JOIN TB_EVENTO_ARTISTA EVA ON EVA.ID_EVENTO = EV.ID_EVENTO INNER JOIN TB_PESSOA P ON P.ID_PESSOA= EVA.ID_PESSOA INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA  WHERE AG.ID_ARTISTA_GERAL= " + fID;
                }
                else
                {
                    Where = "INNER JOIN TB_EVENTO_ARTISTA EVA ON EVA.ID_EVENTO = EV.ID_EVENTO INNER JOIN TB_PESSOA P ON P.ID_PESSOA= EVA.ID_PESSOA INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA WHERE AG.ID_ARTISTA_GERAL=" + fID + " " + Where.Replace("WHERE", "AND");
                }
            }
            DAO.ClasseConexao c = new DAO.ClasseConexao();
            string comando = string.Empty;

            if (ativo == 2 && texto.Length == 0)
            {
                if (Where != string.Empty)
                {
                    comando = " SELECT EV.URL_IMG,EV.ID_EVENTO,EV.TITULO, EV.DATA_EVENTO, CONCAT( CONCAT(FORMAT(EV.HORARIO_INICIO,'HH:mm'), ' até ') , FORMAT(EV.HORARIO_FINAL,'HH:mm') ) as HORARIO, EV.DURACAO, EV.N_ARTISTAS,EV.DESCRICAO,EV.TIPO_PAG, EV.ATIVO, EV.VALOR_EVENTO FROM TB_EVENTO EV " + Where + " AND EV.DATA_EVENTO >= CONVERT(DATETIME,'" + _DataListarInicio.ToString().Substring(0, 10) + "', 103) AND EV.DATA_EVENTO <= CONVERT(DATETIME,'" + DataListarFinal.ToString().Substring(0, 10) + "', 103) ORDER BY EV.DATA_EVENTO";
                }
                else
                {
                    comando = " SELECT EV.URL_IMG,EV.ID_EVENTO,EV.TITULO, EV.DATA_EVENTO, CONCAT( CONCAT(FORMAT(EV.HORARIO_INICIO,'HH:mm'), ' até ') , FORMAT(EV.HORARIO_FINAL,'HH:mm') ) as HORARIO,EV.DURACAO, EV.N_ARTISTAS,EV.DESCRICAO,EV.TIPO_PAG, EV.ATIVO, EV.VALOR_EVENTO FROM TB_EVENTO EV WHERE EV.DATA_EVENTO >= CONVERT(DATETIME,'" + _DataListarInicio.ToString().Substring(0, 10) + "', 103) AND EV.DATA_EVENTO <= CONVERT(DATETIME,'" + DataListarFinal.ToString().Substring(0, 10) + "', 103) ORDER BY EV.DATA_EVENTO";
                }


                return c.RetornarDataSet(comando);
            }
            else if (ativo == 2 && texto.Length != 0)
            {
                if (Where != string.Empty)
                {
                    comando = " SELECT EV.URL_IMG,EV.ID_EVENTO,EV.TITULO, EV.DATA_EVENTO, CONCAT( CONCAT(FORMAT(EV.HORARIO_INICIO,'HH:mm'), ' até ') , FORMAT(EV.HORARIO_FINAL,'HH:mm') ) as HORARIO,EV.DURACAO, EV.N_ARTISTAS,EV.DESCRICAO,EV.TIPO_PAG, EV.ATIVO, EV.VALOR_EVENTO FROM TB_EVENTO EV " + Where + " AND EV.DATA_EVENTO >= CONVERT(DATETIME,'" + _DataListarInicio.ToString().Substring(0, 10) + "', 103) AND EV.DATA_EVENTO <= CONVERT(DATETIME,'" + DataListarFinal.ToString().Substring(0, 10) + "', 103) ORDER BY EV.DATA_EVENTO";
                }
                else
                {
                    comando = " SELECT EV.URL_IMG,EV.ID_EVENTO,EV.TITULO, EV.DATA_EVENTO, CONCAT( CONCAT(FORMAT(EV.HORARIO_INICIO,'HH:mm'), ' até ') , FORMAT(EV.HORARIO_FINAL,'HH:mm') ) as HORARIO,EV.DURACAO, EV.N_ARTISTAS,EV.DESCRICAO,EV.TIPO_PAG, EV.ATIVO, EV.VALOR_EVENTO FROM TB_EVENTO EV WHERE " + tipo + " LIKE '%" + texto + "%' AND EV.DATA_EVENTO >= CONVERT(DATETIME,'" + _DataListarInicio.ToString().Substring(0, 10) + "', 103) AND EV.DATA_EVENTO <= CONVERT(DATETIME,'" + DataListarFinal.ToString().Substring(0, 10) + "', 103) ORDER BY EV.DATA_EVENTO";

                }

                return c.RetornarDataSet(comando);
            }
            else
            {
                if (texto.Length == 0) // texto == null || texto == ""
                {
                    if (Where != string.Empty)
                    {
                        comando = "SELECT EV.URL_IMG,EV.ID_EVENTO,EV.TITULO, EV.DATA_EVENTO, CONCAT( CONCAT(FORMAT(EV.HORARIO_INICIO,'HH:mm'), ' até ') , FORMAT(EV.HORARIO_FINAL,'HH:mm') ) as HORARIO,EV.DURACAO, EV.N_ARTISTAS,EV.DESCRICAO,EV.TIPO_PAG, EV.ATIVO, EV.VALOR_EVENTO FROM TB_EVENTO EV " + Where + " AND EV.ATIVO=" + ativo + "  AND EV.DATA_EVENTO >= CONVERT(DATETIME,'" + _DataListarInicio.ToString().Substring(0, 10) + "', 103) AND EV.DATA_EVENTO <= CONVERT(DATETIME,'" + _DataListarFinal.ToString().Substring(0, 10) + "', 103) ORDER BY EV.DATA_EVENTO";
                    }
                    else
                    {
                        comando = "SELECT EV.URL_IMG,EV.ID_EVENTO,EV.TITULO, EV.DATA_EVENTO, CONCAT( CONCAT(FORMAT(EV.HORARIO_INICIO,'HH:mm'), ' até ') , FORMAT(EV.HORARIO_FINAL,'HH:mm') ) as HORARIO,EV.DURACAO, EV.N_ARTISTAS,EV.DESCRICAO,EV.TIPO_PAG, EV.ATIVO, EV.VALOR_EVENTO FROM TB_EVENTO EV  WHERE EV.ATIVO=" + ativo + " AND EV.DATA_EVENTO >= CONVERT(DATETIME,'" + _DataListarInicio.ToString().Substring(0, 10) + "', 103) AND EV.DATA_EVENTO <= CONVERT(DATETIME,'" + _DataListarFinal.ToString().Substring(0, 10) + "', 103) ORDER BY EV.DATA_EVENTO";
                    }

                    return c.RetornarDataSet(comando);
                }
                else
                {
                    if (Where != string.Empty)
                    {
                        comando = " SELECT EV.URL_IMG,EV.ID_EVENTO,EV.TITULO, EV.DATA_EVENTO, CONCAT( CONCAT(FORMAT(EV.HORARIO_INICIO,'HH:mm'), ' até ') , FORMAT(EV.HORARIO_FINAL,'HH:mm') ) as HORARIO,EV.DURACAO, EV.N_ARTISTAS,EV.DESCRICAO,EV.TIPO_PAG, EV.ATIVO, EV.VALOR_EVENTO FROM TB_EVENTO EV  " + Where + " AND EV.ATIVO = " + ativo + " AND EV.DATA_EVENTO >= CONVERT(DATETIME,'" + _DataListarInicio.ToString().Substring(0, 10) + "', 103) AND EV.DATA_EVENTO <= CONVERT(DATETIME,'" + DataListarFinal.ToString().Substring(0, 10) + "', 103) ORDER BY EV.DATA_EVENTO";
                    }
                    else
                    {
                        comando = " SELECT EV.URL_IMG,EV.ID_EVENTO,EV.TITULO, EV.DATA_EVENTO, CONCAT( CONCAT(FORMAT(EV.HORARIO_INICIO,'HH:mm'), ' até ') , FORMAT(EV.HORARIO_FINAL,'HH:mm') ) as HORARIO,EV.DURACAO, EV.N_ARTISTAS,EV.DESCRICAO,EV.TIPO_PAG, EV.ATIVO, EV.VALOR_EVENTO FROM TB_EVENTO EV WHERE " + tipo + " LIKE '%" + texto + "%' AND EV.ATIVO = " + ativo + " AND EV.DATA_EVENTO >= CONVERT(DATETIME,'" + _DataListarInicio.ToString().Substring(0, 10) + "', 103) AND EV.DATA_EVENTO <= CONVERT(DATETIME,'" + DataListarFinal.ToString().Substring(0, 10) + "', 103) ORDER BY EV.DATA_EVENTO";
                    }

                    return c.RetornarDataSet(comando);
                }
            }
        }


        public DataSet ListarArtistasDoEvento()
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();

                string comando = "    SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, RD.FACEBOOK, RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA  INNER JOIN TB_EVENTO_ARTISTA EA ON EA.ID_PESSOA = P.ID_PESSOA  WHERE EA.ID_EVENTO = '" + _ID_EVENTO + "' ORDER BY AG.ID_ARTISTA_GERAL ";

                return c.RetornarDataSet(comando);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public void Evento_crud(char opr)
        {
            try
            {
                DAO.ClasseConexao c = new DAO.ClasseConexao();
                SQL = "SP_EVENTO";
                List<SqlParameter> p = new List<SqlParameter>();
                p.Add(new SqlParameter("@ID_EVENTO", SqlDbType.Int) { Value = _ID_EVENTO });
                p.Add(new SqlParameter("@TITULO", SqlDbType.VarChar) { Value = _Titulo });
                p.Add(new SqlParameter("@DATA_EVENTO", SqlDbType.Date) { Value = _DataEvento });
                p.Add(new SqlParameter("@DESCRICAO", SqlDbType.VarChar) { Value = _Descricao });
                p.Add(new SqlParameter("@HORARIO_INICIO", SqlDbType.DateTime) { Value = _HorarioINICIO });
                p.Add(new SqlParameter("@HORARIO_FINAL", SqlDbType.DateTime) { Value = _HorarioFINAL });
                p.Add(new SqlParameter("@DURACAO", SqlDbType.VarChar) { Value = _Duracao });
                p.Add(new SqlParameter("@N_ARTISTAS", SqlDbType.Int) { Value = _N_ARTISTAS });
                p.Add(new SqlParameter("@TIPO_PAG", SqlDbType.VarChar) { Value = _Tipo_Pag });
                p.Add(new SqlParameter("@ATIVO", SqlDbType.Int) { Value = _Ativo });
                p.Add(new SqlParameter("@VALOR_EVENTO", SqlDbType.Float) { Value = _Valor_Evento });
                p.Add(new SqlParameter("@ID_ARTISTA_GERAL", SqlDbType.Int) { Value = _ID_ARTISTA_GERAL });
                p.Add(new SqlParameter("@URL_IMG", SqlDbType.VarChar) { Value = URL_IMG });
                p.Add(new SqlParameter("@OPR", SqlDbType.Char) { Value = opr });
                c.ExecutarStoredProcedureParametro(SQL, p.ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
