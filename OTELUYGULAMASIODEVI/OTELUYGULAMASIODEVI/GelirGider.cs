using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OTELUYGULAMASIODEVI
{
    public partial class GelirGider : Form
    {
        public GelirGider()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection(@"server=localhost;userid=root;password=root;database=dblogin");
        private void button1_Click(object sender, EventArgs e)
        {
            int personel;
            if (textBox1.Text=="")
            {
                MessageBox.Show("Boş Alan Bırakmayınız");
            }
            else
            {
                personel = Convert.ToInt16(textBox1.Text);
                lblPersonelM.Text = (personel * 5500).ToString();
            }
            int sonuc;
            sonuc = Convert.ToInt32(lblKasaT.Text) - (Convert.ToInt32(lblPersonelM.Text) + Convert.ToInt32(lblAlinanUrunlerCerez.Text) + Convert.ToInt32(lblAlinanUrunlerGida.Text) + Convert.ToInt32(lblAlinanUrunlerİcecek.Text) + Convert.ToInt32(lblFaturalarE.Text) + Convert.ToInt32(lblFaturalarS.Text) + Convert.ToInt32(lblFaturalarİ.Text));
            lblSonuc.Text = sonuc.ToString();
        }

        private void GelirGider_Load(object sender, EventArgs e)
        {
            //kasadaki toplam tutar
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("Select sum(ucret) as toplam from musteri", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasaT.Text = oku["toplam"].ToString();

                
            }
            baglanti.Close();
            
            //Gıdalar
            baglanti.Open();
            MySqlCommand komut2 = new MySqlCommand("Select sum(Gıda) as toplam1 from alinanurunler", baglanti);
            MySqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblAlinanUrunlerGida.Text = oku2["toplam1"].ToString();


            }
            baglanti.Close();

            //içecek
            baglanti.Open();
            MySqlCommand komut3 = new MySqlCommand("Select sum(İcecek) as toplam2 from alinanurunler", baglanti);
            MySqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblAlinanUrunlerİcecek.Text = oku3["toplam2"].ToString();


            }
            baglanti.Close();
            //Gıdalar
            baglanti.Open();
            MySqlCommand komut4 = new MySqlCommand("Select sum(Cerezler) as toplam3 from alinanurunler", baglanti);
            MySqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblAlinanUrunlerCerez.Text = oku4["toplam3"].ToString();


            }
            baglanti.Close();
            //Gıdalar
            baglanti.Open();
            MySqlCommand komut5 = new MySqlCommand("Select sum(Elektrik) as toplam5 from faturalar", baglanti);
            MySqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblFaturalarE.Text = oku5["toplam5"].ToString();


            }
            baglanti.Close();
            //Gıdalar
            baglanti.Open();
            MySqlCommand komut6 = new MySqlCommand("Select sum(Su) as toplam6 from faturalar", baglanti);
            MySqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblFaturalarS.Text = oku6["toplam6"].ToString();


            }
            baglanti.Close();
            //Gıdalar
            baglanti.Open();
            MySqlCommand komut7 = new MySqlCommand("Select sum(İnternet) as toplam7 from faturalar", baglanti);
            MySqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblFaturalarİ.Text = oku7["toplam7"].ToString();


            }





        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void C(object sender, EventArgs e)
        {

        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa ansyf = new AnaSayfa();
            this.Hide();
            ansyf.ShowDialog();
            this.Close();
        }
    }
}
