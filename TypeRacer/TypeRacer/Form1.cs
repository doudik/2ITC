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
            //TODO zobrazit na UI v�tu
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
            //TODO obarvit p�smenko zelen�

        }
        void ChybnePismenko() {
            //TODO obarvit �patn� p�smenko
            
        }

        private void button_GenerujVetu_Click(object sender, EventArgs e)
        {
            ZobrazListCharu();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("as");
        }




        //1. Na��st v�ty a rozd�lit je
        //2. Ulo�it jednotliv� v�ty do Listu
        //3. Rozd�lit n�hodn� vybranou v�tu na chary
        //4. Ulo�it chary do Listu
        //5. Kontrola p�smene
    }
}