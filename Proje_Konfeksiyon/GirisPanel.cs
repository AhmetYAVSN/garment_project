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
    public partial class GirisPanel : Form
    {
        public GirisPanel()
        {
            InitializeComponent();
        }

           DBEntities db = new DBEntities();

        void temizle()
        {
            txt_kulad.Text = "";
            txt_sifre.Text = "";
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                var Giris = db.tbl_KulKayit.Where(x => x.YetkiID == 1 | x.YetkiID == 2 | x.YetkiID == 3 && x.Kul_Ad == txt_kulad.Text && x.Sifre == txt_sifre.Text).FirstOrDefault();

                if (Giris == null)
                {
                    MessageBox.Show("Giriş İçin Yetkiniz Yok");
                    lbl_bilgilendirme.Text = "Lütfen Admin Yetkisi Olan Bir Kullanıcı Adı ve Şifre Giriniz.";
                }

                else if (Giris.Kul_Ad == txt_kulad.Text && Giris.Sifre == txt_sifre.Text && Giris.YetkiID == 1 | Giris.YetkiID == 2 | Giris.YetkiID == 3 )
                {
                    AnaForm giris = new AnaForm();
                    giris.YetkiID = Convert.ToInt32(Giris.YetkiID);
                    giris.PersonelID = Giris.Kul_ID;
                    giris.ShowDialog();

                }
                
                //           ŞİFRESİZ GİRİŞ           //
                //AnaForm giris = new AnaForm();
                //giris.Show();
                //temizle();

            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata ile Karşılaşıldı.");

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (checkBox1.Checked)
            {
                //karakteri göster.
                txt_sifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                txt_sifre.PasswordChar = '*';
            }
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                var Giris = db.tbl_KulKayit.Where(x => x.YetkiID == 1  && x.Kul_Ad == txt_kulad.Text && x.Sifre == txt_sifre.Text).FirstOrDefault();
                if (Giris == null)
                {
                    MessageBox.Show("Kayıt Etmek İçin Yetkiniz Yok");
                    lbl_bilgilendirme.Text = "Lütfen Admin Yetkisi Olan Bir Kullanıcı Adı ve Şifre Giriniz.";
                }

                else if (Giris.Kul_Ad == txt_kulad.Text && Giris.Sifre == txt_sifre.Text && Giris.YetkiID == 1 | Giris.YetkiID == 2)
                {

                    KayitEt kayit = new KayitEt();
                    kayit.ShowDialog();
                }
                temizle();

            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata ile Karşılaşıldı.");

            }
                  }

        private void GirisPanel_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dr = MessageBox.Show("Programdan çıkmak istiyormusunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
                e.Cancel = false;
            else e.Cancel = true;
        }

    }
}
