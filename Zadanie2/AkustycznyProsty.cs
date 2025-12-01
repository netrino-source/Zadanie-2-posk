using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace Zadanie2
{
    public partial class AkustycznyProsty : Form

    {
        private Stopwatch stoper = new Stopwatch();
        private Random rng = new Random();
        private bool czekamNaReakcje = false;

        private int totalTrials = 10;
        private int currentTrial = 0;
        public AkustycznyProsty()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private async void btnstart_Click(object sender, EventArgs e)
        {


            btnstart.Enabled = false;
            lbltext.Text = "Przygotuj się...";

            await Task.Delay(1000); 

            currentTrial = 0;
            NextTrial();
        }
        private async void NextTrial()
        {
            currentTrial++;

            if (currentTrial > totalTrials)
            {
                lbltext.Text = "Koniec testu!";
                btnstart.Enabled = true;
                return;
            }

            lbltext.Text = $"Próba {currentTrial}/{totalTrials}. Czekaj...";

            // losowy czas 2–5 sekund
            await Task.Delay(rng.Next(2000, 5000));

            // sygnał dźwiękowy
            SystemSounds.Beep.Play();

            lbltext.Text = "REAKCJA! Naciśnij SPACJĘ!";
            czekamNaReakcje = true;
            stoper.Restart();
        }
        private void AkustycznyProsty_KeyDown(object sender, KeyEventArgs e)
        {
            if (!czekamNaReakcje) return;
            if (e.KeyCode != Keys.Space) return;

            stoper.Stop();
            czekamNaReakcje = false;

            double czas = stoper.Elapsed.TotalMilliseconds;
            lbltext.Text = $"Czas: {czas:F0} ms";

            // następna próba po sekundzie
            Task.Delay(1000).ContinueWith(_ =>
            {
                this.Invoke(new Action(NextTrial));
            });


        }
    }
}