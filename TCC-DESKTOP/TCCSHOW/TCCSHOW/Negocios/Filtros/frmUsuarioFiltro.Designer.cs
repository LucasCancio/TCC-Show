namespace TCCSHOW.Negocios.Filtros
{
    partial class frmUsuarioFiltro
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
            this.gbFuncao = new System.Windows.Forms.GroupBox();
            this.cbTipoPessoa = new System.Windows.Forms.ComboBox();
            this.chkTipoPessoa = new System.Windows.Forms.CheckBox();
            this.gbDataEsp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            this.rbPergunta = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.chkDataEsp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAplicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            this.pnFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            this.gbFuncao.SuspendLayout();
            this.gbDataEsp.SuspendLayout();
            this.gbPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAplicar
            // 
            this.pbAplicar.Location = new System.Drawing.Point(99, 480);
            this.pbAplicar.Click += new System.EventHandler(this.Aplicar);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(81, 472);
            this.btnAplicar.Click += new System.EventHandler(this.Aplicar);
            // 
            // pbCancelar
            // 
            this.pbCancelar.Location = new System.Drawing.Point(258, 482);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(251, 473);
            // 
            // pnFiltro
            // 
            this.pnFiltro.Controls.Add(this.chkDataEsp);
            this.pnFiltro.Controls.Add(this.gbFuncao);
            this.pnFiltro.Controls.Add(this.gbDataEsp);
            this.pnFiltro.Controls.Add(this.gbPrincipal);
            this.pnFiltro.Size = new System.Drawing.Size(492, 533);
            this.pnFiltro.Controls.SetChildIndex(this.pbFiltro, 0);
            this.pnFiltro.Controls.SetChildIndex(this.lblFiltro, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbCancelar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnAplicar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbAplicar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbPrincipal, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbDataEsp, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbFuncao, 0);
            this.pnFiltro.Controls.SetChildIndex(this.chkDataEsp, 0);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Location = new System.Drawing.Point(217, 24);
            // 
            // pbFiltro
            // 
            this.pbFiltro.Location = new System.Drawing.Point(129, 16);
            // 
            // gbFuncao
            // 
            this.gbFuncao.Controls.Add(this.cbTipoPessoa);
            this.gbFuncao.Controls.Add(this.chkTipoPessoa);
            this.gbFuncao.Location = new System.Drawing.Point(81, 216);
            this.gbFuncao.Name = "gbFuncao";
            this.gbFuncao.Size = new System.Drawing.Size(332, 72);
            this.gbFuncao.TabIndex = 381;
            this.gbFuncao.TabStop = false;
            // 
            // cbTipoPessoa
            // 
            this.cbTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPessoa.Enabled = false;
            this.cbTipoPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoPessoa.FormattingEnabled = true;
            this.cbTipoPessoa.Items.AddRange(new object[] {
            "Funcionario",
            "Cliente"});
            this.cbTipoPessoa.Location = new System.Drawing.Point(18, 28);
            this.cbTipoPessoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoPessoa.Name = "cbTipoPessoa";
            this.cbTipoPessoa.Size = new System.Drawing.Size(304, 33);
            this.cbTipoPessoa.TabIndex = 375;
            this.cbTipoPessoa.SelectedIndexChanged += new System.EventHandler(this.cbTipoPessoa_SelectedIndexChanged);
            // 
            // chkTipoPessoa
            // 
            this.chkTipoPessoa.AutoSize = true;
            this.chkTipoPessoa.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTipoPessoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkTipoPessoa.Location = new System.Drawing.Point(20, -7);
            this.chkTipoPessoa.Margin = new System.Windows.Forms.Padding(4);
            this.chkTipoPessoa.Name = "chkTipoPessoa";
            this.chkTipoPessoa.Size = new System.Drawing.Size(291, 27);
            this.chkTipoPessoa.TabIndex = 374;
            this.chkTipoPessoa.Text = "Tipo de pessoa específico";
            this.chkTipoPessoa.UseVisualStyleBackColor = true;
            this.chkTipoPessoa.CheckedChanged += new System.EventHandler(this.chkTipoPessoa_CheckedChanged);
            // 
            // gbDataEsp
            // 
            this.gbDataEsp.BackColor = System.Drawing.Color.Gray;
            this.gbDataEsp.Controls.Add(this.label3);
            this.gbDataEsp.Controls.Add(this.cbData);
            this.gbDataEsp.Enabled = false;
            this.gbDataEsp.Location = new System.Drawing.Point(79, 343);
            this.gbDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Name = "gbDataEsp";
            this.gbDataEsp.Padding = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Size = new System.Drawing.Size(334, 110);
            this.gbDataEsp.TabIndex = 380;
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
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.rbCodigo);
            this.gbPrincipal.Controls.Add(this.rbUsuario);
            this.gbPrincipal.Controls.Add(this.rbPergunta);
            this.gbPrincipal.Controls.Add(this.rbNome);
            this.gbPrincipal.Location = new System.Drawing.Point(33, 82);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(440, 109);
            this.gbPrincipal.TabIndex = 379;
            this.gbPrincipal.TabStop = false;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(18, 24);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(119, 32);
            this.rbCodigo.TabIndex = 375;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbUsuario
            // 
            this.rbUsuario.AutoSize = true;
            this.rbUsuario.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUsuario.ForeColor = System.Drawing.Color.White;
            this.rbUsuario.Location = new System.Drawing.Point(296, 24);
            this.rbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(127, 32);
            this.rbUsuario.TabIndex = 372;
            this.rbUsuario.TabStop = true;
            this.rbUsuario.Text = "Usuário";
            this.rbUsuario.UseVisualStyleBackColor = true;
            this.rbUsuario.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbPergunta
            // 
            this.rbPergunta.AutoSize = true;
            this.rbPergunta.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPergunta.ForeColor = System.Drawing.Color.White;
            this.rbPergunta.Location = new System.Drawing.Point(73, 64);
            this.rbPergunta.Margin = new System.Windows.Forms.Padding(4);
            this.rbPergunta.Name = "rbPergunta";
            this.rbPergunta.Size = new System.Drawing.Size(247, 32);
            this.rbPergunta.TabIndex = 373;
            this.rbPergunta.TabStop = true;
            this.rbPergunta.Text = "Pergunta Secreta";
            this.rbPergunta.UseVisualStyleBackColor = true;
            this.rbPergunta.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(164, 24);
            this.rbNome.Margin = new System.Windows.Forms.Padding(4);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(105, 32);
            this.rbNome.TabIndex = 343;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // chkDataEsp
            // 
            this.chkDataEsp.AutoSize = true;
            this.chkDataEsp.Font = new System.Drawing.Font("Quicksand Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDataEsp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkDataEsp.Location = new System.Drawing.Point(154, 316);
            this.chkDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.chkDataEsp.Name = "chkDataEsp";
            this.chkDataEsp.Size = new System.Drawing.Size(181, 26);
            this.chkDataEsp.TabIndex = 382;
            this.chkDataEsp.Text = "Data específica";
            this.chkDataEsp.UseVisualStyleBackColor = true;
            this.chkDataEsp.CheckedChanged += new System.EventHandler(this.chkDataEsp_CheckedChanged);
            // 
            // frmUsuarioFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 587);
            this.Name = "frmUsuarioFiltro";
            this.Text = "";
            this.Load += new System.EventHandler(this.CarregarCampos);
            ((System.ComponentModel.ISupportInitialize)(this.pbAplicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            this.pnFiltro.ResumeLayout(false);
            this.pnFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            this.gbFuncao.ResumeLayout(false);
            this.gbFuncao.PerformLayout();
            this.gbDataEsp.ResumeLayout(false);
            this.gbDataEsp.PerformLayout();
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFuncao;
        public System.Windows.Forms.ComboBox cbTipoPessoa;
        private System.Windows.Forms.CheckBox chkTipoPessoa;
        private System.Windows.Forms.GroupBox gbDataEsp;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbUsuario;
        private System.Windows.Forms.RadioButton rbPergunta;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.CheckBox chkDataEsp;
    }
}