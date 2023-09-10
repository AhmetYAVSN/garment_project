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
    public partial class UretimStok : Form
    {
        public UretimStok()
        {
            InitializeComponent();
        }
        DBEntities db = new DBEntities();

        private void UretimStok_Load(object sender, EventArgs e)
        {
            var sorgu = from uretim in db.tbl_Uretim
                        join UstKategori in db.tbl_UstKategori on uretim.KategoriID equals UstKategori.ID
                        join kategori in db.tbl_Kategori on uretim.UretimAdi equals kategori.ID
                        join alis in db.tbl_KumasAlis on uretim.StokKoduID equals alis.Kumas_alis_ID
                        join cins in db.tbl_KumasCinsi on uretim.KumasCinsiID equals cins.ID
                        select new
                        {
                            uretim.UretimID,
                            UstKategori.UstKategoriAdi,
                            kategori.KategoriAdi,
                            cins.KumasCinsi,
                            alis.StokKoduID,
                            uretim.Miktar_KG_,
                            uretim.Adet,
                            uretim.Tarih
                        };

            grd_uretim.DataSource = sorgu.ToList();

        }

        private void txtAnahtarKelime_TextChanged(object sender, EventArgs e)
        {
            string anahtarKelime = txtAnahtarKelime.Text;

            var sorgu = from uretim in db.tbl_Uretim
                        join UstKategori in db.tbl_UstKategori on uretim.KategoriID equals UstKategori.ID
                        join kategori in db.tbl_Kategori on uretim.UretimAdi equals kategori.ID
                        join alis in db.tbl_KumasAlis on uretim.StokKoduID equals alis.Kumas_alis_ID
                        join cins in db.tbl_KumasCinsi on uretim.KumasCinsiID equals cins.ID
                        where UstKategori.UstKategoriAdi.Contains(anahtarKelime) | cins.KumasCinsi.Contains(anahtarKelime) | kategori.KategoriAdi.Contains(anahtarKelime)

                        select new
                        {
                            uretim.UretimID,
                            UstKategori.UstKategoriAdi,
                            kategori.KategoriAdi,
                            cins.KumasCinsi,
                            alis.StokKoduID,
                            uretim.Miktar_KG_,
                            uretim.Adet,
                            uretim.Tarih
                        };
            grd_uretim.DataSource = sorgu.ToList();
        }
    }
}
