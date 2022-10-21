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
    /// Interaction logic for UnosAlergena.xaml
    /// </summary>
    public partial class UnosAlergena : Window
    {
        public UnosAlergena()
        {
            InitializeComponent();
        }

        private void Vrati_Se_Na_Karton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
