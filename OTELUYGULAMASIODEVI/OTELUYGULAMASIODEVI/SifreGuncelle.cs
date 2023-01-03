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
    public partial class SifreGuncelle : Form
    {
        public SifreGuncelle()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection(@"server=localhost;userid=root;password=root;database=dblogin");

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("update tblaccount set Username='" + textBox1.Text + "',Password='" + textBox2.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}
