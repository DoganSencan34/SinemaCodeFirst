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
    public partial class frmKoltukSatis : Form
    {
        public frmKoltukSatis()
        {
            InitializeComponent();
        }
        ServerContext db = new ServerContext();
        public int salonid = 0;
        public int filimid = 0;
        public int avmid = 0;
        private void frmKoltukSatis_Load(object sender, EventArgs e)
        {




            KoltukKontrol();

            List<Filimler> f = new List<Filimler>();
            f = db.Filimlers.Where(x => x.filmID == filimid).ToList();
            foreach (Filimler item in f)
            {
                label2.Text = item.filmAdi.ToString();
            }


        }

        private void button16_Click(object sender, EventArgs e)
        {
            Koltuk koltuk = new Koltuk();
            foreach (object item in listBox1.Items)
            {


                koltuk.koltukNo = Convert.ToInt32(item.ToString());
                koltuk.salonId = salonid;

                db.Koltuks.Add(koltuk);
                db.SaveChanges();


            }

            AvmHasilat avmhslt = new AvmHasilat();
            avmhslt.AvmID = avmid.ToString();
            avmhslt.Bakiye = label5.Text;
            db.AvmHasilats.Add(avmhslt);
            db.SaveChanges();


            MessageBox.Show("Eklendi");
            KoltukKontrol();
            this.Hide();

        }


        public void KoltukKontrol()
        {
            List<Koltuk> k = new List<Koltuk>();

            int i = 1;
            if (db.Koltuks.Where(x => x.salonId == salonid).ToList().Count > 0)
            {
                k = db.Koltuks.Where(x => x.salonId == salonid).ToList();
                foreach (Koltuk item in k)
                {
                    if (item.koltukNo == 1)
                    {
                        b1.BackColor = Color.Red;
                        b1.Enabled = false;
                    }
                    else if (item.koltukNo == 2)
                    {
                        b2.BackColor = Color.Red;
                        b2.Enabled = false;
                    }
                    else if (item.koltukNo == 3)
                    {
                        b3.BackColor = Color.Red;
                        b3.Enabled = false;
                    }
                    else if (item.koltukNo == 4)
                    {
                        b4.BackColor = Color.Red;
                        b4.Enabled = false;
                    }
                    else if (item.koltukNo == 5)
                    {
                        b5.BackColor = Color.Red;
                        b5.Enabled = false;
                    }
                    else if (item.koltukNo == 6)
                    {
                        b6.BackColor = Color.Red;
                        b6.Enabled = false;
                    }
                    else if (item.koltukNo == 7)
                    {
                        b7.BackColor = Color.Red;
                        b7.Enabled = false;
                    }
                    else if (item.koltukNo == 8)
                    {
                        b8.BackColor = Color.Red;
                        b8.Enabled = false;
                    }
                    else if (item.koltukNo == 9)
                    {
                        b9.BackColor = Color.Red;
                        b9.Enabled = false;
                    }
                    else if (item.koltukNo == 10)
                    {
                        b10.BackColor = Color.Red;
                        b10.Enabled = false;
                    }
                    else if (item.koltukNo == 11)
                    {
                        b11.BackColor = Color.Red;
                        b11.Enabled = false;
                    }
                    else if (item.koltukNo == 12)
                    {
                        b12.BackColor = Color.Red;
                        b12.Enabled = false;
                    }
                    else if (item.koltukNo == 13)
                    {
                        b13.BackColor = Color.Red;
                        b13.Enabled = false;
                    }
                    else if (item.koltukNo == 14)
                    {
                        b14.BackColor = Color.Red;
                        b14.Enabled = false;
                    }
                    else if (item.koltukNo == 15)
                    {
                        b15.BackColor = Color.Red;
                        b15.Enabled = false;
                    }

                }
            }
        }
        int topla = 0;
        public void Topla()
        {
            if (comboBox1.SelectedIndex == 1)
            {
                topla = topla + 10;
                label5.Text = topla.ToString();
            }
            else
            {
                topla = topla + 15;
                label5.Text = topla.ToString();
            }

        }


        private void b1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("1");
            b1.BackColor = Color.Orange;
            Topla();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("2");
            b2.BackColor = Color.Orange;
            Topla();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("3");
            b3.BackColor = Color.Orange;
            Topla();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("4");
            b4.BackColor = Color.Orange;
            Topla();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("5");
            b5.BackColor = Color.Orange;
            Topla();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("6");
            b6.BackColor = Color.Orange;
            Topla();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("7");
            b7.BackColor = Color.Orange;
            Topla();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("8");
            b8.BackColor = Color.Orange;
            Topla();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("9");
            b9.BackColor = Color.Orange;
            Topla();
        }

        private void b10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("10");
            b10.BackColor = Color.Orange;
            Topla();
        }

        private void b11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("11");
            b11.BackColor = Color.Orange;
            Topla();
        }

        private void b12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("12");
            b12.BackColor = Color.Orange;
            Topla();
        }

        private void b13_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("13");
            b13.BackColor = Color.Orange;
            Topla();
        }

        private void b14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("14");
            b14.BackColor = Color.Orange;
            Topla();
        }

        private void b15_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("15");
            b15.BackColor = Color.Orange;
            Topla();
        }
        int topla2 = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 1)
            {
                topla2 = 0;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    
                    topla2 = topla2 + 10;
                    label5.Text = topla2.ToString();
                }
            }
            else
            {
                topla2 = 0;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                   
                    topla2 = topla2 + 15;
                    label5.Text = topla2.ToString();
                }
            }

        }
    }
}
