using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO___2ITC
{
    internal class Vybeh
    {
        //[Výběh]
        //maxPocetZvirat
        //            pojmenování
        //            seznam zvířátek, které se tam nachází
        //            velikost
        string nazev;
        public List<Zviratko> zviratkaVeVybehu;
        int maxPocetZvirat, velikost;

        public Vybeh(string nazev, int maxPocetZvirat, int velikost)
        {
            this.nazev = nazev;
            this.maxPocetZvirat = maxPocetZvirat;
            this.velikost = velikost;
            Zastavka.zastavky.Add(new Zastavka(this.nazev));
        }

        void pridejZviratkoDoVybehu(Zviratko zviratko)
        {
            if (zviratkaVeVybehu.Count == 0)
            {
                zviratkaVeVybehu.Add(zviratko);
            }
            else if (zviratkaVeVybehu[0].druh == zviratko.druh && zviratkaVeVybehu.Count < maxPocetZvirat) //aby zviratka ve vybehu byli stejny druh
            {
                zviratkaVeVybehu.Add(zviratko);
            }
            else
            {
                //ERROR
            }
        }
    }
}
