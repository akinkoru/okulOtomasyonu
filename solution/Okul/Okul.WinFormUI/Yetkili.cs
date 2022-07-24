using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul.WinFormUI
{
    public partial class Yetkili : Form
    {
        public Yetkili()
        {
            InitializeComponent();
        }
        Personeller p = new Personeller();

        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p = new Personeller();
            p.MdiParent = this;
            p.Show();
            
            
        }
        Pozisyonlar poz = new Pozisyonlar();
        private void pozisyonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
               
            poz.MdiParent = this;
            poz.Show();
        }
        Ogrenciler ogr = new Ogrenciler();
        private void öğrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ogr.MdiParent = this;
            ogr.Show();
        }
            Izinler izin = new Izinler();

        private void izinlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            izin.MdiParent = this;
            izin.Show();
        }
        Disiplin disiplin = new Disiplin();
        private void disiplinToolStripMenuItem_Click(object sender, EventArgs e)
        {
                disiplin.MdiParent = this;
            disiplin.Show();
        }
            Okul_Girisleri og = new Okul_Girisleri();
        private void okulGirişleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            og.MdiParent = this;
            og.Show();
        }
            Dersler dersler = new Dersler();

        private void derslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dersler.MdiParent = this;
            dersler.Show();
        }

        private void öğretmenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        Devamsizlik devam = new Devamsizlik();
        private void devamsızlıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devam.MdiParent = this;
            devam.Show();
        }
        Logs l = new Logs();
        private void logKayıtlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            l.MdiParent = this;
            l.Show();
        }
 Ogretmen_Dersleri od = new Ogretmen_Dersleri();
        private void öğretmenDersleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            od.MdiParent = this;
            od.Show();
        }
            Siniflar siniflar = new Siniflar();

        private void sınıflarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siniflar.MdiParent = this;
            siniflar.Show();
        }
        Veliler v = new Veliler();

        private void velilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.MdiParent = this;
            v.Show();
        }
            KartAyarları krt = new KartAyarları();

        private void kartAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            krt.MdiParent = this;
            krt.Show();

        }

        private void Yetkili_Load(object sender, EventArgs e)
        {

        }
    }
}
