using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using WpfApp1.MODEL;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for FrmPdf.xaml
    /// </summary>
    public partial class FrmPdf : Window
    {

        public List<ZakazaniTermini> zakazani_termini { get; set; }

        public FrmPdf()
        {
            InitializeComponent();
            this.DataContext = this;

            zakazani_termini = new List<ZakazaniTermini>();

            ZakazaniTermini termin1 = new ZakazaniTermini()
            {
                Pacijent = "Gordan Remić",
                JMBG = "1234567891011",
                Broj = "064-789-6655",
                Lekar = "Miloš Ćojder",
                TipPregleda = Vrsta_Pregleda.Intervencija,
                Pocetak_Pregleda = new DateTime(2021, 12, 05, 07, 50, 00),
                Zavrsetak_Pregleda = new DateTime(2021, 12, 05, 08, 50, 00),
                Prostorija = "333 A"


            };

            ZakazaniTermini termin2 = new ZakazaniTermini()
            {
                Pacijent = "Marko Oršić",
                JMBG = "4455667788123",
                Broj = "063-557-894",
                Lekar = "Ljubodrag Minić",
                TipPregleda = Vrsta_Pregleda.Sistematski_Pregled,
                Pocetak_Pregleda = new DateTime(2021, 12, 05, 09, 50, 00),
                Zavrsetak_Pregleda = new DateTime(2021, 12, 05, 12, 30, 00),
                Prostorija = "101 A"


            };

            ZakazaniTermini termin3 = new ZakazaniTermini()
            {
                Pacijent = "Žarko Zrenjanin",
                JMBG = "2255167344980",
                Broj = "061-866-824",
                Lekar = "Petar Dinić",
                TipPregleda = Vrsta_Pregleda.Intervencija,
                Pocetak_Pregleda = new DateTime(2021, 12, 06, 11, 00, 00),
                Zavrsetak_Pregleda = new DateTime(2021, 12, 06, 14, 30, 00),
                Prostorija = "11"


            };

            zakazani_termini.Add(termin1);
            zakazani_termini.Add(termin2);
            zakazani_termini.Add(termin3);







        }


        private void btn_EmployeeReport_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(print, "bilosta");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }
    }
}
