namespace Proje_Konfeksiyon
{
    partial class GirisPanel
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
            this.lbl_bilgilendirme = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kulad = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_kulad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_bilgilendirme
            // 
            this.lbl_bilgilendirme.AutoSize = true;
            this.lbl_bilgilendirme.Location = new System.Drawing.Point(21, 183);
            this.lbl_bilgilendirme.Name = "lbl_bilgilendirme";
            this.lbl_bilgilendirme.Size = new System.Drawing.Size(0, 17);
            this.lbl_bilgilendirme.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(285, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 24);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Şifre Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_kayit
            // 
            this.btn_kayit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kayit.Location = new System.Drawing.Point(227, 136);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(126, 35);
            this.btn_kayit.TabIndex = 4;
            this.btn_kayit.Text = "KAYIT ET";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(66, 136);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(126, 35);
            this.btn_giris.TabIndex = 3;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(165, 83);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(112, 22);
            this.txt_sifre.TabIndex = 2;
            // 
            // txt_kulad
            // 
            this.txt_kulad.Location = new System.Drawing.Point(163, 32);
            this.txt_kulad.Name = "txt_kulad";
            this.txt_kulad.Size = new System.Drawing.Size(112, 22);
            this.txt_kulad.TabIndex = 1;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(115, 85);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(44, 20);
            this.lbl_sifre.TabIndex = 10;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // lbl_kulad
            // 
            this.lbl_kulad.AutoSize = true;
            this.lbl_kulad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kulad.Location = new System.Drawing.Point(57, 34);
            this.lbl_kulad.Name = "lbl_kulad";
            this.lbl_kulad.Size = new System.Drawing.Size(102, 20);
            this.lbl_kulad.TabIndex = 8;
            this.lbl_kulad.Text = "Kullanıcı İsmi:";
            // 
            // GirisPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 230);
            this.Controls.Add(this.lbl_bilgilendirme);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kulad);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kulad);
            this.Name = "GirisPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GirisPanel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bilgilendirme;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kulad;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_kulad;
    }
}

