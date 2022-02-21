using System;
using System.Collections;

namespace Ders4
{
    class Program
    {
        class Araba
        {
            public virtual void Sur()
            {
                Console.WriteLine("Araba Sür...");
            }
        }
        class Ferrari:Araba
        {
            public override void Sur()
            {
                Console.WriteLine("Ferrari Sür...");
            }
        }

        class Mercedes:Araba
        {
            public override void Sur()
            {
                Console.WriteLine("Mercedes Sür...");
            }
        }
        class Personel
        {
            public int PerId { get; set; }
            public string PerAdi { get; set; }
            public override string ToString()
            {
                return PerId + " " + PerAdi;
            }
        }

        class Musteri
        {
            public int MusId { get; set; }
            public string MusAdi { get; set; }
            public override string ToString()
            {
                return MusId + " " + MusAdi;
            }
        }

        //class Daire
        //{
        //    public Daire(double r)
        //    {
        //        this.r = r;
        //    }

        //    public double r { get; set; }
        //    public virtual double Alan()
        //    {

        //        return Math.PI * r * r;
        //    }
        //}
        //class Silindir : Daire
        //{
        //    public double h { get; set; }
        //    public Silindir(double _h,double r):base(r)
        //    {
        //        this.h = _h;
        //    }
        //    public override double Alan()
        //    {
        //        return base.Alan() * h;
        //    }
        //}

        //class Koni:Silindir
        //{
        //    public Koni(double r, double h) : base(r, h)
        //    {
               
        //    }
        //    public override double Alan()
        //    {
        //        return base.Alan()/3;
        //    }
        //}
        static void Main(string[] args)
        {
            //PollyMorfizim: aynı metodun farklı sınıflarda aynı işi yapması

            //Araba araba = new Araba();
            //Ferrari ferrari = new Ferrari();
            //Mercedes mercedes = new Mercedes();

            Araba araba = new Araba();
            Araba ferrari = new Ferrari();
            Araba mercedes = new Mercedes();


            araba.Sur();
            ferrari.Sur();
            mercedes.Sur();


            //Object obj = new Ferrari();
            //((Ferrari)obj).Sur();

            Personel personel = new Personel { PerAdi="Abdullah", PerId=1 };//object ini...
            Musteri musteri = new Musteri{ MusAdi="Usame", MusId=2 }; 
            Console.WriteLine(personel);
            Console.WriteLine(musteri);
            
            Object obj = new object();
            Console.WriteLine(obj);

            ArrayList liste = new ArrayList();
            for (int i = 0; i < 2; i++)
            {
                liste.Add(12);
                
            }
            Console.WriteLine(liste.Count);
            Console.WriteLine(liste.Capacity);
            Console.WriteLine("Adet={0} Kapasite={1}",liste.Count, liste.Capacity);
            Console.WriteLine($"Adet={liste.Count} Kapasite={liste.Capacity}");

            //liste[2] = "12";
            
            Stack stack = new Stack();
            stack.Push(12);
            stack.Push(52);
            stack.Push(2);

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            Queue queue = new Queue();
            queue.Enqueue(12);
            queue.Enqueue(22);
            queue.Enqueue(32);
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(34, "İstanbul");
            //hashtable.Add(06, "Ankara");
            //Console.WriteLine(hashtable[06]);


            SortedList sortedList = new SortedList();
            sortedList.Add(34, "İst");
            sortedList.Add(06, "Ank");
            Console.WriteLine(sortedList.GetByIndex(0));

            sortedList
        }
    }
}
