namespace TCCSHOW.Modelos
{
    partial class ModeloPadrao
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
            this.erro = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            this.SuspendLayout();
            // 
            // erro
            // 
            this.erro.ContainerControl = this;
            // 
            // ModeloPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCCSHOW.Properties.Resources.HAHAHA;
            this.ClientSize = new System.Drawing.Size(1576, 913);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModeloPadrao";
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ErrorProvider erro;
    }
}