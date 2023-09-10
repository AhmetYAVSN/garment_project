namespace Proje_Konfeksiyon
{
    partial class Hareket
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
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Ara = new System.Windows.Forms.Label();
            this.txtAnahtarKelime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_listele
            // 
            this.grd_listele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_listele.Location = new System.Drawing.Point(12, 137);
            this.grd_listele.Name = "grd_listele";
            this.grd_listele.RowTemplate.Height = 24;
            this.grd_listele.Size = new System.Drawing.Size(874, 298);
            this.grd_listele.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(303, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "İŞLEM GEÇMİŞİ";
            // 
            // lbl_Ara
            // 
            this.lbl_Ara.AutoSize = true;
            this.lbl_Ara.Location = new System.Drawing.Point(24, 114);
            this.lbl_Ara.Name = "lbl_Ara";
            this.lbl_Ara.Size = new System.Drawing.Size(34, 17);
            this.lbl_Ara.TabIndex = 27;
            this.lbl_Ara.Text = "Ara:";
            // 
            // txtAnahtarKelime
            // 
            this.txtAnahtarKelime.Location = new System.Drawing.Point(64, 109);
            this.txtAnahtarKelime.Name = "txtAnahtarKelime";
            this.txtAnahtarKelime.Size = new System.Drawing.Size(122, 22);
            this.txtAnahtarKelime.TabIndex = 26;
            this.txtAnahtarKelime.TextChanged += new System.EventHandler(this.txtAnahtarKelime_TextChanged);
            // 
            // Hareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 475);
            this.Controls.Add(this.lbl_Ara);
            this.Controls.Add(this.txtAnahtarKelime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grd_listele);
            this.Name = "Hareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hareket";
            this.Load += new System.EventHandler(this.Hareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_listele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_listele;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Ara;
        private System.Windows.Forms.TextBox txtAnahtarKelime;
    }
}