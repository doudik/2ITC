using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZOO___2ITC
{
    internal class Zamestnanec
    {
        //[Zaměstnanci]
        //jmeno
        //            Male/female
        //            moznostPovyseni
        //            výběh, o který se stará
        string jmeno;
        bool male_female;
        bool moznostPovyseni;
        List<Vybeh> vybehyOKtereSeStara;
        public Pozice pozice { get; private set; }
        public Zamestnanec(string jmeno, bool male_female, bool moznostPovyseni = false, Pozice pozice = null)
        {
            this.jmeno = jmeno;
            this.male_female = male_female;
            this.moznostPovyseni = moznostPovyseni;
            this.pozice = pozice;
        }
        void ZmenaPozice(Pozice pozice) {
            if (this.pozice != pozice && this.pozice.vedeni)
            {
                this.pozice = pozice; 
            }
            else { 
                // nemůžeš si změnit pozici 
            }
        }
        public void PriradVybeh(Vybeh vybeh) {
            if (vybehyOKtereSeStara.Contains(vybeh))
            {
                //napise ze uz se o ne stara
            }
            else
            {
                vybehyOKtereSeStara.Add(vybeh);
            }
        }

        public void OdeberVybeh(Vybeh vybeh) {
            if (vybehyOKtereSeStara.Contains(vybeh))
            {
                vybehyOKtereSeStara.Remove(vybeh);
            }
            else
            {
                //vypise : o tento vybeh se ani nestaral
            }
        }
        public void NakrmZviratko(Zviratko zviratko)
        {
            //kontrola vybehyOKtereSeStara && zviratkaVeVybehu musí obsahovat hladové zvířátko 
            for (int i = 0; i < vybehyOKtereSeStara.Count; i++)
            {   
                for (int j = 0; j < vybehyOKtereSeStara[i].zviratkaVeVybehu.Count; j++)
                {
                    if (vybehyOKtereSeStara[i].zviratkaVeVybehu[j] == zviratko && vybehyOKtereSeStara[i].zviratkaVeVybehu[j].jeHladove == true) { //je hladové a starám se o něj
                        //dám zvířátku napapat
                        if (vybehyOKtereSeStara[i].zviratkaVeVybehu[j].masozravec) //pokud je masožravec
                        {
                            // zkontroluji všechny potraviny na skladě s arrayem potravin po masožravce
                            for (int z = 0; z < Potrava.potravaProMasozravce.Length; z++)
                            {
                                for (int x = 0; x < Sklad.surovinyNaSklade.Count; x++)
                                {
                                    if (Potrava.potravaProMasozravce[z] == Sklad.surovinyNaSklade[x].nazev)
                                    { //našel sem potravinu na skladě
                                        if (Sklad.surovinyNaSklade[x].mnozstvi >= zviratko.kolikTohoSni)
                                        {
                                            zviratko.jeHladove = false;
                                            Sklad.surovinyNaSklade[x].mnozstvi -= zviratko.kolikTohoSni;
                                            break;
                                        }
                                        else
                                        {
                                            //na skladě není dostatečné množství suroviny
                                        }
                                    }
                                }
                                //nenašel sem potravinu [z] na skladě
                            }
                            //nenašel sem žádnou potravinu na skladě
                        }
                        else// tohle je když je to bílozravec
                        {
                            for (int z = 0; z < Potrava.potravaProBilozravce.Length; z++)
                            {
                                for (int x = 0; x < Sklad.surovinyNaSklade.Count; x++)
                                {
                                    if (Potrava.potravaProBilozravce[z] == Sklad.surovinyNaSklade[x].nazev)
                                    { //našel sem potravinu na skladě
                                        if (Sklad.surovinyNaSklade[x].mnozstvi >= zviratko.kolikTohoSni)
                                        {
                                            zviratko.jeHladove = false;
                                            Sklad.surovinyNaSklade[x].mnozstvi -= zviratko.kolikTohoSni;
                                            break;
                                        }
                                        else
                                        {
                                            //na skladě není dostatečné množství suroviny
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
        public void VypisHladovaZviratka() {
            for (int i = 0; i < vybehyOKtereSeStara.Count; i++)
            {
                for (int j = 0; j < vybehyOKtereSeStara[i].zviratkaVeVybehu.Count; j++)
                {
                    if (vybehyOKtereSeStara[i].zviratkaVeVybehu[j].jeHladove) { 
                        //Vypis mi vsechny tyhle zvířátka!
                    }
                }
            }
        }
    } 
}
