using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Televisor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Canal 2
            axWindowsMediaPlayer1.URL = "http://ss1.domint.net:2126/ta2_str/teleantillas/chunklist_w460875019.m3u8";
            label2.Text = "Canal 2: TeleAntillas";

        }

        

        private void bplay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int canal = 1;

        private void bUpcanal_Click(object sender, EventArgs e)
        {
            
            canal++;

            if (canal == 1)

            {
              
            }

            if (canal== 2)

            {
                //Canal 5
                axWindowsMediaPlayer1.URL = "http://stream.grupotelemicro.com/5.m3u8";
                label2.Text = "Canal 5: Telemicro";
            }

            if (canal == 3)

            {
                //Canal 7
                axWindowsMediaPlayer1.URL = "http://ss2.domint.net:2138/cvh_str/colorvisionhd/playlist.m3u8";
                label2.Text = "Canal 9: Color Visión";
            }

            if (canal == 4)

            {

                //Canal 10
                axWindowsMediaPlayer1.URL = "http://190.103.183.24:1935/live/MicroHD/chunklist_w1105794626.m3u8";
                label2.Text = "Canal 10: Microvisión";
            }

            if (canal == 5)

            {

                //Canal 11
                axWindowsMediaPlayer1.URL = "http://ss3.domint.net:2114/t11_str/telesistema/chunklist_w1744473215.m3u8";
                label2.Text = "Canal 11: Telesistema 11";
                
            }
        
            if (canal == 6)

            {
                //Canal 13
                axWindowsMediaPlayer1.URL = "http://stream.grupotelemicro.com/13.m3u8";
                label2.Text = "Canal 13: Telecentro";
                
            }

            if (canal == 7)

            {
                //Canal 15
                axWindowsMediaPlayer1.URL = "http://stream.grupotelemicro.com/15.m3u8";
                label2.Text = "Canal 15: Digital 15";
               
            }

            if (canal == 8)

            { 
                //Canal 29
                axWindowsMediaPlayer1.URL = "http://ss1.domint.net:2302/tu_str/universo/chunklist_w197342393.m3u8";
                label2.Text = "Canal 29: Teleuniverso";
              
            }

            if (canal == 9)

            {
                //Canal 59
                axWindowsMediaPlayer1.URL = "http://mangotv01.streamprolive.com/hls/live_med.m3u8";
                label2.Text = "Canal 59: Mango TV"; 
            }

            if (canal==10)
            {
                canal = 1;
                //Canal 2
                axWindowsMediaPlayer1.URL = "http://ss1.domint.net:2126/ta2_str/teleantillas/chunklist_w460875019.m3u8";
                label2.Text = "Canal 2: TeleAntillas";
            }

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void bDowncanal_Click(object sender, EventArgs e)
        {
            canal--;

            if (canal == 0)

            {
                //Canal 59
                axWindowsMediaPlayer1.URL = "http://mangotv01.streamprolive.com/hls/live_med.m3u8";
                label2.Text = "Canal 59: Mango TV";
                canal = 9;
            }

            if (canal == 8)
            {

                //Canal 29
                axWindowsMediaPlayer1.URL = "http://ss1.domint.net:2302/tu_str/universo/chunklist_w197342393.m3u8";
                label2.Text = "Canal 29: Teleuniverso";
            }

            if (canal == 7)

            {
                //Canal 15
                axWindowsMediaPlayer1.URL = "http://stream.grupotelemicro.com/15.m3u8";
                label2.Text = "Canal 15: Digital 15";

            }

            if (canal == 6)

            {
                //Canal 13
                axWindowsMediaPlayer1.URL = "http://stream.grupotelemicro.com/13.m3u8";
                label2.Text = "Canal 13: Telecentro";

            }

            if (canal == 5)

            {

                //Canal 11
                axWindowsMediaPlayer1.URL = "http://ss3.domint.net:2114/t11_str/telesistema/chunklist_w1744473215.m3u8";
                label2.Text = "Canal 11: Telesistema 11";

            }

            if (canal == 4)

            {

                //Canal 10
                axWindowsMediaPlayer1.URL = "http://190.103.183.24:1935/live/MicroHD/chunklist_w1105794626.m3u8";
                label2.Text = "Canal 10: Microvisión";
            }

            if (canal == 3)

            {
                //Canal 7
                axWindowsMediaPlayer1.URL = "http://ss2.domint.net:2138/cvh_str/colorvisionhd/playlist.m3u8";
                label2.Text = "Canal 9: Color Visión";
            }

            if (canal == 2)

            {
                //Canal 5
                axWindowsMediaPlayer1.URL = "http://stream.grupotelemicro.com/5.m3u8";
                label2.Text = "Canal 5: Telemicro";
            }

            if (canal == 1)

            {
                //Canal 2
                axWindowsMediaPlayer1.URL = "http://ss1.domint.net:2126/ta2_str/teleantillas/chunklist_w460875019.m3u8";
                label2.Text = "Canal 2: TeleAntillas";

            }

        }

        private void bUpV_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume++;
            if (axWindowsMediaPlayer1.settings.volume == 100)
            {
                MessageBox.Show("Ya ha alcanzado el límite. El volumen no puede subir más.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bDownV_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume--;
            if (axWindowsMediaPlayer1.settings.volume == 0)
            {
                MessageBox.Show("Ya ha alcanzado el límite. El volumen no puede bajar más.","Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            canalBox.Text = canalBox.Text + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            canalBox.Text = canalBox.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            canalBox.Text = canalBox.Text + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            canalBox.Text = canalBox.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            canalBox.Text = canalBox.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            canalBox.Text = canalBox.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            canalBox.Text = canalBox.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            canalBox.Text = canalBox.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            canalBox.Text = canalBox.Text + "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            canalBox.Text = canalBox.Text + "0";
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
           int Bcanal = int.Parse(canalBox.Text);


        }
    }
}
    