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
    public partial class Ogretmen_Dersleri : Form
    {
        public Ogretmen_Dersleri()
        {
            InitializeComponent();
        }
        Ogretmen_ders od = new Ogretmen_ders();
        Ogretmen_dersORM odorm = new Ogretmen_dersORM();
        Personel p = new Personel();
        PersonelORM porm = new PersonelORM();
        Ders d = new Ders();
        DersORM dersorm = new DersORM();
        private void Ogretmen_Ders_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = odorm.Listele();
            comboBox1.DataSource = porm.adsoyadgetir();
            comboBox1.DisplayMember = "adsoyad";
            comboBox1.ValueMember = "id";
            comboBox2.DataSource = dersorm.Listele();
            comboBox2.DisplayMember = "ders_adi";
            comboBox2.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            od.personel_id = Convert.ToInt32(comboBox1.SelectedValue);
            od.ders_id = Convert.ToInt32(comboBox2.SelectedValue);
            bool sonuc = odorm.Ekle(od);
            if (sonuc) MessageBox.Show("Kayıt Ekleme başarılı");
            else MessageBox.Show("Kayıt Ekleme başarısız");
            dataGridView1.DataSource = odorm.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            odorm.Sil(id);
            dataGridView1.DataSource = odorm.Listele();
        }
        int id;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
        }
    }
}
