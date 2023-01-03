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
    public partial class Stoklar : Form
    {
        public Stoklar()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection(@"server=localhost;userid=root;password=root;database=dblogin");

            private void veriler()
            {
            listView1.Items.Clear();
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select* from alinanurunler", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gıda"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();


            }
            private void veriler2()
            {
            
            
                listView2.Items.Clear();
                baglanti.Open();
                MySqlCommand komut2 = new MySqlCommand("select* from faturalar", baglanti);
                MySqlDataReader oku2  = komut2.ExecuteReader();
                while (oku2.Read())
            {
                ListViewItem ekle2 = new ListViewItem();
                ekle2.Text = oku2["Elektrik"].ToString();
                ekle2.SubItems.Add(oku2["Su"].ToString());
                ekle2.SubItems.Add(oku2["İnternet"].ToString());
                listView2.Items.Add(ekle2);
            }
            baglanti.Close();

        }
            

            private void Stoklar_Load(object sender, EventArgs e)
            {
                veriler();
                veriler2();
            }

            private void buttonkaydet2_Click(object sender, EventArgs e)
            {
            baglanti.Open();
            MySqlCommand komut2 = new MySqlCommand("insert into faturalar(Elektrik,Su,İnternet) values ('" + textBox3.Text + "','" + textBox2.Text + "','" + textBox1.Text + "')", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                veriler2();
            }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into alinanurunler(Gıda,İcecek,Cerezler) values('" + txtGıda.Text + "','" + txtIcecek.Text + "','" + txtAtistirma.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }

        private void txtAtistirma_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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

