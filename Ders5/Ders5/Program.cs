using Ders5;
using System;
using System.Collections;
using System.Threading;
using static Ders5.Interfaces;

namespace Ders5
{
    public enum Gunler { none, Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar }
    class Hafta
    {
        public Gunler izin { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList();
            list1.Add(new Pelikan());
            list1.Add(new Hamsi());
            list1.Add(new Kedi());
            list1.Add(new Penguen());
            list1.Add(new Kanarya());
            Console.WriteLine("All Animals");
            Console.WriteLine("**********************************");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("All Fly");
            Console.WriteLine("**********************************");
            foreach (var item in list1)
            {
                if (item is IUcabilir)
                {
                    Console.WriteLine(item);
                }
            }
            Deneme deneme = new Deneme();
            deneme.IslemA();
            deneme.IslemB();
            MetotA metotA = new Deneme();
            metotA.IslemA();
            //metotA.IslemB();//IslemB deneme classına ait ınterface deneme classının referansını tutabilir ama metot,prop vs tutamaz.
            
            
            Arac ferrari = new Ferrari();
            Arac mercedes = new Mustang();
            Arac bmx = new BMX();
            Boyahane boyahane = new Boyahane();



            boyahane.Boya(ferrari, ConsoleColor.Red);
            boyahane.Boya(mercedes, ConsoleColor.Green);
            boyahane.Boya(bmx, ConsoleColor.Gray);
            Depo depo = new Depo();
            foreach (var item in depo)
            {
                Console.WriteLine(item);
            }


            ArrayList arrayList = new ArrayList();
            arrayList.AddRange()//ICollection interface ini implememte eden herhangibir şey gelebilir

            //Deneme deneme = new Deneme();
            //IArayuz deneme2 = new Deneme();
            //Depo depo = new Depo();
            //string str = "Deneme";
            //foreach (var s  in depo)
            //{
            //    Console.WriteLine(s);
            //}
            //**********************************************************************************************

            //**********************************************************************************************
            //ArrayList arrayList = new ArrayList() { 45,33,56,4,22,17};
            //arrayList.Sort();
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //*********************************************************************************************
            //ArrayList arrayList1 = new ArrayList() { "Zonguldak", "Ankara", "Adana", "Niğde" };
            //arrayList1.Sort();
            //foreach (var item in arrayList1)
            //{
            //    Console.WriteLine( item);
            //}
            //*********************************************************************************************
            //ArrayList arrayList2 = new ArrayList()
            //{
            //    new Urun{ UrunId=2, UrunAdi="Kalem", Fiyat=20 },
            //    new Urun{ UrunId=14, UrunAdi="Defter", Fiyat=25 },
            //    new Urun{ UrunId=5, UrunAdi="Silgi", Fiyat=10 },
            //};
            //foreach (Urun item in arrayList2)
            //{
            //    Console.WriteLine(item);
            //}
            //***********************************************************************************************
            //ArrayList arrayList3 = new ArrayList()
            //{
            //    new Product{ ProId=2, ProName="Kalem", Price=20 },
            //    new Product{ ProId=14, ProName="Defter", Price=25 },
            //    new Product{ ProId=5, ProName="Silgi", Price=10 },
            //};
            //Karsilastir karsilastir = new Karsilastir();
            //karsilastir.Sirala = Siralama.Adagöre;
            //arrayList3.Sort(karsilastir);
            //foreach (Product item in arrayList3)
            //{
            //    Console.WriteLine(item);
            //}
            //***********************************************************************************************
            //Console.WriteLine((int)Gunler.Pazar);
            //Hafta hafta = new Hafta();
            //hafta.izin = Gunler.Cuma;
            //hafta.izin = (Gunler)1;

        }
    }
    public enum Siralama { Idyegöre = 1, Adagöre = 2, Fiyatagöre = 3 };
    class Karsilastir : IComparer
    {
        public Siralama Sirala { get; set; }
        public int Compare(object x, object y)
        {
            Product p1 = (Product)x;
            Product p2 = (Product)y;

            if (Sirala == Siralama.Idyegöre)
            {
                return p1.ProId.CompareTo(p2.ProId);
            }
            else if (Sirala == Siralama.Adagöre)
            {
                return p1.ProName.CompareTo(p2.ProName);
            }
            else
            {
                return p1.Price.CompareTo(p2.Price);
            }
        }
    }
    class Urun : IComparable
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public int CompareTo(object obj)
        {
            Urun urun = (Urun)obj;
            return -1 * UrunId.CompareTo(urun.UrunId);//*-1 tersten sırala
        }
        public override string ToString()
        {
            return UrunId + " " + UrunAdi + " " + Fiyat;
        }
    }
    class Product
    {
        public int ProId { get; set; }
        public string ProName { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return ProId + " " + ProName + " " + Price;
        }
    }
}
