using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Konfeksiyon
{
    public partial class Uretim : Form
    {
        public Uretim()
        {
            InitializeComponent();
        }
        DBEntities db = new DBEntities();
        int kategori;

        void temizle()
        {
            txt_adet.Text = "";
            txt_kilo.Text = "";
            txt_sonuc.Text = "";
            cm_stokKumas.SelectedValue = "";
            cm_UrunAdi.SelectedValue = "";
            cm_KategoriAdi.SelectedValue = "";
            cm_stokkodu.SelectedValue = "";
            cm_KumasCinsi.SelectedValue = "";
        }

        void doldur()
        {

            var sorgu = from alis in db.tbl_KumasAlis
                        join tedarikci in db.tbl_TedarikciKayit on alis.TedarikciID equals tedarikci.TedarikciID
                        join cins in db.tbl_KumasCinsi on  alis.KumasCinsi equals cins.ID
                        select new
                        {
                            alis.Kumas_alis_ID,
                            tedarikci.Firmaİsmi,
                            cins.KumasCinsi,
                            alis.Miktar_KG_,
                            alis.Alis_Fitat_TL_,
                            alis.StokKoduID,
                            alis.Tarih
                        };

                       grd_listele.DataSource = sorgu.ToList();

            cm_KategoriAdi.DataSource = db.tbl_UstKategori.ToList();
            cm_KategoriAdi.DisplayMember = "UstKategoriAdi";
            cm_KategoriAdi.ValueMember = "ID";


            var sorgu2 = from kumascinsi in db.tbl_KumasAlis
                         join kumas in db.tbl_KumasCinsi on kumascinsi.KumasCinsi equals kumas.ID
                         select new
                         {
                            
                             kumas.ID,
                             kumas.KumasCinsi
                         };

            cm_KumasCinsi.DataSource = sorgu2.ToList();
            cm_KumasCinsi.DisplayMember = "KumasCinsi";
            cm_KumasCinsi.ValueMember = "ID";
            cm_KumasCinsi.SelectedValue = "";

        }
   
        private void btn_Uret_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Hareket hareket = new tbl_Hareket();
                tbl_Uretim uretim = new tbl_Uretim();
                tbl_KumasAlis alis = new tbl_KumasAlis();
                tbl_UretimGecmisi uretimstok = new tbl_UretimGecmisi();            
                
                int s1 = Convert.ToInt32(cm_stokKumas.Text);
                int s2 = Convert.ToInt32(txt_kilo.Text);
                int a = s1 - s2;
                if (a < 0)
                {
                    MessageBox.Show("Okadar fazla mal yok.");
                }
                else
                {
                    hareket.HareketID = 2;
                    hareket.StokID = Convert.ToInt32(cm_stokkodu.SelectedValue);
                    hareket.GirisKG = 0;
                    hareket.UretimKG = Convert.ToInt32(txt_kilo.Text);
                    hareket.SatisKG = 0;
                    hareket.MusteriID = 1;
                    hareket.UrunID = Convert.ToInt32(cm_UrunAdi.SelectedValue);
                    hareket.KumasCinsiID = Convert.ToInt32(cm_KumasCinsi.SelectedValue);

                    uretim.KategoriID = Convert.ToInt32(cm_KategoriAdi.SelectedValue);
                    uretim.KumasCinsiID = Convert.ToInt32(cm_KumasCinsi.SelectedValue);
                    uretim.UretimAdi = Convert.ToInt32(cm_UrunAdi.SelectedValue);
                    uretim.StokKoduID = Convert.ToInt32(cm_stokkodu.SelectedValue);
                    uretim.Miktar_KG_ = Convert.ToInt32(txt_kilo.Text);
                    uretim.Adet = Convert.ToInt32(txt_adet.Text);
                    uretim.Tarih = dt_tarih.Value;

                    uretimstok.KategoriID = Convert.ToInt32(cm_KategoriAdi.SelectedValue);
                    uretimstok.KumasCinsiID = Convert.ToInt32(cm_KumasCinsi.SelectedValue);
                    uretimstok.UretimAdi = Convert.ToInt32(cm_UrunAdi.SelectedValue);
                    uretimstok.StokKoduID = Convert.ToInt32(cm_stokkodu.SelectedValue);
                    uretimstok.Miktar_KG_ = Convert.ToInt32(txt_kilo.Text);
                    uretimstok.Adet = Convert.ToInt32(txt_adet.Text);
                    uretimstok.Tarih = dt_tarih.Value;

                    txt_sonuc.Text = a.ToString();
                    int stokno = Convert.ToInt32(cm_stokkodu.Text);
                    var miktar = db.tbl_KumasAlis.Where(x => x.StokKoduID == stokno).FirstOrDefault();
                    miktar.Miktar_KG_ = Convert.ToInt32(txt_sonuc.Text);
                    db.SaveChanges();
                    MessageBox.Show("Stokda Kalan Kilo:" + a.ToString(), "Dikkat");
                    float adet = Convert.ToUInt32(txt_adet.Text);
                    float kilo = Convert.ToUInt32(txt_kilo.Text);
                    float oran = kilo / adet;
                    uretim.Oran = oran;
                    db.tbl_Hareket.Add(hareket);
                    db.tbl_Uretim.Add(uretim);
                    db.tbl_UretimGecmisi.Add(uretimstok);
                    db.SaveChanges();
                    doldur();
                    temizle();
                    MessageBox.Show("Üretim başarılı.");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Üretim başarısız.");
            }
        }

        private void Uretim_Load(object sender, EventArgs e)
        {
            doldur();  
            temizle();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        

        private void cm_KategoriAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                kategori = Convert.ToInt32(cm_KategoriAdi.SelectedValue);
                var sorgu = from uretim in db.tbl_Kategori.Where(x => x.KategoriID == kategori)
                            select new
                            {
                                uretim.ID,
                                uretim.KategoriAdi
                            };


                cm_UrunAdi.DataSource = sorgu.ToList();
                cm_UrunAdi.DisplayMember = "KategoriAdi";
                cm_UrunAdi.ValueMember = "ID";
                cm_UrunAdi.SelectedValue = "";

            }
            catch (Exception)
            {

            }
        }
        private void cm_KumasCinsi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int kumascinsiID = Convert.ToInt32(cm_KumasCinsi.SelectedValue);
                var sorgu = from stok in db.tbl_KumasAlis.Where(x => x.KumasCinsi == kumascinsiID)

                            select new
                            {
                                stok.Kumas_alis_ID,
                                stok.StokKoduID
                            };
                cm_stokkodu.DataSource = sorgu.ToList();
                cm_stokkodu.DisplayMember = "StokKoduID";
                cm_stokkodu.ValueMember = "Kumas_alis_ID";
                cm_stokkodu.SelectedValue = "";
            }
            catch (Exception)
            {

            }
        }
        private void cm_stokkodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int stokno = Convert.ToInt32(cm_stokkodu.SelectedValue);
                var sorgu = from miktar in db.tbl_KumasAlis.Where(x => x.Kumas_alis_ID == stokno )
                            select new
                            {
                                miktar.Kumas_alis_ID,
                                miktar.Miktar_KG_
                            };
                cm_stokKumas.DataSource = sorgu.ToList();
                cm_stokKumas.DisplayMember = "Miktar_KG_";
                cm_stokKumas.ValueMember = "Kumas_alis_ID";
                
            }
            catch (Exception)
            {

            }


        }

        private void grd_listele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cm_KumasCinsi.Text = grd_listele.CurrentRow.Cells[2].Value.ToString();
            cm_stokKumas.Text = grd_listele.CurrentRow.Cells[3].Value.ToString();
            cm_stokkodu.Text = grd_listele.CurrentRow.Cells[5].Value.ToString();
        }

    }
}
