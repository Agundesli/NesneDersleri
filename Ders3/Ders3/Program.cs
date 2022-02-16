using System;
using System.Collections.Generic;
using System.IO;

namespace Ders3
{
    class Store
    {
        private string[] _store = new string[10];

        public string this [int indis]
        {
            get { return _store[indis]; }
            set { _store[indis] = value; }
        }
    }

    static class VeriTabani
    {
        public static void Kaydet()//static class içindeki herşey static olmalıdır
        {
            VeriTabani.Kaydet();
            Baglan baglan = new Baglan();
            //baglan.//ConnectionString yok
            Baglan.ConnectionString("nfejfbej");

            int[] sayılar = { 45, 45, 78, 78 };
            //sayılar.sort//
            //Array.Sort
            //StreamWriter
        }
    }
    class Baglan
    {
        public static void ConnectionString(string str)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Store store = new Store();
            //store[0] = "Abdullah";

            //string strMessage = "Hello";
            //for (int i = 0; i < strMessage.Length; i++)
            //{
            //    Console.WriteLine(strMessage[i]);
            //}
            //Soldier soldier = new Soldier();
            //Er er = new Er();


            Daire daire = new Daire() { r = 3 };
            Console.WriteLine(daire.DaireAlan());

            Silindir silindir = new Silindir() { r = 3, h = 10 };//obhect initialize
            Console.WriteLine(silindir.SilindirAlan());

            Koni koni = new Koni() { r = 3, h = 10 };
            Console.WriteLine(koni.KoniAlan());



            Circle circle = new Circle(3);
            Console.WriteLine(circle.DaireAlan());

            Cylinder cylinder = new Cylinder(3, 10);
            Console.WriteLine(cylinder.SilindirAlan());

            Cone cone = new Cone(3, 10);
            Console.WriteLine(cone.KoniAlan());


            Personel personel = new Personel();
            Mudur mudur = new Mudur();


            //Sekil sekil = new Sekil();//abstract sınıf new edilemez

            _Say say = new _Say();
            _Say say1 = new _Say();
            _Say say2 = new _Say();

        }
    }

    class _Say
    {
       static int sayac = 0;
        public _Say()
        {
            sayac++;
            Console.WriteLine(sayac);
        }

        ~_Say()
        {
            sayac--;
            Console.WriteLine(sayac);
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





    class Personel
    {
        public Personel()
        {
            Console.WriteLine("Personel Sınıfı Oluştu");
        }

    }
    class Mudur : Personel 
    {
        public Mudur()
        {
            Console.WriteLine("Müdür Sınıfı Oluştu...");
        }
    }





    class Soldier
    {
        public int SicilNo { get; set; }
        public string Task { get; set; }
        protected void Islem()
        {

        }
    }
    class Er:Soldier
    {
        public Er()
        {
            
        }
    }

    class Circle 
    {
        protected double yc;
        public Circle(double r)
        {
            this.yc = r;
        }
        public double DaireAlan()
        {
            return Math.PI * yc * yc;
        }
    }
    class Cylinder :Circle
    {
        protected double yuk;
        public Cylinder(double r, double h) : base(r)
        {
            //this.yc = r;
            this.yuk = h;
        }
        public double SilindirAlan()
        {
            return base.DaireAlan() * yuk;
        }
    }
    class Cone:Cylinder
    {
        public Cone(double r,double _h):base(r,_h)
        {
            //this.yc = r;
            //this.yuk = h;
        }
        public double KoniAlan()
        {
            return base.SilindirAlan() / 3;
        }
    }
}
