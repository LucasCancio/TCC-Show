namespace TCCSHOW.Negocios.Filtros
{
    partial class frmFuncionarioFiltro
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
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbTelefone = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.gbDataEsp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.chkDataEsp = new System.Windows.Forms.CheckBox();
            this.gbFuncao = new System.Windows.Forms.GroupBox();
            this.cbFuncao = new System.Windows.Forms.ComboBox();
            this.chkFuncao = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAplicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            this.pnFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            this.gbPrincipal.SuspendLayout();
            this.gbDataEsp.SuspendLayout();
            this.gbFuncao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAplicar
            // 
            this.pbAplicar.Location = new System.Drawing.Point(116, 458);
            this.pbAplicar.Click += new System.EventHandler(this.Aplicar);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(98, 450);
            this.btnAplicar.Click += new System.EventHandler(this.Aplicar);
            // 
            // pbCancelar
            // 
            this.pbCancelar.Location = new System.Drawing.Point(275, 460);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(268, 451);
            // 
            // pnFiltro
            // 
            this.pnFiltro.Controls.Add(this.gbFuncao);
            this.pnFiltro.Controls.Add(this.gbDataEsp);
            this.pnFiltro.Controls.Add(this.chkDataEsp);
            this.pnFiltro.Controls.Add(this.gbPrincipal);
            this.pnFiltro.Size = new System.Drawing.Size(529, 507);
            this.pnFiltro.Controls.SetChildIndex(this.pbFiltro, 0);
            this.pnFiltro.Controls.SetChildIndex(this.lblFiltro, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbCancelar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnAplicar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbAplicar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbPrincipal, 0);
            this.pnFiltro.Controls.SetChildIndex(this.chkDataEsp, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbDataEsp, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbFuncao, 0);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Location = new System.Drawing.Point(231, 11);
            // 
            // pbFiltro
            // 
            this.pbFiltro.Location = new System.Drawing.Point(143, 3);
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.rbCodigo);
            this.gbPrincipal.Controls.Add(this.rbCPF);
            this.gbPrincipal.Controls.Add(this.rbTelefone);
            this.gbPrincipal.Controls.Add(this.rbEmail);
            this.gbPrincipal.Controls.Add(this.rbNome);
            this.gbPrincipal.Location = new System.Drawing.Point(58, 70);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(404, 109);
            this.gbPrincipal.TabIndex = 369;
            this.gbPrincipal.TabStop = false;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(35, 22);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(119, 32);
            this.rbCodigo.TabIndex = 375;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCPF.ForeColor = System.Drawing.Color.White;
            this.rbCPF.Location = new System.Drawing.Point(275, 22);
            this.rbCPF.Margin = new System.Windows.Forms.Padding(4);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(78, 32);
            this.rbCPF.TabIndex = 374;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbTelefone
            // 
            this.rbTelefone.AutoSize = true;
            this.rbTelefone.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTelefone.ForeColor = System.Drawing.Color.White;
            this.rbTelefone.Location = new System.Drawing.Point(196, 62);
            this.rbTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.rbTelefone.Name = "rbTelefone";
            this.rbTelefone.Size = new System.Drawing.Size(139, 32);
            this.rbTelefone.TabIndex = 372;
            this.rbTelefone.TabStop = true;
            this.rbTelefone.Text = "Telefone";
            this.rbTelefone.UseVisualStyleBackColor = true;
            this.rbTelefone.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmail.ForeColor = System.Drawing.Color.White;
            this.rbEmail.Location = new System.Drawing.Point(72, 62);
            this.rbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(98, 32);
            this.rbEmail.TabIndex = 373;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "Email";
            this.rbEmail.UseVisualStyleBackColor = true;
            this.rbEmail.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(162, 22);
            this.rbNome.Margin = new System.Windows.Forms.Padding(4);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(105, 32);
            this.rbNome.TabIndex = 343;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // gbDataEsp
            // 
            this.gbDataEsp.BackColor = System.Drawing.Color.Gray;
            this.gbDataEsp.Controls.Add(this.label3);
            this.gbDataEsp.Controls.Add(this.cbData);
            this.gbDataEsp.Enabled = false;
            this.gbDataEsp.Location = new System.Drawing.Point(98, 319);
            this.gbDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Name = "gbDataEsp";
            this.gbDataEsp.Padding = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Size = new System.Drawing.Size(334, 110);
            this.gbDataEsp.TabIndex = 371;
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
            "Nascimento",
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
            this.chkDataEsp.Location = new System.Drawing.Point(190, 292);
            this.chkDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.chkDataEsp.Name = "chkDataEsp";
            this.chkDataEsp.Size = new System.Drawing.Size(173, 28);
            this.chkDataEsp.TabIndex = 370;
            this.chkDataEsp.Text = "Data específica";
            this.chkDataEsp.UseVisualStyleBackColor = true;
            this.chkDataEsp.CheckedChanged += new System.EventHandler(this.chkDataEsp_CheckedChanged);
            // 
            // gbFuncao
            // 
            this.gbFuncao.Controls.Add(this.cbFuncao);
            this.gbFuncao.Controls.Add(this.chkFuncao);
            this.gbFuncao.Location = new System.Drawing.Point(58, 204);
            this.gbFuncao.Name = "gbFuncao";
            this.gbFuncao.Size = new System.Drawing.Size(404, 72);
            this.gbFuncao.TabIndex = 378;
            this.gbFuncao.TabStop = false;
            // 
            // cbFuncao
            // 
            this.cbFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncao.Enabled = false;
            this.cbFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncao.FormattingEnabled = true;
            this.cbFuncao.Items.AddRange(new object[] {
            "Data de Nascimento",
            "Data de Contratação"});
            this.cbFuncao.Location = new System.Drawing.Point(40, 28);
            this.cbFuncao.Margin = new System.Windows.Forms.Padding(4);
            this.cbFuncao.Name = "cbFuncao";
            this.cbFuncao.Size = new System.Drawing.Size(334, 33);
            this.cbFuncao.TabIndex = 375;
            // 
            // chkFuncao
            // 
            this.chkFuncao.AutoSize = true;
            this.chkFuncao.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFuncao.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkFuncao.Location = new System.Drawing.Point(102, -7);
            this.chkFuncao.Margin = new System.Windows.Forms.Padding(4);
            this.chkFuncao.Name = "chkFuncao";
            this.chkFuncao.Size = new System.Drawing.Size(209, 27);
            this.chkFuncao.TabIndex = 374;
            this.chkFuncao.Text = "Função específica";
            this.chkFuncao.UseVisualStyleBackColor = true;
            this.chkFuncao.CheckedChanged += new System.EventHandler(this.chkFuncao_CheckedChanged);
            // 
            // frmFuncionarioFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 545);
            this.Name = "frmFuncionarioFiltro";
            this.Text = "";
            this.Load += new System.EventHandler(this.CarregarCampos);
            ((System.ComponentModel.ISupportInitialize)(this.pbAplicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            this.pnFiltro.ResumeLayout(false);
            this.pnFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.gbDataEsp.ResumeLayout(false);
            this.gbDataEsp.PerformLayout();
            this.gbFuncao.ResumeLayout(false);
            this.gbFuncao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.GroupBox gbDataEsp;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.CheckBox chkDataEsp;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbTelefone;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.GroupBox gbFuncao;
        public System.Windows.Forms.ComboBox cbFuncao;
        private System.Windows.Forms.CheckBox chkFuncao;
        private System.Windows.Forms.RadioButton rbCodigo;
    }
}