using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;

            int[] dizi = new int[] { 10, 20, 30 };
            int[] dizi2 = new int[] { 100, 200, 300 };

            dizi = dizi2;
            dizi2[0] = 999;


            Console.WriteLine(dizi[0]);
        }
    }
}
