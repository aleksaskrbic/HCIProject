using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1.MODEL
{

    public enum TipNaloga
    {
       Guest_Nalog,
       Redovan_Nalog
    }
    public class Pacijent 
    {
        public TipNaloga TipNaloga { get; set; }
       public String Prezime { get; set; }
        public String Ime { get; set; }

        public String JMBG { get; set; }

        public String Ulica { get; set; }

        public String Grad { get; set; }

        public DateTime Datum_Rodjenja { get; set; }

        public String Mail_Adresa { get; set; }

        public String Broj_Telefona { get; set; }

        public String Nadimak { get; set; }

    }

    
    
}
