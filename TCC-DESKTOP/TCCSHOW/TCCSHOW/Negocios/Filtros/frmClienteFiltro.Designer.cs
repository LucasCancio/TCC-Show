namespace TCCSHOW.Negocios.Filtros
{
    partial class frmClienteFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteFiltro));
            this.gbDataEsp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.chkDataEsp = new System.Windows.Forms.CheckBox();
            this.pbRemover = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.gbArtEsp = new System.Windows.Forms.GroupBox();
            this.pbProcurarEvento = new System.Windows.Forms.PictureBox();
            this.btnProcurarEvento = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbAplicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            this.pnFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            this.gbDataEsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemover)).BeginInit();
            this.gbArtEsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcurarEvento)).BeginInit();
            this.gbPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAplicar
            // 
            this.pbAplicar.Location = new System.Drawing.Point(234, 456);
            this.pbAplicar.Click += new System.EventHandler(this.Aplicar);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(216, 448);
            this.btnAplicar.Click += new System.EventHandler(this.Aplicar);
            // 
            // pbCancelar
            // 
            this.pbCancelar.Location = new System.Drawing.Point(393, 458);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(386, 449);
            // 
            // pnFiltro
            // 
            this.pnFiltro.Controls.Add(this.gbPrincipal);
            this.pnFiltro.Controls.Add(this.gbDataEsp);
            this.pnFiltro.Controls.Add(this.chkDataEsp);
            this.pnFiltro.Controls.Add(this.pbRemover);
            this.pnFiltro.Controls.Add(this.label1);
            this.pnFiltro.Controls.Add(this.btnRemover);
            this.pnFiltro.Controls.Add(this.gbArtEsp);
            this.pnFiltro.Size = new System.Drawing.Size(717, 512);
            this.pnFiltro.Controls.SetChildIndex(this.pbFiltro, 0);
            this.pnFiltro.Controls.SetChildIndex(this.lblFiltro, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbCancelar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnAplicar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbAplicar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbArtEsp, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnRemover, 0);
            this.pnFiltro.Controls.SetChildIndex(this.label1, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbRemover, 0);
            this.pnFiltro.Controls.SetChildIndex(this.chkDataEsp, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbDataEsp, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbPrincipal, 0);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Font = new System.Drawing.Font("Quicksand Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(330, 24);
            this.lblFiltro.Size = new System.Drawing.Size(156, 43);
            // 
            // pbFiltro
            // 
            this.pbFiltro.Location = new System.Drawing.Point(242, 16);
            // 
            // gbDataEsp
            // 
            this.gbDataEsp.BackColor = System.Drawing.Color.Gray;
            this.gbDataEsp.Controls.Add(this.label3);
            this.gbDataEsp.Controls.Add(this.cbData);
            this.gbDataEsp.Enabled = false;
            this.gbDataEsp.Location = new System.Drawing.Point(208, 330);
            this.gbDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Name = "gbDataEsp";
            this.gbDataEsp.Padding = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Size = new System.Drawing.Size(334, 110);
            this.gbDataEsp.TabIndex = 392;
            this.gbDataEsp.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 34);
            this.label3.TabIndex = 288;
            this.label3.Text = "DATA DE(o/a):";
            // 
            // cbData
            // 
            this.cbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbData.FormattingEnabled = true;
            this.cbData.Items.AddRange(new object[] {
            "Nascimento"});
            this.cbData.Location = new System.Drawing.Point(32, 55);
            this.cbData.Margin = new System.Windows.Forms.Padding(4);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(281, 33);
            this.cbData.TabIndex = 286;
            // 
            // chkDataEsp
            // 
            this.chkDataEsp.AutoSize = true;
            this.chkDataEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDataEsp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkDataEsp.Location = new System.Drawing.Point(294, 304);
            this.chkDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.chkDataEsp.Name = "chkDataEsp";
            this.chkDataEsp.Size = new System.Drawing.Size(173, 28);
            this.chkDataEsp.TabIndex = 391;
            this.chkDataEsp.Text = "Data específica";
            this.chkDataEsp.UseVisualStyleBackColor = true;
            this.chkDataEsp.CheckedChanged += new System.EventHandler(this.chkDataEsp_CheckedChanged);
            // 
            // pbRemover
            // 
            this.pbRemover.BackColor = System.Drawing.Color.Firebrick;
            this.pbRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRemover.Image = ((System.Drawing.Image)(resources.GetObject("pbRemover.Image")));
            this.pbRemover.Location = new System.Drawing.Point(528, 200);
            this.pbRemover.Margin = new System.Windows.Forms.Padding(4);
            this.pbRemover.Name = "pbRemover";
            this.pbRemover.Size = new System.Drawing.Size(29, 24);
            this.pbRemover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemover.TabIndex = 390;
            this.pbRemover.TabStop = false;
            this.pbRemover.Visible = false;
            this.pbRemover.Click += new System.EventHandler(this.RemoverEvento);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(217, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 27);
            this.label1.TabIndex = 386;
            this.label1.Text = "Evento comparecido";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemover.Location = new System.Drawing.Point(518, 193);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(146, 40);
            this.btnRemover.TabIndex = 389;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Visible = false;
            this.btnRemover.Click += new System.EventHandler(this.RemoverEvento);
            // 
            // gbArtEsp
            // 
            this.gbArtEsp.BackColor = System.Drawing.Color.Gray;
            this.gbArtEsp.Controls.Add(this.pbProcurarEvento);
            this.gbArtEsp.Controls.Add(this.btnProcurarEvento);
            this.gbArtEsp.Controls.Add(this.txtTitulo);
            this.gbArtEsp.Location = new System.Drawing.Point(58, 215);
            this.gbArtEsp.Margin = new System.Windows.Forms.Padding(4);
            this.gbArtEsp.Name = "gbArtEsp";
            this.gbArtEsp.Padding = new System.Windows.Forms.Padding(4);
            this.gbArtEsp.Size = new System.Drawing.Size(615, 70);
            this.gbArtEsp.TabIndex = 387;
            this.gbArtEsp.TabStop = false;
            // 
            // pbProcurarEvento
            // 
            this.pbProcurarEvento.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbProcurarEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProcurarEvento.Image = ((System.Drawing.Image)(resources.GetObject("pbProcurarEvento.Image")));
            this.pbProcurarEvento.Location = new System.Drawing.Point(477, 29);
            this.pbProcurarEvento.Margin = new System.Windows.Forms.Padding(4);
            this.pbProcurarEvento.Name = "pbProcurarEvento";
            this.pbProcurarEvento.Size = new System.Drawing.Size(23, 24);
            this.pbProcurarEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProcurarEvento.TabIndex = 302;
            this.pbProcurarEvento.TabStop = false;
            this.pbProcurarEvento.Click += new System.EventHandler(this.ProcurarEvento);
            // 
            // btnProcurarEvento
            // 
            this.btnProcurarEvento.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProcurarEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarEvento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcurarEvento.Location = new System.Drawing.Point(461, 20);
            this.btnProcurarEvento.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcurarEvento.Name = "btnProcurarEvento";
            this.btnProcurarEvento.Size = new System.Drawing.Size(146, 40);
            this.btnProcurarEvento.TabIndex = 301;
            this.btnProcurarEvento.Text = "Procurar";
            this.btnProcurarEvento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcurarEvento.UseVisualStyleBackColor = false;
            this.btnProcurarEvento.Click += new System.EventHandler(this.ProcurarEvento);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(8, 26);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(446, 34);
            this.txtTitulo.TabIndex = 0;
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.rbEmail);
            this.gbPrincipal.Controls.Add(this.rbCodigo);
            this.gbPrincipal.Controls.Add(this.rbCPF);
            this.gbPrincipal.Controls.Add(this.rbNome);
            this.gbPrincipal.Controls.Add(this.rbUsuario);
            this.gbPrincipal.Location = new System.Drawing.Point(26, 82);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(667, 74);
            this.gbPrincipal.TabIndex = 382;
            this.gbPrincipal.TabStop = false;
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Font = new System.Drawing.Font("Quicksand Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmail.ForeColor = System.Drawing.Color.White;
            this.rbEmail.Location = new System.Drawing.Point(548, 25);
            this.rbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(100, 32);
            this.rbEmail.TabIndex = 347;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "Email";
            this.rbEmail.UseVisualStyleBackColor = true;
            this.rbEmail.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Quicksand Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(16, 25);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(125, 32);
            this.rbCodigo.TabIndex = 346;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCPF.ForeColor = System.Drawing.Color.White;
            this.rbCPF.Location = new System.Drawing.Point(437, 25);
            this.rbCPF.Margin = new System.Windows.Forms.Padding(4);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(91, 36);
            this.rbCPF.TabIndex = 345;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(149, 25);
            this.rbNome.Margin = new System.Windows.Forms.Padding(4);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(120, 36);
            this.rbNome.TabIndex = 343;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbUsuario
            // 
            this.rbUsuario.AutoSize = true;
            this.rbUsuario.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUsuario.ForeColor = System.Drawing.Color.White;
            this.rbUsuario.Location = new System.Drawing.Point(278, 25);
            this.rbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(144, 36);
            this.rbUsuario.TabIndex = 344;
            this.rbUsuario.TabStop = true;
            this.rbUsuario.Text = "Usuário";
            this.rbUsuario.UseVisualStyleBackColor = true;
            this.rbUsuario.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // frmClienteFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 561);
            this.Name = "frmClienteFiltro";
            this.Text = "";
            this.Load += new System.EventHandler(this.CarregarCampos);
            ((System.ComponentModel.ISupportInitialize)(this.pbAplicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            this.pnFiltro.ResumeLayout(false);
            this.pnFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            this.gbDataEsp.ResumeLayout(false);
            this.gbDataEsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemover)).EndInit();
            this.gbArtEsp.ResumeLayout(false);
            this.gbArtEsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcurarEvento)).EndInit();
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDataEsp;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.CheckBox chkDataEsp;
        public System.Windows.Forms.PictureBox pbRemover;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox gbArtEsp;
        public System.Windows.Forms.PictureBox pbProcurarEvento;
        public System.Windows.Forms.Button btnProcurarEvento;
        public System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbUsuario;
    }
}