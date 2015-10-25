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
            ConsoleKey key = ConsoleKey.H;
            Boolean dilHatasi = true;
            do
            {
                Console.WriteLine("lutfen dil seçiniz / please select the language");
                Console.WriteLine("Türkçe için 't', for English press 'e'");
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.E || key == ConsoleKey.T)
                {
                    dilHatasi = false;
                }
            }
            while (dilHatasi == true);
            if (key == ConsoleKey.T)
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
            else
            {
                var cevap = ConsoleKey.R;
                int GirilenSayi = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to 'Guess the number' game");
                    Console.WriteLine("You have 10 guess to find the number. Lets play.");
                    int tahminSayısı = 0;
                    Random rnd = new Random();
                    int RandomSayi = rnd.Next(100);
                    do
                    {
                        Boolean HataliSayi = true;
                        do
                        {
                            Console.WriteLine((tahminSayısı + 1) + ". guess");
                            try
                            {
                                GirilenSayi = Convert.ToInt32(Console.ReadLine());
                                HataliSayi = false;
                                tahminSayısı++;
                            }
                            catch (Exception exp)
                            {
                                Console.WriteLine("Please enter valid number");
                            }
                        }
                        while (HataliSayi == true);
                        if (tahminSayısı == 10)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Game Over!! You have reached the guess limit. ;((((");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (RandomSayi > GirilenSayi && RandomSayi != GirilenSayi)
                        {
                            Console.WriteLine("Please enter bigger number");
                        }
                        else if (RandomSayi < GirilenSayi && RandomSayi != GirilenSayi)
                        {
                            Console.WriteLine("Please enter smaller number");
                        }
                    }
                    while (RandomSayi != GirilenSayi && tahminSayısı < 10);
                    if (tahminSayısı < 10)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("******** Congratzz " + tahminSayısı + ". You are the winner *********");
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("To play again please press 'R'. To end the game press any key.");
                    cevap = Console.ReadKey().Key;
                    Console.WriteLine();
                }
                while (cevap == ConsoleKey.R);
                Console.ReadLine();
            }
        }
    }
}
