namespace TCCSHOW.Sistema
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TxtBoxs = new System.Windows.Forms.Timer(this.components);
            this.pnLogin = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbCapsLock = new System.Windows.Forms.PictureBox();
            this.lblCapsLock = new System.Windows.Forms.Label();
            this.pbMostrarSenha = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEsqueceuSenha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.btnDeslogar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnRodape = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.erro = new System.Windows.Forms.ErrorProvider(this.components);
            this.IniciarAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapsLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeslogar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 500;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // TxtBoxs
            // 
            this.TxtBoxs.Enabled = true;
            this.TxtBoxs.Interval = 1000;
            this.TxtBoxs.Tick += new System.EventHandler(this.Fontes);
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnLogin.Controls.Add(this.pictureBox5);
            this.pnLogin.Controls.Add(this.groupBox1);
            this.pnLogin.Controls.Add(this.label4);
            this.pnLogin.Controls.Add(this.lblEsqueceuSenha);
            this.pnLogin.Controls.Add(this.label3);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.IniciarAnimation.SetDecoration(this.pnLogin, BunifuAnimatorNS.DecorationType.None);
            this.pnLogin.Location = new System.Drawing.Point(37, 41);
            this.pnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(576, 447);
            this.pnLogin.TabIndex = 131;
            this.pnLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pnLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.IniciarAnimation.SetDecoration(this.pictureBox5, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(219, 27);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 113);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.pbCapsLock);
            this.groupBox1.Controls.Add(this.lblCapsLock);
            this.groupBox1.Controls.Add(this.pbMostrarSenha);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.txtUser);
            this.IniciarAnimation.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(49, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(464, 243);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // pbCapsLock
            // 
            this.pbCapsLock.BackColor = System.Drawing.Color.Transparent;
            this.IniciarAnimation.SetDecoration(this.pbCapsLock, BunifuAnimatorNS.DecorationType.None);
            this.pbCapsLock.Image = ((System.Drawing.Image)(resources.GetObject("pbCapsLock.Image")));
            this.pbCapsLock.Location = new System.Drawing.Point(90, 198);
            this.pbCapsLock.Margin = new System.Windows.Forms.Padding(4);
            this.pbCapsLock.Name = "pbCapsLock";
            this.pbCapsLock.Size = new System.Drawing.Size(37, 35);
            this.pbCapsLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCapsLock.TabIndex = 22;
            this.pbCapsLock.TabStop = false;
            this.pbCapsLock.Visible = false;
            // 
            // lblCapsLock
            // 
            this.lblCapsLock.AutoSize = true;
            this.IniciarAnimation.SetDecoration(this.lblCapsLock, BunifuAnimatorNS.DecorationType.None);
            this.lblCapsLock.Font = new System.Drawing.Font("Quicksand Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapsLock.ForeColor = System.Drawing.Color.Yellow;
            this.lblCapsLock.Location = new System.Drawing.Point(128, 204);
            this.lblCapsLock.Name = "lblCapsLock";
            this.lblCapsLock.Size = new System.Drawing.Size(231, 27);
            this.lblCapsLock.TabIndex = 21;
            this.lblCapsLock.Text = "CapsLock LIGADO";
            this.lblCapsLock.Visible = false;
            // 
            // pbMostrarSenha
            // 
            this.pbMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.IniciarAnimation.SetDecoration(this.pbMostrarSenha, BunifuAnimatorNS.DecorationType.None);
            this.pbMostrarSenha.Image = ((System.Drawing.Image)(resources.GetObject("pbMostrarSenha.Image")));
            this.pbMostrarSenha.Location = new System.Drawing.Point(418, 156);
            this.pbMostrarSenha.Margin = new System.Windows.Forms.Padding(4);
            this.pbMostrarSenha.Name = "pbMostrarSenha";
            this.pbMostrarSenha.Size = new System.Drawing.Size(31, 36);
            this.pbMostrarSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrarSenha.TabIndex = 20;
            this.pbMostrarSenha.TabStop = false;
            this.pbMostrarSenha.Visible = false;
            this.pbMostrarSenha.Click += new System.EventHandler(this.VisualizarSenha);
            this.pbMostrarSenha.DragOver += new System.Windows.Forms.DragEventHandler(this.pbMostrarSenha_DragOver);
            this.pbMostrarSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMostrarSenha_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IniciarAnimation.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(39, 155);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IniciarAnimation.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 97);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IniciarAnimation.SetDecoration(this.txtSenha, BunifuAnimatorNS.DecorationType.None);
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.LightGray;
            this.txtSenha.Location = new System.Drawing.Point(76, 153);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.MaxLength = 120;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSenha.Size = new System.Drawing.Size(328, 38);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "Digite sua Senha";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fontes);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IniciarAnimation.SetDecoration(this.txtUser, BunifuAnimatorNS.DecorationType.None);
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.LightGray;
            this.txtUser.Location = new System.Drawing.Point(76, 97);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.MaxLength = 120;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(328, 38);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Digite seu Usuário";
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fontes);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.IniciarAnimation.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Quicksand Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(355, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 50);
            this.label4.TabIndex = 21;
            this.label4.Text = "House";
            // 
            // lblEsqueceuSenha
            // 
            this.lblEsqueceuSenha.AutoSize = true;
            this.lblEsqueceuSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblEsqueceuSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarAnimation.SetDecoration(this.lblEsqueceuSenha, BunifuAnimatorNS.DecorationType.None);
            this.lblEsqueceuSenha.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueceuSenha.ForeColor = System.Drawing.Color.Silver;
            this.lblEsqueceuSenha.Location = new System.Drawing.Point(188, 411);
            this.lblEsqueceuSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEsqueceuSenha.Name = "lblEsqueceuSenha";
            this.lblEsqueceuSenha.Size = new System.Drawing.Size(200, 23);
            this.lblEsqueceuSenha.TabIndex = 15;
            this.lblEsqueceuSenha.Text = "Esqueceu a Senha?";
            this.lblEsqueceuSenha.Visible = false;
            this.lblEsqueceuSenha.Click += new System.EventHandler(this.Trocar);
            this.lblEsqueceuSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SubinharLbl);
            this.lblEsqueceuSenha.MouseLeave += new System.EventHandler(this.DesSubinharLbl);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.IniciarAnimation.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Quicksand Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(11, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 50);
            this.label3.TabIndex = 20;
            this.label3.Text = "Comedy";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarAnimation.SetDecoration(this.btnLogin, BunifuAnimatorNS.DecorationType.None);
            this.btnLogin.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(127, 340);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(313, 60);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.AbrirLogin);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarAnimation.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(53, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "WebSite";
            this.label2.Click += new System.EventHandler(this.AbrirSite);
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SubinharLbl);
            this.label2.MouseLeave += new System.EventHandler(this.DesSubinharLbl);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.IniciarAnimation.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(337, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Powered by: Equipe 05 ";
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.BackColor = System.Drawing.Color.Black;
            this.pnCabecalho.Controls.Add(this.label2);
            this.pnCabecalho.Controls.Add(this.pictureBox2);
            this.pnCabecalho.Controls.Add(this.pbMinimizar);
            this.pnCabecalho.Controls.Add(this.btnDeslogar);
            this.IniciarAnimation.SetDecoration(this.pnCabecalho, BunifuAnimatorNS.DecorationType.None);
            this.pnCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.pnCabecalho.Name = "pnCabecalho";
            this.pnCabecalho.Size = new System.Drawing.Size(657, 39);
            this.pnCabecalho.TabIndex = 133;
            this.pnCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pnCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarAnimation.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.BackgroundImage")));
            this.IniciarAnimation.SetDecoration(this.pbMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(551, 4);
            this.pbMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(40, 32);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizar.TabIndex = 6;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.Minimizar);
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.BackColor = System.Drawing.Color.Transparent;
            this.IniciarAnimation.SetDecoration(this.btnDeslogar, BunifuAnimatorNS.DecorationType.None);
            this.btnDeslogar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeslogar.Image")));
            this.btnDeslogar.ImageActive = null;
            this.btnDeslogar.Location = new System.Drawing.Point(596, 6);
            this.btnDeslogar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(43, 31);
            this.btnDeslogar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeslogar.TabIndex = 0;
            this.btnDeslogar.TabStop = false;
            this.btnDeslogar.Zoom = 10;
            this.btnDeslogar.Click += new System.EventHandler(this.Sair);
            // 
            // pnRodape
            // 
            this.pnRodape.BackColor = System.Drawing.Color.Black;
            this.IniciarAnimation.SetDecoration(this.pnRodape, BunifuAnimatorNS.DecorationType.None);
            this.pnRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnRodape.Location = new System.Drawing.Point(0, 479);
            this.pnRodape.Margin = new System.Windows.Forms.Padding(4);
            this.pnRodape.Name = "pnRodape";
            this.pnRodape.Size = new System.Drawing.Size(657, 39);
            this.pnRodape.TabIndex = 132;
            this.pnRodape.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pnRodape.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 60;
            this.bunifuElipse1.TargetControl = this;
            // 
            // erro
            // 
            this.erro.ContainerControl = this;
            // 
            // IniciarAnimation
            // 
            this.IniciarAnimation.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.IniciarAnimation.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.IniciarAnimation.DefaultAnimation = animation1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 518);
            this.Controls.Add(this.pnCabecalho);
            this.Controls.Add(this.pnRodape);
            this.Controls.Add(this.pnLogin);
            this.IniciarAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CapsLock);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BotaoEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapsLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeslogar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer TxtBoxs;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEsqueceuSenha;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel pnCabecalho;
        public System.Windows.Forms.PictureBox pbMinimizar;
        public Bunifu.Framework.UI.BunifuImageButton btnDeslogar;
        public System.Windows.Forms.Panel pnRodape;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.ErrorProvider erro;
        private System.Windows.Forms.PictureBox pbMostrarSenha;
        private System.Windows.Forms.PictureBox pbCapsLock;
        private System.Windows.Forms.Label lblCapsLock;
        private BunifuAnimatorNS.BunifuTransition IniciarAnimation;
    }
}