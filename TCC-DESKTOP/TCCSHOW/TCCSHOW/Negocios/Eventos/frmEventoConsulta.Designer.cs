namespace TCCSHOW.Negocios.Eventos
{
    partial class frmEventoConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventoConsulta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gbFiltro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesativar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReativar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).BeginInit();
            this.pnDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCtrlF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDesativar
            // 
            this.pbDesativar.Click += new System.EventHandler(this.FixarStatusPb);
            // 
            // pbConsultar
            // 
            this.pbConsultar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // pbReativar
            // 
            this.pbReativar.Click += new System.EventHandler(this.FixarStatusPb);
            // 
            // pbAlterar
            // 
            this.pbAlterar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // pbExcluir
            // 
            this.pbExcluir.Click += new System.EventHandler(this.FixarStatusPb);
            // 
            // btnReativar
            // 
            this.btnReativar.Click += new System.EventHandler(this.FixarStatus);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Click += new System.EventHandler(this.FixarStatus);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.FixarStatus);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // pnDGV
            // 
            this.pnDGV.Controls.Add(this.dgv);
            this.pnDGV.Size = new System.Drawing.Size(1538, 566);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(1168, 8);
            this.pictureBox10.Size = new System.Drawing.Size(128, 80);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(187)))), ((int)(((byte)(22)))));
            this.lblTitulo2.Size = new System.Drawing.Size(265, 68);
            this.lblTitulo2.Text = "Eventos";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Size = new System.Drawing.Size(668, 73);
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmEventoConsulta_KeyPress);
            // 
            // rbTodos
            // 
            this.rbTodos.Click += new System.EventHandler(this.Exibir);
            // 
            // rbDesativa
            // 
            this.rbDesativa.Click += new System.EventHandler(this.Exibir);
            // 
            // rbAtiva
            // 
            this.rbAtiva.Click += new System.EventHandler(this.Exibir);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.Exibir);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Click += new System.EventHandler(this.Exibir);
            // 
            // txtPesquisarMask
            // 
            this.txtPesquisarMask.Size = new System.Drawing.Size(668, 69);
            this.txtPesquisarMask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmEventoConsulta_KeyPress);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Click += new System.EventHandler(this.AbrirFiltro);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Click += new System.EventHandler(this.AbrirFiltro);
            // 
            // lblHorario
            // 
            this.lblHorario.Visible = true;
            // 
            // dtpHorarioInicio
            // 
            this.dtpHorarioInicio.Visible = true;
            this.dtpHorarioInicio.ValueChanged += new System.EventHandler(this.Exibir);
            // 
            // dtpHorarioFinal
            // 
            this.dtpHorarioFinal.Visible = true;
            this.dtpHorarioFinal.ValueChanged += new System.EventHandler(this.Exibir);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Quicksand Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Quicksand Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1538, 566);
            this.dgv.TabIndex = 4;
            this.dgv.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgv_ColumnAdded);
            this.dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmEventoConsulta_KeyPress);
            // 
            // frmEventoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 913);
            this.Name = "frmEventoConsulta";
            this.Text = "frmEventoConsulta";
            this.Load += new System.EventHandler(this.Exibir);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmEventoConsulta_KeyPress);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesativar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReativar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).EndInit();
            this.pnDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCtrlF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
    }
}