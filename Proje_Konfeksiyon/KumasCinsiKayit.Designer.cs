namespace Proje_Konfeksiyon
{
    partial class KumasCinsiKayit
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
            this.lbl_KumasCinsi = new System.Windows.Forms.Label();
            this.txt_KumasCinsi = new System.Windows.Forms.TextBox();
            this.btn_Kayitet = new System.Windows.Forms.Button();
            this.grd_listele = new System.Windows.Forms.DataGridView();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_KumasCinsi
            // 
            this.lbl_KumasCinsi.AutoSize = true;
            this.lbl_KumasCinsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KumasCinsi.Location = new System.Drawing.Point(14, 214);
            this.lbl_KumasCinsi.Name = "lbl_KumasCinsi";
            this.lbl_KumasCinsi.Size = new System.Drawing.Size(109, 20);
            this.lbl_KumasCinsi.TabIndex = 0;
            this.lbl_KumasCinsi.Text = "Kumaş Cinsi:";
            // 
            // txt_KumasCinsi
            // 
            this.txt_KumasCinsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KumasCinsi.Location = new System.Drawing.Point(13, 246);
            this.txt_KumasCinsi.Name = "txt_KumasCinsi";
            this.txt_KumasCinsi.Size = new System.Drawing.Size(183, 27);
            this.txt_KumasCinsi.TabIndex = 1;
            // 
            // btn_Kayitet
            // 
            this.btn_Kayitet.Location = new System.Drawing.Point(254, 214);
            this.btn_Kayitet.Name = "btn_Kayitet";
            this.btn_Kayitet.Size = new System.Drawing.Size(100, 32);
            this.btn_Kayitet.TabIndex = 2;
            this.btn_Kayitet.Text = "Kayıt Et";
            this.btn_Kayitet.UseVisualStyleBackColor = true;
            this.btn_Kayitet.Click += new System.EventHandler(this.btn_Kayitet_Click);
            // 
            // grd_listele
            // 
            this.grd_listele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_listele.Location = new System.Drawing.Point(13, 13);
            this.grd_listele.Name = "grd_listele";
            this.grd_listele.RowTemplate.Height = 24;
            this.grd_listele.Size = new System.Drawing.Size(380, 150);
            this.grd_listele.TabIndex = 3;
            this.grd_listele.DoubleClick += new System.EventHandler(this.grd_listele_DoubleClick);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(254, 266);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(100, 32);
            this.btn_Sil.TabIndex = 4;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(13, 170);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(32, 22);
            this.txt_ID.TabIndex = 5;
            // 
            // KumasCinsiKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 332);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.grd_listele);
            this.Controls.Add(this.btn_Kayitet);
            this.Controls.Add(this.txt_KumasCinsi);
            this.Controls.Add(this.lbl_KumasCinsi);
            this.Name = "KumasCinsiKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KumasCinsiKayit";
            this.Load += new System.EventHandler(this.KumasCinsiKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_listele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KumasCinsi;
        private System.Windows.Forms.TextBox txt_KumasCinsi;
        private System.Windows.Forms.Button btn_Kayitet;
        private System.Windows.Forms.DataGridView grd_listele;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.TextBox txt_ID;
    }
}