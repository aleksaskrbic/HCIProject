using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp1.Tabs;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for SecretaryProfile.xaml
    /// </summary>
    public partial class SecretaryProfile : Window
    {
        private Point _dragStartPoint;

        public ObservableCollection<Pacijent> Pacijenti { get; }
        public List<Pacijent> patients { get; set; }
        public List<Lekovi> lekovi { get; set; }
        public List<Appointment> appointments { get; set; }

        public List<Obavestenja> obavestenja { get; set; }

        public List<Appointment> doktori { get; set; }




        // public List<Doktor> doctors { get; set; }

        public SecretaryProfile()
        {
            InitializeComponent();
            this.DataContext = this;

            lekovi = new List<Lekovi>();
            Pacijenti = new ObservableCollection<Pacijent>();
            patients = new List<Pacijent>();
            appointments = new List<Appointment>();
            obavestenja = new List<Obavestenja>();
            doktori = new List<Appointment>();





            ///Manipulacija sa pacijentima
            Pacijent pacijent1 = new Pacijent()
            {
                Prezime = "Pavlović",
                Ime = "Dragiša",
                Broj_Telefona = "064/998/441",
                Mail_Adresa = "dragiša@gmail.com",
                Nadimak = "dragiša" 
                
            };
       
            Pacijenti.Add(new Pacijent() { 
            Prezime = "Markovic", 
            Ime = "Marko", 
            Broj_Telefona = "555-333", 
            Mail_Adresa = "marko@gmail.com",
            Nadimak = "Mare"
                                     });

            Pacijenti.Add(pacijent1);
            patients.Add(pacijent1);

            ///Drag and drop
            Pacijenti_Box.PreviewMouseMove += ListBox_PreviewMouseMove;


            var style = new Style(typeof(ListBoxItem));
            style.Setters.Add(new Setter(ListBoxItem.AllowDropProperty, true));
            style.Setters.Add(
                new EventSetter(
                    ListBoxItem.PreviewMouseLeftButtonDownEvent,
                    new MouseButtonEventHandler(ListBoxItem_PreviewMouseLeftButtonDown)));
            style.Setters.Add(
                    new EventSetter(
                        ListBoxItem.DropEvent,
                        new DragEventHandler(ListBoxItem_Drop)));
            Pacijenti_Box.ItemContainerStyle = style;

           





            // Pacijenti.Add(new Pacijent() { Id = "2", Ime = "Mika", Prezime = "Mikic" });
            // Pacijenti.Add(new Pacijent() { Id = "3", Ime = "Zika", Prezime = "Zikic" })

            //Manipulacija sa terminima

            Appointment appointment1 = new Appointment()
            {
                Vreme_Pregleda = "07:00",
                Zavrsetak_Pregleda = "08:30"
               

            };

            Appointment appointment2 = new Appointment()
            {
                Vreme_Pregleda = "09:00",
                Zavrsetak_Pregleda = "09:45"
            };

            appointments.Add(appointment1);
            appointments.Add(appointment2);

            //Doktori

            Appointment dr1 = new Appointment()
            {
                Doktor = "Dr Miloš Ćojder"
            };
            doktori.Add(dr1);

            



            //Manipulacija sa obavestenjima

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

        private T FindVisualParent<T>(DependencyObject child)
            where T : DependencyObject
        {
            var parentObject = VisualTreeHelper.GetParent(child);
            if (parentObject == null)
                return null;
            T parent = parentObject as T;
            if (parent != null)
                return parent;
            return FindVisualParent<T>(parentObject);
        }

        private void Kalendar_Click(object sender, RoutedEventArgs e)
        {
            Setnja.SelectedIndex = 1;
        }

     
        private void Oglasi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Izbor_Doktora_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

   
   
        private void Klikni_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Izvestaji_Click(object sender, RoutedEventArgs e)
        {
            Generisi_Izvestaj gi = new Generisi_Izvestaj();
            gi.Show();
        }

        private void Patient_Pravi_Profile_Click(object sender, RoutedEventArgs e)
        {
            Patient_Pravi_Profile ppp = new Patient_Pravi_Profile();
            ppp.Show();
        }

      

       

        private void Prikazi_Ga_Opet_Click(object sender, RoutedEventArgs e)
        {
            Patient_Pravi_Profile ppp = new Patient_Pravi_Profile();
            ppp.Show();
        }

        private void Nedeljni_Kalendar_Click(object sender, RoutedEventArgs e)
        {
            Setnja.SelectedIndex = 2;
        }

        private void Dnevni_Kalendar_Click(object sender, RoutedEventArgs e)
        {
            Setnja.SelectedIndex = 3;
        }

        private void Mesecni_Kalendar_Click(object sender, RoutedEventArgs e)
        {
            Setnja.SelectedIndex = 1;
        }

        private void Nazad_Na_Dnevni_Click(object sender, RoutedEventArgs e)
        {
            Setnja.SelectedIndex = 3;
        }

        private void Ponovo_Nedeljni_Click(object sender, RoutedEventArgs e)
        {
            Setnja.SelectedIndex = 2;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Setnja.SelectedIndex = 1;
        }

        private void Nemate_Nalog_Click(object sender, RoutedEventArgs e)
        {
            Tabs.KreiranjeNaloga kn = new KreiranjeNaloga();
            kn.Show();
        }

        /* private void Button_Click(object sender, RoutedEventArgs e)
         {
             myTabControl.SelectedIndex = 1;
         }*/

        private void ListBox_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            Point point = e.GetPosition(null);
            Vector diff = _dragStartPoint - point;
            if (e.LeftButton == MouseButtonState.Pressed &&
                (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                    Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                var lb = sender as ListBox;
                var lbi = FindVisualParent<ListBoxItem>(((DependencyObject)e.OriginalSource));
                if (lbi != null)
                {
                    DragDrop.DoDragDrop(lbi, lbi.DataContext, DragDropEffects.Move);
                }
            }
        }
        private void ListBoxItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _dragStartPoint = e.GetPosition(null);
        }

        private void ListBoxItem_Drop(object sender, DragEventArgs e)
        {
            if (sender is ListBoxItem)
            {
                var source = e.Data.GetData(typeof(Pacijent)) as Pacijent;
                var target = ((ListBoxItem)(sender)).DataContext as Pacijent;

                int sourceIndex = Pacijenti_Box.Items.IndexOf(source);
                int targetIndex = Pacijenti_Box.Items.IndexOf(target);

                Move(source, sourceIndex, targetIndex);
            }
        }

        private void Move(Pacijent source, int sourceIndex, int targetIndex)
        {
            if (sourceIndex < targetIndex)
            {
                patients.Insert(targetIndex + 1, source);
                patients.RemoveAt(sourceIndex);
            }
            else
            {
                int removeIndex = sourceIndex + 1;
                if (patients.Count + 1 > removeIndex)
                {
                    patients.Insert(targetIndex, source);
                    patients.RemoveAt(removeIndex);
                }
            }
        }

        private void Profil_Sekretara_Click(object sender, RoutedEventArgs e)
        {
            MojProfil mp = new MojProfil();
            mp.Show();
        }

        private void Oglasna_Tabla_Click(object sender, RoutedEventArgs e)
        {
            OglasnaTabla ot = new OglasnaTabla();
            ot.Show();
        }

        private void Zakaži_Termin_Click(object sender, RoutedEventArgs e)
        {
            KreiranjePregleda kp = new KreiranjePregleda();
            kp.Show();
        }

        
    }


}
