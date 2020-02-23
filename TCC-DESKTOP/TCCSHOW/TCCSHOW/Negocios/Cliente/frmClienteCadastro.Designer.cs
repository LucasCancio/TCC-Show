namespace TCCSHOW.Negocios.Cliente
{
    partial class frmClienteCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteCadastro));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.lblDataDeNasc = new System.Windows.Forms.Label();
            this.btnValidarCPF = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.gbHistorico = new System.Windows.Forms.GroupBox();
            this.tvHistorico = new System.Windows.Forms.TreeView();
            this.lblHorario = new System.Windows.Forms.Label();
            this.dtpHorarioInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHorarioFinal = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbConsultar = new System.Windows.Forms.PictureBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.pnCadastrar = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnValidarEmail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            this.gbCodigo.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnValidarCPF)).BeginInit();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.gbHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).BeginInit();
            this.pnCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnValidarEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSalvar
            // 
            this.pbSalvar.Location = new System.Drawing.Point(732, 806);
            this.pbSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(721, 787);
            this.btnSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // chkAtivo
            // 
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(375, 111);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.Font = new System.Drawing.Font("Quicksand Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitulo2.Location = new System.Drawing.Point(778, 16);
            this.lblTitulo2.Size = new System.Drawing.Size(242, 68);
            this.lblTitulo2.Text = "Cliente";
            // 
            // pbCancelar
            // 
            this.pbCancelar.Location = new System.Drawing.Point(946, 807);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(934, 787);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(740, 104);
            // 
            // pbLimpar
            // 
            this.pbLimpar.Location = new System.Drawing.Point(518, 811);
            this.pbLimpar.Click += new System.EventHandler(this.Limpar);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(501, 789);
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
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(20, 61);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(473, 38);
            this.txtNome.TabIndex = 350;
            this.txtNome.Leave += new System.EventHandler(this.LeaveMaisculo);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quicksand Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(122, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 36);
            this.label1.TabIndex = 349;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 34);
            this.label3.TabIndex = 348;
            this.label3.Text = "Nome";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(559, 58);
            this.dtpDataNasc.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataNasc.MaxDate = new System.DateTime(2111, 1, 10, 0, 0, 0, 0);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(323, 38);
            this.dtpDataNasc.TabIndex = 342;
            this.dtpDataNasc.Value = new System.DateTime(2017, 8, 31, 0, 0, 0, 0);
            // 
            // lblDataDeNasc
            // 
            this.lblDataDeNasc.AutoSize = true;
            this.lblDataDeNasc.BackColor = System.Drawing.Color.Transparent;
            this.lblDataDeNasc.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeNasc.ForeColor = System.Drawing.Color.White;
            this.lblDataDeNasc.Location = new System.Drawing.Point(553, 19);
            this.lblDataDeNasc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataDeNasc.Name = "lblDataDeNasc";
            this.lblDataDeNasc.Size = new System.Drawing.Size(321, 34);
            this.lblDataDeNasc.TabIndex = 341;
            this.lblDataDeNasc.Text = "Data de Nascimento";
            // 
            // btnValidarCPF
            // 
            this.btnValidarCPF.BackColor = System.Drawing.Color.Transparent;
            this.btnValidarCPF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarCPF.Image = ((System.Drawing.Image)(resources.GetObject("btnValidarCPF.Image")));
            this.btnValidarCPF.Location = new System.Drawing.Point(795, 165);
            this.btnValidarCPF.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidarCPF.Name = "btnValidarCPF";
            this.btnValidarCPF.Size = new System.Drawing.Size(38, 40);
            this.btnValidarCPF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnValidarCPF.TabIndex = 356;
            this.btnValidarCPF.TabStop = false;
            this.btnValidarCPF.Click += new System.EventHandler(this.ClickValidar);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(643, 124);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 36);
            this.label19.TabIndex = 355;
            this.label19.Text = "*";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(561, 164);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Mask = "000000000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(226, 41);
            this.txtCPF.TabIndex = 354;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // lblCPF2
            // 
            this.lblCPF2.AutoSize = true;
            this.lblCPF2.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF2.Font = new System.Drawing.Font("Quicksand Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF2.ForeColor = System.Drawing.Color.White;
            this.lblCPF2.Location = new System.Drawing.Point(574, 131);
            this.lblCPF2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF2.Name = "lblCPF2";
            this.lblCPF2.Size = new System.Drawing.Size(60, 27);
            this.lblCPF2.TabIndex = 353;
            this.lblCPF2.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 34);
            this.label5.TabIndex = 352;
            this.label5.Text = "Sexo";
            // 
            // cbSexo
            // 
            this.cbSexo.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.ItemHeight = 31;
            this.cbSexo.Items.AddRange(new object[] {
            "N.I",
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(20, 164);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(283, 39);
            this.cbSexo.TabIndex = 351;
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbLogin.Controls.Add(this.label21);
            this.gbLogin.Controls.Add(this.label20);
            this.gbLogin.Controls.Add(this.label7);
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
            this.gbLogin.Location = new System.Drawing.Point(11, 309);
            this.gbLogin.Margin = new System.Windows.Forms.Padding(4);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Padding = new System.Windows.Forms.Padding(4);
            this.gbLogin.Size = new System.Drawing.Size(872, 279);
            this.gbLogin.TabIndex = 357;
            this.gbLogin.TabStop = false;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(808, 22);
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
            this.label20.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(699, 182);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 23);
            this.label20.TabIndex = 351;
            this.label20.Text = "*";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(221, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 23);
            this.label7.TabIndex = 350;
            this.label7.Text = "*";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(230, 86);
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
            this.pictureBox9.Location = new System.Drawing.Point(134, 21);
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
            this.label17.Font = new System.Drawing.Font("Quicksand Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(208, 15);
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
            this.lblPergunta.Location = new System.Drawing.Point(525, 20);
            this.lblPergunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(257, 32);
            this.lblPergunta.TabIndex = 346;
            this.lblPergunta.Text = "Pergunta Secreta";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(471, 15);
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
            this.txtPergunta.Location = new System.Drawing.Point(471, 61);
            this.txtPergunta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPergunta.MaxLength = 120;
            this.txtPergunta.Multiline = true;
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(379, 106);
            this.txtPergunta.TabIndex = 344;
            this.txtPergunta.Leave += new System.EventHandler(this.LeaveMaisculo);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(485, 180);
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
            this.txtResposta.Location = new System.Drawing.Point(471, 232);
            this.txtResposta.Margin = new System.Windows.Forms.Padding(4);
            this.txtResposta.MaxLength = 20;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.PasswordChar = '*';
            this.txtResposta.Size = new System.Drawing.Size(375, 30);
            this.txtResposta.TabIndex = 341;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResposta.Location = new System.Drawing.Point(542, 178);
            this.lblResposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(152, 34);
            this.lblResposta.TabIndex = 342;
            this.lblResposta.Text = "Resposta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(95, 195);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 34);
            this.label9.TabIndex = 335;
            this.label9.Text = "Senha";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(41, 80);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 334;
            this.pictureBox4.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtUsuario.Location = new System.Drawing.Point(41, 126);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.MaxLength = 60;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(379, 30);
            this.txtUsuario.TabIndex = 331;
            this.txtUsuario.TextChanged += new System.EventHandler(this.VerificarUsuario);
            this.txtUsuario.Leave += new System.EventHandler(this.LeaveMaisculo);
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtSenha.Location = new System.Drawing.Point(41, 233);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.MaxLength = 60;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(380, 30);
            this.txtSenha.TabIndex = 333;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(41, 195);
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
            this.lblUsuario.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Location = new System.Drawing.Point(86, 80);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(129, 34);
            this.lblUsuario.TabIndex = 332;
            this.lblUsuario.Text = "Usuário";
            // 
            // gbHistorico
            // 
            this.gbHistorico.BackColor = System.Drawing.Color.Transparent;
            this.gbHistorico.Controls.Add(this.tvHistorico);
            this.gbHistorico.Controls.Add(this.lblHorario);
            this.gbHistorico.Controls.Add(this.dtpHorarioInicio);
            this.gbHistorico.Controls.Add(this.dtpHorarioFinal);
            this.gbHistorico.Controls.Add(this.label8);
            this.gbHistorico.Controls.Add(this.pictureBox1);
            this.gbHistorico.Controls.Add(this.pbConsultar);
            this.gbHistorico.Controls.Add(this.btnConsultar);
            this.gbHistorico.Enabled = false;
            this.gbHistorico.Location = new System.Drawing.Point(973, 166);
            this.gbHistorico.Name = "gbHistorico";
            this.gbHistorico.Size = new System.Drawing.Size(590, 602);
            this.gbHistorico.TabIndex = 358;
            this.gbHistorico.TabStop = false;
            // 
            // tvHistorico
            // 
            this.tvHistorico.BackColor = System.Drawing.Color.Black;
            this.tvHistorico.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvHistorico.ForeColor = System.Drawing.Color.White;
            this.tvHistorico.Location = new System.Drawing.Point(26, 92);
            this.tvHistorico.Name = "tvHistorico";
            this.tvHistorico.ShowLines = false;
            this.tvHistorico.Size = new System.Drawing.Size(540, 396);
            this.tvHistorico.TabIndex = 702;
            this.tvHistorico.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvHistorico_AfterSelect);
            this.tvHistorico.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tvHistorico_ControlAdded);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Quicksand Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(305, 510);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(26, 27);
            this.lblHorario.TabIndex = 701;
            this.lblHorario.Text = "á";
            // 
            // dtpHorarioInicio
            // 
            this.dtpHorarioInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHorarioInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHorarioInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorarioInicio.Location = new System.Drawing.Point(141, 508);
            this.dtpHorarioInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHorarioInicio.Name = "dtpHorarioInicio";
            this.dtpHorarioInicio.ShowUpDown = true;
            this.dtpHorarioInicio.Size = new System.Drawing.Size(156, 30);
            this.dtpHorarioInicio.TabIndex = 699;
            this.dtpHorarioInicio.Value = new System.DateTime(2016, 4, 15, 0, 0, 0, 0);
            this.dtpHorarioInicio.ValueChanged += new System.EventHandler(this.Exibir);
            // 
            // dtpHorarioFinal
            // 
            this.dtpHorarioFinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHorarioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHorarioFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorarioFinal.Location = new System.Drawing.Point(345, 508);
            this.dtpHorarioFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHorarioFinal.Name = "dtpHorarioFinal";
            this.dtpHorarioFinal.ShowUpDown = true;
            this.dtpHorarioFinal.Size = new System.Drawing.Size(153, 30);
            this.dtpHorarioFinal.TabIndex = 700;
            this.dtpHorarioFinal.Value = new System.DateTime(2018, 4, 15, 0, 0, 0, 0);
            this.dtpHorarioFinal.ValueChanged += new System.EventHandler(this.Exibir);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Quicksand Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(229, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 53);
            this.label8.TabIndex = 359;
            this.label8.Text = "Histórico";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 360;
            this.pictureBox1.TabStop = false;
            // 
            // pbConsultar
            // 
            this.pbConsultar.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConsultar.Image = ((System.Drawing.Image)(resources.GetObject("pbConsultar.Image")));
            this.pbConsultar.Location = new System.Drawing.Point(232, 558);
            this.pbConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.pbConsultar.Name = "pbConsultar";
            this.pbConsultar.Size = new System.Drawing.Size(36, 29);
            this.pbConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConsultar.TabIndex = 651;
            this.pbConsultar.TabStop = false;
            this.pbConsultar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Quicksand Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(221, 551);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(183, 46);
            this.btnConsultar.TabIndex = 650;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // pnCadastrar
            // 
            this.pnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.pnCadastrar.Controls.Add(this.label10);
            this.pnCadastrar.Controls.Add(this.txtEmail);
            this.pnCadastrar.Controls.Add(this.btnValidarEmail);
            this.pnCadastrar.Controls.Add(this.dtpDataNasc);
            this.pnCadastrar.Controls.Add(this.label3);
            this.pnCadastrar.Controls.Add(this.gbLogin);
            this.pnCadastrar.Controls.Add(this.label1);
            this.pnCadastrar.Controls.Add(this.btnValidarCPF);
            this.pnCadastrar.Controls.Add(this.lblDataDeNasc);
            this.pnCadastrar.Controls.Add(this.label19);
            this.pnCadastrar.Controls.Add(this.txtNome);
            this.pnCadastrar.Controls.Add(this.txtCPF);
            this.pnCadastrar.Controls.Add(this.cbSexo);
            this.pnCadastrar.Controls.Add(this.lblCPF2);
            this.pnCadastrar.Controls.Add(this.label5);
            this.pnCadastrar.Location = new System.Drawing.Point(54, 175);
            this.pnCadastrar.Name = "pnCadastrar";
            this.pnCadastrar.Size = new System.Drawing.Size(913, 593);
            this.pnCadastrar.TabIndex = 359;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(20, 225);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 34);
            this.label10.TabIndex = 359;
            this.label10.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(26, 261);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 120;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(468, 38);
            this.txtEmail.TabIndex = 358;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnValidarEmail
            // 
            this.btnValidarEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnValidarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnValidarEmail.Image")));
            this.btnValidarEmail.Location = new System.Drawing.Point(513, 259);
            this.btnValidarEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidarEmail.Name = "btnValidarEmail";
            this.btnValidarEmail.Size = new System.Drawing.Size(41, 40);
            this.btnValidarEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnValidarEmail.TabIndex = 360;
            this.btnValidarEmail.TabStop = false;
            this.btnValidarEmail.Click += new System.EventHandler(this.btnValidarEmail_Click);
            // 
            // frmClienteCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1576, 913);
            this.Controls.Add(this.pnCadastrar);
            this.Controls.Add(this.gbHistorico);
            this.Name = "frmClienteCadastro";
            this.Text = "";
            this.Load += new System.EventHandler(this.CarregarCampos);
            this.Controls.SetChildIndex(this.btnLimpar, 0);
            this.Controls.SetChildIndex(this.pbLimpar, 0);
            this.Controls.SetChildIndex(this.gbCodigo, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.pbSalvar, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblTitulo2, 0);
            this.Controls.SetChildIndex(this.pictureBox10, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.pbCancelar, 0);
            this.Controls.SetChildIndex(this.gbHistorico, 0);
            this.Controls.SetChildIndex(this.pnCadastrar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            this.gbCodigo.ResumeLayout(false);
            this.gbCodigo.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnValidarCPF)).EndInit();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.gbHistorico.ResumeLayout(false);
            this.gbHistorico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).EndInit();
            this.pnCadastrar.ResumeLayout(false);
            this.pnCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnValidarEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Label lblDataDeNasc;
        public System.Windows.Forms.PictureBox btnValidarCPF;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblCPF2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbSexo;
        public System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gbHistorico;
        public System.Windows.Forms.PictureBox pbConsultar;
        public System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblHorario;
        public System.Windows.Forms.DateTimePicker dtpHorarioInicio;
        public System.Windows.Forms.DateTimePicker dtpHorarioFinal;
        private System.Windows.Forms.TreeView tvHistorico;
        private System.Windows.Forms.Panel pnCadastrar;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.PictureBox btnValidarEmail;
    }
}