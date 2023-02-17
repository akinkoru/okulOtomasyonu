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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = persORM.Listele();
            cb_pozisyon.DataSource = pozorm.Listele();
            cb_pozisyon.DisplayMember = "pozisyon_adi";
            cb_pozisyon.ValueMember = "pozisyon_id";
        }

        private void tb_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        PersonelORM persORM = new PersonelORM();
        PozisyonORM pozorm = new PozisyonORM();
        Entity.Logs log = new Entity.Logs();
        LogsORM loORM = new LogsORM();
        short id;
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt Eklensin mi?", "EKLEME", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Personel personel = new Personel();
                personel.ad = tb_ad.Text;
                personel.e_posta = textBox5.Text;
                personel.giris_yili = dt_giris.MaxDate;
                personel.k_adi = tb_kadi.Text;
                personel.pozisyon = Convert.ToInt16(cb_pozisyon.SelectedValue);
                personel.sifre = tb_sifre.Text;
                personel.soyad = tb_soyad.Text;
                personel.tc = tb_tc.Text;
                personel.tel_no = maskedTextBox1.Text;
                bool sonuc = persORM.Ekle(personel);
                if (sonuc) { MessageBox.Show("Kayıt ekleme başarılı oldu");
                    log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "PERSONEL EKLE";
                    loORM.Ekle(log);}
                else MessageBox.Show("Kayıt ekleme başarısız oldu");
                dataGridView1.DataSource = persORM.Listele();
            }
            else MessageBox.Show("Ekleme yapılmadı");
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e){   }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            id = (short)dataGridView1.CurrentRow.Cells["id"].Value;
            tb_ad.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            tb_kadi.Text = dataGridView1.CurrentRow.Cells["k_adi"].Value.ToString();
            tb_sifre.Text = dataGridView1.CurrentRow.Cells["sifre"].Value.ToString();
            tb_soyad.Text = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString();
            tb_tc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["e_posta"].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells["tel_no"].Value.ToString();
                dt_giris.Text = dataGridView1.CurrentRow.Cells["giris_yili"].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt silinsin mi?", "SİL", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                log.kimin_tarafindan = Frm_Giris_Yap.id;
                log.tarih = DateTime.Now;
                log.yapilan_is = "PERSONEL SİL";
                loORM.Ekle(log);
                persORM.Sil(id);
                dataGridView1.DataSource = persORM.Listele();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt silinsin mi?", "SİL", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Personel personel = new Personel();
                personel.id = id;
                personel.ad = tb_ad.Text;
                personel.e_posta = textBox5.Text;
                personel.giris_yili = dt_giris.MaxDate;
                personel.k_adi = tb_kadi.Text;
                personel.pozisyon = Convert.ToInt16(cb_pozisyon.SelectedValue);
                personel.sifre = tb_sifre.Text;
                personel.soyad = tb_soyad.Text;
                personel.tc = tb_tc.Text;
                personel.tel_no = maskedTextBox1.Text;
                bool sonuc = persORM.Guncelle(personel);
                if (sonuc) { MessageBox.Show("Güncelleme Başarılı");
                    log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "PERSONEL GÜNCELLE";
                    loORM.Ekle(log);            }
                else MessageBox.Show("Güncelleme Başarısız");
                dataGridView1.DataSource = persORM.Listele();
            }
            else MessageBox.Show("Güncelleme yapılmadı");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void tb_ara_TextChanged(object sender, EventArgs e)
        {
            if (tb_ara.Text=="")   dataGridView1.DataSource = persORM.Listele();
            else dataGridView1.DataSource = persORM.arat(tb_ara.Text);
        }
    }
}
