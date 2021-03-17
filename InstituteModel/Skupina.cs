using System;
using System.Collections.Generic;
using System.Text;

namespace InstituteModel
{
    public class Skupina
    {

        public string Zkratka { get; set; }

        public string Nazev { get; set; }

        public List<Predmet> SeznamPredmetu { get; set; } = new List<Predmet>();

        public int Rocnik { get; set; }

        public Semestr Semestr { get; set; } = new Semestr();

        public int PocetStudentu { get; set; }

        public StudiumTyp StudiumTyp { get; set; } = new StudiumTyp();

        public Jazyk Jazyk { get; set; } = new Jazyk();

    }
}
