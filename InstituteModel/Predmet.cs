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

        public enum ZpusobZakonceni { get; set; }

        public enum Jazyk { get; set; }

        public int VelikostTridy { get; set; }

        public List<Skupinka> SeznamSkupin { get; set; } = new List<Skupinka>();

        public string NazevPredmetu { get; set; }

        public int PocetKreditu { get; set; }

        public enum GarantUstav { get; set; }

        public string GarantJmeno { get; set; }

    }
}
