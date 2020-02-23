namespace TCCSHOW.Modelos
{
    partial class ModeloCadastroPadrao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeloCadastroPadrao));
            this.pbSalvar = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.gbCodigo = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbLimpar = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.gbCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSalvar
            // 
            this.pbSalvar.BackColor = System.Drawing.Color.PaleGreen;
            this.pbSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pbSalvar.Image")));
            this.pbSalvar.Location = new System.Drawing.Point(589, 833);
            this.pbSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(52, 43);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalvar.TabIndex = 299;
            this.pbSalvar.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.Location = new System.Drawing.Point(578, 814);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(192, 86);
            this.btnSalvar.TabIndex = 297;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.lblAtivo);
            this.groupBox4.Controls.Add(this.chkAtivo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1414, 83);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(148, 64);
            this.groupBox4.TabIndex = 296;
            this.groupBox4.TabStop = false;
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.BackColor = System.Drawing.Color.Transparent;
            this.lblAtivo.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAtivo.Location = new System.Drawing.Point(12, 25);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(122, 23);
            this.lblAtivo.TabIndex = 316;
            this.lblAtivo.Text = "Desativado";
            this.lblAtivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAtivo.Visible = false;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.ForeColor = System.Drawing.Color.White;
            this.chkAtivo.Location = new System.Drawing.Point(23, 21);
            this.chkAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(102, 35);
            this.chkAtivo.TabIndex = 1;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.CheckedChanged += new System.EventHandler(this.chkAtivo_CheckedChanged);
            // 
            // gbCodigo
            // 
            this.gbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.gbCodigo.Controls.Add(this.txtCodigo);
            this.gbCodigo.Controls.Add(this.label2);
            this.gbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCodigo.Location = new System.Drawing.Point(1371, 13);
            this.gbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.gbCodigo.Name = "gbCodigo";
            this.gbCodigo.Padding = new System.Windows.Forms.Padding(4);
            this.gbCodigo.Size = new System.Drawing.Size(192, 70);
            this.gbCodigo.TabIndex = 295;
            this.gbCodigo.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(80, 21);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(103, 37);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cod";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(701, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 37);
            this.label4.TabIndex = 305;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(368, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(593, 36);
            this.label6.TabIndex = 304;
            this.label6.Text = "Todos os campos com * são obrigatórios";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Location = new System.Drawing.Point(1036, 16);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(136, 106);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 303;
            this.pictureBox10.TabStop = false;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo2.Font = new System.Drawing.Font("Quicksand Bold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.Blue;
            this.lblTitulo2.Location = new System.Drawing.Point(787, 17);
            this.lblTitulo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(227, 68);
            this.lblTitulo2.TabIndex = 302;
            this.lblTitulo2.Text = "           ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Quicksand Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(369, 17);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(401, 68);
            this.lblTitulo.TabIndex = 301;
            this.lblTitulo.Text = "Cadastro de";
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.Color.Red;
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("pbCancelar.Image")));
            this.pbCancelar.Location = new System.Drawing.Point(814, 834);
            this.pbCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(39, 43);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancelar.TabIndex = 313;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(802, 814);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(192, 86);
            this.btnCancelar.TabIndex = 312;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // pbLimpar
            // 
            this.pbLimpar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pbLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLimpar.Image = ((System.Drawing.Image)(resources.GetObject("pbLimpar.Image")));
            this.pbLimpar.Location = new System.Drawing.Point(381, 836);
            this.pbLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.pbLimpar.Name = "pbLimpar";
            this.pbLimpar.Size = new System.Drawing.Size(48, 48);
            this.pbLimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLimpar.TabIndex = 315;
            this.pbLimpar.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(364, 814);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(192, 86);
            this.btnLimpar.TabIndex = 314;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // ModeloCadastroPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 913);
            this.Controls.Add(this.pbLimpar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pbCancelar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbCodigo);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = true;
            this.Name = "ModeloCadastroPadrao";
            this.Text = "ModeloCadastroPadrao";
            this.Load += new System.EventHandler(this.ModeloCadastroPadrao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbCodigo.ResumeLayout(false);
            this.gbCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pbSalvar;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.CheckBox chkAtivo;
        public System.Windows.Forms.GroupBox gbCodigo;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox pictureBox10;
        public System.Windows.Forms.Label lblTitulo2;
        public System.Windows.Forms.PictureBox pbCancelar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox pbLimpar;
        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Label lblAtivo;
    }
}