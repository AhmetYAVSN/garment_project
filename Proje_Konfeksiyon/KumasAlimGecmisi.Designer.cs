namespace Proje_Konfeksiyon
{
    partial class KumasAlimGecmisi
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
            this.grd_listele = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnahtarKelime = new System.Windows.Forms.TextBox();
            this.lbl_Ara = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_listele
            // 
            this.grd_listele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_listele.Location = new System.Drawing.Point(55, 136);
            this.grd_listele.Name = "grd_listele";
            this.grd_listele.RowTemplate.Height = 24;
            this.grd_listele.Size = new System.Drawing.Size(878, 291);
            this.grd_listele.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(328, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "KUMAŞ ALIM GEÇMİŞİ";
            // 
            // txtAnahtarKelime
            // 
            this.txtAnahtarKelime.Location = new System.Drawing.Point(138, 95);
            this.txtAnahtarKelime.Name = "txtAnahtarKelime";
            this.txtAnahtarKelime.Size = new System.Drawing.Size(122, 22);
            this.txtAnahtarKelime.TabIndex = 2;
            this.txtAnahtarKelime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_Ara
            // 
            this.lbl_Ara.AutoSize = true;
            this.lbl_Ara.Location = new System.Drawing.Point(98, 100);
            this.lbl_Ara.Name = "lbl_Ara";
            this.lbl_Ara.Size = new System.Drawing.Size(34, 17);
            this.lbl_Ara.TabIndex = 3;
            this.lbl_Ara.Text = "Ara:";
            // 
            // KumasAlimGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 457);
            this.Controls.Add(this.lbl_Ara);
            this.Controls.Add(this.txtAnahtarKelime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grd_listele);
            this.Name = "KumasAlimGecmisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KumasStok";
            this.Load += new System.EventHandler(this.KumasStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_listele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_listele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnahtarKelime;
        private System.Windows.Forms.Label lbl_Ara;
    }
}