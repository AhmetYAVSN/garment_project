namespace Proje_Konfeksiyon
{
    partial class UrunSatis
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cm_UrunAdi = new System.Windows.Forms.ComboBox();
            this.cm_MusteriAdi = new System.Windows.Forms.ComboBox();
            this.dt_tarih = new System.Windows.Forms.DateTimePicker();
            this.txt_Adet = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.btn_satis = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.grd_listele = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cm_KumasCinsi = new System.Windows.Forms.ComboBox();
            this.lbl_stokkodu = new System.Windows.Forms.Label();
            this.cm_stokkodu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Oran = new System.Windows.Forms.TextBox();
            this.cm_stokUrun = new System.Windows.Forms.ComboBox();
            this.txt_StokAdet = new System.Windows.Forms.TextBox();
            this.lbl_Kilo = new System.Windows.Forms.Label();
            this.txt_Kilo = new System.Windows.Forms.TextBox();
            this.lbl_kdv = new System.Windows.Forms.Label();
            this.txt_KDV = new System.Windows.Forms.TextBox();
            this.lbl_KarOrani = new System.Windows.Forms.Label();
            this.txt_KarOrani = new System.Windows.Forms.TextBox();
            this.lbl_BirimFiyati = new System.Windows.Forms.Label();
            this.txt_BirimFiyati = new System.Windows.Forms.TextBox();
            this.txt_sonuc = new System.Windows.Forms.TextBox();
            this.txt_sonuc2 = new System.Windows.Forms.TextBox();
            this.lbl_DepoKilo = new System.Windows.Forms.Label();
            this.txt_depokilo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Satış Fiyatı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Müşteri Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tarih:";
            // 
            // cm_UrunAdi
            // 
            this.cm_UrunAdi.FormattingEnabled = true;
            this.cm_UrunAdi.Location = new System.Drawing.Point(114, 412);
            this.cm_UrunAdi.Name = "cm_UrunAdi";
            this.cm_UrunAdi.Size = new System.Drawing.Size(141, 24);
            this.cm_UrunAdi.TabIndex = 2;
            this.cm_UrunAdi.SelectedIndexChanged += new System.EventHandler(this.cm_UrunAdi_SelectedIndexChanged);
            // 
            // cm_MusteriAdi
            // 
            this.cm_MusteriAdi.FormattingEnabled = true;
            this.cm_MusteriAdi.Location = new System.Drawing.Point(114, 485);
            this.cm_MusteriAdi.Name = "cm_MusteriAdi";
            this.cm_MusteriAdi.Size = new System.Drawing.Size(141, 24);
            this.cm_MusteriAdi.TabIndex = 4;
            // 
            // dt_tarih
            // 
            this.dt_tarih.Location = new System.Drawing.Point(649, 496);
            this.dt_tarih.Name = "dt_tarih";
            this.dt_tarih.Size = new System.Drawing.Size(200, 22);
            this.dt_tarih.TabIndex = 11;
            // 
            // txt_Adet
            // 
            this.txt_Adet.Location = new System.Drawing.Point(401, 382);
            this.txt_Adet.Name = "txt_Adet";
            this.txt_Adet.Size = new System.Drawing.Size(141, 22);
            this.txt_Adet.TabIndex = 5;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Enabled = false;
            this.txt_fiyat.Location = new System.Drawing.Point(649, 456);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(141, 22);
            this.txt_fiyat.TabIndex = 10;
            // 
            // btn_satis
            // 
            this.btn_satis.Location = new System.Drawing.Point(411, 541);
            this.btn_satis.Name = "btn_satis";
            this.btn_satis.Size = new System.Drawing.Size(121, 32);
            this.btn_satis.TabIndex = 12;
            this.btn_satis.Text = "SAT";
            this.btn_satis.UseVisualStyleBackColor = true;
            this.btn_satis.Click += new System.EventHandler(this.btn_satis_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(19, 525);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(84, 32);
            this.btn_temizle.TabIndex = 13;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // grd_listele
            // 
            this.grd_listele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_listele.Location = new System.Drawing.Point(12, 37);
            this.grd_listele.Name = "grd_listele";
            this.grd_listele.RowTemplate.Height = 24;
            this.grd_listele.Size = new System.Drawing.Size(841, 278);
            this.grd_listele.TabIndex = 14;
            this.grd_listele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_listele_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kumaş Cinsi:";
            // 
            // cm_KumasCinsi
            // 
            this.cm_KumasCinsi.FormattingEnabled = true;
            this.cm_KumasCinsi.Location = new System.Drawing.Point(114, 382);
            this.cm_KumasCinsi.Name = "cm_KumasCinsi";
            this.cm_KumasCinsi.Size = new System.Drawing.Size(141, 24);
            this.cm_KumasCinsi.TabIndex = 1;
            this.cm_KumasCinsi.SelectedIndexChanged += new System.EventHandler(this.cm_KumasCinsi_SelectedIndexChanged);
            // 
            // lbl_stokkodu
            // 
            this.lbl_stokkodu.AutoSize = true;
            this.lbl_stokkodu.Location = new System.Drawing.Point(16, 454);
            this.lbl_stokkodu.Name = "lbl_stokkodu";
            this.lbl_stokkodu.Size = new System.Drawing.Size(77, 17);
            this.lbl_stokkodu.TabIndex = 0;
            this.lbl_stokkodu.Text = "Stok Kodu:";
            // 
            // cm_stokkodu
            // 
            this.cm_stokkodu.FormattingEnabled = true;
            this.cm_stokkodu.Location = new System.Drawing.Point(114, 447);
            this.cm_stokkodu.Name = "cm_stokkodu";
            this.cm_stokkodu.Size = new System.Drawing.Size(141, 24);
            this.cm_stokkodu.TabIndex = 3;
            this.cm_stokkodu.SelectedIndexChanged += new System.EventHandler(this.cm_stokkodu_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Stokdaki Ürünler";
            // 
            // txt_Oran
            // 
            this.txt_Oran.Enabled = false;
            this.txt_Oran.Location = new System.Drawing.Point(92, 324);
            this.txt_Oran.Name = "txt_Oran";
            this.txt_Oran.Size = new System.Drawing.Size(107, 22);
            this.txt_Oran.TabIndex = 17;
            // 
            // cm_stokUrun
            // 
            this.cm_stokUrun.Enabled = false;
            this.cm_stokUrun.FormattingEnabled = true;
            this.cm_stokUrun.Location = new System.Drawing.Point(706, 337);
            this.cm_stokUrun.Name = "cm_stokUrun";
            this.cm_stokUrun.Size = new System.Drawing.Size(110, 24);
            this.cm_stokUrun.TabIndex = 16;
            // 
            // txt_StokAdet
            // 
            this.txt_StokAdet.Enabled = false;
            this.txt_StokAdet.Location = new System.Drawing.Point(811, 286);
            this.txt_StokAdet.Name = "txt_StokAdet";
            this.txt_StokAdet.Size = new System.Drawing.Size(14, 22);
            this.txt_StokAdet.TabIndex = 18;
            // 
            // lbl_Kilo
            // 
            this.lbl_Kilo.AutoSize = true;
            this.lbl_Kilo.Location = new System.Drawing.Point(583, 426);
            this.lbl_Kilo.Name = "lbl_Kilo";
            this.lbl_Kilo.Size = new System.Drawing.Size(35, 17);
            this.lbl_Kilo.TabIndex = 0;
            this.lbl_Kilo.Text = "Kilo:";
            // 
            // txt_Kilo
            // 
            this.txt_Kilo.Location = new System.Drawing.Point(649, 421);
            this.txt_Kilo.Name = "txt_Kilo";
            this.txt_Kilo.Size = new System.Drawing.Size(94, 22);
            this.txt_Kilo.TabIndex = 9;
            this.txt_Kilo.TextChanged += new System.EventHandler(this.txt_Kilo_TextChanged);
            // 
            // lbl_kdv
            // 
            this.lbl_kdv.AutoSize = true;
            this.lbl_kdv.Location = new System.Drawing.Point(306, 456);
            this.lbl_kdv.Name = "lbl_kdv";
            this.lbl_kdv.Size = new System.Drawing.Size(40, 17);
            this.lbl_kdv.TabIndex = 19;
            this.lbl_kdv.Text = "KDV:";
            // 
            // txt_KDV
            // 
            this.txt_KDV.Location = new System.Drawing.Point(401, 451);
            this.txt_KDV.Name = "txt_KDV";
            this.txt_KDV.Size = new System.Drawing.Size(141, 22);
            this.txt_KDV.TabIndex = 7;
            this.txt_KDV.TextChanged += new System.EventHandler(this.txt_KDV_TextChanged);
            // 
            // lbl_KarOrani
            // 
            this.lbl_KarOrani.AutoSize = true;
            this.lbl_KarOrani.Location = new System.Drawing.Point(306, 495);
            this.lbl_KarOrani.Name = "lbl_KarOrani";
            this.lbl_KarOrani.Size = new System.Drawing.Size(73, 17);
            this.lbl_KarOrani.TabIndex = 19;
            this.lbl_KarOrani.Text = "Kar Oranı:";
            // 
            // txt_KarOrani
            // 
            this.txt_KarOrani.Location = new System.Drawing.Point(401, 490);
            this.txt_KarOrani.Name = "txt_KarOrani";
            this.txt_KarOrani.Size = new System.Drawing.Size(141, 22);
            this.txt_KarOrani.TabIndex = 8;
            this.txt_KarOrani.TextChanged += new System.EventHandler(this.txt_KarOrani_TextChanged);
            // 
            // lbl_BirimFiyati
            // 
            this.lbl_BirimFiyati.AutoSize = true;
            this.lbl_BirimFiyati.Location = new System.Drawing.Point(303, 421);
            this.lbl_BirimFiyati.Name = "lbl_BirimFiyati";
            this.lbl_BirimFiyati.Size = new System.Drawing.Size(80, 17);
            this.lbl_BirimFiyati.TabIndex = 0;
            this.lbl_BirimFiyati.Text = "Birim Fiyati:";
            // 
            // txt_BirimFiyati
            // 
            this.txt_BirimFiyati.Location = new System.Drawing.Point(401, 415);
            this.txt_BirimFiyati.Name = "txt_BirimFiyati";
            this.txt_BirimFiyati.Size = new System.Drawing.Size(141, 22);
            this.txt_BirimFiyati.TabIndex = 6;
            // 
            // txt_sonuc
            // 
            this.txt_sonuc.Enabled = false;
            this.txt_sonuc.Location = new System.Drawing.Point(822, 286);
            this.txt_sonuc.Name = "txt_sonuc";
            this.txt_sonuc.Size = new System.Drawing.Size(31, 22);
            this.txt_sonuc.TabIndex = 20;
            // 
            // txt_sonuc2
            // 
            this.txt_sonuc2.Location = new System.Drawing.Point(787, 286);
            this.txt_sonuc2.Name = "txt_sonuc2";
            this.txt_sonuc2.Size = new System.Drawing.Size(10, 22);
            this.txt_sonuc2.TabIndex = 21;
            // 
            // lbl_DepoKilo
            // 
            this.lbl_DepoKilo.AutoSize = true;
            this.lbl_DepoKilo.Location = new System.Drawing.Point(587, 344);
            this.lbl_DepoKilo.Name = "lbl_DepoKilo";
            this.lbl_DepoKilo.Size = new System.Drawing.Size(105, 17);
            this.lbl_DepoKilo.TabIndex = 22;
            this.lbl_DepoKilo.Text = "Depoda Ki Kilo:";
            // 
            // txt_depokilo
            // 
            this.txt_depokilo.Location = new System.Drawing.Point(795, 286);
            this.txt_depokilo.Name = "txt_depokilo";
            this.txt_depokilo.Size = new System.Drawing.Size(10, 22);
            this.txt_depokilo.TabIndex = 21;
            // 
            // UrunSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 601);
            this.Controls.Add(this.lbl_DepoKilo);
            this.Controls.Add(this.txt_KarOrani);
            this.Controls.Add(this.lbl_KarOrani);
            this.Controls.Add(this.txt_KDV);
            this.Controls.Add(this.lbl_kdv);
            this.Controls.Add(this.cm_stokUrun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cm_KumasCinsi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_satis);
            this.Controls.Add(this.txt_BirimFiyati);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_Kilo);
            this.Controls.Add(this.txt_Adet);
            this.Controls.Add(this.dt_tarih);
            this.Controls.Add(this.cm_stokkodu);
            this.Controls.Add(this.cm_MusteriAdi);
            this.Controls.Add(this.cm_UrunAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Kilo);
            this.Controls.Add(this.lbl_stokkodu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_BirimFiyati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grd_listele);
            this.Controls.Add(this.txt_sonuc);
            this.Controls.Add(this.txt_StokAdet);
            this.Controls.Add(this.txt_Oran);
            this.Controls.Add(this.txt_sonuc2);
            this.Controls.Add(this.txt_depokilo);
            this.Name = "UrunSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunSatis";
            this.Load += new System.EventHandler(this.UrunSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_listele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cm_UrunAdi;
        private System.Windows.Forms.ComboBox cm_MusteriAdi;
        private System.Windows.Forms.DateTimePicker dt_tarih;
        private System.Windows.Forms.TextBox txt_Adet;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.Button btn_satis;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.DataGridView grd_listele;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cm_KumasCinsi;
        private System.Windows.Forms.Label lbl_stokkodu;
        private System.Windows.Forms.ComboBox cm_stokkodu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Oran;
        private System.Windows.Forms.ComboBox cm_stokUrun;
        private System.Windows.Forms.TextBox txt_StokAdet;
        private System.Windows.Forms.Label lbl_Kilo;
        private System.Windows.Forms.TextBox txt_Kilo;
        private System.Windows.Forms.Label lbl_kdv;
        private System.Windows.Forms.TextBox txt_KDV;
        private System.Windows.Forms.Label lbl_KarOrani;
        private System.Windows.Forms.TextBox txt_KarOrani;
        private System.Windows.Forms.Label lbl_BirimFiyati;
        private System.Windows.Forms.TextBox txt_BirimFiyati;
        private System.Windows.Forms.TextBox txt_sonuc;
        private System.Windows.Forms.TextBox txt_sonuc2;
        private System.Windows.Forms.Label lbl_DepoKilo;
        private System.Windows.Forms.TextBox txt_depokilo;
    }
}