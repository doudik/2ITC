namespace TypeRacer
{
    public partial class Form1 : Form
    {

        
        
        public Form1()
        {
            InitializeComponent();
            Start();
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