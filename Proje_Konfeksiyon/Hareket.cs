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
    public partial class Hareket : Form
    {
        public Hareket()
        {
            InitializeComponent();
        }

        DBEntities db = new DBEntities();

        private void Hareket_Load(object sender, EventArgs e)
        {
            var sorgu = from hareket in db.tbl_Hareket
                        join harekettipi in db.tbl_HareketTipi on hareket.HareketID equals harekettipi.ID
                        join kumascinsi in db.tbl_KumasCinsi on hareket.KumasCinsiID equals kumascinsi.ID
                        join musteri in db.tbl_Musteri on hareket.MusteriID equals musteri.musteriID
                        join urunadi in db.tbl_Kategori on hareket.UrunID equals urunadi.ID
                        select new
                        {
                           harekettipi.HareketAdi,
                           musteri.Musteri_Ad_Soyad,
                           kumascinsi.KumasCinsi,
                           urunadi.KategoriAdi,
                           hareket.GirisKG,
                           hareket.UretimKG,
                           hareket.SatisKG
                        };

            grd_listele.DataSource = sorgu.ToList();
        }

        private void txtAnahtarKelime_TextChanged(object sender, EventArgs e)
        {
            string anahtarKelime = txtAnahtarKelime.Text;
            var sorgu = from hareket in db.tbl_Hareket
                        join harekettipi in db.tbl_HareketTipi on hareket.HareketID equals harekettipi.ID
                        join kumascinsi in db.tbl_KumasCinsi on hareket.KumasCinsiID equals kumascinsi.ID
                        join musteri in db.tbl_Musteri on hareket.MusteriID equals musteri.musteriID
                        join urunadi in db.tbl_Kategori on hareket.UrunID equals urunadi.ID
                        where harekettipi.HareketAdi.Contains(anahtarKelime) | kumascinsi.KumasCinsi.Contains(anahtarKelime) | musteri.Musteri_Ad_Soyad.Contains(anahtarKelime) | urunadi.KategoriAdi.Contains(anahtarKelime)
                        select new
                        {
                            harekettipi.HareketAdi,
                            musteri.Musteri_Ad_Soyad,
                            kumascinsi.KumasCinsi,
                            urunadi.KategoriAdi,
                            hareket.GirisKG,
                            hareket.UretimKG,
                            hareket.SatisKG
                        };

            grd_listele.DataSource = sorgu.ToList();
        }
    }
}
