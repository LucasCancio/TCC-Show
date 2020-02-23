namespace TCCSHOW.Negocios.Artistas
{
    partial class frmArtistaConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArtistaConsulta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbAmbos = new System.Windows.Forms.RadioButton();
            this.rbEmpresario = new System.Windows.Forms.RadioButton();
            this.gbDataEsp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.chkDataEsp = new System.Windows.Forms.CheckBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            this.gbDataEsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.comboBox2);
            this.gbFiltro.Controls.Add(this.comboBox1);
            this.gbFiltro.Controls.Add(this.rbAmbos);
            this.gbFiltro.Controls.Add(this.rbEmpresario);
            this.gbFiltro.Controls.Add(this.gbDataEsp);
            this.gbFiltro.Controls.Add(this.rbCodigo);
            this.gbFiltro.Controls.Add(this.cbEmpresa);
            this.gbFiltro.Controls.Add(this.rbEmpresa);
            this.gbFiltro.Controls.Add(this.chkDataEsp);
            this.gbFiltro.Location = new System.Drawing.Point(1241, 112);
            this.gbFiltro.Controls.SetChildIndex(this.btnFiltro, 0);
            this.gbFiltro.Controls.SetChildIndex(this.lblFiltro, 0);
            this.gbFiltro.Controls.SetChildIndex(this.chkDataEsp, 0);
            this.gbFiltro.Controls.SetChildIndex(this.rbEmpresa, 0);
            this.gbFiltro.Controls.SetChildIndex(this.cbEmpresa, 0);
            this.gbFiltro.Controls.SetChildIndex(this.rbCodigo, 0);
            this.gbFiltro.Controls.SetChildIndex(this.gbDataEsp, 0);
            this.gbFiltro.Controls.SetChildIndex(this.rbEmpresario, 0);
            this.gbFiltro.Controls.SetChildIndex(this.rbAmbos, 0);
            this.gbFiltro.Controls.SetChildIndex(this.comboBox1, 0);
            this.gbFiltro.Controls.SetChildIndex(this.comboBox2, 0);
            // 
            // pbDesativar
            // 
            this.pbDesativar.Click += new System.EventHandler(this.FixarStatusPB);
            // 
            // pbConsultar
            // 
            this.pbConsultar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // pbReativar
            // 
            this.pbReativar.Click += new System.EventHandler(this.FixarStatusPB);
            // 
            // pbAlterar
            // 
            this.pbAlterar.Location = new System.Drawing.Point(1213, 835);
            this.pbAlterar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // pbExcluir
            // 
            this.pbExcluir.Click += new System.EventHandler(this.FixarStatusPB);
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
            this.btnAlterar.Location = new System.Drawing.Point(1196, 827);
            this.btnAlterar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // pnDGV
            // 
            this.pnDGV.Controls.Add(this.dgv);
            this.pnDGV.Size = new System.Drawing.Size(1520, 566);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(1123, 8);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.Size = new System.Drawing.Size(226, 68);
            this.lblTitulo2.Text = "Artista";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(13, 28);
            this.txtPesquisar.Size = new System.Drawing.Size(830, 73);
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmArtistaConsulta_KeyPress);
            // 
            // rbTodos
            // 
            this.rbTodos.Location = new System.Drawing.Point(1046, 48);
            this.rbTodos.Click += new System.EventHandler(this.Exibir);
            // 
            // rbDesativa
            // 
            this.rbDesativa.Location = new System.Drawing.Point(1046, 73);
            this.rbDesativa.Click += new System.EventHandler(this.Exibir);
            // 
            // rbAtiva
            // 
            this.rbAtiva.Location = new System.Drawing.Point(1046, 20);
            this.rbAtiva.Click += new System.EventHandler(this.Exibir);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(855, 32);
            this.btnBuscar.Click += new System.EventHandler(this.Exibir);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(874, 42);
            this.pictureBox1.Click += new System.EventHandler(this.Exibir);
            // 
            // txtPesquisarMask
            // 
            this.txtPesquisarMask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmArtistaConsulta_KeyPress);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Click += new System.EventHandler(this.AbrirFiltro);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Click += new System.EventHandler(this.AbrirFiltro);
            // 
            // dtpHorarioInicio
            // 
            this.dtpHorarioInicio.ValueChanged += new System.EventHandler(this.Exibir);
            // 
            // dtpHorarioFinal
            // 
            this.dtpHorarioFinal.ValueChanged += new System.EventHandler(this.Exibir);
            // 
            // rbAmbos
            // 
            this.rbAmbos.AutoSize = true;
            this.rbAmbos.Font = new System.Drawing.Font("Quicksand Bold Oblique", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAmbos.ForeColor = System.Drawing.Color.White;
            this.rbAmbos.Location = new System.Drawing.Point(12, 362);
            this.rbAmbos.Margin = new System.Windows.Forms.Padding(4);
            this.rbAmbos.Name = "rbAmbos";
            this.rbAmbos.Size = new System.Drawing.Size(138, 38);
            this.rbAmbos.TabIndex = 321;
            this.rbAmbos.TabStop = true;
            this.rbAmbos.Text = "Ambos";
            this.rbAmbos.UseVisualStyleBackColor = true;
            // 
            // rbEmpresario
            // 
            this.rbEmpresario.AutoSize = true;
            this.rbEmpresario.Font = new System.Drawing.Font("Quicksand Bold Oblique", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpresario.ForeColor = System.Drawing.Color.White;
            this.rbEmpresario.Location = new System.Drawing.Point(19, 265);
            this.rbEmpresario.Margin = new System.Windows.Forms.Padding(4);
            this.rbEmpresario.Name = "rbEmpresario";
            this.rbEmpresario.Size = new System.Drawing.Size(235, 38);
            this.rbEmpresario.TabIndex = 319;
            this.rbEmpresario.TabStop = true;
            this.rbEmpresario.Text = "Artistas Fixos";
            this.rbEmpresario.UseVisualStyleBackColor = true;
            // 
            // gbDataEsp
            // 
            this.gbDataEsp.BackColor = System.Drawing.Color.Gray;
            this.gbDataEsp.Controls.Add(this.label3);
            this.gbDataEsp.Controls.Add(this.label1);
            this.gbDataEsp.Controls.Add(this.dateTimePicker1);
            this.gbDataEsp.Controls.Add(this.cbData);
            this.gbDataEsp.Controls.Add(this.dateTimePicker2);
            this.gbDataEsp.Enabled = false;
            this.gbDataEsp.Location = new System.Drawing.Point(1, 523);
            this.gbDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Name = "gbDataEsp";
            this.gbDataEsp.Padding = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Size = new System.Drawing.Size(303, 166);
            this.gbDataEsp.TabIndex = 315;
            this.gbDataEsp.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 34);
            this.label3.TabIndex = 288;
            this.label3.Text = "DATA DE(o/a):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 236;
            this.label1.Text = "á";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 118);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 24);
            this.dateTimePicker1.TabIndex = 234;
            // 
            // cbData
            // 
            this.cbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbData.FormattingEnabled = true;
            this.cbData.Items.AddRange(new object[] {
            "Contratação"});
            this.cbData.Location = new System.Drawing.Point(11, 70);
            this.cbData.Margin = new System.Windows.Forms.Padding(4);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(281, 38);
            this.cbData.TabIndex = 286;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(169, 118);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 24);
            this.dateTimePicker2.TabIndex = 235;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Quicksand Bold Oblique", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(19, 111);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(181, 43);
            this.rbCodigo.TabIndex = 318;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "CÓDIGO";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresa.Enabled = false;
            this.cbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Items.AddRange(new object[] {
            "CNPJ",
            "Nome Fantasia",
            "Razão Social"});
            this.cbEmpresa.Location = new System.Drawing.Point(41, 209);
            this.cbEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(239, 38);
            this.cbEmpresa.TabIndex = 317;
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.Font = new System.Drawing.Font("Quicksand Bold Oblique", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpresa.ForeColor = System.Drawing.Color.White;
            this.rbEmpresa.Location = new System.Drawing.Point(19, 162);
            this.rbEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(149, 38);
            this.rbEmpresa.TabIndex = 316;
            this.rbEmpresa.TabStop = true;
            this.rbEmpresa.Text = "Artistas";
            this.rbEmpresa.UseVisualStyleBackColor = true;
            // 
            // chkDataEsp
            // 
            this.chkDataEsp.AutoSize = true;
            this.chkDataEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDataEsp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkDataEsp.Location = new System.Drawing.Point(64, 482);
            this.chkDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.chkDataEsp.Name = "chkDataEsp";
            this.chkDataEsp.Size = new System.Drawing.Size(173, 28);
            this.chkDataEsp.TabIndex = 314;
            this.chkDataEsp.Text = "Data específica";
            this.chkDataEsp.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
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
            this.dgv.Size = new System.Drawing.Size(1520, 566);
            this.dgv.TabIndex = 2;
            this.dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmArtistaConsulta_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CNPJ",
            "Nome Fantasia",
            "Razão Social"});
            this.comboBox1.Location = new System.Drawing.Point(41, 311);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 38);
            this.comboBox1.TabIndex = 322;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "CNPJ",
            "Nome Fantasia",
            "Razão Social"});
            this.comboBox2.Location = new System.Drawing.Point(41, 408);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(239, 38);
            this.comboBox2.TabIndex = 323;
            // 
            // frmArtistaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 913);
            this.Name = "frmArtistaConsulta";
            this.Text = "frmArtistaConsulta";
            this.Load += new System.EventHandler(this.Exibir);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmArtistaConsulta_KeyPress);
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
            this.gbDataEsp.ResumeLayout(false);
            this.gbDataEsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbAmbos;
        private System.Windows.Forms.RadioButton rbEmpresario;
        private System.Windows.Forms.GroupBox gbDataEsp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton rbCodigo;
        public System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.CheckBox chkDataEsp;
        private System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
    }
}