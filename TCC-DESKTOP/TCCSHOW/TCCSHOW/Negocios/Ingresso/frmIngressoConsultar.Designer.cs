namespace TCCSHOW.Negocios.Ingresso
{
    partial class frmIngressoConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngressoConsultar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbReembolso = new System.Windows.Forms.PictureBox();
            this.btnReembolso = new System.Windows.Forms.Button();
            this.menuReembolso = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsReembolso = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.rbAPagar = new System.Windows.Forms.RadioButton();
            this.rbCancelados = new System.Windows.Forms.RadioButton();
            this.rbPagos = new System.Windows.Forms.RadioButton();
            this.lblAlertaReemb = new System.Windows.Forms.Label();
            this.pbAlertaReemb = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbReembolso)).BeginInit();
            this.menuReembolso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlertaReemb)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAPagar);
            this.groupBox2.Controls.Add(this.rbCancelados);
            this.groupBox2.Controls.Add(this.rbPagos);
            this.groupBox2.Controls.SetChildIndex(this.rbPagos, 0);
            this.groupBox2.Controls.SetChildIndex(this.rbCancelados, 0);
            this.groupBox2.Controls.SetChildIndex(this.rbAPagar, 0);
            this.groupBox2.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.groupBox2.Controls.SetChildIndex(this.rbAtiva, 0);
            this.groupBox2.Controls.SetChildIndex(this.rbDesativa, 0);
            this.groupBox2.Controls.SetChildIndex(this.rbTodos, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnBuscar, 0);
            this.groupBox2.Controls.SetChildIndex(this.pictureBox1, 0);
            this.groupBox2.Controls.SetChildIndex(this.txtPesquisarMask, 0);
            this.groupBox2.Controls.SetChildIndex(this.dtpHorarioFinal, 0);
            this.groupBox2.Controls.SetChildIndex(this.dtpHorarioInicio, 0);
            this.groupBox2.Controls.SetChildIndex(this.lblHorario, 0);
            // 
            // pbDesativar
            // 
            this.pbDesativar.Location = new System.Drawing.Point(751, 825);
            this.pbDesativar.Size = new System.Drawing.Size(10, 10);
            this.pbDesativar.Visible = false;
            // 
            // pbConsultar
            // 
            this.pbConsultar.Location = new System.Drawing.Point(656, 833);
            this.pbConsultar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // pbReativar
            // 
            this.pbReativar.Location = new System.Drawing.Point(509, 824);
            this.pbReativar.Size = new System.Drawing.Size(10, 10);
            this.pbReativar.Visible = false;
            // 
            // pbAlterar
            // 
            this.pbAlterar.Size = new System.Drawing.Size(1, 1);
            this.pbAlterar.Visible = false;
            // 
            // pbExcluir
            // 
            this.pbExcluir.Location = new System.Drawing.Point(266, 846);
            this.pbExcluir.Size = new System.Drawing.Size(1, 1);
            this.pbExcluir.Visible = false;
            // 
            // btnReativar
            // 
            this.btnReativar.Location = new System.Drawing.Point(500, 817);
            this.btnReativar.Size = new System.Drawing.Size(10, 10);
            this.btnReativar.Visible = false;
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(739, 817);
            this.btnDesativar.Size = new System.Drawing.Size(10, 10);
            this.btnDesativar.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(254, 837);
            this.btnExcluir.Size = new System.Drawing.Size(1, 1);
            this.btnExcluir.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Size = new System.Drawing.Size(1, 1);
            this.btnAlterar.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(647, 825);
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
            this.pictureBox10.Location = new System.Drawing.Point(1227, 20);
            this.pictureBox10.Size = new System.Drawing.Size(116, 85);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.ForeColor = System.Drawing.Color.Indigo;
            this.lblTitulo2.Size = new System.Drawing.Size(314, 68);
            this.lblTitulo2.Text = "Ingressos";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Size = new System.Drawing.Size(599, 73);
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmIngressoConsulta_KeyPress);
            // 
            // rbTodos
            // 
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(1094, 49);
            this.rbTodos.TabStop = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.Exibir);
            this.rbTodos.Click += new System.EventHandler(this.Exibir);
            // 
            // rbDesativa
            // 
            this.rbDesativa.AutoSize = false;
            this.rbDesativa.Location = new System.Drawing.Point(1191, 11);
            this.rbDesativa.Size = new System.Drawing.Size(10, 10);
            this.rbDesativa.Text = "";
            this.rbDesativa.Visible = false;
            this.rbDesativa.CheckedChanged += new System.EventHandler(this.Exibir);
            // 
            // rbAtiva
            // 
            this.rbAtiva.AutoSize = false;
            this.rbAtiva.Checked = false;
            this.rbAtiva.Location = new System.Drawing.Point(1191, 6);
            this.rbAtiva.Size = new System.Drawing.Size(10, 10);
            this.rbAtiva.TabStop = false;
            this.rbAtiva.Text = "";
            this.rbAtiva.Visible = false;
            this.rbAtiva.CheckedChanged += new System.EventHandler(this.Exibir);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(781, 28);
            this.btnBuscar.Click += new System.EventHandler(this.Exibir);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(800, 38);
            this.pictureBox1.Click += new System.EventHandler(this.Exibir);
            // 
            // txtPesquisarMask
            // 
            this.txtPesquisarMask.Size = new System.Drawing.Size(599, 69);
            this.txtPesquisarMask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmIngressoConsulta_KeyPress);
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
            this.lblHorario.Location = new System.Drawing.Point(686, 48);
            this.lblHorario.Visible = true;
            // 
            // dtpHorarioInicio
            // 
            this.dtpHorarioInicio.Location = new System.Drawing.Point(631, 20);
            this.dtpHorarioInicio.Visible = true;
            this.dtpHorarioInicio.ValueChanged += new System.EventHandler(this.Exibir);
            // 
            // dtpHorarioFinal
            // 
            this.dtpHorarioFinal.Location = new System.Drawing.Point(631, 74);
            this.dtpHorarioFinal.Visible = true;
            this.dtpHorarioFinal.ValueChanged += new System.EventHandler(this.Exibir);
            // 
            // lblCTRLF
            // 
            this.lblCTRLF.Location = new System.Drawing.Point(95, 823);
            // 
            // pbCtrlF
            // 
            this.pbCtrlF.Location = new System.Drawing.Point(51, 817);
            // 
            // pbReembolso
            // 
            this.pbReembolso.BackColor = System.Drawing.Color.LimeGreen;
            this.pbReembolso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReembolso.Image = ((System.Drawing.Image)(resources.GetObject("pbReembolso.Image")));
            this.pbReembolso.Location = new System.Drawing.Point(891, 833);
            this.pbReembolso.Margin = new System.Windows.Forms.Padding(4);
            this.pbReembolso.Name = "pbReembolso";
            this.pbReembolso.Size = new System.Drawing.Size(54, 54);
            this.pbReembolso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReembolso.TabIndex = 304;
            this.pbReembolso.TabStop = false;
            this.pbReembolso.Visible = false;
            this.pbReembolso.Click += new System.EventHandler(this.CancelarVenda);
            // 
            // btnReembolso
            // 
            this.btnReembolso.BackColor = System.Drawing.Color.LimeGreen;
            this.btnReembolso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReembolso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReembolso.Location = new System.Drawing.Point(882, 825);
            this.btnReembolso.Margin = new System.Windows.Forms.Padding(4);
            this.btnReembolso.Name = "btnReembolso";
            this.btnReembolso.Size = new System.Drawing.Size(227, 70);
            this.btnReembolso.TabIndex = 303;
            this.btnReembolso.Text = "Reembolsar";
            this.btnReembolso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReembolso.UseVisualStyleBackColor = false;
            this.btnReembolso.Visible = false;
            this.btnReembolso.Click += new System.EventHandler(this.CancelarVenda);
            // 
            // menuReembolso
            // 
            this.menuReembolso.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuReembolso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsReembolso});
            this.menuReembolso.Name = "menuAssento";
            this.menuReembolso.Size = new System.Drawing.Size(288, 30);
            // 
            // tsReembolso
            // 
            this.tsReembolso.BackColor = System.Drawing.Color.LimeGreen;
            this.tsReembolso.Font = new System.Drawing.Font("Quicksand Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsReembolso.ForeColor = System.Drawing.Color.White;
            this.tsReembolso.Image = ((System.Drawing.Image)(resources.GetObject("tsReembolso.Image")));
            this.tsReembolso.Name = "tsReembolso";
            this.tsReembolso.Size = new System.Drawing.Size(287, 26);
            this.tsReembolso.Text = "Consultar Reembolso";
            this.tsReembolso.Click += new System.EventHandler(this.ConsultarReembolso);
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
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Quicksand Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1538, 566);
            this.dgv.TabIndex = 5;
            this.dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmIngressoConsulta_KeyPress);
            // 
            // rbAPagar
            // 
            this.rbAPagar.AutoSize = true;
            this.rbAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAPagar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbAPagar.Location = new System.Drawing.Point(967, 47);
            this.rbAPagar.Margin = new System.Windows.Forms.Padding(4);
            this.rbAPagar.Name = "rbAPagar";
            this.rbAPagar.Size = new System.Drawing.Size(104, 28);
            this.rbAPagar.TabIndex = 310;
            this.rbAPagar.Text = "A pagar";
            this.rbAPagar.UseVisualStyleBackColor = true;
            this.rbAPagar.Click += new System.EventHandler(this.Exibir);
            // 
            // rbCancelados
            // 
            this.rbCancelados.AutoSize = true;
            this.rbCancelados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCancelados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbCancelados.Location = new System.Drawing.Point(967, 76);
            this.rbCancelados.Margin = new System.Windows.Forms.Padding(4);
            this.rbCancelados.Name = "rbCancelados";
            this.rbCancelados.Size = new System.Drawing.Size(141, 28);
            this.rbCancelados.TabIndex = 309;
            this.rbCancelados.Text = "Cancelados";
            this.rbCancelados.UseVisualStyleBackColor = true;
            this.rbCancelados.Click += new System.EventHandler(this.Exibir);
            // 
            // rbPagos
            // 
            this.rbPagos.AutoSize = true;
            this.rbPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPagos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbPagos.Location = new System.Drawing.Point(967, 18);
            this.rbPagos.Margin = new System.Windows.Forms.Padding(4);
            this.rbPagos.Name = "rbPagos";
            this.rbPagos.Size = new System.Drawing.Size(89, 28);
            this.rbPagos.TabIndex = 308;
            this.rbPagos.Text = "Pagos";
            this.rbPagos.UseVisualStyleBackColor = true;
            this.rbPagos.Click += new System.EventHandler(this.Exibir);
            // 
            // lblAlertaReemb
            // 
            this.lblAlertaReemb.AutoSize = true;
            this.lblAlertaReemb.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaReemb.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblAlertaReemb.Font = new System.Drawing.Font("Quicksand Bold Oblique", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaReemb.ForeColor = System.Drawing.Color.LightGray;
            this.lblAlertaReemb.Location = new System.Drawing.Point(95, 869);
            this.lblAlertaReemb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlertaReemb.Name = "lblAlertaReemb";
            this.lblAlertaReemb.Size = new System.Drawing.Size(186, 20);
            this.lblAlertaReemb.TabIndex = 322;
            this.lblAlertaReemb.Text = "Consultar Reembolso";
            // 
            // pbAlertaReemb
            // 
            this.pbAlertaReemb.BackColor = System.Drawing.Color.Transparent;
            this.pbAlertaReemb.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbAlertaReemb.Image = ((System.Drawing.Image)(resources.GetObject("pbAlertaReemb.Image")));
            this.pbAlertaReemb.Location = new System.Drawing.Point(51, 863);
            this.pbAlertaReemb.Name = "pbAlertaReemb";
            this.pbAlertaReemb.Size = new System.Drawing.Size(36, 32);
            this.pbAlertaReemb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlertaReemb.TabIndex = 326;
            this.pbAlertaReemb.TabStop = false;
            // 
            // frmIngressoConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 913);
            this.Controls.Add(this.pbAlertaReemb);
            this.Controls.Add(this.lblAlertaReemb);
            this.Controls.Add(this.pbReembolso);
            this.Controls.Add(this.btnReembolso);
            this.Name = "frmIngressoConsultar";
            this.Text = "frmIngressoConsultar";
            this.Load += new System.EventHandler(this.Exibir);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmIngressoConsulta_KeyPress);
            this.Controls.SetChildIndex(this.lblCTRLF, 0);
            this.Controls.SetChildIndex(this.pbCtrlF, 0);
            this.Controls.SetChildIndex(this.btnReembolso, 0);
            this.Controls.SetChildIndex(this.pbReembolso, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblTitulo2, 0);
            this.Controls.SetChildIndex(this.pictureBox10, 0);
            this.Controls.SetChildIndex(this.gbFiltro, 0);
            this.Controls.SetChildIndex(this.pnDGV, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnDesativar, 0);
            this.Controls.SetChildIndex(this.btnReativar, 0);
            this.Controls.SetChildIndex(this.pbExcluir, 0);
            this.Controls.SetChildIndex(this.pbAlterar, 0);
            this.Controls.SetChildIndex(this.pbReativar, 0);
            this.Controls.SetChildIndex(this.pbConsultar, 0);
            this.Controls.SetChildIndex(this.pbDesativar, 0);
            this.Controls.SetChildIndex(this.lblAlertaReemb, 0);
            this.Controls.SetChildIndex(this.pbAlertaReemb, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbReembolso)).EndInit();
            this.menuReembolso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlertaReemb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pbReembolso;
        public System.Windows.Forms.Button btnReembolso;
        private System.Windows.Forms.ContextMenuStrip menuReembolso;
        private System.Windows.Forms.ToolStripMenuItem tsReembolso;
        private System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.RadioButton rbAPagar;
        public System.Windows.Forms.RadioButton rbCancelados;
        public System.Windows.Forms.RadioButton rbPagos;
        public System.Windows.Forms.Label lblAlertaReemb;
        public System.Windows.Forms.PictureBox pbAlertaReemb;
    }
}