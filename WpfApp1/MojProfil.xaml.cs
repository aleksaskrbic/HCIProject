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
    /// Interaction logic for MojProfil.xaml
    /// </summary>
    public partial class MojProfil : Window
    {
        public MojProfil()
        {
            InitializeComponent();
        }

        private void Change_Picture_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sacuvaj_Promene_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Odbaci_Promene_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
