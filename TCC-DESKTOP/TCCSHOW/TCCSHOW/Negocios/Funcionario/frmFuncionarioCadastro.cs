using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Funcionario
{
    public partial class frmFuncionarioCadastro : Modelos.ModeloCadastroPadrao
    {
        public frmFuncionarioCadastro()
        {
            InitializeComponent();

            cbSexo.SelectedIndex = 0;
            if (operacao == 0)
            {
                this.gbCodigo.Visible = false;
                this.chkAtivo.Checked = true;
                this.dtpDataNasc.MaxDate = System.DateTime.Now.AddYears(18);
                this.dtpDataNasc.MinDate = System.DateTime.Now.AddYears(-100);

            }
            else
            {
                this.dtpDataNasc.MaxDate = System.DateTime.Now.AddYears(100);
                this.dtpDataNasc.MinDate = System.DateTime.Now.AddYears(-200);
            }
        }
        public int FuncIdLogin;
        private void Limpar(object sender, EventArgs e)
        {
            try
            {
                this.chkAtivo.Checked = true;
                this.chkTelFixo.Checked = false;
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = string.Empty;
                    }
                }
                foreach (Control item in gbCep.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = string.Empty;
                    }
                }
                foreach (Control item in gbCodigo.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = string.Empty;
                    }
                }
                foreach (Control item in  gbContato.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = string.Empty;
                    }
                }
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = string.Empty;
                    }
                }
                this.nupNumeroCasa.Value = 0;
                this.erro.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void MudarTel(object sender, EventArgs e)
        {
            this.txtTelefone.Text = string.Empty;
            if (this.chkTelFixo.Checked)
            {
                this.txtTelefone.Mask = "(00)0000-0000";
                this.lblTelefone.Text = "Telefone";

            }
            else
            {
                this.txtTelefone.Mask = "(00)90000-0000";
                this.lblTelefone.Text = "Celular";
            }
        }

        public int IdEndereco, IdPergunta, IdPessoa;
        private void Salvar(object sender, EventArgs e)
        {
           



            try
            {
                


                if (this.txtNomeFunc.Text == String.Empty)
                {
                    this.erro.SetError(this.txtNomeFunc, "O nome é obrigatório");
                    this.txtNomeFunc.Focus();
                    return;
                }
                else
                {
                    this.erro.SetError(this.txtNomeFunc, String.Empty);
                }



                if (ValidarCPF() == false)
                {
                    btnValidarCPF.Image = Properties.Resources.ValidarIcone2;
                    return;
                }
                else
                {
                    btnValidarCPF.Image = Properties.Resources.ValidarIcone1;
                }


                if (this.txtEmail.Text != string.Empty && txtEmail.Text!="")
                {
                    if (!validarEmail(this.txtEmail.Text))
                    {
                        this.erro.SetError(this.txtEmail, "Email inválido!");
                        btnValidarEmail.Image = Properties.Resources.ValidarIcone2;
                        this.txtEmail.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.txtEmail, String.Empty);
                        btnValidarEmail.Image = Properties.Resources.ValidarIcone1;
                    }
                }



                if (this.txtTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ","").Length < 11 && this.chkTelFixo.Checked == false)
                {
                    this.erro.SetError(this.txtTelefone, "O número do celular é obrigatório");
                    this.txtTelefone.Focus();
                    return;
                }
                else
                {
                    this.erro.SetError(this.txtTelefone, String.Empty);
                }
                if (chkTelFixo.Checked == true && this.txtTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "").Length < 10)
                {
                    this.erro.SetError(this.txtTelefone, "O número do telefone é obrigatório");
                    this.txtTelefone.Focus();
                    return;
                }
                else
                {
                    this.erro.SetError(this.txtTelefone, String.Empty);
                }

                if (!this.txtCep.MaskFull)
                {
                    this.erro.SetError(this.txtCep, "O número do CEP é obrigatório");
                    this.txtCep.Focus();
                    return;
                }
                else
                {
                    this.erro.SetError(this.txtCep, String.Empty);
                    if (!ValidarCEP())
                    {
                        return;
                    }
                }



                if (this.cbFuncao.Text.ToUpper() == "GERENTE" || this.cbFuncao.Text.ToUpper() == "ATENDENTE")
                {
                    if (this.txtUsuario.Text == string.Empty && operacao != 0)
                    {
                        this.erro.SetError(this.txtUsuario, "O nome do usuário é obrigatório");
                        this.txtUsuario.Focus();
                        return;
                    }
                    else {
                        this.erro.SetError(this.txtUsuario, string.Empty);
                    }


                   if (this.txtSenha.Text == string.Empty && operacao != 0)
                    {
                        this.erro.SetError(this.txtSenha, "A senha é obrigatória");
                        this.txtSenha.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.txtSenha, string.Empty);
                    }


                    if (this.txtPergunta.Text == string.Empty)
                    {
                        this.erro.SetError(this.lblPergunta, "A pergunta secreta é obrigatória");
                        this.txtPergunta.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.lblPergunta, string.Empty);

                    }


                    if (this.txtResposta.Text == string.Empty)
                    {
                        this.erro.SetError(this.lblResposta, "A resposta é obrigatória");
                        this.txtResposta.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.lblResposta, string.Empty);
                    }
                }

                if (nupNumeroCasa.Value == 0)
                {
                    this.erro.SetError(this.nupNumeroCasa, "O Numero é obrigatório!");
                    return;
                }
                else
                {
                    this.erro.SetError(this.nupNumeroCasa, string.Empty);
                }

                //if (operacao == 0 && cbFuncao.Text=="GERENTE" | cbFuncao.Text=="ATENDENTE")
                //{
                //    if (this.txtNomeFunc.Text.IndexOf(" ") > 0)
                //    {
                //        this.txtUsuario.Text = this.txtNomeFunc.Text.ToUpper().Substring(0, this.txtNomeFunc.Text.IndexOf(" ")) + "_1234";
                //    }
                //    else
                //    {
                //        this.txtUsuario.Text = this.txtNomeFunc.Text.ToUpper().Substring(0, this.txtNomeFunc.Text.Length) + "_1234";
                //    }

                //    this.txtSenha.Text = "1234";

                //}
                //FIM DOS TRATAMENTOS DE ERROS



                if (MessageBox.Show("Deseja Salvar?", "ATENÇÃO ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; } else { btnProcurarCEP.Enabled = true; }
                BLL.Funcionario func = new BLL.Funcionario();
                BLL.CEP c = new BLL.CEP();
                BLL.Log Log = new BLL.Log();
                BLL.Login log = new BLL.Login();
                BLL.Pessoa p = new BLL.Pessoa();
                BLL.PerguntaSecreta pg = new BLL.PerguntaSecreta();
                btnSalvar.Cursor = Cursors.AppStarting;
                func.Nome = this.txtNomeFunc.Text.ToUpper().Trim();


                Log.ID_FUNC = idFunc;
                Log.ID_MODIFICADO = codigo;
                Log.TABELA_LOG = "FUNCIONÁRIOS";


                switch (this.cbFuncao.Text.ToUpper())
                {
                    case "GERENTE":
                        log.IdNivelAcesso = 1;
                        break;
                    case "ATENDENTE":
                        log.IdNivelAcesso = 2;
                        break;
                }

                c.Cep = this.txtCep.Text.Replace("-", "");


                if (this.txtComplemento.Text != string.Empty)
                {
                    c.Complemento = txtComplemento.Text.ToUpper().Trim();
                }
                else { c.Complemento = ""; }
                if (nupNumeroCasa.Value != 0)
                {
                    c.NUMERO = Convert.ToInt32(nupNumeroCasa.Value);
                }
                else { c.NUMERO = 0; }

                func.CPF = this.txtCPF.Text;
                func.Telefone = this.txtTelefone.Text;


                func.IdFuncao= Convert.ToInt32(cbFuncao.SelectedValue);

                if (cbSexo.Text == String.Empty) { func.Sexo = ""; }
                else
                {

                    if (cbSexo.Text != String.Empty) { func.Sexo = cbSexo.Text.ToString().ToUpper().Trim(); }
                    else { func.Sexo = cbSexo.SelectedItem.ToString().ToUpper(); func.Sexo = cbSexo.SelectedItem.ToString().ToUpper(); }
                }

                func.DataNasc = this.dtpDataNasc.Value.ToString().Substring(0, 10);


                //func.DataDeContratacao = System.DateTime.Now.ToString().Substring(0, 10);
                func.Ativo = 0;
                p.ATIVO = 0;
                
                if (this.txtEmail.Text == string.Empty)
                {
                    func.Email = "";
                   
                }
                else
                {
                    func.Email = this.txtEmail.Text;
                    
                }

                if (this.chkAtivo.Checked)
                {
                    func.Ativo = 1;
                    p.ATIVO = 1;
                   
                }
                p.NOME = this.txtNomeFunc.Text.ToString().ToUpper().Trim();
                p.DATA_NASC = Convert.ToDateTime(this.dtpDataNasc.Value.ToString().Substring(0, 10));
                p.SEXO = cbSexo.Text.ToString().ToUpper().Trim();
                p.ID_TIPO_PESSOA = 1;

                c.ID_ENDERECO = IdEndereco;

                if (this.cbFuncao.Text.ToUpper() == "GERENTE" || this.cbFuncao.Text.ToUpper() == "ATENDENTE")
                {
                   
                    log.RespostaPerguntaSecreta = this.txtResposta.Text;
                    log.Usuario = txtUsuario.Text.ToUpper();
                    log.Senha = txtSenha.Text;
                    log.Descricao = txtPergunta.Text;
                    log.Ativo = 1;
                    log.PerguntaSecretaId = IdPergunta;
                    log.IdLogin = FuncIdLogin;/////
                    pg.PerguntaSecretaId = IdPergunta;
                    pg.Descricao = txtPergunta.Text;
                    pg.Resposta = txtResposta.Text;
                }
                func.IdPessoa = IdPessoa;
                func.IdEndereco = IdEndereco;


                // MessageBox.Show("teste Salvar"+ operacao);
                switch (operacao)
                {
                    case 0: //inclusao
                        
                        p.Pessoa_crud('I');
                        c.Endereco_crud('I');
                        if (this.cbFuncao.Text.ToUpper() == "GERENTE" || this.cbFuncao.Text.ToUpper() == "ATENDENTE")
                        {

                           log.Login_crud('I');                            
                        }
                        func.Funcionario_crud('I');
                        Oracle.DataAccess.Client.OracleDataReader dr;
                        dr = func.ConsultarValorMaximo();
                        Log.TIPO_LOG = "INSERÇÃO";
                        if (dr.Read())
                        {
                            Log.ID_MODIFICADO = Convert.ToInt32(dr["ID"]);
                        }
                        Log.Log_crud('I');

                        break;
                    case 1: //alteracao
                        func.IdFuncionario = codigo;
                        p.ID_PESSOA = IdPessoa;
                        p.Pessoa_crud('A');
                        c.ID_ENDERECO = IdEndereco;
                        
                        c.Endereco_crud('A');
                        if (this.cbFuncao.Text.ToUpper() == "GERENTE" || this.cbFuncao.Text.ToUpper() == "ATENDENTE")
                        {
                            log.IdLogin = FuncIdLogin;
                            log.Login_crud('A');
                        }
                        else
                        {
                            if (FuncIdLogin!=0)
                            {
                                
                                log.IdLogin = FuncIdLogin;
                                log.Login_crud('D');
                            }
                        }

                        func.Funcionario_crud('A');
                        Log.TIPO_LOG = "ALTERAÇÃO";
                        Log.Log_crud('A');
                        break;
                }



                btnSalvar.Cursor = Cursors.Hand;

                MessageBox.Show("Operação realizada com sucesso!");
                this.Dispose();

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);

            }
        }

        private void VerificarUsuario(object sender, EventArgs e)
        {
            
            this.erro.SetError(this.txtUsuario, string.Empty);
           
            BLL.Login medi = new BLL.Login();
            Oracle.DataAccess.Client.OracleDataReader dr;
            medi.Usuario = this.txtUsuario.Text;
            dr = medi.ConsultarUsuario("FUNCIONARIO");
            if (dr.Read())
            {
                if (operacao != 0)
                {
                    if (this.txtCodigo.Text != dr["ID_FUNC"].ToString())
                    {
                        this.erro.SetError(this.txtUsuario, "O Usuário já está sendo utilizado!");
                        this.txtUsuario.Text = string.Empty;
                        this.txtUsuario.Focus();
                    }

                }
                else
                {
                    this.erro.SetError(this.txtUsuario, "O Usuário já está sendo utilizado!");
                    this.txtUsuario.Text = string.Empty;
                    this.txtUsuario.Focus();

                }

            }

        }
        private void AbrirLogin(object sender, EventArgs e)
        {
            foreach (TextBox item in gbLogin.Controls.OfType<TextBox>())
            {
                item.Text = string.Empty;
            }
            if (this.cbFuncao.Text.ToUpper()=="GERENTE" || this.cbFuncao.Text.ToUpper()=="ATENDENTE")
            {
                this.gbLogin.Enabled = true;
                if (operacao == 5) {
                    this.txtUsuario.Enabled = false;
                    this.txtSenha.Enabled = false;
                }
                if (operacao==0)
                {
                    this.txtUsuario.Enabled = false;
                    this.txtSenha.Enabled = false;

                    if (this.txtCPF.MaskFull)
                    {
                       
                            txtUsuario.Text = txtCPF.Text.Replace("-", "");
                            txtSenha.Text = "1234";
                        

                    }
                }
                else if(operacao!=5)
                {
                    this.txtUsuario.Enabled = true;
                    this.txtSenha.Enabled = true;
                }
               
            }
            else if(operacao!=5)
            {
                this.txtUsuario.Enabled = true;
                this.txtSenha.Enabled = true;
                this.gbLogin.Enabled = false;

                this.erro.SetError(this.lblPergunta, string.Empty);
                this.erro.SetError(this.lblResposta, string.Empty);
                this.erro.SetError(this.txtUsuario, string.Empty);
                this.erro.SetError(this.txtSenha, string.Empty);
            }
        }

        //////////////////////////////////VALIDAR
        private void ClickValidar(object sender, EventArgs e)
        {
            var b = (PictureBox)sender;
            switch (b.Name)
            {
                case "btnValidarCPF":
                    ValidarCPF();
                    break;
                case "btnValidarEmail":


                    if (!validarEmail(this.txtEmail.Text))
                    {
                        this.erro.SetError(this.txtEmail, "Email inválido!");
                        btnValidarEmail.Image = Properties.Resources.ValidarIcone2;
                        this.txtEmail.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.txtEmail, String.Empty);
                        btnValidarEmail.Image = Properties.Resources.ValidarIcone1;
                    }

                    break;
            }
        }

        private bool ValidarCPF()
        {
            this.erro.SetError(this.txtCPF, string.Empty);
            string texto = txtCPF.Text.Trim().Replace(".", "").Replace("-", "");
            Boolean retornar = true;
            if (texto.Length == 0 || !txtCPF.MaskCompleted)
            {

                this.erro.SetError(this.txtCPF, "O CPF não está preenchido!");
                btnValidarCPF.Image = Properties.Resources.ValidarIcone2;
                retornar = false;

            }
            else
            {
                if (!BLL.ValidarIcone1rCPF.CampoCPF(texto) ||
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

                    this.erro.SetError(this.txtCPF, "CPF Inválido!");
                    btnValidarCPF.Image = Properties.Resources.ValidarIcone2;
                    this.txtCPF.Text = string.Empty;
                    this.txtCPF.Focus();
                    retornar = false;
                }
                else
                {
                    BLL.Funcionario medi = new BLL.Funcionario();
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    medi.CPF = this.txtCPF.Text;
                    dr = medi.ConsultarCPF();
                    if (dr.Read())
                    {
                        if (operacao!=0)
                        {
                            if (this.txtCodigo.Text== dr["ID_FUNC"].ToString())
                            {
                                btnValidarCPF.Image = Properties.Resources.ValidarIcone1;
                            }
                            else
                            {
                                this.erro.SetError(this.txtCPF, "O CPF ja está sendo utilizado!");
                                btnValidarCPF.Image = Properties.Resources.ValidarIcone2;
                                this.txtCPF.Text = string.Empty;
                                this.txtCPF.Focus();
                                retornar = false;
                            }
                        }
                        else
                        {
                            this.erro.SetError(this.txtCPF, "O CPF ja está sendo utilizado!");
                            btnValidarCPF.Image = Properties.Resources.ValidarIcone2;
                            this.txtCPF.Text = string.Empty;
                            this.txtCPF.Focus();
                            retornar = false;
                        }
                       
                    }
                    else
                    {
                        btnValidarCPF.Image = Properties.Resources.ValidarIcone1;

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
        ///////////////////////////////CEP
        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCep.MaskFull )
            {

                ValidarCEP();

            }
        }

        public void BuscarCep(object o, EventArgs e)
        {
            ValidarCEP();
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCPF.MaskFull)
            {
                if (ValidarCPF()) {
                    if (this.cbFuncao.Text.ToUpper() == "GERENTE" || this.cbFuncao.Text.ToUpper() == "ATENDENTE") {

                        if (txtUsuario.Text == string.Empty && txtSenha.Text == string.Empty)
                        {
                            txtUsuario.Text = txtCPF.Text.Replace("-", "");
                            txtSenha.Text = "1234";
                        }
                    }
                        
                   
                }
            }
            else
            {
                if (operacao==0)
                {
                    txtUsuario.Text = string.Empty;
                    txtSenha.Text = string.Empty;
                }
               
            }
        }

        private void CarregarCampos(object sender, EventArgs e)
        {

            try
            {
                if (operacao == 0)
                {
                    cbSexo.SelectedIndex = 0;

                    this.dtpDataNasc.MaxDate = DateTime.Now.AddYears(-18);
                    this.dtpDataNasc.MinDate = DateTime.Now.AddYears(-80);
                }
                else
                {
                    this.dtpDataNasc.MaxDate = DateTime.Now.AddYears(-18);
                    this.txtUsuario.Enabled = true;
                    this.txtSenha.Enabled = true;
                }
                CarregarCBFuncao();
                this.txtCodigo.Enabled = false;
                //MessageBox.Show("codigo; " + codigo);
                if (operacao != Convert.ToByte(BLL.Operacao.Inclusao))
                {

                    BLL.Funcionario medi = new BLL.Funcionario();
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    medi.IdFuncionario = codigo;
                    dr = medi.Consultar();
                    if (dr.Read())// COM LOGIN
                    {

                        this.txtCodigo.Text = Convert.ToString(codigo);
                        this.txtCodigo.Enabled = false;
                        this.txtNomeFunc.Text = dr["NOME"].ToString();
                        if (dr["ATIVO"].ToString() == "1")
                        {
                            this.chkAtivo.Checked = true;
                        }
                        else
                        {
                            this.chkAtivo.Checked = false;
                        }
                        this.cbSexo.Text = dr["SEXO"].ToString();
                        this.cbFuncao.Text = dr["FUNCAO"].ToString();
                        if (dr["TELEFONE"].ToString().Replace(" ", "").Length == 13)
                        {
                            this.chkTelFixo.Checked = true;
                        }
                        this.txtTelefone.Text = dr["TELEFONE"].ToString().Replace(" ", "");

                        this.txtCPF.Text = dr["CPF"].ToString();
                        this.txtEmail.Text = dr["EMAIL"].ToString();
                        if (this.txtEmail.Text != string.Empty)
                        {
                            if (!validarEmail(this.txtEmail.Text))
                            {
                                this.erro.SetError(this.txtEmail, "Email inválido!");
                                btnValidarEmail.Image = Properties.Resources.ValidarIcone2;
                                this.txtEmail.Focus();
                                return;
                            }
                            else
                            {
                                this.erro.SetError(this.txtEmail, String.Empty);
                                btnValidarEmail.Image = Properties.Resources.ValidarIcone1;
                            }
                        }
                        this.txtCep.Text = dr["CEP"].ToString();
                        this.nupNumeroCasa.Value = Convert.ToInt32(dr["NUMERO"].ToString());
                        this.txtComplemento.Text = dr["COMPLEMENTO"].ToString();

                        IdEndereco = Convert.ToInt32(dr["ID_ENDERECO"]);
                        FuncIdLogin = Convert.ToInt32(dr["ID_LOGIN"]);
                        IdPergunta = Convert.ToInt32(dr["ID_PERGUNTASECRETA"]);
                        IdPessoa = Convert.ToInt32(dr["ID_PESSOA"]);
                        this.cbFuncao.Text = dr["FUNCAO"].ToString();

                        if (this.cbFuncao.Text.ToUpper() == "GERENTE" || this.cbFuncao.Text.ToUpper() == "ATENDENTE")
                        {
                            txtUsuario.Text = dr["USUARIO"].ToString();
                            txtSenha.Text = dr["SENHA"].ToString();
                            txtPergunta.Text = dr["PERGUNTA"].ToString();
                            txtResposta.Text = dr["RESPOSTA"].ToString();
                        }
                        this.dtpDataNasc.Value = Convert.ToDateTime(dr["DATA_NASC"]);

                    }
                    else
                    {
                        dr = medi.Consultar2();
                        if (dr.Read())// SEM LOGIN
                        {

                            this.txtCodigo.Text = Convert.ToString(codigo);
                            this.txtCodigo.Enabled = false;
                            this.txtNomeFunc.Text = dr["NOME"].ToString();
                            if (dr["ATIVO"].ToString() == "1")
                            {
                                this.chkAtivo.Checked = true;
                            }
                            else
                            {
                                this.chkAtivo.Checked = false;
                            }

                            this.cbSexo.Text = dr["SEXO"].ToString();
                            this.cbFuncao.Text = dr["FUNCAO"].ToString();

                            this.txtTelefone.Text = dr["TELEFONE"].ToString();



                            this.txtCPF.Text = dr["CPF"].ToString();
                            this.txtEmail.Text = dr["EMAIL"].ToString();
                            if (this.txtEmail.Text != string.Empty)
                            {
                                if (!validarEmail(this.txtEmail.Text))
                                {
                                    this.erro.SetError(this.txtEmail, "Email inválido!");
                                    btnValidarEmail.Image = Properties.Resources.ValidarIcone2;
                                    this.txtEmail.Focus();
                                    return;
                                }
                                else
                                {
                                    this.erro.SetError(this.txtEmail, String.Empty);
                                    btnValidarEmail.Image = Properties.Resources.ValidarIcone1;
                                }
                            }
                            FuncIdLogin = 0;
                            this.txtCep.Text = dr["CEP"].ToString();
                            this.nupNumeroCasa.Value = Convert.ToInt32(dr["NUMERO"].ToString());
                            this.txtComplemento.Text = dr["COMPLEMENTO"].ToString();
                            IdEndereco = Convert.ToInt32(dr["ID_ENDERECO"]);
                            IdPessoa = Convert.ToInt32(dr["ID_PESSOA"]);
                            this.dtpDataNasc.Value = Convert.ToDateTime(dr["DATA_NASC"]);

                        }
                    }
                    //this.groupBox1.Focus();
                    ValidarCEP();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            this.txtUsuario.Text = this.txtUsuario.Text.ToUpper();
        }

        private void LeaveMaisculo(object sender, EventArgs e)
        {
            var b=(TextBox)sender;
            b.Text = b.Text.ToUpper();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text==string.Empty)
            {
                this.erro.SetError(txtEmail, string.Empty);
                this.btnValidarEmail.Image = Properties.Resources.ValidarIcone;
            }
        }

        private void CarregarCBFuncao()
        {
            try
            {
                this.erro.SetError(this.cbFuncao, String.Empty);

                BLL.Funcao cont = new BLL.Funcao();


                this.cbFuncao.DataSource = cont.ListarComboBox().Tables[0];
                this.cbFuncao.DisplayMember = "FUNCAO".ToLower();
                this.cbFuncao.ValueMember = "ID_FUNCAO";
                this.cbFuncao.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                this.erro.SetError(this.cbFuncao, "Nenhuma Função cadastrada!");
                MessageBox.Show(ex.Message);




            }
        }
        public bool ValidarCEP()
        {
            Boolean retornar;
            retornar = false;
            txtCidade.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            cbEstado.Text = string.Empty;

            if (txtCep.Text.Trim().Replace(".", "").Replace("-", "") == string.Empty || !txtCep.MaskCompleted)
            {
                this.erro.SetError(this.txtCep, "O CEP não esta preenchido!");
                retornar = false;
                txtCidade.Text = string.Empty;
                txtBairro.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                cbEstado.SelectedItem = string.Empty;
                //this.txtCidade.Enabled = true;
                //this.txtBairro.Enabled = true;
                //this.txtEndereco.Enabled = true;
                //this.cbEstado.Enabled = true;
            }

            else
            {
                erro.Clear();
                string Cep;
                BLL.CEP cp = new BLL.CEP();
                Cep = txtCep.Text.Replace("-", "").Trim();
                cp.Cep = Cep;
                Oracle.DataAccess.Client.OracleDataReader dr;
                dr = cp.Consultar();

                if (dr.Read())
                {
                    this.txtCep.Text = dr["CEP"].ToString();
                    this.txtEndereco.Text = dr["DESCRICAO"].ToString();
                    this.txtCidade.Text = dr["CIDADE"].ToString();
                    this.txtBairro.Text = dr["BAIRRO"].ToString();
                    this.cbEstado.Text = dr["UF"].ToString();
                }

                if (txtCidade.Text == string.Empty || txtBairro.Text == string.Empty || txtEndereco.Text.Trim().Replace(" ", "") == string.Empty)
                {
                    this.erro.SetError(this.txtCep, "CEP inválido!");
                    txtCidade.Text = string.Empty;
                    txtBairro.Text = string.Empty;
                    txtEndereco.Text = string.Empty;
                    cbEstado.Text = string.Empty;

                    //this.txtCidade.Enabled = true;
                    //this.txtBairro.Enabled = true;
                    //this.txtEndereco.Enabled = true;
                    //this.cbEstado.Enabled = true;
                    retornar = false;
                }
                else
                {
                    retornar = true;

                    this.txtCidade.Enabled = false;
                    this.txtBairro.Enabled = false;
                    this.txtEndereco.Enabled = false;
                    this.cbEstado.Enabled = false;
                }

            }
            // MessageBox.Show("retornar:   " + retornar.ToString());
            return retornar;
        }
        //////////////////////////////////////////////////////////////
    }
}
