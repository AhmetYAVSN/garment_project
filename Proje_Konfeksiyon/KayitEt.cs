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
    public partial class KayitEt : Form
    {
        public KayitEt()
        {
            InitializeComponent();
        }
        DBEntities db = new DBEntities();

        void temizle()
        {
            txt_AdSoyad.Text = "";
            txt_kulismi.Text = "";
            txt_sifre.Text = "";
            txt_telno.Text = "";
            txt_eposta.Text = "";
            txt_Adres.Text = "";
            txt_unvani.Text = "";
            cm_yetki.SelectedValue = "";
        }
        void doldur()
        {
            //Combobax içerisine veri dolduruyoruz
            cm_yetki.DataSource = db.tbl_yetki.ToList();
            cm_yetki.DisplayMember = "Yetki";
            cm_yetki.ValueMember = "ID";
        }
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_KulKayit uye = new tbl_KulKayit();
                uye.Kul_Ad= txt_kulismi.Text;
                uye.Sifre = txt_sifre.Text;
                uye.Ad_Soyad = txt_AdSoyad.Text;
                uye.Kul_Tel_No = txt_telno.Text;
                uye.E_Posta = txt_eposta.Text;
                uye.Adres = txt_Adres.Text;
                uye.Unvani = txt_unvani.Text;
                uye.YetkiID = Convert.ToInt32(cm_yetki.SelectedValue);
                db.tbl_KulKayit.Add(uye);
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

        private void btn_vazgec_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kayıt et sayfasından çıkmak istiyormusunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            this.Hide();
        }

        private void KayitEt_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Programdan çıkmak istiyormusunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            //if (dr == DialogResult.Yes)
            //    e.Cancel = false;
            //else e.Cancel = true;
        }

        private void KayitEt_Load(object sender, EventArgs e)
        {
            doldur();
            temizle();
        }
    }
}
