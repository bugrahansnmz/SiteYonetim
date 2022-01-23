
namespace SiteYonetim.Forms
{
    partial class FrmYoneticiBilgileri
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.GridViewYoneticiSakin = new System.Windows.Forms.DataGridView();
            this.GridViewYonetici = new System.Windows.Forms.DataGridView();
            this.btnYoneticiYap = new System.Windows.Forms.Button();
            this.btnYoneticiSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblBlok = new System.Windows.Forms.Label();
            this.lblDaireNo = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dtpYoneticiTarih = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewYoneticiSakin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewYonetici)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dtpYoneticiTarih);
            this.panel2.Controls.Add(this.btnYoneticiSil);
            this.panel2.Controls.Add(this.btnYoneticiYap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(47, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 205);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(47, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 44);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(775, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(25, 201);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.GridViewYonetici);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(47, 205);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(418, 201);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(465, 205);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(17, 201);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.GridViewYoneticiSakin);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(482, 205);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(293, 201);
            this.panel7.TabIndex = 6;
            // 
            // GridViewYoneticiSakin
            // 
            this.GridViewYoneticiSakin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewYoneticiSakin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewYoneticiSakin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewYoneticiSakin.Location = new System.Drawing.Point(0, 0);
            this.GridViewYoneticiSakin.Name = "GridViewYoneticiSakin";
            this.GridViewYoneticiSakin.ReadOnly = true;
            this.GridViewYoneticiSakin.RowHeadersWidth = 51;
            this.GridViewYoneticiSakin.RowTemplate.Height = 24;
            this.GridViewYoneticiSakin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewYoneticiSakin.Size = new System.Drawing.Size(293, 201);
            this.GridViewYoneticiSakin.TabIndex = 0;
            // 
            // GridViewYonetici
            // 
            this.GridViewYonetici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewYonetici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewYonetici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewYonetici.Location = new System.Drawing.Point(0, 0);
            this.GridViewYonetici.Name = "GridViewYonetici";
            this.GridViewYonetici.ReadOnly = true;
            this.GridViewYonetici.RowHeadersWidth = 51;
            this.GridViewYonetici.RowTemplate.Height = 24;
            this.GridViewYonetici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewYonetici.Size = new System.Drawing.Size(418, 201);
            this.GridViewYonetici.TabIndex = 1;
            // 
            // btnYoneticiYap
            // 
            this.btnYoneticiYap.Location = new System.Drawing.Point(435, 152);
            this.btnYoneticiYap.Name = "btnYoneticiYap";
            this.btnYoneticiYap.Size = new System.Drawing.Size(103, 36);
            this.btnYoneticiYap.TabIndex = 1;
            this.btnYoneticiYap.Text = "Yönetici Yap";
            this.btnYoneticiYap.UseVisualStyleBackColor = true;
            this.btnYoneticiYap.Click += new System.EventHandler(this.btnYoneticiYap_Click);
            // 
            // btnYoneticiSil
            // 
            this.btnYoneticiSil.Location = new System.Drawing.Point(33, 152);
            this.btnYoneticiSil.Name = "btnYoneticiSil";
            this.btnYoneticiSil.Size = new System.Drawing.Size(103, 36);
            this.btnYoneticiSil.TabIndex = 2;
            this.btnYoneticiSil.Text = "Yönetici Sil";
            this.btnYoneticiSil.UseVisualStyleBackColor = true;
            this.btnYoneticiSil.Click += new System.EventHandler(this.btnYoneticiSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Blok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Daire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(572, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Yönetici Olduğu Tarih";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(71, 74);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(0, 17);
            this.lblAd.TabIndex = 9;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(153, 74);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(0, 17);
            this.lblSoyad.TabIndex = 10;
            // 
            // lblBlok
            // 
            this.lblBlok.AutoSize = true;
            this.lblBlok.Location = new System.Drawing.Point(267, 77);
            this.lblBlok.Name = "lblBlok";
            this.lblBlok.Size = new System.Drawing.Size(0, 17);
            this.lblBlok.TabIndex = 11;
            // 
            // lblDaireNo
            // 
            this.lblDaireNo.AutoSize = true;
            this.lblDaireNo.Location = new System.Drawing.Point(361, 77);
            this.lblDaireNo.Name = "lblDaireNo";
            this.lblDaireNo.Size = new System.Drawing.Size(0, 17);
            this.lblDaireNo.TabIndex = 12;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(454, 77);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(0, 17);
            this.lblTelefon.TabIndex = 13;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(579, 77);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 17);
            this.lblTarih.TabIndex = 14;
            // 
            // dtpYoneticiTarih
            // 
            this.dtpYoneticiTarih.Location = new System.Drawing.Point(552, 160);
            this.dtpYoneticiTarih.Name = "dtpYoneticiTarih";
            this.dtpYoneticiTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpYoneticiTarih.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTarih);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblDaireNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblBlok);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 120);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şuanki Yönetici Bilgileri";
            // 
            // FrmYoneticiBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmYoneticiBilgileri";
            this.Text = "FrmYoneticiBilgileri";
            this.Load += new System.EventHandler(this.FrmYoneticiBilgileri_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewYoneticiSakin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewYonetici)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView GridViewYonetici;
        private System.Windows.Forms.DataGridView GridViewYoneticiSakin;
        private System.Windows.Forms.Button btnYoneticiYap;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblDaireNo;
        private System.Windows.Forms.Label lblBlok;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYoneticiSil;
        private System.Windows.Forms.DateTimePicker dtpYoneticiTarih;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}