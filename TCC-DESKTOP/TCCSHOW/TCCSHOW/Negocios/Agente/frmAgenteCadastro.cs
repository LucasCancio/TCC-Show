using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Agente
{
    public partial class frmAgenteCadastro : Modelos.ModeloCadastroPadrao
    {
        public frmAgenteCadastro()
        {
            InitializeComponent();
            if (operacao == 0)
            {
                this.gbCodigo.Visible = false;
                this.rbPFisica.Checked = true;


            }
            
        }
        public int IdAgente, IdEndereco, idRedesocial;
        public string Documento;
        private void Salvar(object sender, EventArgs e)
        {
          


            try
            {

                
                    if (rbPJuridica.Checked)
                    {
                        if (this.txtNomeFant.Text==string.Empty)
                        {
                            this.erro.SetError(this.txtNomeFant, "O nome fantasia é obrigatório");
                        this.txtNomeFant.Focus();
                        return;
                    }
                        else
                        {
                            this.erro.SetError(this.txtNomeFant, String.Empty);
                        }
                  
                    }
                    else
                    {
                        if (this.txtNomeCivil.Text==string.Empty)
                        {
                            this.erro.SetError(this.txtNomeCivil, "O nome civil é obrigatório");
                        this.txtNomeCivil.Focus();
                        return;
                        }
                        else
                        {
                            this.erro.SetError(this.txtNomeCivil, String.Empty);
                        }
                    
                    }
                  
                    
                
               

                if (rbPJuridica.Checked)
                {
                    if (this.txtRazaoSocial.Text == String.Empty )
                    {
                        this.erro.SetError(this.txtRazaoSocial, "A razão social da empresa é obrigatório");
                        this.txtRazaoSocial.Focus();
                        return;
                    }
                    else
                    {
                        this.erro.SetError(this.txtRazaoSocial, string.Empty);
                    }

                   
                }
              
                if (ValidarCPF() == false && rbPFisica.Checked)
                {
                    btnValidarCPF.Image = Properties.Resources.ValidarIcone2;
                    return;
                }
                else if (rbPFisica.Checked)
                {
                    btnValidarCPF.Image = Properties.Resources.ValidarIcone1;
                }


                if (ValidarCNPJ() == false && rbPJuridica.Checked)
                {
                    btnValidarCNPJ.Image = Properties.Resources.ValidarIcone2;
                    return;
                }
                else if (rbPJuridica.Checked)
                {
                    btnValidarCNPJ.Image = Properties.Resources.ValidarIcone1;

                }

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


                if (this.txtTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "").Length < 11 && this.chkTelFixo.Checked==false)
                {
                    this.erro.SetError(this.txtTelefone, "O número do celular é obrigatório");
                    this.txtTelefone.Focus();
                    return;
                }
                else
                {
                    this.erro.SetError(this.txtTelefone, String.Empty);
                }
                if(chkTelFixo.Checked==true && this.txtTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "").Length<10)
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
                    if (!ValidarCEP()) {
                        return;
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


                //FIM DOS TRATAMENTOS DE ERROS



                if (MessageBox.Show("Deseja Salvar?", "ATENÇÃO ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; } else { btnProcurarCEP.Enabled = true; }
                BLL.Empresario func = new BLL.Empresario();
                BLL.Log log = new BLL.Log();
                BLL.CEP c = new BLL.CEP();
                btnSalvar.Cursor = Cursors.AppStarting;
                if (rbPFisica.Checked)
                {
                    func.NomePrincipal = this.txtNomeCivil.Text.ToUpper().Trim();
                    if (txtNomeSocial.Text == string.Empty)
                    {
                        func.NomeSecundario = "";
                    }
                    else
                    {
                        func.NomeSecundario = this.txtNomeSocial.Text.ToUpper().Trim();
                    }
                }
                else
                {
                    func.NomePrincipal = this.txtNomeFant.Text.ToUpper().Trim();
                 
                    func.NomeSecundario = this.txtRazaoSocial.Text.ToUpper().Trim();
                    
                }
                log.ID_FUNC = idFunc;
                log.ID_MODIFICADO = codigo;
                log.TABELA_LOG = "EMPRESÁRIOS";
              


                c.Cep = txtCep.Text.Replace("-", "");

                if (txtComplemento.Text != string.Empty)
                {
                    c.Complemento = txtComplemento.Text;
                }
                else { c.Complemento = ""; }
                if (nupNumeroCasa.Value != 0)
                {
                    c.NUMERO = Convert.ToInt32(nupNumeroCasa.Value);
                }
                else { c.NUMERO = 0; }
              


                func.Telefone = this.txtTelefone.Text.Replace(" ", "");

                if (rbPJuridica.Checked)
                {
                    func.TipoPessoa = "Jurídica";
                    func.Documento = this.txtCNPJ.Text;
                }
                else
                {
                    func.TipoPessoa = "Física";
                    func.Documento = this.txtCPF.Text;
                }
                func.DataDeCriacao = System.DateTime.Now;
                func.Ativo = 0;

                if (txtEmail.Text == string.Empty)
                {
                    func.Email = "";
                }
                else
                {
                    func.Email = txtEmail.Text;
                }
                if (this.chkAtivo.Checked)
                {
                    func.Ativo = 1;
                }
               
                // MessageBox.Show("teste Salvar"+ operacao);
                switch (operacao)
                {
                    case 0: //inclusao

                        c.Endereco_crud('I');
                        func.Agente_crud('I');
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
                        func.ID_Agente = codigo;
                        c.ID_ENDERECO = this.IdEndereco;
                        c.Endereco_crud('A');
                        func.Agente_crud('A');
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
            this.Dispose();
        }

        private void LeaveMaisculo(object sender, EventArgs e)
        {
            var b = (TextBox)sender;
            b.Text = b.Text.ToUpper();
        }

        private void CarregarCampos(object sender, EventArgs e)
        {
            try
            {
                //if (this.FormBorderStyle == FormBorderStyle.None)
                //{
                //    this.btnSalvar.Location = new Point(568, 703);
                //    this.pbSalvar.Location = new Point(577 ,719);
                //}

                this.txtCodigo.Enabled = false;
                //MessageBox.Show("codigo; " + codigo);
                if (operacao != Convert.ToByte(BLL.Operacao.Inclusao))
                {
                    BLL.Empresario medi = new BLL.Empresario();
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    //Oracle.DataAccess.Client.OracleDataReader dr;
                    medi.ID_Agente = codigo;
                    dr = medi.ConsultarGeral();
                    // MessageBox.Show("teste CarregarCampo");DADE, TB_CEP.BAIRRO,TB_ENDERECO.NUMERO, TB_ENDERECO.COMPLEMENTO FROM TCCSHOW.TB_AGENTE INNER JOIN TCCSHOW.TB_ENDERECO ON TB_ENDERECO.ID_
                    if (dr.Read())
                    {
                        this.txtCodigo.Text = Convert.ToString(codigo);
                        this.txtCodigo.Enabled = false;
                        Documento = dr["DOCUMENTO"].ToString();
                        if (dr["TIPO_PESSOA"].ToString() == "FÍSICA")
                        {
                            this.rbPFisica.Checked = true;
                            this.txtCPF.Text = dr["DOCUMENTO"].ToString();
                            
                            ValidarCPF();
                            this.txtNomeCivil.Text = dr["NOME_PRINCIPAL"].ToString();
                            this.txtNomeSocial.Text = dr["NOME_SECUNDARIO"].ToString();
                        }
                        else
                        {
                            this.rbPJuridica.Checked = true;
                            this.txtCNPJ.Text = dr["DOCUMENTO"].ToString();
                            ValidarCNPJ();
                            this.txtCNPJ.Enabled = false;
                            
                            this.txtNomeFant.Text = dr["NOME_PRINCIPAL"].ToString();
                            this.txtRazaoSocial.Text = dr["NOME_SECUNDARIO"].ToString();
                        }
                      
                        if (dr["ATIVO"].ToString() == "1")
                        {
                            this.chkAtivo.Checked = true;
                        }
                        else
                        {
                            this.chkAtivo.Checked = false;
                        }
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

                        this.IdEndereco = Convert.ToInt32(dr["ID_ENDERECO"]);
                        this.txtCep.Text = dr["CEP"].ToString();
                        this.cbEstado.Text = dr["UF"].ToString();
                        this.txtCidade.Text = dr["CIDADE"].ToString();
                        this.txtBairro.Text = dr["BAIRRO"].ToString();
                        this.txtLogradouro.Text = dr["DESCRICAO"].ToString();
                        this.nupNumeroCasa.Value = Convert.ToInt32(dr["NUMERO"].ToString());
                        this.txtComplemento.Text = dr["COMPLEMENTO"].ToString();

                    }
                    this.gbContato.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }

        ///////////////////////////////////
        private void ChecarTipoPessoa(object sender, EventArgs e)
        {
            var b = (RadioButton)sender;
           

            this.btnValidarCPF.Image = Properties.Resources.ValidarIcone;
            this.btnValidarCNPJ.Image = Properties.Resources.ValidarIcone;
            this.erro.SetError(this.btnValidarCNPJ, "");
            this.erro.Clear();

            this.erro.SetError(this.btnValidarCPF, "");
            if (btnCancelar.Text != "Voltar")
            {
                switch (b.Name)
                {
                    case "rbPFisica":
                        this.pbJuridica.Image = Properties.Resources.ResidenciaIcone;
                        this.rbPJuridica.ForeColor = Color.White;
                        this.rbPFisica.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF00A0B0");
                        this.pbFisica.Image = Properties.Resources.UserIcone3;
                        this.gbFisica.Enabled = true;
                        this.gbJuridica.Enabled = false;
                     
                        break;
                    case "rbPJuridica":
                        this.pbFisica.Image = Properties.Resources.UserIcone;
                        this.rbPFisica.ForeColor = Color.White;
                        this.rbPJuridica.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF00A0B0");
                        this.pbJuridica.Image = Properties.Resources.ResidenciaIcone1;
             
                        this.gbFisica.Enabled = false;
                        this.gbJuridica.Enabled = true;

                      
                        break;
                }

            }

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

        //////////////////////////////////VALIDAR
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

        public bool ValidarCPF()
        {
            if (!this.rbPFisica.Checked)
            {
                return false;
            }
            string texto = txtCPF.Text.Trim().Replace(".", "").Replace("-", "");
            Boolean retornar = true;
            this.erro.SetError(this.txtCPF, string.Empty);
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
                    BLL.Empresario medi = new BLL.Empresario();
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    medi.Documento = this.txtCPF.Text;
                    dr = medi.ConsultarDocumento();
                    if (dr.Read())
                    {
                        if (operacao != 0)
                        {
                            if (this.txtCodigo.Text == dr["ID_AGENTE"].ToString())
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

        public bool ValidarCNPJ()
        {
            if (!this.rbPJuridica.Checked)
            {
                return false;
            }
            string texto = txtCNPJ.Text.Trim().Replace(".", "").Replace("-", "");
            this.erro.SetError(this.txtCNPJ, string.Empty);
            Boolean retornar = true;
            if (texto.Length == 0 || !txtCNPJ.MaskCompleted)
            {

                this.erro.SetError(this.txtCNPJ, "O CNPJ não está preenchido!");
                btnValidarCNPJ.Image = Properties.Resources.ValidarIcone2;
                retornar = false;

            }
            else
            {
                if (!BLL.ValidarIcone1rCNPJ.ValidarCNPJ(texto))
                {
                    this.erro.SetError(this.txtCNPJ, "CNPJ Inválido!");
                    btnValidarCNPJ.Image = Properties.Resources.ValidarIcone2;
                    this.txtCNPJ.Text = string.Empty;
                    this.txtCNPJ.Focus();
                    retornar = false;
                }
                else
                {
                    BLL.Empresario medi = new BLL.Empresario();
                    Oracle.DataAccess.Client.OracleDataReader dr;
                    medi.Documento = this.txtCNPJ.Text;
                    dr = medi.ConsultarDocumento();
                    if (dr.Read())
                    {
                        if (operacao != 0)
                        {
                            if (this.txtCodigo.Text == dr["ID_AGENTE"].ToString())
                            {
                                btnValidarCNPJ.Image = Properties.Resources.ValidarIcone1;
                            }
                            else
                            {
                                this.erro.SetError(this.txtCNPJ, "O CNPJ ja está sendo utilizado!");
                                btnValidarCNPJ.Image = Properties.Resources.ValidarIcone2;
                                this.txtCNPJ.Text = string.Empty;
                                this.txtCNPJ.Focus();
                                retornar = false;
                            }
                        }
                        else
                        {
                            this.erro.SetError(this.txtCPF, "O CNPJ ja está sendo utilizado!");
                            btnValidarCNPJ.Image = Properties.Resources.ValidarIcone2;
                            this.txtCNPJ.Text = string.Empty;
                            this.txtCNPJ.Focus();
                            retornar = false;
                        }

                    }
                    else
                    {
                        btnValidarCNPJ.Image = Properties.Resources.ValidarIcone1;
                    }
                }


            }
            return retornar;
        }

        private void TextChangedValidar(object o, EventArgs e)
        {
            var b = (MaskedTextBox)o;
            switch (b.Name)
            {
                case "txtCPF":

                    if (this.txtCPF.MaskFull && rbPFisica.Checked)
                    {
                        ValidarCPF();
                    }
                    break;
                case "txtCNPJ":

                    if (this.txtCNPJ.MaskFull && rbPJuridica.Checked)
                    {
                        ValidarCNPJ();
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
                case "btnValidarCNPJ":
                    erro.SetError(txtCNPJ, string.Empty);
                    ValidarCNPJ();
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
        ////////////////////////////////////////CEP
        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCep.MaskFull && operacao == 0)
            {

                ValidarCEP();

            }
        }

        private void Limpar(object sender, EventArgs e)
        {
            try
            {
                this.chkAtivo.Checked = true;
                this.chkTelFixo.Checked = false;
                foreach (Control item in gbContato.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = string.Empty;
                    }
                }
                foreach (Control item in gbFisica.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = string.Empty;
                    }
                }
                foreach (Control item in gbJuridica.Controls)
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
                this.nupNumeroCasa.Value = 0;
                this.btnValidarCPF.Image = Properties.Resources.ValidarIcone;
                this.btnValidarCNPJ.Image= Properties.Resources.ValidarIcone;
                this.btnValidarEmail.Image= Properties.Resources.ValidarIcone;
                this.erro.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty)
            {
                this.erro.SetError(txtEmail, string.Empty);
                this.btnValidarEmail.Image = Properties.Resources.ValidarIcone;
            }
        }

        public void BuscarCep(object o, EventArgs e)
        {
            ValidarCEP();
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
                //Oracle.DataAccess.Client.OracleDataReader dr;
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

        //////////////////////////////////////
    }
}
