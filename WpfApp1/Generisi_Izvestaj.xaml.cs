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
    /// Interaction logic for Generisi_Izvestaj.xaml
    /// </summary>
    public partial class Generisi_Izvestaj : Window
    {
        App app;
        public Generisi_Izvestaj()
        {
            InitializeComponent();
            app = Application.Current as App;
            Beginning.SelectedDate = DateTime.Now;
            End.SelectedDate = DateTime.Now.AddDays(30);
        }

        private void Generisi_Izvestaj_Click(object sender, RoutedEventArgs e)
        {

            string start = Beginning.Text as string;
            string end = End.Text as string;
            DateTime from = Convert.ToDateTime(start);
            DateTime to = Convert.ToDateTime(end);

            FrmPdf fp = new FrmPdf();
            fp.ShowDialog();

            //SecretaryProfile sp = new SecretaryProfile();
            ///this.Close();
            //sp.Show();
        }

        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            //SecretaryProfile sp = new SecretaryProfile();
            this.Close();
            //sp.Show();
        }
    }
}
