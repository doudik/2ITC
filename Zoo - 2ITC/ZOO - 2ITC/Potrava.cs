using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO___2ITC
{
    internal class Potrava
    {
        public static string[] potravaProBilozravce = { "List", "Tráva", "Jablka", "Salát", "Obilí" };
        public static string[] potravaProMasozravce = { "Bilozravce", "Jehnečí", "Vepřove", "Kuřecí" };
        //[Potraviny]
        //nazev
        //mnozstvi
        public string nazev { get; }
        public float mnozstvi { get; set; }
        public Potrava(string nazev, float mnoztvi)
        {
            this.nazev = nazev;
            this.mnozstvi = mnoztvi;

        }
    }
}
