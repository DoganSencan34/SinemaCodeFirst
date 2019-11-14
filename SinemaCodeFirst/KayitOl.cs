using SinemaCodeFirst.ORM.Context;
using SinemaCodeFirst.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaCodeFirst
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }
        ServerContext db = new ServerContext();
        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                Kullanici kl = new Kullanici();
                kl.KullaniciAdi = textBox1.Text;
                kl.Sifre = textBox2.Text;
                kl.Yetki = "0";
                db.Kullanicis.Add(kl);
                db.SaveChanges();

                KullaniciGirisi kullanici= new KullaniciGirisi();
                kullanici.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Alanları Boş Geçilmez..");
            }
        }
    }
}
