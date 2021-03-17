using System;
using System.Collections.Generic;
using System.Text;

namespace InstituteModel
{
    public class Zamestnanec
    {
        public string Jmeno { get; set; }

        public string Prijmeni { get; set; }

        public string CeleJmeno
        {
            get
            {
                return $"{Jmeno} {Prijmeni}";
            }
        }

        public string EmailPracovni { get; set; }

        public string EmailSoukromy { get; set; }

        public string TelefonPracovni { get; set; }

        public string TelefonSoukromy { get; set; }

        public bool Doktorand { get; set; }

        public double Uvazek { get; set; }

        public List<PracovniStitek> SeznamStitku { get; set; } = new List<PracovniStitek>();

        // Pracovní body bez angličtiny – int – 526 (Toto nebude vlastnost, ale metoda.)
        // Pracovní body – int – 767 (Toto nebude vlastnost, ale metoda.)
    }
}
