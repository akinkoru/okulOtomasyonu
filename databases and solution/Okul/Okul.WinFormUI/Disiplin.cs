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
    public partial class Disiplin : Form
    {
        public Disiplin()
        {
            InitializeComponent();
        }
        Entity.Disiplin ds = new Entity.Disiplin();
        LogsORM loORM = new LogsORM();
        DisiplinORM dorm = new DisiplinORM();
        Entity.Logs log = new Entity.Logs();
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Ekleme işlemi yapılsın mı?", "Ekle", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                ds.ogrenci_no = tb_OgrenciNo.Text;
                ds.ceza = textBox1.Text;
                ds.ceza_baslangic = dateTimePicker1.Value;
                ds.ceza_bitis = dateTimePicker2.Value;
                bool sonuc = dorm.Ekle(ds);
                if (sonuc)
                {   MessageBox.Show("Ekleme Başarılı"); log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "DİSİPLİN EKLE";
                    loORM.Ekle(log);}
                else MessageBox.Show("Ekleme Başarısız");
                dataGridView1.DataSource = dorm.Listele();
            }
            else MessageBox.Show("Ekleme yapılmadı");
        }

        private void Disiplin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dorm.Listele();
            dataGridView2.DataSource = dorm.Cezalı();
        }
        int id;
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Silme işlemi yapılsın mı?", "SİL", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                ds.id = id;
                ds.ogrenci_no = tb_OgrenciNo.Text;
                ds.ceza = textBox1.Text;
                ds.ceza_baslangic = dateTimePicker1.Value;
                ds.ceza_bitis = dateTimePicker2.Value;
                bool sonuc = dorm.Guncelle(ds);
                if (sonuc) { MessageBox.Show("Güncelleme Başarılı");
                    log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "DİSİPLİN GÜNCELLE";
                    loORM.Ekle(log);
                }
                else MessageBox.Show("Güncelleme Başarısız");
                dataGridView1.DataSource = dorm.Listele();
            }
            else MessageBox.Show("Güncelleme yapılmadı");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            tb_OgrenciNo.Text = dataGridView1.CurrentRow.Cells["ogrenci_no"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["ceza"].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells["ceza_baslangic"].Value;
            dateTimePicker2.Value = (DateTime)dataGridView1.CurrentRow.Cells["ceza_bitis"].Value;}

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Silme işlemi yapılsın mı?", "SİL", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                log.kimin_tarafindan = Frm_Giris_Yap.id;
                log.tarih = DateTime.Now;
                log.yapilan_is = "DİSİPLİN SİL";
                loORM.Ekle(log);
                dorm.Sil(id);
                dataGridView1.DataSource = dorm.Listele();
            }
            else MessageBox.Show("Silme işlemi yapılmadı");
            }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void tb_ara_TextChanged(object sender, EventArgs e)
        {
            if (tb_ara.Text=="") dataGridView1.DataSource = dorm.Listele();
            else dataGridView1.DataSource = dorm.arat(tb_ara.Text);
        }
    }
    }
