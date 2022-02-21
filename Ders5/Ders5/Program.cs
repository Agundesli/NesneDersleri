using System;
using System.Collections;
using System.Threading;

namespace Ders5
{
    interface IYuzebilir
    {
        void Yuz();
    }
    interface IYuruyebilir
    {
        void Yuru();
    }
    interface IUcabilir
    {
        void Uc();
    }
    class Penguen : IYuruyebilir, IYuzebilir
    {
        public void Yuru()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
    class Kanarya : IUcabilir, IYuruyebilir
    {
        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Yuru()
        {
            throw new NotImplementedException();
        }
    }
    class Pelikan : IYuzebilir, IYuruyebilir, IUcabilir
    {
        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Yuru()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
    class Hamsi : IYuzebilir
    {
        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
    class Kedi : IYuruyebilir
    {
        public void Yuru()
        {
            throw new NotImplementedException();
        }
    }


    interface IArayuz
    {
         void IslemA();
    }
    class Deneme:IArayuz
    {
        public void IslemA()
        {

        }
        public void MetotA()
        {

        }
    }
    class Depo:IEnumerable
    {
        string[] _urunler = { "Urun1", "Urun2", "Urun3", "Urun4" };

        public IEnumerator GetEnumerator()
        {
            return _urunler.GetEnumerator();
        }
    }
    public enum Gunler {none, Pazartesi,Salı,Çarşamba,Perşembe,Cuma,Cumartesi,Pazar}
    class Hafta
    {
        public Gunler izin { get; set; }
    }
    public interface IBoyanabilir
    {
    }
    class Boyahane
    {
        public void Boya(IBoyanabilir _arac,ConsoleColor _yeniRenk)
        {
            Araç araç = (Araç)_arac;
            araç.Renk = _yeniRenk;
            Console.ForegroundColor = araç.Renk;
            Console.WriteLine(araç.GetType().Name+"Boyandı.. ");
        }
      
    }
    abstract class Araç
    {
        public ConsoleColor Renk { get; set; }
        public Araç()
        {

            Random random = new Random();
            Thread.Sleep(100);
            Renk = (ConsoleColor)random.Next(1, 15);
        }
    }
    class Ferrari:Araç,IBoyanabilir
    {
        public Ferrari()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("Ferrari");
        }
    }
    class Mustang:Araç,IBoyanabilir
    {
        public Mustang()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("Mustang");
        }
    }
    class BMX:Araç
    {
        public BMX()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("BMX");
        }
    }

























    class Program
    {
        static void Main(string[] args)
        {
            //Deneme deneme = new Deneme();
            //IArayuz deneme2 = new Deneme();
            //Depo depo = new Depo();
            //string str = "Deneme";
            //foreach (var s  in depo)
            //{
            //    Console.WriteLine(s);
            //}
            //**********************************************************************************************
            //    ArrayList arrayList = new ArrayList();
            //    arrayList.AddRange()//ICollection interface ini implememte eden herhangibir şey gelebilir
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
            //***********************************************************************************************

            //Ferrari ferrari = new Ferrari();
            //Mustang mustang = new Mustang();
            //BMX bMX = new BMX();

            //Boyahane boyahane = new Boyahane();
            //boyahane.Boya(ferrari, ConsoleColor.Red);
            //boyahane.Boya(mustang, ConsoleColor.Green);

            //boyahane.Boya(bMX)

            //***********************************************************************************************
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Penguen());
            arrayList.Add(new Pelikan());
            arrayList.Add(new Hamsi());
            arrayList.Add(new Kedi());
            arrayList.Add(new Kanarya());
            foreach (object obj in arrayList)
            {
                if (obj is IYuruyebilir)
                {
                    Console.WriteLine(obj.ToString());
                }
            }
            Console.WriteLine("----------------------------------------------");
            foreach (object ob in arrayList)
            {
                if (ob is IUcabilir)
                {
                    Console.WriteLine(ob.ToString());
                }
            }
        }
    }
    public enum Siralama { Idyegöre=1,Adagöre=2,Fiyatagöre=3};
    class Karsilastir : IComparer
    {
        public Siralama Sirala { get; set; }
        public int Compare(object x, object y)
        {
            Product p1 = (Product)x;
            Product p2 = (Product)y;

            if (Sirala==Siralama.Idyegöre)
            {
                return p1.ProId.CompareTo(p2.ProId);
            }
            else if(Sirala==Siralama.Adagöre)
            {
                return p1.ProName.CompareTo(p2.ProName);
            }
            else  
            {
                return p1.Price.CompareTo(p2.Price);
            }
        }
    }
    class Urun:IComparable
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public int CompareTo(object obj)
        {
            Urun urun = (Urun)obj;
            return -1*UrunId.CompareTo(urun.UrunId);//*-1 tersten sırala
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
            return ProId+" "+ ProName+" " + Price;
        }
    }
}
