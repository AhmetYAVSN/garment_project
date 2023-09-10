namespace Proje_Konfeksiyon
{
    partial class KayitEt
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
            this.btn_kayit = new System.Windows.Forms.Button();
            this.cm_yetki = new System.Windows.Forms.ComboBox();
            this.txt_unvani = new System.Windows.Forms.TextBox();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.txt_telno = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.lbl_yetki = new System.Windows.Forms.Label();
            this.lbl_unvani = new System.Windows.Forms.Label();
            this.lbl_Adres = new System.Windows.Forms.Label();
            this.lbl_Eposta = new System.Windows.Forms.Label();
            this.lbl_kultelno = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.txt_kulismi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_kuladsoyad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(192, 288);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(148, 50);
            this.btn_kayit.TabIndex = 9;
            this.btn_kayit.Text = "KAYIT ET";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // cm_yetki
            // 
            this.cm_yetki.FormattingEnabled = true;
            this.cm_yetki.Location = new System.Drawing.Point(173, 246);
            this.cm_yetki.Name = "cm_yetki";
            this.cm_yetki.Size = new System.Drawing.Size(210, 24);
            this.cm_yetki.TabIndex = 8;
            // 
            // txt_unvani
            // 
            this.txt_unvani.Location = new System.Drawing.Point(173, 212);
            this.txt_unvani.MaxLength = 50;
            this.txt_unvani.Name = "txt_unvani";
            this.txt_unvani.Size = new System.Drawing.Size(210, 22);
            this.txt_unvani.TabIndex = 7;
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(173, 175);
            this.txt_Adres.MaxLength = 100;
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(210, 22);
            this.txt_Adres.TabIndex = 6;
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(173, 147);
            this.txt_eposta.MaxLength = 50;
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(210, 22);
            this.txt_eposta.TabIndex = 5;
            // 
            // txt_telno
            // 
            this.txt_telno.Location = new System.Drawing.Point(173, 112);
            this.txt_telno.MaxLength = 11;
            this.txt_telno.Name = "txt_telno";
            this.txt_telno.Size = new System.Drawing.Size(210, 22);
            this.txt_telno.TabIndex = 4;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(173, 83);
            this.txt_sifre.MaxLength = 50;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(210, 22);
            this.txt_sifre.TabIndex = 3;
            // 
            // lbl_yetki
            // 
            this.lbl_yetki.AutoSize = true;
            this.lbl_yetki.Location = new System.Drawing.Point(40, 246);
            this.lbl_yetki.Name = "lbl_yetki";
            this.lbl_yetki.Size = new System.Drawing.Size(43, 17);
            this.lbl_yetki.TabIndex = 10;
            this.lbl_yetki.Text = "Yetki:";
            // 
            // lbl_unvani
            // 
            this.lbl_unvani.AutoSize = true;
            this.lbl_unvani.Location = new System.Drawing.Point(40, 217);
            this.lbl_unvani.Name = "lbl_unvani";
            this.lbl_unvani.Size = new System.Drawing.Size(56, 17);
            this.lbl_unvani.TabIndex = 11;
            this.lbl_unvani.Text = "Unvanı:";
            // 
            // lbl_Adres
            // 
            this.lbl_Adres.AutoSize = true;
            this.lbl_Adres.Location = new System.Drawing.Point(40, 182);
            this.lbl_Adres.Name = "lbl_Adres";
            this.lbl_Adres.Size = new System.Drawing.Size(49, 17);
            this.lbl_Adres.TabIndex = 12;
            this.lbl_Adres.Text = "Adres:";
            // 
            // lbl_Eposta
            // 
            this.lbl_Eposta.AutoSize = true;
            this.lbl_Eposta.Location = new System.Drawing.Point(40, 146);
            this.lbl_Eposta.Name = "lbl_Eposta";
            this.lbl_Eposta.Size = new System.Drawing.Size(62, 17);
            this.lbl_Eposta.TabIndex = 13;
            this.lbl_Eposta.Text = "E-Posta:";
            // 
            // lbl_kultelno
            // 
            this.lbl_kultelno.AutoSize = true;
            this.lbl_kultelno.Location = new System.Drawing.Point(40, 113);
            this.lbl_kultelno.Name = "lbl_kultelno";
            this.lbl_kultelno.Size = new System.Drawing.Size(82, 17);
            this.lbl_kultelno.TabIndex = 14;
            this.lbl_kultelno.Text = "Telefon No:";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(40, 86);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(41, 17);
            this.lbl_sifre.TabIndex = 15;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(173, 20);
            this.txt_AdSoyad.MaxLength = 50;
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(210, 22);
            this.txt_AdSoyad.TabIndex = 1;
            // 
            // txt_kulismi
            // 
            this.txt_kulismi.Location = new System.Drawing.Point(173, 50);
            this.txt_kulismi.MaxLength = 50;
            this.txt_kulismi.Name = "txt_kulismi";
            this.txt_kulismi.Size = new System.Drawing.Size(210, 22);
            this.txt_kulismi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ad-Soyad:";
            // 
            // lbl_kuladsoyad
            // 
            this.lbl_kuladsoyad.AutoSize = true;
            this.lbl_kuladsoyad.Location = new System.Drawing.Point(40, 55);
            this.lbl_kuladsoyad.Name = "lbl_kuladsoyad";
            this.lbl_kuladsoyad.Size = new System.Drawing.Size(92, 17);
            this.lbl_kuladsoyad.TabIndex = 36;
            this.lbl_kuladsoyad.Text = "Kullanıcı İsmi:";
            // 
            // KayitEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 367);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.txt_kulismi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_kuladsoyad);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.cm_yetki);
            this.Controls.Add(this.txt_unvani);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.txt_eposta);
            this.Controls.Add(this.txt_telno);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.lbl_yetki);
            this.Controls.Add(this.lbl_unvani);
            this.Controls.Add(this.lbl_Adres);
            this.Controls.Add(this.lbl_Eposta);
            this.Controls.Add(this.lbl_kultelno);
            this.Controls.Add(this.lbl_sifre);
            this.Name = "KayitEt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitEt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KayitEt_FormClosing);
            this.Load += new System.EventHandler(this.KayitEt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.ComboBox cm_yetki;
        private System.Windows.Forms.TextBox txt_unvani;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.TextBox txt_telno;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label lbl_yetki;
        private System.Windows.Forms.Label lbl_unvani;
        private System.Windows.Forms.Label lbl_Adres;
        private System.Windows.Forms.Label lbl_Eposta;
        private System.Windows.Forms.Label lbl_kultelno;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.TextBox txt_kulismi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_kuladsoyad;
    }
}