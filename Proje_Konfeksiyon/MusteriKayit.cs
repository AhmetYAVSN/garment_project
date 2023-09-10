using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Konfeksiyon
{
    public partial class MusteriKayit : Form
    {
        public MusteriKayit()
        {
            InitializeComponent();
        }

        DBEntities db = new DBEntities();

        void doldur()
        { 
            grd_listele.DataSource = db.tbl_Musteri.ToList();
        }

        void temizle()
        {
            txt_ID.Text = "";
            txt_musteriadresi.Text = "";
            txt_musteritelno.Text = "";
            txt_müsteriismi.Text = "";
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Musteri firma = new tbl_Musteri();
                firma.Musteri_Ad_Soyad = txt_müsteriismi.Text;
                firma.Musteri_Adres = txt_musteriadresi.Text;
                firma.Musteri_Tel_No = Convert.ToInt32(txt_musteritelno.Text);
                db.tbl_Musteri.Add(firma);
                db.SaveChanges();
                temizle();
                doldur();
                MessageBox.Show("Kayıt başarılı.");
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt başarısız.");
            }
        }

        private void btn_vzg_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kayıt et sayfasından çıkmak istiyormusunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            this.Hide();
        }

        private void btn_gucelle_Click(object sender, EventArgs e)
        {
            try
            {
                int musteriID = Convert.ToInt32(txt_ID.Text);
                var musteri = db.tbl_Musteri.Where(x => x.musteriID == musteriID).FirstOrDefault();
                musteri.Musteri_Ad_Soyad = txt_müsteriismi.Text;
                musteri.Musteri_Adres = txt_musteriadresi.Text;
                musteri.Musteri_Tel_No = Convert.ToInt32(txt_musteritelno.Text);
                db.SaveChanges();
                doldur();
                temizle();
                MessageBox.Show("başarılı bir şekilde güncellenmiştir.");
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme yapılamadı.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int musteriID = Convert.ToInt32(txt_ID.Text);
                var silinecekmusteri = db.tbl_Musteri.Where(x => x.musteriID == musteriID).FirstOrDefault();
                db.tbl_Musteri.Remove(silinecekmusteri);
                db.SaveChanges();
                doldur();
                temizle();
                MessageBox.Show("başarılı bir şekilde silinmiştir.");
            }
            catch (Exception)
            {
                MessageBox.Show("silme işlemi yapılamadı.");
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void MusteriKayit_Load(object sender, EventArgs e)
        {
            doldur();
            foreach (Form childForm in MdiChildren)
            {
                temizle();
            }
        }

        private void grd_listele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_ID.Text = grd_listele.CurrentRow.Cells[0].Value.ToString();
            txt_müsteriismi.Text = grd_listele.CurrentRow.Cells[1].Value.ToString();
            txt_musteriadresi.Text = grd_listele.CurrentRow.Cells[2].Value.ToString();
            txt_musteritelno.Text = grd_listele.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
