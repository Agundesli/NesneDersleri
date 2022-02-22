using System;
using System.Collections.Generic;
using System.IO;

namespace Ders3
{
    class Program
    {
        static void Main(string[] args)
        {
            Depo depo = new Depo();
            depo[0] = "Abdullah";
            Console.WriteLine(depo[0]);

            string strMessage = "Hello";
            for (int i = 0; i < strMessage.Length; i++)
            {
                Console.WriteLine(strMessage[i]);//Burada indexleyici var,
                                                 //string sınıfının içinde indexleyici olmasaydı zaten böyle kullanamzdık
            }

            Soldier soldier = new Soldier();
            Er er = new Er();
            


            Daire daire = new Daire() { r = 3 };
            Console.WriteLine("d: "+daire.DaireAlan());

            Silindir silindir = new Silindir() {r=3, h=10} ;//obhect initialize
            Console.WriteLine("s: "+silindir.SilindirAlan());

            Koni koni = new Koni() { r = 3, h = 10 };
            Console.WriteLine("k: "+koni.KoniAlan());

            Console.WriteLine("-----------------------------------------------------");

            Circle circle = new Circle(3) ;
            Console.WriteLine(circle.AlanHesap());

            Circle cyclinder = new Cyclinder(3,10);//obhect initialize
            Console.WriteLine(cyclinder.AlanHesap());

            Circle parcel = new Parcel(3,10);
            Console.WriteLine(parcel.AlanHesap());





            Personel personel = new Personel();
            Mudur mudur = new Mudur();


            //Sekil sekil = new Sekil();//abstract sınıf new edilemez

            _Say say = new _Say();
            _Say say1 = new _Say();
            _Say say2 = new _Say();

        }
    }

   abstract class Sekil
    {
        public string Renk { get; set; }
    }
    class _Dairee:Sekil
    {

    }
    class _Silindirr:_Dairee
    {

    }
    sealed class _Konii:_Silindirr
    {

    }
    //class _KesikKonii:_Konii//_Konii sealed olduğu için türetme vermez
    //{

    //}
}
