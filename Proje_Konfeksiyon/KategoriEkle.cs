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
    public partial class KategoriEkle : Form
    {
        public KategoriEkle()
        {
            InitializeComponent();
        }
        DBEntities db = new DBEntities();

        void doldur()
        {
            var sorgu = from kategori in db.tbl_Kategori
                        join ustkategori in db.tbl_UstKategori on kategori.KategoriID equals ustkategori.ID
                        select new
                        {
                            kategori.ID,
                            ustkategori.UstKategoriAdi,
                            kategori.KategoriAdi,
                        };


            grd_liste.DataSource = db.tbl_UstKategori.ToList();
            grid_altkategorilistele.DataSource = sorgu.ToList();
            //Combobax içerisine veri dolduruyoruz
            cm_altkategori.DataSource = db.tbl_UstKategori.ToList();
            cm_altkategori.DisplayMember = "UstKategoriAdi";
            cm_altkategori.ValueMember = "ID";

        }

        void temizle()
        {
            txt_KategoriAdi.Text = "";
            txt_kategoriID.Text = "";
            txt_altkategoriID.Text = "";
            txt_altkategoriadi.Text = "";
            cm_altkategori.SelectedValue = "";
        }

        private void KategoriEkle_Load(object sender, EventArgs e)
        {
            doldur();
            temizle();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_UstKategori kategori = new tbl_UstKategori();
                kategori.UstKategoriAdi = txt_KategoriAdi.Text;
                db.tbl_UstKategori.Add(kategori);
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

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int kategoriID = Convert.ToInt32(txt_kategoriID.Text);
                var kategori = db.tbl_UstKategori.Where(x => x.ID== kategoriID).FirstOrDefault();
                kategori.UstKategoriAdi = txt_KategoriAdi.Text;
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

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                int KategoriID = Convert.ToInt32(txt_kategoriID.Text);
                var silinecekkategori = db.tbl_UstKategori.Where(x => x.ID== KategoriID).FirstOrDefault();
                db.tbl_UstKategori.Remove(silinecekkategori);
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

        private void btn_altkategoriekle_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Kategori kategori = new tbl_Kategori();
                kategori.KategoriAdi = txt_altkategoriadi.Text;
                kategori.KategoriID = Convert.ToInt32(cm_altkategori.SelectedValue);
                db.tbl_Kategori.Add(kategori);
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

        private void btn_altkategoriguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int kategoriID = Convert.ToInt32(txt_altkategoriID.Text);
                var kategori = db.tbl_Kategori.Where(x => x.ID== kategoriID).FirstOrDefault();
                kategori.KategoriAdi = txt_altkategoriadi.Text;
                kategori.KategoriID = Convert.ToInt32(cm_altkategori.SelectedValue);
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

        private void btn_altkategorisil_Click(object sender, EventArgs e)
        {
            try
            {
                int KategoriID = Convert.ToInt32(txt_altkategoriID.Text);
                var silinecekkategori = db.tbl_Kategori.Where(x => x.ID == KategoriID).FirstOrDefault();
                db.tbl_Kategori.Remove(silinecekkategori);
                silinecekkategori.KategoriAdi = txt_altkategoriadi.Text;
                silinecekkategori.KategoriID = Convert.ToInt32(cm_altkategori.SelectedValue);
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


        private void grd_liste_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kategoriID.Text = grd_liste.CurrentRow.Cells[0].Value.ToString();
            txt_KategoriAdi.Text = grd_liste.CurrentRow.Cells[1].Value.ToString();
        }

        private void grid_altkategorilistele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_altkategoriID.Text = grid_altkategorilistele.CurrentRow.Cells[0].Value.ToString();
            cm_altkategori.Text = grid_altkategorilistele.CurrentRow.Cells[1].Value.ToString();
            txt_altkategoriadi.Text = grid_altkategorilistele.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
