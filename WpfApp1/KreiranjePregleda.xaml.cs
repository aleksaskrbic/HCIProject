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
using WpfApp1.MODEL;
using WpfApp1.Tabs;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for KreiranjePregleda.xaml
    /// </summary>
    public partial class KreiranjePregleda : Window
    {
        public List<Appointment> appointments { get; set; }
        public List<Pacijent> patients { get; set; }

        public string jmbg { get; set; }

        public string ime { get; set; }
        public KreiranjePregleda()
        {
            InitializeComponent();
            this.DataContext = this;

            appointments = new List<Appointment>();
            patients = new List<Pacijent>();

            Appointment appointment1 = new Appointment()
            {
                Vreme_Pregleda = "07:00",
                Zavrsetak_Pregleda = "08:30"

            };

            Appointment appointment2 = new Appointment()
            {
                Vreme_Pregleda = "09:00",
                Zavrsetak_Pregleda = "09:45"
            };

            Appointment appointment3 = new Appointment()
            {
                Vreme_Pregleda = "12:00",
                Zavrsetak_Pregleda = "13:45"
            };

            appointments.Add(appointment1);
            appointments.Add(appointment2);
            appointments.Add(appointment3);

            Pacijent pacijent1 = new Pacijent()
            {
                Ime = "Milomir",
                Prezime = "Vranić",
                Broj_Telefona = "064-559-87",
                JMBG = "1234567779988",
                TipNaloga = TipNaloga.Redovan_Nalog
            };

            Pacijent pacijent2 = new Pacijent()
            {
                Ime = "Marko",
                Prezime = "Marković",
                Broj_Telefona = "061-522-887",
                JMBG = "4455668991126",
                TipNaloga = TipNaloga.Redovan_Nalog
            };

            Pacijent pacijent3 = new Pacijent()
            {
                Ime = "Stefan",
                Prezime = "Vukotić",
                Broj_Telefona = "021-887",
                JMBG = "7895654412371",
                TipNaloga = TipNaloga.Redovan_Nalog


            };

            Pacijent pacijent4 = new Pacijent()
            {
                Ime = "Merima",
                Prezime = "Milojević",
                Broj_Telefona = "456-743",
                JMBG = "5553336677443",
                TipNaloga = TipNaloga.Redovan_Nalog


            };

            Pacijent pacijent5 = new Pacijent()
            {
                Ime = "Dragorad",
                Prezime = "Malešević",
                Broj_Telefona = "064-877-255",
                JMBG = "1122335566999",
                TipNaloga = TipNaloga.Redovan_Nalog


            };

            Pacijent pacijent6 = new Pacijent()
            {
                Ime = "Eric",
                Prezime = "Garsia",
                Broj_Telefona = "057-444-99",
                JMBG = "4567983126776",
                TipNaloga = TipNaloga.Guest_Nalog


            };

            Pacijent pacijent7 = new Pacijent()
            {
                Ime = "Maksimus",
                Prezime = "Valagus",
                Broj_Telefona = "037-55-99",
                JMBG = "7832154622996",
                TipNaloga = TipNaloga.Guest_Nalog


            };

            patients.Add(pacijent1);
            patients.Add(pacijent2);
            patients.Add(pacijent3);
            patients.Add(pacijent4);
            patients.Add(pacijent5);
            patients.Add(pacijent6);
            patients.Add(pacijent7);

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Nemamo_Nalog_Click(object sender, RoutedEventArgs e)
        {
            Tabs.KreiranjeNaloga kn = new KreiranjeNaloga();
            kn.Show();

        }

        private void Kreiraj_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void Demo_Click(object sender, RoutedEventArgs e)
        {

            Brush colour = DEMO.Background;
            await Task.Delay(1000);
            Ime_TextBox.Text = "Stefan";
            await Task.Delay(2000);
            Ime_TextBox.Text = "";
            await Task.Delay(2000);
            JMBG_TextBox.Text = "4687918855123";
            await Task.Delay(2000);
            JMBG_TextBox.Text = "";
            await Task.Delay(200);
          
          
            await Task.Delay(200);
            
            //Kreiramo Nalog
            NemamoNalog.Background = Brushes.Transparent;
            await Task.Delay(200);
            NemamoNalog.Background = Brushes.White;
            await Task.Delay(200);
            NemamoNalog.Background = colour;
            await Task.Delay(200);
            NemamoNalog.Background = Brushes.Transparent;
            await Task.Delay(200);
            NemamoNalog.Background = Brushes.White;
            await Task.Delay(200);
            NemamoNalog.Background = colour;
            await Task.Delay(200);
           
            var s = new KreiranjeNaloga();
            s.Show();
            await Task.Delay(2000);
            
            
            s.Profile_FirstName.Text = "Stefan";
            await Task.Delay(1000);
            s.Profile_LastName.Text = "Vukotić";
            await Task.Delay(1000);
            s.Profile_DateOfBirth.Text = "05-05-1987";
            await Task.Delay(1000);


            s.JMBG.Text = "4687918855123";
            await Task.Delay(1000);
            s.Grad.Text = "Novi Sad";
            await Task.Delay(1000);
            s.Ulica.Text = "Olge Petrov 23";
            await Task.Delay(1000);
            s.Mail_Adresa.Text = "stefav@gmail.com";
            await Task.Delay(1000);
            s.Kontakt.Text = "021-978-654";
            await Task.Delay(1000);
            s.Password.Text = "stefanovic";
            await Task.Delay(1000);

            s.Kreiramo_Redovan_Nalog.Background = Brushes.Transparent;
            await Task.Delay(200);
            s.Kreiramo_Redovan_Nalog.Background = Brushes.White;
            await Task.Delay(200);
            s.Kreiramo_Redovan_Nalog.Background = colour;
            await Task.Delay(200);


            s.Close();
            await Task.Delay(2000);


            //Izbor Doktora i Tipova Pregleda
            Doktori_Box.SelectedIndex = 2;
            await Task.Delay(2000);
            Pregledi_Box.SelectedIndex = 3;
            await Task.Delay(2000);
            Pacijenti.SelectedIndex = 2;
            await Task.Delay(2000);

           // TipNaloga_Box.SelectedIndex = 1;
            //await Task.Delay(2000);

            OD_TextBox.Text = "14:00";
            await Task.Delay(2000);
            DO_TextBox.Text = "14:45";
            await Task.Delay(2000);

          

            //Kreiramo Pregled
            Kreiraj.Background = Brushes.Transparent;
            await Task.Delay(1000);
            Kreiraj.Background = Brushes.White;
            await Task.Delay(1000);
            Kreiraj.Background = colour;
            await Task.Delay(1000);
            this.Close();






           

        }

    

        private void Pacijenti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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

        private void Termini_Click(object sender, RoutedEventArgs e)
        {
            Termini t = new Termini();
            this.Close();
            t.Show();
        }



    }
}
