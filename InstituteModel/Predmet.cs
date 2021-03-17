using System;
using System.Collections.Generic;
using System.Text;

namespace InstituteModel
{
    public class Predmet
    {

        public string Zkratka { get; set; }

        public int PocetTydnu { get; set; }

        public int HodinyPrednasek { get; set; }

        public int HodinyCviceni { get; set; }

        public int HodinySeminaru { get; set; }

        public ZakonceniTyp ZakonceniTyp { get; set; } = new ZakonceniTyp();

        public Jazyk Jazyk { get; set; } = new Jazyk();

        public int VelikostTridy { get; set; }

        public List<Skupina> SeznamSkupin { get; set; } = new List<Skupina>();

        public string NazevPredmetu { get; set; }

        public int PocetKreditu { get; set; }

        public Ustav GarantUstav { get; set; } = new Ustav();

        public Zamestnanec GarantJmeno { get; set; } = new Zamestnanec();

    }
}
