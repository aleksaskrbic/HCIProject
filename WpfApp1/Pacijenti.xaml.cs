using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Validation;
using WpfApp1.MODEL;
using WpfApp1.Tabs;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Pacijenti.xaml
    /// </summary>
    public partial class Pacijenti : Window
    {
        public string jmbg { get; set; }

        public string ime { get; set; }

        public List<Pacijent> patients { get; set; }
        public Pacijenti()
        {
            InitializeComponent();
            this.DataContext = this;



            ///Manipulacije sa pacijentima
            ///
            patients = new List<Pacijent>();

            ///Redovni nalozi
            ///
            Pacijent pacijent1 = new Pacijent()
            {
                Ime = "Milomir",
                Prezime = "Vranić",
                JMBG = "1234567779988",
                Datum_Rodjenja = new DateTime(1987,01,23,10,50,00),
                Ulica = "Stražilovska 27a",
                Grad = "Novi Sad",
                Broj_Telefona = "064-559-87",
                Mail_Adresa = "milomir@gmail.com",
                TipNaloga = TipNaloga.Redovan_Nalog
            };

            Pacijent pacijent2 = new Pacijent()
            {
                Ime = "Marko",
                Prezime = "Marković",
                JMBG = "4455668991126",
                Datum_Rodjenja = new DateTime(1999, 02, 12, 05, 50, 00),
                Ulica = "Kneza Miloša 21",
                Grad = "Beograd",
                Broj_Telefona = "061-522-887",
                Mail_Adresa = "marko@gmail.com",
                TipNaloga = TipNaloga.Redovan_Nalog
            };

            Pacijent pacijent3 = new Pacijent()
            {
                Ime = "Stefan",
                Prezime = "Vukotić",
                JMBG = "7895654412371",
                Datum_Rodjenja = new DateTime(1956, 11, 12, 03, 12, 00),
                Ulica = "Gogoljeva 13",
                Grad = "Novi Sad",
                Broj_Telefona = "021-887-778",
                Mail_Adresa = "stefanv@gmail.com",
                TipNaloga = TipNaloga.Redovan_Nalog


            };

            Pacijent pacijent4 = new Pacijent()
            {
                Ime = "Merima",
                Prezime = "Milojević",
                JMBG = "5553336677443",
                Datum_Rodjenja = new DateTime(1987, 01, 23, 10, 50, 00),
                Ulica = "Stražilovska 27a",
                Grad = "Novi Sad",
                Broj_Telefona = "021-456-743",
                Mail_Adresa = "merimam@gmail.com",
                TipNaloga = TipNaloga.Redovan_Nalog


            };

            Pacijent pacijent5 = new Pacijent()
            {
                Ime = "Dragorad",
                Prezime = "Malešević",
                JMBG = "1122335566999",
                Datum_Rodjenja = new DateTime(1998, 01, 14, 10, 45, 00),
                Ulica = "Tolstojeva",
                Grad = "Novi Sad",
                Broj_Telefona = "064-877-255",
                Mail_Adresa = "ddrakce@gmail.com",
                TipNaloga = TipNaloga.Redovan_Nalog


            };

            Pacijent pacijent6 = new Pacijent()
            {
                Ime = "Mile",
                Prezime = "Krstić",
                JMBG = "9875556767123",
                Datum_Rodjenja = new DateTime(1938, 10, 05, 03, 03, 00),
                Ulica = "Kralja Petra I 16",
                Grad = "Lajkovac",
                Broj_Telefona = "061-227-964",
                Mail_Adresa = "lajpruga@gmail.com",
                TipNaloga = TipNaloga.Redovan_Nalog


            };

            Pacijent pacijent7 = new Pacijent()
            {
                Ime = "Rada",
                Prezime = "Matić",
                JMBG = "1456789900123",
                Datum_Rodjenja = new DateTime(1978, 05, 05, 12, 40, 00),
                Ulica = "Svetosavska 14",
                Grad = "Novi Sad",
                Broj_Telefona = "061-227-964",
                Mail_Adresa = "rada@gmail.com",
                TipNaloga = TipNaloga.Redovan_Nalog


            };

            Pacijent pacijent8 = new Pacijent()
            {
                Ime = "Eric",
                Prezime = "Garsia",
                Broj_Telefona = "057-444-99",
                JMBG = "4567983126776",
                TipNaloga = TipNaloga.Guest_Nalog,
                
                Ulica = "UNKNOWN",
                Grad = "UNKNOWN",
                Mail_Adresa = "UNKNOWN"


            };

            Pacijent pacijent9 = new Pacijent()
            {
                Ime = "Maksimus",
                Prezime = "Valagus",
                Broj_Telefona = "037-55-99",
                JMBG = "7832154622996",
                TipNaloga = TipNaloga.Guest_Nalog,
               
                Ulica = "UNKNOWN",
                Grad = "UNKNOWN",
                Mail_Adresa = "UNKNOWN"


            };

            Pacijent pacijent10 = new Pacijent()
            {
                Ime = "Sofia",
                Prezime = "Loren",
                Broj_Telefona = "047-65-77",
                JMBG = "798524565635",
                TipNaloga = TipNaloga.Guest_Nalog,
               
                Ulica = "UNKNOWN",
                Grad = "UNKNOWN",
                Mail_Adresa = "UNKNOWN"


            };

            Pacijent pacijent11 = new Pacijent()
            {
                Ime = "Maria",
                Prezime = "Voren",
                Broj_Telefona = "245-879-66",
                JMBG = "15466389665566",
                TipNaloga = TipNaloga.Guest_Nalog,
              
                Ulica = "UNKNOWN",
                Grad = "UNKNOWN",
                Mail_Adresa = "UNKNOWN"


            };

            patients.Add(pacijent1);
            patients.Add(pacijent2);
            patients.Add(pacijent3);
            patients.Add(pacijent4);
            patients.Add(pacijent5);
            patients.Add(pacijent6);
            patients.Add(pacijent7);
            patients.Add(pacijent8);
            patients.Add(pacijent9);
            patients.Add(pacijent10);
            patients.Add(pacijent11);







        }

        private void JmbgValidate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        ///Za meni bar Klikovi
        ///


        private void Kreiranje_Pregleda_Click(object sender, RoutedEventArgs e)
        {
            KreiranjePregleda kp = new KreiranjePregleda();

            this.Close();

            kp.Show();
        }


        private void Home_Click(object sender, RoutedEventArgs e)
        {
            NoviProfil np = new NoviProfil();
            this.Close();
            np.Show();
        }

        private void Kalendar_Click(object sender, RoutedEventArgs e)
        {
            KalendarMesec km = new KalendarMesec();
            this.Close();
            km.Show();
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

        private void Kreiraj_Nalog_Click(object sender, RoutedEventArgs e)
        {
            KreiranjeNaloga kn = new KreiranjeNaloga();
            kn.Show();
        }

        private void Termini_Click(object sender, RoutedEventArgs e)
        {
            Termini t = new Termini();
            this.Close();
            t.Show();
        }
    }
}
