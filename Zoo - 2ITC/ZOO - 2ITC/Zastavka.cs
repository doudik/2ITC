using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO___2ITC
{
    internal class Zastavka
    {
        //[Zastávka]
        //nazev == nazev vybehu 
        //            --> V každá zastávka == výběh
        public static List<Zastavka> zastavky = new List<Zastavka>();
        string nazev;
        public Zastavka(string nazev)
        {
            this.nazev = nazev;
        }
    }
}
