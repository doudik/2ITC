using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO___2ITC
{
    internal class Zoo
    {
        //[ZOO]
        //hodnocení
        //            vstupné
        //            kapacitaLidí
        //            otevíracíDoba
        //            -------------
        //            početZvířátek
        //            početVýběhů
        //            početZaměstnanců
        float hodnoceni, vstupne;
        int kapacitaLidi, pocetZviratek, pocetVybehu, pocetZamestnancu;
        DateTime oteviraciDoba;
        string nazev;
        public Zoo(string nazev, float vstupne, int kapacitaLidi, DateTime oteviraciDoba) {  
            this.nazev = nazev;
            this.vstupne = vstupne;
            this.kapacitaLidi = kapacitaLidi;
            this.oteviraciDoba = oteviraciDoba;
        }
    }
}
