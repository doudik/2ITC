using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeRacer
{
    internal class TypeRacer
    {
        static string[] SentencesField;
        public static char[] vetaVCharech;
        public static string VybranaVeta;
        public static int index { get; private set; } = 1;

        int VratIndex(int cislo)
        {
            return cislo;
        }
        public static void KontrolaPismene(Form1 form, PreviewKeyDownEventArgs e)
        {

            //TODO kontrola inputu 
            // -> spravne 
            MessageBox.Show(vetaVCharech[index].ToString());
            if (vetaVCharech[index] == (char)e.KeyCode)
            {
                ObarveniPismene(form); 
                SpravnePismenko(form);
                
           // MessageBox.Show(e.KeyCode.ToString());
            }
            // -> spatne    
            else
            {
                ChybnePismenko();
            }
        }
        static void SpravnePismenko(Form1 form)
        {
            form.label_pocetSpravnychUhozu_Num.Text = (Int32.Parse(form.label_pocetSpravnychUhozu_Num.Text)+1).ToString();
            index++;
        }
        static void ChybnePismenko()
        {
            //TODO obarvit špatné písmenko

        }
        static void ObarveniPismene(Form1 form) {
            //form.richTextBox1.Text = form.richTextBox1.Text[index].ToString();
            var oldStart = form.richTextBox1.SelectionStart;
            var oldLength = form.richTextBox1.SelectionLength;

            // Select the text to change
            form.richTextBox1.Select(form.richTextBox1.TextLength - 1, 1);
            // Change color
            form.richTextBox1.SelectionColor = Color.Red;

            // Restore selection
            form.richTextBox1.Select(oldStart, oldLength);



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
            form.richTextBox1.Text = VyberNahodnouVetu(SentencesField);
            vetaVCharech = VybranaVeta.ToCharArray();
        }

        static string VyberNahodnouVetu(string[] sentencesField)
        {
            Random rnd = new Random();
            VybranaVeta = sentencesField[rnd.Next(0, sentencesField.Length - 1)].ToUpper();
            return VybranaVeta;

        }

    }
}
