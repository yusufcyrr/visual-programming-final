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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection(@"server=localhost;userid=root;password=root;database=dblogin");


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from  tblaccount where Username=@Usernamee AND Password=@Passwordd";
                MySqlParameter prm1 = new MySqlParameter("Usernamee", textBox1.Text.Trim());
                MySqlParameter prm2 = new MySqlParameter("Passwordd", textBox2.Text.Trim());
                MySqlCommand komut = new MySqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(komut);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    AnaSayfa anaSayfa = new AnaSayfa();
                    this.Hide();
                    anaSayfa.ShowDialog();
                    this.Close();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş");
            }


        }
    }
}
