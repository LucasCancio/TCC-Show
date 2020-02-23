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
    public partial class Login : Form
    {
        private Int32 _codigo;

        public Int32 codigo
        { get { return _codigo; } set { _codigo = value; } }
        public Login()
        {
            InitializeComponent();
            this.txtUser.Focus();

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






        BLL.Login l = new BLL.Login();
        

        public int Tentativas;

        private void Cancelar(Object o, EventArgs e)
        {
            this.pnLogin.Enabled = true;
            this.Size = new Size(418, 437);
        }

        public bool Validar()
        {
            try
            {

                bool Check = false;

                Hub h = new Hub(); 
                l.Usuario = txtUser.Text.ToUpper().Trim();
                l.Senha = txtSenha.Text.Trim();
                h.Nome = txtUser.Text.ToUpper().Trim();
                Check = l.Logar();




                return Check;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //////////////////////////////////////////////////

        //////////////////////////////////////////////////


        private void Trocar(Object o, EventArgs e)
        {
            if (txtUser.Text != "Digite seu Usuario")
            {

                //}
                //else
                //{
                //    if (this.txtUser.Text.Length > 3)
                //    {
                BLL.Login objLogin = new BLL.Login();
                Pergunta f = new Pergunta();
                objLogin.Usuario = this.txtUser.Text.ToUpper().Trim();
                objLogin.RecuperarDadosTrocaSenha();
                codigo = objLogin.IdLogin;
                f.txtPergunta.Enabled = false;
                // f.txtPergunta.Text = objLogin.PerguntaSecreta;
                BLL.PerguntaSecreta perg = new BLL.PerguntaSecreta();
                perg.PerguntaSecretaId = objLogin.PerguntaSecretaId;
                var drr = perg.Consultar();
                if (drr.Read())
                {
                    f.txtPergunta.Text = drr.GetString(1);
                    f.Resposta = drr["RESPOSTA"].ToString();
                }
                else
                {
                    f.txtPergunta.Text = "NÃO HÁ PERGUNTA DEFINIDA";
                }
                f.codigo = codigo;
                f.ShowDialog();

            }
            else
            {
                MessageBox.Show("O nome do usuário deve estar " +
                    "preenchido para realizar a troca de senha.");
                this.txtSenha.Clear();
                TxtBoxs.Enabled = true;
                this.txtUser.Focus();
            }


        }


        public void Logar()
        {
            btnLogin.Cursor = Cursors.AppStarting;
            erro.SetError(this.txtUser, string.Empty);
            erro.SetError(this.txtSenha, string.Empty);
            if (txtUser.Text == "Digite seu Usuario" || txtSenha.Text == "Digite sua Senha")
            {

                txtSenha.Text = string.Empty;
                txtUser.Text = string.Empty;
                System.Windows.Forms.MessageBox.Show("Digite o usuario/senha", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                btnLogin.Cursor = Cursors.Hand;
            }
            else
            {

                try
                {

                    if (Validar() && Tentativas < 3)
                    {


                        Componentes.Loading load = new Componentes.Loading();

                        load.ShowDialog();

                        this.Hide();


                        Hub h = new Hub();

                        if (l.DataUltimoAcesso.ToString() == "01/01/0001 00:00:00")
                        {

                            frmLoginNovo lgnovo = new frmLoginNovo();
                            lgnovo.codigo = l.IdLogin;
                            lgnovo.IdNivelAcesso = l.IdNivelAcesso;
                            lgnovo.NomeFunc = l.Nome;
                            lgnovo.IdFunc = l.IdFunc;
                            lgnovo.Show();
                            return;

                        }


                        l.Login_crud('L');


                        h.NivelAcesso = l.IdNivelAcesso;

                        h.lblNomeTool.Text = l.Nome;

                        h.tool_ID.Text = l.IdFunc.ToString();

                        BLL.Log Log = new BLL.Log();
                        Log.ID_FUNC = l.IdFunc;
                        Log.TABELA_LOG = "FUNCIONÁRIOS";
                        Log.TIPO_LOG = "LOGON";
                        Log.Log_crud('L');

                        h.Show();





                    }
                    else
                    {
                        if (Tentativas > 5)
                        {
                            MessageBox.Show("Números de tentativas excedidas" + System.Environment.NewLine + "Tente novamente mais tarde!", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                            Application.Exit();
                        }
                        Tentativas = Tentativas + 1;
                        erro.SetError(this.txtUser, "Usuário/Senha Inválido(s)");
                        erro.SetError(this.txtSenha, "Usuário/Senha Inválido(s)");
                        btnLogin.Cursor = Cursors.Hand;
                        TxtBoxs.Enabled = true;
                        this.txtSenha.Clear();
                        this.txtUser.Focus();
                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //   throw;
                }
            }
        }
        private void SubinharCheck(Object o, MouseEventArgs e)
        {
            try
            {
                var b = (CheckBox)o;

                b.Font = new Font("Quicksand", 9F, System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Bold);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DesSubinharCheck(Object o, EventArgs e)
        {
            try
            {
                var b = (CheckBox)o;

                b.Font = new Font("Quicksand", 9F, System.Drawing.FontStyle.Bold);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SubinharLbl(Object o, MouseEventArgs e)
        {
            try
            {
                var b = (Label)o;

                b.Font = new Font("Quicksand Bold", 11.99F, System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Bold);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void DesSubinharLbl(Object o, EventArgs e)
        {
            try
            {
                var b = (Label)o;

                b.Font = new Font("Quicksand Bold", 11.99F, System.Drawing.FontStyle.Bold);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Fontes(Object o, EventArgs e)
        {
            var a = txtUser;
            var b = txtSenha;

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

        }
        private void Fontes(Object o, KeyPressEventArgs e)
        {
            var b = (TextBox)o;
            if (b.Focus())
            {
                if (b.Text == "Digite seu Usuário" || b.Text == "Digite sua Senha")
                {
                    b.ForeColor = Color.White;
                    b.Font = new Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular & FontStyle.Underline);
                    b.Text = String.Empty;
                    if (b.Name == "txtSenha")
                    {
                        txtSenha.PasswordChar = '*';
                    }
                }

            }
        }

        private void BotaoEnter(object sender, KeyPressEventArgs k)
        {

            if (k.KeyChar == (char)13 && this.pnLogin.Enabled == true)
            {
                Logar();
            }

        }

        private void AbrirLogin(object sender, EventArgs e)
        {
            Logar();
        }

        private void Sair(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar(object sender, EventArgs e)
        {


            this.WindowState = FormWindowState.Minimized;


        }

        private void AbrirSite(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://www.google.com.br");

            // System.Diagnostics.Process.Start("@");//COLOCAR URL AQUI
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void VisualizarSenha(object sender, EventArgs e)
        {
            //if (txtSenha.Text != String.Empty)
            //{
            //    if (txtSenha.Text == "Digite sua Senha") {
            //        txtSenha.PasswordChar = '\0';
            //        return;
            //    }
            //    else
            //    {
            //        if (txtSenha.PasswordChar == '*')//se visivel
            //        {
            //            this.pbMostrarSenha.Image = Properties.Resources.DesativarIcone2;
            //            txtSenha.PasswordChar = '\0';

            //        }
            //        else
            //        {
            //            this.pbMostrarSenha.Image = Properties.Resources.AtivarIcone1;
            //            txtSenha.PasswordChar = '*';
            //        }

            //    }
            //}
            //else
            //{

            //    txtSenha.PasswordChar = '\0';
            //}
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

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text != "Digite seu Usuário" && txtUser.Text != string.Empty)
            {
                this.lblEsqueceuSenha.Visible = true;
            }
            else
            {
                this.lblEsqueceuSenha.Visible = false;
            }
        }



    }
}
