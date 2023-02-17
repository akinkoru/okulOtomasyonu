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
    public partial class Izinler : Form
    {
        public Izinler()
        {
            InitializeComponent();
        }
        Izin izin = new Izin();
        IzinORM iORM = new IzinORM();
        private void Izinler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = iORM.Listele();
            dataGridView2.DataSource = iORM.mevcutizinliler();
        }
        Entity.Logs log = new Entity.Logs();
        LogsORM loORM = new LogsORM();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt Eklensin mi?", "EKLEME", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                izin.ogrenci_no = Convert.ToInt32(tb_ogrenciNo.Text);
                izin.izin_baslangic = dt_Baslangic.Value;
                izin.izin_bitis = dt_Bitis.Value;
                izin.izin_nedeni = tb_izinNeden.Text;
                bool sonuc = iORM.Ekle(izin);
                if (sonuc) {
                    MessageBox.Show("Kayıt ekleme başarılı");
                    log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "İZİN EKLE";
                    loORM.Ekle(log);
                }
                else MessageBox.Show("Kayıt ekleme başarısız");
                dataGridView1.DataSource = iORM.Listele();
            }
            else MessageBox.Show("Ekleme yapılmadı");

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt Silinsin mi?", "SİLME", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                iORM.Sil(id);
                log.kimin_tarafindan = Frm_Giris_Yap.id;
                log.tarih = DateTime.Now;
                log.yapilan_is = "İZİN SİL";
                loORM.Ekle(log);
                dataGridView1.DataSource = iORM.Listele();
            }
            else MessageBox.Show("Silme yapılmadı");
        }
        int id;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id =Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            tb_ogrenciNo.Text = dataGridView1.CurrentRow.Cells["ogrenci_no"].Value.ToString();
            tb_izinNeden.Text = dataGridView1.CurrentRow.Cells["izin_nedeni"].Value.ToString();
            dt_Baslangic.Value = (DateTime)dataGridView1.CurrentRow.Cells["izin_baslangic"].Value;
            dt_Bitis.Value = (DateTime)dataGridView1.CurrentRow.Cells["izin_bitis"].Value;

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt Eklensin mi?", "EKLEME", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                izin.id = id;
                izin.ogrenci_no = Convert.ToInt32(tb_ogrenciNo.Text);
                izin.izin_nedeni = tb_izinNeden.Text;
                izin.izin_baslangic = dt_Baslangic.Value;
                izin.izin_bitis = dt_Bitis.Value;
                bool sonuc = iORM.Guncelle(izin);
                if (sonuc) {MessageBox.Show("Güncelleme İşlemi Başarılı");
                    log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "İZİN GÜNCELLE";
                    loORM.Ekle(log);}
                else MessageBox.Show("Güncelleme İşlemi Başarısız");
                dataGridView1.DataSource = iORM.Listele();
            }
            else MessageBox.Show("Güncelleme yapılmadı ");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void btnTabloGetir_Click(object sender, EventArgs e)
        {
        }

        private void tb_ara_TextChanged(object sender, EventArgs e)
        {
            if(tb_ara.Text=="")dataGridView1.DataSource = iORM.Listele();
            else dataGridView1.DataSource = iORM.arat(tb_ara.Text);
        }
    }
}
