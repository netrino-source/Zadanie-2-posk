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
    public partial class AkustycznyZlozony : Form
    {
     private Stopwatch stoper = new Stopwatch();
        private Random rng = new Random();

        private int trainingTrials = 3;   // faza szkoleniowa
        private int testTrials = 12;      // faza właściwa

        private int currentTrial = 0;
        private bool trainingMode = true;
        private bool oczekuje = false;

        private Keys correctKey;       // jaki klawisz jest prawidłowy

        public AkustycznyZlozony()
        {
            InitializeComponent();
            this.KeyPreview = true;             // żeby formularz widział klawisze
this.BackColor = Color.LightGray;
 panelInstrukcja.Visible = true;
            panelTest.Visible = false;
            panelKoniec.Visible = false;

            lblInstrukcja.Text =
                "TEST AKUSTYCZNY ZŁOŻONY\n\n" +
                "Po losowym czasie usłyszysz ton:\n" +
                "  • Wysoki → naciśnij A\n" +
                "  • Niski  → naciśnij L\n" +
                "  • Brak tonu → NIE reaguj\n\n" +
                "Najpierw wykonasz 3 próby szkoleniowe,\n" +
                "a następnie 12 prób testu właściwego.\n\n" +
                "Kliknij START, aby rozpocząć szkolenie.";
        }
            private async void btnStartSzkolenie_Click(object sender, EventArgs e)
        {
            panelInstrukcja.Visible = false;
            panelTest.Visible = true;

            trainingMode = true;
            currentTrial = 0;

            lblInfo.Text = "Przygotuj się...";
            await Task.Delay(1000);

            NextTrial();
        }


        // --------------------------------------------------------------------
        //  KOLEJNA PRÓBA
        // --------------------------------------------------------------------
        private async void NextTrial()
        {
            currentTrial++;

            // Koniec szkolenia
            if (trainingMode && currentTrial > trainingTrials)
            {
                trainingMode = false;
                currentTrial = 0;

                lblInfo.Text = "Koniec szkolenia. Trwa przygotowanie...";
                await Task.Delay(2000);

                NextTrial();
                return;
            }

            // Koniec testu
            if (!trainingMode && currentTrial > testTrials)
            {
                ShowEndMessage();
                return;
            }

            lblInfo.Text = trainingMode
                ? $"Szkolenie – próba {currentTrial}/{trainingTrials}. Czekaj..."
                : $"Test – próba {currentTrial}/{testTrials}. Czekaj...";

            await Task.Delay(rng.Next(2000, 5000));

            // Losowanie bodźca
            int los = rng.Next(3); // 0 = wysoki, 1 = niski, 2 = brak

            if (los == 0)
            {
                Console.Beep(1200, 300);
                correctKey = Keys.A;
                lblInfo.Text = "Wysoki ton → A";
            }
            else if (los == 1)
            {
                Console.Beep(400, 300);
                correctKey = Keys.L;
                lblInfo.Text = "Niski ton → L";
            }
            else
            {
                correctKey = Keys.None;
                lblInfo.Text = "Brak tonu → NIE reaguj!";
            }

            oczekuje = true;
            stoper.Restart();
        }


        // --------------------------------------------------------------------
        //  OBSŁUGA REAKCJI
        // --------------------------------------------------------------------
        private void AkustycznyZlozony_KeyDown(object sender, KeyEventArgs e)
        {
            if (!oczekuje) return;

            oczekuje = false;
            stoper.Stop();

            // Przypadek NO-GO (nie reagować)
            if (correctKey == Keys.None)
            {
                lblInfo.Text = e.KeyCode == Keys.A || e.KeyCode == Keys.L
                    ? "BŁĄD: nie powinieneś reagować!"
                    : "OK (brak reakcji)";

                Task.Delay(1000).ContinueWith(_ =>
                    this.Invoke(new Action(NextTrial)));
                return;
            }

            // Poprawny
            if (e.KeyCode == correctKey)
            {
                lblInfo.Text = $"Dobrze!";
            }
            else
            {
                lblInfo.Text = "Zły klawisz!";
            }

            Task.Delay(1000).ContinueWith(_ =>
                this.Invoke(new Action(NextTrial)));
        }


        // --------------------------------------------------------------------
        //  KONIEC TESTU (bez wyników)
        // --------------------------------------------------------------------
        private void ShowEndMessage()
        {
            panelTest.Visible = false;
            panelKoniec.Visible = true;

            lblKoniec.Text =
                "Test zakończony.\n" +
                "Dziękujemy za udział.";
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


