namespace Proje_Konfeksiyon
{
    partial class Kullanıcılar
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
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.cm_yetki = new System.Windows.Forms.ComboBox();
            this.txt_unvani = new System.Windows.Forms.TextBox();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.txt_telno = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kulismi = new System.Windows.Forms.TextBox();
            this.lbl_yetki = new System.Windows.Forms.Label();
            this.lbl_unvani = new System.Windows.Forms.Label();
            this.lbl_Adres = new System.Windows.Forms.Label();
            this.lbl_Eposta = new System.Windows.Forms.Label();
            this.lbl_kultelno = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_kuladsoyad = new System.Windows.Forms.Label();
            this.grd_listele = new System.Windows.Forms.DataGridView();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(13, 404);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(88, 32);
            this.btn_temizle.TabIndex = 12;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(706, 273);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(105, 32);
            this.btn_kayit.TabIndex = 9;
            this.btn_kayit.Text = "KAYIT ET";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // cm_yetki
            // 
            this.cm_yetki.FormattingEnabled = true;
            this.cm_yetki.Location = new System.Drawing.Point(423, 364);
            this.cm_yetki.Name = "cm_yetki";
            this.cm_yetki.Size = new System.Drawing.Size(174, 24);
            this.cm_yetki.TabIndex = 8;
            // 
            // txt_unvani
            // 
            this.txt_unvani.Location = new System.Drawing.Point(423, 335);
            this.txt_unvani.MaxLength = 20;
            this.txt_unvani.Name = "txt_unvani";
            this.txt_unvani.Size = new System.Drawing.Size(174, 22);
            this.txt_unvani.TabIndex = 7;
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(423, 273);
            this.txt_Adres.MaxLength = 100;
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(263, 22);
            this.txt_Adres.TabIndex = 5;
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(423, 304);
            this.txt_eposta.MaxLength = 50;
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(263, 22);
            this.txt_eposta.TabIndex = 6;
            // 
            // txt_telno
            // 
            this.txt_telno.Location = new System.Drawing.Point(111, 363);
            this.txt_telno.MaxLength = 11;
            this.txt_telno.Name = "txt_telno";
            this.txt_telno.Size = new System.Drawing.Size(132, 22);
            this.txt_telno.TabIndex = 4;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(111, 335);
            this.txt_sifre.MaxLength = 50;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(132, 22);
            this.txt_sifre.TabIndex = 3;
            // 
            // txt_kulismi
            // 
            this.txt_kulismi.Location = new System.Drawing.Point(110, 307);
            this.txt_kulismi.MaxLength = 50;
            this.txt_kulismi.Name = "txt_kulismi";
            this.txt_kulismi.Size = new System.Drawing.Size(132, 22);
            this.txt_kulismi.TabIndex = 2;
            // 
            // lbl_yetki
            // 
            this.lbl_yetki.AutoSize = true;
            this.lbl_yetki.Location = new System.Drawing.Point(346, 369);
            this.lbl_yetki.Name = "lbl_yetki";
            this.lbl_yetki.Size = new System.Drawing.Size(43, 17);
            this.lbl_yetki.TabIndex = 26;
            this.lbl_yetki.Text = "Yetki:";
            // 
            // lbl_unvani
            // 
            this.lbl_unvani.AutoSize = true;
            this.lbl_unvani.Location = new System.Drawing.Point(346, 340);
            this.lbl_unvani.Name = "lbl_unvani";
            this.lbl_unvani.Size = new System.Drawing.Size(56, 17);
            this.lbl_unvani.TabIndex = 27;
            this.lbl_unvani.Text = "Unvanı:";
            // 
            // lbl_Adres
            // 
            this.lbl_Adres.AutoSize = true;
            this.lbl_Adres.Location = new System.Drawing.Point(346, 276);
            this.lbl_Adres.Name = "lbl_Adres";
            this.lbl_Adres.Size = new System.Drawing.Size(49, 17);
            this.lbl_Adres.TabIndex = 28;
            this.lbl_Adres.Text = "Adres:";
            // 
            // lbl_Eposta
            // 
            this.lbl_Eposta.AutoSize = true;
            this.lbl_Eposta.Location = new System.Drawing.Point(348, 307);
            this.lbl_Eposta.Name = "lbl_Eposta";
            this.lbl_Eposta.Size = new System.Drawing.Size(62, 17);
            this.lbl_Eposta.TabIndex = 29;
            this.lbl_Eposta.Text = "E-Posta:";
            // 
            // lbl_kultelno
            // 
            this.lbl_kultelno.AutoSize = true;
            this.lbl_kultelno.Location = new System.Drawing.Point(10, 368);
            this.lbl_kultelno.Name = "lbl_kultelno";
            this.lbl_kultelno.Size = new System.Drawing.Size(82, 17);
            this.lbl_kultelno.TabIndex = 30;
            this.lbl_kultelno.Text = "Telefon No:";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(10, 337);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(41, 17);
            this.lbl_sifre.TabIndex = 31;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // lbl_kuladsoyad
            // 
            this.lbl_kuladsoyad.AutoSize = true;
            this.lbl_kuladsoyad.Location = new System.Drawing.Point(9, 307);
            this.lbl_kuladsoyad.Name = "lbl_kuladsoyad";
            this.lbl_kuladsoyad.Size = new System.Drawing.Size(92, 17);
            this.lbl_kuladsoyad.TabIndex = 32;
            this.lbl_kuladsoyad.Text = "Kullanıcı İsmi:";
            // 
            // grd_listele
            // 
            this.grd_listele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_listele.Location = new System.Drawing.Point(13, 12);
            this.grd_listele.Name = "grd_listele";
            this.grd_listele.RowTemplate.Height = 24;
            this.grd_listele.Size = new System.Drawing.Size(760, 228);
            this.grd_listele.TabIndex = 13;
            this.grd_listele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_listele_CellDoubleClick);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(706, 322);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(105, 32);
            this.btn_guncelle.TabIndex = 10;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click_1);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(706, 364);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(105, 32);
            this.btn_sil.TabIndex = 11;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(13, 218);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(48, 22);
            this.txt_ID.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ad-Soyad:";
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(110, 274);
            this.txt_AdSoyad.MaxLength = 50;
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(132, 22);
            this.txt_AdSoyad.TabIndex = 1;
            // 
            // Kullanıcılar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 449);
            this.Controls.Add(this.grd_listele);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.cm_yetki);
            this.Controls.Add(this.txt_unvani);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.txt_eposta);
            this.Controls.Add(this.txt_telno);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.txt_kulismi);
            this.Controls.Add(this.lbl_yetki);
            this.Controls.Add(this.lbl_unvani);
            this.Controls.Add(this.lbl_Adres);
            this.Controls.Add(this.lbl_Eposta);
            this.Controls.Add(this.lbl_kultelno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kuladsoyad);
            this.Controls.Add(this.txt_ID);
            this.Name = "Kullanıcılar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.Kullanıcılar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_listele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.ComboBox cm_yetki;
        private System.Windows.Forms.TextBox txt_unvani;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.TextBox txt_telno;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kulismi;
        private System.Windows.Forms.Label lbl_yetki;
        private System.Windows.Forms.Label lbl_unvani;
        private System.Windows.Forms.Label lbl_Adres;
        private System.Windows.Forms.Label lbl_Eposta;
        private System.Windows.Forms.Label lbl_kultelno;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_kuladsoyad;
        private System.Windows.Forms.DataGridView grd_listele;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_AdSoyad;
    }
}