namespace Proje_Konfeksiyon
{
    partial class MusteriKayit
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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.grd_listele = new System.Windows.Forms.DataGridView();
            this.btn_vzg = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_gucelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_musteritelno = new System.Windows.Forms.TextBox();
            this.txt_musteriadresi = new System.Windows.Forms.TextBox();
            this.lbl_FirmaTelNo = new System.Windows.Forms.Label();
            this.lbl_FirmaAdres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_müsteriismi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(43, 276);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(48, 22);
            this.txt_ID.TabIndex = 21;
            // 
            // grd_listele
            // 
            this.grd_listele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_listele.Location = new System.Drawing.Point(12, 12);
            this.grd_listele.Name = "grd_listele";
            this.grd_listele.RowTemplate.Height = 24;
            this.grd_listele.Size = new System.Drawing.Size(542, 229);
            this.grd_listele.TabIndex = 9;
            this.grd_listele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_listele_CellDoubleClick);
            // 
            // btn_vzg
            // 
            this.btn_vzg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_vzg.Location = new System.Drawing.Point(430, 416);
            this.btn_vzg.Name = "btn_vzg";
            this.btn_vzg.Size = new System.Drawing.Size(121, 32);
            this.btn_vzg.TabIndex = 6;
            this.btn_vzg.Text = "VAZGEÇ";
            this.btn_vzg.UseVisualStyleBackColor = true;
            this.btn_vzg.Click += new System.EventHandler(this.btn_vzg_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(13, 437);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(95, 32);
            this.btn_temizle.TabIndex = 5;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_gucelle
            // 
            this.btn_gucelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gucelle.Location = new System.Drawing.Point(430, 340);
            this.btn_gucelle.Name = "btn_gucelle";
            this.btn_gucelle.Size = new System.Drawing.Size(121, 32);
            this.btn_gucelle.TabIndex = 7;
            this.btn_gucelle.Text = "GÜNCELLE";
            this.btn_gucelle.UseVisualStyleBackColor = true;
            this.btn_gucelle.Click += new System.EventHandler(this.btn_gucelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(430, 299);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(121, 32);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "KAYIT ET";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_musteritelno
            // 
            this.txt_musteritelno.Location = new System.Drawing.Point(189, 395);
            this.txt_musteritelno.Name = "txt_musteritelno";
            this.txt_musteritelno.Size = new System.Drawing.Size(172, 22);
            this.txt_musteritelno.TabIndex = 3;
            // 
            // txt_musteriadresi
            // 
            this.txt_musteriadresi.Location = new System.Drawing.Point(189, 360);
            this.txt_musteriadresi.Name = "txt_musteriadresi";
            this.txt_musteriadresi.Size = new System.Drawing.Size(172, 22);
            this.txt_musteriadresi.TabIndex = 2;
            // 
            // lbl_FirmaTelNo
            // 
            this.lbl_FirmaTelNo.AutoSize = true;
            this.lbl_FirmaTelNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_FirmaTelNo.Location = new System.Drawing.Point(9, 396);
            this.lbl_FirmaTelNo.Name = "lbl_FirmaTelNo";
            this.lbl_FirmaTelNo.Size = new System.Drawing.Size(160, 23);
            this.lbl_FirmaTelNo.TabIndex = 10;
            this.lbl_FirmaTelNo.Text = "Müşteri Telefon No:";
            // 
            // lbl_FirmaAdres
            // 
            this.lbl_FirmaAdres.AutoSize = true;
            this.lbl_FirmaAdres.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_FirmaAdres.Location = new System.Drawing.Point(9, 361);
            this.lbl_FirmaAdres.Name = "lbl_FirmaAdres";
            this.lbl_FirmaAdres.Size = new System.Drawing.Size(124, 23);
            this.lbl_FirmaAdres.TabIndex = 11;
            this.lbl_FirmaAdres.Text = "Müşteri Adresi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Müşteri İsmi:";
            // 
            // txt_müsteriismi
            // 
            this.txt_müsteriismi.Location = new System.Drawing.Point(189, 318);
            this.txt_müsteriismi.Name = "txt_müsteriismi";
            this.txt_müsteriismi.Size = new System.Drawing.Size(172, 22);
            this.txt_müsteriismi.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(430, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MusteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 483);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.grd_listele);
            this.Controls.Add(this.btn_vzg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_gucelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_musteritelno);
            this.Controls.Add(this.txt_musteriadresi);
            this.Controls.Add(this.txt_müsteriismi);
            this.Controls.Add(this.lbl_FirmaTelNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_FirmaAdres);
            this.Name = "MusteriKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriKayit";
            this.Load += new System.EventHandler(this.MusteriKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_listele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.DataGridView grd_listele;
        private System.Windows.Forms.Button btn_vzg;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_gucelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_musteritelno;
        private System.Windows.Forms.TextBox txt_musteriadresi;
        private System.Windows.Forms.Label lbl_FirmaTelNo;
        private System.Windows.Forms.Label lbl_FirmaAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_müsteriismi;
        private System.Windows.Forms.Button button1;
    }
}