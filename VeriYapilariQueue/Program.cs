using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Pideci pideci = new Pideci();

            Console.WriteLine("                           -------------------------------------------------------------------");
            Console.WriteLine("                           *************** ÖZ URFA PİDE UYGULAMASINA HOŞGELDİNİZ *************");
            Console.WriteLine("                           -------------------------------------------------------------------");

            while (true)
            {
                Console.WriteLine("");



                Console.WriteLine("1-Müşteri Eklemek İçin 1'e Basınız");
                Console.WriteLine("2-Kuyruğu Yazdırmak İçin 2'ye Basınız");
                Console.WriteLine("3-Pide Satmak İçin 3'e Basınız");
                Console.WriteLine("4-Kuyrukta Kaç Kişi Olduğunu Ögrenmek İçin 4'e Basınız");
                Console.WriteLine("5-Uygulamadan Çıkmak İçin 5'e Basınız");


                int secim = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                if (secim == 1)
                {
                    Console.Write("Kuyruğa Girecek Müşteri İsmini Giriniz:");
                    string musteriısmi = Console.ReadLine();
                    Console.Write("Kaç Adet Pide Almak İstersiniz:");
                    int pideadedi = Convert.ToInt32(Console.ReadLine());
                    Musteri musteri1 = new Musteri(musteriısmi, pideadedi);
                    pideci.KuyrugaGir(musteri1);

                    
                    DosyayaVeriYazma(musteri1);

                }
                else if (secim == 2)
                {
                    pideci.KuyruguYaz();
                }
                else if (secim == 3)
                {
                    pideci.PideSat();
                    pideci.KuyruguYaz();
                }
                else if (secim == 4)
                {
                    pideci.KuyruktakiKisiSayisi();
                }
                else if (secim == 5)
                {
                    Environment.Exit(0);
                }
            }

        }
        public static void DosyayaVeriYazma(Musteri musteri1)
        {
            String[] musteriler = { "Musteri Ismi: " + musteri1.ad + " Pide Adedi: " + musteri1.adet + " Ödenmesi Gereken Tutar: " + musteri1.adet * 5 };
            System.IO.File.AppendAllLines(@"..\VeriTabani.txt", musteriler);
        }
    }


}
