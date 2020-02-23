using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Preco
{
    public partial class frmPrecos : Modelos.ModeloPadrao
    {
        public frmPrecos()
        {
            InitializeComponent();
            this.cbCategoria.SelectedIndex = 0;
            this.cbTipo.SelectedIndex = 0;
            MudarValor();
            CarregarCampos();
          
           
        }


        

    


        class myComboBox : ComboBox
        {
            private ImageList imageList;
            public ImageList ImageList
            {
                get { return imageList; }
                set { imageList = value; }
            }

            public myComboBox()
            {
                DrawMode = DrawMode.OwnerDrawFixed;
            }

            protected override void OnDrawItem(DrawItemEventArgs ea)
            {
                ea.DrawBackground();
                ea.DrawFocusRectangle();
                ComboBoxExItem item;
                Size imageSize = imageList.ImageSize;
                Rectangle bounds = ea.Bounds;

                try
                {
                    item = (ComboBoxExItem)Items[ea.Index];

                    if (item.ImageIndex != -1)
                    {
                        imageList.Draw(ea.Graphics, bounds.Left, bounds.Top,
                        item.ImageIndex);
                        ea.Graphics.DrawString(item.Text, ea.Font, new
                            SolidBrush(ea.ForeColor), bounds.Left + imageSize.Width, bounds.Top);
                    }
                    else
                    {
                        ea.Graphics.DrawString(item.Text, ea.Font, new
                            SolidBrush(ea.ForeColor), bounds.Left, bounds.Top);
                    }
                }
                catch
                {
                    if (ea.Index != -1)
                    {
                        ea.Graphics.DrawString(Items[ea.Index].ToString(), ea.Font, new
                        SolidBrush(ea.ForeColor), bounds.Left, bounds.Top);
                    }
                    else
                    {
                        ea.Graphics.DrawString(Text, ea.Font, new
                        SolidBrush(ea.ForeColor), bounds.Left, bounds.Top);
                    }
                }

                base.OnDrawItem(ea);
            }
        }

        class ComboBoxExItem
        {
            private string _text;
            public string Text
            {
                get { return _text; }
                set { _text = value; }
            }

            private int _imageIndex;
            public int ImageIndex
            {
                get { return _imageIndex; }
                set { _imageIndex = value; }
            }

            public ComboBoxExItem()
                : this("")
            {
            }

            public ComboBoxExItem(string text)
                : this(text, -1)
            {
            }

            public ComboBoxExItem(string text, int imageIndex)
            {
                _text = text;
                _imageIndex = imageIndex;
            }

            public override string ToString()
            {
                return _text;
            }
        }


  





        /// //////////////////////////////////////////////


        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)

            {

                e.Handled = true;

            }
            if (e.KeyChar == (char)44)
            {
                e.Handled = true;




            }
            if (this.txtValor.Text.Length > 2 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void MudarValor()
        {
            try
            {
                this.cbTipo.Items.Clear();
                switch (cbCategoria.Text)
                {
                    case "Ouro":
                        this.cbTipo.Items.Add("Simples");
                        this.cbTipo.Items.Add("Duplo");
                        this.cbTipo.Items.Add("Especial");
                        break;
                    case "Prata":
                        this.cbTipo.Items.Add("Simples");
                        this.cbTipo.Items.Add("Especial");
                        break;
                    case "Bronze":
                        this.cbTipo.Items.Add("Simples");
                        break;
                }

                this.cbTipo.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Salvar(object sender, EventArgs e)
        {
            try
            {
                if (this.txtValor.Text==string.Empty)
                {
                    erro.SetError(txtValor, "Digite um percentual!");
                    return;
                }
                else
                {
                    erro.SetError(txtValor, string.Empty);
                }




                if (MessageBox.Show("Deseja Aplicar?", "ATENÇÃO ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; }
                BLL.Assento func = new BLL.Assento();

                btnSalvar.Cursor = Cursors.AppStarting;
                switch (this.cbTipo.Text)
                {
                    case "Simples":
                        func.ID_TIPOASSENTO = 1;
                        break;
                    case "Duplo":
                        func.ID_TIPOASSENTO = 2;
                        break;
                    case "Especial":
                        func.ID_TIPOASSENTO = 3;
                        break;

                }
                switch (this.cbCategoria.Text)
                {
                    case "Ouro":
                        func.ID_SETOR = 1;
                        break;
                    case "Prata":
                        func.ID_SETOR = 2;
                        break;
                    case "Bronze":
                        func.ID_SETOR = 3;
                        break;
                }

                func.Valor = txtValor.Text.Trim();

                func.AlterarPrecos();
                MessageBox.Show("Operação realizada com sucesso!");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        private void MudarTipo(object sender, EventArgs e)
        {
            CarregarCampos();
        }

        private void MudarCategoria(object sender, EventArgs e)
        {

            MudarValor();
        }

        private void CarregarCampos()
        {
            try
            {
                this.txtValor.Text = string.Empty;

                BLL.Assento medi = new BLL.Assento();
                Oracle.DataAccess.Client.OracleDataReader dr;
                this.txtValor.Enabled = true;
                this.btnSalvar.Enabled =true;
                this.pbSalvar.Enabled = true;
                switch (this.cbTipo.Text)
                {
                    case "Simples":
                        medi.ID_TIPOASSENTO = 1;
                        break;
                    case "Duplo":
                        medi.ID_TIPOASSENTO = 2;
                        
                        break;
                    case "Especial":
                        medi.ID_TIPOASSENTO = 3;
                        this.txtValor.Enabled = false;
                        this.btnSalvar.Enabled = false;
                        this.pbSalvar.Enabled = false;
                        break;

                }
                switch (this.cbCategoria.Text)
                {
                    case "Ouro":
                        medi.ID_SETOR = 1;
                        break;
                    case "Prata":
                        medi.ID_SETOR = 2;
                        break;
                    case "Bronze":
                        medi.ID_SETOR = 3;
                        break;
                }
                dr = medi.ConsultarValor2();
                if (dr.Read())
                {
                    this.txtValor.Text = dr["PERC"].ToString();
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.Dispose();
        }

      


        //////////////////////////////
    }
}
