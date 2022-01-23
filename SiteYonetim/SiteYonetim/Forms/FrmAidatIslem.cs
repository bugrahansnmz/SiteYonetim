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
    public partial class FrmAidatIslem : Form
    {
        DbSYSEntities1 db = new DbSYSEntities1();
        public FrmAidatIslem()
        {
            InitializeComponent();
        }
        private void AidatIslemListele()
        {
            GridViewAidatIslem.DataSource = db.SiteAidat.ToList();
            GridViewAidatIslem.Columns[0].Visible = false;
        }
        private void FrmAidatIslem_Load(object sender, EventArgs e)
        {
            AidatIslemListele();
        }
        private void tbAidatAd_TextChanged(object sender, EventArgs e)
        {
            string aranan = tbAidatAd.Text;
            var degerler = from item in db.SiteAidat
                           where item.Ad.Contains(aranan)
                           select item;
            GridViewAidatIslem.DataSource = degerler.ToList();
        }

        private void tbAidatSoyad_TextChanged(object sender, EventArgs e)
        {
            string aranan = tbAidatSoyad.Text;
            var degerler = from item in db.SiteAidat
                           where item.Soyad.Contains(aranan)
                           select item;
            GridViewAidatIslem.DataSource = degerler.ToList();
        }

        private void btnAidatAra_Click(object sender, EventArgs e)
        {
            if (cbAidatBlok.Text == "" && tbAidatAd.Text == "" && tbAidatSoyad.Text == "")
            {
                GridViewAidatIslem.DataSource = db.SiteAidat.ToList();
            }
            else
            {
                GridViewAidatIslem.DataSource = db.SiteAidat.Where(x => x.Blok == cbAidatBlok.Text || x.Ad == tbAidatAd.Text || x.Soyad == tbAidatSoyad.Text).ToList();
                cbAidatBlok.Text = "";
                tbAidatAd.Text = "";
                tbAidatSoyad.Text = "";
            }
        }
    }
}
