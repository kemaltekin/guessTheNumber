using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            

            var cevap = ConsoleKey.R;
            int GirilenSayi = 0;
            do
            {
                Console.Clear();
                 Console.WriteLine("TAHMİN OYUNUNA HOŞ GELDİNİZ");
            Console.WriteLine("10 tahmin hakkınız var");

                int tahminSayısı = 0;
                Random rnd = new Random();
                int RandomSayi = rnd.Next(100);
                do
                {

                    Boolean HataliSayi = true;
                    do
                    {
                        Console.WriteLine((tahminSayısı + 1) + ". tahmininizi giriniz");
                        try
                        {
                            GirilenSayi = Convert.ToInt32(Console.ReadLine());
                            HataliSayi = false;
                            tahminSayısı++;
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine("HATALİ GİRİŞ YAPTINIZ");

                        }


                    }
                    while (HataliSayi == true);
                    if (tahminSayısı == 10)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("tahmin hakkınız doldu kaybettiniz ;((((");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else if (RandomSayi > GirilenSayi && RandomSayi != GirilenSayi)
                    {
                        Console.WriteLine("daha büyük sayı giriniz");

                    }
                    else if (RandomSayi < GirilenSayi && RandomSayi != GirilenSayi)
                    {
                        Console.WriteLine("daha küçük sayı giriniz");

                    }

                }
                while (RandomSayi != GirilenSayi && tahminSayısı < 10);
                if (tahminSayısı < 10)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("******** TEBRİKLER SAYIYI " + tahminSayısı + ". Tahmininizde BULDUNUZ *********");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                
                Console.WriteLine("tekrar oynamak istiyorsanız 'R' harfine basınız");
                cevap = Console.ReadKey().Key;
                Console.WriteLine();
            }
            while (cevap == ConsoleKey.R);
            Console.ReadLine();
        }
    }
}
