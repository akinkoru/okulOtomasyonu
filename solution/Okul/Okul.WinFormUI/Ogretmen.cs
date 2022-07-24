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
    public partial class Ogretmen : Form
    {
        public Ogretmen()
        {
            InitializeComponent();
        }


        SinifORM sorm = new SinifORM();
        OgrenciORM oorm = new OgrenciORM();
        Ogrenci o = new Ogrenci();
        IzinORM izinORM = new IzinORM();
        DisiplinORM dORM = new DisiplinORM();
        Ogretmen_dersORM odORM = new Ogretmen_dersORM();
        private void Ogretmen_Load(object sender, EventArgs e)
        {
            Ogretmen_sinifORM ogtORM = new Ogretmen_sinifORM();
            Ogretmen_sinif osinif = new Ogretmen_sinif();
            osinif.personel_id = Frm_Giris_Yap.id;
            dataGridView1.DataSource = oorm.Listele();
            dataGridView1.Hide();
            dataGridView2.DataSource = ogtORM.Listele();
            dataGridView2.Hide();
            dataGridView3.DataSource = ogtORM.sinifGetir(osinif);
            dataGridView3.Hide();
            dataGridView4.Hide();
            dataGridView5.DataSource = izinORM.mevcutizinliler();
            dataGridView6.DataSource = dORM.Cezalı();
            dataGridView5.Hide();
            dataGridView6.Hide();
            dataGridView7.DataSource = odORM.sinifGetir(Frm_Giris_Yap.id);
            dataGridView7.Hide();

            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            listBox1.Items.Add(dataGridView3.Rows[i].Cells["sinif_adi"].Value.ToString());
            for (int i = 0; i < dataGridView7.Rows.Count - 1; i++)
                listBox2.Items.Add(dataGridView7.Rows[i].Cells["ders_adi"].Value.ToString());

        }
        private void yoklamaAlToolStripMenuItem_Click(object sender, EventArgs e){}
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls) if (c is Button) this.Controls.Remove(c);
            int bttop = 30; string ad, soyad, numara,durum;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {  if ((short)dataGridView1.Rows[i].Cells["sinifi"].Value == sorm.sinifidgetir(Convert.ToString(listBox1.SelectedItem)))
             { ad = dataGridView1.Rows[i].Cells["ad"].Value.ToString();
                soyad = dataGridView1.Rows[i].Cells["soyad"].Value.ToString();
                numara = dataGridView1.Rows[i].Cells["Ogrenci_no"].Value.ToString();                    
                Button bt = new Button();
                if (dataGridView6.RowCount > 0) { 
                for (int j = 0; j < dataGridView6.RowCount - 1; j++)
               {if (numara == dataGridView6.Rows[j].Cells["ogrenci_no"].Value.ToString())
               {bt.BackgroundImage=Properties.Resources.banCat;bt.BackgroundImageLayout = ImageLayout.Stretch; bt.BackColor = Color.LightGray; bt.ForeColor = Color.White;bt.Enabled = false; }}}
                    if (dataGridView5.RowCount > 0)
                    {for (int k = 0; k < dataGridView5.RowCount - 1; k++)
                    { if (numara == dataGridView5.Rows[k].Cells["ogrenci_no"].Value.ToString())
                    { bt.BackgroundImage = Properties.Resources.sickCat;bt.BackColor = Color.Green; bt.BackgroundImageLayout=ImageLayout.Stretch; bt.ForeColor = Color.White; bt.Enabled = false; }}}
                    bt.Height = bt.Width = 85;
                if (bt.Left > 1000) bttop += 105;
                bt.Top = bttop;
                bt.Left = 5 + (i * 105);
                bt.Text = string.Format("{0} \n {1} {2}", numara, ad, soyad);
                bt.Tag= dataGridView1.Rows[i].Cells["Ogrenci_no"].Value.ToString();
                bt.Click += Bt_Click;
                this.Controls.Add(bt);}}
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            Button tiklanan =(Button)sender;
            if (tiklanan.BackColor==Color.Red)
            {   tiklanan.BackColor = SystemColors.Control; tiklanan.BackgroundImage = null;
                for (int i = 0; i < listBox3.Items.Count; i++)
                if (listBox3.Items.Contains(tiklanan.Tag))listBox3.Items.RemoveAt(i);}
            else {tiklanan.BackgroundImage=Properties.Resources.cat;tiklanan.BackgroundImageLayout = ImageLayout.Stretch ; tiklanan.BackColor=Color.Red; listBox3.Items.Add(tiklanan.Tag);}            
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        Yoklama y = new Yoklama();
        YoklamaORM yokORM = new YoklamaORM();
        private void yOKLAMAYIBİTİRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex==-1 || listBox2.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen ders ve sınıf seçiniz");
            }
            else
            { 
            foreach (Control btn in this.Controls)
            {
                if (btn is Button)
                {
               if (btn.BackColor==Color.Red)
                 {
                        y.ogrenci_no = Convert.ToInt32(btn.Tag);
                        y.tarih = DateTime.Now;
                        y.ders_id=(short)dataGridView7.Rows[derssec].Cells["id"].Value;
                        y.durum = "YOK";
                        bool sonuc = yokORM.Ekle(y);
                        if (sonuc) MessageBox.Show("Yoklama başarıyla alındı");
                        else MessageBox.Show("Yoklama alınamadı");
                    }
                      else  if (btn.BackColor == Color.Green)
                        {
                            y.ogrenci_no = Convert.ToInt32(btn.Tag);
                            y.tarih = DateTime.Now;
                            y.ders_id = (short)dataGridView7.Rows[derssec].Cells["id"].Value;
                            y.durum = "İZİNLİ";
                            bool sonuc = yokORM.Ekle(y);
                            if (sonuc) MessageBox.Show("Yoklama başarıyla alındı");
                            else MessageBox.Show("Yoklama alınamadı");
                        }
                      else  if (btn.BackColor == Color.Red)
                        {
                            y.ogrenci_no = Convert.ToInt32(btn.Tag);
                            y.tarih = DateTime.Now;
                            y.ders_id = (short)dataGridView7.Rows[derssec].Cells["id"].Value;
                            y.durum = "YOK";
                            bool sonuc = yokORM.Ekle(y);
                            if (sonuc) MessageBox.Show("Yoklama başarıyla alındı");
                            else MessageBox.Show("Yoklama alınamadı");
                        }
                        else if (btn.BackColor == Color.LightGray) 
                        {
                            y.ogrenci_no = Convert.ToInt32(btn.Tag);
                            y.tarih = DateTime.Now;
                            y.ders_id = (short)dataGridView7.Rows[derssec].Cells["id"].Value;
                            y.durum = "CEZALI";
                            bool sonuc = yokORM.Ekle(y);
                            if (sonuc) MessageBox.Show("Yoklama başarıyla alındı");
                            else MessageBox.Show("Yoklama alınamadı");
                        }
                    }
               
            }
           }
        }
        int derssec = 0;
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            derssec = listBox2.SelectedIndex;
        }
    }
}
