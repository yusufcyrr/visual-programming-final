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
    public partial class Musteriler : Form
    {
       

        public Musteriler()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection(@"server=localhost;userid=root;password=root;database=dblogin");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from musteri", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["tcno"].ToString();
                ekle.SubItems.Add(oku["adi"].ToString());
                ekle.SubItems.Add(oku["soyadi"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["email"].ToString());
                ekle.SubItems.Add(oku["odano"].ToString());
                ekle.SubItems.Add(oku["ucret"].ToString());
                ekle.SubItems.Add(oku["girisT"].ToString());
                ekle.SubItems.Add(oku["cikisT"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }
         int odano = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            odano = int.Parse(listView1.SelectedItems[0].SubItems[6].Text);
            textTcNo.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            maskedTextBoxNumara.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBoxMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBoxOdaNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBoxUcret.Text = listView1.SelectedItems[0].SubItems[7].Text;
            dateTimePickerG.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dateTimePickerC.Text = listView1.SelectedItems[0].SubItems[9].Text;

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if(textBoxOdaNo.Text=="501")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda501", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (textBoxOdaNo.Text == "502")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda502", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (textBoxOdaNo.Text == "503")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda503", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (textBoxOdaNo.Text == "504")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda504", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (textBoxOdaNo.Text == "505")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda505", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (textBoxOdaNo.Text == "506")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda506", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (textBoxOdaNo.Text == "507")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda507", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (textBoxOdaNo.Text == "508")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda508", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (textBoxOdaNo.Text == "509")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from oda509", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textTcNo.Clear();
            textAd.Clear();
            textSoyad.Clear();
            comboBox1.Text = ("");
            maskedTextBoxNumara.Clear();
            textBoxMail.Clear();
            textBoxOdaNo.Clear();
            textBoxUcret.Clear();
            dateTimePickerG.Text = ("");
            dateTimePickerC.Text = ("");
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand command = new MySqlCommand("update musteri set tcno = @tcno, adi = @adi, soyadi = @soyadi, cinsiyet = @cinsiyet, telefon = @telefon, email = @email, odano = @odano, ucret = @ucret, girisT = @girisT, cikisT = @cikisT where tcno = @id", baglanti);
            command.Parameters.AddWithValue("@tcno", textTcNo.Text);
            command.Parameters.AddWithValue("@adi", textAd.Text);
            command.Parameters.AddWithValue("@soyadi", textSoyad.Text);
            command.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
            command.Parameters.AddWithValue("@telefon", maskedTextBoxNumara.Text);
            command.Parameters.AddWithValue("@email", textBoxMail.Text);
            command.Parameters.AddWithValue("@odano", textBoxOdaNo.Text);
            command.Parameters.AddWithValue("@ucret", textBoxUcret.Text);
            command.Parameters.AddWithValue("@girisT", dateTimePickerG.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@cikisT", dateTimePickerC.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@id", textTcNo.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }   

        private void buttonAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSyfa = new AnaSayfa();
            this.Hide();
            anaSyfa.ShowDialog();
            this.Close();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from musteri Where adi like'%" + textBox1.Text + "%'", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["tcno"].ToString();
                ekle.SubItems.Add(oku["adi"].ToString());
                ekle.SubItems.Add(oku["soyadi"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["email"].ToString());
                ekle.SubItems.Add(oku["odano"].ToString());
                ekle.SubItems.Add(oku["ucret"].ToString());
                ekle.SubItems.Add(oku["girisT"].ToString());
                ekle.SubItems.Add(oku["cikisT"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
    }
}
