using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenis
{
    class YuksekSkorlariGoster:Form
    {
        Form NesneTut;
        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        public Label label6;
        public Label label7;
        public Label label8;
        public Label label9;
        public Button button1;
        public Label label10;

        public YuksekSkorlariGoster()
        {
            InitializeComponent();
        }
        public void FormuAc()
        {
            InitializeComponent();
            Skor.Oku();

            

            label1.Text = Skor.kisiler[0].ad;
            label2.Text = Skor.kisiler[1].ad;
            label3.Text = Skor.kisiler[2].ad;
            label4.Text = Skor.kisiler[3].ad;
            label5.Text = Skor.kisiler[4].ad;

            label10.Text = string.Format("{0:00}:{1:00}", Skor.kisiler[0].dakika, Skor.kisiler[0].saniye);
            label9.Text = string.Format("{0:00}:{1:00}", Skor.kisiler[1].dakika, Skor.kisiler[1].saniye);
            label8.Text = string.Format("{0:00}:{1:00}", Skor.kisiler[2].dakika, Skor.kisiler[2].saniye);
            label7.Text = string.Format("{0:00}:{1:00}", Skor.kisiler[3].dakika, Skor.kisiler[3].saniye);
            label6.Text = string.Format("{0:00}:{1:00}", Skor.kisiler[4].dakika, Skor.kisiler[4].saniye);

            NesneTut.Show();

        }
        public void InitializeComponent()
        {
            NesneTut = new Form();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            NesneTut.SuspendLayout();
            // 
            // label1
            //
         
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(41, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(41, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(41, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(41, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(182, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(182, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(182, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(182, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(182, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 26);
            this.label10.TabIndex = 5;
            this.label10.Text = "label10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "tamam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YuksekSkorlariGoster
            // 
           NesneTut.ClientSize = new System.Drawing.Size(325, 257);
           NesneTut.Controls.Add(this.button1);
           NesneTut.Controls.Add(this.label6);
           NesneTut.Controls.Add(this.label7);
           NesneTut.Controls.Add(this.label8);
           NesneTut.Controls.Add(this.label9);
           NesneTut.Controls.Add(this.label10);
           NesneTut.Controls.Add(this.label5);
           NesneTut.Controls.Add(this.label4);
           NesneTut.Controls.Add(this.label3);
           NesneTut.Controls.Add(this.label2);
           NesneTut.Controls.Add(this.label1);
           NesneTut.Name = "YuksekSkorlariGoster";
           NesneTut.Text = "Yüksek Skor Tablosu";
           NesneTut.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NesneTut.Close();
            InitializeComponent();
           
        }

        
    }
}
