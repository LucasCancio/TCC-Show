namespace TCCSHOW.Modelos
{
    partial class ModeloGeralCompleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeloGeralCompleto));
            this.erro = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.btnDeslogar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnRodape = new System.Windows.Forms.Panel();
            this.tool_ID = new System.Windows.Forms.Label();
            this.lblNomeTool = new System.Windows.Forms.Label();
            this.btnPerfil = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            this.pnCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeslogar)).BeginInit();
            this.pnRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // erro
            // 
            this.erro.ContainerControl = this;
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.BackColor = System.Drawing.Color.Black;
            this.pnCabecalho.Controls.Add(this.btnDeslogar);
            this.pnCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.pnCabecalho.Name = "pnCabecalho";
            this.pnCabecalho.Size = new System.Drawing.Size(991, 39);
            this.pnCabecalho.TabIndex = 7;
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeslogar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeslogar.Image")));
            this.btnDeslogar.ImageActive = null;
            this.btnDeslogar.Location = new System.Drawing.Point(948, 5);
            this.btnDeslogar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(43, 34);
            this.btnDeslogar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeslogar.TabIndex = 0;
            this.btnDeslogar.TabStop = false;
            this.btnDeslogar.Zoom = 10;
            // 
            // pnRodape
            // 
            this.pnRodape.BackColor = System.Drawing.Color.Black;
            this.pnRodape.Controls.Add(this.tool_ID);
            this.pnRodape.Controls.Add(this.lblNomeTool);
            this.pnRodape.Controls.Add(this.btnPerfil);
            this.pnRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnRodape.Location = new System.Drawing.Point(0, 494);
            this.pnRodape.Margin = new System.Windows.Forms.Padding(4);
            this.pnRodape.Name = "pnRodape";
            this.pnRodape.Size = new System.Drawing.Size(991, 39);
            this.pnRodape.TabIndex = 6;
            // 
            // tool_ID
            // 
            this.tool_ID.AutoSize = true;
            this.tool_ID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tool_ID.Location = new System.Drawing.Point(267, 14);
            this.tool_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tool_ID.Name = "tool_ID";
            this.tool_ID.Size = new System.Drawing.Size(46, 17);
            this.tool_ID.TabIndex = 4;
            this.tool_ID.Text = "label1";
            this.tool_ID.Visible = false;
            // 
            // lblNomeTool
            // 
            this.lblNomeTool.AutoSize = true;
            this.lblNomeTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTool.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomeTool.Location = new System.Drawing.Point(144, 5);
            this.lblNomeTool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeTool.Name = "lblNomeTool";
            this.lblNomeTool.Size = new System.Drawing.Size(68, 25);
            this.lblNomeTool.TabIndex = 2;
            this.lblNomeTool.Text = "Nome";
            this.lblNomeTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.ImageActive = null;
            this.btnPerfil.Location = new System.Drawing.Point(12, 1);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(43, 34);
            this.btnPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPerfil.TabIndex = 1;
            this.btnPerfil.TabStop = false;
            this.btnPerfil.Zoom = 10;
            // 
            // ModeloGeralCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::TCCSHOW.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(991, 533);
            this.Controls.Add(this.pnCabecalho);
            this.Controls.Add(this.pnRodape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModeloGeralCompleto";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModeloGeralCompleto_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            this.pnCabecalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDeslogar)).EndInit();
            this.pnRodape.ResumeLayout(false);
            this.pnRodape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ErrorProvider erro;
        //public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public System.Windows.Forms.Panel pnCabecalho;
        public Bunifu.Framework.UI.BunifuImageButton btnDeslogar;
        public System.Windows.Forms.Panel pnRodape;
        public System.Windows.Forms.Label tool_ID;
        public System.Windows.Forms.Label lblNomeTool;
        public Bunifu.Framework.UI.BunifuImageButton btnPerfil;
    }
}