namespace TCCSHOW.Negocios.Assento
{
    partial class AssentoIngressos
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipo2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesativar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReativar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(23)))), ((int)(((byte)(117)))));
            this.lblTitulo.Location = new System.Drawing.Point(105, -5);
            this.lblTitulo.Size = new System.Drawing.Size(225, 72);
            this.lblTitulo.Text = "Ingresso";
            // 
            // pbDesativar
            // 
            this.pbDesativar.Location = new System.Drawing.Point(627, 108);
            this.pbDesativar.Size = new System.Drawing.Size(31, 27);
            // 
            // pbConsultar
            // 
            this.pbConsultar.Location = new System.Drawing.Point(515, 150);
            // 
            // pbReativar
            // 
            this.pbReativar.Location = new System.Drawing.Point(514, 108);
            this.pbReativar.Size = new System.Drawing.Size(31, 27);
            // 
            // pbAlterar
            // 
            this.pbAlterar.Image = global::TCCSHOW.Properties.Resources.EditarIconePreto;
            this.pbAlterar.Location = new System.Drawing.Point(517, 188);
            // 
            // pbExcluir
            // 
            this.pbExcluir.Location = new System.Drawing.Point(517, 230);
            this.pbExcluir.Size = new System.Drawing.Size(31, 27);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(12, 64);
            this.groupBox2.Size = new System.Drawing.Size(485, 77);
            // 
            // pbBuscar
            // 
            this.pbBuscar.Location = new System.Drawing.Point(384, 44);
            this.pbBuscar.Size = new System.Drawing.Size(29, 23);
            // 
            // btnApresentar
            // 
            this.btnApresentar.Location = new System.Drawing.Point(377, 41);
            this.btnApresentar.Size = new System.Drawing.Size(102, 30);
            this.btnApresentar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(7, 44);
            this.txtPesquisar.Size = new System.Drawing.Size(364, 27);
            // 
            // btnReativar
            // 
            this.btnReativar.Location = new System.Drawing.Point(511, 105);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(623, 105);
            this.btnDesativar.Size = new System.Drawing.Size(121, 34);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(511, 225);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(511, 183);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(511, 145);
            // 
            // pbTitulo
            // 
            this.pbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pbTitulo.Image = global::TCCSHOW.Properties.Resources.AssentoIconePadrao;
            this.pbTitulo.Location = new System.Drawing.Point(336, 6);
            this.pbTitulo.Size = new System.Drawing.Size(98, 61);
            this.pbTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(12, 147);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(485, 149);
            this.dgv.TabIndex = 58;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(510, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(234, 33);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(503, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 43);
            this.label2.TabIndex = 69;
            this.label2.Text = "Separar por:";
            // 
            // cbTipo2
            // 
            this.cbTipo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo2.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo2.FormattingEnabled = true;
            this.cbTipo2.Items.AddRange(new object[] {
            "Ambas",
            "Contas a Receber",
            "Contas a Pagar"});
            this.cbTipo2.Location = new System.Drawing.Point(531, 53);
            this.cbTipo2.Name = "cbTipo2";
            this.cbTipo2.Size = new System.Drawing.Size(211, 39);
            this.cbTipo2.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(12, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "Obs:   N.D  = Não Definido";
            // 
            // AssentoIngressos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 345);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipo2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgv);
            this.Name = "AssentoIngressos";
            this.Text = "AssentoIngressos";
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
            this.Controls.SetChildIndex(this.dgv, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.cbTipo2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbDesativar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReativar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipo2;
        private System.Windows.Forms.Label label3;
    }
}