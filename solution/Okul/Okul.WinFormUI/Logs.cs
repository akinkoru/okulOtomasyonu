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
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }
        Entity.Logs lo = new Entity.Logs();
        LogsORM lorm = new LogsORM();
        int id;
        private void button1_Click(object sender, EventArgs e)
        {
            lorm.Sil(id);
            dataGridView1.DataSource = lorm.Listele();
        }
        private void Logs_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lorm.Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            label2.Text = id.ToString();
            }
            catch (Exception)
            {
            }
           
        }
    }
}
