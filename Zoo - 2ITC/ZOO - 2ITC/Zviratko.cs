using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO___2ITC
{
    internal class Zviratko
    {
        //           [Zvířátko]
        //        Jméno
        //       Druh
        //         Masožravec(v booleanu) --> list potravin 
        //       pocetNohou
        //          kolik toho sni zejo
        //     Adoptovany(bool)
        //         Male/female asi bych to dal jako bool true = male false = female
        // ja bych dal kapacitu zalůdku žeo takže 100% :skull_emoji: 

        string jmeno;
        public string druh { get; }
        int pocetNohou;
        public bool masozravec { get; }
        bool adoptovany, male_female;
        float kapacitaZaludku;
        public float kolikTohoSni { get; } // určuje vyhládlost zvířátka
        public bool jeHladove;
        public Zviratko(string jmeno, string druh, bool masozravec, int pocetNohou, float kolikTohoSni, bool adoptovany, bool male_female, Vybeh vybeh)
        {
            this.jmeno = jmeno;
            this.druh = druh;
            this.masozravec = masozravec;
            this.pocetNohou = pocetNohou;
            this.kolikTohoSni = kolikTohoSni;
            kapacitaZaludku = 100f;
            this.adoptovany = adoptovany;
            this.male_female = male_female;
            jeHladove = true;
        }
    
    }
}
