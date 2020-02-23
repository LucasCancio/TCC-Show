using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace TCCSHOW.Sistema
{
    public partial class Hub : Modelos.ModeloGeralCompleto
    {
        public Hub()
        {

            InitializeComponent();
            
            MenuHub.Renderer = new MyRenderer();
            lblComedyHouse.Text = "Comedy" + Environment.NewLine + "House";
            mArtista = this.btnArtista.Margin;
            mSistema = this.btnSistema.Margin;
            mCliente = this.btnCliente.Margin;
            mEvento = this.btnEvento.Margin;
            mIngresso = this.btnIngresso.Margin;

            sArtista = this.btnArtista.Size;
            sSistema = this.btnSistema.Size;
            sCliente = this.btnCliente.Size;
            sEvento = this.btnEvento.Size;
            sIngresso = this.btnIngresso.Size;


        }

        private string _Nome;
        public string Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                _Nome = value;
            }
        }

        int x, y;
        Point Point = new Point();

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.Firebrick; }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.Silver; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Firebrick; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Firebrick; }
            }

        }

        private void relogio(Object sender, EventArgs e)
        {

            this.Hora.Text = "      " + System.DateTime.Now.ToString().Substring(10, 6) + Environment.NewLine + System.DateTime.Now.ToString().Substring(0, 10);
            if (System.DateTime.Now.Hour < 12)
            {
                this.lblTempo.Text = "Bom Dia";
            }
            else if (System.DateTime.Now.Hour > 17)
            {
                this.lblTempo.Text = "Boa Noite";
            }
            else
            {
                this.lblTempo.Text = "Boa Tarde";
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point = Control.MousePosition;
                Point.X -= x;
                Point.Y -= y;
                this.Location = Point;
                Application.DoEvents();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }
        ///////////////////////////////////////////////////////////////////////

        private void SubinharLbl(Object o, MouseEventArgs e)
        {
            try
            {
                var b = (Label)o;

                b.Font = new Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Bold);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DesSubinharLbl(Object o, EventArgs e)
        {
            try
            {
                var b = (Label)o;

                b.Font = new Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CarregarCampos(object o, EventArgs e) {
            try
            {
             
                //this.Size = new System.Drawing.Size(1942, 982);

                switch (NivelAcesso)
                {
                    case 2://ATENDENTE

                        this.lblNomeTool.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF00FF");
                        this.btnSistema.Visible = false;
                        this.btnFunc.Visible = false;
                        this.btnFinanceiro.Visible = false;
                        this.btnDescontos.Visible = false;
                        this.btnPrecos.Visible = false;
                        break;
                    case 1://GERENTE
                        this.lblNomeTool.ForeColor = Color.DeepSkyBlue;
                        this.btnAddFunc.ShortcutKeys = Keys.F6;
                        this.btnRelatorio.ShortcutKeys = Keys.F7;
                        this.btnAddContas.ShortcutKeys = Keys.F8;
                        break;
                }


                BLL.Login log = new BLL.Login();
                log.SpIniciar('I');



             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    
        private void Consultar(Object o, EventArgs e) {
            var b = (ToolStripMenuItem)o;
            bool _found = false;
            
            lblComedyHouse.Visible = true;
            if (this._objForm != null)
            {
                if (!this._objForm.IsDisposed)
                {
                    //if (_objForm.Name.IndexOf("Cadastro") > 0)
                    //{
                    //msg.lblTexto.Text = "Gostaria de cancelar a operação?";
                    //msg.btnNao.Click += RespostaNao;
                    //msg.ShowDialog();

                    if (MessageBox.Show("Gostaria de cancelar a operação?!", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;

                    }

                    //}
                }

                _objForm.Visible = false;
            }
            _objForm?.Dispose();
            switch (b.Name)
            {

                case "btnEditArtista":
                    //foreach (Form _openForm in Application.OpenForms)
                    //{
                    //    if (_openForm is Negocios.Artistas.frmArtistaConsulta)
                    //    {
                    //        _openForm.Focus();
                    //        _found = true;
                    //    }
                    //}

                    //if (!_found)

                    //{
                    _objForm = new Negocios.Artistas.frmArtistaConsulta
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                        NivelAcesso = NivelAcesso,
                        idFunc =Convert.ToInt32(tool_ID.Text),
                        

                    };
                    pnCentro.Controls.Add(_objForm);
                    pnCentro.Visible = false;
                    _objForm.Show();
                    LogoAnimation.ShowSync(pnCentro);
                    //    Negocios.Artistas.frmArtistaConsulta f = new Negocios.Artistas.frmArtistaConsulta();
                    //    f.StartPosition = FormStartPosition.Manual;
                    //    f.Location= this.pnCentro.Location;
                    //    f.TopMost = true;
                    //    f.Show();

                    //}


                    //_objForm = new Negocios.Artistas.frmArtistaConsulta
                    //{
                    //    TopLevel = false,
                    //    FormBorderStyle = FormBorderStyle.FixedSingle,
                    //    Dock = DockStyle.None,
                    //};
                    //pnCentro.Controls.Add(_objForm);
                    //_objForm.Show();
                    //if (!panelCentro.Contains(Negocios.Agente.Componentes.AgenteCadastro.Instance))
                    //{
                    //    panelCentro.Controls.Add(Negocios.Agente.Componentes.AgenteCadastro.Instance);
                    //    Negocios.Agente.Componentes.AgenteCadastro.Instance.Dock = DockStyle.Fill;
                    //    Negocios.Agente.Componentes.AgenteCadastro.Instance.BringToFront();
                    //}
                    //else
                    //{
                    //    Negocios.Agente.Componentes.AgenteCadastro.Instance.BringToFront();
                    //}
                    break;
                case "btnEditAgente":

                   


                        _objForm = new Negocios.Agente.frmAgenteConsulta
                        {
                            TopLevel = false,
                            FormBorderStyle = FormBorderStyle.None,
                            Dock = DockStyle.Fill,
                            NivelAcesso= NivelAcesso,
                            idFunc = Convert.ToInt32(tool_ID.Text),
                        };
                    
                    pnCentro.Controls.Add(_objForm);
                    pnCentro.Visible = false;
                    _objForm.Show();
                    LogoAnimation.ShowSync(pnCentro);


                    break;
                case "btnEditFunc":



                    _objForm = new Negocios.Funcionario.frmFuncionarioConsulta
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                        NivelAcesso = NivelAcesso,
                        idFunc =Convert.ToInt32(tool_ID.Text),
                    };
                    pnCentro.Controls.Add(_objForm);
                    pnCentro.Visible = false;
                    _objForm.Show();
                    LogoAnimation.ShowSync(pnCentro);


                    break;
                case "btnLog":



                    _objForm = new Log.frmLog
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                        NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),
                    };
                    pnCentro.Controls.Add(_objForm);
                    pnCentro.Visible = false;
                    _objForm.Show();
                    LogoAnimation.ShowSync(pnCentro);


                    break;
                case "btnConsultarIngresso":



                    _objForm = new Negocios.Ingresso.frmIngressoConsultar
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                        NivelAcesso = NivelAcesso, idFunc = Convert.ToInt32(tool_ID.Text),
                        Funcionario = this.lblNomeTool.Text,
                    };
                    pnCentro.Controls.Add(_objForm);
                    pnCentro.Visible = false;
                    _objForm.Show();
                    LogoAnimation.ShowSync(pnCentro);

                   


                    break;
                case "btnUsuario":



                    _objForm = new Negocios.Usuarios.frmUsuarioGerenciar
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                        NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),
                    };
                    pnCentro.Controls.Add(_objForm);
                    pnCentro.Visible = false;
                    _objForm.Show();
                    LogoAnimation.ShowSync(pnCentro);


                    break;
                case "btnEditEvento":



                    _objForm = new Negocios.Eventos.frmEventoConsulta
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                        NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),
                    };
                    pnCentro.Controls.Add(_objForm);
                    pnCentro.Visible = false;
                    _objForm.Show();
                    LogoAnimation.ShowSync(pnCentro);


                    break;
                case "btnEditContas":



                    _objForm = new Negocios.Contas.frmContasConsulta
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                        NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),
                    };
                    pnCentro.Controls.Add(_objForm);
                    pnCentro.Visible = false;
                    _objForm.Show();
                    LogoAnimation.ShowSync(pnCentro);
                   


                    break;
                case "btnRelatorio":



                    _objForm = new Negocios.Contas.frmContasRelatorio
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                        NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),

                    };
                    pnCentro.Controls.Add(_objForm);
                    pnCentro.Visible = false;
                    
                    _objForm.Show();
                    LogoAnimation.ShowSync(pnCentro);


                    break;
                case "btnEditCliente":



                    _objForm = new Negocios.Cliente.frmClienteConsulta
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                        NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),
                        operacao = 0
                    };
                    pnCentro.Controls.Add(_objForm);
                    pnCentro.Visible = false;
                    _objForm.Show();
                    LogoAnimation.ShowSync(pnCentro);


                    break;
                case "btnNovidades":



                    _objForm = new Negocios.Novidades.frmNovidades
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                        NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),
                        operacao = 0
                    };
                    pnCentro.Controls.Add(_objForm);
                    pnCentro.Visible = false;
                    _objForm.Show();
                    LogoAnimation.ShowSync(pnCentro);


                    break;
                case "btnConsultarQRCODE":


                    

                    _objForm = new Negocios.Ingresso.frmConsultarQRCODE()
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                        NivelAcesso = NivelAcesso,
                        idFunc = Convert.ToInt32(tool_ID.Text),
                        Funcionario = this.lblNomeTool.Text,
                    };
                    pnCentro.Controls.Add(_objForm);
                    pnCentro.Visible = false;
                    
                    _objForm.Show();
                    LogoAnimation.ShowSync(pnCentro);




                    break;
            }

            

        }

        private Form _objForm;
        //Componentes.MessageBox msg = new Componentes.MessageBox();
        //private void RespostaNao(Object o, EventArgs e)
        //{
        //    return;
        //    msg.Hide();
        //}

        private void Cadastrar(Object o, EventArgs e)
        {
            var b = (ToolStripMenuItem)o;
           
            if (this._objForm != null)
            {
                if (!this._objForm.IsDisposed)
                {
                    //if (_objForm.Name.IndexOf("Cadastro") > 0)
                    //{
                    //msg.lblTexto.Text = "Gostaria de cancelar a operação?";
                    //msg.btnNao.Click += RespostaNao;
                    //msg.ShowDialog();

                    if (MessageBox.Show("Gostaria de cancelar a operação?!", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;

                    }

                    //}
                }


            }

                lblComedyHouse.Visible = true;
                _objForm?.Close();
                switch (b.Name)
                {

                    case "btnAddArtista":



                        _objForm = new Negocios.Artistas.frmArtistaCadastro
                        {
                            TopLevel = false,
                            FormBorderStyle = FormBorderStyle.None,
                            Dock = DockStyle.Fill,
                            operacao = 0,
                            NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),

                        };
                        pnCentro.Controls.Add(_objForm);
                        pnCentro.Visible = false;
                        _objForm.Show();
                        LogoAnimation.ShowSync(pnCentro);
                        
                        
                        //if (!panelCentro.Contains(Negocios.Agente.Componentes.AgenteCadastro.Instance))
                        //{
                        //    panelCentro.Controls.Add(Negocios.Agente.Componentes.AgenteCadastro.Instance);
                        //    Negocios.Agente.Componentes.AgenteCadastro.Instance.Dock = DockStyle.Fill;
                        //    Negocios.Agente.Componentes.AgenteCadastro.Instance.BringToFront();
                        //}
                        //else
                        //{
                        //    Negocios.Agente.Componentes.AgenteCadastro.Instance.BringToFront();
                        //}
                        break;
                    case "btnAddAgente":



                        _objForm = new Negocios.Agente.frmAgenteCadastro
                        {
                            TopLevel = false,
                            FormBorderStyle = FormBorderStyle.None,
                            Dock = DockStyle.Fill,
                            NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),
                            operacao = 0
                        };
                        pnCentro.Controls.Add(_objForm);
                        pnCentro.Visible = false;
                        _objForm.Show();
                        LogoAnimation.ShowSync(pnCentro);


                        break;
                    case "btnAddFunc":



                        _objForm = new Negocios.Funcionario.frmFuncionarioCadastro
                        {
                            TopLevel = false,
                            FormBorderStyle = FormBorderStyle.None,
                            Dock = DockStyle.Fill,
                            NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),
                            operacao = 0
                        };
                        pnCentro.Controls.Add(_objForm);
                        pnCentro.Visible = false;
                        _objForm.Show();
                        LogoAnimation.ShowSync(pnCentro);


                        break;
                    case "btnAddEvento":



                        _objForm = new Negocios.Eventos.frmEventoCadastro
                        {
                            TopLevel = false,
                            FormBorderStyle = FormBorderStyle.None,
                            Dock = DockStyle.Fill,
                            NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),
                            operacao = 0
                        };
                        pnCentro.Controls.Add(_objForm);
                        pnCentro.Visible = false;
                        _objForm.Show();
                        LogoAnimation.ShowSync(pnCentro);


                        break;
                    case "btnFuncao":



                        _objForm = new Negocios.Funcao.frmFuncao
                        {
                            TopLevel = false,
                            FormBorderStyle = FormBorderStyle.None,
                            Dock = DockStyle.Fill,
                            NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),
                            operacao = 0
                        };
                        pnCentro.Controls.Add(_objForm);
                        pnCentro.Visible = false;
                        _objForm.Show();
                        LogoAnimation.ShowSync(pnCentro);


                        break;
                    case "btnVenderIngresso":



                        _objForm = new Negocios.Assento.frmAssentoPrincipal
                        {
                            TopLevel = false,
                            FormBorderStyle = FormBorderStyle.None,
                            Dock = DockStyle.Fill,
                            NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),
                            operacao = 0,
                            Funcionario= this.lblNomeTool.Text
                        };
                        pnCentro.Controls.Add(_objForm);
                        
                        pnCentro.Visible = false;
                        
                        _objForm.Show();
                        LogoAnimation.ShowSync(pnCentro);


                        break;
                    case "btnAddContas":



                        _objForm = new Negocios.Contas.frmContasCadastro
                        {
                            TopLevel = false,
                            FormBorderStyle = FormBorderStyle.None,
                            Dock = DockStyle.Fill,
                            NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),
                            operacao = 0
                        };
                        pnCentro.Controls.Add(_objForm);
                        pnCentro.Visible = false;
                        _objForm.Show();
                        LogoAnimation.ShowSync(pnCentro);


                        break;
                case "btnFormasDePag":



                    _objForm = new Negocios.FormaPagamento.frmFormaDePag
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                        NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),
                        operacao = 0
                    };
                    pnCentro.Controls.Add(_objForm);
                    pnCentro.Visible = false;
                    _objForm.Show();
                    LogoAnimation.ShowSync(pnCentro);


                    break;
                case "btnPrecos":



                    _objForm = new Negocios.Preco.frmPrecos
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                        NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),
                        operacao = 0
                    };
                    pnCentro.Controls.Add(_objForm);
                    pnCentro.Visible = false;
                    _objForm.Show();
                    LogoAnimation.ShowSync(pnCentro);


                    break;
                case "btnAddCliente":



                    _objForm = new Negocios.Cliente.frmClienteCadastro
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                        NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),
                        operacao = 0
                    };
                    pnCentro.Controls.Add(_objForm);
                    pnCentro.Visible = false;
                    _objForm.Show();
                    LogoAnimation.ShowSync(pnCentro);


                    break;
                case "btnDescontos":



                    _objForm = new Negocios.Descontos.frmDescontos
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                        NivelAcesso = NivelAcesso, idFunc=Convert.ToInt32(tool_ID.Text),
                        operacao = 0
                    };
                    pnCentro.Controls.Add(_objForm);
                    pnCentro.Visible = false;
                    _objForm.Show();
                    LogoAnimation.ShowSync(pnCentro);


                    break;

            }
               
                //this.pnCentro.Size = this.pnCentro.Size;

            }



            private void UserControl(object sender, EventArgs e)
            {
                var b = (PictureBox)sender;
                this.pnSelect.Width = b.Width;
                this.pnSelect.Visible = true;
                this.pnSelect.Left = b.Left;


                switch (b.Name)
                {
                    case "btnArtista":

                        break;
                    case "btnAdm":
                        //if (!panelSelecao.Contains(Sistema.UserControls.userAdmin.Instance))
                        //{
                        //    panelSelecao.Controls.Add(Sistema.UserControls.userAdmin.Instance);
                        //    Sistema.UserControls.userAdmin.Instance.Dock = DockStyle.Fill;
                        //    Sistema.UserControls.userAdmin.Instance.BringToFront();
                        //}
                        //else
                        //{
                        //    Sistema.UserControls.userAdmin.Instance.BringToFront();
                        //}
                        //Sistema.UserControls.userAdmin.Instance.btnArtista.Click += UserControlAdm;
                        break;
                    case "btnRec":
                        MessageBox.Show("rec");
                        _objForm?.Close();

                        _objForm = new Negocios.Artistas.frmArtistaConsulta
                        {
                            TopLevel = false,
                            FormBorderStyle = FormBorderStyle.None,
                            Dock = DockStyle.Fill,
                        };
                        pnCentro.Controls.Add(_objForm);
                        _objForm.Show();
                        //if (!panelCentro.Contains(Negocios.Agente.Componentes.AgenteCadastro.Instance))
                        //{
                        //    panelCentro.Controls.Add(Negocios.Agente.Componentes.AgenteCadastro.Instance);
                        //    Negocios.Agente.Componentes.AgenteCadastro.Instance.Dock = DockStyle.Fill;
                        //    Negocios.Agente.Componentes.AgenteCadastro.Instance.BringToFront();
                        //}
                        //else
                        //{
                        //    Negocios.Agente.Componentes.AgenteCadastro.Instance.BringToFront();
                        //}
                        break;


                }

            }

            private void UserControlAdm(object o, EventArgs e) {
                var b = (PictureBox)o;
                switch (b.Name)
                {
                    case "btnArtista":

                        //if (!panelSelecao.Contains(UserControls.userArtistaHub.Instance))
                        //{
                        //    panelSelecao.Controls.Add(UserControls.userArtistaHub.Instance);
                        //    UserControls.userArtistaHub.Instance.Dock = DockStyle.Fill;
                        //    UserControls.userArtistaHub.Instance.BringToFront();

                        //}
                        //else
                        //{
                        //    UserControls.userArtistaHub.Instance.BringToFront();
                        //}

                        break;

                }
            }

            private void UserControlArtista(object o, EventArgs e) {
                var b = (Bunifu.Framework.UI.BunifuTileButton)o;
                switch (b.Name)
                {
                    case "btnAdd":
                        _objForm?.Close();

                        _objForm = new Negocios.Artistas.frmArtistaCadastro
                        {
                            TopLevel = false,
                            FormBorderStyle = FormBorderStyle.None,
                            Dock = DockStyle.Fill,
                        };
                        pnCentro.Controls.Add(_objForm);
                        _objForm.Show();

                        break;
                    case "btnEdit":
                        _objForm?.Close();

                        _objForm = new Negocios.Artistas.frmArtistaConsulta
                        {
                            TopLevel = false,
                            FormBorderStyle = FormBorderStyle.None,
                            Dock = DockStyle.Fill,
                        };
                        pnCentro.Controls.Add(_objForm);
                        _objForm.Show();
                        break;

                    case "btnVoltar":
                        _objForm?.Close();

                        //if (!panelSelecao.Contains(Sistema.UserControls.userAdmin.Instance))
                        //{
                        //    panelSelecao.Controls.Add(Sistema.UserControls.userAdmin.Instance);
                        //    Sistema.UserControls.userAdmin.Instance.Dock = DockStyle.Fill;
                        //    Sistema.UserControls.userAdmin.Instance.BringToFront();
                        //}
                        //else
                        //{
                        //    Sistema.UserControls.userAdmin.Instance.BringToFront();
                        //}
                        //Sistema.UserControls.userAdmin.Instance.btnArtista.Click += UserControlAdm;
                        break;
                }
            }
            private void UserControlTEXTO(object sender, EventArgs e)
            {
                var b = (Label)sender;
                //this.panelSelecao.Height = b.Height+ 109;
                //this.panelSelecao.Visible = true;
                //this.panelSelecao.Top = b.Top-112;


            }


            private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
            {
                if (box != null)
                {
                    Brush textBrush = new SolidBrush(textColor);
                    Brush borderBrush = new SolidBrush(borderColor);
                    Pen borderPen = new Pen(borderBrush);
                    SizeF strSize = g.MeasureString(box.Text, box.Font);
                    Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                                   box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                                   box.ClientRectangle.Width - 1,
                                                   box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                    // Clear text and border
                    g.Clear(this.BackColor);

                    // Draw text
                    g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                    // Drawing Border
                    //Left
                    g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                    //Right
                    g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));

                    //Top1
                    g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                    //Top2
                    g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
                }
            }




        Padding mSistema, mArtista, mEvento, mCliente, mIngresso;
        Size sSistema, sArtista, sEvento, sCliente, sIngresso;

        private void Funcoes(object sender, EventArgs e)
        {
            try
            {
                if (_objForm is TCCSHOW.Negocios.Artistas.frmArtistaCadastro)
                {
                    MessageBox.Show("a");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void Deslogar(object sender, EventArgs e)
        {
            this.TopMost = true;
            if (MessageBox.Show("Deseja Sair?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { this.TopMost = false; return; }
            Sistema.Login form = new Sistema.Login();

            BLL.Log Log = new BLL.Log();
            Log.ID_FUNC =Convert.ToInt32(tool_ID.Text);
            Log.TABELA_LOG = "FUNCIONÁRIOS";
            Log.TIPO_LOG = "LOGOFF";
            Log.Log_crud('L');
            
            _objForm?.Dispose();
       
            this.Hide();

            form.ShowDialog();

            this.Dispose();
        }

        private void ClickHome(object sender, EventArgs e)
        {
            if (this._objForm != null)
            {
                if (!this._objForm.IsDisposed)
                {
                    //if (_objForm.Name.IndexOf("Cadastro") > 0)
                    //{
                    //msg.lblTexto.Text = "Gostaria de cancelar a operação?";
                    //msg.btnNao.Click += RespostaNao;
                    //msg.ShowDialog();

                    if (MessageBox.Show("Gostaria de cancelar a operação?!", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                       
                        return;

                    }
                    //_objForm.Visible = false;
                    //this.Refresh();
                    //_objForm.Dispose();
                   
                    //_objForm.Refresh();
                    //_objForm.Visible = true;
                    //}
                }


            }
            _objForm?.Dispose();
        }

        private void Hub_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login log = new Login();
            log.Show();
        }

        private void RedmMenu(object sender, EventArgs e)
            {

                bool sair = true;
                foreach (var obj in pnCentro.Controls)
                {
                    if (obj == _objForm)
                    {
                        sair = false;
                    }
                }
                if (sair == true)
                {
                    return;
                }
                if (this.MenuHub.Width == 90)
                {
                    this.MenuHub.Visible = false;
                    this.MenuHub.Width = 328;
                    this.pnCentro.Visible = false;///

                this.btnSistema.Margin = mSistema;
                this.btnArtista.Margin = mArtista;
                this.btnEvento.Margin = mEvento;
                this.btnCliente.Margin = mCliente;
                this.btnIngresso.Margin = mIngresso;

                this.btnSistema.Size= sSistema;
                this.btnArtista.Size = sArtista;
                this.btnEvento.Size = sEvento;
                this.btnCliente.Size = sCliente;
                this.btnIngresso.Size = sIngresso;

                this.btnAgente.Text = "Empresário";
                    this.btnArtista.Text = "Artista";
                    this.btnEvento.Text = "Evento";
                    this.btnFunc.Text = "Funcionário";
                    this.btnIngresso.Text = "Ingresso";
                    this.btnSistema.Text = "Sistema";
                this.btnCliente.Text = "Cliente";
                    this.btnFinanceiro.Text = "Contabilidade";
                    lblComedyHouse.Text = "Comedy" + Environment.NewLine + "House";
                    this.MenuAnimation.ShowSync(MenuHub);
                    
                    this.pnCentro.Width = pnCentro.Width - 64;
                    this.pnCentro.Location = new Point(332, 64);

                    this.PanelAnimation.ShowSync(pnCentro);///



            }
            else
                {

                    this.MenuAnimation.HideSync(MenuHub);
                 //   this.PanelAnimation.HideSync(pnCentro);///
                    this.btnAgente.Text = string.Empty;
                    this.btnArtista.Text = string.Empty;
                    this.btnEvento.Text = string.Empty;
                    this.btnFunc.Text = string.Empty;
                    this.btnIngresso.Text = string.Empty;
                    this.btnSistema.Text = string.Empty;
                    this.btnFinanceiro.Text = string.Empty;
                this.btnCliente.Text = string.Empty;
                    this.lblComedyHouse.Text = string.Empty;
                    this.MenuHub.Width = 90;

                this.btnIngresso.Margin = this.btnAgente.Margin;
                this.btnIngresso.Size = new Size(this.btnAgente.Width + 5, this.btnAgente.Height);

                this.btnSistema.Margin = this.btnAgente.Margin;
                this.btnSistema.Size = new Size(this.btnAgente.Width+5, this.btnAgente.Height);

                this.btnArtista.Margin = this.btnAgente.Margin;
                this.btnArtista.Size = new Size(this.btnAgente.Width + 5, this.btnAgente.Height);

                this.btnEvento.Margin = this.btnAgente.Margin;
                this.btnEvento.Size = new Size(this.btnAgente.Width + 5, this.btnAgente.Height);

                this.btnCliente.Margin = this.btnAgente.Margin;
                this.btnCliente.Size = new Size(this.btnAgente.Width + 5, this.btnAgente.Height);


                this.pnCentro.Width = pnCentro.Width + 64;
                    this.pnCentro.Location = new Point(235, 64);

                    this.MenuHub.Visible = true;
                    // this.pnCentro.Visible = true;///


                }

            }



            private void Minimizar(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;
            }

          
         

        private void AbrirLink(object sender, EventArgs e)
        {
            var b = (Label)sender;
            switch (b.Name)
            {
                case "lblSite":

                    

                        System.Diagnostics.Process.Start("https://www.google.com.br");

                        // System.Diagnostics.Process.Start("@");//COLOCAR URL AQUI
                    
                    break;

                case "lblFacebookH":



                    System.Diagnostics.Process.Start("https://www.facebook.com/");

                    // System.Diagnostics.Process.Start("@");//COLOCAR URL AQUI

                    break;

                case "lblTwitterH":
           


                    System.Diagnostics.Process.Start("https://twitter.com/");

                    // System.Diagnostics.Process.Start("@");//COLOCAR URL AQUI

                    break;

                case "lblInstagramH":
   


                    System.Diagnostics.Process.Start("https://www.instagram.com/?hl=pt-br");

                    // System.Diagnostics.Process.Start("@");//COLOCAR URL AQUI

                    break;

                case null: case "":
                    break;
            }
        }

        private void AbrirLinkPb(object sender, EventArgs e)
        {
            var b = (PictureBox)sender;
            switch (b.Name)
            {
   
                case "pbSite":


                    System.Diagnostics.Process.Start("https://www.google.com.br");

                    // System.Diagnostics.Process.Start("@");//COLOCAR URL AQUI

                    break;

   
                case "pbFacebookH":


                    System.Diagnostics.Process.Start("https://www.facebook.com/");

                    // System.Diagnostics.Process.Start("@");//COLOCAR URL AQUI

                    break;

 
                case "pbTwitterH":


                    System.Diagnostics.Process.Start("https://twitter.com/");

                    // System.Diagnostics.Process.Start("@");//COLOCAR URL AQUI

                    break;

  
                case "pbInstagramH":


                    System.Diagnostics.Process.Start("https://www.instagram.com/?hl=pt-br");

                    // System.Diagnostics.Process.Start("@");//COLOCAR URL AQUI

                    break;

                case null: case "":
                    break;
            }
        }







    
        }
    } 
