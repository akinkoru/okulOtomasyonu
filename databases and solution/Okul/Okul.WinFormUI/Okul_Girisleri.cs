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
    public partial class Okul_Girisleri : Form
    {
        public Okul_Girisleri()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Okul_Giris og = new Okul_Giris();
        Okul_GirisORM ogORM = new Okul_GirisORM();
        private void Okul_Girisleri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogORM.Listele();
            dataGridView2.DataSource = ogORM.OkulGirisBugun();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void tb_ara_TextChanged(object sender, EventArgs e)
        {
            if (tb_ara.Text=="")
            {
                dataGridView1.DataSource = ogORM.Listele();

            }
            else
            dataGridView1.DataSource = ogORM.arat(tb_ara.Text);
        }
    }
}
