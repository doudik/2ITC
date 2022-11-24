namespace ZOO___2ITC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_pridejVybeh = new System.Windows.Forms.Button();
            this.button_generujZviratka = new System.Windows.Forms.Button();
            this.button_vygenerujZamestnance = new System.Windows.Forms.Button();
            this.comboBox_vyberVybeh = new System.Windows.Forms.ComboBox();
            this.label_vyberVybeh = new System.Windows.Forms.Label();
            this.panel_Zoo = new System.Windows.Forms.Panel();
            this.label_zamestnanec = new System.Windows.Forms.Label();
            this.comboBox_vyberZamestnance = new System.Windows.Forms.ComboBox();
            this.button_otevriZoo = new System.Windows.Forms.Button();
            this.button_zavriZoo = new System.Windows.Forms.Button();
            this.button_pridejNavstevnika = new System.Windows.Forms.Button();
            this.panel_informaceOZoo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_pocetZvirat_num = new System.Windows.Forms.Label();
            this.label_pocetZvirat = new System.Windows.Forms.Label();
            this.label_pocetNavstevniku_num = new System.Windows.Forms.Label();
            this.label_pocetNavstevniku = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel_informaceOZoo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_pridejVybeh
            // 
            this.button_pridejVybeh.Location = new System.Drawing.Point(2371, 24);
            this.button_pridejVybeh.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_pridejVybeh.Name = "button_pridejVybeh";
            this.button_pridejVybeh.Size = new System.Drawing.Size(324, 46);
            this.button_pridejVybeh.TabIndex = 0;
            this.button_pridejVybeh.Text = "Přidej Výběh";
            this.button_pridejVybeh.UseVisualStyleBackColor = true;
            // 
            // button_generujZviratka
            // 
            this.button_generujZviratka.Location = new System.Drawing.Point(2371, 82);
            this.button_generujZviratka.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_generujZviratka.Name = "button_generujZviratka";
            this.button_generujZviratka.Size = new System.Drawing.Size(324, 46);
            this.button_generujZviratka.TabIndex = 1;
            this.button_generujZviratka.Text = "Nageneruj Zvířátka";
            this.button_generujZviratka.UseVisualStyleBackColor = true;
            // 
            // button_vygenerujZamestnance
            // 
            this.button_vygenerujZamestnance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_vygenerujZamestnance.Location = new System.Drawing.Point(2371, 140);
            this.button_vygenerujZamestnance.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_vygenerujZamestnance.Name = "button_vygenerujZamestnance";
            this.button_vygenerujZamestnance.Size = new System.Drawing.Size(324, 46);
            this.button_vygenerujZamestnance.TabIndex = 2;
            this.button_vygenerujZamestnance.Text = "Nageneruj Zaměstnance";
            this.button_vygenerujZamestnance.UseVisualStyleBackColor = true;
            // 
            // comboBox_vyberVybeh
            // 
            this.comboBox_vyberVybeh.FormattingEnabled = true;
            this.comboBox_vyberVybeh.Location = new System.Drawing.Point(2378, 1204);
            this.comboBox_vyberVybeh.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBox_vyberVybeh.Name = "comboBox_vyberVybeh";
            this.comboBox_vyberVybeh.Size = new System.Drawing.Size(321, 38);
            this.comboBox_vyberVybeh.TabIndex = 3;
            // 
            // label_vyberVybeh
            // 
            this.label_vyberVybeh.AutoSize = true;
            this.label_vyberVybeh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_vyberVybeh.Location = new System.Drawing.Point(2270, 1208);
            this.label_vyberVybeh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_vyberVybeh.Name = "label_vyberVybeh";
            this.label_vyberVybeh.Size = new System.Drawing.Size(101, 38);
            this.label_vyberVybeh.TabIndex = 4;
            this.label_vyberVybeh.Text = "Výběh:";
            // 
            // panel_Zoo
            // 
            this.panel_Zoo.BackColor = System.Drawing.Color.MistyRose;
            this.panel_Zoo.Location = new System.Drawing.Point(21, 24);
            this.panel_Zoo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel_Zoo.Name = "panel_Zoo";
            this.panel_Zoo.Size = new System.Drawing.Size(1910, 1674);
            this.panel_Zoo.TabIndex = 7;
            this.panel_Zoo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Zoo_Paint);
            // 
            // label_zamestnanec
            // 
            this.label_zamestnanec.AutoSize = true;
            this.label_zamestnanec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_zamestnanec.Location = new System.Drawing.Point(2187, 1272);
            this.label_zamestnanec.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_zamestnanec.Name = "label_zamestnanec";
            this.label_zamestnanec.Size = new System.Drawing.Size(187, 38);
            this.label_zamestnanec.TabIndex = 9;
            this.label_zamestnanec.Text = "Zaměstnanec:";
            // 
            // comboBox_vyberZamestnance
            // 
            this.comboBox_vyberZamestnance.FormattingEnabled = true;
            this.comboBox_vyberZamestnance.Location = new System.Drawing.Point(2378, 1272);
            this.comboBox_vyberZamestnance.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBox_vyberZamestnance.Name = "comboBox_vyberZamestnance";
            this.comboBox_vyberZamestnance.Size = new System.Drawing.Size(321, 38);
            this.comboBox_vyberZamestnance.TabIndex = 8;
            // 
            // button_otevriZoo
            // 
            this.button_otevriZoo.Location = new System.Drawing.Point(1941, 24);
            this.button_otevriZoo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_otevriZoo.Name = "button_otevriZoo";
            this.button_otevriZoo.Size = new System.Drawing.Size(324, 46);
            this.button_otevriZoo.TabIndex = 10;
            this.button_otevriZoo.Text = "Otevři Zoo";
            this.button_otevriZoo.UseVisualStyleBackColor = true;
            this.button_otevriZoo.Click += new System.EventHandler(this.button_otevriZoo_Click);
            // 
            // button_zavriZoo
            // 
            this.button_zavriZoo.Location = new System.Drawing.Point(1941, 82);
            this.button_zavriZoo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_zavriZoo.Name = "button_zavriZoo";
            this.button_zavriZoo.Size = new System.Drawing.Size(324, 46);
            this.button_zavriZoo.TabIndex = 11;
            this.button_zavriZoo.Text = "Zavři Zoo";
            this.button_zavriZoo.UseVisualStyleBackColor = true;
            this.button_zavriZoo.Click += new System.EventHandler(this.button_zavriZoo_Click);
            // 
            // button_pridejNavstevnika
            // 
            this.button_pridejNavstevnika.Location = new System.Drawing.Point(1941, 140);
            this.button_pridejNavstevnika.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_pridejNavstevnika.Name = "button_pridejNavstevnika";
            this.button_pridejNavstevnika.Size = new System.Drawing.Size(324, 46);
            this.button_pridejNavstevnika.TabIndex = 12;
            this.button_pridejNavstevnika.Text = "Přidej návštěvníka";
            this.button_pridejNavstevnika.UseVisualStyleBackColor = true;
            this.button_pridejNavstevnika.Click += new System.EventHandler(this.button_pridejNavstevnika_Click);
            // 
            // panel_informaceOZoo
            // 
            this.panel_informaceOZoo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_informaceOZoo.Controls.Add(this.label1);
            this.panel_informaceOZoo.Controls.Add(this.label2);
            this.panel_informaceOZoo.Controls.Add(this.label_pocetZvirat_num);
            this.panel_informaceOZoo.Controls.Add(this.label_pocetZvirat);
            this.panel_informaceOZoo.Controls.Add(this.label_pocetNavstevniku_num);
            this.panel_informaceOZoo.Controls.Add(this.label_pocetNavstevniku);
            this.panel_informaceOZoo.Location = new System.Drawing.Point(1941, 262);
            this.panel_informaceOZoo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel_informaceOZoo.Name = "panel_informaceOZoo";
            this.panel_informaceOZoo.Size = new System.Drawing.Size(754, 432);
            this.panel_informaceOZoo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(247, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Počet návštěvníků: ";
            // 
            // label_pocetZvirat_num
            // 
            this.label_pocetZvirat_num.AutoSize = true;
            this.label_pocetZvirat_num.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_pocetZvirat_num.Location = new System.Drawing.Point(171, 68);
            this.label_pocetZvirat_num.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_pocetZvirat_num.Name = "label_pocetZvirat_num";
            this.label_pocetZvirat_num.Size = new System.Drawing.Size(32, 38);
            this.label_pocetZvirat_num.TabIndex = 3;
            this.label_pocetZvirat_num.Text = "0";
            // 
            // label_pocetZvirat
            // 
            this.label_pocetZvirat.AutoSize = true;
            this.label_pocetZvirat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_pocetZvirat.Location = new System.Drawing.Point(21, 68);
            this.label_pocetZvirat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_pocetZvirat.Name = "label_pocetZvirat";
            this.label_pocetZvirat.Size = new System.Drawing.Size(173, 38);
            this.label_pocetZvirat.TabIndex = 2;
            this.label_pocetZvirat.Text = "Počet zvířat: ";
            // 
            // label_pocetNavstevniku_num
            // 
            this.label_pocetNavstevniku_num.AutoSize = true;
            this.label_pocetNavstevniku_num.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_pocetNavstevniku_num.Location = new System.Drawing.Point(247, 26);
            this.label_pocetNavstevniku_num.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_pocetNavstevniku_num.Name = "label_pocetNavstevniku_num";
            this.label_pocetNavstevniku_num.Size = new System.Drawing.Size(32, 38);
            this.label_pocetNavstevniku_num.TabIndex = 1;
            this.label_pocetNavstevniku_num.Text = "0";
            // 
            // label_pocetNavstevniku
            // 
            this.label_pocetNavstevniku.AutoSize = true;
            this.label_pocetNavstevniku.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_pocetNavstevniku.Location = new System.Drawing.Point(21, 26);
            this.label_pocetNavstevniku.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_pocetNavstevniku.Name = "label_pocetNavstevniku";
            this.label_pocetNavstevniku.Size = new System.Drawing.Size(252, 38);
            this.label_pocetNavstevniku.TabIndex = 0;
            this.label_pocetNavstevniku.Text = "Počet návštěvníků: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2083, 802);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2829, 1764);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_informaceOZoo);
            this.Controls.Add(this.button_pridejNavstevnika);
            this.Controls.Add(this.button_zavriZoo);
            this.Controls.Add(this.button_otevriZoo);
            this.Controls.Add(this.label_zamestnanec);
            this.Controls.Add(this.comboBox_vyberZamestnance);
            this.Controls.Add(this.panel_Zoo);
            this.Controls.Add(this.label_vyberVybeh);
            this.Controls.Add(this.comboBox_vyberVybeh);
            this.Controls.Add(this.button_vygenerujZamestnance);
            this.Controls.Add(this.button_generujZviratka);
            this.Controls.Add(this.button_pridejVybeh);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_informaceOZoo.ResumeLayout(false);
            this.panel_informaceOZoo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_pridejVybeh;
        private Button button_generujZviratka;
        private Button button_vygenerujZamestnance;
        private ComboBox comboBox_vyberVybeh;
        private Label label_vyberVybeh;
        private Panel panel_Zoo;
        private Label label_zamestnanec;
        private ComboBox comboBox_vyberZamestnance;
        private Button button_otevriZoo;
        private Button button_zavriZoo;
        private Button button_pridejNavstevnika;
        private Panel panel_informaceOZoo;
        private Label label1;
        private Label label2;
        private Label label_pocetZvirat_num;
        private Label label_pocetZvirat;
        private Label label_pocetNavstevniku_num;
        private Label label_pocetNavstevniku;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}