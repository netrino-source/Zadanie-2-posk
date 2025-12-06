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
    public partial class OptycznyZlozony : Form
    {
     Stopwatch stoper = new Stopwatch();
 Random rng = new Random();
 bool oczekujeNaReakcje = false;

 int totalTrials = 12;      // liczba prób
 int currentTrial = 0;

 Color currentColor;        // jaki kolor jest teraz
 Keys correctKey;           // jaki klawisz jest prawidłowy

        public OptycznyZlozony()
        {
            InitializeComponent();
            this.KeyPreview = true;             // żeby formularz widział klawisze
this.BackColor = Color.LightGray;
        }
            private async void btnStart_Click(object sender, EventArgs e)
    {
        button1.Enabled = false;
        currentTrial = 0;
        labelinfo.Text = "Przygotuj się do testu…";

        await Task.Delay(1500);
        NextTrial();
    }

    private async void NextTrial()
    {
        currentTrial++;

        if (currentTrial > totalTrials)
        {
            // KONIEC TESTU – PODSUMOWANIE
            this.BackColor = Color.LightGray;
            

            button1.Enabled = true;
            return;
        }

        // EKRAN OCZEKIWANIA
        this.BackColor = Color.LightGray;
        labelinfo.Text = $"Próba {currentTrial}/{totalTrials}. Czekaj…";

        // losowy czas od 2 do 5 sekund
        int delay = rng.Next(2000, 5000);
        await Task.Delay(delay);

        // WYBIERAMY LOSOWY BODZIEC
        int los = rng.Next(3); // 0,1,2 → 3 kolory

        if (los == 0)
        {
            currentColor = Color.Green;
            correctKey = Keys.F;       // zielony → F
            labelinfo.Text = "Zielony → naciśnij F";
        }
        else if (los == 1)
        {
            currentColor = Color.Red;
            correctKey = Keys.J;       // czerwony → J
            labelinfo.Text = "Czerwony → naciśnij J";
        }
        else
        {
            currentColor = Color.Blue;
            correctKey = Keys.None;    // niebieski → NO-GO
            labelinfo.Text = "Niebieski → NIE reaguj!";
        }

        // WYŚWIETLAMY BODZIEC
        this.BackColor = currentColor;

        oczekujeNaReakcje = true;
        stoper.Restart();
    }

    private void OptycznyZlozony_KeyDown(object sender, KeyEventArgs e)
    {
        if (!oczekujeNaReakcje) return;

        // PRZYPADEK 1: bodziec NIEBIESKI → NO-GO
        if (correctKey == Keys.None)
        {
            // Użytkownik nacisnął cokolwiek → błąd
           
            labelinfo.Text = "BŁĄD: przy niebieskim nie wolno naciskać!";
            oczekujeNaReakcje = false;
            this.BackColor = Color.LightGray;

            Task.Delay(1500).ContinueWith(_ => this.Invoke(new Action(NextTrial)));
            return;
        }

        // PRZYPADEK 2: poprawny klawisz
        if (e.KeyCode == correctKey)
        {
            stoper.Stop();
            double t = stoper.Elapsed.TotalMilliseconds;
           

            labelinfo.Text = $"Dobry klawisz! Czas: {t:F0} ms";
        }
        else
        {
            // PRZYPADEK 3: zły klawisz
            
            labelinfo.Text = "ZŁY KLAWISZ!";
        }

        // przejście do następnej próby
        oczekujeNaReakcje = false;
        this.BackColor = Color.LightGray;
        Task.Delay(1200).ContinueWith(_ => this.Invoke(new Action(NextTrial)));
    }
}
    }


