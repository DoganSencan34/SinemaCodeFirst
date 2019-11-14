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
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AvmEkle avmEkle = new AvmEkle();
            avmEkle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalonEkle salonEkle = new SalonEkle();
            salonEkle.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FilimEkle filimEkle = new FilimEkle();
            filimEkle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hasilat avmHasilat = new Hasilat();
            avmHasilat.Show();
        }
    }
}
