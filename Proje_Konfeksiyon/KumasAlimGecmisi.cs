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
    public partial class KumasAlimGecmisi : Form
    {
        public KumasAlimGecmisi()
        {
            InitializeComponent();
        }

        DBEntities db = new DBEntities();

        private void KumasStok_Load(object sender, EventArgs e)
        {
            var sorgu = from kumasstok in db.tbl_KumasAlimGecmisi
                        join tedarikci in db.tbl_TedarikciKayit on kumasstok.TedarikciID equals tedarikci.TedarikciID
                        join cins in db.tbl_KumasCinsi on kumasstok.KumasCinsi equals cins.ID
                        select new
                        {
                            kumasstok.Kumas_Stok_ID,
                            tedarikci.Firmaİsmi,
                            cins.KumasCinsi,
                            kumasstok.Miktar_KG_,
                            kumasstok.Alis_Fiyat_TL_,
                            kumasstok.Tarih
                        };

            grd_listele.DataSource = sorgu.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string anahtarKelime = txtAnahtarKelime.Text;

            var sorgu = from stok in db.tbl_KumasAlimGecmisi

                        join tedarikci in db.tbl_TedarikciKayit on stok.TedarikciID equals tedarikci.TedarikciID
                        join cins in db.tbl_KumasCinsi on stok.KumasCinsi equals cins.ID
                        where tedarikci.Firmaİsmi.Contains(anahtarKelime) | cins.KumasCinsi.Contains(anahtarKelime) 

                        select new
                        {
                            stok.Kumas_Stok_ID,
                            tedarikci.Firmaİsmi,
                            cins.KumasCinsi,
                            stok.Miktar_KG_,
                            stok.Alis_Fiyat_TL_,
                            stok.Tarih
                        };
            grd_listele.DataSource = sorgu.ToList();
            
        }
    }
}
