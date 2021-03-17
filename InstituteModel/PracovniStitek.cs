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

        public enum Typ { get; set; }

        public int PocetStudentu { get; set; }

        public int PocetHodin { get; set; }

        public int PocetTydnu { get; set; }

        public enum Jazyk { get; set; }

        public int PocetBoduZaPracovniStitek { get; set; }

    }
}
