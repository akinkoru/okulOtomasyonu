using Okul.Entity;
using Okul.ORM;
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
    public partial class Dersler : Form
    {
        public Dersler()
        {
            InitializeComponent();
        }
        DersORM dorm = new DersORM();
        Ders d = new Ders();
        private void Dersler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dorm.Listele();
        }
        Entity.Logs log = new Entity.Logs();
        LogsORM loORM = new LogsORM();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt Eklensin mi?", "EKLEME", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
            d.ders_adi = tb_dersadi.Text;
            bool sonuc = dorm.Ekle(d);
                if (sonuc)
                {   MessageBox.Show("Kayıt Ekleme Başarılı");
                    log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "DERS EKLE";
                    loORM.Ekle(log);}
                else MessageBox.Show("Kayıt EKleme Başarısız");
            dataGridView1.DataSource = dorm.Listele();
            }
            else MessageBox.Show("Ekleme yapılmadı");
        }
        short id;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (short)dataGridView1.CurrentRow.Cells["id"].Value;
            tb_dersadi.Text = dataGridView1.CurrentRow.Cells["ders_adi"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Güncelleme yapılsın mı?", "GÜNCELLE", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
            d.id = id;
            d.ders_adi = tb_dersadi.Text;
            bool sonuc = dorm.Guncelle(d);
            if (sonuc) { MessageBox.Show("Güncelleme Başarılı");
                log.kimin_tarafindan = Frm_Giris_Yap.id;
                log.tarih = DateTime.Now;
                    log.yapilan_is = "DERS GÜNCELLE";
                loORM.Ekle(log);
                }
                else MessageBox.Show("Güncelleme Başarısız");
                dataGridView1.DataSource = dorm.Listele();
            }
            else
            {
                MessageBox.Show("Güncelleme yapılmadı");
            }
         }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Silme işlemi yapılsın mı?", "SİL", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                log.kimin_tarafindan = Frm_Giris_Yap.id;
                log.tarih = DateTime.Now;
                log.yapilan_is = "DERS SİL";
                loORM.Ekle(log);
                dorm.Sil(id);
                dataGridView1.DataSource = dorm.Listele();
            }
            else MessageBox.Show("Silme yapılmadı");
           
        }
    }
}
