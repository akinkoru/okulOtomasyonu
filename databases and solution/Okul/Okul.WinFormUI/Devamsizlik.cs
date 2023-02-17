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
    public partial class Devamsizlik : Form
    {
        public Devamsizlik()
        {
            InitializeComponent();
        }
        YoklamaORM yokORM = new YoklamaORM();
        private void button1_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(textBox1.Text);
            dataGridView1.DataSource = yokORM.yoklamaogrencigetir(no);
            label2.Text = string.Format("TOTAL DEVAMSIZLIK:{0}", yokORM.total(no).ToString());
        }
        LogsORM loORM = new LogsORM();
        Entity.Logs log = new Entity.Logs();
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Silme işlemi yapılsın mı?", "SİL", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                log.kimin_tarafindan = Frm_Giris_Yap.id;
                log.tarih = DateTime.Now;
                log.yapilan_is = "YOKLAMA SİL";
                loORM.Ekle(log);
                yokORM.Sil(id);
            }
            else MessageBox.Show("Silme işlemi yapılmadı");
            
        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
        }

        private void Devamsizlik_Load(object sender, EventArgs e)
        {

        }
    }
}
