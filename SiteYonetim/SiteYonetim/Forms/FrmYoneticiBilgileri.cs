using SiteYonetim.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteYonetim.Forms
{
    public partial class FrmYoneticiBilgileri : Form
    {
        DbSYSEntities2 db = new DbSYSEntities2();
        public FrmYoneticiBilgileri()
        {
            InitializeComponent();
        }
        private void YoneticiListele()
        {
            GridViewYoneticiSakin.DataSource = db.SiteSakinleri.ToList();
            GridViewYoneticiSakin.Columns[0].Visible = false;
        }
        private void YeniYoneticiListele()
        {
            GridViewYonetici.DataSource = db.Yonetici.ToList();
            GridViewYonetici.Columns[0].Visible = false;
        }
        private void FrmYoneticiBilgileri_Load(object sender, EventArgs e)
        {
            YoneticiListele();
            YeniYoneticiListele();
            YoneticiBilgi();
        }

        private void btnYoneticiYap_Click(object sender, EventArgs e)
        {
            Yonetici s = new Yonetici();
            s.Blok = GridViewYoneticiSakin.CurrentRow.Cells[1].Value.ToString();
            s.DaireNo =Convert.ToInt32(GridViewYoneticiSakin.CurrentRow.Cells[2].Value.ToString());
            s.Ad = GridViewYoneticiSakin.CurrentRow.Cells[3].Value.ToString();
            s.Soyad = GridViewYoneticiSakin.CurrentRow.Cells[4].Value.ToString();
            s.Telefon = GridViewYoneticiSakin.CurrentRow.Cells[5].Value.ToString();
            s.Tarih = dtpYoneticiTarih.Value;
            db.Yonetici.Add(s);
            db.SaveChanges();
            MessageBox.Show("Yönetici Kaydedildi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YeniYoneticiListele();
            YoneticiBilgi();
        }
        private void YoneticiBilgi()
        {
            if (GridViewYonetici.RowCount == 0)
            {

            }
            else
            {
                var enyuksek = db.Yonetici.Max(p => p.Tarih);
                var degerler = from item in db.Yonetici
                               where item.Tarih == enyuksek
                               select item;
                List<Yonetici> lis = degerler.ToList();

                lblAd.Text = Convert.ToString(lis.ElementAt(0).Ad);
                lblSoyad.Text = Convert.ToString(lis.ElementAt(0).Soyad);
                lblBlok.Text = Convert.ToString(lis.ElementAt(0).Blok);
                lblDaireNo.Text = Convert.ToString(lis.ElementAt(0).DaireNo);
                lblTelefon.Text = Convert.ToString(lis.ElementAt(0).Telefon);
                lblTarih.Text = Convert.ToString(lis.ElementAt(0).Tarih);
            }
           
         
        }

        private void btnYoneticiSil_Click(object sender, EventArgs e)
        {
            if (GridViewYonetici.RowCount == 1) {
                lblAd.Text = "";
                lblBlok.Text = "";
                lblDaireNo.Text = "";
                lblSoyad.Text = "";
                lblTarih.Text = "";
                lblTelefon.Text = "";
                int id = Convert.ToInt32(GridViewYonetici.CurrentRow.Cells[0].Value.ToString());
                var x = db.Yonetici.Find(id);
                db.Yonetici.Remove(x);
                db.SaveChanges();
                MessageBox.Show("Silindi");
                YeniYoneticiListele();
                YoneticiBilgi();

            }
            else
            {
                int id = Convert.ToInt32(GridViewYonetici.CurrentRow.Cells[0].Value.ToString());
                var x = db.Yonetici.Find(id);
                db.Yonetici.Remove(x);
                db.SaveChanges();
                MessageBox.Show("Silindi");
                YeniYoneticiListele();
                YoneticiBilgi();
            }
          
        }
    }
}
