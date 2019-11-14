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
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = "";
            string sifre = "";
            string yetki = "";

            List<Kullanici> f = new List<Kullanici>();
            f = db.Kullanicis.Where(x => x.KullaniciAdi == textBox1.Text).ToList();
            foreach (Kullanici item in f)
            {
                ad = item.KullaniciAdi.ToString();
                sifre = item.Sifre.ToString();
                yetki = item.Yetki.ToString();
            }
            
            if (ad == textBox1.Text)
            {
                if (sifre == textBox2.Text)
                {
                    if (yetki=="1")
                    {
                        AdminPaneli adminPaneli = new AdminPaneli();
                        adminPaneli.Show();
                    }
                    else
                    {
                        Form1 frm1 = new Form1();
                        frm1.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Şifreniz Yanlış");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Yok..");
            }



        }
        ServerContext db = new ServerContext();

        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {
            if (db.Kullanicis.Count() < 1)
            {
                Kullanici kl = new Kullanici();
                kl.KullaniciAdi = "Doğan";
                kl.Sifre = "1";
                kl.Yetki = "1";

                db.Kullanicis.Add(kl);
                db.SaveChanges();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl kayitOl = new KayitOl();
            kayitOl.Show();
            this.Hide();
        }

       
    }
}
