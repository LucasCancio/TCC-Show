namespace TCCSHOW.Modelos
{
    partial class ModeloFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeloFiltro));
            this.pnFiltro = new System.Windows.Forms.Panel();
            this.pbAplicar = new System.Windows.Forms.PictureBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.pbFiltro = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            this.pnFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAplicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // pnFiltro
            // 
            this.pnFiltro.BackColor = System.Drawing.Color.Gray;
            this.pnFiltro.Controls.Add(this.pbAplicar);
            this.pnFiltro.Controls.Add(this.btnAplicar);
            this.pnFiltro.Controls.Add(this.pbCancelar);
            this.pnFiltro.Controls.Add(this.btnCancelar);
            this.pnFiltro.Controls.Add(this.lblFiltro);
            this.pnFiltro.Controls.Add(this.pbFiltro);
            this.pnFiltro.Location = new System.Drawing.Point(29, 26);
            this.pnFiltro.Name = "pnFiltro";
            this.pnFiltro.Size = new System.Drawing.Size(808, 559);
            this.pnFiltro.TabIndex = 0;
            // 
            // pbAplicar
            // 
            this.pbAplicar.BackColor = System.Drawing.Color.LimeGreen;
            this.pbAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAplicar.Image = ((System.Drawing.Image)(resources.GetObject("pbAplicar.Image")));
            this.pbAplicar.Location = new System.Drawing.Point(267, 519);
            this.pbAplicar.Margin = new System.Windows.Forms.Padding(4);
            this.pbAplicar.Name = "pbAplicar";
            this.pbAplicar.Size = new System.Drawing.Size(33, 28);
            this.pbAplicar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAplicar.TabIndex = 317;
            this.pbAplicar.TabStop = false;
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAplicar.Location = new System.Drawing.Point(249, 511);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(162, 44);
            this.btnAplicar.TabIndex = 316;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAplicar.UseVisualStyleBackColor = false;
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.Color.Red;
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("pbCancelar.Image")));
            this.pbCancelar.Location = new System.Drawing.Point(426, 521);
            this.pbCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(33, 28);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancelar.TabIndex = 315;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(419, 512);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(162, 44);
            this.btnCancelar.TabIndex = 314;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFiltro.Font = new System.Drawing.Font("Quicksand Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.Silver;
            this.lblFiltro.Location = new System.Drawing.Point(378, 24);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(156, 43);
            this.lblFiltro.TabIndex = 289;
            this.lblFiltro.Text = "FILTRO";
            // 
            // pbFiltro
            // 
            this.pbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.pbFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFiltro.Image = ((System.Drawing.Image)(resources.GetObject("pbFiltro.Image")));
            this.pbFiltro.ImageActive = null;
            this.pbFiltro.Location = new System.Drawing.Point(290, 16);
            this.pbFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.pbFiltro.Name = "pbFiltro";
            this.pbFiltro.Size = new System.Drawing.Size(80, 59);
            this.pbFiltro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFiltro.TabIndex = 288;
            this.pbFiltro.TabStop = false;
            this.pbFiltro.Zoom = 10;
            // 
            // ModeloFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 618);
            this.Controls.Add(this.pnFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModeloFiltro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModeloFiltro";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModeloFiltro_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            this.pnFiltro.ResumeLayout(false);
            this.pnFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAplicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pbAplicar;
        public System.Windows.Forms.Button btnAplicar;
        public System.Windows.Forms.PictureBox pbCancelar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Panel pnFiltro;
        public System.Windows.Forms.Label lblFiltro;
        public Bunifu.Framework.UI.BunifuImageButton pbFiltro;
    }
}