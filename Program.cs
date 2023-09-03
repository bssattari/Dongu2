using System;

namespace Dongu2
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                Console
                    .WriteLine("{0}. kez döngü içerisindeki tekrarlanan içerik",
                    (i + 1));
                Console
                    .WriteLine((i + 1) +
                    ". kez döngü içerisindeki tekrarlanan içerik");

                Console.Write((i + 1));
                Console
                    .WriteLine(". kez döngü içerisindeki tekrarlanan içerik");
            }

            */
            Random rnd = new Random();
            int[] sayilar = new int[6];
            Console.WriteLine("Burası For İle Yazdırıldı");


            for (int i = 0; i < sayilar.Length; i++)
                sayilar[i] = rnd.Next(1, 59);
            {
                if (sayilar[i] %2==0)
                {

                    Console.WriteLine(sayilar[i]);

                }
                else
                    Console.WriteLine("Burası Foreach İle Yazdırıldı");

                foreach (var sayi in sayilar)
                {
                    Console.WriteLine(sayi);
                }

                Console.WriteLine("Burası While İle Yazdırıldı");

                int j = 0;
                while (j < sayilar.Length)
                {
                    Console.WriteLine(sayilar[j]);
                    j++;
                }
            }
        }
    }
}


                    



            //for (int i = 0; i < sayilar.Length; i++)


            /*

            Console.WriteLine("Burası continue sonrası");
            */


           

            /*while (true)
            {
                Console.WriteLine("Burası Sonsuz Kez Tekrarlanacak");
            }
            */

