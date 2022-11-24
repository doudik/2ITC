namespace ZOO___2ITC
{
    public partial class Form1 : Form
    {
        Zoo zoo = new Zoo("Ustecka", 99.9f, 200);
        public Form1()
        {
            InitializeComponent();
            
        }
        void VykresliCtverec(int x, int y, PaintEventArgs e) {
            
            
        }
      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel_Zoo_Paint(object sender, PaintEventArgs e)
        {
            Random rnd = new Random();
            VykresliCtverec(rnd.Next(50, 500), rnd.Next(50, 500), e);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_Zoo.Invalidate();
        }

        private void button_otevriZoo_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button_zavriZoo.Enabled = true;
            button_otevriZoo.Enabled = false;
        }

        private void button_zavriZoo_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button_zavriZoo.Enabled = false;
            button_otevriZoo.Enabled = true;
        }

        private void button_pridejNavstevnika_Click(object sender, EventArgs e)
        {
            if (zoo.KapacitaLidi > zoo.pritomnychLidi)
            {
                zoo.PridejLidi();
                zoo.
                label_pocetNavstevniku_num.Text = zoo.pritomnychLidi.ToString();
            }
            else {
                MessageBox.Show("Již není kapacita");
            }
        }
    } 
}