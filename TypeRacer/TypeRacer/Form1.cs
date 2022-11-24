namespace TypeRacer
{
    public partial class Form1 : Form
    {

        
        string[] SentencesField;
        public char[] vetaVCharech;
        string VybranaVeta;
        int index = 0;

        public Form1()
        {
            InitializeComponent();
            Start();
        }
        void Start() {
            NactiSoubor();
            ZobrazListCharu();
        }
        void NactiSoubor() {
            string sentences = System.IO.File.ReadAllText("vety.txt");
            SentencesField = sentences.Split('.');
        }
        
        void ZobrazListCharu() {
            //TODO zobrazit na UI vìtu
            label_Text.Text = VyberNahodnouVetu(SentencesField);
        }

        string VyberNahodnouVetu(string[] sentencesField)
        {
            Random rnd = new Random();
            VybranaVeta = sentencesField[rnd.Next(0, sentencesField.Length - 1)];
            return VybranaVeta;

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MessageBox.Show("Adawd");
            //TODO userInput
            if ((char)e.KeyCode == vetaVCharech[index])
            {
                //+
                
                label_pocetSpravnychUhozu_Num.Text = (Int32.Parse(label_pocetSpravnychUhozu_Num.Text)+1).ToString();
            }
            else { 
                //-
            }
        }
        int VratIndex(int cislo) {
            return cislo;
        }
        void KontrolaPismene(PreviewKeyDownEventArgs e) {
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
        void SpravnePismenko() {
            //TODO obarvit písmenko zelenì

        }
        void ChybnePismenko() {
            //TODO obarvit špatné písmenko
            
        }

        private void button_GenerujVetu_Click(object sender, EventArgs e)
        {
            ZobrazListCharu();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("as");
        }




        //1. Naèíst vìty a rozdìlit je
        //2. Uložit jednotlivé vìty do Listu
        //3. Rozdìlit náhodnì vybranou vìtu na chary
        //4. Uložit chary do Listu
        //5. Kontrola písmene
    }
}