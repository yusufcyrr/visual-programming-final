﻿using System;
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
            AnaSayfa ansyf = new AnaSayfa();
            this.Hide();
            ansyf.ShowDialog();
            this.Close();

            
        }
    }
}
