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
    /// Interaction logic for IstorijaPregleda.xaml
    /// </summary>
    public partial class IstorijaPregleda : Window
    {

        public List<Doktor> doktori { get; set; }
        public List<Pacijent> pacijenti { get; set; }

        public List<Appointment> pregledi { get; set; }

        public List<Lekovi> lekovi { get; set; }

        public List<Alergeni> alergeni { get; set; }


        public IstorijaPregleda()
        {
            InitializeComponent();
            this.DataContext = this;

            ///Liste
            doktori = new List<Doktor>();
            pacijenti = new List<Pacijent>();
            pregledi = new List<Appointment>();
            lekovi = new List<Lekovi>();
            alergeni = new List<Alergeni>();

            Pacijent pacijent1 = new Pacijent()
            {
                Prezime = "Pavlović",
                Ime = "Dragiša",
                Broj_Telefona = "555-333",
                Mail_Adresa = "dragisa@gmail.com"
            };
            pacijenti.Add(pacijent1);

            ///Manipulacija sa doktorima
            Doktor doktor1 = new Doktor()
            {
                Ime = "Dr " + "Miloš",
                Prezime = "Ćojder",
                Specijalizacija = "Anesteziologija"
            };

            Doktor doktor2 = new Doktor()
            {
                Ime = "Dr " + "Gregory",
                Prezime = "House",
                Specijalizacija = "Dijagnostika"
            };

            doktori.Add(doktor1);
            doktori.Add(doktor2);

            ///Manipulacija nad pregledima
            Appointment pregled1 = new Appointment()
            {
                TipPregleda = TipPregleda.Kontrolni_Pregled
            };

            pregledi.Add(pregled1);

            Lekovi lek1 = new Lekovi()
            {
                Sifra_Leka = "#11yy",
                Naziv_Leka = "Rivotril",
                Doza = "2 mg",
                Upotreba = "2x1 na dan"
            };

            Lekovi lek2 = new Lekovi()
            {
                Sifra_Leka = "#22xx",
                Naziv_Leka = "Trodon",
                Doza = "50 mg",
                Upotreba = "3x1 na dan"
            };

            lekovi.Add(lek2);
            lekovi.Add(lek1);

            ///Manipulacija nad alergenima
            Alergeni alergen1 = new Alergeni()
            {
                Nutritivni_Alergeni = "orašasti plodovi ",
                Inhalatorni_Alergeni = "NEMA",
                Alergije_Na_Lekove = "METOTREKSAT"
            };
            alergeni.Add(alergen1);
        }

        private void Lekovi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Nazad_Na_Karton_Click(object sender, RoutedEventArgs e)
        {
            ZdravstveniKarton zk = new ZdravstveniKarton();
            this.Close();
            zk.Show();
        }

      
    }

}
