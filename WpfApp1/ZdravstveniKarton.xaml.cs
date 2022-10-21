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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ZdravstveniKarton.xaml
    /// </summary>
    ///
    public partial class ZdravstveniKarton : Window
    {
        private object lv;
        private object lv2;

        public List<Lekovi> lekovi { get; set; }
    public List<Appointment> pregledi { get; set; }
    public List<Appointment> istorija_pregleda { get; set; }

    public List<Doktor> doktori { get; set; }

    public List<Alergeni> alergeni { get; set; }
        public ZdravstveniKarton()
        {
            InitializeComponent();
            this.DataContext = this;

            ///Manipulacija nad lekovima
            lekovi = new List<Lekovi>();

       

            Lekovi lek1 = new Lekovi()
            {
                Sifra_Leka = "#11yy",
                Naziv_Leka = "Rivotril",
                Doza  = "2 mg",
                Upotreba = "2x1 na dan"
            };

            Lekovi lek2 = new Lekovi()
            {
                Sifra_Leka = "#22xx",
                Naziv_Leka = "Trodon",
                Doza = "50 mg",
                Upotreba = "3x1 na dan"
            };

            Lekovi lek3 = new Lekovi()
            {
                Sifra_Leka = "#33hg",
                Naziv_Leka = "Ibuprofen",
                Doza =" 600 mg",
                Upotreba = "Po potrebi(ne više od 4 na dan)"
            };
            lekovi.Add(lek1);
            lekovi.Add(lek2);
            lekovi.Add(lek3);
            ///Manipulacija nad terminima
            pregledi = new List<Appointment>();
            istorija_pregleda = new List<Appointment>();
            doktori = new List<Doktor>();

            Appointment pregled1 = new Appointment()
            {
                TipPregleda = TipPregleda.Kontrolni_Pregled,
                Vreme_Pregleda ="24.5.2021. 10:00-10:45s",
                Doktor ="Dr Matija Milosavljev"
            };

            Appointment pregled2 = new Appointment()
            {
                TipPregleda = TipPregleda.Medicinska_Preskripcija,
                Vreme_Pregleda = "29.05.2021. 08:00-08:30",
                Doktor ="Dr Matija Milosavljev"
            };

            pregledi.Add(pregled1);
            pregledi.Add(pregled2);

            Doktor doktor1 = new Doktor()
            {
                Ime = "Milan",
                Prezime = "Milosavljevic",
                Specijalizacija = "kardiologija"
            };
            doktori.Add(doktor1);

            ///Istorija pregleda
            ///
            Appointment istorija_1 = new Appointment()
            {
                TipPregleda = TipPregleda.Operacija,
                Vreme_Pregleda = "13.5.2018. 07:45 - 12:45",
                Doktor = " Dr Matija Milosavljev"
            };

            Appointment istorija_2 = new Appointment()
            {
                TipPregleda = TipPregleda.Sistematski_Pregled,
                Vreme_Pregleda = "21.12.2019. 12:00 - 12:55",
                Doktor = " Dr Milan Milosavljević"

            };
            
            Appointment istorija_3= new Appointment()
            {
                TipPregleda = TipPregleda.Rehabilitacija,
                Vreme_Pregleda = "21.12.2019. - 05.01.2020 ",
                Doktor = " Dr Milan Milosavljević"
            };

            istorija_pregleda.Add(istorija_1);
            istorija_pregleda.Add(istorija_2);
            istorija_pregleda.Add(istorija_3);

            ///Manipulacija nad alergenima

            alergeni = new List<Alergeni>();

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

    

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Nazad_Na_Profil_Click(object sender, RoutedEventArgs e)
        {
            Patient_Pravi_Profile ppp = new Patient_Pravi_Profile();
            this.Close();
            ppp.Show();
        }

        private void Sacuvaj_Promene_Click(object sender, RoutedEventArgs e)
        {
            Patient_Pravi_Profile ppp = new Patient_Pravi_Profile();
            this.Close();
            ppp.Show();
        }

        private void Zakazani_Termin_Click(object sender, RoutedEventArgs e)
        {
            Zakazani_Termin zt = new Zakazani_Termin();
            this.Close();
            zt.Show();
        }

        private void Istorija_Pregleda_Click(object sender, RoutedEventArgs e)
        {
            IstorijaPregleda ip = new IstorijaPregleda();
            this.Close();
            ip.Show();
        }

        private void Unesi_Alergene_Click(object sender, RoutedEventArgs e)
        {
            UnosAlergena ua = new UnosAlergena();
            ua.Show();
        }




    }
}
