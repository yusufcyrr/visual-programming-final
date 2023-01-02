using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTELUYGULAMASIODEVI
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusterEkle musek = new MusterEkle();
            this.Hide();
            musek.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Odalar odlr = new Odalar();
            this.Hide();
            odlr.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Musteriler mstrlr = new Musteriler();
            this.Hide();
            mstrlr.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminEkle admnEkle = new AdminEkle();
            this.Hide(); 
            admnEkle.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GelirGider glrgider = new GelirGider();
            this.Hide();
            glrgider.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Stoklar stklr = new Stoklar();
            this.Hide();
            stklr.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SifreGuncelle sfrgnclle = new SifreGuncelle();
            this.Hide();
            sfrgnclle.ShowDialog();
            this.Close();
        }
    }
}
