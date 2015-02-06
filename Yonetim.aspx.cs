using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZDefteri
{
    public partial class Yonetim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MesajYukle();
        }

        private void MesajYukle()
        {
            DbClass db = new DbClass();
            string sql = "select * from MEsaj";
            DataSet ds= db.DataSetGetir(sql);
            grdMesajlar.DataSource = ds;
            grdMesajlar.DataBind();
        }

        protected void btnOnayla_Click(object sender, EventArgs e)
        {
            MesajDurumDegistir(txtMesajID.Text, 1);
            lblSonuc.Text = "Onaylama başarılı";
            MesajYukle();
        }

     

        protected void btnSil_Click(object sender, EventArgs e)
        {
            MesajSil(txtMesajID.Text);
            lblSonuc.Text = "Silme başarılı";
            MesajYukle();
        }

      

        protected void btnPasifYap_Click(object sender, EventArgs e)
        {
            MesajDurumDegistir(txtMesajID.Text, 0);
            lblSonuc.Text = "Pasif yapma başarılı";
            MesajYukle();
        }

        private void MesajDurumDegistir(string mesajID, int durum)
        {
            DbClass db = new DbClass();
            db.ExecuteQuery("UPDATE Mesaj Set OnayDurumu='" + durum + "' where MesajID=" + mesajID, 0);

        }

        private void MesajSil(string mesajID)
        {
            DbClass db = new DbClass();
            db.ExecuteQuery("DELETE from Mesaj where MesajID=" + mesajID, 0);
        }
    }
}