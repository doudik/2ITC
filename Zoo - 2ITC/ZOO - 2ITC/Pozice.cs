using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO___2ITC
{
    /*[Pozice]
        plat
        nazevPozice
    */
    
    internal class Pozice
    {
        public bool vedeni { get; private set; }
        public string nazevPozice { get; private set; }
        public int plat { get; private set; }
        public Pozice(string nazevPozice, int plat)
        {
            this.nazevPozice = nazevPozice;
            this.plat = plat;
        }
    }
}
