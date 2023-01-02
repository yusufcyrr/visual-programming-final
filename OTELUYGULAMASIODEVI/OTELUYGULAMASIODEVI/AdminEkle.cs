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
    public partial class AdminEkle : Form
    {
        public AdminEkle()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection(@"server=localhost;userid=root;password=root;database=dblogin");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into tblaccount(Username,Password) values('"+textBox1.Text+"','"+textBox2.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni Yönetici Eklendi");
        }

        private void buttonAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSyfa = new AnaSayfa();
            this.Hide();
            anaSyfa.ShowDialog();
            this.Close();
        }
    }
    
}

