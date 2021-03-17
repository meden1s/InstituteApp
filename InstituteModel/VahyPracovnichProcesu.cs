using System;
using System.Collections.Generic;
using System.Text;

namespace InstituteModel
{
    // Doplňující model, který se po spuštění aplikace
    // načte z XML, nebo databáze, někam do GlobalConfig.)
    public class VahyPracovnichProcesu
    {
        public double HodinaPrednasky { get; set; }

        public double HodinaCviceni { get; set; }

        public double HodinaSeminare { get; set; }

        public double HodinaPrednaskyAnglicky { get; set; }

        public double HodinaCviceniAnglicky { get; set; }

        public double HodinaSeminareAnglicky { get; set; }

        public double UdeleniZapoctu { get; set; }

        public double UdeleniKlasZapoctu { get; set; }

        public double UdeleniZkousky { get; set; }

        public double UdeleniZapoctuAnglicky { get; set; }

        public double UdeleniKlasZapoctuAnglicky { get; set; }

        public double UdeleniZkouskyAnglicky { get; set; }

    }
}
