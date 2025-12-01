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

namespace Zadanie2
{
    public partial class Optycznyprosty : Form

    {
        private Stopwatch stoper = new Stopwatch();
        private Random rng = new Random();
        private bool czekamNaReakcje = false;
        private int totalTrials = 10; 
        private int currentTrial = 0;
        public Optycznyprosty()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.BackColor = Color.LightGray;
        }

        private void lbltext_KeyDown(object sender, KeyEventArgs e)
        {
            if (!czekamNaReakcje) return; if (e.KeyCode != Keys.Space) return;
            stoper.Stop(); czekamNaReakcje = false; double czas = stoper.Elapsed.TotalMilliseconds;
            lblinfotext.Text = $"Czas: {czas:F0} ms"; 
            this.BackColor = Color.LightGray; 
            Task.Delay(1000).ContinueWith(_ => { this.Invoke(new Action(NextTrial)); });
        }

        private  async void btnstart_Click(object sender, EventArgs e)
        {
            btnstart.Enabled = false; 
            lblinfotext.Text = "Przygotuj się..."; 
            await Task.Delay(1000); currentTrial = 0;
            NextTrial();
        }
        private async void NextTrial() { 
            currentTrial++;
            if (currentTrial > totalTrials) { 
                lblinfotext.Text = "Koniec testu!";
                btnstart.Enabled = true; 
                this.BackColor = Color.LightGray;
                return;
            }
            lblinfotext.Text = $"Próba {currentTrial}/{totalTrials}. Czekaj..."; 
            this.BackColor = Color.LightGray; 
            await Task.Delay(rng.Next(2000, 5000));
            this.BackColor = Color.LimeGreen;
            lblinfotext.Text = "REAKCJA! Naciśnij SPACJĘ!";
            czekamNaReakcje = true; stoper.Restart(); }
    }
}
