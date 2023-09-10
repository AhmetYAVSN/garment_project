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
    public partial class KumasStok : Form
    {
        public KumasStok()
        {
            InitializeComponent();
        }
        DBEntities db = new DBEntities();


        private void StokGris_Load(object sender, EventArgs e)
        {
            var sorgu = from kumasStok in db.tbl_KumasAlis
                        join tedarikci in db.tbl_TedarikciKayit on kumasStok.TedarikciID equals tedarikci.TedarikciID
                        join cins in db.tbl_KumasCinsi on kumasStok.KumasCinsi equals cins.ID
                        select new
                        {
                            kumasStok.Kumas_alis_ID,
                            tedarikci.Firmaİsmi,
                            cins.KumasCinsi,
                            kumasStok.Miktar_KG_,
                            kumasStok.Alis_Fitat_TL_,
                            kumasStok.Tarih
                        };

            dataGridView1.DataSource = sorgu.ToList();
        }

        private void txtAnahtarKelime_TextChanged(object sender, EventArgs e)
        {
            string anahtarKelime = txtAnahtarKelime.Text;
            var sorgu = from kumasStok in db.tbl_KumasAlis
                        join tedarikci in db.tbl_TedarikciKayit on kumasStok.TedarikciID equals tedarikci.TedarikciID
                        join cins in db.tbl_KumasCinsi on kumasStok.KumasCinsi equals cins.ID
                        where tedarikci.Firmaİsmi.Contains(anahtarKelime) | cins.KumasCinsi.Contains(anahtarKelime)

                        select new
                        {
                            kumasStok.Kumas_alis_ID,
                            tedarikci.Firmaİsmi,
                            cins.KumasCinsi,
                            kumasStok.Miktar_KG_,
                            kumasStok.Alis_Fitat_TL_,
                            kumasStok.Tarih
                        };

            dataGridView1.DataSource = sorgu.ToList();
        }
    }
}
