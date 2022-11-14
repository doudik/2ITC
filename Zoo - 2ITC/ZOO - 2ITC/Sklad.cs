using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO___2ITC
{

    internal class Sklad
    {
        public static List<Potrava> surovinyNaSklade = new List<Potrava>();

        public static void Remove(Potrava potrava) {
            if (surovinyNaSklade.Contains(potrava))
            {
                surovinyNaSklade.Remove(potrava); //ale tady odebírám celou potravu a né množství 
            }
            else { 
                //TODO potravina není na skladě --> LABEL
            }
        }
        public static void Add(Potrava potrava) {
            if (surovinyNaSklade.Contains(potrava)) { // <-- když to tam je tak tohle (sipkadolu)
                surovinyNaSklade[surovinyNaSklade.IndexOf(potrava)].mnozstvi += potrava.mnozstvi; // najde v listu kde to je a přidá množství
             }
            else // když ne tak přidam celou potravu
            {
                surovinyNaSklade.Add(potrava);
            }
        }
    }
}
