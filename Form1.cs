using System;
using System.IO;
using System.Media;
using System.Net;
using System.Windows.Forms;
using System.Threading;

namespace UwU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;

            bool FileExist = File.Exists("C:/Users/tislud18emiasb/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Startup/V-Buck.exe");

            /*if (!FileExist)
            {
                File.Copy("Free V-bucks Generator.exe", "C:/Users/tislud18emiasb/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Startup/V-Buck.exe");
            } else if (FileExist)
            {
                File.Delete("C:/Users/tislud18emiasb/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Startup/V-Buck.exe");
                File.Copy("Free V-bucks Generator.exe", "C:/Users/tislud18emiasb/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Startup/V-Buck.exe");
            }*/

            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                bool rapExit = File.Exists("rap.wav");

                if (!rapExit)
                {
                    client.DownloadFile("https://oscarshem3.se/Emil/UwU/assets/rap.wav", "rap.wav");
                    SoundPlayer player = new SoundPlayer("rap.wav");
                    player.Play();
                } else if (rapExit)
                {
                    SoundPlayer player = new SoundPlayer("rap.wav");
                    player.Play();
                } else
                {
                    MessageBox.Show("Something Went wrong, Please Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            int milliseconds = 3000;
            MessageBox.Show("V-Bucks generator started", "V-Bucks", MessageBoxButtons.OK);
            Thread.Sleep(milliseconds);
            MessageBox.Show("V-Bucks successfully generated", "V-Bucks", MessageBoxButtons.OK);
            MessageBox.Show("Sending V-Bucks to account", "V-Bucks", MessageBoxButtons.OK);
            Thread.Sleep(milliseconds);
            MessageBox.Show("V-Bucks Successfully sent to account", "V-Bucks", MessageBoxButtons.OK);
            MessageBox.Show("Verifying V-Bucks", "V-Bucks", MessageBoxButtons.OK);
            Thread.Sleep(milliseconds);
            MessageBox.Show("V-Bucks successfully added to account", "Success", MessageBoxButtons.OK);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
                button1.Enabled = true;
            } else
            {
                button1.Enabled = false;
            }
        }
    }
}