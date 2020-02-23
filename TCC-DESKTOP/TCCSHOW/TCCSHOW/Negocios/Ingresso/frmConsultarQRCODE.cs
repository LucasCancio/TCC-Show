using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MessagingToolkit.Barcode;
//using AForge.Video;
//using AForge.Video.DirectShow;
using System.Drawing;

namespace TCCSHOW.Negocios.Ingresso
{
    public partial class frmConsultarQRCODE : Modelos.ModeloPadrao
    {
        public frmConsultarQRCODE()
        {
            InitializeComponent();
          
         
        }
        
        BarcodeEncoder Generator;
        BarcodeDecoder Scanner;
        SaveFileDialog SD;
        OpenFileDialog OD;

        private FilterInfoCollection dispositivo;
        private VideoCaptureDevice imagem;

        private void CarregarCampos(object sender, EventArgs e)
        {

           
            
            dispositivo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo capturar in dispositivo)
            {
                cbWebCan.Items.Add(capturar.Name);
            }
            cbWebCan.SelectedIndex = -1;

           
        }

      


        private void camera(object sender, NewFrameEventArgs eventargs)
        {
            try
            {
                Bitmap bit = (Bitmap)eventargs.Frame.Clone();

                pbWebCan.Image = bit;
            }
            catch (Exception ex)
            {

               
            }
           
            
            

        }
        BLL.Ingresso ing = new BLL.Ingresso();
        Oracle.DataAccess.Client.OracleDataReader dr;
        
        private void Scannear(object sender, EventArgs e)
        {
            try
            {
                if (this.cbWebCan.SelectedIndex == -1)
                {
                    return;
                }
                Scanner = new BarcodeDecoder();
                //if (f.Visible == false)
                //{
                //    if (imagem != null && this.Visible == false)
                //    {
                //        if (imagem.IsRunning)
                //        {
                //            imagem.Stop();
                //            timerWebCan.Enabled = false;
                //            return;

                //        }
                //    }
                //}
                
                Result result = Scanner.Decode(new Bitmap(pbWebCan.Image));///IF


                ing.ID_VENDA = Convert.ToInt32(result.Text.Replace("http://",""));
                dr = ing.ConsultarValidade();
                if (!dr.Read())
                {
                    timerWebCan.Enabled = false;
                    if (MessageBox.Show("Esse ingresso não existe!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        timerWebCan.Enabled = true;
                    }
                    else
                    {
                        timerWebCan.Enabled = true;
                    }

                    return;
                }
                try
                {
                    Id_Venda = Convert.ToInt32(result.Text.Replace("http://", ""));
                    imagem.NewFrame -= camera;
                    timerWebCan.Enabled = false;
                    this.pbCancelar.Visible = true;
                    this.btnCancelar.Visible = true;
                    this.pbConsultar.Visible = true;
                    this.btnConsultar.Visible = true;


                    if (MessageBox.Show("QRCode lido com sucesso!" + Environment.NewLine + "Deseja consulta-lo?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                          
                            frmIngresso f = new frmIngresso
                            {
                                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                                Size = this.Size,
                                idFunc = this.idFunc
                            };
                            f.MinimizeBox = true;
                            f.Size = new Size(f.Width, f.Height + 15);
                            f.StartPosition = FormStartPosition.CenterScreen;
                            f.txtCodigo.Enabled = false; f.txtCodigo.Visible = true;


                            f.gbCodigo.Visible = true;
                            f.codigo = Convert.ToInt32(result.Text.Replace("http://", ""));
                            //f.Ativo = Convert.ToInt32(this.dgv.CurrentRow.Cells[4].Value);
                            f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);


                            f.txtCPF.Enabled = true;

                            f.txtCodigo.Enabled = true;



                            f.btnImprimir.Visible = false;
                            f.pbImprimir.Visible = false;
                            f.gbImprimir.Visible = false;


                            f.btnCancelar.Location = new Point(f.btnCancelar.Location.X + 180, f.btnCancelar.Location.Y);
                            f.pbCancelar.Location = new Point(f.pbCancelar.Location.X + 180, f.pbCancelar.Location.Y);







                            f.txtCPF.Enabled = false;
                            //f.txtNomeFunc.Enabled = false;
                            f.dtpDataNasc.Enabled = false;
                            f.txtCodigo.Enabled = false; f.txtCodigo.Visible = true;
                            f.dtpEvento.Enabled = false;
                            //f.cbSexo.Enabled = false;

                            //f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible = false; f.btnLimpar.Visible = false;


                            f.operacao = Convert.ToByte(BLL.Operacao.Consulta);



                            //var b = (Button)sender;
                            //f.lblTitulo.Text =  b.Text;

                            f.TopMost = true;
                            f.FormBorderStyle = FormBorderStyle.FixedToolWindow;



                            this.timerWebCan.Enabled = false;

                            f.idFunc = this.idFunc; f.ShowDialog();

                            Generator = new BarcodeEncoder();
                            Generator.IncludeLabel = true;
                            Generator.CustomLabel = result.Text;
                            //pbQrCode.Image = new Bitmap(Generator.Encode(BarcodeFormat.QRCode, result.Text));

                            ID_Venda_QRCODE = Convert.ToInt32(result.Text.Replace("http://", ""));

                            //this.pbQrCode.Visible = true;


                            





                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro: " + ex.Message, ex.Source);
                        }
                    }
                    
                }
                finally {
                   
                }
               
               


              
                   



               

            }
            catch (Exception ex)
            {
               
            }

        }

        public int Id_Venda;

        //private void button2_Click(object sender, EventArgs e)////// GERAR QRCODE
        //{
        //    Generator = new BarcodeEncoder();
        //    Generator.IncludeLabel = true;
        //    Generator.CustomLabel = textBox1.Text;
        //    if (textBox1.Text != "")
        //        pictureBox1.Image = new Bitmap(Generator.Encode(BarcodeFormat.QRCode, textBox1.Text));

        //}

        private void button3_Click(object sender, EventArgs e)
        {
            SD = new SaveFileDialog();
            SD.Filter = "PNG File|*.png";
            if (SD.ShowDialog() == DialogResult.OK)
                pbWebCan.Image.Save(SD.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OD = new OpenFileDialog();
            OD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (OD.ShowDialog() == DialogResult.OK)
                pbWebCan.Load(OD.FileName);
        }

        private void cbWebCan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cbWebCan.SelectedIndex == -1)
                { return; }
              
                imagem = new VideoCaptureDevice(dispositivo[cbWebCan.SelectedIndex].MonikerString);
                imagem.NewFrame += new NewFrameEventHandler(camera);

                imagem.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
          
               
        }

        private void Cancelar(object sender, EventArgs e)
        {
           

            this.pbCancelar.Visible = false;
            this.btnCancelar.Visible = false;

            this.pbConsultar.Visible = false;
            this.btnConsultar.Visible = false;

            imagem.NewFrame += camera;
            timerWebCan.Enabled = true;


        }

    

        private void frmConsultarQRCODE_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (imagem != null)
            {
                if (imagem.IsRunning)
                {
                    imagem.Stop();

                    timerWebCan.Enabled = false;
                }
            }

        }

        private void frmConsultarQRCODE_VisibleChanged(object sender, EventArgs e)
        {
            if (!(imagem == null))
            {
                if (imagem.IsRunning)
                {
                    imagem.SignalToStop();
                    imagem = null;
                }
            }
        }
        int ID_Venda_QRCODE;

        private void Consultar(object sender, EventArgs e)
        {
            try
            {

                frmIngresso f = new frmIngresso
                {
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    Size = this.Size,
                    idFunc = this.idFunc
                };
                f.MinimizeBox = true;
                f.Size = new Size(f.Width, f.Height + 15);
                f.StartPosition = FormStartPosition.CenterScreen;
                f.txtCodigo.Enabled = false; f.txtCodigo.Visible = true;


                f.gbCodigo.Visible = true;
                f.codigo = Convert.ToInt32(Id_Venda);
                //f.Ativo = Convert.ToInt32(this.dgv.CurrentRow.Cells[4].Value);
                f.operacao = Convert.ToByte(BLL.Operacao.Alteracao);


                f.txtCPF.Enabled = true;

                f.txtCodigo.Enabled = true;



                f.btnImprimir.Visible = false;
                f.pbImprimir.Visible = false;
                f.gbImprimir.Visible = false;


                f.btnCancelar.Location = new Point(f.btnCancelar.Location.X + 180, f.btnCancelar.Location.Y);
                f.pbCancelar.Location = new Point(f.pbCancelar.Location.X + 180, f.pbCancelar.Location.Y);







                f.txtCPF.Enabled = false;
                //f.txtNomeFunc.Enabled = false;
                f.dtpDataNasc.Enabled = false;
                f.txtCodigo.Enabled = false; f.txtCodigo.Visible = true;
                f.dtpEvento.Enabled = false;
                //f.cbSexo.Enabled = false;

                //f.btnSalvar.Visible = false; f.pbSalvar.Visible = false; f.pbLimpar.Visible = false; f.btnLimpar.Visible = false;


                f.operacao = Convert.ToByte(BLL.Operacao.Consulta);



                //var b = (Button)sender;
                //f.lblTitulo.Text =  b.Text;

                f.TopMost = true;
                f.FormBorderStyle = FormBorderStyle.FixedToolWindow;



                this.timerWebCan.Enabled = false;

                f.idFunc = this.idFunc; f.ShowDialog();

                Generator = new BarcodeEncoder();
                Generator.IncludeLabel = true;
                Generator.CustomLabel = Id_Venda.ToString();
                //pbQrCode.Image = new Bitmap(Generator.Encode(BarcodeFormat.QRCode, result.Text));

                ID_Venda_QRCODE = Convert.ToInt32(Id_Venda);

                //this.pbQrCode.Visible = true;








            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, ex.Source);
            }
        }
        //private void Validar(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ing.ID_VENDA = ID_Venda_QRCODE;
        //        dr = ing.ConsultarValidade();
        //        if (dr.Read())
        //        {
        //            if (dr[0].ToString()=="1")
        //            {
        //                ing.ValidarIngresso();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Esse ingresso já foi utilizado ou não esta vinculado a um cliente!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            }

        //        }
        //        else
        //        {
        //            MessageBox.Show("Esse ingresso não existe!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}








        //////////////////////
    }
}
