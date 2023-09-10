namespace Proje_Konfeksiyon
{
    partial class KategoriEkle
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
            this.txt_kategoriID = new System.Windows.Forms.TextBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.lbl_KategoriAdi = new System.Windows.Forms.Label();
            this.txt_KategoriAdi = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.grd_liste = new System.Windows.Forms.DataGridView();
            this.txt_altkategoriID = new System.Windows.Forms.TextBox();
            this.cm_altkategori = new System.Windows.Forms.ComboBox();
            this.btn_altkategorisil = new System.Windows.Forms.Button();
            this.btn_altkategoriguncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_altkategoriadi = new System.Windows.Forms.Label();
            this.txt_altkategoriadi = new System.Windows.Forms.TextBox();
            this.btn_altkategoriekle = new System.Windows.Forms.Button();
            this.grid_altkategorilistele = new System.Windows.Forms.DataGridView();
            this.KATEGORİ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_altkategorilistele)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_kategoriID
            // 
            this.txt_kategoriID.Enabled = false;
            this.txt_kategoriID.Location = new System.Drawing.Point(13, 339);
            this.txt_kategoriID.Name = "txt_kategoriID";
            this.txt_kategoriID.Size = new System.Drawing.Size(47, 22);
            this.txt_kategoriID.TabIndex = 33;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(233, 419);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(113, 32);
            this.btn_Sil.TabIndex = 4;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_güncelle.Location = new System.Drawing.Point(233, 379);
            this.btn_güncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(113, 32);
            this.btn_güncelle.TabIndex = 3;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // lbl_KategoriAdi
            // 
            this.lbl_KategoriAdi.AutoSize = true;
            this.lbl_KategoriAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KategoriAdi.Location = new System.Drawing.Point(13, 374);
            this.lbl_KategoriAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KategoriAdi.Name = "lbl_KategoriAdi";
            this.lbl_KategoriAdi.Size = new System.Drawing.Size(100, 20);
            this.lbl_KategoriAdi.TabIndex = 29;
            this.lbl_KategoriAdi.Text = "Kategori adı :";
            // 
            // txt_KategoriAdi
            // 
            this.txt_KategoriAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KategoriAdi.Location = new System.Drawing.Point(16, 396);
            this.txt_KategoriAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_KategoriAdi.Name = "txt_KategoriAdi";
            this.txt_KategoriAdi.Size = new System.Drawing.Size(152, 27);
            this.txt_KategoriAdi.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(233, 339);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(113, 32);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // grd_liste
            // 
            this.grd_liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_liste.Location = new System.Drawing.Point(16, 67);
            this.grd_liste.Margin = new System.Windows.Forms.Padding(4);
            this.grd_liste.Name = "grd_liste";
            this.grd_liste.Size = new System.Drawing.Size(403, 245);
            this.grd_liste.TabIndex = 5;
            this.grd_liste.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_liste_CellDoubleClick);
            // 
            // txt_altkategoriID
            // 
            this.txt_altkategoriID.Enabled = false;
            this.txt_altkategoriID.Location = new System.Drawing.Point(611, 328);
            this.txt_altkategoriID.Name = "txt_altkategoriID";
            this.txt_altkategoriID.Size = new System.Drawing.Size(47, 22);
            this.txt_altkategoriID.TabIndex = 42;
            // 
            // cm_altkategori
            // 
            this.cm_altkategori.FormattingEnabled = true;
            this.cm_altkategori.Location = new System.Drawing.Point(604, 449);
            this.cm_altkategori.Name = "cm_altkategori";
            this.cm_altkategori.Size = new System.Drawing.Size(130, 24);
            this.cm_altkategori.TabIndex = 8;
            // 
            // btn_altkategorisil
            // 
            this.btn_altkategorisil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_altkategorisil.Location = new System.Drawing.Point(881, 419);
            this.btn_altkategorisil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_altkategorisil.Name = "btn_altkategorisil";
            this.btn_altkategorisil.Size = new System.Drawing.Size(113, 32);
            this.btn_altkategorisil.TabIndex = 11;
            this.btn_altkategorisil.Text = "Sil";
            this.btn_altkategorisil.UseVisualStyleBackColor = true;
            this.btn_altkategorisil.Click += new System.EventHandler(this.btn_altkategorisil_Click);
            // 
            // btn_altkategoriguncelle
            // 
            this.btn_altkategoriguncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_altkategoriguncelle.Location = new System.Drawing.Point(881, 379);
            this.btn_altkategoriguncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_altkategoriguncelle.Name = "btn_altkategoriguncelle";
            this.btn_altkategoriguncelle.Size = new System.Drawing.Size(113, 32);
            this.btn_altkategoriguncelle.TabIndex = 10;
            this.btn_altkategoriguncelle.Text = "Güncelle";
            this.btn_altkategoriguncelle.UseVisualStyleBackColor = true;
            this.btn_altkategoriguncelle.Click += new System.EventHandler(this.btn_altkategoriguncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(602, 425);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Alt Kategori:";
            // 
            // lbl_altkategoriadi
            // 
            this.lbl_altkategoriadi.AutoSize = true;
            this.lbl_altkategoriadi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_altkategoriadi.Location = new System.Drawing.Point(600, 366);
            this.lbl_altkategoriadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_altkategoriadi.Name = "lbl_altkategoriadi";
            this.lbl_altkategoriadi.Size = new System.Drawing.Size(123, 20);
            this.lbl_altkategoriadi.TabIndex = 38;
            this.lbl_altkategoriadi.Text = "Alt Kategori adı :";
            // 
            // txt_altkategoriadi
            // 
            this.txt_altkategoriadi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_altkategoriadi.Location = new System.Drawing.Point(603, 388);
            this.txt_altkategoriadi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_altkategoriadi.Name = "txt_altkategoriadi";
            this.txt_altkategoriadi.Size = new System.Drawing.Size(152, 27);
            this.txt_altkategoriadi.TabIndex = 7;
            // 
            // btn_altkategoriekle
            // 
            this.btn_altkategoriekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_altkategoriekle.Location = new System.Drawing.Point(881, 339);
            this.btn_altkategoriekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_altkategoriekle.Name = "btn_altkategoriekle";
            this.btn_altkategoriekle.Size = new System.Drawing.Size(113, 32);
            this.btn_altkategoriekle.TabIndex = 9;
            this.btn_altkategoriekle.Text = "Ekle";
            this.btn_altkategoriekle.UseVisualStyleBackColor = true;
            this.btn_altkategoriekle.Click += new System.EventHandler(this.btn_altkategoriekle_Click);
            // 
            // grid_altkategorilistele
            // 
            this.grid_altkategorilistele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_altkategorilistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_altkategorilistele.Location = new System.Drawing.Point(572, 67);
            this.grid_altkategorilistele.Margin = new System.Windows.Forms.Padding(4);
            this.grid_altkategorilistele.Name = "grid_altkategorilistele";
            this.grid_altkategorilistele.Size = new System.Drawing.Size(452, 245);
            this.grid_altkategorilistele.TabIndex = 12;
            this.grid_altkategorilistele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_altkategorilistele_CellDoubleClick);
            // 
            // KATEGORİ
            // 
            this.KATEGORİ.AutoSize = true;
            this.KATEGORİ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KATEGORİ.Location = new System.Drawing.Point(90, 27);
            this.KATEGORİ.Name = "KATEGORİ";
            this.KATEGORİ.Size = new System.Drawing.Size(169, 36);
            this.KATEGORİ.TabIndex = 43;
            this.KATEGORİ.Text = "KATEGORİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(643, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 36);
            this.label3.TabIndex = 43;
            this.label3.Text = "ALT KATEGORİ";
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(445, 339);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(94, 32);
            this.btn_temizle.TabIndex = 5;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // KategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KATEGORİ);
            this.Controls.Add(this.txt_altkategoriID);
            this.Controls.Add(this.cm_altkategori);
            this.Controls.Add(this.btn_altkategorisil);
            this.Controls.Add(this.btn_altkategoriguncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_altkategoriadi);
            this.Controls.Add(this.txt_altkategoriadi);
            this.Controls.Add(this.btn_altkategoriekle);
            this.Controls.Add(this.grid_altkategorilistele);
            this.Controls.Add(this.txt_kategoriID);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.lbl_KategoriAdi);
            this.Controls.Add(this.txt_KategoriAdi);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.grd_liste);
            this.Name = "KategoriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KategoriEkle";
            this.Load += new System.EventHandler(this.KategoriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_altkategorilistele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_kategoriID;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Label lbl_KategoriAdi;
        private System.Windows.Forms.TextBox txt_KategoriAdi;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView grd_liste;
        private System.Windows.Forms.TextBox txt_altkategoriID;
        private System.Windows.Forms.ComboBox cm_altkategori;
        private System.Windows.Forms.Button btn_altkategorisil;
        private System.Windows.Forms.Button btn_altkategoriguncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_altkategoriadi;
        private System.Windows.Forms.TextBox txt_altkategoriadi;
        private System.Windows.Forms.Button btn_altkategoriekle;
        private System.Windows.Forms.DataGridView grid_altkategorilistele;
        private System.Windows.Forms.Label KATEGORİ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_temizle;
    }
}