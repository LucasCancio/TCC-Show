using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Cliente
{
    public partial class frmClienteCadastro : Modelos.ModeloCadastroPadrao
    {
        public frmClienteCadastro()
        {
            InitializeComponent();
            this.dtpHorarioFinal.MinDate = this.dtpHorarioInicio.Value;
            this.dtpHorarioInicio.MaxDate = this.dtpHorarioFinal.Value;

            this.dtpHorarioFinal.Value = Convert.ToDateTime(DateTime.Now.ToString().Substring(0, 10));
            this.dtpHorarioInicio.Value = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToString().Substring(0, 10));
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

        public int IdPessoa, IdLogin, IdPergunta;
        public bool cadastrado=false;

        private void MudarUsuario(object sender, EventArgs e)
        {
            if (this.txtNome.Text != string.Empty)
            {
                    if (this.txtNome.Text.IndexOf(" ") > 0)
                    {
                        this.txtUsuario.Text = this.txtNome.Text.ToUpper().Substring(0, this.txtNome.Text.IndexOf(" ")) + "_1234";
                    }
                    else
                    {
                        this.txtUsuario.Text = this.txtNome.Text.ToUpper().Substring(0, this.txtNome.Text.Length) + "_1234";
                    }

                    this.txtSenha.Text = "1234";

                

            }
            else if (operacao == 0)
            {
                this.txtUsuario.Text = string.Empty;
                this.txtSenha.Text = string.Empty;
            }
        }
        private void Limpar(object sender, EventArgs e)
        {
            try
            {
                this.chkAtivo.Checked = true;
                foreach (Control item in this.Controls)
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
                foreach (Control item in gbLogin.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = string.Empty;
                    }
                }
               
                
                this.erro.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Salvar(object sender, EventArgs e)
        {

            {




                try
                {


                    if (this.txtNome.Text == String.Empty)
                    {
                        this.erro.SetError(this.txtNome, "O Nome é obrigatório");
                        this.txtNome.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.txtNome, String.Empty);
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

                    if (this.txtUsuario.Text == String.Empty && operacao!=0)
                    {
                        this.erro.SetError(this.txtUsuario, "O usuario é obrigatório");
                        this.txtUsuario.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.txtUsuario, String.Empty);
                    }

                    if (this.txtPergunta.Text == String.Empty)
                    {
                        this.erro.SetError(this.lblPergunta, "A pergunta é obrigatória");
                        this.txtPergunta.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.lblPergunta, String.Empty);
                    }

                    if (this.txtResposta.Text == String.Empty)
                    {
                        this.erro.SetError(this.lblResposta, "A resposta é obrigatória");
                        this.txtResposta.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.lblResposta, String.Empty);
                    }

                    if (this.txtUsuario.Text == String.Empty)
                    {
                        this.erro.SetError(this.txtUsuario, "O Usuario é obrigatório");
                        this.txtUsuario.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.txtUsuario, String.Empty);
                    }

                    if (this.txtEmail.Text != string.Empty && txtEmail.Text != "")
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


                    //FIM DOS TRATAMENTOS DE ERROS



                    if (MessageBox.Show("Deseja Salvar?", "ATENÇÃO ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; }
                    BLL.Cliente c = new BLL.Cliente();
                    BLL.Pessoa p = new BLL.Pessoa();
                    BLL.Login log = new BLL.Login();
                    BLL.Log Log = new BLL.Log();
                    BLL.PerguntaSecreta pg = new BLL.PerguntaSecreta();
                    btnSalvar.Cursor = Cursors.AppStarting;
                    p.NOME = txtNome.Text.Trim();
                    c.CPF = this.txtCPF.Text;
                    p.DATA_NASC = Convert.ToDateTime(this.dtpDataNasc.Value.ToString().Substring(0, 10));
                    p.ID_TIPO_PESSOA = 2;
                    p.SEXO = cbSexo.Text;
                    c.Ativo = 0;
                    c.Email = this.txtEmail.Text;
                    p.ATIVO = 0;
                    if (this.chkAtivo.Checked)
                    {
                        c.Ativo = 1;
                        p.ATIVO = 1;
                    }
                    log.RespostaPerguntaSecreta = this.txtResposta.Text;
                    log.Usuario = txtUsuario.Text;
                    log.Senha = txtSenha.Text;
                    log.Descricao = txtPergunta.Text;
                    log.Ativo = 1;
                    log.PerguntaSecretaId = IdPergunta;
                    log.IdLogin = IdLogin;
                    log.IdNivelAcesso = 3;
                    pg.PerguntaSecretaId = IdPergunta;
                    pg.Descricao = txtPergunta.Text;
                    pg.Resposta = txtResposta.Text;

                    Log.ID_FUNC = idFunc;
                    Log.ID_MODIFICADO = codigo;
                    Log.TABELA_LOG = "CLIENTES";
                    switch (operacao)
                    {
                        case 0: //inclusao
                            p.Pessoa_crud('I');
                            log.Login_crud('I');
                            c.Cliente_crud('I');
                            Oracle.DataAccess.Client.OracleDataReader dr;
                            dr = c.ConsultarValorMaximo();
                            Log.TIPO_LOG = "INSERÇÃO";
                            if (dr.Read())
                            {
                                Log.ID_MODIFICADO = Convert.ToInt32(dr["ID"]);
                            }
                            Log.Log_crud('I');
                            cadastrado = true;
                            break;
                        case 1: //alteracao
                            c.ID_CLIENTE = codigo;
                            p.ID_PESSOA = IdPessoa;
                            log.IdLogin = IdLogin;
                            pg.PerguntaSecretaId = IdPergunta;
                            p.Pessoa_crud('A');
                            c.Cliente_crud('A');
                            log.Login_crud('A');
                            Log.TIPO_LOG = "ALTERAÇÃO";
                            Log.Log_crud('A');
                            break;
                    }

                  

                    btnSalvar.Cursor = Cursors.Hand;

                    MessageBox.Show("Operação realizada com sucesso!");


                    if (this.FormBorderStyle ==FormBorderStyle.FixedDialog)
                    {
                        this.Close();
                    }
                    else
                    {
                        this.Dispose();
                    }

                    
                }
                catch (Exception ex)
                {
                    throw ex;

                }
            }
        }

        private void CarregarCampos(object sender, EventArgs e)
        {

            try
            {
                if (operacao == 0)
                {
                    this.gbCodigo.Visible = false;
                    this.cbSexo.SelectedIndex = 0;

                    this.dtpDataNasc.MaxDate = DateTime.Now.AddYears(-18);
                    this.dtpDataNasc.MinDate = DateTime.Now.AddYears(-80);

                    this.gbHistorico.Visible = false;
                    this.pnCadastrar.Location = new Point(pnCadastrar.Location.X+230, pnCadastrar.Location.Y);
                }
                else
                {
                   // this.dtpDataNasc.MaxDate = DateTime.Now.AddYears(-18);
                    if (operacao==5)
                    {
                        this.txtUsuario.Enabled = false;
                        this.txtSenha.Enabled = false;
                    }
                    else
                    {
                        this.txtUsuario.Enabled = true;
                        this.txtSenha.Enabled = true;
                    }
                   
                    this.gbHistorico.Enabled = true;
                }
               

                this.txtCodigo.Enabled = false;
                //MessageBox.Show("codigo; " + codigo);
                if (operacao != Convert.ToByte(BLL.Operacao.Inclusao))
                {

                    BLL.Cliente medi = new BLL.Cliente();
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    medi.ID_CLIENTE = codigo;
                    dr = medi.Consultar();
                    if (dr.Read())
                    {
                        CarregarGrid();
                        this.txtCodigo.Text = Convert.ToString(codigo);
                        this.txtCodigo.Enabled = false;
                        this.txtNome.Text = dr["NOME"].ToString();
                        if (dr["ATIVO"].ToString() == "1")
                        {
                            this.chkAtivo.Checked = true;
                        }
                        else
                        {
                            this.chkAtivo.Checked = false;
                        }

                        this.cbSexo.Text = dr["SEXO"].ToString();
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
                        IdLogin = Convert.ToInt32(dr["ID_LOGIN"]);
                        IdPergunta = Convert.ToInt32(dr["ID_PERGUNTASECRETA"]);
                        IdPessoa = Convert.ToInt32(dr["ID_PESSOA"]);
                        txtUsuario.Text = dr["USUARIO"].ToString();
                        txtSenha.Text = dr["SENHA"].ToString();
                        txtPergunta.Text = dr["PERGUNTA"].ToString();
                        txtResposta.Text = dr["RESPOSTA"].ToString();
                        if (operacao != 5)
                        {
                            this.txtUsuario.Enabled = true;
                            this.txtSenha.Enabled = true;
                        }
                        
                        this.dtpDataNasc.Value = Convert.ToDateTime(dr["DATA_NASC"]);

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }
        private void ClickValidar(object sender, EventArgs e)
        {
            var b = (PictureBox)sender;
            switch (b.Name)
            {
                case "btnValidarCPF":
                    ValidarCPF();
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
                    BLL.Cliente medi = new BLL.Cliente();
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    medi.CPF = this.txtCPF.Text;
                    dr = medi.ConsultarCPF();
                    if (dr.Read())
                    {
                        if (operacao != 0)
                        {
                            if (this.txtCodigo.Text == dr["ID_CLIENTE"].ToString())
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

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCPF.MaskFull)
            {
                if(ValidarCPF()){
                    if (txtUsuario.Text == string.Empty && txtSenha.Text==string.Empty)
                    {
                        txtUsuario.Text = txtCPF.Text.Replace("-", "");
                        txtSenha.Text = "1234";
                    }
                }
            }
            else
            {
                if (operacao == 0)
                {
                    txtUsuario.Text = string.Empty;
                    txtSenha.Text = string.Empty;
                }
            }
        }
        private void CarregarGrid()
        {
            try
            {
                BLL.Cliente obj = new BLL.Cliente(); // <<<<<<<<<<<<<<<<
                if (this.operacao==0)
                {
                    return;
                }

                obj.ID_CLIENTE = codigo;
                obj.DataListarFinal = Convert.ToDateTime(this.dtpHorarioFinal.Value.ToString().Substring(0, 10));
                obj.DataListarInicio = Convert.ToDateTime(this.dtpHorarioInicio.Value.ToString().Substring(0, 10));
                DataTable dt = new DataTable();
               
                dt= obj.ListarHistorico().Tables[0];
                int total = dt.Rows.Count;
                int contagem=0;
                string[] DatadoEvento = new string[total];
                string[] DatadaVenda = new string[total];
                string[] Horario = new string[total];
                string[] Titulo = new string[total];
                string[] Assento = new string[total];
                string[] Situacao = new string[total];
                int[] CodEvento = new int[total];
                int[] CodVenda = new int[total];
                foreach (DataRow linha in dt.Rows)
                {
                    if (contagem!=total)
                    {
                        
                        DatadoEvento[contagem] = Convert.ToString(linha["DATA_EVENTO"].ToString().Substring(0,10));
                        DatadaVenda[contagem] = Convert.ToString(linha["DATAVENDA"].ToString().Substring(0, 16));
                        Horario[contagem] = Convert.ToString(linha["HORARIO"]);
                        Titulo[contagem] = Convert.ToString(linha["TITULO"]);
                        Assento[contagem] = Convert.ToString(linha["ASSENTO"]);
                        CodEvento[contagem] = Convert.ToInt32(linha["ID_EVENTO"]);
                        CodVenda[contagem] = Convert.ToInt32(linha["ID_VENDA"]);
                        Situacao[contagem] = Convert.ToString(linha["SITUACAO"]);
                        if (contagem != 0)
                        {
                            if (CodVenda[contagem] == CodVenda[contagem - 1])
                            {
                                DatadoEvento[contagem - 1] = string.Empty;
                                DatadaVenda[contagem - 1] = string.Empty;
                                Horario[contagem - 1] = string.Empty;
                                CodVenda[contagem - 1] = 0;
                                Titulo[contagem - 1] = string.Empty;
                                Situacao[contagem - 1] = string.Empty;
                                CodEvento[contagem - 1] = 0;

                                Assento[contagem] = Assento[contagem - 1] +","+ Assento[contagem];

                                Assento[contagem - 1] = string.Empty;

                            }
                        }
                        contagem = contagem + 1;
                    }
                   
                }

                
                while (contagem!=0)
                {
    
                    if (CodVenda[contagem-1]!=0)
                    {
                        TreeNode rootNode = new TreeNode();
                        if (Situacao[contagem-1]=="Cancelado")
                        {
                             rootNode= tvHistorico.Nodes.Add("Dia " + DatadaVenda[contagem - 1] + "- Cancelado");
                        }
                        else
                        {
                            rootNode = tvHistorico.Nodes.Add("Dia " + DatadaVenda[contagem - 1]);
                        }
                        
                        rootNode.ImageIndex = 0;
                        rootNode.Tag = CodVenda[contagem - 1];


                        TreeNode statesEvento = rootNode.Nodes.Add("Evento:");
                        statesEvento.ImageIndex = 1;

                        TreeNode cData = statesEvento.Nodes.Add("Data: "+DatadoEvento[contagem - 1]);

                        TreeNode cHorario = statesEvento.Nodes.Add("Horario: "+Horario[contagem - 1]);

                        TreeNode cTitulo = statesEvento.Nodes.Add("Titulo: " + Titulo[contagem - 1]);
                       

                        TreeNode statesAssento = rootNode.Nodes.Add("Assento(s):");
                        statesAssento.ImageIndex = 2;
                        TreeNode cAssento;
                        if (Assento[contagem - 1].IndexOf(",") > 0)
                        {
                            cAssento = statesAssento.Nodes.Add(Assento[contagem - 1].Substring(0, Assento[contagem - 1].IndexOf(",")));
                            while (Assento[contagem - 1].IndexOf(",") > 0)
                            {                             
                                Assento[contagem - 1] = Assento[contagem - 1].Substring(Assento[contagem - 1].IndexOf(",") + 1, Assento[contagem - 1].Length - Assento[contagem - 1].IndexOf(",") - 1);
                                if (Assento[contagem - 1].IndexOf(",") == -1)
                                {
                                    cAssento = statesAssento.Nodes.Add(Assento[contagem - 1]);
                                }
                                else
                                {
                                    cAssento = statesAssento.Nodes.Add(Assento[contagem - 1].Substring(0, Assento[contagem - 1].IndexOf(",")));
                                }
                               
                            }
                        }
                        else
                        {
                            cAssento = statesAssento.Nodes.Add(Assento[contagem - 1]);
                        }
                        
                        
                        
                        
                        



                    }
                   
                    contagem = contagem - 1;
                }
                //this.dgvHistorico.DataSource = obj.ListarHistorico().Tables[0];
                DataView view = new DataView(dt);
                //this.tvHistorico.DataSource = view;




                //this.dgvHistorico.Columns[0].HeaderText = "Data do Evento";
                //this.dgvHistorico.AutoResizeColumn(0);
                //this.dgvHistorico.Columns[1].HeaderText = "Horario";
                //this.dgvHistorico.AutoResizeColumn(1);
                //this.dgvHistorico.Columns[2].HeaderText = "Título";
                //this.dgvHistorico.AutoResizeColumn(2);
                //this.dgvHistorico.Columns[3].HeaderText = "Assento";
                //this.dgvHistorico.AutoResizeColumn(3);
                //this.dgvHistorico.Columns[4].HeaderText = "Cód Evento";
                //this.dgvHistorico.AutoResizeColumn(4);
                //this.dgvHistorico.Columns[5].HeaderText = "Cód Venda";
                //this.dgvHistorico.AutoResizeColumn(5);


              

             

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }

        
        private void dgvHistorico_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //if (this.dgvHistorico.Rows.Count < 1)
            //{
            //    this.btnConsultar.Enabled = false;
            //    this.pbConsultar.Enabled = false;
            //}
        }

        private void LeaveMaisculo(object sender, EventArgs e)
        {
            var b = (TextBox)sender;
            b.Text = b.Text.ToUpper();
        }
        private void VerificarUsuario(object sender, EventArgs e)
        {
           
            this.erro.SetError(this.txtUsuario, string.Empty);
            BLL.Login medi = new BLL.Login();
            Oracle.DataAccess.Client.OracleDataReader dr;
            medi.Usuario = this.txtUsuario.Text;
            dr = medi.ConsultarUsuario("CLIENTE");
            if (dr.Read())
            {
                if (operacao != 0)
                {
                    if (this.txtCodigo.Text != dr["ID_CLIENTE"].ToString())
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

        private void Exibir(object sender, EventArgs e)
        {
            this.dtpHorarioFinal.MinDate = this.dtpHorarioInicio.Value;
            this.dtpHorarioInicio.MaxDate = this.dtpHorarioFinal.Value;
            this.tvHistorico.Nodes.Clear();

            CarregarGrid();
        }

        private void btnValidarEmail_Click(object sender, EventArgs e)
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty)
            {
                this.erro.SetError(txtEmail, string.Empty);
                this.btnValidarEmail.Image = Properties.Resources.ValidarIcone;
            }
        }

        private void tvHistorico_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.tvHistorico.SelectedNode.Level != 0) {
                this.btnConsultar.Visible = false;
                this.pbConsultar.Visible = false;
            }
            else
            {
                this.btnConsultar.Visible = true;
                this.pbConsultar.Visible = true;
            }
        }

        private void tvHistorico_ControlAdded(object sender, ControlEventArgs e)
        {
            if (this.tvHistorico.Nodes.Count >= 1)
            {
                this.btnConsultar.Enabled = true;
                this.pbConsultar.Enabled = true;
            }
            else
            {
                this.btnConsultar.Enabled = false;
                this.pbConsultar.Enabled = false;
            }
        }

        
        private void AbrirFormulario(object sender, EventArgs e)
        {//INCLUIR ALTERAR CONSULTAR
            try
            {
                if (this.tvHistorico.SelectedNode==null) { return; }
                
                Negocios.Ingresso.frmIngresso f = new Negocios.Ingresso.frmIngresso
                {
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size,
                    idFunc = this.idFunc
                };
                f.MinimizeBox = true;
                f.Size = new Size(f.Width, f.Height + 30);
                f.StartPosition = FormStartPosition.CenterScreen;
                f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;

                if (sender == this.btnConsultar || sender == this.pbConsultar)
                {
                    f.gbCodigo.Visible = true;
                    f.codigo = Convert.ToInt32(this.tvHistorico.SelectedNode.Tag);
                    //f.Ativo = Convert.ToInt32(this.dgv.CurrentRow.Cells[4].Value);
                    f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);


                    f.txtCPF.Enabled = true;

                    f.txtCodigo.Enabled = true;






                    if (sender == this.btnConsultar || sender == this.pbConsultar)
                    {
                        f.txtCPF.Enabled = false;
                        f.btnImprimir.Visible = false;
                        f.pbImprimir.Visible = false;
                        f.gbImprimir.Visible = false;
                        

                        f.btnCancelar.Location = new Point(f.btnCancelar.Location.X + 180, f.btnCancelar.Location.Y);
                        f.pbCancelar.Location = new Point(f.pbCancelar.Location.X + 180, f.pbCancelar.Location.Y);

                        //f.txtNomeFunc.Enabled = false;
                        f.dtpDataNasc.Enabled = false;
                        f.txtCodigo.Enabled = false; f.txtCodigo.Visible=true;
                        f.dtpEvento.Enabled = false;
                        f.btnConsultarCli.Visible = false;
                        f.pbConsultarCli.Visible = false;
                        //f.cbSexo.Enabled = false;
                        f.IdCliente = 0;
                        //f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible = false; f.btnLimpar.Visible = false;


                        f.operacao = Convert.ToByte(BLL.Operacao.Consulta);

                    }
                }
                //var b = (Button)sender;
                //f.lblTitulo.Text =  b.Text;

                f.TopMost = true;
                f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                f.idFunc = this.idFunc; f.ShowDialog();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }


        //////////////////////////////////////////      
    }
}
