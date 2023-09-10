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
    public partial class TedarikciKayit : Form
    {
        public TedarikciKayit()
        {
            InitializeComponent();
        }

        DBEntities db = new DBEntities(); 



        void doldur()
        {
            grd_listele.DataSource = db.tbl_TedarikciKayit.ToList();
        }
        void temizle()
        {
            txt_ID.Text = "";
            txt_Firmaadresi.Text = "";
            txt_Firmatelno.Text = "";
            txt_Firmaİsmi.Text = "";
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_TedarikciKayit firma = new tbl_TedarikciKayit();
                firma.Firmaİsmi = txt_Firmaİsmi.Text;
                firma.FirmaAdres = txt_Firmaadresi.Text;
                firma.Firma_Tel_No = Convert.ToInt32(txt_Firmatelno.Text);
                db.tbl_TedarikciKayit.Add(firma);
                db.SaveChanges();
                temizle();
                doldur();
                MessageBox.Show("Kayıt başarılı.");
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt başarısız.");
            }
        }

        private void btn_vzg_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kayıt et sayfasından çıkmak istiyormusunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            this.Hide();
        }

        private void TedarikciKayit_Load(object sender, EventArgs e)
        {
            temizle();
            doldur();
        }


        private void btn_gucelle_Click(object sender, EventArgs e)
        {
            try
            {

                int firmaID = Convert.ToInt32(txt_ID.Text);
                var firma = db.tbl_TedarikciKayit.Where(x => x.TedarikciID == firmaID).FirstOrDefault();
                firma.Firmaİsmi = txt_Firmaİsmi.Text;
                firma.FirmaAdres = txt_Firmaadresi.Text;
                firma.Firma_Tel_No = Convert.ToInt32(txt_Firmatelno.Text);
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

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                int firmaID = Convert.ToInt32(txt_ID.Text);
                var silinecekfirma = db.tbl_TedarikciKayit.Where(x => x.TedarikciID == firmaID).FirstOrDefault();
                db.tbl_TedarikciKayit.Remove(silinecekfirma);
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

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void grd_listele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = grd_listele.CurrentRow.Cells[0].Value.ToString();
            txt_Firmaİsmi.Text = grd_listele.CurrentRow.Cells[1].Value.ToString();
            txt_Firmaadresi.Text = grd_listele.CurrentRow.Cells[2].Value.ToString();
            txt_Firmatelno.Text = grd_listele.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
