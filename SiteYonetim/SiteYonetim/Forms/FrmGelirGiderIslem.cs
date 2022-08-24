using SiteYonetim.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SiteYonetim.Forms
{
    public partial class FrmGelirGiderIslem : Form
    {
        DbSYSEntities2 db = new DbSYSEntities2();
        int gelirToplam = 0;
        int giderToplam = 0;
        List<char> txtMoneyValue;
        public FrmGelirGiderIslem()
        {
            InitializeComponent();
            txtMoneyValue = new System.Collections.Generic.List<char>();
        }

        private void FrmGelirGiderIslem_Load(object sender, EventArgs e)
        {
            GelirGiderListele();
            GelirGiderAidatHesapla();
        }
        private void GelirGiderListele()
        {
            GridViewGelirTablosu.DataSource = db.GelirGider.ToList();
            GridViewGelirTablosu.Columns[0].Visible = false;
        }
        private void GelirGiderAidatHesapla()
        {
            if (GridViewGelirTablosu.RowCount == 0)
            {
                var toplam = db.SiteAidat.Sum(p => p.Tutar);
                lblGelenAidat.Text = Convert.ToString(toplam);
                lblFark.Text = Convert.ToString(toplam);
            }
            else
            {
                var gelir = from item in db.GelirGider
                            where item.GelirGiderTuru == "Gelir"
                            select item;
                List<GelirGider> lisGelir = gelir.ToList();
                for (int i = 0; i < lisGelir.Count; i++)
                {
                    gelirToplam += Convert.ToInt32(lisGelir.ElementAt(i).GelirGiderTutar);
                }
                var aidatToplam = db.SiteAidat.Sum(p => p.Tutar);
                var genelToplam = aidatToplam + gelirToplam;
                lblGelenAidat.Text = Convert.ToString(aidatToplam);
                lblGelenGelir.Text = Convert.ToString(gelirToplam);


                var gider = from item in db.GelirGider
                            where item.GelirGiderTuru == "Gider"
                            select item;

                List<GelirGider> lisGider = gider.ToList();
                for (int i = 0; i < lisGider.Count; i++)
                {
                    giderToplam += Convert.ToInt32(lisGider.ElementAt(i).GelirGiderTutar);
                }
                lblGiden.Text = Convert.ToString(giderToplam);
                lblFark.Text = Convert.ToString(genelToplam - giderToplam);
            }
        }
        void Gelir()
        {
            lblGelenGelir.Text = Convert.ToString(Convert.ToDecimal(tbGelirGiderTutar.Text) + Convert.ToDecimal(lblGelenGelir.Text));
            decimal gelenAidat = (Convert.ToDecimal(lblGelenAidat.Text));
            decimal gelenGelir = Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(lblGelenGelir.Text).ToString()));
            decimal giden = Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(lblGiden.Text).ToString()));
            lblFark.Text = Convert.ToString((gelenAidat + gelenGelir) - giden);
        }
        void Gider()
        {
            lblGiden.Text = Convert.ToString(Convert.ToDecimal(tbGelirGiderTutar.Text) + Convert.ToDecimal(lblGiden.Text));
            decimal gelenAidat = (Convert.ToDecimal(lblGelenAidat.Text));
            decimal gelenGelir = Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(lblGelenGelir.Text).ToString()));
            decimal giden = Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(lblGiden.Text).ToString()));
            lblFark.Text = Convert.ToString((gelenAidat + gelenGelir) - giden);
        }
        
        private void btnGelirGiderEkle_Click(object sender, EventArgs e)
        {
            if (cbGelirGiderTur.Text == "Gelir")
            {
                GelirGider s = new GelirGider();
                s.GelirGiderTuru = cbGelirGiderTur.Text;
                s.GelirGiderTutar = Convert.ToDecimal(tbGelirGiderTutar.Text);
                s.GelirGiderAciklama = tbGelirGiderAciklama.Text;
                s.Tarih = dtpGelirGiderTarih.Value;
                s.KaydedenKisi = tbGelirGiderKaydıYapan.Text;
                db.GelirGider.Add(s);
                db.SaveChanges();
                MessageBox.Show("Kaydedildi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Gelir();
                // Fark();
                GelirGiderListele();
            }
            else if (cbGelirGiderTur.Text == "Gider")
            {
                GelirGider s = new GelirGider();
                s.GelirGiderTuru = cbGelirGiderTur.Text;
                s.GelirGiderTutar = Convert.ToDecimal(tbGelirGiderTutar.Text);
                s.GelirGiderAciklama = tbGelirGiderAciklama.Text;
                s.Tarih = dtpGelirGiderTarih.Value;
                s.KaydedenKisi = tbGelirGiderKaydıYapan.Text;
                db.GelirGider.Add(s);
                db.SaveChanges();
                MessageBox.Show("Kaydedildi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Gider();
                //  Fark();
                GelirGiderListele();
            }


        }
        void GiderSil()
        {
            lblGiden.Text = Convert.ToString(Convert.ToDecimal(lblGiden.Text) - Convert.ToDecimal(tbGelirGiderTutar.Text));
            decimal gelenAidat = Convert.ToDecimal(lblGelenAidat.Text);
            decimal gelenGelir = Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(lblGelenGelir.Text).ToString()));
            decimal giden = Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(lblGiden.Text).ToString()));
            lblFark.Text = Convert.ToString(((gelenAidat + gelenGelir) - giden) );
          
        }
        void GelirSil()
        {
            lblGelenGelir.Text = Convert.ToString( Convert.ToDecimal(lblGelenGelir.Text)- Convert.ToDecimal(tbGelirGiderTutar.Text));
            // lblFark.Text = Convert.ToString((Convert.ToInt32(lblGelenAidat.Text) + Convert.ToInt32(lblGelenGelir.Text)) - Convert.ToInt32(lblGiden.Text));
            decimal gelenAidat = (Convert.ToDecimal(lblGelenAidat.Text));
            decimal gelenGelir = Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(lblGelenGelir.Text).ToString()));
            decimal giden = Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(lblGiden.Text).ToString()));
            lblFark.Text = Convert.ToString((gelenAidat + gelenGelir) - giden);

        }
        private void btnGelirGiderSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GridViewGelirTablosu.CurrentRow.Cells[0].Value.ToString());
            var x = db.GelirGider.Find(id);
            if (x.GelirGiderTuru == "Gider")
            {
                db.GelirGider.Remove(x);
                db.SaveChanges();
                MessageBox.Show("Silindi");
                GiderSil();
                //Fark();
                GelirGiderListele();
            }
            else if (x.GelirGiderTuru == "Gelir")
            {
                db.GelirGider.Remove(x);
                db.SaveChanges();
                MessageBox.Show("Silindi");
                GelirSil();
                // Fark();
                GelirGiderListele();
            }


        }
        private void tbGelirGiderTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                SetValue();
                SetTextbox();
            }
            else
            {
                e.Handled = true;
            }
        }
        public void SetValue()
        {
            txtMoneyValue.Clear();
            for (int i = 0; i < tbGelirGiderTutar.Text.Length; i++)
            {
                txtMoneyValue.Add(tbGelirGiderTutar.Text[i]);
            }
        }
        public void SetTextbox()
        {
            string s = string.Empty;
            if (txtMoneyValue.Count > 2)
            {
                txtMoneyValue.Remove(',');
                txtMoneyValue.Insert(txtMoneyValue.Count - 1, ',');
            }


            if (txtMoneyValue.Count >= 6)
            {
                RemovePoints();
                int pointCount = 1 + (txtMoneyValue.Count - 6) / 3;

                for (int i = 1; i <= pointCount; i++)
                {
                    int pointposition = ((txtMoneyValue.Count - 4) - (i * 1)) - ((i - 1) * 3);
                    txtMoneyValue.Insert(pointposition, '.');
                }
            }

            for (int i = 0; i < txtMoneyValue.Count; i++)
            {
                s += txtMoneyValue[i];
            }
            tbGelirGiderTutar.Text = s;
            tbGelirGiderTutar.SelectionStart = tbGelirGiderTutar.Text.Length;
        }
        private void RemovePoints()
        {
            for (int i = 0; i < txtMoneyValue.Count; i++)
            {
                if (txtMoneyValue[i] == '.')
                    txtMoneyValue.RemoveAt(i);
            }

        }
        private void tbGelirGiderTutar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                txtMoneyValue.Clear();
                tbGelirGiderTutar.Text = "";
            }
        }

        private void GridViewGelirTablosu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbGelirGiderTutar.Text = GridViewGelirTablosu.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
