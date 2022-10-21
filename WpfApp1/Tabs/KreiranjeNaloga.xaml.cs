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

namespace WpfApp1.Tabs
{
    /// <summary>
    /// Interaction logic for KreiranjeNaloga.xaml
    /// </summary>
    public partial class KreiranjeNaloga : Window
    {
        public string Email { get; set; }
        public string Ime { get; set; }
        public string Ime_Gosta { get; set; }

        public string jmbg { get; set; }
        public KreiranjeNaloga()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void Kreiramo_Redovan_Nalog_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
