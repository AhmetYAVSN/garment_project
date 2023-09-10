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
    public partial class Yetki : Form
    {
        public Yetki()
        {
            InitializeComponent();
        }

        DBEntities db = new DBEntities();
        int kayitislemleri, alissatis, stok, kulkayit, rapor, hareket;

        void doldur()
        {
            dataGridView1.DataSource = db.tbl_yetki.ToList();
        }
        void temizle()
        {
            txt_yetki.Text = "";
            txt_ID.Text = "";
            chbox_AlisSatis.Checked = false;
            chbox_Hareket.Checked = false;
            chbox_Kayitislemleri.Checked = false;
            chbox_KulKayit.Checked = false;
            chbox_Rapor.Checked = false;
            chbox_stok.Checked = false;
        }


        private void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_yetki.Text != "")
                {


                    if (chbox_Kayitislemleri.Checked == true)
                    {
                        kayitislemleri = 1;
                    }
                    else
                    {
                        kayitislemleri = 0;
                    }
                    if (chbox_AlisSatis.Checked == true)
                    {
                        alissatis = 1;
                    }
                    else
                    {
                        alissatis = 0;
                    }
                    if (chbox_stok.Checked == true)
                    {
                        stok = 1;
                    }
                    else
                    {
                        stok = 0;
                    }
                    if (chbox_Rapor.Checked == true)
                    {
                        rapor = 1;
                    }
                    else
                    {
                        rapor = 0;
                    }
                    if (chbox_Hareket.Checked == true)
                    {
                        hareket = 1;
                    }
                    else
                    {
                        hareket = 0;
                    }
                    if (chbox_KulKayit.Checked == true)
                    {
                        kulkayit = 1;
                    }
                    else
                    {
                        kulkayit = 0;
                    }

                    tbl_yetki kayit = new tbl_yetki();
                    kayit.Yetki = txt_yetki.Text;
                    kayit.KayitIslemleri = kayitislemleri;
                    kayit.Alis_Satis = alissatis;
                    kayit.Stok = stok;
                    kayit.Raporlar = rapor;
                    kayit.Hareket = hareket;
                    kayit.Kul_Kayit = kulkayit;
                    db.tbl_yetki.Add(kayit);
                    db.SaveChanges();
                    doldur();
                    temizle();
                    MessageBox.Show("Kayıt başarılı.");
                }
                else
                {
                    MessageBox.Show("Yetki kısımı boş geçilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt başarısız.");
            }
        
        }

        private void Yetki_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_ID.Text);
                var silinecekyetki  = db.tbl_yetki.Where(x => x.ID== id).FirstOrDefault();
                db.tbl_yetki.Remove(silinecekyetki);
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kayitislemleri = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            alissatis = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            stok = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            rapor = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            hareket = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
            kulkayit = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value);

            if (kayitislemleri == 1)
            {
                chbox_Kayitislemleri.Checked = true;
            }
            else
            {
                chbox_Kayitislemleri.Checked = false;
            }
            if (alissatis == 1)
            {
                chbox_AlisSatis.Checked = true;
            }
            else
            {
                chbox_AlisSatis.Checked = false;
            }
            if (stok == 1)
            {
                chbox_stok.Checked = true;
            }
            else
            {
                chbox_stok.Checked = false;
            }
            if (rapor == 1)
            {
                chbox_Rapor.Checked = true;
            }
            else
            {
                chbox_Rapor.Checked = false;
            }
            if (hareket == 1)
            {
                chbox_Hareket.Checked = true;
            }
            else
            {
                chbox_Hareket.Checked = false;
            }
            if (kulkayit == 1)
            {
                chbox_KulKayit.Checked = true;
            }
            else
            {
                chbox_KulKayit.Checked = false;
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (chbox_Kayitislemleri.Checked == true)
                {
                    kayitislemleri = 1;
                }
                else
                {
                    kayitislemleri = 0;
                }
                if (chbox_AlisSatis.Checked == true)
                {
                    alissatis = 1;
                }
                else
                {
                    alissatis = 0;
                }
                if (chbox_stok.Checked == true)
                {
                    stok = 1;
                }
                else
                {
                    stok = 0;
                }
                if (chbox_Rapor.Checked == true)
                {
                    rapor = 1;
                }
                else
                {
                    rapor = 0;
                }
                if (chbox_Hareket.Checked == true)
                {
                    hareket = 1;
                }
                else
                {
                    hareket = 0;
                }
                if (chbox_KulKayit.Checked == true)
                {
                    kulkayit = 1;
                }
                else
                {
                    kulkayit = 0;
                }

                int YetkiID = Convert.ToInt32(txt_ID.Text);
                var yetki = db.tbl_yetki.Where(x => x.ID == YetkiID).FirstOrDefault();
                yetki.Yetki = txt_yetki.Text;
                yetki.KayitIslemleri = kayitislemleri;
                yetki.Alis_Satis = alissatis;
                yetki.Stok = stok;
                yetki.Raporlar = rapor;
                yetki.Hareket = hareket;
                yetki.Kul_Kayit = kulkayit;
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
    }
}
