using System;
using System.Collections.Generic;
using System.Text;

namespace InstituteModel
{
    public class Skupinka
    {

        public string Zkratka { get; set; }

        public string Nazev { get; set; }

        public List<Predmet> SeznamPredmetu { get; set; } = new List<Predmet>();

        public int Rocnik { get; set; }

        public enum Semestr { get; set; }

        public enum PocetStudentu { get; set; }

        public enum TypStudium { get; set; }

        public enum Jazyk { get; set; }


    }
}
