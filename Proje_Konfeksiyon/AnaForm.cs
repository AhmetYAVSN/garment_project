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
    public partial class AnaForm : Form
    {
        private int childFormNumber = 0;

        public AnaForm()
        {
            InitializeComponent();
        }

        DBEntities db = new DBEntities();
        public int PersonelID, YetkiID;
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void kullanıcıKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            Kullanıcılar kayit = new Kullanıcılar();
            kayit.MdiParent = this;
            kayit.Show();
        }

        private void müşteriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            MusteriKayit kayit = new MusteriKayit();
            kayit.MdiParent = this;
            kayit.Show();
        }

        private void tedarikciKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            TedarikciKayit kayit = new TedarikciKayit();
            kayit.MdiParent = this;
            kayit.Show();
        }

        private void yetkiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            Yetki kayit = new Yetki();
            kayit.MdiParent = this;
            kayit.Show();
        }

        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            KategoriEkle kayit = new KategoriEkle();
            kayit.MdiParent = this;
            kayit.Show();
        }

        private void kumaşAlışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            KumasAlis alis = new KumasAlis();
            alis.MdiParent = this;
            alis.Show();
        }
        private void ürünSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            UrunSatis satis = new UrunSatis();
            satis.MdiParent = this;
            satis.Show();
        }

        private void kumasStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            KumasStok stok = new KumasStok();
            stok.MdiParent = this;
            stok.Show();
        }



        private void üretimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            Uretim uret = new Uretim();
            uret.MdiParent = this;
            uret.Show();
        }

        private void üreimStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            UretimStok uret = new UretimStok();
            uret.MdiParent = this;
            uret.Show();
        }
        private void kumaşAlımGeçmişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            KumasAlimGecmisi stok = new KumasAlimGecmisi();
            stok.MdiParent = this;
            stok.Show();
        }
        private void ürünSatışGeçmişiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

            StokSatis satis = new StokSatis();
            satis.MdiParent = this;
            satis.Show();
        }
        private void hareketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

            Hareket hareket = new Hareket();
            hareket.MdiParent = this;
            hareket.Show();
        }
        private void kumaşCinsiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

            KumasCinsiKayit cins = new KumasCinsiKayit();
            cins.MdiParent = this;
            cins.Show();
        }
        private void üretimGeçmişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

            UretimGecmisi uretim = new UretimGecmisi();
            uretim.MdiParent = this;
            uretim.Show();

        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            var kullanici = db.tbl_KulKayit.Where(X => X.Kul_ID == PersonelID).FirstOrDefault();
            var personelBilgileri = db.tbl_yetki.Where(x => x.ID == YetkiID).FirstOrDefault();
            
            if (personelBilgileri.Kul_Kayit == 0)
            {
                kullanıcıKayıtToolStripMenuItem.Visible = false;
            }
            if (personelBilgileri.Alis_Satis == 0)
            {
                alışSatışToolStripMenuItem.Visible = false;
            }
            if (personelBilgileri.KayitIslemleri == 0)
            {
                kayıtİşlemleriToolStripMenuItem.Visible = false;
            }
            if (personelBilgileri.Stok == 0)
            {
                stokToolStripMenuItem.Visible = false;
            }
            if (personelBilgileri.Raporlar == 0)
            {
                raporlarToolStripMenuItem.Visible = false;
            }
            if (personelBilgileri.Hareket == 0)
            {
                hareketToolStripMenuItem.Visible = false;
            }

            MessageBox.Show(personelBilgileri.Yetki +"\n"+ kullanici.Ad_Soyad
                + " hoş geldiniz.", "Hoşgeldiniz.", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dr = MessageBox.Show("Programı kapatmak istiyormusunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
                e.Cancel = false;
            else e.Cancel = true;
        }


    }
}
