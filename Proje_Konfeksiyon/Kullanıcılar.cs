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
    public partial class Kullanıcılar : Form
    {
        public Kullanıcılar()
        {
            InitializeComponent();
        }
        DBEntities db = new DBEntities();

        void temizle()
        {
            txt_kulismi.Text = "";
            txt_sifre.Text = "";
            txt_telno.Text = "";
            txt_eposta.Text = "";
            txt_Adres.Text = "";
            txt_AdSoyad.Text = "";
            txt_unvani.Text = "";
            cm_yetki.SelectedValue = "";
        }
        void doldur()
        {
            //Combobax içerisine veri dolduruyoruz
            cm_yetki.DataSource = db.tbl_yetki.ToList();
            cm_yetki.DisplayMember = "Yetki";
            cm_yetki.ValueMember = "ID";

            var sorgu = from kullanici in db.tbl_KulKayit
                        join yetki in db.tbl_yetki on kullanici.YetkiID equals yetki.ID
                        select new
                        {
                            kullanici.Kul_ID,
                            kullanici.Ad_Soyad,
                            kullanici.Kul_Ad,
                            kullanici.Sifre,
                            kullanici.Kul_Tel_No,
                            kullanici.E_Posta,
                            kullanici.Adres,
                            kullanici.Unvani,
                            yetki.Yetki
                        };


            grd_listele.DataSource = sorgu.ToList();
        }

        private void Kullanıcılar_Load(object sender, EventArgs e)
        {
            doldur();
            temizle();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_KulKayit uye = new tbl_KulKayit();
                uye.Kul_Ad = txt_kulismi.Text;
                uye.Sifre = txt_sifre.Text;
                uye.Kul_Tel_No = txt_telno.Text;
                uye.E_Posta = txt_eposta.Text;
                uye.Adres = txt_Adres.Text;
                uye.Unvani = txt_unvani.Text;
                uye.YetkiID = Convert.ToInt32(cm_yetki.SelectedValue);
                uye.Ad_Soyad = txt_AdSoyad.Text;
                db.tbl_KulKayit.Add(uye);
                db.SaveChanges();
                doldur();
                temizle();
                MessageBox.Show("Kayıt başarılı.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt başarısız.");
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }


        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                int Kul_ID = Convert.ToInt32(txt_ID.Text);
                var silinecekkullanici = db.tbl_KulKayit.Where(x => x.Kul_ID== Kul_ID).FirstOrDefault();
                db.tbl_KulKayit.Remove(silinecekkullanici);
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

        private void btn_guncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                int Kul_ID = Convert.ToInt32(txt_ID.Text);
                var kullanici = db.tbl_KulKayit.Where(x => x.Kul_ID == Kul_ID).FirstOrDefault();
                kullanici.Kul_Ad = txt_kulismi.Text;
                kullanici.Ad_Soyad = txt_AdSoyad.Text;
                kullanici.Sifre = txt_sifre.Text;
                kullanici.Kul_Tel_No = txt_telno.Text;
                kullanici.E_Posta = txt_eposta.Text;
                kullanici.Adres = txt_Adres.Text;
                kullanici.Unvani = txt_unvani.Text;
                kullanici.YetkiID = Convert.ToInt32(cm_yetki.SelectedValue);
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

        private void grd_listele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = grd_listele.CurrentRow.Cells[0].Value.ToString();
            txt_AdSoyad.Text = grd_listele.CurrentRow.Cells[1].Value.ToString();
            txt_kulismi.Text = grd_listele.CurrentRow.Cells[2].Value.ToString();
            txt_sifre.Text = grd_listele.CurrentRow.Cells[3].Value.ToString();
            txt_telno.Text = grd_listele.CurrentRow.Cells[4].Value.ToString();
            txt_eposta.Text = grd_listele.CurrentRow.Cells[5].Value.ToString();
            txt_Adres.Text = grd_listele.CurrentRow.Cells[6].Value.ToString();
            txt_unvani.Text = grd_listele.CurrentRow.Cells[7].Value.ToString();
            cm_yetki.Text = grd_listele.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
