using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for OglasnaTabla.xaml
    /// </summary>
    public partial class OglasnaTabla : Window
    {
        private const bool V = true;
        private bool m_allowReorder;
        private object widgetCollectionList;

        public List<Obavestenja> obavestenja { get; set; }
        public OglasnaTabla()
        {
            InitializeComponent();
            this.DataContext = this;

            obavestenja = new List<Obavestenja>();


            Obavestenja obavestenje1 = new Obavestenja()
            {
                Naziv_Obavestenja = "Obaveštenje 1",
                Vrsta_Obavestenja = "Suspenzija",
                Datum_Obavestenja = new DateTime(2012, 12, 15, 07, 00, 00),
                Tekst_Obavestenja = "Lekar Miloš Ćojder suspendovan je do daljnjeg."
            };

            Obavestenja obavestenje2 = new Obavestenja()
            {
                Naziv_Obavestenja = "Obaveštenje 2",
                Vrsta_Obavestenja = "COVID 19 Mere",
                Datum_Obavestenja = new DateTime(2020, 03, 25, 10, 30, 00),
                Tekst_Obavestenja = "Poštovati sve mere u vezi sa zaraznom bolešću Covid-19."
            };

            Obavestenja obavestenje3 = new Obavestenja()
            {
                Naziv_Obavestenja = "Obaveštenje 3",
                Vrsta_Obavestenja = "Godišnji odmori",
                Datum_Obavestenja = new DateTime(2021, 08, 07, 10, 30, 50),
                Tekst_Obavestenja = "Svi lekari biće na godišnjem odmoru do 18.08.2021. "
            };

            obavestenja.Add(obavestenje1);
            obavestenja.Add(obavestenje2);
            obavestenja.Add(obavestenje3);

        }

        private void Kreiraj_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            NoviProfil np = new NoviProfil();
            np.Show();
            // SecretaryProfile sp = new SecretaryProfile();
            // sp.Show();
        }

        private void Izmeni_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            NoviProfil np = new NoviProfil();
            np.Show();

        }

        private void Obriši_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            NoviProfil np = new NoviProfil();
            np.Show();
        }


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

       

        private void Izvestaji_Click(object sender, RoutedEventArgs e)
        {
            Generisi_Izvestaj gi = new Generisi_Izvestaj();
            gi.Show();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            NoviProfil np = new NoviProfil();
            this.Close();
            np.Show();
        }


        private void Termini_Click(object sender, RoutedEventArgs e)
        {
            Termini t = new Termini();
            this.Close();
            t.Show();
        }




        //Drag and drop

      





    }




}




