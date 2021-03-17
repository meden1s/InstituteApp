using System;
using System.Collections.Generic;
using System.Text;

namespace InstituteModel
{
    public class PracovniStitek
    {

        public string Nazev { get; set; }

        public Zamestnanec Zamestnanec { get; set; }

        public Predmet Predmet { get; set; }

        public PracovniStitekTyp Typ { get; set; } = new PracovniStitekTyp();

        public int PocetStudentu { get; set; }

        public int PocetHodin { get; set; }

        public int PocetTydnu { get; set; }

        public Jazyk Jazyk { get; set; } = new Jazyk();

        //public int PocetBoduZaPracovniStitek { get; set; }

    }
}
