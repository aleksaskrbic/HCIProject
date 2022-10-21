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
using WpfApp1.Tabs;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for KalendarNedeljni.xaml
    /// </summary>
    public partial class KalendarNedeljni : Window
    {
        public KalendarNedeljni()
        {
            InitializeComponent();
        }

        private void Mesecni_Kalendar_Click(object sender, RoutedEventArgs e)
        {
            KalendarMesec KM = new KalendarMesec();
            this.Close();
            KM.Show();
        }

        private void Profil_Click(object sender, RoutedEventArgs e)
        {
            Patient_Pravi_Profile pp = new Patient_Pravi_Profile();
            
            pp.Show();
        }

       

        private void Kalendar_Day_Click(object sender, RoutedEventArgs e)
        {
            KalendarDnevni kd = new KalendarDnevni();
            this.Close();
            kd.Show();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            NoviProfil np = new NoviProfil();
            this.Close();
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
