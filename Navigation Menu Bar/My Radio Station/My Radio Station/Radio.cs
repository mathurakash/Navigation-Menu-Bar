using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Radio_Station
{
    public partial class Radio : Form
    {
        public Radio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radioindia.net/radio/radio-city/icecast.audio";
            label1.Text = "Radio City 91.1 FM";
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radioindia.net/radio/mirchi98/icecast.audio";
            label1.Text = "Radio Mirchi 98.3 FM";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radioindia.net/radio/sc-bb/icecast.audio";
            label1.Text = "BIG 92.7 FM";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://air.pc.cdn.bitgravity.com/air/live/pbaudio004/playlist.m3u8";
            label1.Text = "Air Rainbow 102.6 FM";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://air.pc.cdn.bitgravity.com/air/live/pbaudio005/playlist.m3u8";
            label1.Text = "Air FM Gold";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://lmil.pc.cdn.bitgravity.com/lmil/live/aajtak_150k/chunklist_ao.m3u8";
            label1.Text = "Aaj Tak Radio";
        }

        

    }
}
