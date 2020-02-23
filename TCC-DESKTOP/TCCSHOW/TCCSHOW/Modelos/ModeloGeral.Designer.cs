namespace TCCSHOW.Modelos
{
    partial class ModeloGeral
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
            this.NomeNaBarra = new System.Windows.Forms.ToolStripLabel();
            this.horario = new System.Windows.Forms.ToolStripLabel();
            this.SuspendLayout();
            // 
            // NomeNaBarra
            // 
            this.NomeNaBarra.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeNaBarra.ForeColor = System.Drawing.Color.Red;
            this.NomeNaBarra.Name = "NomeNaBarra";
            this.NomeNaBarra.Size = new System.Drawing.Size(43, 22);
            this.NomeNaBarra.Text = "Nome";
            // 
            // horario
            // 
            this.horario.Name = "horario";
            this.horario.Size = new System.Drawing.Size(86, 22);
            this.horario.Text = "toolStripLabel1";
            // 
            // ModeloGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(598, 316);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModeloGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModeloGeral";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripLabel horario;
        //public System.Windows.Forms.ToolStripLabel Hora;
        public System.Windows.Forms.ToolStripLabel NomeNaBarra;
    }
}