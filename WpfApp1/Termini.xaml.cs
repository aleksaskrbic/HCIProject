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
using WpfApp1.Tabs;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Termini.xaml
    /// </summary>
    public partial class Termini : Window
    {

        public string jmbg { get; set; }
        public List<Pacijent> Pacijenti { get; set; }
        public List<Pacijent> patients { get; set; }

        public List<Appointment> doktori { get; set; }

        public List<ZakazaniTermini> zakazani_termini { get; set; }
        public Termini()
        {
            InitializeComponent();
            this.DataContext = this;

            patients = new List<Pacijent>();
            doktori = new List<Appointment>();
           
            zakazani_termini = new List<ZakazaniTermini>();

            Pacijent pacijent1 = new Pacijent()
            {
                Prezime = "Pavlović",
                Ime = "Dragiša",
                Broj_Telefona = "064/998/441",
                Mail_Adresa = "dragiša@gmail.com",
                Nadimak = "dragiša"

            };

            
            patients.Add(pacijent1);

            Appointment dr1 = new Appointment()
            {
                Doktor = "Dr Miloš Ćojder"
            };

            Appointment dr2 = new Appointment()
            {
                Doktor = "Dr Gregory House"
            };
            doktori.Add(dr1);
            doktori.Add(dr2);


            ///Manipulacije nad samim terminima
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


            ZakazaniTermini termin4 = new ZakazaniTermini()
            {
                Pacijent = "Dragorad Malešević",
                JMBG = "5566789554431",
                Broj = "061-422-324",
                Lekar = "Miloš Ćojder",
                TipPregleda = Vrsta_Pregleda.Sistematski_Pregled,
                Pocetak_Pregleda = new DateTime(2021, 12, 07, 11, 00, 00),
                Zavrsetak_Pregleda = new DateTime(2021, 12, 07, 12, 30, 00),
                Prostorija = "11"


            };


            ZakazaniTermini termin5 = new ZakazaniTermini()
            {
                Pacijent = "Rajko Malešević",
                JMBG = "9997778881236",
                Broj = "NEMA",
                Lekar = "House Gregory",
                TipPregleda = Vrsta_Pregleda.Rehabilitacija,
                Pocetak_Pregleda = new DateTime(2021, 12, 07, 08, 00, 00),
                Zavrsetak_Pregleda = new DateTime(2022, 01, 07, 08, 00, 00),
                Prostorija = "22R"


            };

            ZakazaniTermini termin6 = new ZakazaniTermini()
            {
                Pacijent = "Dragoljub Pavlović",
                JMBG = "7775555666458",
                Broj = "NEMA",
                Lekar = "House Gregory",
                TipPregleda = Vrsta_Pregleda.Operacija,
                Pocetak_Pregleda = new DateTime(2021, 12, 07, 08, 00, 00),
                Zavrsetak_Pregleda = new DateTime(2021, 12, 07, 10, 00, 00),
                Prostorija = "33O"


            };


            zakazani_termini.Add(termin1);
            zakazani_termini.Add(termin2);
            zakazani_termini.Add(termin3);
            zakazani_termini.Add(termin4);
            zakazani_termini.Add(termin5);
            zakazani_termini.Add(termin6);
            



        }

        private void Patient_Profile_Click(object sender, RoutedEventArgs e)
        {
            Patient_Pravi_Profile ppp = new Patient_Pravi_Profile();
            ppp.Show();
                

        }


        ///Pocetni meni
        ///

        private void Kreiranje_Pregleda_Click(object sender, RoutedEventArgs e)
        {
            KreiranjePregleda kp = new KreiranjePregleda();
            this.Close();

            kp.Show();
        }

        private void Kalendar_Click(object sender, RoutedEventArgs e)
        {
            KalendarMesec km = new KalendarMesec();
            this.Close();
            km.Show();
        }

        private void Pacijenti_Click(object sender, RoutedEventArgs e)
        {
            Pacijenti p = new Pacijenti();
            this.Close();
            p.Show();
        }

        private void Kreiranje_Naloga_Click(object sender, RoutedEventArgs e)
        {
            Tabs.KreiranjeNaloga kn = new KreiranjeNaloga();
            kn.Show();
        }

        private void Oglasna_Tabla_Click(object sender, RoutedEventArgs e)
        {
            OglasnaTabla ot = new OglasnaTabla();
            this.Close();
            ot.Show();
        }

        private void Izvestaji_Click(object sender, RoutedEventArgs e)
        {
            Generisi_Izvestaj gi = new Generisi_Izvestaj();
            gi.Show();
        }

        private void HOME_Click(object sender, RoutedEventArgs e)
        {
            NoviProfil np = new NoviProfil();
            this.Close();
            np.Show();
        }

        private void Dodaj_Termin_Click(object sender, RoutedEventArgs e)
        {
            KreiranjePregleda kp = new KreiranjePregleda();
            this.Close();

            kp.Show();
        }

        ///Sami Termini
        ///









    }
}
