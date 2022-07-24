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
    public partial class Veliler : Form
    {
        public Veliler()
        {
            InitializeComponent();
        }
        VeliORM vorm = new VeliORM();
        Veli v = new Veli();
        private void Veliler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vorm.Listele();
        }
        Entity.Logs log = new Entity.Logs();
        LogsORM loORM = new LogsORM();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt Eklensin mi?", "EKLEME", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                v.ad = tb_ad.Text;
                v.soyad = tb_soyad.Text;
                v.tc = tb_tc.Text;
                v.tel_no = maskedTextBox1.Text;
                v.ogrenci_no = Convert.ToInt32(tb_ogrenciNo.Text);
                v.e_posta = tb_eposta.Text;
                bool sonuc = vorm.Ekle(v);
                if (sonuc) { MessageBox.Show("Kayıt Ekleme başarılı");
                    log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "VELİ EKLE";
                    loORM.Ekle(log);
                }
                else MessageBox.Show("Kayıt Ekleme Başarısız");
                dataGridView1.DataSource = vorm.Listele();
            }
            else MessageBox.Show("Kayıt eklenmedi");
        }
        short id;
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt silinsin mi?", "SİL", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                vorm.Sil(id);
                dataGridView1.DataSource = vorm.Listele();
                log.kimin_tarafindan = Frm_Giris_Yap.id;
                log.tarih = DateTime.Now;
                log.yapilan_is = "VELİ SİL";
                loORM.Ekle(log);
            }
            else MessageBox.Show("Silinmedi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt silinsin mi?", "SİL", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                v.id = id;
                v.ad = tb_ad.Text;
                v.soyad = tb_soyad.Text;
                v.tc = tb_tc.Text;
                v.tel_no = maskedTextBox1.Text;
                v.ogrenci_no = Convert.ToInt32(tb_ogrenciNo.Text);
                v.e_posta = tb_eposta.Text;
                bool sonuc = vorm.Guncelle(v);
                if (sonuc)
                {
                    MessageBox.Show("Güncelleme başarılı");
                    log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "VELİ GÜNCELLE";
                    loORM.Ekle(log);
                }
                else MessageBox.Show("Güncelleme Başarısız");
                dataGridView1.DataSource = vorm.Listele();
            }
            else MessageBox.Show("güncellenmedi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (short)dataGridView1.CurrentRow.Cells["id"].Value;
            v.id = id;
            tb_ad.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            tb_tc.Text= dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            tb_soyad.Text = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString();
            tb_eposta.Text = dataGridView1.CurrentRow.Cells["e_posta"].Value.ToString();
            tb_ogrenciNo.Text = dataGridView1.CurrentRow.Cells["ogrenci_no"].Value.ToString();
            maskedTextBox1.Text= dataGridView1.CurrentRow.Cells["tel_no"].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") dataGridView1.DataSource = vorm.Listele();
            else dataGridView1.DataSource = vorm.arat(textBox1.Text);
        }
    }
}
