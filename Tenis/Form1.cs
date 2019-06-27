using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Tenis
{
    public partial class Form1 : Form
    {
        Skor skor;
        Y_Skor ykr_skr;
        YuksekSkorlariGoster Y_SkorlariGoster;
        public Form1()
        {
            Y_SkorlariGoster = new YuksekSkorlariGoster();
            skor = new Skor();
            ykr_skr = new Y_Skor();
            InitializeComponent();
            MouseMove += Form1_MouseMove;
            KeyDown += Form1_KeyDown;
            timer1.Interval = 1;
            timer2.Interval = 1000;
            MouseDown += Form1_MouseDown;
            top.Visible = false;
            //Oyun karakteri,характеристики игры


        }

        void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Click_sayisi == 0)
            {
                label2.Text = string.Format("{0:00} : {1:00}", Dakika, Saniye);
                timer1.Start();
                label3.Visible = false;
                timer2.Start();
                top.Visible = true;
                top.Location = new Point(raket.Location.X + raket.Width / 2 - top.Width / 2, raket.Location.Y - top.Height);
                Click_sayisi++;
            }
        }//Oyunu baslanğıc kısmı,обзор начала игры,таймеры и тд...

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Application.Exit(); } 
        }

        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (raket.Kotrol(this.Width, e.X) == true)
                raket.Location = new System.Drawing.Point(e.X-(raket.Width/2),this.Height-70);
            //mausun raketle kontrolu,ставим функцию чтоб середина ракеты двигалась с мышкой.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {//topun karakter kismi,характеристика мяча,где куда и как будет вести себя.
          

             if (top.Location.X <= 0)
                top.hiz_X *= -1;

             if (top.Location.X + top.Width >= this.Width - 10)
                top.hiz_X *= -1;

             if (top.Location.Y <= 59)
                top.hiz_Y *= -1;

             if (top.Location.X + top.Width / 2 >= raket.Location.X && top.Location.X + top.Width / 2 <= raket.Location.X + raket.Width && top.Location.Y + top.Height >= this.Height - 70)
             {
                 top.hiz_Y *= -1;
                 top.hiz_X += top.hiz_X / 10;
                 top.hiz_Y += top.hiz_Y / 10;
                 SystemSounds.Beep.Play();
             }

            else if (top.Location.Y + top.Height >= this.Height - 60)
            {
                timer1.Stop();
                label3.Visible = true;
                timer2.Stop();
                Cursor.Show();
                top.Visible = false;
                Click_sayisi = 0;
                top.hiz_X = 3;
                top.hiz_Y = -3;
                SystemSounds.Hand.Play();
                //oyun bitis kismi,конец игры,характеристики ее
               
                ykr_skr.dakika = Dakika;
                ykr_skr.saniye = Saniye;

                if (Skor.BilgileriAl("12345", Dakika, Saniye))
                {
                    ykr_skr.FormAc();

                }

                Dakika = 0;
                Saniye = 0;
            }
          
            top.Location = new System.Drawing.Point(top.Location.X+(int)top.hiz_X,top.Location.Y+(int)top.hiz_Y );//sürekli yeni konuma çiziliyor
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Saniye++;

            if (Saniye == 60)
            {
                Saniye = 0;
                Dakika++;
            }
            if (Dakika == 60)
            {
                Dakika = 0;
            }
            label2.Text = string.Format("{0:00} : {1:00}",Dakika,Saniye);
        }//tablo uzerindeki taymer,время на табло,ее характеристики

        private void button1_Click(object sender, EventArgs e)
        {


            Y_SkorlariGoster.FormuAc();
         
            //buton kismin karakteri,basdigimizda skorlari goruyoruz
        }

       


       

       

    
    }
}
