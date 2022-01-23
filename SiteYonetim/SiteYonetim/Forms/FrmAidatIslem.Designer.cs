
namespace SiteYonetim.Forms
{
    partial class FrmAidatIslem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAidatAd = new System.Windows.Forms.TextBox();
            this.cbAidatBlok = new System.Windows.Forms.ComboBox();
            this.btnAidatAra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAidatSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.GridViewAidatIslem = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAidatIslem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 450);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbAidatAd);
            this.groupBox1.Controls.Add(this.cbAidatBlok);
            this.groupBox1.Controls.Add(this.btnAidatAra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAidatSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // tbAidatAd
            // 
            this.tbAidatAd.Location = new System.Drawing.Point(77, 44);
            this.tbAidatAd.Name = "tbAidatAd";
            this.tbAidatAd.Size = new System.Drawing.Size(126, 22);
            this.tbAidatAd.TabIndex = 1;
            this.tbAidatAd.TextChanged += new System.EventHandler(this.tbAidatAd_TextChanged);
            // 
            // cbAidatBlok
            // 
            this.cbAidatBlok.FormattingEnabled = true;
            this.cbAidatBlok.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbAidatBlok.Location = new System.Drawing.Point(77, 119);
            this.cbAidatBlok.Name = "cbAidatBlok";
            this.cbAidatBlok.Size = new System.Drawing.Size(126, 24);
            this.cbAidatBlok.TabIndex = 7;
            // 
            // btnAidatAra
            // 
            this.btnAidatAra.Location = new System.Drawing.Point(39, 164);
            this.btnAidatAra.Name = "btnAidatAra";
            this.btnAidatAra.Size = new System.Drawing.Size(138, 42);
            this.btnAidatAra.TabIndex = 6;
            this.btnAidatAra.Text = "Ara";
            this.btnAidatAra.UseVisualStyleBackColor = true;
            this.btnAidatAra.Click += new System.EventHandler(this.btnAidatAra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Blok";
            // 
            // tbAidatSoyad
            // 
            this.tbAidatSoyad.Location = new System.Drawing.Point(77, 82);
            this.tbAidatSoyad.Name = "tbAidatSoyad";
            this.tbAidatSoyad.Size = new System.Drawing.Size(126, 22);
            this.tbAidatSoyad.TabIndex = 3;
            this.tbAidatSoyad.TextChanged += new System.EventHandler(this.tbAidatSoyad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 71);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(240, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 147);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(780, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 232);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(240, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(19, 232);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.GridViewAidatIslem);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(259, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(521, 232);
            this.panel6.TabIndex = 5;
            // 
            // GridViewAidatIslem
            // 
            this.GridViewAidatIslem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewAidatIslem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewAidatIslem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewAidatIslem.Location = new System.Drawing.Point(0, 0);
            this.GridViewAidatIslem.Name = "GridViewAidatIslem";
            this.GridViewAidatIslem.ReadOnly = true;
            this.GridViewAidatIslem.RowHeadersWidth = 51;
            this.GridViewAidatIslem.RowTemplate.Height = 24;
            this.GridViewAidatIslem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewAidatIslem.Size = new System.Drawing.Size(521, 232);
            this.GridViewAidatIslem.TabIndex = 0;
            // 
            // FrmAidatIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAidatIslem";
            this.Text = "FrmAidatIslem";
            this.Load += new System.EventHandler(this.FrmAidatIslem_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAidatIslem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView GridViewAidatIslem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAidatSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAidatAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAidatAra;
        private System.Windows.Forms.ComboBox cbAidatBlok;
    }
}