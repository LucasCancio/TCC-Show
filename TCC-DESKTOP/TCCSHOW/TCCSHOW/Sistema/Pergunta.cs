using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace TCCSHOW.Sistema
{
    public partial class Pergunta : Modelos.ModeloGeral
    {
        public Pergunta()
        {
            InitializeComponent();
        }


        BLL.Login objLogin = new BLL.Login();


        private void ValidarSenha(object sender, EventArgs e)
        {
            if (VerificarResposta() == true)
            {

                objLogin.IdLogin = codigo;
                if (Resposta == null)
                {
                    MessageBox.Show("Usuário não cadastrado!!");

                    this.Dispose();
                    return;
                }
                if (this.txtResposta.Text != Resposta.Trim())
                {
                    this.txtNovaRedigitada.Text = string.Empty;
                    this.txtNovaRedigitada.Text = string.Empty;
                    this.txtNovaRedigitada.Focus();
                    MessageBox.Show("Verifique a resposta da pergunta secreta.");

                    this.pbValidar.Image = Properties.Resources.ValidarIcone2;
                    this.lblValidar.ForeColor = Color.Red;
                    this.lblValidar.Text = "Incorreto";
                    return;
                }
                this.pbValidar.Image = Properties.Resources.ValidarIcone1;
                this.lblValidar.ForeColor = Color.Lime;
                this.lblValidar.Text = "Correto";
                this.txtResposta.Enabled = false;
                this.gbSenha.Enabled = true;
                this.btnSalvar.Enabled = true; this.pbSalvar.Enabled = true;

                this.txtSenha.Focus();
                this.btnSalvar.Enabled = true;
                this.pbSalvar.Enabled = true;
            }
        }
        public bool VerificarSenha()
        {
            if ((this.txtNovaRedigitada.Text.Trim() != this.txtNovaRedigitada.Text.Trim()) || this.txtNovaRedigitada.Text.Length == 0)
            {
                MessageBox.Show("A nova senha não coincide com a senha redigitada, ou nada foi digitado.");

                this.txtNovaRedigitada.Text = string.Empty;
                this.txtNovaRedigitada.Text = string.Empty;
                this.txtNovaRedigitada.Focus();
                return false;

            }
            return true;
        }
        private void Confirmar(Object o, EventArgs e)
        {
            try
            {
                if (VerificarSenha() == true)
                {
                    objLogin.IdLogin = codigo;
                    objLogin.Senha = txtSenha.Text.Trim();
                    objLogin.AlterarSenha("Login");

                    MessageBox.Show("Operação realizada com sucesso!");
                    this.Dispose();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool VerificarResposta()
        {
            if (this.txtResposta.Text.Length == 0)
            {
                MessageBox.Show("Digite a resposta");

                this.txtNovaRedigitada.Text = string.Empty;
                this.txtNovaRedigitada.Text = string.Empty;
                this.txtNovaRedigitada.Focus();
                return false;

            }
            return true;
        }

        public string Resposta;

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (this.txtSenha.Text != string.Empty)
            {
                this.txtNovaRedigitada.Enabled = true;
            }
        }

        private void txtResposta_TextChanged(object sender, EventArgs e)
        {
            if (this.txtResposta.Text == string.Empty)
            {
                this.pbValidar.Image = Properties.Resources.ValidarIcone;
                this.lblValidar.ForeColor = Color.White;
                this.lblValidar.Text = "Confirmar";
            }
        }

        private void BotaoEnter(object sender, KeyPressEventArgs k)
        {

            if (k.KeyChar == (char)13)
            {
                if (this.txtResposta.Enabled == true)
                {
                    if (VerificarResposta() == true)
                    {

                        objLogin.IdLogin = codigo;
                        if (Resposta == null)
                        {
                            MessageBox.Show("Usuário não cadastrado!!");

                            this.Dispose();
                            return;
                        }
                        if (this.txtResposta.Text != Resposta.Trim())
                        {
                            this.txtNovaRedigitada.Text = string.Empty;
                            this.txtNovaRedigitada.Text = string.Empty;
                            this.txtNovaRedigitada.Focus();
                            MessageBox.Show("Verifique a resposta da pergunta secreta.");

                            this.pbValidar.Image = Properties.Resources.ValidarIcone2;
                            this.lblValidar.ForeColor = Color.Red;
                            this.lblValidar.Text = "Incorreto";
                            return;
                        }
                        this.pbValidar.Image = Properties.Resources.ValidarIcone1;
                        this.lblValidar.ForeColor = Color.Lime;
                        this.lblValidar.Text = "Correto";
                        this.txtResposta.Enabled = false;
                        this.gbSenha.Enabled = true;
                        this.btnSalvar.Enabled = true; this.pbSalvar.Enabled = true;

                        this.txtSenha.Focus();
                    }
                   

                }
                else
                {
                    try
                    {
                        if (VerificarSenha() == true)
                        {
                            objLogin.IdLogin = codigo;
                            objLogin.Senha = txtSenha.Text.Trim();
                            objLogin.AlterarSenha("Login");

                            MessageBox.Show("Operação realizada com sucesso!");
                            this.Dispose();

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
