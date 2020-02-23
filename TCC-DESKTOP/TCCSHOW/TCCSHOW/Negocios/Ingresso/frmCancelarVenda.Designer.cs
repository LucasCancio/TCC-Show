namespace TCCSHOW.Negocios.Ingresso
{
    partial class frmCancelarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelarVenda));
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.pbConfirmar = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pbReembolso = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.erro = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReembolso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(264, 267);
            this.txtMotivo.MaxLength = 120;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(603, 108);
            this.txtMotivo.TabIndex = 0;
            this.txtMotivo.Leave += new System.EventHandler(this.LeaveMaisculo);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Quicksand Bold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.ForeColor = System.Drawing.Color.White;
            this.lblMotivo.Location = new System.Drawing.Point(24, 303);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(176, 49);
            this.lblMotivo.TabIndex = 1;
            this.lblMotivo.Text = "Motivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Responsável:";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Enabled = false;
            this.txtResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsavel.Location = new System.Drawing.Point(357, 125);
            this.txtResponsavel.MaxLength = 30;
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(510, 45);
            this.txtResponsavel.TabIndex = 679;
            // 
            // pbConfirmar
            // 
            this.pbConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("pbConfirmar.Image")));
            this.pbConfirmar.Location = new System.Drawing.Point(482, 411);
            this.pbConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.pbConfirmar.Name = "pbConfirmar";
            this.pbConfirmar.Size = new System.Drawing.Size(64, 54);
            this.pbConfirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConfirmar.TabIndex = 683;
            this.pbConfirmar.TabStop = false;
            this.pbConfirmar.Click += new System.EventHandler(this.Confirmar);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(472, 403);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(227, 70);
            this.btnConfirmar.TabIndex = 682;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.Confirmar);
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.Color.Red;
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("pbCancelar.Image")));
            this.pbCancelar.Location = new System.Drawing.Point(246, 411);
            this.pbCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(64, 54);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancelar.TabIndex = 681;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(237, 403);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(227, 70);
            this.btnCancelar.TabIndex = 680;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand Bold", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(302, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 60);
            this.label4.TabIndex = 684;
            this.label4.Text = "Reembolso";
            // 
            // pbReembolso
            // 
            this.pbReembolso.BackColor = System.Drawing.Color.Transparent;
            this.pbReembolso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReembolso.Image = ((System.Drawing.Image)(resources.GetObject("pbReembolso.Image")));
            this.pbReembolso.Location = new System.Drawing.Point(621, 9);
            this.pbReembolso.Margin = new System.Windows.Forms.Padding(4);
            this.pbReembolso.Name = "pbReembolso";
            this.pbReembolso.Size = new System.Drawing.Size(79, 61);
            this.pbReembolso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReembolso.TabIndex = 685;
            this.pbReembolso.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(27, 212);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(367, 34);
            this.lblData.TabIndex = 686;
            this.lblData.Text = "Data de Cancelamento:";
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpData.Enabled = false;
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(438, 197);
            this.dtpData.Margin = new System.Windows.Forms.Padding(4);
            this.dtpData.MinDate = new System.DateTime(2017, 9, 13, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(429, 49);
            this.dtpData.TabIndex = 687;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(218, 303);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 36);
            this.label8.TabIndex = 688;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // erro
            // 
            this.erro.ContainerControl = this;
            // 
            // frmCancelarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(895, 495);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.pbReembolso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbConfirmar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.pbCancelar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.txtMotivo);
            this.Name = "frmCancelarVenda";
            this.Text = "";
            this.Load += new System.EventHandler(this.CarregarCampos);
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReembolso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pbConfirmar;
        public System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.PictureBox pbCancelar;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox pbReembolso;
        public System.Windows.Forms.TextBox txtMotivo;
        public System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label lblData;
        public System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ErrorProvider erro;
    }
}