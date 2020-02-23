using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boots.SemLogin
{
    public partial class CadastroOff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // this.vDateMaior18.ValueToCompare = DateTime.Now.AddYears(-18).ToString().Substring(0, 10);
           // this.vDateInvalid.ValueToCompare = DateTime.Now.AddYears(-100).ToString().Substring(0, 10);
        }

        private bool ValidarCPF()
        {
           // this.lblErro.Text = string.Empty;
            string texto = txtCPF.Text.Trim().Replace(".", "").Replace("-", "");
            Boolean retornar = true;
            if (texto.Length <= 10)
            {
                lblErro.Text = "O <b>CPF</b> não está preenchido!";
                pnErro.Visible = true; pnErro.Focus();
                retornar = false;
                // this.lblErro.Text = "O CPF não está completo!";
              

            }
            else
            {
                //this.txtCPF.Text = this.txtCPF.Text.Substring(0, 9) + "-" + txtCPF.Text.Substring(9, 2);
                if (!BLL.ValidadorCPF.CampoCPF(texto) ||
                    txtCPF.Text == "111.111.111-11" ||
                    txtCPF.Text == "222.222.222-22" ||
                    txtCPF.Text == "333.333.333-33" ||
                    txtCPF.Text == "444.444.444-44" ||
                    txtCPF.Text == "555.555.555-55" ||
                    txtCPF.Text == "666.666.666-66" ||
                    txtCPF.Text == "777.777.777-77" ||
                    txtCPF.Text == "888.888.888-88" ||
                    txtCPF.Text == "999.999.999-99" ||
                    txtCPF.Text == "000.000.000-00")
                {
                    lblErro.Text = "<b>CPF</b> inválido!";
                    pnErro.Visible = true; pnErro.Focus();
                  

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


                        //   this.lblErro.Text = "O CPF ja está sendo utilizado!";
                        lblErro.Text = "O <b>CPF</b> já está sendo utilizado!";
                        pnErro.Visible = true; pnErro.Focus();
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

        private bool VerificarUsuario()
        {


            BLL.Login medi = new BLL.Login();
            System.Data.SqlClient.SqlDataReader dr;
            medi.Usuario = this.txtUsuario.Text;
            dr = medi.ConsultarUsuario("CLIENTE");
            if (dr.Read())
            {
                
                    
                lblErro.Text = "O <b>usúario</b> já está sendo utilizado!";
                pnErro.Visible = true; pnErro.Focus();
                return false;


            }
            else
            {
                return true;
            }

        }
        protected void btnSalvar_cad_Click(object sender, EventArgs e)
        {
            try
            {
                //this.lblErro.Text = string.Empty;
                pnErro.Visible = false;
              



                if (this.txtNome.Text == String.Empty)
                {
                    lblErro.Text = "O <b>nome</b> não foi preenchido!";
                    pnErro.Visible = true; pnErro.Focus();
                    return;
                }



                if (ValidarCPF() == false)
                {

                    return;
                }

                if (txtDataNasc.Text != string.Empty)
                {
                    if (Convert.ToDateTime(txtDataNasc.Text) > Convert.ToDateTime(DateTime.Now.AddYears(-18).ToString().Substring(0, 10)))
                    {
                        lblErro.Text = "É obrigatório ter no mínimo <b>18 anos</b>!";
                        pnErro.Visible = true; pnErro.Focus();
                        return;
                    }
                    else if (Convert.ToDateTime(txtDataNasc.Text) < Convert.ToDateTime(DateTime.Now.AddYears(-100).ToString().Substring(0, 10)))
                    {
                        lblErro.Text = "A <b>data de nascimento</b> está inválida!";
                        pnErro.Visible = true; pnErro.Focus();
                        return;
                    }
                }
                else
                {
                    lblErro.Text = "A <b>data de nascimento</b> não foi preenchida!";
                    pnErro.Visible = true; pnErro.Focus();
                    return;
                }


                if (this.txtUsuario.Text == String.Empty)
                {
                    lblErro.Text = "O <b>usuário</b> não foi preenchido!";
                    pnErro.Visible = true; pnErro.Focus();
                    return;
                }

                if (!VerificarUsuario())
                {
                    return;
                }
               

                if (this.txtPergunta.Text == String.Empty)
                {
                    lblErro.Text = "A <b>pergunta</b> não foi preenchida!";
                    pnErro.Visible = true; pnErro.Focus();
                    return;
                }


                if (this.txtResposta.Text == String.Empty)
                {
                    lblErro.Text = "A <b>resposta</b> não foi preenchida!";
                    pnErro.Visible = true; pnErro.Focus();
                    return;
                }


              


                if (this.txtEmail.Text != string.Empty && txtEmail.Text != "")
                {
                    if (!validarEmail(this.txtEmail.Text))
                    {
                        lblErro.Text = "<b>Email</b> inválido!";
                        pnErro.Visible = true; pnErro.Focus();
                        return;
                    }

                }


                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openMessageBox();", true);

            }
            catch (Exception ex)
            {

                lblErro.Text = "<b>Erro: </b>" + ex.Message + " <b>Favor contatar o gerente</b>!";
                pnErro.Visible = true; pnErro.Focus();
            }
        }

        protected void Salvar(object o, EventArgs e) {
            try
            {
                //this.lblErro.Text = string.Empty;
                pnErro.Visible = false;




                if (this.txtNome.Text == String.Empty)
                {
                    lblErro.Text = "O <b>nome</b> não foi preenchido!";
                    pnErro.Visible = true; pnErro.Focus();
                    return;
                }



                if (ValidarCPF() == false)
                {

                    return;
                }

                if (txtDataNasc.Text != string.Empty)
                {
                    if (Convert.ToDateTime(txtDataNasc.Text) > Convert.ToDateTime(DateTime.Now.AddYears(-18).ToString().Substring(0, 10)))
                    {
                        lblErro.Text = "É obrigatório ter no mínimo <b>18 anos</b>!";
                        pnErro.Visible = true; pnErro.Focus();
                        return;
                    }
                    else if (Convert.ToDateTime(txtDataNasc.Text) < Convert.ToDateTime(DateTime.Now.AddYears(-100).ToString().Substring(0, 10)))
                    {
                        lblErro.Text = "A <b>data de nascimento</b> está inválida!";
                        pnErro.Visible = true; pnErro.Focus();
                        return;
                    }
                }
                else
                {
                    lblErro.Text = "A <b>data de nascimento</b> não foi preenchida!";
                    pnErro.Visible = true; pnErro.Focus();
                    return;
                }


                if (this.txtUsuario.Text == String.Empty)
                {
                    lblErro.Text = "O <b>usuário</b> não foi preenchido!";
                    pnErro.Visible = true; pnErro.Focus();
                    return;
                }

                if (!VerificarUsuario())
                {
                    return;
                }


                if (this.txtPergunta.Text == String.Empty)
                {
                    lblErro.Text = "A <b>pergunta</b> não foi preenchida!";
                    pnErro.Visible = true; pnErro.Focus();
                    return;
                }


                if (this.txtResposta.Text == String.Empty)
                {
                    lblErro.Text = "A <b>resposta</b> não foi preenchida!";
                    pnErro.Visible = true; pnErro.Focus();
                    return;
                }





                if (this.txtEmail.Text != string.Empty && txtEmail.Text != "")
                {
                    if (!validarEmail(this.txtEmail.Text))
                    {
                        lblErro.Text = "<b>Email</b> inválido!";
                        pnErro.Visible = true; pnErro.Focus();
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
             

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);

            }
            catch (Exception ex)
            {

                lblErro.Text = "<b>Erro: </b>"+ex.Message+" <b>Favor contatar o gerente</b>!";
                pnErro.Visible = true; pnErro.Focus();
                
            }
        }
    }
}