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
    public partial class Pozisyonlar : Form
    {
        public Pozisyonlar()
        {
            InitializeComponent();
        }
        Entity.Logs log = new Entity.Logs();
        LogsORM loORM = new LogsORM();
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt Eklensin mi?", "EKLEME", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Pozisyon pozisyon = new Pozisyon();
                pozisyon.pozisyon_adi = textBox1.Text;
                pozisyon.yetki_id = (short)comboBox1.SelectedValue;
                PozisyonORM porm = new PozisyonORM();
                bool sonuc = porm.Ekle(pozisyon);
                if (sonuc)
                { MessageBox.Show("Kayıt Eklemesi Başarılı Oldu");
                    log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "POZİSYON EKLE";
                    loORM.Ekle(log);
                }
                else MessageBox.Show("Kayıt Eklemesi Başarısız Oldu");
                dataGridView1.DataSource = porm.Listele();
            }
        }
        
        private void Pozisyonlar_Load(object sender, EventArgs e)
        {
            YetkiORM yorm = new YetkiORM();
            PozisyonORM porm = new PozisyonORM();
            dataGridView1.DataSource = porm.Listele();
            comboBox1.DataSource = yorm.Listele();
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "yetki";
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt güncellensin mi?", "GÜNCELLE", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Pozisyon pozisyon = new Pozisyon();
                pozisyon.pozisyon_id = id;
                pozisyon.pozisyon_adi = textBox1.Text;
                PozisyonORM porm = new PozisyonORM();
                bool sonuc = porm.Guncelle(pozisyon);
                if (sonuc)
                { MessageBox.Show("Güncelleme Başarılı");
                    log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "POZİSYON GÜNCELLE";
                    loORM.Ekle(log);
                }
                else MessageBox.Show("Güncelleme Başarısız");
                dataGridView1.DataSource = porm.Listele();
            }
        }
        short id;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (short)dataGridView1.CurrentRow.Cells["pozisyon_id"].Value;
           textBox1.Text= dataGridView1.CurrentRow.Cells["pozisyon_adi"].Value.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt silinsin mi?", "SİL", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                PozisyonORM porm = new PozisyonORM();
                porm.Sil(id);
                log.kimin_tarafindan = Frm_Giris_Yap.id;
                log.tarih = DateTime.Now;
                log.yapilan_is = "POZİSYON SİL";
                loORM.Ekle(log);
                dataGridView1.DataSource = porm.Listele();
            }
            else MessageBox.Show("Silme işlemi yapılmadı");
        }
    }
}
