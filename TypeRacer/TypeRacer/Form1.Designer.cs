namespace TypeRacer
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
            this.panel_UI = new System.Windows.Forms.Panel();
            this.label_pocetSpravnychUhozu_Num = new System.Windows.Forms.Label();
            this.label_PocetUhozu_Num = new System.Windows.Forms.Label();
            this.label_CasDokonceni = new System.Windows.Forms.Label();
            this.button_GenerujVetu = new System.Windows.Forms.Button();
            this.label_pocetSpravnychUhozu = new System.Windows.Forms.Label();
            this.label_pocetUhozu = new System.Windows.Forms.Label();
            this.label_Text = new System.Windows.Forms.Label();
            this.timer_cas = new System.Windows.Forms.Timer(this.components);
            this.panel_UI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_UI
            // 
            this.panel_UI.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_UI.Controls.Add(this.label_pocetSpravnychUhozu_Num);
            this.panel_UI.Controls.Add(this.label_PocetUhozu_Num);
            this.panel_UI.Controls.Add(this.label_CasDokonceni);
            this.panel_UI.Controls.Add(this.button_GenerujVetu);
            this.panel_UI.Controls.Add(this.label_pocetSpravnychUhozu);
            this.panel_UI.Controls.Add(this.label_pocetUhozu);
            this.panel_UI.Location = new System.Drawing.Point(915, -3);
            this.panel_UI.Name = "panel_UI";
            this.panel_UI.Size = new System.Drawing.Size(433, 787);
            this.panel_UI.TabIndex = 0;
            // 
            // label_pocetSpravnychUhozu_Num
            // 
            this.label_pocetSpravnychUhozu_Num.AutoSize = true;
            this.label_pocetSpravnychUhozu_Num.Location = new System.Drawing.Point(258, 110);
            this.label_pocetSpravnychUhozu_Num.Name = "label_pocetSpravnychUhozu_Num";
            this.label_pocetSpravnychUhozu_Num.Size = new System.Drawing.Size(24, 30);
            this.label_pocetSpravnychUhozu_Num.TabIndex = 5;
            this.label_pocetSpravnychUhozu_Num.Text = "0";
            this.label_pocetSpravnychUhozu_Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_PocetUhozu_Num
            // 
            this.label_PocetUhozu_Num.AutoSize = true;
            this.label_PocetUhozu_Num.Location = new System.Drawing.Point(159, 80);
            this.label_PocetUhozu_Num.Name = "label_PocetUhozu_Num";
            this.label_PocetUhozu_Num.Size = new System.Drawing.Size(24, 30);
            this.label_PocetUhozu_Num.TabIndex = 4;
            this.label_PocetUhozu_Num.Text = "0";
            this.label_PocetUhozu_Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CasDokonceni
            // 
            this.label_CasDokonceni.AutoSize = true;
            this.label_CasDokonceni.Location = new System.Drawing.Point(29, 140);
            this.label_CasDokonceni.Name = "label_CasDokonceni";
            this.label_CasDokonceni.Size = new System.Drawing.Size(131, 30);
            this.label_CasDokonceni.TabIndex = 3;
            this.label_CasDokonceni.Text = "Celkový čas: ";
            // 
            // button_GenerujVetu
            // 
            this.button_GenerujVetu.Location = new System.Drawing.Point(31, 181);
            this.button_GenerujVetu.Name = "button_GenerujVetu";
            this.button_GenerujVetu.Size = new System.Drawing.Size(376, 40);
            this.button_GenerujVetu.TabIndex = 2;
            this.button_GenerujVetu.Text = "Generuj větu";
            this.button_GenerujVetu.UseVisualStyleBackColor = true;
            this.button_GenerujVetu.Click += new System.EventHandler(this.button_GenerujVetu_Click);
            // 
            // label_pocetSpravnychUhozu
            // 
            this.label_pocetSpravnychUhozu.AutoSize = true;
            this.label_pocetSpravnychUhozu.Location = new System.Drawing.Point(29, 110);
            this.label_pocetSpravnychUhozu.Name = "label_pocetSpravnychUhozu";
            this.label_pocetSpravnychUhozu.Size = new System.Drawing.Size(238, 30);
            this.label_pocetSpravnychUhozu.TabIndex = 1;
            this.label_pocetSpravnychUhozu.Text = "Počet správných úhozů: ";
            // 
            // label_pocetUhozu
            // 
            this.label_pocetUhozu.AutoSize = true;
            this.label_pocetUhozu.Location = new System.Drawing.Point(29, 80);
            this.label_pocetUhozu.Name = "label_pocetUhozu";
            this.label_pocetUhozu.Size = new System.Drawing.Size(133, 30);
            this.label_pocetUhozu.TabIndex = 0;
            this.label_pocetUhozu.Text = "Počet úhozů:";
            // 
            // label_Text
            // 
            this.label_Text.AutoSize = true;
            this.label_Text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_Text.Location = new System.Drawing.Point(35, 59);
            this.label_Text.Name = "label_Text";
            this.label_Text.Size = new System.Drawing.Size(68, 30);
            this.label_Text.TabIndex = 1;
            this.label_Text.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 784);
            this.Controls.Add(this.label_Text);
            this.Controls.Add(this.panel_UI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.panel_UI.ResumeLayout(false);
            this.panel_UI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_UI;
        private Label label_pocetSpravnychUhozu;
        private Label label_pocetUhozu;
        private Label label_Text;
        private Button button_GenerujVetu;
        private System.Windows.Forms.Timer timer_cas;
        private Label label_CasDokonceni;
        private Label label_pocetSpravnychUhozu_Num;
        private Label label_PocetUhozu_Num;
    }
}