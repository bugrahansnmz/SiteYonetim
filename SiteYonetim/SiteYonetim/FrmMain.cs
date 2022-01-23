using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteYonetim
{
    public partial class FrmMain : Form
    {
        private Button seciliButon;
        private Form seciliForm;

        public FrmMain()
        {
            InitializeComponent();
        }
        private void AktifButton(object btnSender)
        {

            if (btnSender != null)
            {
                if (seciliButon != (Button)btnSender)
                {
                    InAktifButon();
                    seciliButon = (Button)btnSender;
                    if (seciliButon.Text == ("Site Sakini Ekle/Güncelle"))
                    {
                        Color color = Color.FromArgb(120, 137, 239);
                        seciliButon.BackColor = color;
                        seciliButon.ForeColor = Color.Black;
                        seciliButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
                        lblBaslik.Text = "Site Sakini Ekle/Güncelle";
                    }
                    else if (seciliButon.Text == ("Aidat - Makbuz İşlemleri"))
                    {
                        Color color = Color.FromArgb(84, 137, 239);
                        seciliButon.BackColor = color;
                        seciliButon.ForeColor = Color.Black;
                        seciliButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
                        lblBaslik.Text = "Aidat - Makbuz İşlemleri";
                    }
                    else if (seciliButon.Text == ("Gelir - Gider İşlemleri"))
                    {
                        Color color = Color.FromArgb(116, 198, 243);
                        seciliButon.BackColor = color;
                        seciliButon.ForeColor = Color.Black;
                        seciliButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
                        lblBaslik.Text = "Gelir - Gider İşlemleri";
                    }
                    else if (seciliButon.Text == ("Yönetici Bilgileri"))
                    {
                        Color color = Color.FromArgb(95, 77, 172);
                        seciliButon.BackColor = color;
                        seciliButon.ForeColor = Color.Black;
                        seciliButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
                        lblBaslik.Text = "Yönetici Bilgileri";
                    }
                }
            }
        }
        private void ChildForm(Form childForm,object btnSernder) {
            if (seciliForm != null)
            {
                seciliForm.Close();
            }
            AktifButton(btnSernder);
            seciliForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelAnaPanel.Controls.Add(childForm);
            this.panelAnaPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void InAktifButon()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(43, 58, 80);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                }
            }
        }

        private void btnSakinEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.FrmSiteSakiniEkle(),sender);
        }

        private void btnAidatIslem_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.FrmAidatIslem(), sender);
        }

        private void btnGelirGiderIslem_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.FrmGelirGiderIslem(), sender);
        }

        private void btnYoneticiBilg_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.FrmYoneticiBilgileri(), sender); 
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
