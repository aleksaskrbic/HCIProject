using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.MODEL
{
        public enum Vrsta_Pregleda
        {
            Kontrolni_Pregled,
            Operacija,
            Intervencija,
            Medicinska_Preskripcija,
            Sistematski_Pregled,
            Rehabilitacija
        }
    public class ZakazaniTermini
    {
        public Vrsta_Pregleda TipPregleda { get; set; }
        public String Pacijent { get; set; }

        public String JMBG { get; set; }

        public String Broj { get; set; }

        public String Lekar { get; set; }

        public String Prostorija { get; set; }

        public DateTime Pocetak_Pregleda { get; set; }

        public DateTime Zavrsetak_Pregleda { get; set; }

       

 

        
    }
}
