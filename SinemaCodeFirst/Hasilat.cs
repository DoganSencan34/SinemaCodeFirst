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
    public partial class Hasilat : Form
    {
        public Hasilat()
        {
            InitializeComponent();
        }
        ServerContext db = new ServerContext();
        private void Hasilat_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Avms.ToList();
            dataGridView1.Columns[5].Visible = false;
        }
        
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int topla = 0;
            string deger = dataGridView1.CurrentRow.Cells["AvmID"].Value.ToString();
           

            List<AvmHasilat> liste = new List<AvmHasilat>();
            liste= db.AvmHasilats.Where(x => x.AvmID == deger).ToList();

            foreach (AvmHasilat item in liste)
            {
                topla=topla+Convert.ToInt32(item.Bakiye);
            }

            label2.Text = topla.ToString();

        }
    }
}
