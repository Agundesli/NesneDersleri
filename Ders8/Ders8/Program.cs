using System;
using System.Collections.Generic;

namespace Ders8
{
    delegate void Temsil();
    class Program
    {
        static bool TekSayiMi(int sayi)
        {
            return sayi % 2 == 1;
        }
        static void Yaz(List<int> sayilar)
        {
            foreach (var s in sayilar)
            {
                Console.WriteLine(s+" ");
            }
        }
        delegate int Temsilci();
        static public int MetotA()
        {
            return 4;
        }
        static public int MetotB()
        {
            return 5;
        }
        static public int MetotC()
        {
            return 1;
        }

        static void Main(string[] args)
        {
            Temsilci temsilci = new Temsilci(MetotA);
            temsilci += new Temsilci(MetotB);
            temsilci += MetotC;
            temsilci += MetotB;
            Console.WriteLine(temsilci());

            


            List<int> sayilar = new List<int>() { 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < sayilar.Count; i++)
            {
                if (sayilar[i]%2==1)
                {
                    Console.Write(sayilar[i]+" ");
                }
            }
            Console.WriteLine();
            //yöntem1
            Predicate<int> p = new Predicate<int>(TekSayiMi);
            Yaz(sayilar.FindAll(p));
            //yöntem2
            Yaz(sayilar.FindAll(TekSayiMi));
            //Anonim metot
            Temsil t = delegate ()
             {
                 Console.WriteLine("Anonim Metot");
             };
            t();
            //yöntem3
            Yaz(sayilar.FindAll( delegate (int s)
            {
                return s % 2 == 1;
            }));
            //yöntem4
            Console.WriteLine("---------------------------------------------");
            Yaz(sayilar.FindAll(s=>s%2==1));
        }
    }
}
