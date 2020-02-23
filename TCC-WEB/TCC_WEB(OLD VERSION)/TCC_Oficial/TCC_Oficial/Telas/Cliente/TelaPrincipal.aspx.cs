using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Configuration;
using System.IO;
using System.Drawing;

namespace TCC_Oficial.Telas.Cliente
{
    public partial class Modelo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dt = obj.Listar();
            if (dt.Rows.Count>0)
            {
                MaxBanner = dt.Rows.Count;
                AtualBanner = 0;
                //if (!File.Exists("~Banner/"+ dt.Rows[AtualBanner][2].ToString()))
                //{

                //    FileStream fs = new FileStream(dt.Rows[AtualBanner][1].ToString(), FileMode.Open, FileAccess.Read);
                //    MemoryStream ms = new MemoryStream();
                //    fs.CopyTo(ms);
                //    byte[] tmpBytes = new byte[fs.Length];
                //    fs.Read(tmpBytes, 0, Convert.ToInt32(fs.Length));

                //    FileImgSave.PostedFile.InputStream.Read(tmpBytes, 0, Convert.ToInt32(fs.Length));

                //    FileImgSave.SaveAs(Request.PhysicalApplicationPath+"/Banner/" + dt.Rows[AtualBanner][2].ToString());
                //}
                
                banner.ImageUrl =  "Banner\\"+ dt.Rows[AtualBanner][2].ToString();
            }
        }
        int MaxBanner, AtualBanner;
        DataTable dt = new DataTable();
        BLL.Novidades obj = new BLL.Novidades();
        protected void imgSetaEsquerda_Click(object sender, ImageClickEventArgs e)
        {

        }

       
        protected void timerNovidade_Tick(object sender, EventArgs e)
        {
           if (AtualBanner != MaxBanner)
            {
                banner.ImageUrl = dt.Rows[AtualBanner][1].ToString();

                ++AtualBanner;

            }
            else
            {
                AtualBanner = 0;
                banner.ImageUrl = dt.Rows[AtualBanner][1].ToString();
            }
            
        }

        protected void imgSetaDireita_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}