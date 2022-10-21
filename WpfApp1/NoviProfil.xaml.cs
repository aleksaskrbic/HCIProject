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
    /// Interaction logic for NoviProfil.xaml
    /// </summary>
    public partial class NoviProfil : Window
    {


        private Point _dragStartPoint;

        //Drag and dropp
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

       

        public List<Pacijent> Pacijenti { get; set; }
        public List<Pacijent> patients { get; set; }

        public List<Appointment> doktori { get; set; }

        private IList<PatientList> doctors = new ObservableCollection<PatientList>();

        public class PatientList
        {
            public string Ime { get; set; }

            //public string Prezime { get; set; }

//            public string Mail_Adresa { get; set; }

           // public string Broj_Telefona { get; set; }
            public PatientList(string name)
            {
                this.Ime = name;

                //this.Prezime = surname;

            //    this.Mail_Adresa = mail;

              //  this.Broj_Telefona = broj;
            }
        }

        public NoviProfil()
        {
            InitializeComponent();
            this.DataContext = this;


            patients = new List<Pacijent>();
            doktori = new List<Appointment>();
            Pacijenti = new List<Pacijent>();

            Pacijent pacijent1 = new Pacijent()
            {
                Prezime = "Pavlović",
                Ime = "Dragiša",
                Broj_Telefona = "064/998/441",
                Mail_Adresa = "dragiša@gmail.com",
                Nadimak = "dragiša"

            };

            Pacijenti.Add(new Pacijent()
            {
                Prezime = "Markovic",
                Ime = "Marko",
                Broj_Telefona = "555-333",
                Mail_Adresa = "marko@gmail.com",
                Nadimak = "Mare"
            });

            Pacijenti.Add(pacijent1);
            patients.Add(pacijent1);


           // lbPatientList.DisplayMemberPath = "Prezime";

            //lbPatientList.DisplayMemberPath = "Broj_Telefona";

           // lbPatientList.DisplayMemberPath = "Mail_Adresa";
            
             
            //Doktori
            Appointment dr1 = new Appointment()
            {
                Ime = "Dr Miloš Ćojder"
            };

            Appointment dr2 = new Appointment()
            {
                Ime = "Dr Gregory House"
            };
            doktori.Add(dr1);
            doktori.Add(dr2);



            //Drag and drop
            doctors.Add(new PatientList("Dr Gregory House"));
            doctors.Add(new PatientList("Dr Miloš Ćojder"));
   
            lbPatientList.DisplayMemberPath =  "Ime";

            lbPatientList.ItemsSource = doctors;


            lbPatientList.PreviewMouseMove += ListBox_PreviewMouseMove;

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
            lbPatientList.ItemContainerStyle = style;
        }

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
                var source = e.Data.GetData(typeof(PatientList)) as PatientList;
                var target = ((ListBoxItem)(sender)).DataContext as PatientList;

                int sourceIndex = lbPatientList.Items.IndexOf(source);
                int targetIndex = lbPatientList.Items.IndexOf(target);

                Move(source, sourceIndex, targetIndex);
            }
        }

        private void Move(PatientList lista, int sourceIndex, int targetIndex)
        {
            if (sourceIndex < targetIndex)
            {
                
                doctors.Insert(targetIndex + 1, lista);
                doctors.RemoveAt(sourceIndex);
            }
            else
            {
                int removeIndex = sourceIndex + 1;
                if (doctors.Count + 1 > removeIndex)
                {
                    doctors.Insert(targetIndex, lista);
                    doctors.RemoveAt(removeIndex);
                }
            }
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

        private void Termini_Click(object sender, RoutedEventArgs e)
        {
            Termini t = new Termini();
            this.Close();
            t.Show();
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

        private void Moj_Profil_Click(object sender, RoutedEventArgs e)
        {
            MojProfil mp = new MojProfil();
            mp.Show();
        }

        private void Patient_Profile_Click(object sender, RoutedEventArgs e)
        {
            Patient_Pravi_Profile ppp = new Patient_Pravi_Profile();
            ppp.Show();
        }

    
   

      
       

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Novi meni
      private void Novi_Profil_Click2(object sender, RoutedEventArgs e)
        {
            KreiranjeNaloga kn = new KreiranjeNaloga();
            this.Close();
            kn.Show();

        }

        private void Oglasna_Tabla_Click2(object sender, RoutedEventArgs e)
        {
            OglasnaTabla ot = new OglasnaTabla();
            this.Close();
            ot.Show();
        }

        private void Pacijenti_Click2(object sender, RoutedEventArgs e)
        {
            Pacijenti p = new Pacijenti();
            this.Close();
            p.Show();
        }

        private void Kalendar_Click2(object sender, RoutedEventArgs e)
        {
            KalendarMesec km = new KalendarMesec();
            this.Close();
            km.Show();
        }

        private void Novi_Termin_Click2(object sender, RoutedEventArgs e)
        {
            KreiranjePregleda kp = new KreiranjePregleda();
            this.Close();

            kp.Show();
        }

        private void Izvestaji_Click2(object sender, RoutedEventArgs e)
        {
            Generisi_Izvestaj gi = new Generisi_Izvestaj();
            gi.Show();
        }




    }
}
