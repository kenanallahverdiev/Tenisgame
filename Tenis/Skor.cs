using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Tenis
{
    struct Kisi
    {
       public string ad;
       public int saniye;
       public int dakika;
       public int Toplam_saniye;
    };

    class Skor
    {

        public static StreamWriter SkorYaz;
        public static StreamReader SkorOku;
         

      public static Kisi[] kisiler;
      public static Kisi degistir;




        public Skor()
        {
            degistir = new Kisi();
            kisiler = new Kisi[6];
            Oku();
        }




        public static  bool BilgileriAl(string ad, int dakika, int saniye)
        {

            kisiler[5].ad = ad;
            kisiler[5].saniye = saniye;
            kisiler[5].dakika = dakika;


            ToplamHesapla();

            for (int i = 0; i < 4; i++)
            {
                if (kisiler[5].Toplam_saniye > kisiler[i].Toplam_saniye)
                {
                    

                    return true;
                }
              
            }
            return false;
           
        }


        public static void Kaydet()
        {
            if (File.Exists("PUAN.txt")==false)
            {
                Sifirla();
            }
            File.Delete("PUAN.txt");
            SkorYaz = File.AppendText("PUAN.txt");
            for (int i = 0; i < 5; i++)
            {
                SkorYaz.WriteLine(kisiler[i].ad);
                SkorYaz.WriteLine(kisiler[i].dakika);
                SkorYaz.WriteLine(kisiler[i].saniye);
            }
            SkorYaz.Close();
        }
        public static void Oku()
        {
            if (File.Exists("PUAN.txt")==false)
            {
                Kaydet();
            }
            SkorOku = File.OpenText("PUAN.txt");
            for (int i = 0; i < 5; i++)
            {
                kisiler[i].ad = SkorOku.ReadLine();

                kisiler[i].dakika = Convert.ToInt16(SkorOku.ReadLine());
                kisiler[i].saniye = Convert.ToInt16(SkorOku.ReadLine());
            }
            SkorOku.Close();
        }
        public static void Degistir(int veri1, int veri2)
        {
            degistir.ad = kisiler[veri1].ad;
            degistir.dakika = kisiler[veri1].dakika;
            degistir.saniye = kisiler[veri1].saniye;

            kisiler[veri1].ad = kisiler[veri2].ad;
            kisiler[veri1].dakika = kisiler[veri2].dakika;
            kisiler[veri1].saniye = kisiler[veri2].saniye;

            kisiler[veri2].ad = degistir.ad;
            kisiler[veri2].dakika = degistir.dakika;
            kisiler[veri2].saniye = degistir.saniye;
        }
    public static    void Sirala()
        {
            ToplamHesapla();
           
            for (int i = 0; i < 6; i++)
            {
                ToplamHesapla();
                for (int j = 0; j < 5; j++)
                {
                    if (kisiler[j+1].Toplam_saniye>kisiler[j].Toplam_saniye)
                    {
                        Degistir(j+1,j);
                    }
                }
            }
        }
    public static void Sifirla()
        {
            for (int i = 0; i < 6; i++)
            {
                kisiler[i].ad = "BOS";
                kisiler[i].dakika = 0;
                kisiler[i].saniye = 0;
            }
        }
    public static void ToplamHesapla()
        {
            for (int i = 0; i < 6; i++)
            {
                kisiler[i].Toplam_saniye = kisiler[i].dakika * 60 + kisiler[i].saniye;

            }
        }

    }


}
