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
    public partial class Siniflar : Form
    {
        public Siniflar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        Sinif s = new Sinif();
        SinifORM sorm = new SinifORM();
        private void Siniflar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sorm.Listele();
        }
        Entity.Logs log = new Entity.Logs();
        LogsORM loORM = new LogsORM();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt Eklensin mi?", "EKLEME", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                s.sinif_adi = textBox1.Text;
                bool sonuc = sorm.Ekle(s);
                if (sonuc) { MessageBox.Show("Ekleme işlemi başarılı");
                    log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "SINIF EKLE";
                    loORM.Ekle(log);
                }
                else MessageBox.Show("Ekleme işlemi başarısız");
                dataGridView1.DataSource = sorm.Listele();
            }
            else MessageBox.Show("Kayıt eklenmedi");

        }
        short id;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (short)dataGridView1.CurrentRow.Cells["id"].Value;
            textBox1.Text = dataGridView1.CurrentRow.Cells["sinif_adi"].Value.ToString();
            dataGridView2.DataSource = oorm.SinifGetir(id);
        }
        OgrenciORM oorm = new OgrenciORM();
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt Eklensin mi?", "EKLEME", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                s.sinif_adi = textBox1.Text;
                s.id = id;
                bool sonuc = sorm.Guncelle(s);
                if (sonuc) { MessageBox.Show("Guncelleme işlemi başarılı");
                    log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "SINIF GÜNCELLE";
                    loORM.Ekle(log);
                }
                else MessageBox.Show("Guncelleme işlemi başarısız");
                dataGridView1.DataSource = sorm.Listele();
            }
            else MessageBox.Show("Güncellenmedi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt Eklensin mi?", "EKLEME", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                log.kimin_tarafindan = Frm_Giris_Yap.id;
                log.tarih = DateTime.Now;
                log.yapilan_is = "SINIF SİL";
                loORM.Ekle(log);
                sorm.Sil(id);
                dataGridView1.DataSource = sorm.Listele();
            }
            else MessageBox.Show("Kayıt silinmedi");
        }
    }
}
