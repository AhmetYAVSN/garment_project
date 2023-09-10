namespace Proje_Konfeksiyon
{
    partial class KumasStok
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Ara = new System.Windows.Forms.Label();
            this.txtAnahtarKelime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(833, 234);
            this.dataGridView1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(347, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kumaş Stok";
            // 
            // lbl_Ara
            // 
            this.lbl_Ara.AutoSize = true;
            this.lbl_Ara.Location = new System.Drawing.Point(50, 100);
            this.lbl_Ara.Name = "lbl_Ara";
            this.lbl_Ara.Size = new System.Drawing.Size(34, 17);
            this.lbl_Ara.TabIndex = 27;
            this.lbl_Ara.Text = "Ara:";
            // 
            // txtAnahtarKelime
            // 
            this.txtAnahtarKelime.Location = new System.Drawing.Point(90, 95);
            this.txtAnahtarKelime.Name = "txtAnahtarKelime";
            this.txtAnahtarKelime.Size = new System.Drawing.Size(122, 22);
            this.txtAnahtarKelime.TabIndex = 26;
            this.txtAnahtarKelime.TextChanged += new System.EventHandler(this.txtAnahtarKelime_TextChanged);
            // 
            // KumasStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 403);
            this.Controls.Add(this.lbl_Ara);
            this.Controls.Add(this.txtAnahtarKelime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KumasStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokGris";
            this.Load += new System.EventHandler(this.StokGris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Ara;
        private System.Windows.Forms.TextBox txtAnahtarKelime;
    }
}