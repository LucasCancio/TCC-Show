namespace TCCSHOW.Negocios.Filtros
{
    partial class frmArtistaFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArtistaFiltro));
            this.pbArtF = new System.Windows.Forms.PictureBox();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.chkArtF = new System.Windows.Forms.CheckBox();
            this.chkArt = new System.Windows.Forms.CheckBox();
            this.gbArtF = new System.Windows.Forms.GroupBox();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.rbTelefone = new System.Windows.Forms.RadioButton();
            this.pbArt = new System.Windows.Forms.PictureBox();
            this.gbArt = new System.Windows.Forms.GroupBox();
            this.chkDoc = new System.Windows.Forms.CheckBox();
            this.gbDoc = new System.Windows.Forms.GroupBox();
            this.rbCNPJEmpresario = new System.Windows.Forms.RadioButton();
            this.rbCPFEmpresario = new System.Windows.Forms.RadioButton();
            this.rbNomeEmpresario = new System.Windows.Forms.RadioButton();
            this.gbDataEsp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.chkDataEsp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAplicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            this.pnFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtF)).BeginInit();
            this.gbArtF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).BeginInit();
            this.gbArt.SuspendLayout();
            this.gbDoc.SuspendLayout();
            this.gbDataEsp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAplicar
            // 
            this.pbAplicar.Location = new System.Drawing.Point(209, 478);
            this.pbAplicar.Click += new System.EventHandler(this.Aplicar);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(191, 470);
            this.btnAplicar.Click += new System.EventHandler(this.Aplicar);
            // 
            // pbCancelar
            // 
            this.pbCancelar.Location = new System.Drawing.Point(368, 480);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(361, 471);
            // 
            // pnFiltro
            // 
            this.pnFiltro.Controls.Add(this.pbArtF);
            this.pnFiltro.Controls.Add(this.rbNome);
            this.pnFiltro.Controls.Add(this.rbCodigo);
            this.pnFiltro.Controls.Add(this.chkArtF);
            this.pnFiltro.Controls.Add(this.chkArt);
            this.pnFiltro.Controls.Add(this.gbArtF);
            this.pnFiltro.Controls.Add(this.pbArt);
            this.pnFiltro.Controls.Add(this.gbArt);
            this.pnFiltro.Controls.Add(this.gbDataEsp);
            this.pnFiltro.Controls.Add(this.chkDataEsp);
            this.pnFiltro.Size = new System.Drawing.Size(736, 545);
            this.pnFiltro.Controls.SetChildIndex(this.pbFiltro, 0);
            this.pnFiltro.Controls.SetChildIndex(this.lblFiltro, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbCancelar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnAplicar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbAplicar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.chkDataEsp, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbDataEsp, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbArt, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbArt, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbArtF, 0);
            this.pnFiltro.Controls.SetChildIndex(this.chkArt, 0);
            this.pnFiltro.Controls.SetChildIndex(this.chkArtF, 0);
            this.pnFiltro.Controls.SetChildIndex(this.rbCodigo, 0);
            this.pnFiltro.Controls.SetChildIndex(this.rbNome, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbArtF, 0);
            // 
            // pbArtF
            // 
            this.pbArtF.AccessibleDescription = "Empresário";
            this.pbArtF.BackColor = System.Drawing.Color.Transparent;
            this.pbArtF.Image = ((System.Drawing.Image)(resources.GetObject("pbArtF.Image")));
            this.pbArtF.Location = new System.Drawing.Point(494, 98);
            this.pbArtF.Margin = new System.Windows.Forms.Padding(4);
            this.pbArtF.Name = "pbArtF";
            this.pbArtF.Size = new System.Drawing.Size(32, 51);
            this.pbArtF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArtF.TabIndex = 398;
            this.pbArtF.TabStop = false;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Quicksand Bold Oblique", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(285, 223);
            this.rbNome.Margin = new System.Windows.Forms.Padding(4);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(194, 27);
            this.rbNome.TabIndex = 389;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome Completo";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(285, 184);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(119, 32);
            this.rbCodigo.TabIndex = 397;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // chkArtF
            // 
            this.chkArtF.AutoSize = true;
            this.chkArtF.Font = new System.Drawing.Font("Quicksand Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkArtF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkArtF.Location = new System.Drawing.Point(533, 111);
            this.chkArtF.Name = "chkArtF";
            this.chkArtF.Size = new System.Drawing.Size(173, 31);
            this.chkArtF.TabIndex = 396;
            this.chkArtF.Text = "Artista Fixo";
            this.chkArtF.UseVisualStyleBackColor = true;
            this.chkArtF.CheckedChanged += new System.EventHandler(this.CheckedChange);
            // 
            // chkArt
            // 
            this.chkArt.AutoSize = true;
            this.chkArt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkArt.Font = new System.Drawing.Font("Quicksand Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkArt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkArt.Location = new System.Drawing.Point(66, 111);
            this.chkArt.Name = "chkArt";
            this.chkArt.Size = new System.Drawing.Size(115, 31);
            this.chkArt.TabIndex = 395;
            this.chkArt.Text = "Artista";
            this.chkArt.UseVisualStyleBackColor = true;
            this.chkArt.CheckedChanged += new System.EventHandler(this.CheckedChange);
            // 
            // gbArtF
            // 
            this.gbArtF.Controls.Add(this.rbCPF);
            this.gbArtF.Controls.Add(this.rbEmail);
            this.gbArtF.Controls.Add(this.rbTelefone);
            this.gbArtF.Location = new System.Drawing.Point(496, 156);
            this.gbArtF.Name = "gbArtF";
            this.gbArtF.Size = new System.Drawing.Size(216, 135);
            this.gbArtF.TabIndex = 394;
            this.gbArtF.TabStop = false;
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCPF.ForeColor = System.Drawing.Color.White;
            this.rbCPF.Location = new System.Drawing.Point(61, 19);
            this.rbCPF.Margin = new System.Windows.Forms.Padding(4);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(78, 32);
            this.rbCPF.TabIndex = 343;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmail.ForeColor = System.Drawing.Color.White;
            this.rbEmail.Location = new System.Drawing.Point(61, 93);
            this.rbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(98, 32);
            this.rbEmail.TabIndex = 342;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "Email";
            this.rbEmail.UseVisualStyleBackColor = true;
            this.rbEmail.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbTelefone
            // 
            this.rbTelefone.AutoSize = true;
            this.rbTelefone.Font = new System.Drawing.Font("Quicksand Bold Oblique", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTelefone.ForeColor = System.Drawing.Color.White;
            this.rbTelefone.Location = new System.Drawing.Point(61, 58);
            this.rbTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.rbTelefone.Name = "rbTelefone";
            this.rbTelefone.Size = new System.Drawing.Size(117, 27);
            this.rbTelefone.TabIndex = 341;
            this.rbTelefone.TabStop = true;
            this.rbTelefone.Text = "Telefone";
            this.rbTelefone.UseVisualStyleBackColor = true;
            this.rbTelefone.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // pbArt
            // 
            this.pbArt.AccessibleDescription = "Empresário";
            this.pbArt.BackColor = System.Drawing.Color.Transparent;
            this.pbArt.Image = ((System.Drawing.Image)(resources.GetObject("pbArt.Image")));
            this.pbArt.Location = new System.Drawing.Point(185, 98);
            this.pbArt.Margin = new System.Windows.Forms.Padding(4);
            this.pbArt.Name = "pbArt";
            this.pbArt.Size = new System.Drawing.Size(32, 51);
            this.pbArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArt.TabIndex = 393;
            this.pbArt.TabStop = false;
            // 
            // gbArt
            // 
            this.gbArt.Controls.Add(this.chkDoc);
            this.gbArt.Controls.Add(this.gbDoc);
            this.gbArt.Controls.Add(this.rbNomeEmpresario);
            this.gbArt.Font = new System.Drawing.Font("Quicksand Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbArt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbArt.Location = new System.Drawing.Point(19, 156);
            this.gbArt.Name = "gbArt";
            this.gbArt.Size = new System.Drawing.Size(248, 135);
            this.gbArt.TabIndex = 392;
            this.gbArt.TabStop = false;
            this.gbArt.Text = "Empresário";
            // 
            // chkDoc
            // 
            this.chkDoc.AutoSize = true;
            this.chkDoc.Font = new System.Drawing.Font("Quicksand Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDoc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkDoc.Location = new System.Drawing.Point(21, 62);
            this.chkDoc.Margin = new System.Windows.Forms.Padding(4);
            this.chkDoc.Name = "chkDoc";
            this.chkDoc.Size = new System.Drawing.Size(143, 26);
            this.chkDoc.TabIndex = 359;
            this.chkDoc.Text = "Documento";
            this.chkDoc.UseVisualStyleBackColor = true;
            this.chkDoc.CheckedChanged += new System.EventHandler(this.chkDoc_CheckedChanged);
            // 
            // gbDoc
            // 
            this.gbDoc.Controls.Add(this.rbCNPJEmpresario);
            this.gbDoc.Controls.Add(this.rbCPFEmpresario);
            this.gbDoc.Enabled = false;
            this.gbDoc.Location = new System.Drawing.Point(19, 67);
            this.gbDoc.Name = "gbDoc";
            this.gbDoc.Size = new System.Drawing.Size(207, 62);
            this.gbDoc.TabIndex = 360;
            this.gbDoc.TabStop = false;
            this.gbDoc.Text = "groupBox1";
            // 
            // rbCNPJEmpresario
            // 
            this.rbCNPJEmpresario.AutoSize = true;
            this.rbCNPJEmpresario.Font = new System.Drawing.Font("Quicksand Bold Oblique", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCNPJEmpresario.ForeColor = System.Drawing.Color.White;
            this.rbCNPJEmpresario.Location = new System.Drawing.Point(97, 28);
            this.rbCNPJEmpresario.Margin = new System.Windows.Forms.Padding(4);
            this.rbCNPJEmpresario.Name = "rbCNPJEmpresario";
            this.rbCNPJEmpresario.Size = new System.Drawing.Size(82, 26);
            this.rbCNPJEmpresario.TabIndex = 347;
            this.rbCNPJEmpresario.TabStop = true;
            this.rbCNPJEmpresario.Text = "CNPJ";
            this.rbCNPJEmpresario.UseVisualStyleBackColor = true;
            this.rbCNPJEmpresario.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbCPFEmpresario
            // 
            this.rbCPFEmpresario.AutoSize = true;
            this.rbCPFEmpresario.Font = new System.Drawing.Font("Quicksand Bold Oblique", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCPFEmpresario.ForeColor = System.Drawing.Color.White;
            this.rbCPFEmpresario.Location = new System.Drawing.Point(19, 28);
            this.rbCPFEmpresario.Margin = new System.Windows.Forms.Padding(4);
            this.rbCPFEmpresario.Name = "rbCPFEmpresario";
            this.rbCPFEmpresario.Size = new System.Drawing.Size(67, 26);
            this.rbCPFEmpresario.TabIndex = 346;
            this.rbCPFEmpresario.TabStop = true;
            this.rbCPFEmpresario.Text = "CPF";
            this.rbCPFEmpresario.UseVisualStyleBackColor = true;
            this.rbCPFEmpresario.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbNomeEmpresario
            // 
            this.rbNomeEmpresario.AutoSize = true;
            this.rbNomeEmpresario.Font = new System.Drawing.Font("Quicksand Bold Oblique", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNomeEmpresario.ForeColor = System.Drawing.Color.White;
            this.rbNomeEmpresario.Location = new System.Drawing.Point(21, 28);
            this.rbNomeEmpresario.Margin = new System.Windows.Forms.Padding(4);
            this.rbNomeEmpresario.Name = "rbNomeEmpresario";
            this.rbNomeEmpresario.Size = new System.Drawing.Size(201, 26);
            this.rbNomeEmpresario.TabIndex = 333;
            this.rbNomeEmpresario.TabStop = true;
            this.rbNomeEmpresario.Text = "Nome Empresário";
            this.rbNomeEmpresario.UseVisualStyleBackColor = true;
            this.rbNomeEmpresario.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // gbDataEsp
            // 
            this.gbDataEsp.BackColor = System.Drawing.Color.Gray;
            this.gbDataEsp.Controls.Add(this.label3);
            this.gbDataEsp.Controls.Add(this.cbData);
            this.gbDataEsp.Enabled = false;
            this.gbDataEsp.Location = new System.Drawing.Point(191, 352);
            this.gbDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Name = "gbDataEsp";
            this.gbDataEsp.Padding = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Size = new System.Drawing.Size(334, 110);
            this.gbDataEsp.TabIndex = 391;
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
            "Contratação",
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
            this.chkDataEsp.Font = new System.Drawing.Font("Quicksand Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDataEsp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkDataEsp.Location = new System.Drawing.Point(277, 326);
            this.chkDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.chkDataEsp.Name = "chkDataEsp";
            this.chkDataEsp.Size = new System.Drawing.Size(181, 26);
            this.chkDataEsp.TabIndex = 390;
            this.chkDataEsp.Text = "Data específica";
            this.chkDataEsp.UseVisualStyleBackColor = true;
            this.chkDataEsp.CheckedChanged += new System.EventHandler(this.chkDataEsp_CheckedChanged);
            // 
            // frmArtistaFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 587);
            this.Name = "frmArtistaFiltro";
            this.Text = "";
            this.Load += new System.EventHandler(this.CarregarCampos);
            ((System.ComponentModel.ISupportInitialize)(this.pbAplicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            this.pnFiltro.ResumeLayout(false);
            this.pnFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtF)).EndInit();
            this.gbArtF.ResumeLayout(false);
            this.gbArtF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).EndInit();
            this.gbArt.ResumeLayout(false);
            this.gbArt.PerformLayout();
            this.gbDoc.ResumeLayout(false);
            this.gbDoc.PerformLayout();
            this.gbDataEsp.ResumeLayout(false);
            this.gbDataEsp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbArtF;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.CheckBox chkArtF;
        private System.Windows.Forms.CheckBox chkArt;
        private System.Windows.Forms.GroupBox gbArtF;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.RadioButton rbTelefone;
        private System.Windows.Forms.PictureBox pbArt;
        private System.Windows.Forms.GroupBox gbArt;
        private System.Windows.Forms.CheckBox chkDoc;
        private System.Windows.Forms.GroupBox gbDoc;
        private System.Windows.Forms.RadioButton rbCNPJEmpresario;
        private System.Windows.Forms.RadioButton rbCPFEmpresario;
        private System.Windows.Forms.RadioButton rbNomeEmpresario;
        private System.Windows.Forms.GroupBox gbDataEsp;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.CheckBox chkDataEsp;
    }
}