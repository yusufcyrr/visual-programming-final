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
using MySql.Data;

namespace OTELUYGULAMASIODEVI
{
    public partial class MusterEkle : Form
    {
        public MusterEkle()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection(@"server=localhost;userid=root;password=root;database=dblogin");
        private void buttonOda501_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "501";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda501 (adi,soyadi) values ('"+textAd.Text +"','"+textSoyad.Text+"')",baglanti);  
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void buttonOda502_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "502";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda502 (adi,soyadi) values ('" + textAd.Text + "','" + textSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void buttonOda3_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "503";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda503 (adi,soyad) values ('" + textAd.Text + "','" + textSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void buttonOda504_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "504";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda504 (adi,soyadi) values ('" + textAd.Text + "','" + textSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void buttonOda505_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "505";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda505 (adi,soyadi) values ('" + textAd.Text + "','" + textSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void buttonOda506_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "506";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda506 (adi,soyadi) values ('" + textAd.Text + "','" + textSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void buttonOda507_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "507";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda507 (adi,soyadi) values ('" + textAd.Text + "','" + textSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void buttonOda508_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "508";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda508 (adi,soyadi) values ('" + textAd.Text + "','" + textSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void buttonOda509_Click(object sender, EventArgs e)
        {
            textBoxOdaNo.Text = "509";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into oda509 (adi,soyadi) values ('" + textAd.Text + "','" + textSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void dateTimePickerC_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(dateTimePickerG.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dateTimePickerC.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            label12.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label12.Text) * 500;
            textBoxUcret.Text = Ucret.ToString();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textTcNo.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(textAd.Text) || string.IsNullOrEmpty(textSoyad.Text) || string.IsNullOrEmpty(maskedTextBoxNumara.Text) || string.IsNullOrEmpty(textBoxMail.Text) || string.IsNullOrEmpty(textBoxOdaNo.Text) || string.IsNullOrEmpty(textBoxUcret.Text))
            {
                MessageBox.Show("Boş Alan Bırakmayın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into musteri(tcno,adi,soyadi,cinsiyet,telefon,email,odano,ucret,girisT,cikisT) values('" + textTcNo.Text + "','" + textAd.Text + "','" + textSoyad.Text + "','" + comboBox1.Text + "','" + maskedTextBoxNumara.Text + "','"+textBoxMail.Text+"','"+textBoxOdaNo.Text+"','"+textBoxUcret.Text+"','"+ dateTimePickerG.Value.ToString("yyyy-MM-dd")+"','" + dateTimePickerC.Value.ToString("yyyy-MM-dd")+ "')" , baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt başarılı");
            }
        }

        private void buttonAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSyfa = new AnaSayfa();
            this.Hide();
            anaSyfa.ShowDialog();
            this.Close();


        }

        private void MusterEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut1 = new MySqlCommand("select * from oda501", baglanti);
            MySqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                buttonOda501.Text = oku1["adi"].ToString() + " " + oku1["soyadi"].ToString();
            }
            baglanti.Close();
            if (buttonOda501.Text != "501")
            {
                buttonOda501.BackColor = Color.Red;
                buttonOda501.Enabled=false;
            }

            baglanti.Open();
            MySqlCommand komut2 = new MySqlCommand("select * from oda502", baglanti);
            MySqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                buttonOda502.Text = oku2["adi"].ToString() + " " + oku2["soyadi"].ToString();
            }
            baglanti.Close();
            if (buttonOda502.Text != "502")
            {
                buttonOda502.BackColor = Color.Red;
                buttonOda502.Enabled = false;
            }
            baglanti.Open();
            MySqlCommand komut3 = new MySqlCommand("select * from oda503", baglanti);
            MySqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                buttonOda3.Text = oku3["adi"].ToString() + " " + oku3["soyad"].ToString();
            }
            baglanti.Close();
            if (buttonOda3.Text != "503")
            {
                buttonOda3.BackColor = Color.Red;
                buttonOda3.Enabled = false;
            }
            baglanti.Open();
            MySqlCommand komut4 = new MySqlCommand("select * from oda504", baglanti);
            MySqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                buttonOda504.Text = oku4["adi"].ToString() + " " + oku4["soyadi"].ToString();
            }
            baglanti.Close();
            if (buttonOda504.Text != "504")
            {
                buttonOda504.BackColor = Color.Red;
                buttonOda504.Enabled = false;
            }
            baglanti.Open();
            MySqlCommand komut5 = new MySqlCommand("select * from oda505", baglanti);
            MySqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                buttonOda505.Text = oku5["adi"].ToString() + " " + oku5["soyadi"].ToString();
            }
            baglanti.Close();
            if (buttonOda505.Text != "505")
            {
                buttonOda505.BackColor = Color.Red;
                buttonOda505.Enabled = false;
            }
            baglanti.Open();
            MySqlCommand komut6 = new MySqlCommand("select * from oda506", baglanti);
            MySqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                buttonOda506.Text = oku6["adi"].ToString() + " " + oku6["soyadi"].ToString();
                
            }
            baglanti.Close();
            if (buttonOda506.Text != "506")
            {
                buttonOda506.BackColor = Color.Red;
                buttonOda506.Enabled = false;
            }
            baglanti.Open();
            MySqlCommand komut7 = new MySqlCommand("select * from oda507", baglanti);
            MySqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                buttonOda507.Text = oku7["adi"].ToString() + " " + oku7["soyadi"].ToString();
            }
            baglanti.Close();
            if (buttonOda507.Text != "507")
            {
                buttonOda507.BackColor = Color.Red;
                buttonOda507.Enabled = false;
            }
            baglanti.Open();
            MySqlCommand komut8 = new MySqlCommand("select * from oda508", baglanti);
            MySqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                buttonOda508.Text = oku8["adi"].ToString() + " " + oku8["soyadi"].ToString();
            }
            baglanti.Close();
            if (buttonOda508.Text != "508")
            {
                buttonOda508.BackColor = Color.Red;
                buttonOda508.Enabled = false;
            }
            baglanti.Open();
            MySqlCommand komut9 = new MySqlCommand("select * from oda509", baglanti);
            MySqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                buttonOda509.Text = oku9["adi"].ToString() + " " + oku9["soyadi"].ToString();
            }
            baglanti.Close();
            if (buttonOda509.Text != "509")
            {
                buttonOda509.BackColor = Color.Red;
                buttonOda509.Enabled = false;

            }
        }

        private void textTcNo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
