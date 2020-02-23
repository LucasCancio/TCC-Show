using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace TCC_Oficial.Telas.Cliente
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.vDateMaior18.ValueToCompare = DateTime.Now.AddYears(-18).ToString().Substring(0, 10);
            this.vDateInvalid.ValueToCompare = DateTime.Now.AddYears(-100).ToString().Substring(0, 10);
        }

        private bool ValidarCPF()
        {
            this.lblErro.Text = string.Empty;
            string texto = txtCPF.Text.Trim().Replace(".", "").Replace("-", "");
            Boolean retornar = true;
            if (texto.Length <= 10)
            {

                this.lblErro.Text = "O CPF não está completo!";
                retornar = false;

            }
            else
            {
                this.txtCPF.Text = this.txtCPF.Text.Substring(0, 9) + "-" + txtCPF.Text.Substring(9, 2);
                if (!BLL.ValidadorCPF.CampoCPF(texto) ||
                    txtCPF.Text == "111111111-11" ||
                    txtCPF.Text == "222222222-22" ||
                    txtCPF.Text == "333333333-33" ||
                    txtCPF.Text == "444444444-44" ||
                    txtCPF.Text == "555555555-55" ||
                    txtCPF.Text == "666666666-66" ||
                    txtCPF.Text == "777777777-77" ||
                    txtCPF.Text == "888888888-88" ||
                    txtCPF.Text == "999999999-99" ||
                    txtCPF.Text == "000000000-00")
                {
                    this.lblErro.Text = "CPF Inválido!";

                    this.txtCPF.Text = string.Empty;
                    this.txtCPF.Focus();
                    retornar = false;
                }
                else
                {
                    BLL.Cliente medi = new BLL.Cliente();
                    System.Data.SqlClient.SqlDataReader dr;

                    medi.CPF = this.txtCPF.Text;
                    dr = medi.ConsultarCPF();
                    if (dr.Read())
                    {


                        this.lblErro.Text = "O CPF ja está sendo utilizado!";

                        this.txtCPF.Text = string.Empty;
                        this.txtCPF.Focus();
                        retornar = false;


                    }

                }


            }
            return retornar;
        }

        public static bool validarEmail(string Email)
        {
            bool ValidEmail = false;
            int indexArr = Email.IndexOf("@");
            if (indexArr > 0)
            {
                int indexDot = Email.IndexOf(".", indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < Email.Length)
                    {
                        string indexDot2 = Email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            ValidEmail = true;
                        }
                    }
                }
            }
            return ValidEmail;
        }
        protected void btnSalvar_cad_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblErro.Text = string.Empty;

                if (Convert.ToDateTime(txtDataNasc.Text) > Convert.ToDateTime(DateTime.Now.AddYears(-18).ToString().Substring(0, 10)))
                {
                    return;
                }
                else if (Convert.ToDateTime(txtDataNasc.Text) < Convert.ToDateTime(DateTime.Now.AddYears(-100).ToString().Substring(0, 10)))
                {
                    return;
                }



                if (this.txtNome.Text == String.Empty)
                {
                    this.lblErro.Text = "O Nome é obrigatório";
                    this.txtNome.Focus();
                    return;
                }



                if (ValidarCPF() == false)
                {

                    return;
                }


                if (this.txtUsuario.Text == String.Empty)
                {
                    this.lblErro.Text = "O usuario é obrigatório";

                    this.txtUsuario.Focus();
                    return;
                }

                if (this.txtPergunta.Text == String.Empty)
                {
                    this.lblErro.Text = "A pergunta é obrigatória";

                    this.txtPergunta.Focus();
                    return;
                }


                if (this.txtResposta.Text == String.Empty)
                {
                    this.lblErro.Text = "A resposta é obrigatória";

                    this.txtResposta.Focus();
                    return;
                }


                if (this.txtUsuario.Text == String.Empty)
                {
                    this.lblErro.Text = "O Usuario é obrigatório";

                    this.txtUsuario.Focus();
                    return;
                }


                if (this.txtEmail.Text != string.Empty && txtEmail.Text != "")
                {
                    if (!validarEmail(this.txtEmail.Text))
                    {
                        this.lblErro.Text = "Email inválido!";
                        this.txtEmail.Focus();
                        return;
                    }

                }

                BLL.Cliente c = new BLL.Cliente();
                BLL.Pessoa p = new BLL.Pessoa();
                BLL.Login log = new BLL.Login();
                BLL.Log Log = new BLL.Log();
                BLL.PerguntaSecreta pg = new BLL.PerguntaSecreta();

                p.NOME = txtNome.Text.Trim();
                c.CPF = this.txtCPF.Text;
                p.DATA_NASC = Convert.ToDateTime(this.txtDataNasc.Text.ToString());
                p.ID_TIPO_PESSOA = 2;
                p.SEXO = cbSexo.Text;
                c.Ativo = 0;
                c.Email = this.txtEmail.Text;

                c.Ativo = 1;
                p.ATIVO = 1;

                log.RespostaPerguntaSecreta = this.txtResposta.Text;
                log.Usuario = txtUsuario.Text;
                log.Senha = txtSenha.Text;
                log.Descricao = txtPergunta.Text;
                log.Ativo = 1;
                
                log.IdNivelAcesso = 3;
               
                pg.Descricao = txtPergunta.Text;
                pg.Resposta = txtResposta.Text;

               
                Log.TABELA_LOG = "CLIENTES";

                p.Pessoa_crud('I');
                log.Login_crud('I');
                c.Cliente_crud('I');
                System.Data.SqlClient.SqlDataReader dr;
                dr = c.ConsultarValorMaximo();
                Log.TIPO_LOG = "INSERÇÃO";
                if (dr.Read())
                {
                    Log.ID_MODIFICADO = Convert.ToInt32(dr["ID"]);
                }
                Log.Log_crud('I');

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}