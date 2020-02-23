namespace TCCSHOW.Negocios.Funcionario
{
    partial class frmFuncionarioConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarioConsulta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gbDataEsp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.chkDataEsp = new System.Windows.Forms.CheckBox();
            this.rbCEP = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
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
            this.gbDataEsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.radioButton1);
            this.gbFiltro.Controls.Add(this.gbDataEsp);
            this.gbFiltro.Controls.Add(this.rbCodigo);
            this.gbFiltro.Controls.Add(this.rbCPF);
            this.gbFiltro.Controls.Add(this.chkDataEsp);
            this.gbFiltro.Controls.Add(this.rbCEP);
            this.gbFiltro.Controls.Add(this.cbNome);
            this.gbFiltro.Controls.Add(this.rbNome);
            this.gbFiltro.Controls.SetChildIndex(this.btnFiltro, 0);
            this.gbFiltro.Controls.SetChildIndex(this.lblFiltro, 0);
            this.gbFiltro.Controls.SetChildIndex(this.rbNome, 0);
            this.gbFiltro.Controls.SetChildIndex(this.cbNome, 0);
            this.gbFiltro.Controls.SetChildIndex(this.rbCEP, 0);
            this.gbFiltro.Controls.SetChildIndex(this.chkDataEsp, 0);
            this.gbFiltro.Controls.SetChildIndex(this.rbCPF, 0);
            this.gbFiltro.Controls.SetChildIndex(this.rbCodigo, 0);
            this.gbFiltro.Controls.SetChildIndex(this.gbDataEsp, 0);
            this.gbFiltro.Controls.SetChildIndex(this.radioButton1, 0);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(177, 22);
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
            this.pictureBox10.Location = new System.Drawing.Point(1234, 9);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.ForeColor = System.Drawing.Color.Silver;
            this.lblTitulo2.Location = new System.Drawing.Point(780, 22);
            this.lblTitulo2.Size = new System.Drawing.Size(408, 68);
            this.lblTitulo2.Text = "Funcionários";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmFuncionarioConsulta_KeyPress);
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
            this.txtPesquisarMask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmFuncionarioConsulta_KeyPress);
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Quicksand Bold Oblique", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(27, 396);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(194, 43);
            this.radioButton1.TabIndex = 312;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "FUNÇÃO";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // gbDataEsp
            // 
            this.gbDataEsp.BackColor = System.Drawing.Color.Gray;
            this.gbDataEsp.Controls.Add(this.label3);
            this.gbDataEsp.Controls.Add(this.label1);
            this.gbDataEsp.Controls.Add(this.dtpDataInicio);
            this.gbDataEsp.Controls.Add(this.cbData);
            this.gbDataEsp.Controls.Add(this.dtpDataFinal);
            this.gbDataEsp.Enabled = false;
            this.gbDataEsp.Location = new System.Drawing.Point(1, 523);
            this.gbDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Name = "gbDataEsp";
            this.gbDataEsp.Padding = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Size = new System.Drawing.Size(303, 166);
            this.gbDataEsp.TabIndex = 306;
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
            // dtpDataInicio
            // 
            this.dtpDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataInicio.Location = new System.Drawing.Point(8, 118);
            this.dtpDataInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.ShowUpDown = true;
            this.dtpDataInicio.Size = new System.Drawing.Size(131, 24);
            this.dtpDataInicio.TabIndex = 234;
            // 
            // cbData
            // 
            this.cbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbData.FormattingEnabled = true;
            this.cbData.Items.AddRange(new object[] {
            "Contratação",
            "Do evento"});
            this.cbData.Location = new System.Drawing.Point(11, 70);
            this.cbData.Margin = new System.Windows.Forms.Padding(4);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(281, 38);
            this.cbData.TabIndex = 286;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataFinal.Location = new System.Drawing.Point(169, 118);
            this.dtpDataFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.ShowUpDown = true;
            this.dtpDataFinal.Size = new System.Drawing.Size(124, 24);
            this.dtpDataFinal.TabIndex = 235;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Quicksand Bold Oblique", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(27, 119);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(181, 43);
            this.rbCodigo.TabIndex = 311;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "CÓDIGO";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Font = new System.Drawing.Font("Quicksand Bold Oblique", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCPF.ForeColor = System.Drawing.Color.White;
            this.rbCPF.Location = new System.Drawing.Point(26, 170);
            this.rbCPF.Margin = new System.Windows.Forms.Padding(4);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(102, 43);
            this.rbCPF.TabIndex = 307;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            // 
            // cbNome
            // 
            this.cbNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Items.AddRange(new object[] {
            "Funcionário"});
            this.cbNome.Location = new System.Drawing.Point(19, 336);
            this.cbNome.Margin = new System.Windows.Forms.Padding(4);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(251, 38);
            this.cbNome.TabIndex = 310;
            // 
            // chkDataEsp
            // 
            this.chkDataEsp.AutoSize = true;
            this.chkDataEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDataEsp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkDataEsp.Location = new System.Drawing.Point(61, 497);
            this.chkDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.chkDataEsp.Name = "chkDataEsp";
            this.chkDataEsp.Size = new System.Drawing.Size(173, 28);
            this.chkDataEsp.TabIndex = 305;
            this.chkDataEsp.Text = "Data específica";
            this.chkDataEsp.UseVisualStyleBackColor = true;
            // 
            // rbCEP
            // 
            this.rbCEP.AutoSize = true;
            this.rbCEP.Font = new System.Drawing.Font("Quicksand Bold Oblique", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCEP.ForeColor = System.Drawing.Color.White;
            this.rbCEP.Location = new System.Drawing.Point(27, 230);
            this.rbCEP.Margin = new System.Windows.Forms.Padding(4);
            this.rbCEP.Name = "rbCEP";
            this.rbCEP.Size = new System.Drawing.Size(102, 43);
            this.rbCEP.TabIndex = 308;
            this.rbCEP.TabStop = true;
            this.rbCEP.Text = "CEP";
            this.rbCEP.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Font = new System.Drawing.Font("Quicksand Bold Oblique", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(26, 290);
            this.rbNome.Margin = new System.Windows.Forms.Padding(4);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(239, 38);
            this.rbNome.TabIndex = 309;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "NOME DO(a):";
            this.rbNome.UseVisualStyleBackColor = true;
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
            this.dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmFuncionarioConsulta_KeyPress);
            // 
            // frmFuncionarioConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 913);
            this.Name = "frmFuncionarioConsulta";
            this.Text = "frmFuncionarioConsulta";
            this.Load += new System.EventHandler(this.Exibir);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmFuncionarioConsulta_KeyPress);
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

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox gbDataEsp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        public System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbCPF;
        public System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.CheckBox chkDataEsp;
        private System.Windows.Forms.RadioButton rbCEP;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.DataGridView dgv;
    }
}