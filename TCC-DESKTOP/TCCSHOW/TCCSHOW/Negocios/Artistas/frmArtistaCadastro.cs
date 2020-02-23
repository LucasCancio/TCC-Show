using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Artistas
{
    public partial class frmArtistaCadastro : Modelos.ModeloCadastroPadrao
    {
        public frmArtistaCadastro()
        {
            InitializeComponent();
           // this.cbPagamento.SelectedIndex = 0;
            this.cbSexo.SelectedIndex = 0;
            if (operacao==0)
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
            //this.Tabela.Enabled = false;
            //if (this.FormBorderStyle == FormBorderStyle.None)
            //{
            //    this.btnSalvar.Location = new Point(600, 748);
            //    this.pbSalvar.Location = new Point(608, 765);
            //}

        }

      
      
       
        String imageLocation = "";
        private void ProcurarImagem(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.pngg| All Files(*.*)|*.*";

                if (dialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                  
                    imageLocation = dialog.FileName;
                    
                    pbImagem.ImageLocation = imageLocation;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void RemoverImagem(object sender, EventArgs e)
        {
            this.pbImagem.Image = Properties.Resources.User3Icone;
            imageLocation = string.Empty;
        }


        ////////////////////
        public int IdAgente, IdEndereco, idRedesocial, idPessoa;
        public string Tipo_Art;

        private void LeaveMaisculo(object sender, EventArgs e)
        {
            var b = (TextBox)sender;
            b.Text = b.Text.ToUpper();
        }
        private void TextChangedValidar(object o, EventArgs e)
        {

            var b = (MaskedTextBox)o;
            switch (b.Name)
            {
                case "txtCPF":
                    this.erro.SetError(this.txtCPF, string.Empty);
                    if (this.txtCPF.MaskFull && chkArtista_Fixo.Checked)
                    {
                        ValidarCPF();
                    }
                    break;
          
            }
        }
        private void ClickValidar(object sender, EventArgs e)
        {
            var b = (PictureBox)sender;
            switch (b.Name)
            {
                case "btnValidarCPF":
                    erro.SetError(txtCPF, string.Empty);
                    ValidarCPF();
                    break;
                case "btnValidarEmail":

                    erro.SetError(txtEmail, string.Empty);
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
        public bool ValidarCPF()
        {
          
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
                    BLL.Artista medi = new BLL.Artista();
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    medi.CPF = this.txtCPF.Text;
                    dr = medi.ConsultarCPF();
                    if (dr.Read())
                    {
                        if (operacao != 0)
                        {
                            if (this.txtCodigo.Text == dr["ID_ARTISTA_GERAL"].ToString())
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

        private void MudarTel(object sender, EventArgs e)
        {
            this.txtTelefone.Text = string.Empty;
            if (this.chkTelFixo.Checked)
            {
                this.txtTelefone.Mask = "(00)0000 - 0000";
                this.lblTelefone.Text = "Telefone";

            }
            else
            {
                this.txtTelefone.Mask = "(00)90000 - 0000";
                this.lblTelefone.Text = "Celular";
            }
        }

        private void Limpar(object sender, EventArgs e)
        {
            try
            {
                this.chkAtivo.Checked = true;
                this.chkTelFixo.Checked = false;
                this.chkArtista_Fixo.Checked = false;
                this.chkDataArti.Checked = false;
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = string.Empty;
                    }
                }
                this.txtAgente.Text = string.Empty;
                this.cbEstado.Items.Clear();
                btnValidarCPF.Enabled =false;
                btnValidarEmail.Enabled = false;
                foreach (Control item in pageContato.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = string.Empty;
                        item.Enabled = false;
                    }
                }
                foreach (Control item in pageDocumentos.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = string.Empty;
                        item.Enabled = false;
                    }

                }
                foreach (Control item in pageResidencia.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = string.Empty;
                        item.Enabled = false;
                    }
                }
                foreach (Control item in gbRedeSocial.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = string.Empty;

                    }
                }
                this.nupNumeroCasa.Value = 0;
                this.erro.Clear();
                this.pbImagem.Image = Properties.Resources.User3Icone;
                imageLocation = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Salvar(object sender, EventArgs e)
        {
            //MessageBox.Show("Estado:" + Estado+ "Cidade:"+Cidade+ "Complemento:"+Complemento);
            //return;



            try
            {
                //MessageBox.Show(this.cbSexo.SelectionLength.ToString());
                //if (this.cbEstado2.SelectedItem.ToString() != String.Empty) { MessageBox.Show("Estado: " + cbEstado2.SelectedItem.ToString()); return; }
                //else { MessageBox.Show("Estado Vazio"); return; }


                if (this.txtNomeArti.Text == String.Empty)
                {
                    this.erro.SetError(this.txtNomeArti, "O nome é obrigatório");
                    this.txtNomeArti.Focus();
                    return;
                }
                else
                {
                    this.erro.SetError(this.txtNomeArti, String.Empty);
                }
                if (!this.chkArtista_Fixo.Checked)
                {

                    if (this.txtAgente.Text == String.Empty)
                    {
                        this.erro.SetError(this.txtAgente, "O Empresário é obrigatório");
                        this.txtAgente.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.txtAgente, String.Empty);
                    }

                }

          


                if (this.chkArtista_Fixo.Checked)
                {
                    if (this.txtTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "").Length < 11 && this.chkTelFixo.Checked == false)
                    {
                        this.erro.SetError(this.Tabela, "O número do celular é obrigatório");
                        this.txtTelefone.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.Tabela, String.Empty);
                    }
                    if (chkTelFixo.Checked == true && this.txtTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "").Length < 10)
                    {
                        this.erro.SetError(this.Tabela, "O número do telefone é obrigatório");
                        this.txtTelefone.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.Tabela, String.Empty);
                    }

                    if (ValidarCPF() == false )
                    {
                        this.Tabela.Focus();
                        this.pageDocumentos.Focus();
                        this.txtCPF.Focus();
                        btnValidarCPF.Image = Properties.Resources.ValidarIcone2;
                        return;
                    }
                    else
                    {
                        btnValidarCPF.Image = Properties.Resources.ValidarIcone1;
                    }

                    if (this.txtEmail.Text != string.Empty)
                    {
                        if (!validarEmail(this.txtEmail.Text))
                        {
                            this.erro.SetError(this.Tabela, "Email inválido!");
                            btnValidarEmail.Image = Properties.Resources.ValidarIcone2;
                            this.txtEmail.Focus();
                            return;
                        }
                        else
                        {
                            this.erro.SetError(this.Tabela, String.Empty);
                            btnValidarEmail.Image = Properties.Resources.ValidarIcone1;
                        }
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
                }

                if (nupNumeroCasa.Value <= 0) 
                {
                    this.erro.SetError(this.Tabela, "O Numero é obrigatório!");
                    return;
                }
                else
                {
                    this.erro.SetError(this.Tabela, string.Empty);
                }
                BLL.Artista func = new BLL.Artista();
                if (operacao!=0)
                {
                    if (!chkAtivo.Checked)
                    {
                        func.ID_ARTISTA_GERAL = codigo;
                        Oracle.DataAccess.Client.OracleDataReader dr;

                        dr = func.Verificar();
                        if (dr.Read())
                        {
                            MessageBox.Show("O artista está ativo em um evento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.chkAtivo.Checked = true;
                            return;
                        }
                    }
                    
                }
             
                //FIM DOS TRATAMENTOS DE ERROS



                if (MessageBox.Show("Deseja Salvar?", "ATENÇÃO ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; }
              
                BLL.Pessoa p = new BLL.Pessoa();
                BLL.CEP cep = new BLL.CEP();
                BLL.Log log = new BLL.Log();
                btnSalvar.Cursor = Cursors.AppStarting;
                func.Nome = this.txtNomeArti.Text.ToUpper().Trim();



                log.ID_FUNC = idFunc;
                log.ID_MODIFICADO = codigo;
                log.TABELA_LOG = "ARTISTAS";


                func.Telefone = txtTelefone.Text;

                
                    func.Facebook =  txtFacebook.Text;

                    func.Twitter =   txtTwitter.Text;
                             
                    func.INSTAGRAM = txtInstagram.Text;
                



                if (cbSexo.Text == String.Empty) { func.Sexo = ""; }
                else
                {

                    if (cbSexo.Text != String.Empty) { func.Sexo = cbSexo.Text.ToString().ToUpper().Trim(); }
                    else { func.Sexo = cbSexo.SelectedItem.ToString().ToUpper(); }
                }

                func.DataNasc = this.dtpDataNasc.Value.ToString().Substring(0, 10);

            
                func.DataDeCriacao = System.DateTime.Now;
                func.Ativo = 0;
                p.ATIVO = 0;
                func.ID_AGENTE = IdAgente;
                if (this.chkAtivo.Checked)
                {
                    func.Ativo = 1;
                    p.ATIVO = 1;
                }
                p.NOME = this.txtNomeArti.Text.ToString().ToUpper().Trim();
                if (this.chkDataArti.Checked)
                {
                    p.DATA_NASC =Convert.ToDateTime("01/01/0001 00:00:00");
                }
                else
                {
                    p.DATA_NASC = Convert.ToDateTime(this.dtpDataNasc.Value.ToString().Substring(0, 10));
                }
               
                p.SEXO = cbSexo.Text.ToString().ToUpper().Trim();
                if (chkArtista_Fixo.Checked)
                {
                    p.ID_TIPO_PESSOA = 4;
                    func.ID_TIPO_PESSOA = 4;
                }
                else
                {
                    p.ID_TIPO_PESSOA = 3;
                    func.ID_TIPO_PESSOA = 3;
                }
                func.ID_PESSOA = idPessoa;
                func.ID_ENDERECO = IdEndereco;
                func.URL_IMG = imageLocation;
                func.CPF = this.txtCPF.Text;
                func.Email = this.txtEmail.Text;
                func.Telefone = this.txtTelefone.Text;
                cep.Cep = this.txtCep.Text.Replace("-","");
                cep.NUMERO = Convert.ToInt32(this.nupNumeroCasa.Value);
                cep.Complemento = this.txtComplemento.Text;
                // MessageBox.Show("teste Salvar"+ operacao);
                switch (operacao)
                {
                    case 0: //inclusao
                       
                        
                        p.Pessoa_crud('I');
                        cep.Endereco_crud('I');
                        func.Artista_crud("I");

                        Oracle.DataAccess.Client.OracleDataReader dr;
                        dr = func.ConsultarValorMaximo();
                        log.TIPO_LOG = "INSERÇÃO";
                        if (dr.Read())
                        {
                            log.ID_MODIFICADO = Convert.ToInt32(dr["ID"]);
                        }
                        log.Log_crud('I');

                        break;
                    case 1: //alteracao
                        func.ID_ARTISTA_GERAL = codigo;

                        func.ID_REDESOCIAL = idRedesocial;
                        p.ID_PESSOA = idPessoa;
                        p.Pessoa_crud('A');
                        if (Tipo_Art=="ARTISTA-FIXO" & chkArtista_Fixo.Checked==false || Tipo_Art=="ARTISTA" & chkArtista_Fixo.Checked==true)
                        {
                            if (Tipo_Art == "ARTISTA" & chkArtista_Fixo.Checked == true)
                            {
                                cep.Endereco_crud('I');
                            }
                            func.Artista_crud("AN");
                        }
                        else
                        {
                            if (Tipo_Art=="ARTISTA-FIXO")
                            {
                                cep.ID_ENDERECO = IdEndereco;
                                cep.Endereco_crud('A');
                            }
                            func.Artista_crud("A");

                        }
                        log.TIPO_LOG = "ALTERAÇÃO";
                        log.Log_crud('A');
                        break;
                }



                btnSalvar.Cursor = Cursors.Hand;

                MessageBox.Show("Operação realizada com sucesso!");

                this.Dispose();

            
            }
            catch (Exception ex)
            {
                throw ex;

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
                }
               
                CarregarTableAgente();


                this.txtCodigo.Enabled = false;
                //MessageBox.Show("codigo; " + codigo);
                if (operacao != Convert.ToByte(BLL.Operacao.Inclusao))
                {
                   // this.chkArtista_Fixo.Enabled = false;
                    BLL.Artista medi = new BLL.Artista();
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    //Oracle.DataAccess.Client.OracleDataReader dr;
                    medi.ID_ARTISTA_GERAL = codigo;
                    if (Tipo_Art=="ARTISTA-FIXO")
                    {
                        dr = medi.ConsultarFIXO();
                    }
                    else
                    {
                        dr = medi.ConsultarNORMAL();
                    }
                    
                    // MessageBox.Show("teste CarregarCampo");
                    if (dr.Read())
                    {

                        this.txtCodigo.Text = Convert.ToString(codigo);
                        this.txtCodigo.Enabled = false;
                        this.txtNomeArti.Text = dr["NOME"].ToString();
                        if (dr["ATIVO"].ToString() == "1")
                        {
                            this.chkAtivo.Checked = true;
                        }
                        else
                        {
                            this.chkAtivo.Checked = false;
                        }

                        if (Convert.ToString(dr["DATA_NASC"]).IndexOf("01/01/0001")>=0)
                        {
                            this.dtpDataNasc.Enabled = false;
                            this.chkDataArti.Checked = true;
                        }
                        else
                        {
                            this.dtpDataNasc.Value = Convert.ToDateTime(dr["DATA_NASC"]);
                        }
                       
                        this.cbSexo.Text = dr["SEXO"].ToString();
                       
                
                       
                        this.txtFacebook.Text = dr["FACEBOOK"].ToString().Replace("Facebook.com/", "");
                        this.txtTwitter.Text = dr["TWITTER"].ToString().Replace("Twitter.com/", "");
                        this.txtInstagram.Text = dr["INSTAGRAM"].ToString().Replace("Instagram.com/", "");

                        //this.picImagem.ImageLocation = @dr["LOCALIMAGEMTURMA"].ToString();
                        if (Tipo_Art=="ARTISTA-FIXO")
                        {
                            this.chkArtista_Fixo.Checked = true;
                            this.btnProcurarAgente.Enabled = false;
                            this.pbProcurarAgente.Enabled = false;
                            this.txtCPF.Text = dr["CPF"].ToString();
                            if (dr["TELEFONE"].ToString().Replace(" ", "").Length == 14)
                            {
                                this.chkTelFixo.Checked = false;

                            }
                            else
                            {
                                this.chkTelFixo.Checked = true;

                            }
                            this.txtTelefone.Text = dr["TELEFONE"].ToString();
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
                        }
                        else
                        {
                            this.btnProcurarAgente.Enabled = true;
                            this.pbProcurarAgente.Enabled = true;
                            this.cbTipoPessoa.Text = dr["TIPO_PESSOA"].ToString();
                            this.txtAgente.Text= dr["NOME_PRINCIPAL"].ToString();
                            if (dr["TIPO_PESSOA"].ToString()=="FÍSICA")
                            {
                                this.txtCPF.Text = dr["DOCUMENTO"].ToString();
                            }
                            else
                            {
                                this.txtCNPJ.Text = dr["DOCUMENTO"].ToString();
                            }
                            this.txtTelefone.Text = dr["TELEFONE"].ToString();
                            this.chkTelFixo.Visible = false;
                           
                            this.txtEmail.Text = dr["EMAIL"].ToString();
                            if (this.txtEmail.Text!=string.Empty)
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
                            IdAgente = Convert.ToInt32(dr["ID_AGENTE"]);
                        }
                        
                        this.txtLogradouro.Text = dr["DESCRICAO"].ToString();
                        this.txtComplemento.Text = dr["COMPLEMENTO"].ToString();
                        this.txtTelefone.Text = dr["TELEFONE"].ToString();
                        this.txtCidade.Text = dr["CIDADE"].ToString();
                        this.txtBairro.Text = dr["BAIRRO"].ToString();
                        this.txtCep.Text = dr["CEP"].ToString();
                        this.nupNumeroCasa.Value = Convert.ToInt32(dr["NUMERO"]);
                        this.cbSexo.Text = dr["SEXO"].ToString();
                        this.cbEstado.Text = dr["UF"].ToString();
                        IdEndereco= Convert.ToInt32(dr["ID_ENDERECO"]);
                        idRedesocial = Convert.ToInt32(dr["ID_REDESOCIAL"]);
                        idPessoa= Convert.ToInt32(dr["ID_PESSOA"]);
                        this.imageLocation= dr["URL_IMG"].ToString().Trim();
                        if (imageLocation!=string.Empty)
                        {
                            this.pbImagem.ImageLocation = dr["URL_IMG"].ToString();
                        }
                        
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }



        private void CarregarTableAgente()
        {
            try
            {
                //this.erro.SetError(this.cbContato, String.Empty);

                //BLL.Contato cont = new BLL.Contato();

                //if (this.rbPJuridica.Checked)
                //{
                //    this.cbContato.DataSource = cont.ListarEmpresa("", 1, "CONTATO").Tables[0];
                //}
                //else
                //{
                //    this.cbContato.DataSource = cont.ListarEmpresario("", 1, "CONTATO").Tables[0];
                //}

                //this.cbContato.DisplayMember = "CONTATO";
                //this.cbContato.ValueMember = "ID_CONTATO_ART";
                //this.cbContato.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                //this.erro.SetError(this.cbContato, "Nenhum Contato cadastrado!");
                //MessageBox.Show(ex.Message);
                //this.cbContato.Focus();



            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)

            {

                e.Handled = true;

            }
           
        }

        private void chkHumor_Fixo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkArtista_Fixo.Checked && operacao != Convert.ToByte(BLL.Operacao.Consulta))//Artista Fixo
            {
               

                this.pbAgente.Image = Properties.Resources.PasswordIcone1;
                this.gbAgente.Enabled = false;

                if (operacao==0)
                {
                    this.txtFacebook.Text = "ComedyHouse";
                    this.txtInstagram.Text = "ComedyHouse";
                    this.txtTwitter.Text = "ComedyHouse";
                }
                
                this.txtFacebook.Enabled = false;
                this.txtInstagram.Enabled = false;
                this.txtTwitter.Enabled = false;
                this.Tabela.Enabled = true;
                this.btnProcurarCEP.Enabled = true;
                foreach (Control item in pageContato.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Enabled = true;
                        item.Text = string.Empty;
                    }
                    else if (item is CheckBox)
                    {
                        item.Enabled = true;
                      
                    }
                   
                }
                foreach (Control item in pageDocumentos.Controls)
                {
                    if (item is MaskedTextBox || item is PictureBox)
                    {
                        item.Enabled = true;
                        item.Text = string.Empty;
                    }
                }
                foreach (Control item in pageResidencia.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox || item is PictureBox || item is NumericUpDown || item is ComboBox)
                    {
                        item.Text = string.Empty;
                    }
                }
                this.txtCep.Enabled = true;
                this.txtComplemento.Enabled = true;
                this.nupNumeroCasa.Enabled = true;
                cbTipoPessoa.Text = "FÍSICA";
                this.nupNumeroCasa.Value = 0;
                txtCNPJ.Enabled = false;
                IdAgente = 0;
                txtAgente.Text = string.Empty;

                btnValidarCPF.Image = Properties.Resources.ValidarIcone;
                btnValidarEmail.Image = Properties.Resources.ValidarIcone;
                btnValidarCPF.Enabled = true;
                btnValidarEmail.Enabled = true;
                this.btnProcurarAgente.Enabled = false;
                this.pbProcurarAgente.Enabled = false;
            }
            else if(operacao != Convert.ToByte(BLL.Operacao.Consulta))// Artista
            {

                if (this.txtAgente.Text==string.Empty)
                {
                    this.Tabela.Enabled = false;
                }
             
                this.pbAgente.Image = Properties.Resources.EmpresaIcone;
                this.gbAgente.Enabled = true;

                this.txtFacebook.Text = string.Empty;
                this.txtInstagram.Text = string.Empty;
                this.txtTwitter.Text = string.Empty;
                this.txtFacebook.Enabled = true;
                this.txtInstagram.Enabled = true;
                this.txtTwitter.Enabled = true;
                this.btnProcurarCEP.Enabled = false;
                this.btnProcurarAgente.Enabled = true;
                this.pbProcurarAgente.Enabled = true;

                foreach (Control item in pageContato.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox || item is CheckBox)
                    {
                        item.Enabled = false;
                    }

                }
                foreach (Control item in pageDocumentos.Controls)
                {
                    if (item is MaskedTextBox || item is PictureBox || item is ComboBox)
                    {
                        item.Enabled = false;
                    }
                }
                foreach (Control item in pageResidencia.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox || item is PictureBox || item is NumericUpDown || item is ComboBox)
                    {
                        item.Enabled = false;
                    }
                }
                btnValidarCPF.Image = Properties.Resources.ValidarIcone1;
                btnValidarEmail.Image = Properties.Resources.ValidarIcone;
                btnValidarCPF.Enabled = false;
                btnValidarEmail.Enabled = false;
            }
            if (operacao==Convert.ToByte(BLL.Operacao.Consulta))
            {
                if (this.chkArtista_Fixo.Checked)
                {
                    lblChkArtF.Visible = true;
                }
            }
        }



        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCep.MaskFull && this.chkArtista_Fixo.Checked)
            {

                ValidarCEP();

            }
        }

        public void BuscarCep(object o, EventArgs e)
        {
            ValidarCEP();
        }

        private void chkDataArti_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkDataArti.Checked)
            {
                this.dtpDataNasc.Enabled = false;
                this.lblChkDataArt.Visible = true;
            }
            else
            {
                this.dtpDataNasc.Enabled = true;
                this.lblChkDataArt.Visible = false;
            }
        }

        public bool ValidarCEP()
        {
            Boolean retornar;
            retornar = false;
            txtCidade.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            cbEstado.Text = string.Empty;

            if (txtCep.Text.Trim().Replace(".", "").Replace("-", "") == string.Empty || !txtCep.MaskCompleted)
            {
                this.erro.SetError(this.txtCep, "O CEP não esta preenchido!");
                retornar = false;
                txtCidade.Text = string.Empty;
                txtBairro.Text = string.Empty;
                txtLogradouro.Text = string.Empty;
                cbEstado.SelectedItem = string.Empty;
                //this.txtCidade.Enabled = true;
                //this.txtBairro.Enabled = true;
                //this.txtLogradouro.Enabled = true;
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
               // Oracle.DataAccess.Client.OracleDataReader dr;
                dr = cp.Consultar();

                if (dr.Read())
                {
                    this.txtCep.Text = dr["CEP"].ToString();
                    this.txtLogradouro.Text = dr["DESCRICAO"].ToString();
                    this.txtCidade.Text = dr["CIDADE"].ToString();
                    this.txtBairro.Text = dr["BAIRRO"].ToString();
                    this.cbEstado.Text = dr["UF"].ToString();
                }

                if (txtCidade.Text == string.Empty || txtBairro.Text == string.Empty || txtLogradouro.Text.Trim().Replace(" ", "") == string.Empty)
                {
                    this.erro.SetError(this.txtCep, "CEP inválido!");
                    txtCidade.Text = string.Empty;
                    txtBairro.Text = string.Empty;
                    txtLogradouro.Text = string.Empty;
                    cbEstado.Text = string.Empty;

                    //this.txtCidade.Enabled = true;
                    //this.txtBairro.Enabled = true;
                    //this.txtLogradouro.Enabled = true;
                    //this.cbEstado.Enabled = true;
                    retornar = false;
                }
                else
                {
                    retornar = true;

                    this.txtCidade.Enabled = false;
                    this.txtBairro.Enabled = false;
                    this.txtLogradouro.Enabled = false;
                    this.cbEstado.Enabled = false;
                }

            }
            // MessageBox.Show("retornar:   " + retornar.ToString());
            return retornar;
        }

      

        private void ProcurarAgente(object sender, EventArgs e)
        {
            Negocios.Filtros.frmProcurarAgente f = new Negocios.Filtros.frmProcurarAgente();
            f.TopMost = true;
            f.idFunc = this.idFunc; f.ShowDialog();
            this.Tabela.Enabled=true;
            if (f.FormNome!=null)
            {
                txtAgente.Text = f.FormNome;
                IdAgente = f.FormIdAgente;

                cbTipoPessoa.Text = f.FormTipoPessoa;


                if (f.FormCPF!=null)
                {
                    if (f.FormCPF.ToString().Replace(" ", "") != string.Empty)
                    {
                        txtCPF.Text = f.FormCPF;
                        txtCNPJ.Enabled = false;
                        txtCNPJ.Text = string.Empty;

                    }
                }          
                else
                {
                    txtCNPJ.Text = f.FormCNPJ;
                    txtCPF.Enabled = false;
                    txtCPF.Text = string.Empty;

                }


                txtTelefone.Text = f.FormTelefone;
                txtEmail.Text = f.FormEmail;

                txtCep.Text = f.FormCep;
                cbEstado.Text = f.FormEstado;
                txtCidade.Text = f.FormCidade;
                txtBairro.Text = f.FormBairro;
                nupNumeroCasa.Value = f.FormNumeroCasa;
                txtComplemento.Text = f.FormComplemento;
                txtLogradouro.Text = f.FormLogradouro;

                this.erro.SetError(txtAgente, string.Empty);
            }
           




        }

        private void AdicionarAgente(object sender, EventArgs e)
        {
            Negocios.Agente.frmAgenteCadastro f = new Agente.frmAgenteCadastro();
            f.btnCancelar.Visible = true;
            f.pbCancelar.Visible = true;
            f.TopMost = true;
            f.FormBorderStyle = FormBorderStyle.FixedDialog;

            f.idFunc = this.idFunc; f.ShowDialog();
        }

        ///////////////////////////////////////////////////////////////
    }
}
