using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TypeRacer
{
    internal class TypeRacer
    {
        string[] SentencesField;
        public char[] vetaVCharech;
        string VybranaVeta;
        int index = 0;


        int VratIndex(int cislo)
        {
            return cislo;
        }
        void KontrolaPismene(PreviewKeyDownEventArgs e)
        {
            vetaVCharech = VybranaVeta.ToCharArray();
            //TODO kontrola inputu 
            // -> spravne 
            if (label_Text.Text[index] == (char)e.KeyCode)
            {
                SpravnePismenko();
            }
            // -> spatne
            else
            {
                ChybnePismenko();
            }
        }
        void SpravnePismenko()
        {
            //TODO obarvit písmenko zeleně

        }
        void ChybnePismenko()
        {
            //TODO obarvit špatné písmenko

        }

        private void button_GenerujVetu_Click(object sender, EventArgs e)
        {
            ZobrazListCharu();
        }
        void Start()
        {
            NactiSoubor();
            ZobrazListCharu();
        }
        void NactiSoubor()
        {
            string sentences = System.IO.File.ReadAllText("vety.txt");
            SentencesField = sentences.Split('.');
        }

        void ZobrazListCharu()
        {
            //TODO zobrazit na UI větu
            label_Text.Text = VyberNahodnouVetu(SentencesField);
        }

        string VyberNahodnouVetu(string[] sentencesField)
        {
            Random rnd = new Random();
            VybranaVeta = sentencesField[rnd.Next(0, sentencesField.Length - 1)];
            return VybranaVeta;

        }

    }
}
