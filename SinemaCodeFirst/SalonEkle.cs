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
    public partial class SalonEkle : Form
    {
        public SalonEkle()
        {
            InitializeComponent();
        }

        private void SalonEkle_Load(object sender, EventArgs e)
        {

        }
        ServerContext db = new ServerContext();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Salon sln = new Salon();
                sln.salonNo = textBox1.Text;
                sln.salonKapasite = textBox4.Text;
                db.Salons.Add(sln);
                db.SaveChanges();
                MessageBox.Show("Salon Eklendi.");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Salon Numarasını Giriniz.");
            }

        }
    }
}
