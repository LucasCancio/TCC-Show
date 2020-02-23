namespace TCCSHOW.Negocios.Descontos
{
    partial class frmDescontos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescontos));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbSalvar = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pbAlterar = new System.Windows.Forms.PictureBox();
            this.pbExcluir = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pbAdicionar = new System.Windows.Forms.PictureBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCodProm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nupUsos = new System.Windows.Forms.NumericUpDown();
            this.lblEstrelaNomeArtista = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupUsos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Quicksand Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv.Location = new System.Drawing.Point(150, 261);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(742, 450);
            this.dgv.TabIndex = 397;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("pbCancelar.Image")));
            this.pbCancelar.Location = new System.Drawing.Point(1344, 739);
            this.pbCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(51, 58);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancelar.TabIndex = 396;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(1189, 733);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(221, 69);
            this.btnCancelar.TabIndex = 395;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(1084, 361);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 37);
            this.txtCodigo.TabIndex = 394;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Quicksand Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(979, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 43);
            this.label2.TabIndex = 393;
            this.label2.Text = "Cód";
            // 
            // pbSalvar
            // 
            this.pbSalvar.BackColor = System.Drawing.Color.PaleGreen;
            this.pbSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pbSalvar.Image")));
            this.pbSalvar.Location = new System.Drawing.Point(1113, 739);
            this.pbSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(51, 58);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalvar.TabIndex = 392;
            this.pbSalvar.TabStop = false;
            this.pbSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Quicksand Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(958, 733);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(221, 69);
            this.btnSalvar.TabIndex = 391;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // pbAlterar
            // 
            this.pbAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAlterar.Image = ((System.Drawing.Image)(resources.GetObject("pbAlterar.Image")));
            this.pbAlterar.Location = new System.Drawing.Point(418, 739);
            this.pbAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlterar.Name = "pbAlterar";
            this.pbAlterar.Size = new System.Drawing.Size(63, 58);
            this.pbAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlterar.TabIndex = 390;
            this.pbAlterar.TabStop = false;
            this.pbAlterar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // pbExcluir
            // 
            this.pbExcluir.BackColor = System.Drawing.Color.Red;
            this.pbExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("pbExcluir.Image")));
            this.pbExcluir.Location = new System.Drawing.Point(627, 739);
            this.pbExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(63, 58);
            this.pbExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExcluir.TabIndex = 389;
            this.pbExcluir.TabStop = false;
            this.pbExcluir.Click += new System.EventHandler(this.FixarStatus);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(507, 733);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(192, 69);
            this.btnExcluir.TabIndex = 387;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.FixarStatus);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(292, 733);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(198, 69);
            this.btnAlterar.TabIndex = 388;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // pbAdicionar
            // 
            this.pbAdicionar.BackColor = System.Drawing.Color.Lime;
            this.pbAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("pbAdicionar.Image")));
            this.pbAdicionar.Location = new System.Drawing.Point(1255, 255);
            this.pbAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.pbAdicionar.Name = "pbAdicionar";
            this.pbAdicionar.Size = new System.Drawing.Size(51, 58);
            this.pbAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdicionar.TabIndex = 386;
            this.pbAdicionar.TabStop = false;
            this.pbAdicionar.Click += new System.EventHandler(this.Adicionar);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Lime;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(1090, 249);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(222, 69);
            this.btnAdicionar.TabIndex = 385;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.Adicionar);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(960, 495);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesconto.MaxLength = 4;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(301, 46);
            this.txtDesconto.TabIndex = 383;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Quicksand Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(966, 440);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 42);
            this.label7.TabIndex = 384;
            this.label7.Text = "Desconto (%)";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(917, 43);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(136, 106);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 399;
            this.pictureBox10.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Quicksand Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTitulo.Location = new System.Drawing.Point(571, 69);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(338, 68);
            this.lblTitulo.TabIndex = 398;
            this.lblTitulo.Text = "Descontos";
            // 
            // txtCodProm
            // 
            this.txtCodProm.Enabled = false;
            this.txtCodProm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProm.Location = new System.Drawing.Point(960, 604);
            this.txtCodProm.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProm.MaxLength = 20;
            this.txtCodProm.Name = "txtCodProm";
            this.txtCodProm.Size = new System.Drawing.Size(468, 46);
            this.txtCodProm.TabIndex = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quicksand Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(998, 552);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 42);
            this.label1.TabIndex = 401;
            this.label1.Text = "Código Promocional";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.chkAtivo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1251, 337);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(148, 73);
            this.groupBox4.TabIndex = 402;
            this.groupBox4.TabStop = false;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Font = new System.Drawing.Font("Quicksand Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.ForeColor = System.Drawing.Color.White;
            this.chkAtivo.Location = new System.Drawing.Point(16, 21);
            this.chkAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(122, 42);
            this.chkAtivo.TabIndex = 1;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Quicksand Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1316, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 43);
            this.label6.TabIndex = 430;
            this.label6.Text = "Usos";
            // 
            // nupUsos
            // 
            this.nupUsos.Enabled = false;
            this.nupUsos.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupUsos.Location = new System.Drawing.Point(1324, 497);
            this.nupUsos.Name = "nupUsos";
            this.nupUsos.Size = new System.Drawing.Size(97, 42);
            this.nupUsos.TabIndex = 429;
            // 
            // lblEstrelaNomeArtista
            // 
            this.lblEstrelaNomeArtista.BackColor = System.Drawing.Color.Transparent;
            this.lblEstrelaNomeArtista.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstrelaNomeArtista.ForeColor = System.Drawing.Color.Red;
            this.lblEstrelaNomeArtista.Location = new System.Drawing.Point(1405, 552);
            this.lblEstrelaNomeArtista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstrelaNomeArtista.Name = "lblEstrelaNomeArtista";
            this.lblEstrelaNomeArtista.Size = new System.Drawing.Size(19, 23);
            this.lblEstrelaNomeArtista.TabIndex = 431;
            this.lblEstrelaNomeArtista.Text = "*";
            this.lblEstrelaNomeArtista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Quicksand Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1242, 443);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 23);
            this.label3.TabIndex = 432;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDescontos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 913);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEstrelaNomeArtista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nupUsos);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtCodProm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pbCancelar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pbAlterar);
            this.Controls.Add(this.pbExcluir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.pbAdicionar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label7);
            this.Name = "frmDescontos";
            this.Load += new System.EventHandler(this.Exibir);
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupUsos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.PictureBox pbCancelar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pbSalvar;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.PictureBox pbAlterar;
        public System.Windows.Forms.PictureBox pbExcluir;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.PictureBox pbAdicionar;
        public System.Windows.Forms.Button btnAdicionar;
        public System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.PictureBox pictureBox10;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.TextBox txtCodProm;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupUsos;
        private System.Windows.Forms.Label lblEstrelaNomeArtista;
        private System.Windows.Forms.Label label3;
    }
}