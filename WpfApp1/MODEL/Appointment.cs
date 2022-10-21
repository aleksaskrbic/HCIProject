using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.MODEL
{
    
        public enum TipPregleda
        {
           Kontrolni_Pregled,
           Operacija,
           Intervencija,
           Sistematski_Pregled,
           Medicinska_Preskripcija,
           Rehabilitacija
        }
        public  class Appointment
        {
            public TipPregleda TipPregleda { get; set; }
            public String Vreme_Pregleda { get; set; }

            public String Zavrsetak_Pregleda { get; set; }
            public DateTime Timestamp { get; set; }
            public string Hall { get; set; }
            public string Doktor { get; set; }
            public string Clinic { get; set; }

           // public TimeInterval timeIntervall

        public Doktor doktor { get; set; }
        public string Ime { get; internal set; }
    }
    
}
