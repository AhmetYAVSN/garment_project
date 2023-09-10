namespace Proje_Konfeksiyon
{
    partial class Yetki
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
            this.lbl_yetki = new System.Windows.Forms.Label();
            this.txt_yetki = new System.Windows.Forms.TextBox();
            this.sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.chbox_Kayitislemleri = new System.Windows.Forms.CheckBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.chbox_AlisSatis = new System.Windows.Forms.CheckBox();
            this.chbox_stok = new System.Windows.Forms.CheckBox();
            this.chbox_Rapor = new System.Windows.Forms.CheckBox();
            this.chbox_Hareket = new System.Windows.Forms.CheckBox();
            this.chbox_KulKayit = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(352, 208);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(125, 32);
            this.btn_kayit.TabIndex = 2;
            this.btn_kayit.Text = "KAYIT ET";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // lbl_yetki
            // 
            this.lbl_yetki.AutoSize = true;
            this.lbl_yetki.Location = new System.Drawing.Point(21, 213);
            this.lbl_yetki.Name = "lbl_yetki";
            this.lbl_yetki.Size = new System.Drawing.Size(43, 17);
            this.lbl_yetki.TabIndex = 4;
            this.lbl_yetki.Text = "Yetki:";
            // 
            // txt_yetki
            // 
            this.txt_yetki.Location = new System.Drawing.Point(101, 213);
            this.txt_yetki.Name = "txt_yetki";
            this.txt_yetki.Size = new System.Drawing.Size(112, 22);
            this.txt_yetki.TabIndex = 1;
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(352, 306);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(125, 32);
            this.sil.TabIndex = 3;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(515, 152);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(13, 171);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(36, 22);
            this.txt_ID.TabIndex = 7;
            // 
            // chbox_Kayitislemleri
            // 
            this.chbox_Kayitislemleri.AutoSize = true;
            this.chbox_Kayitislemleri.Location = new System.Drawing.Point(24, 259);
            this.chbox_Kayitislemleri.Name = "chbox_Kayitislemleri";
            this.chbox_Kayitislemleri.Size = new System.Drawing.Size(116, 21);
            this.chbox_Kayitislemleri.TabIndex = 8;
            this.chbox_Kayitislemleri.Text = "Kayıt İşlemleri";
            this.chbox_Kayitislemleri.UseVisualStyleBackColor = true;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(352, 259);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(125, 32);
            this.btn_guncelle.TabIndex = 9;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // chbox_AlisSatis
            // 
            this.chbox_AlisSatis.AutoSize = true;
            this.chbox_AlisSatis.Location = new System.Drawing.Point(24, 286);
            this.chbox_AlisSatis.Name = "chbox_AlisSatis";
            this.chbox_AlisSatis.Size = new System.Drawing.Size(96, 21);
            this.chbox_AlisSatis.TabIndex = 8;
            this.chbox_AlisSatis.Text = "Alış - Satış";
            this.chbox_AlisSatis.UseVisualStyleBackColor = true;
            // 
            // chbox_stok
            // 
            this.chbox_stok.AutoSize = true;
            this.chbox_stok.Location = new System.Drawing.Point(24, 313);
            this.chbox_stok.Name = "chbox_stok";
            this.chbox_stok.Size = new System.Drawing.Size(113, 21);
            this.chbox_stok.TabIndex = 8;
            this.chbox_stok.Text = "Stok İşlemleri";
            this.chbox_stok.UseVisualStyleBackColor = true;
            // 
            // chbox_Rapor
            // 
            this.chbox_Rapor.AutoSize = true;
            this.chbox_Rapor.Location = new System.Drawing.Point(176, 259);
            this.chbox_Rapor.Name = "chbox_Rapor";
            this.chbox_Rapor.Size = new System.Drawing.Size(85, 21);
            this.chbox_Rapor.TabIndex = 8;
            this.chbox_Rapor.Text = "Raporlar";
            this.chbox_Rapor.UseVisualStyleBackColor = true;
            // 
            // chbox_Hareket
            // 
            this.chbox_Hareket.AutoSize = true;
            this.chbox_Hareket.Location = new System.Drawing.Point(176, 286);
            this.chbox_Hareket.Name = "chbox_Hareket";
            this.chbox_Hareket.Size = new System.Drawing.Size(96, 21);
            this.chbox_Hareket.TabIndex = 8;
            this.chbox_Hareket.Text = "Hareketler";
            this.chbox_Hareket.UseVisualStyleBackColor = true;
            // 
            // chbox_KulKayit
            // 
            this.chbox_KulKayit.AutoSize = true;
            this.chbox_KulKayit.Location = new System.Drawing.Point(176, 313);
            this.chbox_KulKayit.Name = "chbox_KulKayit";
            this.chbox_KulKayit.Size = new System.Drawing.Size(117, 21);
            this.chbox_KulKayit.TabIndex = 8;
            this.chbox_KulKayit.Text = "Kullanıcı Kayıt";
            this.chbox_KulKayit.UseVisualStyleBackColor = true;
            // 
            // Yetki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 386);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.chbox_KulKayit);
            this.Controls.Add(this.chbox_Hareket);
            this.Controls.Add(this.chbox_Rapor);
            this.Controls.Add(this.chbox_stok);
            this.Controls.Add(this.chbox_AlisSatis);
            this.Controls.Add(this.chbox_Kayitislemleri);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.lbl_yetki);
            this.Controls.Add(this.txt_yetki);
            this.Name = "Yetki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetki";
            this.Load += new System.EventHandler(this.Yetki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.Label lbl_yetki;
        private System.Windows.Forms.TextBox txt_yetki;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.CheckBox chbox_Kayitislemleri;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.CheckBox chbox_AlisSatis;
        private System.Windows.Forms.CheckBox chbox_stok;
        private System.Windows.Forms.CheckBox chbox_Rapor;
        private System.Windows.Forms.CheckBox chbox_Hareket;
        private System.Windows.Forms.CheckBox chbox_KulKayit;
    }
}