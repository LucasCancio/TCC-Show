namespace TCCSHOW.Negocios.Filtros
{
    partial class frmEventoFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventoFiltro));
            this.pbRemover = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkNArts = new System.Windows.Forms.CheckBox();
            this.gbTipoPag = new System.Windows.Forms.GroupBox();
            this.rbCache = new System.Windows.Forms.RadioButton();
            this.rbBilheteria = new System.Windows.Forms.RadioButton();
            this.chkTipoPag = new System.Windows.Forms.CheckBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.gbNArts = new System.Windows.Forms.GroupBox();
            this.nupNArt = new System.Windows.Forms.NumericUpDown();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbValor = new System.Windows.Forms.RadioButton();
            this.rbTitulo = new System.Windows.Forms.RadioButton();
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.gbArtEsp = new System.Windows.Forms.GroupBox();
            this.pbProcurarArtista = new System.Windows.Forms.PictureBox();
            this.btnProcurarArtista = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAplicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            this.pnFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemover)).BeginInit();
            this.gbTipoPag.SuspendLayout();
            this.gbNArts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNArt)).BeginInit();
            this.gbPrincipal.SuspendLayout();
            this.gbArtEsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcurarArtista)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAplicar
            // 
            this.pbAplicar.Location = new System.Drawing.Point(213, 394);
            this.pbAplicar.Click += new System.EventHandler(this.Aplicar);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(195, 386);
            this.btnAplicar.Click += new System.EventHandler(this.Aplicar);
            // 
            // pbCancelar
            // 
            this.pbCancelar.Location = new System.Drawing.Point(372, 396);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(365, 387);
            // 
            // pnFiltro
            // 
            this.pnFiltro.Controls.Add(this.pbRemover);
            this.pnFiltro.Controls.Add(this.label1);
            this.pnFiltro.Controls.Add(this.chkNArts);
            this.pnFiltro.Controls.Add(this.gbTipoPag);
            this.pnFiltro.Controls.Add(this.btnRemover);
            this.pnFiltro.Controls.Add(this.gbNArts);
            this.pnFiltro.Controls.Add(this.gbPrincipal);
            this.pnFiltro.Controls.Add(this.gbArtEsp);
            this.pnFiltro.Size = new System.Drawing.Size(762, 462);
            this.pnFiltro.Controls.SetChildIndex(this.pbFiltro, 0);
            this.pnFiltro.Controls.SetChildIndex(this.lblFiltro, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbCancelar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnAplicar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbAplicar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbArtEsp, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbPrincipal, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbNArts, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnRemover, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbTipoPag, 0);
            this.pnFiltro.Controls.SetChildIndex(this.chkNArts, 0);
            this.pnFiltro.Controls.SetChildIndex(this.label1, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbRemover, 0);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Location = new System.Drawing.Point(337, 28);
            // 
            // pbFiltro
            // 
            this.pbFiltro.Location = new System.Drawing.Point(249, 20);
            // 
            // pbRemover
            // 
            this.pbRemover.BackColor = System.Drawing.Color.Firebrick;
            this.pbRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRemover.Image = ((System.Drawing.Image)(resources.GetObject("pbRemover.Image")));
            this.pbRemover.Location = new System.Drawing.Point(545, 287);
            this.pbRemover.Margin = new System.Windows.Forms.Padding(4);
            this.pbRemover.Name = "pbRemover";
            this.pbRemover.Size = new System.Drawing.Size(29, 24);
            this.pbRemover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemover.TabIndex = 395;
            this.pbRemover.TabStop = false;
            this.pbRemover.Visible = false;
            this.pbRemover.Click += new System.EventHandler(this.RemoverArtista);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(262, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 27);
            this.label1.TabIndex = 388;
            this.label1.Text = "Artista específico";
            // 
            // chkNArts
            // 
            this.chkNArts.AutoSize = true;
            this.chkNArts.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNArts.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkNArts.Location = new System.Drawing.Point(58, 190);
            this.chkNArts.Margin = new System.Windows.Forms.Padding(4);
            this.chkNArts.Name = "chkNArts";
            this.chkNArts.Size = new System.Drawing.Size(225, 27);
            this.chkNArts.TabIndex = 390;
            this.chkNArts.Text = "Número de Artistas";
            this.chkNArts.UseVisualStyleBackColor = true;
            this.chkNArts.CheckedChanged += new System.EventHandler(this.chkNArts_CheckedChanged);
            // 
            // gbTipoPag
            // 
            this.gbTipoPag.Controls.Add(this.rbCache);
            this.gbTipoPag.Controls.Add(this.rbBilheteria);
            this.gbTipoPag.Controls.Add(this.chkTipoPag);
            this.gbTipoPag.Location = new System.Drawing.Point(384, 191);
            this.gbTipoPag.Name = "gbTipoPag";
            this.gbTipoPag.Size = new System.Drawing.Size(334, 72);
            this.gbTipoPag.TabIndex = 393;
            this.gbTipoPag.TabStop = false;
            // 
            // rbCache
            // 
            this.rbCache.AutoSize = true;
            this.rbCache.Enabled = false;
            this.rbCache.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCache.ForeColor = System.Drawing.Color.White;
            this.rbCache.Location = new System.Drawing.Point(172, 36);
            this.rbCache.Margin = new System.Windows.Forms.Padding(4);
            this.rbCache.Name = "rbCache";
            this.rbCache.Size = new System.Drawing.Size(141, 27);
            this.rbCache.TabIndex = 376;
            this.rbCache.TabStop = true;
            this.rbCache.Text = "Cachê Fixo";
            this.rbCache.UseVisualStyleBackColor = true;
            // 
            // rbBilheteria
            // 
            this.rbBilheteria.AutoSize = true;
            this.rbBilheteria.Checked = true;
            this.rbBilheteria.Enabled = false;
            this.rbBilheteria.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBilheteria.ForeColor = System.Drawing.Color.White;
            this.rbBilheteria.Location = new System.Drawing.Point(15, 36);
            this.rbBilheteria.Margin = new System.Windows.Forms.Padding(4);
            this.rbBilheteria.Name = "rbBilheteria";
            this.rbBilheteria.Size = new System.Drawing.Size(125, 27);
            this.rbBilheteria.TabIndex = 375;
            this.rbBilheteria.TabStop = true;
            this.rbBilheteria.Text = "Bilheteria";
            this.rbBilheteria.UseVisualStyleBackColor = true;
            // 
            // chkTipoPag
            // 
            this.chkTipoPag.AutoSize = true;
            this.chkTipoPag.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTipoPag.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkTipoPag.Location = new System.Drawing.Point(50, 1);
            this.chkTipoPag.Margin = new System.Windows.Forms.Padding(4);
            this.chkTipoPag.Name = "chkTipoPag";
            this.chkTipoPag.Size = new System.Drawing.Size(227, 27);
            this.chkTipoPag.TabIndex = 374;
            this.chkTipoPag.Text = "Tipo de Pagamento";
            this.chkTipoPag.UseVisualStyleBackColor = true;
            this.chkTipoPag.CheckedChanged += new System.EventHandler(this.chkTipoPag_CheckedChanged);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemover.Location = new System.Drawing.Point(535, 280);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(146, 40);
            this.btnRemover.TabIndex = 394;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Visible = false;
            this.btnRemover.Click += new System.EventHandler(this.RemoverArtista);
            // 
            // gbNArts
            // 
            this.gbNArts.Controls.Add(this.nupNArt);
            this.gbNArts.Enabled = false;
            this.gbNArts.Location = new System.Drawing.Point(96, 210);
            this.gbNArts.Name = "gbNArts";
            this.gbNArts.Size = new System.Drawing.Size(150, 53);
            this.gbNArts.TabIndex = 392;
            this.gbNArts.TabStop = false;
            // 
            // nupNArt
            // 
            this.nupNArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNArt.Location = new System.Drawing.Point(15, 16);
            this.nupNArt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNArt.Name = "nupNArt";
            this.nupNArt.Size = new System.Drawing.Size(115, 27);
            this.nupNArt.TabIndex = 374;
            this.nupNArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupNArt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.rbCodigo);
            this.gbPrincipal.Controls.Add(this.rbValor);
            this.gbPrincipal.Controls.Add(this.rbTitulo);
            this.gbPrincipal.Controls.Add(this.rbDescricao);
            this.gbPrincipal.Location = new System.Drawing.Point(23, 99);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(712, 70);
            this.gbPrincipal.TabIndex = 391;
            this.gbPrincipal.TabStop = false;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(51, 22);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(138, 36);
            this.rbCodigo.TabIndex = 346;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbValor
            // 
            this.rbValor.AutoSize = true;
            this.rbValor.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbValor.ForeColor = System.Drawing.Color.White;
            this.rbValor.Location = new System.Drawing.Point(574, 22);
            this.rbValor.Margin = new System.Windows.Forms.Padding(4);
            this.rbValor.Name = "rbValor";
            this.rbValor.Size = new System.Drawing.Size(111, 36);
            this.rbValor.TabIndex = 345;
            this.rbValor.TabStop = true;
            this.rbValor.Text = "Valor";
            this.rbValor.UseVisualStyleBackColor = true;
            this.rbValor.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbTitulo
            // 
            this.rbTitulo.AutoSize = true;
            this.rbTitulo.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTitulo.ForeColor = System.Drawing.Color.White;
            this.rbTitulo.Location = new System.Drawing.Point(219, 22);
            this.rbTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.rbTitulo.Name = "rbTitulo";
            this.rbTitulo.Size = new System.Drawing.Size(115, 36);
            this.rbTitulo.TabIndex = 343;
            this.rbTitulo.TabStop = true;
            this.rbTitulo.Text = "Título";
            this.rbTitulo.UseVisualStyleBackColor = true;
            this.rbTitulo.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDescricao.ForeColor = System.Drawing.Color.White;
            this.rbDescricao.Location = new System.Drawing.Point(361, 22);
            this.rbDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(173, 36);
            this.rbDescricao.TabIndex = 344;
            this.rbDescricao.TabStop = true;
            this.rbDescricao.Text = "Descrição";
            this.rbDescricao.UseVisualStyleBackColor = true;
            this.rbDescricao.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // gbArtEsp
            // 
            this.gbArtEsp.BackColor = System.Drawing.Color.Gray;
            this.gbArtEsp.Controls.Add(this.pbProcurarArtista);
            this.gbArtEsp.Controls.Add(this.btnProcurarArtista);
            this.gbArtEsp.Controls.Add(this.txtNome);
            this.gbArtEsp.Location = new System.Drawing.Point(74, 299);
            this.gbArtEsp.Margin = new System.Windows.Forms.Padding(4);
            this.gbArtEsp.Name = "gbArtEsp";
            this.gbArtEsp.Padding = new System.Windows.Forms.Padding(4);
            this.gbArtEsp.Size = new System.Drawing.Size(615, 70);
            this.gbArtEsp.TabIndex = 389;
            this.gbArtEsp.TabStop = false;
            // 
            // pbProcurarArtista
            // 
            this.pbProcurarArtista.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbProcurarArtista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProcurarArtista.Image = ((System.Drawing.Image)(resources.GetObject("pbProcurarArtista.Image")));
            this.pbProcurarArtista.Location = new System.Drawing.Point(477, 29);
            this.pbProcurarArtista.Margin = new System.Windows.Forms.Padding(4);
            this.pbProcurarArtista.Name = "pbProcurarArtista";
            this.pbProcurarArtista.Size = new System.Drawing.Size(23, 24);
            this.pbProcurarArtista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProcurarArtista.TabIndex = 302;
            this.pbProcurarArtista.TabStop = false;
            this.pbProcurarArtista.Click += new System.EventHandler(this.ProcurarArtista);
            // 
            // btnProcurarArtista
            // 
            this.btnProcurarArtista.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProcurarArtista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurarArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarArtista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcurarArtista.Location = new System.Drawing.Point(461, 20);
            this.btnProcurarArtista.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcurarArtista.Name = "btnProcurarArtista";
            this.btnProcurarArtista.Size = new System.Drawing.Size(146, 40);
            this.btnProcurarArtista.TabIndex = 301;
            this.btnProcurarArtista.Text = "Procurar";
            this.btnProcurarArtista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcurarArtista.UseVisualStyleBackColor = false;
            this.btnProcurarArtista.Click += new System.EventHandler(this.ProcurarArtista);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(8, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(446, 34);
            this.txtNome.TabIndex = 0;
            // 
            // frmEventoFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 513);
            this.Name = "frmEventoFiltro";
            this.Text = "";
            this.Load += new System.EventHandler(this.CarregarCampos);
            ((System.ComponentModel.ISupportInitialize)(this.pbAplicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            this.pnFiltro.ResumeLayout(false);
            this.pnFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemover)).EndInit();
            this.gbTipoPag.ResumeLayout(false);
            this.gbTipoPag.PerformLayout();
            this.gbNArts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupNArt)).EndInit();
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.gbArtEsp.ResumeLayout(false);
            this.gbArtEsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcurarArtista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pbRemover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkNArts;
        private System.Windows.Forms.GroupBox gbTipoPag;
        private System.Windows.Forms.RadioButton rbCache;
        private System.Windows.Forms.RadioButton rbBilheteria;
        private System.Windows.Forms.CheckBox chkTipoPag;
        public System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox gbNArts;
        private System.Windows.Forms.NumericUpDown nupNArt;
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbValor;
        private System.Windows.Forms.RadioButton rbTitulo;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.GroupBox gbArtEsp;
        public System.Windows.Forms.PictureBox pbProcurarArtista;
        public System.Windows.Forms.Button btnProcurarArtista;
        public System.Windows.Forms.TextBox txtNome;
    }
}