namespace TCCSHOW.Negocios.Filtros
{
    partial class frmContasFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContasFiltro));
            this.gbDataEsp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.rbDepartamento = new System.Windows.Forms.RadioButton();
            this.rbValor = new System.Windows.Forms.RadioButton();
            this.gbTipoConta = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbPagar = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbReceber = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.chkSituacao = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipoPag = new System.Windows.Forms.ComboBox();
            this.chkTipoPag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAplicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            this.pnFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            this.gbDataEsp.SuspendLayout();
            this.gbPrincipal.SuspendLayout();
            this.gbTipoConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAplicar
            // 
            this.pbAplicar.Location = new System.Drawing.Point(213, 481);
            this.pbAplicar.Click += new System.EventHandler(this.Aplicar);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(199, 473);
            this.btnAplicar.Click += new System.EventHandler(this.Aplicar);
            // 
            // pbCancelar
            // 
            this.pbCancelar.Location = new System.Drawing.Point(378, 481);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(369, 474);
            // 
            // pnFiltro
            // 
            this.pnFiltro.Controls.Add(this.groupBox2);
            this.pnFiltro.Controls.Add(this.gbTipoConta);
            this.pnFiltro.Controls.Add(this.groupBox1);
            this.pnFiltro.Controls.Add(this.gbPrincipal);
            this.pnFiltro.Controls.Add(this.gbDataEsp);
            this.pnFiltro.Size = new System.Drawing.Size(782, 534);
            this.pnFiltro.Controls.SetChildIndex(this.gbDataEsp, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbPrincipal, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbFiltro, 0);
            this.pnFiltro.Controls.SetChildIndex(this.lblFiltro, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbCancelar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnAplicar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbAplicar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbTipoConta, 0);
            this.pnFiltro.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Location = new System.Drawing.Point(349, 19);
            // 
            // pbFiltro
            // 
            this.pbFiltro.Location = new System.Drawing.Point(261, 11);
            // 
            // gbDataEsp
            // 
            this.gbDataEsp.BackColor = System.Drawing.Color.Gray;
            this.gbDataEsp.Controls.Add(this.label3);
            this.gbDataEsp.Controls.Add(this.cbData);
            this.gbDataEsp.Location = new System.Drawing.Point(197, 333);
            this.gbDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Name = "gbDataEsp";
            this.gbDataEsp.Padding = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Size = new System.Drawing.Size(334, 110);
            this.gbDataEsp.TabIndex = 373;
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
            this.cbData.Location = new System.Drawing.Point(32, 55);
            this.cbData.Margin = new System.Windows.Forms.Padding(4);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(281, 33);
            this.cbData.TabIndex = 286;
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.rbCodigo);
            this.gbPrincipal.Controls.Add(this.rbDescricao);
            this.gbPrincipal.Controls.Add(this.rbDepartamento);
            this.gbPrincipal.Controls.Add(this.rbValor);
            this.gbPrincipal.Location = new System.Drawing.Point(22, 77);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(729, 69);
            this.gbPrincipal.TabIndex = 374;
            this.gbPrincipal.TabStop = false;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(32, 22);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(119, 32);
            this.rbCodigo.TabIndex = 345;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDescricao.ForeColor = System.Drawing.Color.White;
            this.rbDescricao.Location = new System.Drawing.Point(560, 22);
            this.rbDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(152, 32);
            this.rbDescricao.TabIndex = 344;
            this.rbDescricao.TabStop = true;
            this.rbDescricao.Text = "Descrição";
            this.rbDescricao.UseVisualStyleBackColor = true;
            this.rbDescricao.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbDepartamento
            // 
            this.rbDepartamento.AutoSize = true;
            this.rbDepartamento.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepartamento.ForeColor = System.Drawing.Color.White;
            this.rbDepartamento.Location = new System.Drawing.Point(325, 22);
            this.rbDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.rbDepartamento.Name = "rbDepartamento";
            this.rbDepartamento.Size = new System.Drawing.Size(210, 32);
            this.rbDepartamento.TabIndex = 342;
            this.rbDepartamento.TabStop = true;
            this.rbDepartamento.Text = "Departamento";
            this.rbDepartamento.UseVisualStyleBackColor = true;
            this.rbDepartamento.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbValor
            // 
            this.rbValor.AutoSize = true;
            this.rbValor.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbValor.ForeColor = System.Drawing.Color.White;
            this.rbValor.Location = new System.Drawing.Point(189, 22);
            this.rbValor.Margin = new System.Windows.Forms.Padding(4);
            this.rbValor.Name = "rbValor";
            this.rbValor.Size = new System.Drawing.Size(98, 32);
            this.rbValor.TabIndex = 343;
            this.rbValor.TabStop = true;
            this.rbValor.Text = "Valor";
            this.rbValor.UseVisualStyleBackColor = true;
            this.rbValor.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // gbTipoConta
            // 
            this.gbTipoConta.Controls.Add(this.label1);
            this.gbTipoConta.Controls.Add(this.pictureBox1);
            this.gbTipoConta.Controls.Add(this.rbPagar);
            this.gbTipoConta.Controls.Add(this.rbTodos);
            this.gbTipoConta.Controls.Add(this.rbReceber);
            this.gbTipoConta.Location = new System.Drawing.Point(51, 152);
            this.gbTipoConta.Name = "gbTipoConta";
            this.gbTipoConta.Size = new System.Drawing.Size(258, 164);
            this.gbTipoConta.TabIndex = 377;
            this.gbTipoConta.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quicksand Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(62, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 27);
            this.label1.TabIndex = 348;
            this.label1.Text = "Tipo de Conta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 347;
            this.pictureBox1.TabStop = false;
            // 
            // rbPagar
            // 
            this.rbPagar.AutoSize = true;
            this.rbPagar.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPagar.ForeColor = System.Drawing.Color.White;
            this.rbPagar.Location = new System.Drawing.Point(55, 122);
            this.rbPagar.Margin = new System.Windows.Forms.Padding(4);
            this.rbPagar.Name = "rbPagar";
            this.rbPagar.Size = new System.Drawing.Size(127, 32);
            this.rbPagar.TabIndex = 346;
            this.rbPagar.Text = "A Pagar";
            this.rbPagar.UseVisualStyleBackColor = true;
            this.rbPagar.CheckedChanged += new System.EventHandler(this.MudarSituacao);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.ForeColor = System.Drawing.Color.White;
            this.rbTodos.Location = new System.Drawing.Point(55, 84);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(4);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(107, 32);
            this.rbTodos.TabIndex = 345;
            this.rbTodos.Text = "Todas";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.MudarSituacao);
            // 
            // rbReceber
            // 
            this.rbReceber.AutoSize = true;
            this.rbReceber.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReceber.ForeColor = System.Drawing.Color.White;
            this.rbReceber.Location = new System.Drawing.Point(55, 44);
            this.rbReceber.Margin = new System.Windows.Forms.Padding(4);
            this.rbReceber.Name = "rbReceber";
            this.rbReceber.Size = new System.Drawing.Size(157, 32);
            this.rbReceber.TabIndex = 344;
            this.rbReceber.Text = "A Receber";
            this.rbReceber.UseVisualStyleBackColor = true;
            this.rbReceber.CheckedChanged += new System.EventHandler(this.MudarSituacao);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSituacao);
            this.groupBox2.Controls.Add(this.chkSituacao);
            this.groupBox2.Location = new System.Drawing.Point(391, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 76);
            this.groupBox2.TabIndex = 378;
            this.groupBox2.TabStop = false;
            // 
            // cbSituacao
            // 
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.Enabled = false;
            this.cbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "Situação"});
            this.cbSituacao.Location = new System.Drawing.Point(18, 25);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(298, 33);
            this.cbSituacao.TabIndex = 376;
            // 
            // chkSituacao
            // 
            this.chkSituacao.AutoSize = true;
            this.chkSituacao.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSituacao.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkSituacao.Location = new System.Drawing.Point(103, -2);
            this.chkSituacao.Margin = new System.Windows.Forms.Padding(4);
            this.chkSituacao.Name = "chkSituacao";
            this.chkSituacao.Size = new System.Drawing.Size(118, 27);
            this.chkSituacao.TabIndex = 375;
            this.chkSituacao.Text = "Situação";
            this.chkSituacao.UseVisualStyleBackColor = true;
            this.chkSituacao.CheckedChanged += new System.EventHandler(this.AbrirSituacao);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipoPag);
            this.groupBox1.Controls.Add(this.chkTipoPag);
            this.groupBox1.Location = new System.Drawing.Point(391, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 82);
            this.groupBox1.TabIndex = 377;
            this.groupBox1.TabStop = false;
            // 
            // cbTipoPag
            // 
            this.cbTipoPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPag.Enabled = false;
            this.cbTipoPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoPag.FormattingEnabled = true;
            this.cbTipoPag.Location = new System.Drawing.Point(18, 34);
            this.cbTipoPag.Name = "cbTipoPag";
            this.cbTipoPag.Size = new System.Drawing.Size(298, 33);
            this.cbTipoPag.TabIndex = 376;
            // 
            // chkTipoPag
            // 
            this.chkTipoPag.AutoSize = true;
            this.chkTipoPag.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTipoPag.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkTipoPag.Location = new System.Drawing.Point(66, 0);
            this.chkTipoPag.Margin = new System.Windows.Forms.Padding(4);
            this.chkTipoPag.Name = "chkTipoPag";
            this.chkTipoPag.Size = new System.Drawing.Size(227, 27);
            this.chkTipoPag.TabIndex = 375;
            this.chkTipoPag.Text = "Tipo de Pagamento";
            this.chkTipoPag.UseVisualStyleBackColor = true;
            this.chkTipoPag.CheckedChanged += new System.EventHandler(this.AbrirTipoPag);
            // 
            // frmContasFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 588);
            this.Name = "frmContasFiltro";
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
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.gbTipoConta.ResumeLayout(false);
            this.gbTipoConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDataEsp;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.RadioButton rbValor;
        private System.Windows.Forms.RadioButton rbDepartamento;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.GroupBox gbTipoConta;
        private System.Windows.Forms.RadioButton rbPagar;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbReceber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.CheckBox chkSituacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTipoPag;
        private System.Windows.Forms.CheckBox chkTipoPag;
    }
}