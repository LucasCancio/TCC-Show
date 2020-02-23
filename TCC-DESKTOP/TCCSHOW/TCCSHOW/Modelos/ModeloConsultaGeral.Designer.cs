namespace TCCSHOW.Modelos
{
    partial class ModeloConsultaGeral
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbDesativar = new System.Windows.Forms.PictureBox();
            this.pbConsultar = new System.Windows.Forms.PictureBox();
            this.pbReativar = new System.Windows.Forms.PictureBox();
            this.pbAlterar = new System.Windows.Forms.PictureBox();
            this.pbExcluir = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.btnApresentar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnReativar = new System.Windows.Forms.Button();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.pbTitulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesativar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReativar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Quicksand", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(536, -6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(183, 72);
            this.lblTitulo.TabIndex = 56;
            this.lblTitulo.Text = "TEXTO";
            // 
            // pbDesativar
            // 
            this.pbDesativar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pbDesativar.Image = global::TCCSHOW.Properties.Resources.DesativarIcone;
            this.pbDesativar.Location = new System.Drawing.Point(631, 132);
            this.pbDesativar.Name = "pbDesativar";
            this.pbDesativar.Size = new System.Drawing.Size(31, 28);
            this.pbDesativar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDesativar.TabIndex = 55;
            this.pbDesativar.TabStop = false;
            // 
            // pbConsultar
            // 
            this.pbConsultar.BackColor = System.Drawing.Color.Blue;
            this.pbConsultar.Image = global::TCCSHOW.Properties.Resources.ProcurarIcone;
            this.pbConsultar.Location = new System.Drawing.Point(519, 175);
            this.pbConsultar.Name = "pbConsultar";
            this.pbConsultar.Size = new System.Drawing.Size(31, 28);
            this.pbConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConsultar.TabIndex = 54;
            this.pbConsultar.TabStop = false;
            // 
            // pbReativar
            // 
            this.pbReativar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbReativar.Image = global::TCCSHOW.Properties.Resources.AtivarIcone;
            this.pbReativar.Location = new System.Drawing.Point(518, 133);
            this.pbReativar.Name = "pbReativar";
            this.pbReativar.Size = new System.Drawing.Size(31, 28);
            this.pbReativar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReativar.TabIndex = 53;
            this.pbReativar.TabStop = false;
            // 
            // pbAlterar
            // 
            this.pbAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbAlterar.Image = global::TCCSHOW.Properties.Resources.EditarIcone;
            this.pbAlterar.Location = new System.Drawing.Point(521, 213);
            this.pbAlterar.Name = "pbAlterar";
            this.pbAlterar.Size = new System.Drawing.Size(31, 28);
            this.pbAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlterar.TabIndex = 52;
            this.pbAlterar.TabStop = false;
            // 
            // pbExcluir
            // 
            this.pbExcluir.BackColor = System.Drawing.Color.Red;
            this.pbExcluir.Image = global::TCCSHOW.Properties.Resources.ExcluirIcone;
            this.pbExcluir.Location = new System.Drawing.Point(521, 255);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(31, 28);
            this.pbExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExcluir.TabIndex = 51;
            this.pbExcluir.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.pbBuscar);
            this.groupBox2.Controls.Add(this.btnApresentar);
            this.groupBox2.Controls.Add(this.txtPesquisar);
            this.groupBox2.Location = new System.Drawing.Point(26, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 52);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // pbBuscar
            // 
            this.pbBuscar.BackColor = System.Drawing.Color.Silver;
            this.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscar.Image = global::TCCSHOW.Properties.Resources.ProcurarIcone;
            this.pbBuscar.Location = new System.Drawing.Point(353, 22);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(22, 20);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 45;
            this.pbBuscar.TabStop = false;
            // 
            // btnApresentar
            // 
            this.btnApresentar.BackColor = System.Drawing.Color.Silver;
            this.btnApresentar.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApresentar.Location = new System.Drawing.Point(353, 19);
            this.btnApresentar.Name = "btnApresentar";
            this.btnApresentar.Size = new System.Drawing.Size(112, 26);
            this.btnApresentar.TabIndex = 1;
            this.btnApresentar.Text = "Buscar";
            this.btnApresentar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(7, 19);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(344, 27);
            this.txtPesquisar.TabIndex = 0;
            // 
            // btnReativar
            // 
            this.btnReativar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReativar.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReativar.Location = new System.Drawing.Point(515, 130);
            this.btnReativar.Name = "btnReativar";
            this.btnReativar.Size = new System.Drawing.Size(110, 33);
            this.btnReativar.TabIndex = 50;
            this.btnReativar.Text = "Reativar";
            this.btnReativar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReativar.UseVisualStyleBackColor = false;
            // 
            // btnDesativar
            // 
            this.btnDesativar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDesativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesativar.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesativar.Location = new System.Drawing.Point(627, 128);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(121, 36);
            this.btnDesativar.TabIndex = 49;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesativar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(515, 250);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(234, 36);
            this.btnExcluir.TabIndex = 46;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(515, 208);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(234, 36);
            this.btnAlterar.TabIndex = 47;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Blue;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(515, 170);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(234, 36);
            this.btnConsultar.TabIndex = 48;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // pbTitulo
            // 
            this.pbTitulo.Location = new System.Drawing.Point(571, 68);
            this.pbTitulo.Name = "pbTitulo";
            this.pbTitulo.Size = new System.Drawing.Size(100, 50);
            this.pbTitulo.TabIndex = 57;
            this.pbTitulo.TabStop = false;
            // 
            // ModeloConsultaGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::TCCSHOW.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 345);
            this.Controls.Add(this.pbTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbDesativar);
            this.Controls.Add(this.pbConsultar);
            this.Controls.Add(this.pbReativar);
            this.Controls.Add(this.pbAlterar);
            this.Controls.Add(this.pbExcluir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReativar);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnConsultar);
            this.Name = "ModeloConsultaGeral";
            this.Text = "ModeloConsultaGeral";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.ModeloConsultaGeral_Load);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnDesativar, 0);
            this.Controls.SetChildIndex(this.btnReativar, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.pbExcluir, 0);
            this.Controls.SetChildIndex(this.pbAlterar, 0);
            this.Controls.SetChildIndex(this.pbReativar, 0);
            this.Controls.SetChildIndex(this.pbConsultar, 0);
            this.Controls.SetChildIndex(this.pbDesativar, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.pbTitulo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbDesativar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReativar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.PictureBox pbDesativar;
        public System.Windows.Forms.PictureBox pbConsultar;
        public System.Windows.Forms.PictureBox pbReativar;
        public System.Windows.Forms.PictureBox pbAlterar;
        public System.Windows.Forms.PictureBox pbExcluir;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.PictureBox pbBuscar;
        public System.Windows.Forms.Button btnApresentar;
        public System.Windows.Forms.TextBox txtPesquisar;
        public System.Windows.Forms.Button btnReativar;
        public System.Windows.Forms.Button btnDesativar;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.Button btnConsultar;
        public System.Windows.Forms.PictureBox pbTitulo;
    }
}