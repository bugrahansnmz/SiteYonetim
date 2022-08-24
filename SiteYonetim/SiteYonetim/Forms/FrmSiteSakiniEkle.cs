using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiteYonetim.Model;

namespace SiteYonetim.Forms
{
    public partial class FrmSiteSakiniEkle : Form
    {
        DbSYSEntities2 db = new DbSYSEntities2();
        public FrmSiteSakiniEkle()
        {
            InitializeComponent();
        }
        private void SiteSakiniListele()
        {
            GridViewSiteSakini.DataSource = db.SiteSakinleri.ToList();
            GridViewSiteSakini.Columns[0].Visible = false;
        }

        private void FrmSiteSakiniEkle_Load(object sender, EventArgs e)
        {
            SiteSakiniListele();
        }

        private void btnSakinEkle_Click(object sender, EventArgs e)
        {
            SiteSakinleri s = new SiteSakinleri();
            s.Ad = tbAd.Text;
            s.Soyad = tbSoyad.Text;
            s.Blok = cbBlok.Text;
            s.DaireNo = Convert.ToInt32(tbDaireNo.Text);
            s.Telefon = tbTelefon.Text;
            db.SiteSakinleri.Add(s);
            db.SaveChanges();
            MessageBox.Show("Kaydedildi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SiteSakiniListele();
        }

        private void btnSakinGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GridViewSiteSakini.CurrentRow.Cells[0].Value.ToString());
            var x = db.SiteSakinleri.Find(id);
            x.Ad = tbAd.Text;
            x.Soyad = tbSoyad.Text;
            x.Blok = cbBlok.Text;
            x.DaireNo = Convert.ToInt32(tbDaireNo.Text);
            x.Telefon = tbTelefon.Text;
            db.SaveChanges();
            MessageBox.Show("Güncellendi");
            SiteSakiniListele();
        }

        private void GridViewSiteSakini_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbBlok.Text = GridViewSiteSakini.CurrentRow.Cells[1].Value.ToString();
            tbDaireNo.Text = GridViewSiteSakini.CurrentRow.Cells[2].Value.ToString();
            tbAd.Text = GridViewSiteSakini.CurrentRow.Cells[3].Value.ToString();
            tbSoyad.Text = GridViewSiteSakini.CurrentRow.Cells[4].Value.ToString();
            tbTelefon.Text = GridViewSiteSakini.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnAidatOde_Click(object sender, EventArgs e)
        {
            if (tbTutar.Text == null || tbTutar.Text == " " || tbTutar.Text == "")
            {
                MessageBox.Show("Tutar Kısmı Boş Bırakılamaz", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SiteAidat a = new SiteAidat();
                a.Ad = tbAd.Text;
                a.Soyad = tbSoyad.Text;
                a.Blok = cbBlok.Text;
                a.DaireNo = Convert.ToInt32(tbDaireNo.Text);
                a.Telefon = tbTelefon.Text;
                a.Tarih = dtpTarih.Value;
                a.Tutar = Convert.ToInt32(tbTutar.Text);
                db.SiteAidat.Add(a);
                db.SaveChanges();
                MessageBox.Show(dtpTarih.Value.ToString() + " Tarihli Ödeme Yapıldı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void btnSakinAra_Click(object sender, EventArgs e)
        {

            if (cbBlokAra.Text == "" )
            {
                GridViewSiteSakini.DataSource = db.SiteSakinleri.ToList();
            }
            else
            {
                GridViewSiteSakini.DataSource = db.SiteSakinleri.Where(x => x.Blok == cbBlokAra.Text).ToList();
                
            }
            
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            GridViewSiteSakini.DataSource = db.SiteSakinleri.ToList();
            cbBlokAra.Text = "";
        }
    }
}
