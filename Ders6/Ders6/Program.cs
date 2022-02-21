using System;
using System.Collections;
using System.Collections.Generic;

namespace Ders6
{
    abstract class Sekil
    {

    }
    class Kare:Sekil
    {

    }
    class Kup:Kare,IHacim
    {

    }

    class Ferrari
    {

    }
    class Cizim<T> where T : Sekil 
    {

    }
    interface IHacim
    {

    }
    class HacimHesapla<T> where T : Sekil { }
    class Deneme<T>
    {
        public void IslemA(T t)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            List<int> liste = new List<int>();
            DateTime basla, bitir;
            TimeSpan fark;

            basla = DateTime.Now;
            for (int i = 0; i < 9999999; i++)
            {
                arrayList.Add(i);
                int sayi =(int)arrayList[i];
            }
            bitir = DateTime.Now;
            fark = bitir - basla;
            Console.WriteLine("Arraylist: "+fark.TotalMilliseconds);


            basla = DateTime.Now;
            for (int i = 0; i < 9999999; i++)
            {
                liste.Add(i);
                int sayi = liste[i];
            }
            bitir = DateTime.Now;
            fark = bitir - basla;
            Console.WriteLine("liste: " + fark.TotalMilliseconds);




            ArrayList list1 = new ArrayList() { 1, 2, 3, 4, 5, 6,"on" };
            List<int> list2 = new List<int>(){ 1, 2, 3, 4, 5, 6 ,};//on
            int t = 0;
            foreach (int item in list1)
            {
                t =t+ item;
                Console.WriteLine(t);
            }
            int toplam = 0;
            foreach (int item in list2)
            {
                toplam += item;
                Console.WriteLine(toplam);
            }
            Cizim<Kare> c1 = new Cizim<Kare>();
            Cizim<Kup> c2 = new Cizim<Kup>();
            //Cizim<Ferrari> c3 = new Cizim<Ferrari>();

            HacimHesapla<Kare> hh1 = new HacimHesapla<Kare>();
            HacimHesapla<Kup> hh2 = new HacimHesapla<Kup>();


        }
    }
}
