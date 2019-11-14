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
    public partial class AvmEkle : Form
    {
        public AvmEkle()
        {
            InitializeComponent();
        }
        ServerContext db = new ServerContext();
        private void button1_Click(object sender, EventArgs e)
        {
            Avm avm = new Avm();
            avm.AvmAdi = textBox1.Text;
            avm.AvmAdres= textBox2.Text;
            avm.AvmTelefon = textBox3.Text;
            avm.WebAdres = textBox4.Text;
            db.Avms.Add(avm);
            db.SaveChanges();
            MessageBox.Show("Avm başarı ile eklendi:)");
            this.Hide();

        }

      
    }
}
