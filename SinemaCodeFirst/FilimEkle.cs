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
    public partial class FilimEkle : Form
    {
        public FilimEkle()
        {
            InitializeComponent();
        }
        ServerContext db = new ServerContext();
        private void FilimEkle_Load(object sender, EventArgs e)
        {
            cmb_avm.DataSource = db.Avms.ToList();
            cmb_avm.DisplayMember = "AvmAdi";
            cmb_avm.ValueMember = "AvmID";
            cmb_avm.SelectedIndex = -1;


            cmb_Salon.DataSource = db.Salons.ToList();
            cmb_Salon.DisplayMember = "salonNo";
            cmb_Salon.ValueMember = "salonID";
            cmb_Salon.SelectedIndex = -1;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Filimler filimler = new Filimler();
            filimler.filmAdi = txt_filimadi.Text;
            filimler.filmGise = txt_filimgise.Text;
            filimler.filmImdb = Convert.ToDecimal(txt_filimimdb.Text);
            filimler.filmOyuncular = txt_filimoyunculari.Text;
            filimler.filmSuresi = txt_filimsuresi.Text;
            filimler.filmTuru = txt_filimturu.Text;

            filimler.filmYönetmeni = txt_filimyonetmen.Text;

            filimler.AvmId = Convert.ToInt32(cmb_avm.SelectedValue);

            filimler.SalonId = Convert.ToInt32(cmb_avm.SelectedValue);

            db.Filimlers.Add(filimler);
            db.SaveChanges();

            int id = filimler.filmID;
            MessageBox.Show("Eklendi..");
            this.Hide();



            Koltuk updated = new Koltuk();
            int seans;

            seans = Convert.ToInt32(cmb_Salon.SelectedValue);

            if (Convert.ToInt32(cmb_Salon.SelectedValue) <= 0 && updated == null)
                return;
            else
            {


                Salon salon = db.Salons.Find(seans);
                salon.salonSeans = maskedTextBox1.Text;
                salon.filmId = id;
                db.Entry(db.Salons.Find(seans)).CurrentValues.SetValues(salon);
                db.SaveChanges();

            }



        }
    }
}
