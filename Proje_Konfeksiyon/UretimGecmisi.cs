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
    public partial class UretimGecmisi : Form
    {
        public UretimGecmisi()
        {
            InitializeComponent();
        }
        DBEntities db = new DBEntities();

        private void UretimGecmisi_Load(object sender, EventArgs e)
        {
            var sorgu = from uretimstok in db.tbl_UretimGecmisi
                        join UstKategori in db.tbl_UstKategori on uretimstok.KategoriID equals UstKategori.ID
                        join kategori in db.tbl_Kategori on uretimstok.UretimAdi equals kategori.ID
                        join alis in db.tbl_KumasAlis on uretimstok.StokKoduID equals alis.Kumas_alis_ID
                        join cins in db.tbl_KumasCinsi on uretimstok.KumasCinsiID equals cins.ID
                        select new
                        {
                            uretimstok.UretimID,
                            UstKategori.UstKategoriAdi,
                            kategori.KategoriAdi,
                            cins.KumasCinsi,
                            alis.StokKoduID,
                            uretimstok.Miktar_KG_,
                            uretimstok.Adet,
                            uretimstok.Tarih
                        };

            grd_uretim.DataSource = sorgu.ToList();
        }

        private void txtAnahtarKelime_TextChanged(object sender, EventArgs e)
        {
            string anahtarKelime = txtAnahtarKelime.Text;
            var sorgu = from uretimstok in db.tbl_UretimGecmisi
                        join UstKategori in db.tbl_UstKategori on uretimstok.KategoriID equals UstKategori.ID
                        join kategori in db.tbl_Kategori on uretimstok.UretimAdi equals kategori.ID
                        join alis in db.tbl_KumasAlis on uretimstok.StokKoduID equals alis.Kumas_alis_ID
                        join cins in db.tbl_KumasCinsi on uretimstok.KumasCinsiID equals cins.ID
                        where UstKategori.UstKategoriAdi.Contains(anahtarKelime) | cins.KumasCinsi.Contains(anahtarKelime) | kategori.KategoriAdi.Contains(anahtarKelime)

                        select new
                        {
                            uretimstok.UretimID,
                            UstKategori.UstKategoriAdi,
                            kategori.KategoriAdi,
                            cins.KumasCinsi,
                            alis.StokKoduID,
                            uretimstok.Miktar_KG_,
                            uretimstok.Adet,
                            uretimstok.Tarih
                        };
            grd_uretim.DataSource = sorgu.ToList();
        }
    }
}
