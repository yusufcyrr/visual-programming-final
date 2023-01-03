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
    public partial class radyo : Form
    {
        public radyo()
        {
            InitializeComponent();
        }

        private void linkLabelKanal1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://shoutcast.radyogrup.com:1020/";
 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://shoutcast.radyogrup.com:1010/";
 

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://moondigitaledge.radyotvonline.net/show/playlist.m3u8"; 
        }
    }
}
