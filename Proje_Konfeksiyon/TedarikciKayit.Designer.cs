namespace Proje_Konfeksiyon
{
    partial class TedarikciKayit
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
            this.lbl_firmaismi = new System.Windows.Forms.Label();
            this.lbl_FirmaAdres = new System.Windows.Forms.Label();
            this.lbl_FirmaTelNo = new System.Windows.Forms.Label();
            this.txt_Firmaİsmi = new System.Windows.Forms.TextBox();
            this.txt_Firmaadresi = new System.Windows.Forms.TextBox();
            this.txt_Firmatelno = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_vzg = new System.Windows.Forms.Button();
            this.grd_listele = new System.Windows.Forms.DataGridView();
            this.btn_gucelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_firmaismi
            // 
            this.lbl_firmaismi.AutoSize = true;
            this.lbl_firmaismi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_firmaismi.Location = new System.Drawing.Point(19, 304);
            this.lbl_firmaismi.Name = "lbl_firmaismi";
            this.lbl_firmaismi.Size = new System.Drawing.Size(93, 23);
            this.lbl_firmaismi.TabIndex = 0;
            this.lbl_firmaismi.Text = "Firma İsmi:";
            // 
            // lbl_FirmaAdres
            // 
            this.lbl_FirmaAdres.AutoSize = true;
            this.lbl_FirmaAdres.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_FirmaAdres.Location = new System.Drawing.Point(19, 338);
            this.lbl_FirmaAdres.Name = "lbl_FirmaAdres";
            this.lbl_FirmaAdres.Size = new System.Drawing.Size(109, 23);
            this.lbl_FirmaAdres.TabIndex = 0;
            this.lbl_FirmaAdres.Text = "Firma Adresi:";
            // 
            // lbl_FirmaTelNo
            // 
            this.lbl_FirmaTelNo.AutoSize = true;
            this.lbl_FirmaTelNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_FirmaTelNo.Location = new System.Drawing.Point(19, 373);
            this.lbl_FirmaTelNo.Name = "lbl_FirmaTelNo";
            this.lbl_FirmaTelNo.Size = new System.Drawing.Size(145, 23);
            this.lbl_FirmaTelNo.TabIndex = 0;
            this.lbl_FirmaTelNo.Text = "Firma Telefon No:";
            // 
            // txt_Firmaİsmi
            // 
            this.txt_Firmaİsmi.Location = new System.Drawing.Point(180, 302);
            this.txt_Firmaİsmi.Name = "txt_Firmaİsmi";
            this.txt_Firmaİsmi.Size = new System.Drawing.Size(172, 22);
            this.txt_Firmaİsmi.TabIndex = 1;
            // 
            // txt_Firmaadresi
            // 
            this.txt_Firmaadresi.Location = new System.Drawing.Point(180, 337);
            this.txt_Firmaadresi.Name = "txt_Firmaadresi";
            this.txt_Firmaadresi.Size = new System.Drawing.Size(172, 22);
            this.txt_Firmaadresi.TabIndex = 2;
            // 
            // txt_Firmatelno
            // 
            this.txt_Firmatelno.Location = new System.Drawing.Point(180, 372);
            this.txt_Firmatelno.Name = "txt_Firmatelno";
            this.txt_Firmatelno.Size = new System.Drawing.Size(172, 22);
            this.txt_Firmatelno.TabIndex = 3;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(414, 292);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(121, 32);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "FİRMA EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_vzg
            // 
            this.btn_vzg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_vzg.Location = new System.Drawing.Point(414, 414);
            this.btn_vzg.Name = "btn_vzg";
            this.btn_vzg.Size = new System.Drawing.Size(121, 32);
            this.btn_vzg.TabIndex = 5;
            this.btn_vzg.Text = "VAZGEÇ";
            this.btn_vzg.UseVisualStyleBackColor = true;
            this.btn_vzg.Click += new System.EventHandler(this.btn_vzg_Click);
            // 
            // grd_listele
            // 
            this.grd_listele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_listele.Location = new System.Drawing.Point(12, 12);
            this.grd_listele.Name = "grd_listele";
            this.grd_listele.RowTemplate.Height = 24;
            this.grd_listele.Size = new System.Drawing.Size(537, 229);
            this.grd_listele.TabIndex = 8;
            this.grd_listele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_listele_CellDoubleClick);
            // 
            // btn_gucelle
            // 
            this.btn_gucelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gucelle.Location = new System.Drawing.Point(414, 331);
            this.btn_gucelle.Name = "btn_gucelle";
            this.btn_gucelle.Size = new System.Drawing.Size(121, 32);
            this.btn_gucelle.TabIndex = 6;
            this.btn_gucelle.Text = "GÜNCELLE";
            this.btn_gucelle.UseVisualStyleBackColor = true;
            this.btn_gucelle.Click += new System.EventHandler(this.btn_gucelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(414, 376);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(121, 32);
            this.btn_sil.TabIndex = 7;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(34, 260);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(48, 22);
            this.txt_ID.TabIndex = 9;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(11, 410);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(85, 32);
            this.btn_temizle.TabIndex = 20;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // TedarikciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 481);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.grd_listele);
            this.Controls.Add(this.btn_vzg);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_gucelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_Firmatelno);
            this.Controls.Add(this.txt_Firmaadresi);
            this.Controls.Add(this.txt_Firmaİsmi);
            this.Controls.Add(this.lbl_FirmaTelNo);
            this.Controls.Add(this.lbl_FirmaAdres);
            this.Controls.Add(this.lbl_firmaismi);
            this.Name = "TedarikciKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TedarikciKayit";
            this.Load += new System.EventHandler(this.TedarikciKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_listele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_firmaismi;
        private System.Windows.Forms.Label lbl_FirmaAdres;
        private System.Windows.Forms.Label lbl_FirmaTelNo;
        private System.Windows.Forms.TextBox txt_Firmaİsmi;
        private System.Windows.Forms.TextBox txt_Firmaadresi;
        private System.Windows.Forms.TextBox txt_Firmatelno;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_vzg;
        private System.Windows.Forms.DataGridView grd_listele;
        private System.Windows.Forms.Button btn_gucelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_temizle;
    }
}