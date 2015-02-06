using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZDefteri
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MesajlariYukle();
        }

        private void MesajlariYukle()
        {
            DbClass db = new DbClass();
            //'http://www.gravatar.com/avatar/'+ SUBSTRING(sys.fn_sqlvarbasetostr(HASHBYTES('MD5',EPosta)),3,32)+'?d=monsterid&s=130'
            string ekKolon = "'http://www.gravatar.com/avatar/'+ SUBSTRING(sys.fn_sqlvarbasetostr(HASHBYTES('MD5',EPosta)),3,32)+'?d=monsterid&s=130'";
            DataSet mesajlar = db.DataSetGetir("SELECT *,"+ekKolon+" as Avatar FROM Mesaj where OnayDurumu=1");
            dlMesajlar.DataSource = mesajlar;
            dlMesajlar.DataBind();
        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {
            YorumGonder();
        }

        private void YorumGonder()
        {
            DbClass db = new DbClass();
            string sqlCumlem = String.Format("INSERT INTO Mesaj Values('{0}','{1}','{2}','{3}')", txtAd.Text, txtEPosta.Text, txtMesaj.Text, 0);
            try
            {
                db.ExecuteQuery(sqlCumlem, 0);
                ltrMesaj.Text = "<p class='bg-success'>Mesajınız kaydedilmiştir.Onaylandıktan sonra yayınlanıcaktır.</p>";
            }
            catch (Exception hata)
            {
                ltrMesaj.Text = "<p class='bg-danger'>Bir hata oluştu.Lütfen tekrar deneyin.</p>";
            }

        }
    }
}