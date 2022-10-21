using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        public string Email { get; set; }
        App app;
        public MainWindow()
        {
            app = System.Windows.Application.Current as App;
            InitializeComponent();


            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            KreiranjePregleda kp = new KreiranjePregleda();
            this.Close();
            kp.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Log_In_Click(object sender, RoutedEventArgs e)
        {
            ///Nas korisnik
              if (User_Name.Text == "aleksa@gmail.com" && password.Password == "srbija")
             {
                  NoviProfil np = new NoviProfil();
                    this.Close();
                    np.Show();
            }
           else if (User_Name.Text != "aleksa@gmail.com")
            {
                System.Windows.MessageBox.Show("Pogrešno uneto korisničko ime!Pokušajte ponovo!");
                
            }
            else if (password.Password != "srbija")
            {
                System.Windows.MessageBox.Show("Uneta je pogrešna lozinka!Pokušajte ponovo!");
            }



            ///Provera kredencijala
            ///if(Email != "" && PasswordTextBox.Password != "")

        }
        private static void NewMethod(SecretaryProfile sc)
        {
            sc.Show();
        }

        private void Zaboravljena_Click(object sender, RoutedEventArgs e)
        {
            ZaboravljenaLozinka zl = new ZaboravljenaLozinka();
            this.Close();
            zl.Show();
        }

       

      

     

        

     
     
    }
}
