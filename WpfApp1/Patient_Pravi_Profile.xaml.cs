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
    /// Interaction logic for Patient_Pravi_Profile.xaml
    /// </summary>
    public partial class Patient_Pravi_Profile : Window
    {
        public List<Pacijent> patients { get; set; }
        public Patient_Pravi_Profile()
        {
            InitializeComponent();

            patients = new List<Pacijent>();

            Pacijent pacijent1 = new Pacijent()
            {
                Prezime = "Pavlović",
                Ime = "Dragiša",
                JMBG = "1313800055533",
                Ulica = "Nemanjina, 77a ",
                Grad = "Beograd",
                Datum_Rodjenja = new DateTime(1991,05,05,08,30,00),
                Broj_Telefona = "064/998/441",
                Mail_Adresa = "dragisa@gmail.com",
               

            };
            this.DataContext = pacijent1;

            patients.Add(pacijent1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Zdravstveni_Karton__Click(object sender, RoutedEventArgs e)
        {
            ZdravstveniKarton zk = new ZdravstveniKarton();
            this.Close();
            zk.Show();
        }

        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
