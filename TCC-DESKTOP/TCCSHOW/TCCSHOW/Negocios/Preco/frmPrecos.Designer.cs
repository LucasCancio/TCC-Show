namespace TCCSHOW.Negocios.Preco
{
    partial class frmPrecos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrecos));
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPercentual = new System.Windows.Forms.GroupBox();
            this.cmAjuda = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbSalvar = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ttInf = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.gbPercentual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(263, 99);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(156, 105);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 392;
            this.pictureBox10.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Quicksand Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(427, 113);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(736, 91);
            this.lblTitulo.TabIndex = 391;
            this.lblTitulo.Text = "Gestão de Preços";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold);
            this.txtValor.Location = new System.Drawing.Point(55, 346);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.MaxLength = 5;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(407, 63);
            this.txtValor.TabIndex = 383;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Help;
            this.label7.Font = new System.Drawing.Font("Quicksand Bold", 25.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(99, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 49);
            this.label7.TabIndex = 384;
            this.label7.Text = "Percentual (%)";
            this.ttInf.SetToolTip(this.label7, "Acréscimo ao valor, em função do setor e do tipo de assento");
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.8F);
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Simples",
            "Duplo",
            "Especial"});
            this.cbTipo.Location = new System.Drawing.Point(55, 225);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(407, 66);
            this.cbTipo.TabIndex = 404;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.MudarTipo);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.8F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Ouro",
            "Prata"});
            this.cbCategoria.Location = new System.Drawing.Point(55, 93);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(407, 66);
            this.cbCategoria.TabIndex = 403;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.MudarCategoria);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quicksand Bold", 25.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(180, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 49);
            this.label1.TabIndex = 405;
            this.label1.Text = "Setor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Quicksand Bold", 25.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(88, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 49);
            this.label2.TabIndex = 406;
            this.label2.Text = "Tipo de Assento";
            // 
            // gbPercentual
            // 
            this.gbPercentual.BackColor = System.Drawing.Color.Transparent;
            this.gbPercentual.Controls.Add(this.txtValor);
            this.gbPercentual.Controls.Add(this.label2);
            this.gbPercentual.Controls.Add(this.label7);
            this.gbPercentual.Controls.Add(this.label1);
            this.gbPercentual.Controls.Add(this.cbCategoria);
            this.gbPercentual.Controls.Add(this.cbTipo);
            this.gbPercentual.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPercentual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbPercentual.Location = new System.Drawing.Point(521, 254);
            this.gbPercentual.Name = "gbPercentual";
            this.gbPercentual.Size = new System.Drawing.Size(525, 435);
            this.gbPercentual.TabIndex = 407;
            this.gbPercentual.TabStop = false;
            this.gbPercentual.Text = "Percentual dos Assentos";
            // 
            // cmAjuda
            // 
            this.cmAjuda.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmAjuda.Name = "cmAjuda";
            this.cmAjuda.Size = new System.Drawing.Size(61, 4);
            this.cmAjuda.Text = "Ajuda";
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("pbCancelar.Image")));
            this.pbCancelar.Location = new System.Drawing.Point(966, 727);
            this.pbCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(36, 55);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancelar.TabIndex = 421;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Quicksand Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(792, 719);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(221, 69);
            this.btnCancelar.TabIndex = 420;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // pbSalvar
            // 
            this.pbSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.pbSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pbSalvar.Image")));
            this.pbSalvar.Location = new System.Drawing.Point(710, 724);
            this.pbSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(51, 58);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalvar.TabIndex = 419;
            this.pbSalvar.TabStop = false;
            this.pbSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Quicksand Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvar.Location = new System.Drawing.Point(555, 718);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(221, 69);
            this.btnSalvar.TabIndex = 418;
            this.btnSalvar.Text = "Aplicar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "AssentoIcone4.png");
            this.imageList1.Images.SetKeyName(1, "AssentoIcone3.png");
            this.imageList1.Images.SetKeyName(2, "AssentoIcone2.png");
            // 
            // ttInf
            // 
            this.ttInf.AutomaticDelay = 300;
            this.ttInf.ShowAlways = true;
            this.ttInf.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttInf.ToolTipTitle = "Sobre:";
            // 
            // frmPrecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 913);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.pbCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbPercentual);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmPrecos";
            this.Text = "frmPrecos";
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.gbPercentual.ResumeLayout(false);
            this.gbPercentual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBox10;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cbTipo;
        public System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPercentual;
        public System.Windows.Forms.PictureBox pbCancelar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.PictureBox pbSalvar;
        public System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip cmAjuda;
        private System.Windows.Forms.ToolTip ttInf;
    }
}