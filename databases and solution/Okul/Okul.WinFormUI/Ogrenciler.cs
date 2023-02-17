using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Okul.Entity;
using Okul.ORM;

namespace Okul.WinFormUI
{
    public partial class Ogrenciler : Form
    {
        public Ogrenciler()
        {
            InitializeComponent();
        }
        Ogrenci o = new Ogrenci();
        OgrenciORM Oorm = new OgrenciORM();
        SinifORM sorm = new SinifORM();
        
        private void Ogrenciler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Oorm.Listele();
            cb_sinifi.DataSource = sorm.Listele();
            cb_sinifi.DisplayMember = "sinif_adi";
            cb_sinifi.ValueMember = "id";
        }
        Entity.Logs log = new Entity.Logs();
        LogsORM loORM = new LogsORM();
        OgrenciORM oorm = new OgrenciORM();
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt Eklensin mi?", "EKLEME", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                o.ad = tb_ad.Text;
                o.Ogrenci_no = Convert.ToInt32(tb_ogrenciNo.Text);
                o.sinifi = (short)cb_sinifi.SelectedValue;
                o.soyad = tb_soyad.Text;
                o.tc = tb_tc.Text;
                bool sonuc = oorm.ogrenciEkle(o);
                if (sonuc) { MessageBox.Show("Kayıt Eklemesi Başarılı");
                    log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "ÖĞRENCİ EKLE";
                    loORM.Ekle(log);
                }
                else MessageBox.Show("Kayıt Eklemesi Başarısız");
                dataGridView1.DataSource = Oorm.Listele();
            }
            else MessageBox.Show("Ekleme yapılmadı");
        }
        int id;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Ogrenci_no"].Value);
            tb_ogrenciNo.Text = id.ToString();
            tb_ad.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            tb_soyad.Text = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString();
            tb_tc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt Güncellensin mi?", "GÜNCELLE", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                o.ad = tb_ad.Text;
                o.Ogrenci_no = Convert.ToInt32(tb_ogrenciNo.Text);
                o.sinifi = (short)cb_sinifi.SelectedValue;
                o.soyad = tb_soyad.Text;
                o.tc = tb_tc.Text;
                bool sonuc = Oorm.Guncelle(o);
                if (sonuc) { MessageBox.Show("Güncelleme Başarılı");
                    log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "ÖĞRENCİ GÜNCELLE";
                    loORM.Ekle(log);}
                else MessageBox.Show("Güncelleme Başarısız");
                dataGridView1.DataSource = Oorm.Listele();
            }
            else MessageBox.Show("Güncelleme yapılmadı");
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt Silinsin mi?", "SİL", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                log.kimin_tarafindan = Frm_Giris_Yap.id;
                log.tarih = DateTime.Now;
                log.yapilan_is = "ÖĞRENCİ SİL";
                loORM.Ekle(log);
                Oorm.Sil(id);
                dataGridView1.DataSource = Oorm.Listele();
            }
            else MessageBox.Show("Silme işlemi yapılmadı");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void tb_ara_TextChanged(object sender, EventArgs e)
        {
            if (tb_ara.Text=="") dataGridView1.DataSource = Oorm.Listele();
            else dataGridView1.DataSource = Oorm.arat(tb_ara.Text);

        }
    }
}
