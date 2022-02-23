using System;
using System.Collections.Generic;
using System.Threading;

namespace Ders8
{
    public delegate void DLG();
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
                Console.WriteLine(s + " ");
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
            Isıtıcı ısıtıcı = new Isıtıcı();
            ısıtıcı.Kabarcik += Isıtıcı_Kabarcik;
            ısıtıcı.SesCikar += Isıtıcı_SesCikar;
            ısıtıcı.Fokurda += Isıtıcı_Fokurda;
            ısıtıcı.Calistir();

           // Temsilci temsilci = new Temsilci(MetotA);
           // temsilci += new Temsilci(MetotB);
           // temsilci += MetotC;
           // temsilci += MetotB;
           // Console.WriteLine(temsilci());

           // List<int> sayilar = new List<int>() { 4, 5, 6, 7, 8, 9 };
           // for (int i = 0; i < sayilar.Count; i++)
           // {
           //     if (sayilar[i] % 2 == 1)
           //     {
           //         Console.Write(sayilar[i] + " ");
           //     }
           // }
           // Console.WriteLine();
           // //yöntem1
           // Predicate<int> p = new Predicate<int>(TekSayiMi);
           // Yaz(sayilar.FindAll(p));
           // //yöntem2
           // Yaz(sayilar.FindAll(TekSayiMi));
           // //Anonim metot
           // Temsil t = delegate ()
           //  {
           //      Console.WriteLine("Anonim Metot");
           //  };
           // t();
           // //yöntem3
           // Yaz(sayilar.FindAll(delegate (int s)
           //{
           //    return s % 2 == 1;
           //}));
           // //yöntem4
           // Console.WriteLine("---------------------------------------------");
           // //Yaz(sayilar.FindAll(s => s % 2 == 1));


            //Events: Aslında bir pattern'dir.
            //Amacı:Mekanızmayı kur ve çalışmasını izle.
            //Nasıl çalıacak? Bu mekanızmayı delege ile kuruyoruz. Evenrler class memberlarıdır
            //Console.WriteLine("--------------------------------------------------------------");
            //Buton buton = new Buton();
            //buton.Tikla += Buton_Tikla;
            //buton.Calistir();
        }

        private static void Isıtıcı_Fokurda()
        {
            Console.WriteLine("fokur");
        }

        private static void Isıtıcı_SesCikar()
        {
            Console.WriteLine("sssssssssssssssssssssssssss");
        }

        private static void Isıtıcı_Kabarcik()
        {
            Console.WriteLine("ooooooooooooooooooooooooooooooooooo");
        }

        private static void Buton_Tikla()
        {
            Console.WriteLine("Butona Tıklandı...");
        }
    }
    public class Isıtıcı
    {
        public int Isi { get; set; }
        public event DLG Kabarcik;
        public event DLG SesCikar;
        public event DLG Fokurda;
        public void Calistir()
        {
            for (int i = 0; i < 120; i++)
            {
                Thread.Sleep(50);
                Isi++;
                Console.WriteLine(i);
                if (Isi >= 30 && Isi < 50 && Kabarcik != null) 
                {
                    Kabarcik();
                }
                else if (Isi >= 50 && Isi < 110 && SesCikar != null)
                {
                    SesCikar();
                }
                else if (Isi >= 110 && Isi < 120 && Fokurda != null) 
                {
                    Fokurda();
                }
            }
        }
    }
}

    

