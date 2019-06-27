using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenis
{
    public partial class Y_Skor : Form
    {
        Form NesneTut;
        public int dakika;
       public int saniye;
      
      
        public Y_Skor()
        {
          

                InitializeComponent();
            button1.Click += button1_Click;
        }

        void button1_Click(object sender, EventArgs e)
        {
            Skor.BilgileriAl(textBox1.Text,dakika,saniye);
            Skor.Sirala();
            Skor.Kaydet();


            NesneTut.Close();
           


        }
        public void FormAc()
        {


            InitializeComponent();
            NesneTut.Show();
           
        }
    }
}
