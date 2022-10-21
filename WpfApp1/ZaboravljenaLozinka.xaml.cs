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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ZaboravljenaLozinka.xaml
    /// </summary>
    public partial class ZaboravljenaLozinka : Window
    {

        public string Email { get; set; }
        public ZaboravljenaLozinka()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Zaboravi_Click(object sender, RoutedEventArgs e)
        {
            if(Mail_Adresa.Text == "aleksa@gmail.com")
            {
                MessageBox.Show("Lozinka će biti poslata na Vašu E-mail adresu! Proverite nalog!");
            }
            else
            {
                MessageBox.Show("Adresa koju ste uneli nije validna! Pokušajte ponovo!");
            }

        }

        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();

        }

    }
}
