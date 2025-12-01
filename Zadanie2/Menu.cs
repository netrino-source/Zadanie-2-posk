using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2
{


    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void comboBoxwybierztest_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Sprawdzenie, czy wybrano faktyczny test
            if (comboBoxwybierztest.SelectedIndex < 0)
            {
                // To jest pozycja początkowa lub pusta, nie rób nic
                return;
            }

            // 2. Pobranie wybranego tekstu
            string selectedTestName = comboBoxwybierztest.SelectedItem.ToString();

            Form formToOpen = null;

            // 3. Decyzja, który formularz otworzyć
            switch (selectedTestName)
            {
                case "Bodźce proste optyczne":
                    formToOpen = new Optycznyprosty();
                    break;

                case "Bodźce proste akustyczne":
                    formToOpen = new AkustycznyProsty();
                    break;

                case "Bodźce złożone optyczne":
                    formToOpen = new OptycznyZlozony();
                    break;

                case "Bodźce złożone akustyczne":
                    formToOpen = new AkustycznyZlozony();
                    break;
            }
            if (formToOpen != null)
            {

                formToOpen.ShowDialog();

            }
            private void button_wyjscie_Click(object sender, EventArgs e)
            {

            }
        }
    }
}
       

