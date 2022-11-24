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
        public int KapacitaLidi {get{ return kapacitaLidi; } }
        public int pritomnychLidi { get; set; }
        string nazev;
        float kasicka;       

        public Zoo(string nazev, float vstupne, int kapacitaLidi) {  
            this.nazev = nazev;
            this.vstupne = vstupne;
            this.kapacitaLidi = kapacitaLidi;
            pritomnychLidi = 0;
            kasicka = 0f;
        }

        public void PridejLidi() {
            pritomnychLidi++;
            ZaplatVstup();
        }
        public void OdeberLidi() {
            pritomnychLidi--;
        }

        void ZaplatVstup()
        {
            kasicka+=vstupne;
        }
}
