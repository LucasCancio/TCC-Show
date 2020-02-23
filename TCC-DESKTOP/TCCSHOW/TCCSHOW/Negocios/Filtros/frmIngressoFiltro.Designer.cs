namespace TCCSHOW.Negocios.Filtros
{
    partial class frmIngressoFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngressoFiltro));
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.rbCod = new System.Windows.Forms.RadioButton();
            this.rbValor = new System.Windows.Forms.RadioButton();
            this.rbTitulo = new System.Windows.Forms.RadioButton();
            this.gbDataEsp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.gbTipoConta = new System.Windows.Forms.GroupBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNumero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFileira = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAplicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            this.pnFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            this.gbPrincipal.SuspendLayout();
            this.gbDataEsp.SuspendLayout();
            this.gbTipoConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAplicar
            // 
            this.pbAplicar.Location = new System.Drawing.Point(182, 446);
            this.pbAplicar.Click += new System.EventHandler(this.Aplicar);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(164, 438);
            this.btnAplicar.Click += new System.EventHandler(this.Aplicar);
            // 
            // pbCancelar
            // 
            this.pbCancelar.Location = new System.Drawing.Point(341, 448);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(334, 439);
            // 
            // pnFiltro
            // 
            this.pnFiltro.Controls.Add(this.gbTipoConta);
            this.pnFiltro.Controls.Add(this.gbDataEsp);
            this.pnFiltro.Controls.Add(this.gbPrincipal);
            this.pnFiltro.Size = new System.Drawing.Size(657, 495);
            this.pnFiltro.Controls.SetChildIndex(this.gbPrincipal, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbDataEsp, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbFiltro, 0);
            this.pnFiltro.Controls.SetChildIndex(this.lblFiltro, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbCancelar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.btnAplicar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.pbAplicar, 0);
            this.pnFiltro.Controls.SetChildIndex(this.gbTipoConta, 0);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Location = new System.Drawing.Point(298, 21);
            // 
            // pbFiltro
            // 
            this.pbFiltro.Location = new System.Drawing.Point(203, 15);
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.rbCod);
            this.gbPrincipal.Controls.Add(this.rbValor);
            this.gbPrincipal.Controls.Add(this.rbTitulo);
            this.gbPrincipal.Location = new System.Drawing.Point(24, 101);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(607, 61);
            this.gbPrincipal.TabIndex = 372;
            this.gbPrincipal.TabStop = false;
            // 
            // rbCod
            // 
            this.rbCod.AutoSize = true;
            this.rbCod.Font = new System.Drawing.Font("Quicksand Bold Oblique", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCod.ForeColor = System.Drawing.Color.White;
            this.rbCod.Location = new System.Drawing.Point(440, 22);
            this.rbCod.Margin = new System.Windows.Forms.Padding(4);
            this.rbCod.Name = "rbCod";
            this.rbCod.Size = new System.Drawing.Size(141, 27);
            this.rbCod.TabIndex = 344;
            this.rbCod.Text = "Cód Venda";
            this.rbCod.UseVisualStyleBackColor = true;
            this.rbCod.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbValor
            // 
            this.rbValor.AutoSize = true;
            this.rbValor.Font = new System.Drawing.Font("Quicksand Bold Oblique", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbValor.ForeColor = System.Drawing.Color.White;
            this.rbValor.Location = new System.Drawing.Point(19, 22);
            this.rbValor.Margin = new System.Windows.Forms.Padding(4);
            this.rbValor.Name = "rbValor";
            this.rbValor.Size = new System.Drawing.Size(142, 27);
            this.rbValor.TabIndex = 343;
            this.rbValor.Text = "Valor Total";
            this.rbValor.UseVisualStyleBackColor = true;
            this.rbValor.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // rbTitulo
            // 
            this.rbTitulo.AutoSize = true;
            this.rbTitulo.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTitulo.ForeColor = System.Drawing.Color.White;
            this.rbTitulo.Location = new System.Drawing.Point(198, 20);
            this.rbTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.rbTitulo.Name = "rbTitulo";
            this.rbTitulo.Size = new System.Drawing.Size(211, 29);
            this.rbTitulo.TabIndex = 342;
            this.rbTitulo.Text = "Título do Evento";
            this.rbTitulo.UseVisualStyleBackColor = true;
            this.rbTitulo.CheckedChanged += new System.EventHandler(this.CheckedChangedGERAL);
            // 
            // gbDataEsp
            // 
            this.gbDataEsp.BackColor = System.Drawing.Color.Gray;
            this.gbDataEsp.Controls.Add(this.label3);
            this.gbDataEsp.Controls.Add(this.cbData);
            this.gbDataEsp.Location = new System.Drawing.Point(162, 310);
            this.gbDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Name = "gbDataEsp";
            this.gbDataEsp.Padding = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Size = new System.Drawing.Size(334, 110);
            this.gbDataEsp.TabIndex = 384;
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
            this.label3.Size = new System.Drawing.Size(203, 34);
            this.label3.TabIndex = 288;
            this.label3.Text = "DATA DO(a):";
            // 
            // cbData
            // 
            this.cbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbData.FormattingEnabled = true;
            this.cbData.Items.AddRange(new object[] {
            "Venda",
            "Evento"});
            this.cbData.Location = new System.Drawing.Point(32, 55);
            this.cbData.Margin = new System.Windows.Forms.Padding(4);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(281, 33);
            this.cbData.TabIndex = 286;
            // 
            // gbTipoConta
            // 
            this.gbTipoConta.Controls.Add(this.cbTipo);
            this.gbTipoConta.Controls.Add(this.label6);
            this.gbTipoConta.Controls.Add(this.cbCategoria);
            this.gbTipoConta.Controls.Add(this.label7);
            this.gbTipoConta.Controls.Add(this.cbNumero);
            this.gbTipoConta.Controls.Add(this.label5);
            this.gbTipoConta.Controls.Add(this.cbFileira);
            this.gbTipoConta.Controls.Add(this.label4);
            this.gbTipoConta.Controls.Add(this.label2);
            this.gbTipoConta.Controls.Add(this.pictureBox1);
            this.gbTipoConta.Location = new System.Drawing.Point(24, 182);
            this.gbTipoConta.Name = "gbTipoConta";
            this.gbTipoConta.Size = new System.Drawing.Size(607, 105);
            this.gbTipoConta.TabIndex = 385;
            this.gbTipoConta.TabStop = false;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Todos",
            "Duplo",
            "Especial",
            "Simples"});
            this.cbTipo.Location = new System.Drawing.Point(440, 63);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(159, 33);
            this.cbTipo.TabIndex = 356;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Quicksand Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(324, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 355;
            this.label6.Text = "Tipo:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Todas",
            "Ouro",
            "Prata",
            "Bronze"});
            this.cbCategoria.Location = new System.Drawing.Point(440, 15);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(160, 33);
            this.cbCategoria.TabIndex = 354;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.MudarCategoria);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Quicksand Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(324, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 27);
            this.label7.TabIndex = 353;
            this.label7.Text = "Setor:";
            // 
            // cbNumero
            // 
            this.cbNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumero.FormattingEnabled = true;
            this.cbNumero.Items.AddRange(new object[] {
            "Todos"});
            this.cbNumero.Location = new System.Drawing.Point(209, 63);
            this.cbNumero.Margin = new System.Windows.Forms.Padding(4);
            this.cbNumero.MaxDropDownItems = 5;
            this.cbNumero.Name = "cbNumero";
            this.cbNumero.Size = new System.Drawing.Size(102, 33);
            this.cbNumero.TabIndex = 352;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(110, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 351;
            this.label5.Text = "Número:";
            // 
            // cbFileira
            // 
            this.cbFileira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFileira.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFileira.FormattingEnabled = true;
            this.cbFileira.Items.AddRange(new object[] {
            "Todas",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.cbFileira.Location = new System.Drawing.Point(209, 17);
            this.cbFileira.Margin = new System.Windows.Forms.Padding(4);
            this.cbFileira.Name = "cbFileira";
            this.cbFileira.Size = new System.Drawing.Size(102, 33);
            this.cbFileira.TabIndex = 350;
            this.cbFileira.SelectedIndexChanged += new System.EventHandler(this.MudarColecoes);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Quicksand Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(109, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 27);
            this.label4.TabIndex = 349;
            this.label4.Text = "Fileira:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Quicksand Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(2, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 27);
            this.label2.TabIndex = 348;
            this.label2.Text = "Assento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 347;
            this.pictureBox1.TabStop = false;
            // 
            // frmIngressoFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 549);
            this.Name = "frmIngressoFiltro";
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
            this.gbTipoConta.ResumeLayout(false);
            this.gbTipoConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.RadioButton rbValor;
        private System.Windows.Forms.RadioButton rbTitulo;
        private System.Windows.Forms.GroupBox gbDataEsp;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.GroupBox gbTipoConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox cbNumero;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbFileira;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbCod;
    }
}