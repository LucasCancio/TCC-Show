namespace TCCSHOW.Negocios.Filtros
{
    partial class frmAgenteFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenteFiltro));
            this.gbDataEsp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.chkDataEsp = new System.Windows.Forms.CheckBox();
            this.gbEmpresario = new System.Windows.Forms.GroupBox();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbNomeSocial = new System.Windows.Forms.RadioButton();
            this.rbNomeCivil = new System.Windows.Forms.RadioButton();
            this.pbFisica = new System.Windows.Forms.PictureBox();
            this.pbJuridica = new System.Windows.Forms.PictureBox();
            this.gbEmpresa = new System.Windows.Forms.GroupBox();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.rbRazSocial = new System.Windows.Forms.RadioButton();
            this.rbNomeFant = new System.Windows.Forms.RadioButton();
            this.chkEmpresario = new System.Windows.Forms.CheckBox();
            this.chkEmpresa = new System.Windows.Forms.CheckBox();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbAplicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            this.pnFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            this.gbDataEsp.SuspendLayout();
            this.gbEmpresario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFisica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJuridica)).BeginInit();
            this.gbEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAplicar
            // 
            this.pbAplicar.Location = new System.Drawing.Point(251, 450);
            this.pbAplicar.Click += new System.EventHandler(this.Aplicar);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(233, 442);
            this.btnAplicar.Click += new System.EventHandler(this.Aplicar);
            // 
            // pbCancelar
            // 
            this.pbCancelar.Location = new System.Drawing.Point(411, 452);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(403, 443);
            // 
            // pnFiltro
            // 
            this.pnFiltro.Controls.Add(this.rbNome);
            this.pnFiltro.Controls.Add(this.rbCodigo);
            this.pnFiltro.Controls.Add(this.chkEmpresa);
            this.pnFiltro.Controls.Add(this.chkEmpresario);
            this.pnFiltro.Controls.Add(this.gbEmpresa);
            this.pnFiltro.Controls.Add(this.pbFisica);
            this.pnFiltro.Controls.Add(this.pbJuridica);
            this.pnFiltro.Controls.Add(this.gbEmpresario);
            this.pnFiltro.Controls.Add(this.gbDataEsp);
            this.pnFiltro.Controls.Add(this.chkDataEsp);
            this.pnFiltro.Size = new System.Drawing.Size(808, 500);
            this.pnFiltro.Controls.SetChildIndex(this.chkDataEsp, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbDataEsp, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbEmpresario, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbJuridica, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbFisica, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbEmpresa, 0);
            this.pnFiltro.Controls.SetChildIndex(this.chkEmpresario, 0);
            this.pnFiltro.Controls.SetChildIndex(this.chkEmpresa, 0);
            this.pnFiltro.Controls.SetChildIndex(this.rbCodigo, 0);
            this.pnFiltro.Controls.SetChildIndex(this.rbNome, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbFiltro, 0);
            this.pnFiltro.Controls.SetChildIndex(this.lblFiltro, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbCancelar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnAplicar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbAplicar, 0);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Location = new System.Drawing.Point(358, 12);
            // 
            // pbFiltro
            // 
            this.pbFiltro.Location = new System.Drawing.Point(284, 4);
            this.pbFiltro.Size = new System.Drawing.Size(66, 50);
            // 
            // gbDataEsp
            // 
            this.gbDataEsp.BackColor = System.Drawing.Color.Gray;
            this.gbDataEsp.Controls.Add(this.label3);
            this.gbDataEsp.Controls.Add(this.cbData);
            this.gbDataEsp.Enabled = false;
            this.gbDataEsp.Location = new System.Drawing.Point(231, 311);
            this.gbDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Name = "gbDataEsp";
            this.gbDataEsp.Padding = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Size = new System.Drawing.Size(334, 110);
            this.gbDataEsp.TabIndex = 319;
            this.gbDataEsp.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 34);
            this.label3.TabIndex = 288;
            this.label3.Text = "DATA DE:";
            // 
            // cbData
            // 
            this.cbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbData.FormattingEnabled = true;
            this.cbData.Items.AddRange(new object[] {
            "Contratação"});
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
            this.chkDataEsp.Location = new System.Drawing.Point(317, 285);
            this.chkDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.chkDataEsp.Name = "chkDataEsp";
            this.chkDataEsp.Size = new System.Drawing.Size(173, 28);
            this.chkDataEsp.TabIndex = 318;
            this.chkDataEsp.Text = "Data específica";
            this.chkDataEsp.UseVisualStyleBackColor = true;
            this.chkDataEsp.Visible = false;
            this.chkDataEsp.CheckedChanged += new System.EventHandler(this.chkDataEsp_CheckedChanged);
            // 
            // gbEmpresario
            // 
            this.gbEmpresario.Controls.Add(this.rbCPF);
            this.gbEmpresario.Controls.Add(this.rbNomeSocial);
            this.gbEmpresario.Controls.Add(this.rbNomeCivil);
            this.gbEmpresario.Location = new System.Drawing.Point(58, 129);
            this.gbEmpresario.Name = "gbEmpresario";
            this.gbEmpresario.Size = new System.Drawing.Size(216, 155);
            this.gbEmpresario.TabIndex = 327;
            this.gbEmpresario.TabStop = false;
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCPF.ForeColor = System.Drawing.Color.White;
            this.rbCPF.Location = new System.Drawing.Point(13, 19);
            this.rbCPF.Margin = new System.Windows.Forms.Padding(4);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(78, 32);
            this.rbCPF.TabIndex = 333;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbNomeSocial
            // 
            this.rbNomeSocial.AutoSize = true;
            this.rbNomeSocial.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNomeSocial.ForeColor = System.Drawing.Color.White;
            this.rbNomeSocial.Location = new System.Drawing.Point(13, 101);
            this.rbNomeSocial.Margin = new System.Windows.Forms.Padding(4);
            this.rbNomeSocial.Name = "rbNomeSocial";
            this.rbNomeSocial.Size = new System.Drawing.Size(185, 32);
            this.rbNomeSocial.TabIndex = 332;
            this.rbNomeSocial.TabStop = true;
            this.rbNomeSocial.Text = "Nome Social";
            this.rbNomeSocial.UseVisualStyleBackColor = true;
            this.rbNomeSocial.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbNomeCivil
            // 
            this.rbNomeCivil.AutoSize = true;
            this.rbNomeCivil.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNomeCivil.ForeColor = System.Drawing.Color.White;
            this.rbNomeCivil.Location = new System.Drawing.Point(13, 59);
            this.rbNomeCivil.Margin = new System.Windows.Forms.Padding(4);
            this.rbNomeCivil.Name = "rbNomeCivil";
            this.rbNomeCivil.Size = new System.Drawing.Size(163, 32);
            this.rbNomeCivil.TabIndex = 331;
            this.rbNomeCivil.TabStop = true;
            this.rbNomeCivil.Text = "Nome Civil";
            this.rbNomeCivil.UseVisualStyleBackColor = true;
            this.rbNomeCivil.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // pbFisica
            // 
            this.pbFisica.AccessibleDescription = "Empresário";
            this.pbFisica.BackColor = System.Drawing.Color.Transparent;
            this.pbFisica.Image = ((System.Drawing.Image)(resources.GetObject("pbFisica.Image")));
            this.pbFisica.Location = new System.Drawing.Point(269, 71);
            this.pbFisica.Margin = new System.Windows.Forms.Padding(4);
            this.pbFisica.Name = "pbFisica";
            this.pbFisica.Size = new System.Drawing.Size(32, 51);
            this.pbFisica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFisica.TabIndex = 331;
            this.pbFisica.TabStop = false;
            this.pbFisica.Click += new System.EventHandler(this.CheckedChange);
            // 
            // pbJuridica
            // 
            this.pbJuridica.AccessibleDescription = "Empresa/Agência";
            this.pbJuridica.BackColor = System.Drawing.Color.Transparent;
            this.pbJuridica.Image = ((System.Drawing.Image)(resources.GetObject("pbJuridica.Image")));
            this.pbJuridica.Location = new System.Drawing.Point(499, 71);
            this.pbJuridica.Margin = new System.Windows.Forms.Padding(4);
            this.pbJuridica.Name = "pbJuridica";
            this.pbJuridica.Size = new System.Drawing.Size(32, 51);
            this.pbJuridica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJuridica.TabIndex = 332;
            this.pbJuridica.TabStop = false;
            this.pbJuridica.Click += new System.EventHandler(this.CheckedChange);
            // 
            // gbEmpresa
            // 
            this.gbEmpresa.Controls.Add(this.rbCNPJ);
            this.gbEmpresa.Controls.Add(this.rbRazSocial);
            this.gbEmpresa.Controls.Add(this.rbNomeFant);
            this.gbEmpresa.Location = new System.Drawing.Point(533, 129);
            this.gbEmpresa.Name = "gbEmpresa";
            this.gbEmpresa.Size = new System.Drawing.Size(216, 155);
            this.gbEmpresa.TabIndex = 341;
            this.gbEmpresa.TabStop = false;
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCNPJ.ForeColor = System.Drawing.Color.White;
            this.rbCNPJ.Location = new System.Drawing.Point(11, 18);
            this.rbCNPJ.Margin = new System.Windows.Forms.Padding(4);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(97, 32);
            this.rbCNPJ.TabIndex = 343;
            this.rbCNPJ.TabStop = true;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            this.rbCNPJ.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbRazSocial
            // 
            this.rbRazSocial.AutoSize = true;
            this.rbRazSocial.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRazSocial.ForeColor = System.Drawing.Color.White;
            this.rbRazSocial.Location = new System.Drawing.Point(11, 101);
            this.rbRazSocial.Margin = new System.Windows.Forms.Padding(4);
            this.rbRazSocial.Name = "rbRazSocial";
            this.rbRazSocial.Size = new System.Drawing.Size(185, 32);
            this.rbRazSocial.TabIndex = 342;
            this.rbRazSocial.TabStop = true;
            this.rbRazSocial.Text = "Razão Social";
            this.rbRazSocial.UseVisualStyleBackColor = true;
            this.rbRazSocial.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbNomeFant
            // 
            this.rbNomeFant.AutoSize = true;
            this.rbNomeFant.Font = new System.Drawing.Font("Quicksand Bold Oblique", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNomeFant.ForeColor = System.Drawing.Color.White;
            this.rbNomeFant.Location = new System.Drawing.Point(11, 58);
            this.rbNomeFant.Margin = new System.Windows.Forms.Padding(4);
            this.rbNomeFant.Name = "rbNomeFant";
            this.rbNomeFant.Size = new System.Drawing.Size(181, 27);
            this.rbNomeFant.TabIndex = 341;
            this.rbNomeFant.TabStop = true;
            this.rbNomeFant.Text = "Nome Fantasia";
            this.rbNomeFant.UseVisualStyleBackColor = true;
            this.rbNomeFant.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // chkEmpresario
            // 
            this.chkEmpresario.AutoSize = true;
            this.chkEmpresario.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEmpresario.Font = new System.Drawing.Font("Quicksand Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmpresario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkEmpresario.Location = new System.Drawing.Point(68, 84);
            this.chkEmpresario.Name = "chkEmpresario";
            this.chkEmpresario.Size = new System.Drawing.Size(194, 31);
            this.chkEmpresario.TabIndex = 342;
            this.chkEmpresario.Text = "Pessoa Física";
            this.chkEmpresario.UseVisualStyleBackColor = true;
            this.chkEmpresario.CheckedChanged += new System.EventHandler(this.CheckedChange);
            // 
            // chkEmpresa
            // 
            this.chkEmpresa.AutoSize = true;
            this.chkEmpresa.Font = new System.Drawing.Font("Quicksand Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmpresa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkEmpresa.Location = new System.Drawing.Point(538, 84);
            this.chkEmpresa.Name = "chkEmpresa";
            this.chkEmpresa.Size = new System.Drawing.Size(223, 31);
            this.chkEmpresa.TabIndex = 343;
            this.chkEmpresa.Text = "Pessoa Jurídica";
            this.chkEmpresa.UseVisualStyleBackColor = true;
            this.chkEmpresa.CheckedChanged += new System.EventHandler(this.CheckedChange);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(338, 148);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(119, 32);
            this.rbCodigo.TabIndex = 346;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Quicksand Bold Oblique", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(297, 188);
            this.rbNome.Margin = new System.Windows.Forms.Padding(4);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(225, 26);
            this.rbNome.TabIndex = 347;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome Civil/Fantasia";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // frmAgenteFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 551);
            this.Name = "frmAgenteFiltro";
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
            this.gbEmpresario.ResumeLayout(false);
            this.gbEmpresario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFisica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJuridica)).EndInit();
            this.gbEmpresa.ResumeLayout(false);
            this.gbEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmpresario;
        private System.Windows.Forms.GroupBox gbDataEsp;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.CheckBox chkDataEsp;
        private System.Windows.Forms.PictureBox pbFisica;
        private System.Windows.Forms.PictureBox pbJuridica;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbNomeSocial;
        private System.Windows.Forms.RadioButton rbNomeCivil;
        private System.Windows.Forms.GroupBox gbEmpresa;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.RadioButton rbRazSocial;
        private System.Windows.Forms.RadioButton rbNomeFant;
        private System.Windows.Forms.CheckBox chkEmpresa;
        private System.Windows.Forms.CheckBox chkEmpresario;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCodigo;
    }
}