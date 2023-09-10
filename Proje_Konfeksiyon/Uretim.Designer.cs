namespace Proje_Konfeksiyon
{
    partial class Uretim
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
            this.lbl_KategoriAdi = new System.Windows.Forms.Label();
            this.lbl_UretimAdi = new System.Windows.Forms.Label();
            this.lbl_kilo = new System.Windows.Forms.Label();
            this.lbl_Adet = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.dt_tarih = new System.Windows.Forms.DateTimePicker();
            this.cm_KategoriAdi = new System.Windows.Forms.ComboBox();
            this.txt_kilo = new System.Windows.Forms.TextBox();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.btn_Uret = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.lbl_kumascinsi = new System.Windows.Forms.Label();
            this.cm_KumasCinsi = new System.Windows.Forms.ComboBox();
            this.cm_stokkodu = new System.Windows.Forms.ComboBox();
            this.lbl_stokkodu = new System.Windows.Forms.Label();
            this.cm_UrunAdi = new System.Windows.Forms.ComboBox();
            this.grd_listele = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cm_stokKumas = new System.Windows.Forms.ComboBox();
            this.txt_sonuc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_KategoriAdi
            // 
            this.lbl_KategoriAdi.AutoSize = true;
            this.lbl_KategoriAdi.Location = new System.Drawing.Point(21, 353);
            this.lbl_KategoriAdi.Name = "lbl_KategoriAdi";
            this.lbl_KategoriAdi.Size = new System.Drawing.Size(89, 17);
            this.lbl_KategoriAdi.TabIndex = 0;
            this.lbl_KategoriAdi.Text = "Kategori Adı:";
            // 
            // lbl_UretimAdi
            // 
            this.lbl_UretimAdi.AutoSize = true;
            this.lbl_UretimAdi.Location = new System.Drawing.Point(21, 381);
            this.lbl_UretimAdi.Name = "lbl_UretimAdi";
            this.lbl_UretimAdi.Size = new System.Drawing.Size(77, 17);
            this.lbl_UretimAdi.TabIndex = 0;
            this.lbl_UretimAdi.Text = "Uretim Adı:";
            // 
            // lbl_kilo
            // 
            this.lbl_kilo.AutoSize = true;
            this.lbl_kilo.Location = new System.Drawing.Point(360, 321);
            this.lbl_kilo.Name = "lbl_kilo";
            this.lbl_kilo.Size = new System.Drawing.Size(35, 17);
            this.lbl_kilo.TabIndex = 0;
            this.lbl_kilo.Text = "Kilo:";
            // 
            // lbl_Adet
            // 
            this.lbl_Adet.AutoSize = true;
            this.lbl_Adet.Location = new System.Drawing.Point(360, 353);
            this.lbl_Adet.Name = "lbl_Adet";
            this.lbl_Adet.Size = new System.Drawing.Size(41, 17);
            this.lbl_Adet.TabIndex = 0;
            this.lbl_Adet.Text = "Adet:";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Location = new System.Drawing.Point(360, 384);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(45, 17);
            this.lbl_tarih.TabIndex = 0;
            this.lbl_tarih.Text = "Tarih:";
            // 
            // dt_tarih
            // 
            this.dt_tarih.Location = new System.Drawing.Point(455, 378);
            this.dt_tarih.Name = "dt_tarih";
            this.dt_tarih.Size = new System.Drawing.Size(200, 22);
            this.dt_tarih.TabIndex = 7;
            // 
            // cm_KategoriAdi
            // 
            this.cm_KategoriAdi.FormattingEnabled = true;
            this.cm_KategoriAdi.Location = new System.Drawing.Point(119, 346);
            this.cm_KategoriAdi.Name = "cm_KategoriAdi";
            this.cm_KategoriAdi.Size = new System.Drawing.Size(200, 24);
            this.cm_KategoriAdi.TabIndex = 3;
            this.cm_KategoriAdi.SelectedIndexChanged += new System.EventHandler(this.cm_KategoriAdi_SelectedIndexChanged);
            // 
            // txt_kilo
            // 
            this.txt_kilo.Location = new System.Drawing.Point(455, 316);
            this.txt_kilo.Name = "txt_kilo";
            this.txt_kilo.Size = new System.Drawing.Size(200, 22);
            this.txt_kilo.TabIndex = 5;
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(455, 348);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(200, 22);
            this.txt_adet.TabIndex = 6;
            // 
            // btn_Uret
            // 
            this.btn_Uret.Location = new System.Drawing.Point(294, 422);
            this.btn_Uret.Name = "btn_Uret";
            this.btn_Uret.Size = new System.Drawing.Size(127, 32);
            this.btn_Uret.TabIndex = 8;
            this.btn_Uret.Text = "ÜRET";
            this.btn_Uret.UseVisualStyleBackColor = true;
            this.btn_Uret.Click += new System.EventHandler(this.btn_Uret_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(12, 422);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(127, 32);
            this.btn_temizle.TabIndex = 9;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // lbl_kumascinsi
            // 
            this.lbl_kumascinsi.AutoSize = true;
            this.lbl_kumascinsi.Location = new System.Drawing.Point(21, 293);
            this.lbl_kumascinsi.Name = "lbl_kumascinsi";
            this.lbl_kumascinsi.Size = new System.Drawing.Size(89, 17);
            this.lbl_kumascinsi.TabIndex = 8;
            this.lbl_kumascinsi.Text = "Kumaş Cinsi:";
            // 
            // cm_KumasCinsi
            // 
            this.cm_KumasCinsi.FormattingEnabled = true;
            this.cm_KumasCinsi.Location = new System.Drawing.Point(119, 286);
            this.cm_KumasCinsi.Name = "cm_KumasCinsi";
            this.cm_KumasCinsi.Size = new System.Drawing.Size(200, 24);
            this.cm_KumasCinsi.TabIndex = 1;
            this.cm_KumasCinsi.SelectedIndexChanged += new System.EventHandler(this.cm_KumasCinsi_SelectedIndexChanged);
            // 
            // cm_stokkodu
            // 
            this.cm_stokkodu.FormattingEnabled = true;
            this.cm_stokkodu.Location = new System.Drawing.Point(119, 316);
            this.cm_stokkodu.Name = "cm_stokkodu";
            this.cm_stokkodu.Size = new System.Drawing.Size(200, 24);
            this.cm_stokkodu.TabIndex = 2;
            this.cm_stokkodu.SelectedIndexChanged += new System.EventHandler(this.cm_stokkodu_SelectedIndexChanged);
            // 
            // lbl_stokkodu
            // 
            this.lbl_stokkodu.AutoSize = true;
            this.lbl_stokkodu.Location = new System.Drawing.Point(21, 323);
            this.lbl_stokkodu.Name = "lbl_stokkodu";
            this.lbl_stokkodu.Size = new System.Drawing.Size(77, 17);
            this.lbl_stokkodu.TabIndex = 9;
            this.lbl_stokkodu.Text = "Stok Kodu:";
            // 
            // cm_UrunAdi
            // 
            this.cm_UrunAdi.FormattingEnabled = true;
            this.cm_UrunAdi.Location = new System.Drawing.Point(119, 375);
            this.cm_UrunAdi.Name = "cm_UrunAdi";
            this.cm_UrunAdi.Size = new System.Drawing.Size(200, 24);
            this.cm_UrunAdi.TabIndex = 4;
            // 
            // grd_listele
            // 
            this.grd_listele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_listele.Location = new System.Drawing.Point(12, 46);
            this.grd_listele.Name = "grd_listele";
            this.grd_listele.RowTemplate.Height = 24;
            this.grd_listele.Size = new System.Drawing.Size(652, 204);
            this.grd_listele.TabIndex = 10;
            this.grd_listele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_listele_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Stokdaki Kumaşlar";
            // 
            // cm_stokKumas
            // 
            this.cm_stokKumas.Enabled = false;
            this.cm_stokKumas.Location = new System.Drawing.Point(492, 272);
            this.cm_stokKumas.Name = "cm_stokKumas";
            this.cm_stokKumas.Size = new System.Drawing.Size(142, 24);
            this.cm_stokKumas.TabIndex = 14;
            // 
            // txt_sonuc
            // 
            this.txt_sonuc.Enabled = false;
            this.txt_sonuc.Location = new System.Drawing.Point(625, 228);
            this.txt_sonuc.Name = "txt_sonuc";
            this.txt_sonuc.Size = new System.Drawing.Size(39, 22);
            this.txt_sonuc.TabIndex = 15;
            // 
            // Uretim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 503);
            this.Controls.Add(this.cm_stokKumas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cm_UrunAdi);
            this.Controls.Add(this.cm_stokkodu);
            this.Controls.Add(this.lbl_stokkodu);
            this.Controls.Add(this.cm_KumasCinsi);
            this.Controls.Add(this.lbl_kumascinsi);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_Uret);
            this.Controls.Add(this.txt_adet);
            this.Controls.Add(this.txt_kilo);
            this.Controls.Add(this.cm_KategoriAdi);
            this.Controls.Add(this.dt_tarih);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.lbl_Adet);
            this.Controls.Add(this.lbl_kilo);
            this.Controls.Add(this.lbl_UretimAdi);
            this.Controls.Add(this.lbl_KategoriAdi);
            this.Controls.Add(this.grd_listele);
            this.Controls.Add(this.txt_sonuc);
            this.Name = "Uretim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uretim";
            this.Load += new System.EventHandler(this.Uretim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_listele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KategoriAdi;
        private System.Windows.Forms.Label lbl_UretimAdi;
        private System.Windows.Forms.Label lbl_kilo;
        private System.Windows.Forms.Label lbl_Adet;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.DateTimePicker dt_tarih;
        private System.Windows.Forms.ComboBox cm_KategoriAdi;
        private System.Windows.Forms.TextBox txt_kilo;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.Button btn_Uret;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Label lbl_kumascinsi;
        private System.Windows.Forms.ComboBox cm_KumasCinsi;
        private System.Windows.Forms.ComboBox cm_stokkodu;
        private System.Windows.Forms.Label lbl_stokkodu;
        private System.Windows.Forms.ComboBox cm_UrunAdi;
        private System.Windows.Forms.DataGridView grd_listele;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cm_stokKumas;
        private System.Windows.Forms.TextBox txt_sonuc;
    }
}