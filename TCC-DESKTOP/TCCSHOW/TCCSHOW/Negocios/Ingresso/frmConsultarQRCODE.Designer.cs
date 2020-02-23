namespace TCCSHOW.Negocios.Ingresso
{
    partial class frmConsultarQRCODE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarQRCODE));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pbConsultar = new System.Windows.Forms.PictureBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbWebCan = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.cbWebCan = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.timerWebCan = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.pbConsultar);
            this.groupBox5.Controls.Add(this.btnConsultar);
            this.groupBox5.Controls.Add(this.pbCancelar);
            this.groupBox5.Controls.Add(this.btnCancelar);
            this.groupBox5.Controls.Add(this.pbWebCan);
            this.groupBox5.Location = new System.Drawing.Point(301, 224);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(879, 660);
            this.groupBox5.TabIndex = 681;
            this.groupBox5.TabStop = false;
            // 
            // pbConsultar
            // 
            this.pbConsultar.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConsultar.Image = ((System.Drawing.Image)(resources.GetObject("pbConsultar.Image")));
            this.pbConsultar.Location = new System.Drawing.Point(187, 550);
            this.pbConsultar.Name = "pbConsultar";
            this.pbConsultar.Size = new System.Drawing.Size(38, 41);
            this.pbConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConsultar.TabIndex = 689;
            this.pbConsultar.TabStop = false;
            this.pbConsultar.Visible = false;
            this.pbConsultar.Click += new System.EventHandler(this.Consultar);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Quicksand Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(169, 537);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(249, 67);
            this.btnConsultar.TabIndex = 688;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Visible = false;
            this.btnConsultar.Click += new System.EventHandler(this.Consultar);
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("pbCancelar.Image")));
            this.pbCancelar.Location = new System.Drawing.Point(442, 550);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(52, 41);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancelar.TabIndex = 687;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Visible = false;
            this.pbCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Quicksand Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(424, 537);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(249, 67);
            this.btnCancelar.TabIndex = 686;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // pbWebCan
            // 
            this.pbWebCan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbWebCan.Location = new System.Drawing.Point(3, 18);
            this.pbWebCan.Name = "pbWebCan";
            this.pbWebCan.Size = new System.Drawing.Size(873, 639);
            this.pbWebCan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWebCan.TabIndex = 0;
            this.pbWebCan.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Quicksand Bold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MediumBlue;
            this.label14.Location = new System.Drawing.Point(515, 75);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(535, 55);
            this.label14.TabIndex = 683;
            this.label14.Text = "Consulta de QRCODE";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(412, 58);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(114, 84);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 682;
            this.pictureBox7.TabStop = false;
            // 
            // cbWebCan
            // 
            this.cbWebCan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWebCan.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWebCan.FormattingEnabled = true;
            this.cbWebCan.Location = new System.Drawing.Point(536, 164);
            this.cbWebCan.Name = "cbWebCan";
            this.cbWebCan.Size = new System.Drawing.Size(567, 42);
            this.cbWebCan.TabIndex = 684;
            this.cbWebCan.SelectedIndexChanged += new System.EventHandler(this.cbWebCan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(337, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 685;
            this.label1.Text = "Dispositivo:";
            // 
            // timerWebCan
            // 
            this.timerWebCan.Enabled = true;
            this.timerWebCan.Interval = 300;
            this.timerWebCan.Tick += new System.EventHandler(this.Scannear);
            // 
            // frmConsultarQRCODE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 913);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbWebCan);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.groupBox5);
            this.Name = "frmConsultarQRCODE";
            this.Text = "frmConsultarQRCODE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultarQRCODE_FormClosing);
            this.Load += new System.EventHandler(this.CarregarCampos);
            this.VisibleChanged += new System.EventHandler(this.frmConsultarQRCODE_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ComboBox cbWebCan;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pbCancelar;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbWebCan;
        private System.Windows.Forms.Timer timerWebCan;
        public System.Windows.Forms.PictureBox pbConsultar;
        public System.Windows.Forms.Button btnConsultar;
    }
}