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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServerContext db = new ServerContext();
        int avmid =0;
        int filimid = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

            //if (Convert.ToInt32(db.Avms.Count()) < 1)
            //{
            //    Avm avm = new Avm
            //    {
            //        AvmAdi = "Canpark",
            //        AvmAdres = "Ümraniye",
            //        AvmTelefon = "02163548596",
            //        WebAdres = "www.canpark.com",
            //    };

            //    Salon Salon;
            //    Filimler Filimler = new Filimler()
            //    {
            //        filmAdi = "Fırıncının Karısı",
            //        filmTuru = "Komedi ",
            //        filmYönetmeni = "Murat Onbul",
            //        filmGise = "1",
            //        filmImdb = (decimal)2.5,
            //        filmOyuncular = "Büşra Pekin,Alper Kul",
            //        filmSuresi = "1 saat 30 dakika",
            //        AvmId = 1,

            //        Salon = new Salon()
            //        {
            //            salonNo = "1",
            //            salonSeans = "14:40",
            //            salonKapasite = "30",
            //            filmId = 1
            //        },

            //        SalonId = 1

            //    };

            //    db.Avms.Add(avm);
            //    db.SaveChanges();
            //    db.Filimlers.Add(Filimler);
            //    db.SaveChanges();
            //    db.Salons.Add(Salon);

            //    db.SaveChanges();
            //}

            cmb_avm.DataSource = db.Avms.ToList();//listeyi verdim
            cmb_avm.DisplayMember = "AvmAdi";//listelenecek kolon ismi
            cmb_avm.ValueMember = "AvmID";
            cmb_avm.SelectedIndex = -1;
            
           

        }

        private void cmb_avm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cmb_avm.SelectedValue) >= 1)
                {
                    avmid = Convert.ToInt32(cmb_avm.SelectedValue);
                    
                   
                    cmb_film.DataSource = db.Filimlers.Where(x => x.AvmId == avmid).ToList(); //listeyi verdim
                    cmb_film.DisplayMember = "filmAdi";//listelenecek kolon ismi
                    cmb_film.ValueMember = "filmID";
                   
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

               
            }
           
            
        }
       
        private void cmb_film_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cmb_film.SelectedValue) >= 1)
                {
                    filimid = Convert.ToInt32(cmb_film.SelectedValue);


                    cmb_Salon.DataSource = db.Salons.Where(x => x.filmId == filimid).ToList(); //listeyi verdim
                    cmb_Salon.DisplayMember = "salonSeans";//listelenecek kolon ismi
                    cmb_Salon.ValueMember = "salonID";
                    cmb_Salon.SelectedIndex = -1;

                    if (Convert.ToInt32(cmb_Salon.SelectedValue)<=0)
                    {
                        cmb_Salon.Items.Clear();
                    }

                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_avm.SelectedValue != null && cmb_film.SelectedValue != null && cmb_Salon.SelectedValue != null)
            {
                frmKoltukSatis kltk = new frmKoltukSatis();
                kltk.salonid = Convert.ToInt32(cmb_Salon.SelectedValue);
                kltk.filimid = filimid;
                kltk.avmid = avmid;
                kltk.Show();
            }
            else
            {
                MessageBox.Show("Alanlar Boş Geçilemez.");
            }
            
                
        }
    }
}
