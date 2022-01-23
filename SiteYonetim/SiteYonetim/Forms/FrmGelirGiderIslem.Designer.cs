
namespace SiteYonetim.Forms
{
    partial class FrmGelirGiderIslem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFark = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblGelenGelir = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpGelirGiderTarih = new System.Windows.Forms.DateTimePicker();
            this.lblGelenAidat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGiden = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGelirGiderSil = new System.Windows.Forms.Button();
            this.tbGelirGiderKaydıYapan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGelirGiderTur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGelirGiderTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGelirGiderAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGelirGiderEkle = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.GridViewGelirTablosu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGelirTablosu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(938, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 450);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(93, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(845, 100);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtpGelirGiderTarih);
            this.panel2.Controls.Add(this.btnGelirGiderSil);
            this.panel2.Controls.Add(this.tbGelirGiderKaydıYapan);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbGelirGiderTur);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbGelirGiderTutar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbGelirGiderAciklama);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnGelirGiderEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(93, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 179);
            this.panel2.TabIndex = 5;
            // 
            // lblFark
            // 
            this.lblFark.AutoSize = true;
            this.lblFark.Location = new System.Drawing.Point(185, 118);
            this.lblFark.Name = "lblFark";
            this.lblFark.Size = new System.Drawing.Size(36, 17);
            this.lblFark.TabIndex = 19;
            this.lblFark.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Toplam Bütçe";
            // 
            // lblGelenGelir
            // 
            this.lblGelenGelir.AutoSize = true;
            this.lblGelenGelir.Location = new System.Drawing.Point(185, 66);
            this.lblGelenGelir.Name = "lblGelenGelir";
            this.lblGelenGelir.Size = new System.Drawing.Size(36, 17);
            this.lblGelenGelir.TabIndex = 17;
            this.lblGelenGelir.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tarih";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Diğer Gelirler";
            // 
            // dtpGelirGiderTarih
            // 
            this.dtpGelirGiderTarih.Location = new System.Drawing.Point(154, 141);
            this.dtpGelirGiderTarih.Name = "dtpGelirGiderTarih";
            this.dtpGelirGiderTarih.Size = new System.Drawing.Size(220, 22);
            this.dtpGelirGiderTarih.TabIndex = 14;
            // 
            // lblGelenAidat
            // 
            this.lblGelenAidat.AutoSize = true;
            this.lblGelenAidat.Location = new System.Drawing.Point(47, 66);
            this.lblGelenAidat.Name = "lblGelenAidat";
            this.lblGelenAidat.Size = new System.Drawing.Size(36, 17);
            this.lblGelenAidat.TabIndex = 13;
            this.lblGelenAidat.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Gelen Para";
            // 
            // lblGiden
            // 
            this.lblGiden.AutoSize = true;
            this.lblGiden.Location = new System.Drawing.Point(47, 118);
            this.lblGiden.Name = "lblGiden";
            this.lblGiden.Size = new System.Drawing.Size(36, 17);
            this.lblGiden.TabIndex = 11;
            this.lblGiden.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Toplam Gider";
            // 
            // btnGelirGiderSil
            // 
            this.btnGelirGiderSil.Location = new System.Drawing.Point(390, 96);
            this.btnGelirGiderSil.Name = "btnGelirGiderSil";
            this.btnGelirGiderSil.Size = new System.Drawing.Size(152, 52);
            this.btnGelirGiderSil.TabIndex = 9;
            this.btnGelirGiderSil.Text = "Gelir - Gider Sil";
            this.btnGelirGiderSil.UseVisualStyleBackColor = true;
            this.btnGelirGiderSil.Click += new System.EventHandler(this.btnGelirGiderSil_Click);
            // 
            // tbGelirGiderKaydıYapan
            // 
            this.tbGelirGiderKaydıYapan.Location = new System.Drawing.Point(154, 112);
            this.tbGelirGiderKaydıYapan.Name = "tbGelirGiderKaydıYapan";
            this.tbGelirGiderKaydıYapan.Size = new System.Drawing.Size(220, 22);
            this.tbGelirGiderKaydıYapan.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kaydı Yapan Kişi";
            // 
            // cbGelirGiderTur
            // 
            this.cbGelirGiderTur.FormattingEnabled = true;
            this.cbGelirGiderTur.Items.AddRange(new object[] {
            "Gelir",
            "Gider"});
            this.cbGelirGiderTur.Location = new System.Drawing.Point(154, 24);
            this.cbGelirGiderTur.Name = "cbGelirGiderTur";
            this.cbGelirGiderTur.Size = new System.Drawing.Size(220, 24);
            this.cbGelirGiderTur.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Türü";
            // 
            // tbGelirGiderTutar
            // 
            this.tbGelirGiderTutar.Location = new System.Drawing.Point(154, 82);
            this.tbGelirGiderTutar.Name = "tbGelirGiderTutar";
            this.tbGelirGiderTutar.Size = new System.Drawing.Size(220, 22);
            this.tbGelirGiderTutar.TabIndex = 4;
            this.tbGelirGiderTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGelirGiderTutar_KeyPress);
            this.tbGelirGiderTutar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbGelirGiderTutar_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tutar";
            // 
            // tbGelirGiderAciklama
            // 
            this.tbGelirGiderAciklama.Location = new System.Drawing.Point(154, 54);
            this.tbGelirGiderAciklama.Name = "tbGelirGiderAciklama";
            this.tbGelirGiderAciklama.Size = new System.Drawing.Size(220, 22);
            this.tbGelirGiderAciklama.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Açıklama";
            // 
            // btnGelirGiderEkle
            // 
            this.btnGelirGiderEkle.Location = new System.Drawing.Point(390, 37);
            this.btnGelirGiderEkle.Name = "btnGelirGiderEkle";
            this.btnGelirGiderEkle.Size = new System.Drawing.Size(152, 50);
            this.btnGelirGiderEkle.TabIndex = 0;
            this.btnGelirGiderEkle.Text = "Gelir - Gider Ekle";
            this.btnGelirGiderEkle.UseVisualStyleBackColor = true;
            this.btnGelirGiderEkle.Click += new System.EventHandler(this.btnGelirGiderEkle_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.GridViewGelirTablosu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(93, 179);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(845, 171);
            this.panel5.TabIndex = 6;
            // 
            // GridViewGelirTablosu
            // 
            this.GridViewGelirTablosu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewGelirTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewGelirTablosu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewGelirTablosu.Location = new System.Drawing.Point(0, 0);
            this.GridViewGelirTablosu.Name = "GridViewGelirTablosu";
            this.GridViewGelirTablosu.ReadOnly = true;
            this.GridViewGelirTablosu.RowHeadersWidth = 51;
            this.GridViewGelirTablosu.RowTemplate.Height = 24;
            this.GridViewGelirTablosu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewGelirTablosu.Size = new System.Drawing.Size(845, 171);
            this.GridViewGelirTablosu.TabIndex = 1;
            this.GridViewGelirTablosu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewGelirTablosu_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblFark);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblGelenAidat);
            this.groupBox1.Controls.Add(this.lblGiden);
            this.groupBox1.Controls.Add(this.lblGelenGelir);
            this.groupBox1.Location = new System.Drawing.Point(548, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelir-Gider Hesabı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Aidatlardan";
            // 
            // FrmGelirGiderIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(198)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(963, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGelirGiderIslem";
            this.Text = "FrmGelirGiderIslem";
            this.Load += new System.EventHandler(this.FrmGelirGiderIslem_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGelirTablosu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGelenAidat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGiden;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGelirGiderSil;
        private System.Windows.Forms.TextBox tbGelirGiderKaydıYapan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGelirGiderTur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGelirGiderTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGelirGiderAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGelirGiderEkle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView GridViewGelirTablosu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpGelirGiderTarih;
        private System.Windows.Forms.Label lblFark;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblGelenGelir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
    }
}