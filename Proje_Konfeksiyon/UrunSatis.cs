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
    public partial class UrunSatis : Form
    {
        public UrunSatis()
        {
            InitializeComponent();
        }

        DBEntities db = new DBEntities();

        void temizle()
        {
            txt_Adet.Text = "";
            txt_fiyat.Text = "";
            dt_tarih.Text = "";
            txt_Oran.Text = "";
            txt_Kilo.Text = "";
            txt_BirimFiyati.Text = "";
            txt_KDV.Text = "";
            txt_KarOrani.Text = "";
            txt_StokAdet.Text = "";
            cm_MusteriAdi.SelectedValue = "";
            cm_stokkodu.SelectedValue = "";
            cm_stokUrun.SelectedValue = "";
            cm_UrunAdi.SelectedValue = "";
            cm_KumasCinsi.SelectedValue = "";
        }
        void doldur()
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
                            cins.KumasCinsi,
                            kategori.KategoriAdi,
                            alis.StokKoduID,
                            uretim.Miktar_KG_,
                            uretim.Adet,
                            uretim.Tarih,
                            uretim.Oran
                        };
            grd_listele.DataSource = sorgu.ToList();

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

            cm_MusteriAdi.DataSource = db.tbl_Musteri.ToList();
            cm_MusteriAdi.DisplayMember = "Musteri_Ad_Soyad";
            cm_MusteriAdi.ValueMember = "musteriID";
        }

        private void UrunSatis_Load(object sender, EventArgs e)
        {
            doldur();
            temizle();
        }

        private void btn_satis_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Hareket hareket = new tbl_Hareket();
                tbl_Satis sat = new tbl_Satis();
                tbl_Uretim uretim = new tbl_Uretim();

                int a1 = Convert.ToInt32(txt_Adet.Text), a2 = Convert.ToInt32(txt_StokAdet.Text);
                int kg1 = Convert.ToInt32(txt_Kilo.Text), kg2 = Convert.ToInt32(txt_depokilo.Text);
                int b = a2 - a1;
                int z = kg2 - kg1;
                if (b < 0)
                {
                    MessageBox.Show("Okadar fazla mal yok.");
                }
                if (z < 0)
                {
                    MessageBox.Show("Okadar fazla mal yok.");
                }
                else
                {
                    hareket.HareketID = 3;
                    hareket.StokID = Convert.ToInt32(cm_stokkodu.SelectedValue);
                    hareket.GirisKG = 0;
                    hareket.UretimKG = 0;
                    hareket.SatisKG = Convert.ToInt32(txt_Adet.Text);
                    hareket.MusteriID = Convert.ToInt32(cm_MusteriAdi.SelectedValue);
                    hareket.UrunID = Convert.ToInt32(cm_UrunAdi.SelectedValue);
                    hareket.KumasCinsiID = Convert.ToInt32(cm_KumasCinsi.SelectedValue);

                    sat.UrunID = Convert.ToInt32(cm_UrunAdi.SelectedValue);
                    sat.MusteriID = Convert.ToInt32(cm_MusteriAdi.SelectedValue);
                    sat.KumasCinsiID = Convert.ToInt32(cm_KumasCinsi.SelectedValue);
                    sat.Adet = Convert.ToInt32(txt_Adet.Text);
                    sat.SatisFiyati = Convert.ToInt32(txt_fiyat.Text);
                    sat.StokKoduID = Convert.ToInt32(cm_stokkodu.SelectedValue);
                    sat.Tarih = dt_tarih.Value;
                    sat.BirimFiyati = Convert.ToInt32(txt_BirimFiyati.Text);
                    sat.KDV = Convert.ToInt32(txt_KDV.Text);
                    sat.KarOrani = Convert.ToInt32(txt_KarOrani.Text);
                    sat.Miktar_KG_ = Convert.ToInt32(txt_Kilo.Text); 
                    txt_sonuc.Text = b.ToString();
                    txt_sonuc2.Text = z.ToString();
                    int stokno = Convert.ToInt32(cm_stokkodu.SelectedValue);
                    var miktar = db.tbl_Uretim.Where(x => x.StokKoduID == stokno).FirstOrDefault();
                    miktar.Adet = Convert.ToInt32(txt_sonuc.Text);
                    miktar.Miktar_KG_ = Convert.ToInt32(txt_sonuc2.Text);
                    MessageBox.Show("Stokda kalan Adet:"+b.ToString()+"\n"+"Stokda kalan Kilo:"+z.ToString(), "Dikkat");
                    db.tbl_Hareket.Add(hareket);
                    db.tbl_Satis.Add(sat);
                    db.SaveChanges();
                    doldur();
                    temizle();
                    MessageBox.Show("Satış başarılı.");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Satış başarısız.");
            }

            temizle();


        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void grd_listele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cm_KumasCinsi.Text = grd_listele.CurrentRow.Cells[2].Value.ToString();
            cm_UrunAdi.Text = grd_listele.CurrentRow.Cells[3].Value.ToString();
            cm_stokkodu.Text = grd_listele.CurrentRow.Cells[4].Value.ToString();
            cm_stokUrun.Text = grd_listele.CurrentRow.Cells[5].Value.ToString();
            txt_Kilo.Text = grd_listele.CurrentRow.Cells[5].Value.ToString();
            txt_depokilo.Text = grd_listele.CurrentRow.Cells[5].Value.ToString();
            txt_StokAdet.Text = grd_listele.CurrentRow.Cells[6].Value.ToString();
            txt_Adet.Text = grd_listele.CurrentRow.Cells[6].Value.ToString();
            txt_Oran.Text = grd_listele.CurrentRow.Cells[8].Value.ToString();
        }

        private void cm_KumasCinsi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int kumascinsi = Convert.ToInt32(cm_KumasCinsi.SelectedValue);
                var sorgu = from urunadi in db.tbl_Uretim.Where(x => x.KumasCinsiID == kumascinsi)
                            join ad in db.tbl_Kategori on urunadi.UretimAdi equals ad.ID
                            select new
                            {
                                ad.ID,
                                ad.KategoriAdi
                            };

                cm_UrunAdi.DataSource = sorgu.ToList();
                cm_UrunAdi.DisplayMember = "KategoriAdi";
                cm_UrunAdi.ValueMember = "ID";
                cm_stokkodu.SelectedValue = "";
                cm_UrunAdi.SelectedValue = "";
            }
            catch (Exception)
            {

            }
        }

        private void cm_UrunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int urunadi = Convert.ToInt32(cm_UrunAdi.SelectedValue);
                int kumascinsi = Convert.ToInt32(cm_KumasCinsi.SelectedValue);
                var sorgu = from stok in db.tbl_Uretim.Where(x => x.UretimAdi == urunadi & x.KumasCinsiID == kumascinsi)
                            join no in db.tbl_KumasAlis on stok.StokKoduID equals no.Kumas_alis_ID
                            select new
                            {
                                no.Kumas_alis_ID,
                                no.StokKoduID
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
                int stokno, urunadi;
                stokno = Convert.ToInt32(cm_stokkodu.SelectedValue);
                urunadi = Convert.ToInt32(cm_UrunAdi.SelectedValue);
                var sorgu = from miktar in db.tbl_Uretim.Where(x => x.StokKoduID == stokno & x.UretimAdi == urunadi)
                            select new
                            {
                                miktar.UretimID,
                                miktar.Miktar_KG_
                            };
                cm_stokUrun.DataSource = sorgu.ToList();
                cm_stokUrun.DisplayMember = "Miktar_KG_";
                cm_stokUrun.ValueMember = "UretimID";

            }
            catch (Exception)
            {

            }
        }

        private void txt_KarOrani_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int KDV = Convert.ToInt32(txt_KDV.Text), BirimFiyati = Convert.ToInt32(txt_BirimFiyati.Text), Karorani2, KDV2, Karorani = Convert.ToInt32(txt_KarOrani.Text);
                int adet = Convert.ToInt32(txt_Adet.Text), tp;
                tp = BirimFiyati * adet;
                KDV2 = tp * KDV / 100;
                Karorani2 = tp * Karorani / 100;
                int fiyat = tp + KDV2 + Karorani2;
                txt_fiyat.Text = fiyat.ToString();
            }
            catch (Exception)
            {
                
            }
        }


        private void txt_KDV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int KDV = Convert.ToInt32(txt_KDV.Text), BirimFiyati = Convert.ToInt32(txt_BirimFiyati.Text), Karorani2, KDV2, Karorani = Convert.ToInt32(txt_KarOrani.Text);
                int adet = Convert.ToInt32(txt_Adet.Text), tp;
                tp = BirimFiyati * adet;
                KDV2 = tp * KDV / 100;
                Karorani2 = tp * Karorani / 100;
                int fiyat = tp + KDV2 + Karorani2;
                txt_fiyat.Text = fiyat.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txt_Kilo_TextChanged(object sender, EventArgs e)
        {
            // adet girilince kilo gelsin
            try
            {
                float adet = Convert.ToUInt32(txt_Adet.Text);
                float oran;
                oran = Convert.ToUInt32(txt_Oran.Text);
                float kilo = adet * oran; 
            }
            catch (Exception)
            {

            }
        }
    }
}
