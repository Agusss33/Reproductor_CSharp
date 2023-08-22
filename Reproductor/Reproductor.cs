using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Reproductor
{
    public partial class Reproductor : Form
    {
        public Reproductor()
        {
            InitializeComponent();
        }

        private void Reproductor_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void openSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Filter = "MP3|*.mp3|FLAC|*.flac|WAV|*.wav";
            dialog.Title = "Selecciona una cancion";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string title = dialog.SafeFileName;
                MusicName.Text = title.Trim();
                timer1.Start();
                AbrirMusic(dialog.FileName);
            }
        }

        private void AbrirMusic(string ruta)
        {
            try
            {
                MediaPlayer.URL = @"" + ruta;
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.play();
        }
        private void Volume_ValueChanged(object sender, decimal value)
        {
            MediaPlayer.settings.volume = Volume.Value;
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.stop();
        }

        private void NextSong_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.next();
        }

        private void Progress_ValueChanged(object sender, decimal value)
        {
            //terminar la progress con el timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = MediaPlayer.Ctlcontrols.currentPositionString;
            Progress.Value = (int)MediaPlayer.Ctlcontrols.currentPosition;
        }
    }
}
