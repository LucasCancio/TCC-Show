namespace TCCSHOW.Negocios.Funcionario
{
    partial class frmFuncionarioCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarioCadastro));
            this.label10 = new System.Windows.Forms.Label();
            this.cbFuncao = new System.Windows.Forms.ComboBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.lblEstrelaNomeArtista = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.btnValidarCPF = new System.Windows.Forms.PictureBox();
            this.lblDataDeNasc = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblCPF2 = new System.Windows.Forms.Label();
            this.lblEstrelaCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnValidarEmail = new System.Windows.Forms.PictureBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.chkTelFixo = new System.Windows.Forms.CheckBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.gbCep = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nupNumeroCasa = new System.Windows.Forms.NumericUpDown();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.btnProcurarCEP = new System.Windows.Forms.PictureBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            this.gbCodigo.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnValidarCPF)).BeginInit();
            this.gbContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnValidarEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.gbCep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroCasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcurarCEP)).BeginInit();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSalvar
            // 
            this.pbSalvar.Location = new System.Drawing.Point(700, 848);
            this.pbSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(682, 833);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Size = new System.Drawing.Size(192, 69);
            this.btnSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // chkAtivo
            // 
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(276, 15);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(356, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(1088, 13);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox10.Size = new System.Drawing.Size(181, 130);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.ForeColor = System.Drawing.Color.Silver;
            this.lblTitulo2.Location = new System.Drawing.Point(694, 15);
            this.lblTitulo2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo2.Size = new System.Drawing.Size(378, 68);
            this.lblTitulo2.Text = "Funcionário";
            // 
            // pbCancelar
            // 
            this.pbCancelar.Location = new System.Drawing.Point(896, 848);
            this.pbCancelar.Margin = new System.Windows.Forms.Padding(5);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(884, 833);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Size = new System.Drawing.Size(192, 69);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(724, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // pbLimpar
            // 
            this.pbLimpar.Location = new System.Drawing.Point(492, 844);
            this.pbLimpar.Click += new System.EventHandler(this.Limpar);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(476, 833);
            this.btnLimpar.Size = new System.Drawing.Size(192, 69);
            this.btnLimpar.Click += new System.EventHandler(this.Limpar);
            // 
            // lblAtivo
            // 
            this.lblAtivo.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtivo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblAtivo.Location = new System.Drawing.Point(20, 21);
            this.lblAtivo.Size = new System.Drawing.Size(90, 34);
            this.lblAtivo.Text = "Ativo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Quicksand Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(256, 641);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 53);
            this.label10.TabIndex = 320;
            this.label10.Text = "Função";
            // 
            // cbFuncao
            // 
            this.cbFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncao.FormattingEnabled = true;
            this.cbFuncao.Location = new System.Drawing.Point(98, 707);
            this.cbFuncao.Margin = new System.Windows.Forms.Padding(4);
            this.cbFuncao.Name = "cbFuncao";
            this.cbFuncao.Size = new System.Drawing.Size(420, 44);
            this.cbFuncao.TabIndex = 319;
            this.cbFuncao.SelectedIndexChanged += new System.EventHandler(this.AbrirLogin);
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(1102, 258);
            this.dtpDataNasc.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataNasc.MaxDate = new System.DateTime(2017, 8, 31, 0, 0, 0, 0);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(259, 38);
            this.dtpDataNasc.TabIndex = 311;
            this.dtpDataNasc.Value = new System.DateTime(2017, 8, 31, 0, 0, 0, 0);
            // 
            // lblEstrelaNomeArtista
            // 
            this.lblEstrelaNomeArtista.BackColor = System.Drawing.Color.Transparent;
            this.lblEstrelaNomeArtista.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstrelaNomeArtista.ForeColor = System.Drawing.Color.Red;
            this.lblEstrelaNomeArtista.Location = new System.Drawing.Point(362, 197);
            this.lblEstrelaNomeArtista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstrelaNomeArtista.Name = "lblEstrelaNomeArtista";
            this.lblEstrelaNomeArtista.Size = new System.Drawing.Size(19, 23);
            this.lblEstrelaNomeArtista.TabIndex = 316;
            this.lblEstrelaNomeArtista.Text = "*";
            this.lblEstrelaNomeArtista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(170, 631);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 315;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(974, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 32);
            this.label5.TabIndex = 313;
            this.label5.Text = "Sexo";
            // 
            // cbSexo
            // 
            this.cbSexo.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "N.I",
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(1094, 193);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(266, 39);
            this.cbSexo.TabIndex = 310;
            // 
            // btnValidarCPF
            // 
            this.btnValidarCPF.BackColor = System.Drawing.Color.Transparent;
            this.btnValidarCPF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarCPF.Image = ((System.Drawing.Image)(resources.GetObject("btnValidarCPF.Image")));
            this.btnValidarCPF.Location = new System.Drawing.Point(651, 253);
            this.btnValidarCPF.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidarCPF.Name = "btnValidarCPF";
            this.btnValidarCPF.Size = new System.Drawing.Size(41, 40);
            this.btnValidarCPF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnValidarCPF.TabIndex = 318;
            this.btnValidarCPF.TabStop = false;
            this.btnValidarCPF.Click += new System.EventHandler(this.ClickValidar);
            // 
            // lblDataDeNasc
            // 
            this.lblDataDeNasc.AutoSize = true;
            this.lblDataDeNasc.BackColor = System.Drawing.Color.Transparent;
            this.lblDataDeNasc.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeNasc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDataDeNasc.Location = new System.Drawing.Point(774, 261);
            this.lblDataDeNasc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataDeNasc.Name = "lblDataDeNasc";
            this.lblDataDeNasc.Size = new System.Drawing.Size(298, 32);
            this.lblDataDeNasc.TabIndex = 312;
            this.lblDataDeNasc.Text = "Data de Nascimento";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFunc.Location = new System.Drawing.Point(406, 193);
            this.txtNomeFunc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeFunc.MaxLength = 50;
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(525, 38);
            this.txtNomeFunc.TabIndex = 306;
            this.txtNomeFunc.Leave += new System.EventHandler(this.LeaveMaisculo);
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFunc.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFunc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomeFunc.Location = new System.Drawing.Point(113, 193);
            this.lblNomeFunc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(245, 32);
            this.lblNomeFunc.TabIndex = 308;
            this.lblNomeFunc.Text = "Nome Completo";
            // 
            // lblCPF2
            // 
            this.lblCPF2.AutoSize = true;
            this.lblCPF2.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF2.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCPF2.Location = new System.Drawing.Point(282, 258);
            this.lblCPF2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF2.Name = "lblCPF2";
            this.lblCPF2.Size = new System.Drawing.Size(70, 32);
            this.lblCPF2.TabIndex = 314;
            this.lblCPF2.Text = "CPF";
            // 
            // lblEstrelaCPF
            // 
            this.lblEstrelaCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblEstrelaCPF.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstrelaCPF.ForeColor = System.Drawing.Color.Red;
            this.lblEstrelaCPF.Location = new System.Drawing.Point(362, 261);
            this.lblEstrelaCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstrelaCPF.Name = "lblEstrelaCPF";
            this.lblEstrelaCPF.Size = new System.Drawing.Size(20, 23);
            this.lblEstrelaCPF.TabIndex = 317;
            this.lblEstrelaCPF.Text = "*";
            this.lblEstrelaCPF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(404, 255);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Mask = "000000000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(213, 38);
            this.txtCPF.TabIndex = 307;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // gbContato
            // 
            this.gbContato.BackColor = System.Drawing.Color.Transparent;
            this.gbContato.Controls.Add(this.label1);
            this.gbContato.Controls.Add(this.txtEmail);
            this.gbContato.Controls.Add(this.label16);
            this.gbContato.Controls.Add(this.btnValidarEmail);
            this.gbContato.Controls.Add(this.lblTelefone);
            this.gbContato.Controls.Add(this.label15);
            this.gbContato.Controls.Add(this.txtTelefone);
            this.gbContato.Controls.Add(this.chkTelFixo);
            this.gbContato.Controls.Add(this.pictureBox7);
            this.gbContato.Location = new System.Drawing.Point(64, 315);
            this.gbContato.Margin = new System.Windows.Forms.Padding(4);
            this.gbContato.Name = "gbContato";
            this.gbContato.Padding = new System.Windows.Forms.Padding(4);
            this.gbContato.Size = new System.Drawing.Size(649, 258);
            this.gbContato.TabIndex = 327;
            this.gbContato.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 96;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(133, 94);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 120;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(420, 38);
            this.txtEmail.TabIndex = 88;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Quicksand Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(275, 21);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 46);
            this.label16.TabIndex = 175;
            this.label16.Text = "Contato";
            // 
            // btnValidarEmail
            // 
            this.btnValidarEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnValidarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnValidarEmail.Image")));
            this.btnValidarEmail.Location = new System.Drawing.Point(576, 92);
            this.btnValidarEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidarEmail.Name = "btnValidarEmail";
            this.btnValidarEmail.Size = new System.Drawing.Size(41, 40);
            this.btnValidarEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnValidarEmail.TabIndex = 98;
            this.btnValidarEmail.TabStop = false;
            this.btnValidarEmail.Click += new System.EventHandler(this.ClickValidar);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(108, 159);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(114, 32);
            this.lblTelefone.TabIndex = 92;
            this.lblTelefone.Text = "Celular";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(259, 162);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 23);
            this.label15.TabIndex = 93;
            this.label15.Text = "*";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(285, 156);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Mask = "(00)00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(257, 38);
            this.txtTelefone.TabIndex = 90;
            // 
            // chkTelFixo
            // 
            this.chkTelFixo.AutoSize = true;
            this.chkTelFixo.BackColor = System.Drawing.Color.Transparent;
            this.chkTelFixo.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTelFixo.ForeColor = System.Drawing.Color.White;
            this.chkTelFixo.Location = new System.Drawing.Point(279, 204);
            this.chkTelFixo.Margin = new System.Windows.Forms.Padding(4);
            this.chkTelFixo.Name = "chkTelFixo";
            this.chkTelFixo.Size = new System.Drawing.Size(225, 36);
            this.chkTelFixo.TabIndex = 97;
            this.chkTelFixo.Text = "Telefone Fixo";
            this.chkTelFixo.UseVisualStyleBackColor = false;
            this.chkTelFixo.CheckedChanged += new System.EventHandler(this.MudarTel);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(189, 16);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(89, 51);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // gbCep
            // 
            this.gbCep.BackColor = System.Drawing.Color.Transparent;
            this.gbCep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbCep.Controls.Add(this.label8);
            this.gbCep.Controls.Add(this.pictureBox3);
            this.gbCep.Controls.Add(this.label14);
            this.gbCep.Controls.Add(this.nupNumeroCasa);
            this.gbCep.Controls.Add(this.lblEstado);
            this.gbCep.Controls.Add(this.cbEstado);
            this.gbCep.Controls.Add(this.txtBairro);
            this.gbCep.Controls.Add(this.lblBairro);
            this.gbCep.Controls.Add(this.txtCidade);
            this.gbCep.Controls.Add(this.label13);
            this.gbCep.Controls.Add(this.txtComplemento);
            this.gbCep.Controls.Add(this.label11);
            this.gbCep.Controls.Add(this.lblEndereco);
            this.gbCep.Controls.Add(this.txtEndereco);
            this.gbCep.Controls.Add(this.label7);
            this.gbCep.Controls.Add(this.txtCep);
            this.gbCep.Controls.Add(this.btnProcurarCEP);
            this.gbCep.Location = new System.Drawing.Point(723, 315);
            this.gbCep.Margin = new System.Windows.Forms.Padding(4);
            this.gbCep.Name = "gbCep";
            this.gbCep.Padding = new System.Windows.Forms.Padding(4);
            this.gbCep.Size = new System.Drawing.Size(809, 256);
            this.gbCep.TabIndex = 176;
            this.gbCep.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(239, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 23);
            this.label8.TabIndex = 318;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(52, 14);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 176;
            this.pictureBox3.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(45, 213);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 32);
            this.label14.TabIndex = 173;
            this.label14.Text = "Nº";
            // 
            // nupNumeroCasa
            // 
            this.nupNumeroCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNumeroCasa.Location = new System.Drawing.Point(120, 208);
            this.nupNumeroCasa.Margin = new System.Windows.Forms.Padding(4);
            this.nupNumeroCasa.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupNumeroCasa.Name = "nupNumeroCasa";
            this.nupNumeroCasa.Size = new System.Drawing.Size(88, 34);
            this.nupNumeroCasa.TabIndex = 172;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(568, 40);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(110, 32);
            this.lblEstado.TabIndex = 172;
            this.lblEstado.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Enabled = false;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbEstado.Location = new System.Drawing.Point(690, 38);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado.MaxLength = 2;
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(97, 38);
            this.cbEstado.TabIndex = 173;
            this.cbEstado.Tag = "";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(514, 95);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.MaxLength = 128;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(271, 37);
            this.txtBairro.TabIndex = 171;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.White;
            this.lblBairro.Location = new System.Drawing.Point(403, 96);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(99, 32);
            this.lblBairro.TabIndex = 170;
            this.lblBairro.Text = "Bairro";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(183, 95);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.MaxLength = 27;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(212, 37);
            this.txtCidade.TabIndex = 169;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(45, 95);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 32);
            this.label13.TabIndex = 168;
            this.label13.Text = "Cidade";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(481, 202);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplemento.MaxLength = 120;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(304, 37);
            this.txtComplemento.TabIndex = 165;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(239, 208);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 32);
            this.label11.TabIndex = 164;
            this.label11.Text = "Complemento";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.White;
            this.lblEndereco.Location = new System.Drawing.Point(45, 150);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(179, 32);
            this.lblEndereco.TabIndex = 162;
            this.lblEndereco.Text = "Logradouro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(245, 148);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.MaxLength = 256;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(536, 37);
            this.txtEndereco.TabIndex = 163;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(152, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 32);
            this.label7.TabIndex = 91;
            this.label7.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(272, 38);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(155, 37);
            this.txtCep.TabIndex = 89;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            // 
            // btnProcurarCEP
            // 
            this.btnProcurarCEP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurarCEP.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurarCEP.Image")));
            this.btnProcurarCEP.Location = new System.Drawing.Point(503, 32);
            this.btnProcurarCEP.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcurarCEP.Name = "btnProcurarCEP";
            this.btnProcurarCEP.Size = new System.Drawing.Size(51, 44);
            this.btnProcurarCEP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProcurarCEP.TabIndex = 94;
            this.btnProcurarCEP.TabStop = false;
            this.btnProcurarCEP.Click += new System.EventHandler(this.BuscarCep);
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbLogin.Controls.Add(this.label21);
            this.gbLogin.Controls.Add(this.label20);
            this.gbLogin.Controls.Add(this.label19);
            this.gbLogin.Controls.Add(this.label18);
            this.gbLogin.Controls.Add(this.pictureBox9);
            this.gbLogin.Controls.Add(this.label17);
            this.gbLogin.Controls.Add(this.lblPergunta);
            this.gbLogin.Controls.Add(this.pictureBox6);
            this.gbLogin.Controls.Add(this.txtPergunta);
            this.gbLogin.Controls.Add(this.pictureBox8);
            this.gbLogin.Controls.Add(this.txtResposta);
            this.gbLogin.Controls.Add(this.lblResposta);
            this.gbLogin.Controls.Add(this.label9);
            this.gbLogin.Controls.Add(this.pictureBox4);
            this.gbLogin.Controls.Add(this.txtUsuario);
            this.gbLogin.Controls.Add(this.txtSenha);
            this.gbLogin.Controls.Add(this.pictureBox5);
            this.gbLogin.Controls.Add(this.lblUsuario);
            this.gbLogin.Enabled = false;
            this.gbLogin.Location = new System.Drawing.Point(549, 573);
            this.gbLogin.Margin = new System.Windows.Forms.Padding(4);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Padding = new System.Windows.Forms.Padding(4);
            this.gbLogin.Size = new System.Drawing.Size(983, 251);
            this.gbLogin.TabIndex = 328;
            this.gbLogin.TabStop = false;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(811, 28);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 23);
            this.label21.TabIndex = 352;
            this.label21.Text = "*";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(701, 187);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 23);
            this.label20.TabIndex = 351;
            this.label20.Text = "*";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(232, 169);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 23);
            this.label19.TabIndex = 350;
            this.label19.Text = "*";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(232, 89);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 23);
            this.label18.TabIndex = 349;
            this.label18.Text = "*";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(133, 14);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(77, 46);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 348;
            this.pictureBox9.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Quicksand Bold", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(207, 8);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(177, 53);
            this.label17.TabIndex = 347;
            this.label17.Text = "LOGIN";
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPergunta.Location = new System.Drawing.Point(541, 28);
            this.lblPergunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(257, 32);
            this.lblPergunta.TabIndex = 346;
            this.lblPergunta.Text = "Pergunta Secreta";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(487, 23);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 345;
            this.pictureBox6.TabStop = false;
            // 
            // txtPergunta
            // 
            this.txtPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtPergunta.Location = new System.Drawing.Point(483, 65);
            this.txtPergunta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPergunta.MaxLength = 120;
            this.txtPergunta.Multiline = true;
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(472, 96);
            this.txtPergunta.TabIndex = 335;
            this.txtPergunta.Leave += new System.EventHandler(this.LeaveMaisculo);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(487, 185);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(49, 38);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 343;
            this.pictureBox8.TabStop = false;
            // 
            // txtResposta
            // 
            this.txtResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtResposta.Location = new System.Drawing.Point(767, 187);
            this.txtResposta.Margin = new System.Windows.Forms.Padding(4);
            this.txtResposta.MaxLength = 20;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.PasswordChar = '*';
            this.txtResposta.Size = new System.Drawing.Size(188, 30);
            this.txtResposta.TabIndex = 336;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResposta.Location = new System.Drawing.Point(544, 183);
            this.lblResposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(142, 32);
            this.lblResposta.TabIndex = 342;
            this.lblResposta.Text = "Resposta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(106, 163);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 32);
            this.label9.TabIndex = 335;
            this.label9.Text = "Senha";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(43, 83);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 334;
            this.pictureBox4.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtUsuario.Location = new System.Drawing.Point(52, 124);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.MaxLength = 60;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(379, 30);
            this.txtUsuario.TabIndex = 333;
            this.txtUsuario.TextChanged += new System.EventHandler(this.VerificarUsuario);
            this.txtUsuario.Leave += new System.EventHandler(this.LeaveMaisculo);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtSenha.Location = new System.Drawing.Point(52, 201);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.MaxLength = 60;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(380, 30);
            this.txtSenha.TabIndex = 334;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(52, 163);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 330;
            this.pictureBox5.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Location = new System.Drawing.Point(88, 83);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(123, 32);
            this.lblUsuario.TabIndex = 332;
            this.lblUsuario.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(448, 644);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 23);
            this.label3.TabIndex = 329;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmFuncionarioCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 913);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.gbCep);
            this.Controls.Add(this.gbContato);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbFuncao);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.lblEstrelaNomeArtista);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.btnValidarCPF);
            this.Controls.Add(this.lblDataDeNasc);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.lblNomeFunc);
            this.Controls.Add(this.lblCPF2);
            this.Controls.Add(this.lblEstrelaCPF);
            this.Controls.Add(this.txtCPF);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmFuncionarioCadastro";
            this.Text = "";
            this.Load += new System.EventHandler(this.CarregarCampos);
            this.Controls.SetChildIndex(this.btnLimpar, 0);
            this.Controls.SetChildIndex(this.pbLimpar, 0);
            this.Controls.SetChildIndex(this.gbCodigo, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.pbSalvar, 0);
            this.Controls.SetChildIndex(this.pbCancelar, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblTitulo2, 0);
            this.Controls.SetChildIndex(this.pictureBox10, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtCPF, 0);
            this.Controls.SetChildIndex(this.lblEstrelaCPF, 0);
            this.Controls.SetChildIndex(this.lblCPF2, 0);
            this.Controls.SetChildIndex(this.lblNomeFunc, 0);
            this.Controls.SetChildIndex(this.txtNomeFunc, 0);
            this.Controls.SetChildIndex(this.lblDataDeNasc, 0);
            this.Controls.SetChildIndex(this.btnValidarCPF, 0);
            this.Controls.SetChildIndex(this.cbSexo, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.lblEstrelaNomeArtista, 0);
            this.Controls.SetChildIndex(this.dtpDataNasc, 0);
            this.Controls.SetChildIndex(this.cbFuncao, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.gbContato, 0);
            this.Controls.SetChildIndex(this.gbCep, 0);
            this.Controls.SetChildIndex(this.gbLogin, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            this.gbCodigo.ResumeLayout(false);
            this.gbCodigo.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnValidarCPF)).EndInit();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnValidarEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.gbCep.ResumeLayout(false);
            this.gbCep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroCasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcurarCEP)).EndInit();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cbFuncao;
        public System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Label lblEstrelaNomeArtista;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbSexo;
        public System.Windows.Forms.PictureBox btnValidarCPF;
        private System.Windows.Forms.Label lblDataDeNasc;
        public System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblCPF2;
        private System.Windows.Forms.Label lblEstrelaCPF;
        public System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.PictureBox btnValidarEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.MaskedTextBox txtTelefone;
        public System.Windows.Forms.CheckBox chkTelFixo;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.NumericUpDown nupNumeroCasa;
        private System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.ComboBox cbEstado;
        public System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        public System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblEndereco;
        public System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox txtCep;
        public System.Windows.Forms.PictureBox btnProcurarCEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.GroupBox gbContato;
        public System.Windows.Forms.GroupBox gbCep;
        public System.Windows.Forms.GroupBox gbLogin;
        public System.Windows.Forms.Label lblPergunta;
    }
}