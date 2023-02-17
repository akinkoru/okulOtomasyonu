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
using System.IO.Ports;

namespace Okul.WinFormUI
{
    public partial class KartAyarları : Form
    {
        public KartAyarları()
        {
            InitializeComponent();
        }
        Ogrenci o = new Ogrenci();
        OgrenciORM oorm = new OgrenciORM();
        private void KartAyarları_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
            serialPort1.DataReceived += SerialPort1_DataReceived;
            dataGridView1.DataSource = ogrenci_kartORM.Listele();
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadLine();
            this.Invoke(new EventHandler(displayData_Event));
        }

        private void displayData_Event(object sender, EventArgs e)
        {
            textBox2.Text = data;
        }

        string data;
        Entity.Logs log = new Entity.Logs();
        LogsORM loORM = new LogsORM();
        Ogrenci_Kart ogrencikart = new Ogrenci_Kart();
        Ogrenci_KartORM ogrenci_kartORM = new Ogrenci_KartORM();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kart Eklensin mi?", "KART", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                ogrencikart.Ogrenci_no = Convert.ToInt32(textBox1.Text);
                ogrencikart.kart_no =textBox2.Text;
                bool sonuc = ogrenci_kartORM.Ekle(ogrencikart);
                if (sonuc)
                {
                    MessageBox.Show("Kayıt Eklendi");
                    log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "KART EKLE";
                    loORM.Ekle(log);
                }
                else
                {
                    MessageBox.Show("kayıt eklenemedi");
                }
                dataGridView1.DataSource = ogrenci_kartORM.Listele();
            }
            else MessageBox.Show("Kart Eklenmedi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt silinsin mi?", "SİLME", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
               ogrenci_kartORM.Sil(id);
                log.kimin_tarafindan = Frm_Giris_Yap.id;
                log.tarih = DateTime.Now;
                log.yapilan_is = "KART NO SİL";
                loORM.Ekle(log);
                dataGridView1.DataSource = ogrenci_kartORM.Listele();
            }
            else MessageBox.Show("Silme yapılmadı");
        }
        int id;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            textBox1.Text = dataGridView1.CurrentRow.Cells["Ogrenci_no"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["kart_no"].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt Güncellensin mi?", "Güncelleme", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                ogrencikart.id = id;
                ogrencikart.Ogrenci_no = Convert.ToInt32(textBox1.Text);
                ogrencikart.kart_no = textBox2.Text;
                bool sonuc = ogrenci_kartORM.Guncelle(ogrencikart);
                if (sonuc)
                {
                    MessageBox.Show("Güncelleme İşlemi Başarılı");
                    log.kimin_tarafindan = Frm_Giris_Yap.id;
                    log.tarih = DateTime.Now;
                    log.yapilan_is = "KART GÜNCELLE";
                    loORM.Ekle(log);
                }
                else MessageBox.Show("Güncelleme İşlemi Başarısız");
                dataGridView1.DataSource = ogrenci_kartORM.Listele();
            }
            else MessageBox.Show("Güncelleme yapılmadı ");
        }
    }
}
