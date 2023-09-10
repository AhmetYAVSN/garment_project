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
    public partial class KumasAlis : Form
    {
        public KumasAlis()
        {
            InitializeComponent();
        }

        DBEntities db = new DBEntities();

        void doldur()
        {
            //Combobax içerisine veri dolduruyoruz
            cm_Tedarikci.DataSource = db.tbl_TedarikciKayit.ToList();
            cm_Tedarikci.DisplayMember = "Firmaİsmi";
            cm_Tedarikci.ValueMember = "TedarikciID";

            cm_KumasCinsi.DataSource = db.tbl_KumasCinsi.ToList();
            cm_KumasCinsi.DisplayMember = "KumasCinsi";
            cm_KumasCinsi.ValueMember = "ID";
        }

        void temizle()
        {
            txt_AlisFiyat.Text = "";
            txt_Miktar.Text = "";
            txt_stokkodu.Text = "";
            cm_KumasCinsi.SelectedValue = "";
            cm_Tedarikci.SelectedValue = "";
        }

        private void btn_satinal_Click(object sender, EventArgs e)
        {

            try
            {
                tbl_KumasAlis alis = new tbl_KumasAlis();
                tbl_Hareket hareket = new tbl_Hareket();
                tbl_KumasAlimGecmisi stok = new tbl_KumasAlimGecmisi();

                hareket.HareketID = 1;
                hareket.StokID = Convert.ToInt32(txt_stokkodu.Text);
                hareket.GirisKG= Convert.ToInt32(txt_Miktar.Text);
                hareket.UretimKG= 0;
                hareket.SatisKG= 0;
                hareket.MusteriID = 1;
                hareket.UrunID = 1;
                hareket.KumasCinsiID = Convert.ToInt32(cm_KumasCinsi.SelectedValue);

                alis.KumasCinsi= Convert.ToInt32(cm_KumasCinsi.SelectedValue);
                alis.Miktar_KG_ = Convert.ToInt32(txt_Miktar.Text);
                alis.Alis_Fitat_TL_ = Convert.ToInt32(txt_AlisFiyat.Text);
                alis.Tarih = dt_tarih.Value;
                alis.StokKoduID = Convert.ToInt32(txt_stokkodu.Text);
                alis.TedarikciID = Convert.ToInt32(cm_Tedarikci.SelectedValue);

                stok.KumasCinsi = Convert.ToInt32(cm_KumasCinsi.SelectedValue);
                stok.Miktar_KG_ = Convert.ToInt32(txt_Miktar.Text);
                stok.Alis_Fiyat_TL_ = Convert.ToInt32(txt_AlisFiyat.Text);
                stok.Tarih = dt_tarih.Value;
                stok.StokKoduID = Convert.ToInt32(txt_stokkodu.Text);
                stok.TedarikciID = Convert.ToInt32(cm_Tedarikci.SelectedValue);


                db.tbl_KumasAlimGecmisi.Add(stok);
                db.SaveChanges();
                db.tbl_Hareket.Add(hareket);
                db.SaveChanges();
                db.tbl_KumasAlis.Add(alis);
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

        private void KumasAlis_Load(object sender, EventArgs e)
        {
            doldur();
            temizle();
        }
    }
}
