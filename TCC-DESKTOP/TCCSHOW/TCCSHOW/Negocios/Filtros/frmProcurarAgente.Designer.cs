namespace TCCSHOW.Negocios.Filtros
{
    partial class frmProcurarAgente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcurarAgente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.cbAmbos = new System.Windows.Forms.ComboBox();
            this.rbAmbos = new System.Windows.Forms.RadioButton();
            this.cbEmpresario = new System.Windows.Forms.ComboBox();
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
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnFiltro = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnDGV = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pbConsultar = new System.Windows.Forms.PictureBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.pbConfirmar = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtPesquisarMask = new System.Windows.Forms.MaskedTextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.dtpHorarioInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHorarioFinal = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.gbDataEsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFiltro)).BeginInit();
            this.pnDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.Color.Red;
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("pbCancelar.Image")));
            this.pbCancelar.Location = new System.Drawing.Point(370, 541);
            this.pbCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(64, 54);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancelar.TabIndex = 327;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(361, 533);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(227, 70);
            this.btnCancelar.TabIndex = 326;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // gbFiltro
            // 
            this.gbFiltro.BackColor = System.Drawing.Color.Gray;
            this.gbFiltro.Controls.Add(this.cbAmbos);
            this.gbFiltro.Controls.Add(this.rbAmbos);
            this.gbFiltro.Controls.Add(this.cbEmpresario);
            this.gbFiltro.Controls.Add(this.rbEmpresario);
            this.gbFiltro.Controls.Add(this.gbDataEsp);
            this.gbFiltro.Controls.Add(this.rbCodigo);
            this.gbFiltro.Controls.Add(this.cbEmpresa);
            this.gbFiltro.Controls.Add(this.rbEmpresa);
            this.gbFiltro.Controls.Add(this.chkDataEsp);
            this.gbFiltro.Controls.Add(this.lblFiltro);
            this.gbFiltro.Controls.Add(this.btnFiltro);
            this.gbFiltro.Location = new System.Drawing.Point(1009, 14);
            this.gbFiltro.Margin = new System.Windows.Forms.Padding(4, 37, 4, 4);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Padding = new System.Windows.Forms.Padding(4);
            this.gbFiltro.Size = new System.Drawing.Size(315, 66);
            this.gbFiltro.TabIndex = 321;
            this.gbFiltro.TabStop = false;
            // 
            // cbAmbos
            // 
            this.cbAmbos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmbos.Enabled = false;
            this.cbAmbos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAmbos.FormattingEnabled = true;
            this.cbAmbos.Items.AddRange(new object[] {
            "CNPJ/CPF",
            "Nome Fantasia/Civil",
            "Razão/Nome Social"});
            this.cbAmbos.Location = new System.Drawing.Point(44, 313);
            this.cbAmbos.Margin = new System.Windows.Forms.Padding(4);
            this.cbAmbos.Name = "cbAmbos";
            this.cbAmbos.Size = new System.Drawing.Size(241, 32);
            this.cbAmbos.TabIndex = 322;
            // 
            // rbAmbos
            // 
            this.rbAmbos.AutoSize = true;
            this.rbAmbos.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAmbos.ForeColor = System.Drawing.Color.White;
            this.rbAmbos.Location = new System.Drawing.Point(34, 273);
            this.rbAmbos.Margin = new System.Windows.Forms.Padding(4);
            this.rbAmbos.Name = "rbAmbos";
            this.rbAmbos.Size = new System.Drawing.Size(115, 32);
            this.rbAmbos.TabIndex = 321;
            this.rbAmbos.TabStop = true;
            this.rbAmbos.Text = "Ambos";
            this.rbAmbos.UseVisualStyleBackColor = true;
            // 
            // cbEmpresario
            // 
            this.cbEmpresario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresario.Enabled = false;
            this.cbEmpresario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpresario.FormattingEnabled = true;
            this.cbEmpresario.Items.AddRange(new object[] {
            "CPF",
            "Nome Civil",
            "Nome Social"});
            this.cbEmpresario.Location = new System.Drawing.Point(44, 230);
            this.cbEmpresario.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmpresario.Name = "cbEmpresario";
            this.cbEmpresario.Size = new System.Drawing.Size(239, 38);
            this.cbEmpresario.TabIndex = 320;
            // 
            // rbEmpresario
            // 
            this.rbEmpresario.AutoSize = true;
            this.rbEmpresario.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpresario.ForeColor = System.Drawing.Color.White;
            this.rbEmpresario.Location = new System.Drawing.Point(34, 190);
            this.rbEmpresario.Margin = new System.Windows.Forms.Padding(4);
            this.rbEmpresario.Name = "rbEmpresario";
            this.rbEmpresario.Size = new System.Drawing.Size(171, 32);
            this.rbEmpresario.TabIndex = 319;
            this.rbEmpresario.TabStop = true;
            this.rbEmpresario.Text = "Empresário";
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
            this.gbDataEsp.Location = new System.Drawing.Point(0, 383);
            this.gbDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Name = "gbDataEsp";
            this.gbDataEsp.Padding = new System.Windows.Forms.Padding(4);
            this.gbDataEsp.Size = new System.Drawing.Size(323, 118);
            this.gbDataEsp.TabIndex = 315;
            this.gbDataEsp.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 27);
            this.label3.TabIndex = 288;
            this.label3.Text = "DATA DE(o/a):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 90);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 86);
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
            this.cbData.Location = new System.Drawing.Point(18, 40);
            this.cbData.Margin = new System.Windows.Forms.Padding(4);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(281, 38);
            this.cbData.TabIndex = 286;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(179, 86);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 24);
            this.dateTimePicker2.TabIndex = 235;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Quicksand Bold Oblique", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(35, 78);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(155, 36);
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
            this.cbEmpresa.Location = new System.Drawing.Point(35, 149);
            this.cbEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(250, 38);
            this.cbEmpresa.TabIndex = 317;
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.Font = new System.Drawing.Font("Quicksand Bold Oblique", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpresa.ForeColor = System.Drawing.Color.White;
            this.rbEmpresa.Location = new System.Drawing.Point(35, 115);
            this.rbEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(139, 32);
            this.rbEmpresa.TabIndex = 316;
            this.rbEmpresa.TabStop = true;
            this.rbEmpresa.Text = "Empresa";
            this.rbEmpresa.UseVisualStyleBackColor = true;
            // 
            // chkDataEsp
            // 
            this.chkDataEsp.AutoSize = true;
            this.chkDataEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDataEsp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkDataEsp.Location = new System.Drawing.Point(72, 353);
            this.chkDataEsp.Margin = new System.Windows.Forms.Padding(4);
            this.chkDataEsp.Name = "chkDataEsp";
            this.chkDataEsp.Size = new System.Drawing.Size(173, 28);
            this.chkDataEsp.TabIndex = 314;
            this.chkDataEsp.Text = "Data específica";
            this.chkDataEsp.UseVisualStyleBackColor = true;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFiltro.Font = new System.Drawing.Font("Quicksand Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.Silver;
            this.lblFiltro.Location = new System.Drawing.Point(95, 16);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(156, 43);
            this.lblFiltro.TabIndex = 287;
            this.lblFiltro.Text = "FILTRO";
            this.lblFiltro.Click += new System.EventHandler(this.AbrirFiltro);
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltro.Image")));
            this.btnFiltro.ImageActive = null;
            this.btnFiltro.Location = new System.Drawing.Point(29, 14);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(76, 46);
            this.btnFiltro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFiltro.TabIndex = 8;
            this.btnFiltro.TabStop = false;
            this.btnFiltro.Zoom = 10;
            this.btnFiltro.Click += new System.EventHandler(this.AbrirFiltro);
            // 
            // pnDGV
            // 
            this.pnDGV.BackColor = System.Drawing.Color.Transparent;
            this.pnDGV.Controls.Add(this.dgv);
            this.pnDGV.Location = new System.Drawing.Point(33, 94);
            this.pnDGV.Margin = new System.Windows.Forms.Padding(4);
            this.pnDGV.Name = "pnDGV";
            this.pnDGV.Size = new System.Drawing.Size(1291, 431);
            this.pnDGV.TabIndex = 320;
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
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Quicksand Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1291, 431);
            this.dgv.TabIndex = 4;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgenteConsulta_KeyPress);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.Color.White;
            this.txtPesquisar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPesquisar.HintForeColor = System.Drawing.Color.Gray;
            this.txtPesquisar.HintText = "Digite o que deseja buscar";
            this.txtPesquisar.isPassword = false;
            this.txtPesquisar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.txtPesquisar.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPesquisar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.txtPesquisar.LineThickness = 4;
            this.txtPesquisar.Location = new System.Drawing.Point(45, 14);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(9);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(761, 69);
            this.txtPesquisar.TabIndex = 318;
            this.txtPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgenteConsulta_KeyPress);
            // 
            // pbConsultar
            // 
            this.pbConsultar.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConsultar.Image = ((System.Drawing.Image)(resources.GetObject("pbConsultar.Image")));
            this.pbConsultar.Location = new System.Drawing.Point(839, 541);
            this.pbConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.pbConsultar.Name = "pbConsultar";
            this.pbConsultar.Size = new System.Drawing.Size(64, 54);
            this.pbConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConsultar.TabIndex = 339;
            this.pbConsultar.TabStop = false;
            this.pbConsultar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(830, 533);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(227, 70);
            this.btnConsultar.TabIndex = 338;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // pbConfirmar
            // 
            this.pbConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("pbConfirmar.Image")));
            this.pbConfirmar.Location = new System.Drawing.Point(605, 541);
            this.pbConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.pbConfirmar.Name = "pbConfirmar";
            this.pbConfirmar.Size = new System.Drawing.Size(64, 54);
            this.pbConfirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConfirmar.TabIndex = 337;
            this.pbConfirmar.TabStop = false;
            this.pbConfirmar.Click += new System.EventHandler(this.Confirmar);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(595, 533);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(227, 70);
            this.btnConfirmar.TabIndex = 336;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.Confirmar);
            // 
            // txtPesquisarMask
            // 
            this.txtPesquisarMask.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarMask.Location = new System.Drawing.Point(45, 14);
            this.txtPesquisarMask.Name = "txtPesquisarMask";
            this.txtPesquisarMask.Size = new System.Drawing.Size(761, 69);
            this.txtPesquisarMask.TabIndex = 343;
            this.txtPesquisarMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisarMask.Visible = false;
            this.txtPesquisarMask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgenteConsulta_KeyPress);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Black;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(730, 35);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(21, 24);
            this.lblHorario.TabIndex = 346;
            this.lblHorario.Text = "á";
            this.lblHorario.Visible = false;
            // 
            // dtpHorarioInicio
            // 
            this.dtpHorarioInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHorarioInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHorarioInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorarioInicio.Location = new System.Drawing.Point(675, 7);
            this.dtpHorarioInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHorarioInicio.Name = "dtpHorarioInicio";
            this.dtpHorarioInicio.ShowUpDown = true;
            this.dtpHorarioInicio.Size = new System.Drawing.Size(131, 24);
            this.dtpHorarioInicio.TabIndex = 344;
            this.dtpHorarioInicio.Visible = false;
            this.dtpHorarioInicio.ValueChanged += new System.EventHandler(this.Exibir);
            // 
            // dtpHorarioFinal
            // 
            this.dtpHorarioFinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHorarioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHorarioFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorarioFinal.Location = new System.Drawing.Point(675, 61);
            this.dtpHorarioFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHorarioFinal.Name = "dtpHorarioFinal";
            this.dtpHorarioFinal.ShowUpDown = true;
            this.dtpHorarioFinal.Size = new System.Drawing.Size(131, 24);
            this.dtpHorarioFinal.TabIndex = 345;
            this.dtpHorarioFinal.Visible = false;
            this.dtpHorarioFinal.ValueChanged += new System.EventHandler(this.Exibir);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(840, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 348;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Exibir);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightGray;
            this.btnBuscar.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(821, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(168, 62);
            this.btnBuscar.TabIndex = 347;
            this.btnBuscar.Text = "Procurar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.Exibir);
            // 
            // frmProcurarAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1380, 627);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.dtpHorarioInicio);
            this.Controls.Add(this.dtpHorarioFinal);
            this.Controls.Add(this.txtPesquisarMask);
            this.Controls.Add(this.pbConsultar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.pbConfirmar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.pbCancelar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.pnDGV);
            this.Controls.Add(this.txtPesquisar);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmProcurarAgente";
            this.Text = "";
            this.Load += new System.EventHandler(this.Exibir);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgenteConsulta_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.gbDataEsp.ResumeLayout(false);
            this.gbDataEsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFiltro)).EndInit();
            this.pnDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbCancelar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private Bunifu.Framework.UI.BunifuImageButton btnFiltro;
        private System.Windows.Forms.Panel pnDGV;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtPesquisar;
        public System.Windows.Forms.PictureBox pbConsultar;
        public System.Windows.Forms.Button btnConsultar;
        public System.Windows.Forms.PictureBox pbConfirmar;
        public System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.ComboBox cbAmbos;
        private System.Windows.Forms.RadioButton rbAmbos;
        public System.Windows.Forms.ComboBox cbEmpresario;
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
        public System.Windows.Forms.MaskedTextBox txtPesquisarMask;
        public System.Windows.Forms.Label lblHorario;
        public System.Windows.Forms.DateTimePicker dtpHorarioInicio;
        public System.Windows.Forms.DateTimePicker dtpHorarioFinal;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgv;
    }
}