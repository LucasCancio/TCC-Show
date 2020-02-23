namespace TCCSHOW.Negocios.Contas
{
    partial class frmContasConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContasConsulta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.menuVenda = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
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
            this.menuVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDesativar
            // 
            this.pbDesativar.Location = new System.Drawing.Point(527, 828);
            this.pbDesativar.Click += new System.EventHandler(this.FixarStatusPB);
            // 
            // pbConsultar
            // 
            this.pbConsultar.Location = new System.Drawing.Point(997, 828);
            this.pbConsultar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // pbReativar
            // 
            this.pbReativar.Location = new System.Drawing.Point(756, 827);
            this.pbReativar.Click += new System.EventHandler(this.FixarStatusPB);
            // 
            // pbAlterar
            // 
            this.pbAlterar.Location = new System.Drawing.Point(1245, 828);
            this.pbAlterar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // pbExcluir
            // 
            this.pbExcluir.Location = new System.Drawing.Point(307, 829);
            this.pbExcluir.Click += new System.EventHandler(this.FixarStatusPB);
            // 
            // btnReativar
            // 
            this.btnReativar.Location = new System.Drawing.Point(747, 820);
            this.btnReativar.Click += new System.EventHandler(this.FixarStatus);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(515, 820);
            this.btnDesativar.Click += new System.EventHandler(this.FixarStatus);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(295, 820);
            this.btnExcluir.Click += new System.EventHandler(this.FixarStatus);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(1228, 820);
            this.btnAlterar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(988, 820);
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
            this.pictureBox10.Location = new System.Drawing.Point(1143, 13);
            this.pictureBox10.Size = new System.Drawing.Size(128, 91);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(151)))), ((int)(((byte)(136)))));
            this.lblTitulo2.Size = new System.Drawing.Size(240, 68);
            this.lblTitulo2.Text = "Contas";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Size = new System.Drawing.Size(668, 73);
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmContasConsulta_KeyPress);
            // 
            // rbTodos
            // 
            this.rbTodos.Location = new System.Drawing.Point(1032, 48);
            this.rbTodos.Click += new System.EventHandler(this.Exibir);
            // 
            // rbDesativa
            // 
            this.rbDesativa.Location = new System.Drawing.Point(1032, 73);
            this.rbDesativa.Click += new System.EventHandler(this.Exibir);
            // 
            // rbAtiva
            // 
            this.rbAtiva.Location = new System.Drawing.Point(1032, 20);
            this.rbAtiva.Click += new System.EventHandler(this.Exibir);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(842, 25);
            this.btnBuscar.Click += new System.EventHandler(this.Exibir);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(861, 35);
            this.pictureBox1.Click += new System.EventHandler(this.Exibir);
            // 
            // txtPesquisarMask
            // 
            this.txtPesquisarMask.Size = new System.Drawing.Size(668, 69);
            this.txtPesquisarMask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmContasConsulta_KeyPress);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Click += new System.EventHandler(this.AbrirFiltro);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Font = new System.Drawing.Font("Quicksand Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Click += new System.EventHandler(this.AbrirFiltro);
            // 
            // lblHorario
            // 
            this.lblHorario.Location = new System.Drawing.Point(749, 48);
            this.lblHorario.Visible = true;
            // 
            // dtpHorarioInicio
            // 
            this.dtpHorarioInicio.Location = new System.Drawing.Point(694, 20);
            this.dtpHorarioInicio.Visible = true;
            this.dtpHorarioInicio.ValueChanged += new System.EventHandler(this.Exibir);
            // 
            // dtpHorarioFinal
            // 
            this.dtpHorarioFinal.Location = new System.Drawing.Point(694, 74);
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
            this.dgv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmContasConsulta_KeyPress);
            // 
            // menuVenda
            // 
            this.menuVenda.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuVenda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsVenda});
            this.menuVenda.Name = "menuAssento";
            this.menuVenda.Size = new System.Drawing.Size(246, 30);
            // 
            // tsVenda
            // 
            this.tsVenda.BackColor = System.Drawing.Color.RoyalBlue;
            this.tsVenda.Font = new System.Drawing.Font("Quicksand Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsVenda.ForeColor = System.Drawing.Color.White;
            this.tsVenda.Image = ((System.Drawing.Image)(resources.GetObject("tsVenda.Image")));
            this.tsVenda.Name = "tsVenda";
            this.tsVenda.Size = new System.Drawing.Size(245, 26);
            this.tsVenda.Text = "Consultar Venda";
            this.tsVenda.Click += new System.EventHandler(this.ConsultarVenda);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(25, 859);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(36, 34);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 327;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Help;
            this.label2.Font = new System.Drawing.Font("Quicksand Bold Oblique", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(69, 869);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 326;
            this.label2.Text = "Consultar Venda";
            // 
            // frmContasConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 913);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.label2);
            this.Name = "frmContasConsulta";
            this.Text = "frmContasConsulta";
            this.Load += new System.EventHandler(this.Exibir);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmContasConsulta_KeyPress);
            this.Controls.SetChildIndex(this.lblCTRLF, 0);
            this.Controls.SetChildIndex(this.pbCtrlF, 0);
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
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.bunifuImageButton2, 0);
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
            this.menuVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ContextMenuStrip menuVenda;
        private System.Windows.Forms.ToolStripMenuItem tsVenda;
        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        public System.Windows.Forms.Label label2;
    }
}