using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Sistema
{
    public partial class frmLoginNovo : Modelos.ModeloGeral
    {
        public frmLoginNovo()
        {
            InitializeComponent();
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                this.lblCapsLock.Visible = true;
                this.pbCapsLock.Visible = true;
            }
            else
            {
                this.lblCapsLock.Visible = false;
                this.pbCapsLock.Visible = false;
            }
        }

        int x, y;
        Point Point = new Point();




        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point = Control.MousePosition;
                Point.X -= x;
                Point.Y -= y;
                this.Location = Point;
                Application.DoEvents();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }






        private void Fontes(Object o, EventArgs e)
        {
            var a = txtUser;
            var b = txtSenha;
            var c = txtSenhaRedigitada;

            if (b.Text == String.Empty)
            {
                b.Font = new Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic & FontStyle.Underline);
                b.PasswordChar = '\0';
                b.Text = "Digite sua Senha";
                this.pbMostrarSenha.Image = Properties.Resources.AtivarIcone1;
                b.ForeColor = Color.LightGray;
            }



            if (a.Text == String.Empty)
            {
                a.Font = new Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic & FontStyle.Underline);
                a.ForeColor = Color.LightGray;
                a.Text = "Digite seu Usuário";
            }

            if (c.Text== String.Empty)
            {
                c.Font = new Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic & FontStyle.Underline);
                c.PasswordChar = '\0';
                c.ForeColor = Color.LightGray;
                c.Text = "Confirme a Senha";
                this.pbMostrarSenha2.Image = Properties.Resources.AtivarIcone1;
            }

        }
        private void Fontes(Object o, KeyPressEventArgs e)
        {
            var b = (TextBox)o;
            if (b.Focus())
            {
                if (b.Text == "Digite seu Usuário" || b.Text == "Digite sua Senha" || b.Text== "Confirme a Senha")
                {
                    b.ForeColor = Color.White;
                    b.Font = new Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular & FontStyle.Underline);
                    b.Text = String.Empty;
                    if (b.Name == "txtSenha" || b.Name=="txtSenhaRedigitada")
                    {
                       b.PasswordChar = '*';
                    }
                }

            }
        }

        private void pbMostrarSenha_DragOver(object sender, DragEventArgs e)
        {
            if (txtSenha.Text != String.Empty)
            {
                if (txtSenha.Text == "Digite sua Senha")
                {
                    txtSenha.PasswordChar = '\0';
                    return;
                }
                else
                {
                    if (txtSenha.PasswordChar == '*')//se visivel
                    {
                        this.pbMostrarSenha.Image = Properties.Resources.DesativarIcone2;
                        txtSenha.PasswordChar = '\0';

                    }
                    else
                    {
                        this.pbMostrarSenha.Image = Properties.Resources.AtivarIcone1;
                        txtSenha.PasswordChar = '*';
                    }

                }
            }
            else
            {

                txtSenha.PasswordChar = '\0';
            }
        }

        private void pbMostrarSenha_MouseUp(object sender, MouseEventArgs e)
        {

            if (txtSenha.Text != String.Empty)
            {
                if (txtSenha.Text == "Digite sua Senha")
                {
                    txtSenha.PasswordChar = '\0';
                    return;
                }
                else
                {
                    if (txtSenha.PasswordChar == '*')//se visivel
                    {
                        this.pbMostrarSenha.Image = Properties.Resources.DesativarIcone2;
                        txtSenha.PasswordChar = '\0';

                    }
                    else
                    {
                        this.pbMostrarSenha.Image = Properties.Resources.AtivarIcone1;
                        txtSenha.PasswordChar = '*';
                    }

                }
            }
            else
            {

                txtSenha.PasswordChar = '\0';
            }
        }



        private void pbMostrarSenha2_DragOver(object sender, DragEventArgs e)
        {
            if (txtSenhaRedigitada.Text != String.Empty)
            {
                if (txtSenhaRedigitada.Text == "Confirme a Senha")
                {
                    txtSenhaRedigitada.PasswordChar = '\0';
                    return;
                }
                else
                {
                    if (txtSenhaRedigitada.PasswordChar == '*')//se visivel
                    {
                        this.pbMostrarSenha2.Image = Properties.Resources.DesativarIcone2;
                        txtSenhaRedigitada.PasswordChar = '\0';

                    }
                    else
                    {
                        this.pbMostrarSenha2.Image = Properties.Resources.AtivarIcone1;
                        txtSenhaRedigitada.PasswordChar = '*';
                    }

                }
            }
            else
            {

                txtSenhaRedigitada.PasswordChar = '\0';
            }
        }

        private void pbMostrarSenha2_MouseUp(object sender, MouseEventArgs e)
        {

            if (txtSenhaRedigitada.Text != String.Empty)
            {
                if (txtSenhaRedigitada.Text == "Confirme a Senha")
                {
                    txtSenha.PasswordChar = '\0';
                    return;
                }
                else
                {
                    if (txtSenhaRedigitada.PasswordChar == '*')//se visivel
                    {
                        this.pbMostrarSenha2.Image = Properties.Resources.DesativarIcone2;
                        txtSenhaRedigitada.PasswordChar = '\0';

                    }
                    else
                    {
                        this.pbMostrarSenha2.Image = Properties.Resources.AtivarIcone1;
                        txtSenhaRedigitada.PasswordChar = '*';
                    }

                }
            }
            else
            {

                txtSenhaRedigitada.PasswordChar = '\0';
            }
        }

        private void CapsLock(object sender, KeyEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                this.lblCapsLock.Visible = true;
                this.pbCapsLock.Visible = true;
            }
            else
            {
                this.lblCapsLock.Visible = false;
                this.pbCapsLock.Visible = false;
            }
        }
        public bool VerificarSenha()
        {
            if ((this.txtSenha.Text.ToUpper().Trim() != this.txtSenhaRedigitada.Text.ToUpper().Trim()) || this.txtSenhaRedigitada.Text.Length == 0)
            {
                MessageBox.Show("A nova senha não coincide com a senha redigitada, ou nada foi digitado.");

                this.txtSenha.Text = string.Empty;
                this.pbMostrarSenha.Visible = false;
                this.txtSenhaRedigitada.Text = string.Empty;
                this.pbMostrarSenha2.Visible = false;
                this.txtSenhaRedigitada.Focus();
                return false;

            }
            return true;
        }

        public int IdNivelAcesso, IdFunc;
        public string NomeFunc;

        BLL.Login objLogin = new BLL.Login();
        private void Confirmar(object sender, EventArgs e)
        {

            try
            {
                if (this.txtUser.Text == "Digite seu Usuário")
                {
                    return;
                }
                this.erro.SetError(this.txtUser, string.Empty);
                BLL.Login medi = new BLL.Login();
                Oracle.DataAccess.Client.OracleDataReader dr;
                medi.Usuario = this.txtUser.Text;
                dr = medi.ConsultarUsuario("FUNCIONARIO");
                if (dr.Read())
                {

                    if (IdFunc.ToString() != dr["ID_FUNC"].ToString())
                    {
                        this.erro.SetError(this.txtUser, "O Usuário já está sendo utilizado!");

                        this.txtUser.Focus();
                        return;
                    }



                }



                if (VerificarSenha() == true)
                {
                    objLogin.IdLogin = codigo;
                    objLogin.Usuario = txtUser.Text.ToUpper().Trim();
                    objLogin.Senha = txtSenha.Text.ToUpper().Trim();
                    objLogin.IdNivelAcesso = IdNivelAcesso;
                    objLogin.Login_crud('N');

                    Hub h = new Hub();
                    MessageBox.Show("Operação realizada com sucesso!");
                    this.Hide();


                    h.NivelAcesso = IdNivelAcesso;

                    h.lblNomeTool.Text = NomeFunc;

                    h.tool_ID.Text = IdFunc.ToString();

                    h.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (this.txtSenha.Text != "Digite sua Senha")
            {
                pbMostrarSenha.Visible = true;
            }
            else
            {
                pbMostrarSenha.Visible = false;
            }
        }

        private void txtSenhaRedigitada_TextChanged(object sender, EventArgs e)
        {
            if (this.txtSenhaRedigitada.Text != "Confirme a Senha")
            {
                pbMostrarSenha2.Visible = true;
            }
            else
            {
                pbMostrarSenha2.Visible = false;
            }
        }

        private void Minimizar(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;


        }
        //////////////////////////////
    }
}
