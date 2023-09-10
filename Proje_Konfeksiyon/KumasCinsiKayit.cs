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
    public partial class KumasCinsiKayit : Form
    {
        public KumasCinsiKayit()
        {
            InitializeComponent();
        }
        DBEntities db = new DBEntities();

        void doldur()
        {
            grd_listele.DataSource = db.tbl_KumasCinsi.ToList();
        }
        private void KumasCinsiKayit_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void btn_Kayitet_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_KumasCinsi kayit = new tbl_KumasCinsi();
                kayit.KumasCinsi = txt_KumasCinsi.Text;
                db.tbl_KumasCinsi.Add(kayit);
                db.SaveChanges();
                doldur();
                txt_KumasCinsi.Text = "";
                txt_ID.Text = "";
                MessageBox.Show("başarılı bir şekilde Kayıt edilmiştir.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt etme işlemi yapılamadı.");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_ID.Text);
                var silinecek = db.tbl_KumasCinsi.Where(x => x.ID == id).FirstOrDefault();
                db.tbl_KumasCinsi.Remove(silinecek);
                db.SaveChanges();
                doldur();
                txt_KumasCinsi.Text = "";
                txt_ID.Text = "";
                MessageBox.Show("başarılı bir şekilde silinmiştir.");
            }
            catch (Exception)
            {
                MessageBox.Show("silme işlemi yapılamadı.");
            }
        }

        private void grd_listele_DoubleClick(object sender, EventArgs e)
        {
            txt_ID.Text = grd_listele.CurrentRow.Cells[0].Value.ToString();
            txt_KumasCinsi.Text = grd_listele.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
