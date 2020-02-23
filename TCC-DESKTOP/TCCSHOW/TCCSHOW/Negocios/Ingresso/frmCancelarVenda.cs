using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCCSHOW.Negocios.Ingresso
{
    public partial class frmCancelarVenda : Modelos.ModeloGeral
    {
        public frmCancelarVenda()
        {
            InitializeComponent();
        }
        BLL.Ingresso obj = new BLL.Ingresso();

        private int _ID_VENDA;

        public int ID_VENDA { get => _ID_VENDA; set => _ID_VENDA = value; }
     

        private void CarregarCampos(Object o, EventArgs e) {
            try
            {
                

                Oracle.DataAccess.Client.OracleDataReader dr;
                BLL.Funcionario func = new BLL.Funcionario();
                if (operacao != 0)
                {
                    BLL.Ingresso obj = new BLL.Ingresso();
                    obj.ID_VENDA = Convert.ToInt32(_ID_VENDA);
                    dr = obj.ConsultarReembolso();
                    if (dr.Read())
                    {
                        txtMotivo.Text = dr["MOTIVO"].ToString();
                        dtpData.Value = Convert.ToDateTime(dr["DATA_CANCELAMENTO"].ToString());
                        idFunc = Convert.ToInt32(dr["ID_FUNC"]);
                        this.dtpData.Enabled = false;
        

                    }

                    this.btnCancelar.Location= new Point(this.btnCancelar.Location.X+90, this.btnCancelar.Location.Y);
                    this.pbCancelar.Location = new Point(this.pbCancelar.Location.X+90, this.pbCancelar.Location.Y);

                    this.btnConfirmar.Visible = false;
                    this.pbConfirmar.Visible = false;


                }
                else
                {
                    dtpData.Value = DateTime.Now;
                }
                func.IdFuncionario = idFunc;
                dr=func.Consultar();
                if (dr.Read())
                {
                    this.txtResponsavel.Text = dr["NOME"].ToString();
                }
                
          
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }  
        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LeaveMaisculo(object sender, EventArgs e)
        {
            var b = (TextBox)sender;
            b.Text = b.Text.ToUpper();
        }
        private void Confirmar(object sender, EventArgs e)
        {
            if (this.txtMotivo.Text==string.Empty)
            {
                this.erro.SetError(lblMotivo, "O motivo é obrigatório!");
                return;
            }
            else
            {
                this.erro.SetError(lblMotivo, string.Empty);
            }
            if (MessageBox.Show("Deseja realizar o cancelamento?", "ATENÇÃO ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) { return; }
            obj.ID_VENDA = _ID_VENDA;
            obj.MOTIVO = this.txtMotivo.Text;
            obj.ID_FUNC = idFunc;
            obj.Cancelar('C');
            MessageBox.Show("Operação realizada com sucesso!");
            this.Dispose();

        }
        ////////////////////////////////
    }
}
