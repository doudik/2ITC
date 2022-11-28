using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TypeRacer
{
    internal class TypeRacer
    {
        static string[] SentencesField;
        public static char[] vetaVCharech;
        public static string VybranaVeta;
        public static int index { get; } = 0;


        int VratIndex(int cislo)
        {
            return cislo;
        }
        void KontrolaPismene(Form1 form, PreviewKeyDownEventArgs e)
        {
            vetaVCharech = VybranaVeta.ToCharArray();
            //TODO kontrola inputu 
            // -> spravne 
            if (form.label_Text.Text[index] == (char)e.KeyCode)
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

        
        public static void Start(Form1 form)
        {
            NactiSoubor();
            ZobrazListCharu(form);
        }
        static void NactiSoubor()
        {
            string sentences = System.IO.File.ReadAllText("vety.txt");
            SentencesField = sentences.Split('.');
        }

        public static void ZobrazListCharu(Form1 form)
        {
            //TODO zobrazit na UI větu
            form.label_Text.Text = VyberNahodnouVetu(SentencesField);
        }

        static string VyberNahodnouVetu(string[] sentencesField)
        {
            Random rnd = new Random();
            VybranaVeta = sentencesField[rnd.Next(0, sentencesField.Length - 1)];
            return VybranaVeta;

        }

    }
}
