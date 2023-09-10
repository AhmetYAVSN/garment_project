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
    public partial class StokSatis : Form
    {
        public StokSatis()
        {
            InitializeComponent();
        }

        DBEntities db = new DBEntities();
        private void StokSatis_Load(object sender, EventArgs e)
        {
          var sorgu = from satis in db.tbl_Satis
                        join urun in db.tbl_Kategori on satis.UrunID equals urun.ID
                        join musteri in db.tbl_Musteri on satis.MusteriID equals musteri.musteriID
                        join cins in db.tbl_KumasCinsi on satis.KumasCinsiID equals cins.ID
                      select new
                        {
                            cins.KumasCinsi,
                            urun.KategoriAdi,
                            musteri.Musteri_Ad_Soyad,
                            satis.Adet,
                            satis.SatisFiyati,
                            satis.BirimFiyati,
                            satis.KDV,
                            satis.KarOrani,
                            satis.StokKoduID,
                            satis.Tarih
                        };

            dataGridView1.DataSource = sorgu.ToList();
        }

        private void txtAnahtarKelime_TextChanged(object sender, EventArgs e)
        {
            string anahtarKelime = txtAnahtarKelime.Text;

            var sorgu = from stok in db.tbl_Satis
                        join urun in db.tbl_Kategori on stok.UrunID equals urun.ID
                        join musteri in db.tbl_Musteri on stok.MusteriID equals musteri.musteriID
                        join cins in db.tbl_KumasCinsi on stok.KumasCinsiID equals cins.ID
                        where musteri.Musteri_Ad_Soyad.Contains(anahtarKelime) | cins.KumasCinsi.Contains(anahtarKelime) | urun.KategoriAdi.Contains(anahtarKelime)

                        select new
                        {
                            cins.KumasCinsi,
                            urun.KategoriAdi,
                            musteri.Musteri_Ad_Soyad,
                            stok.Adet,
                            stok.SatisFiyati,
                            stok.BirimFiyati,
                            stok.KDV,
                            stok.KarOrani,
                            stok.Tarih
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }
    }
}
