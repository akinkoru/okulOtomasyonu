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
    public partial class Frm_Giris_Yap : Form
    {
        public Frm_Giris_Yap()
        {
            InitializeComponent();
        }

        private void cb_goster_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_goster.Checked)
            {
                tb_Parola.PasswordChar = '\0';
                cb_goster.Text = "şifreyi gizle";
            }
            else
            {
                tb_Parola.PasswordChar = '*';
                cb_goster.Text = "şifreyi göster";

            }
        }
        static public short id;
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            PersonelORM porm = new PersonelORM();
            Personel p = new Personel();
            p.k_adi = tb_kAdi.Text;
            p.sifre = tb_Parola.Text;
           Personel girisyap = porm.girisYap(p);
            
            if (girisyap==null) MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            else
            {
                PersonelORM.kullanici = girisyap;
                switch (girisyap.pozisyon)
                {
                    case 1:
                        id = girisyap.id;
                        MessageBox.Show("Hoş Geldiniz "+girisyap.ad+" "+ girisyap.soyad);
                        Yetkili y = new Yetkili();
                        this.Hide();
                        y.ShowDialog();
                        break;
                    case 2:
                        id = girisyap.id;
                        MessageBox.Show("Hoş Geldiniz " + girisyap.ad + " " + girisyap.soyad+" ");
                        Ogretmen o = new Ogretmen();
                        this.Hide();
                        o.ShowDialog();
                        break;
                    case 3:
                        id = girisyap.id;
                        MessageBox.Show("Hoş Geldiniz " + girisyap.ad + " " + girisyap.soyad + " ");
                        Ogretmen ogr = new Ogretmen();
                        Yetkili yet = new Yetkili();
                        this.Hide();
                        ogr.Show();
                        yet.Show();
                        break;
                    default:
                        break;
                       
                }
               
               
            }
        }

        private void Frm_Giris_Yap_Load(object sender, EventArgs e)
        {

        }
    }
}
