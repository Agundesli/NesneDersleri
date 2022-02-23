using System;
using System.Collections;

namespace Ders4
{
    class Program
    {
        static void Main(string[] args)
        {
            //PollyMorfizim: aynı metodun farklı sınıflarda aynı işi yapması

            Car araba1 = new Car();
            Ferrari ferrari1 = new Ferrari();
            Mercedec mercedes1 = new Mercedec();

            Car araba = new Car();
            Car ferrari = new Ferrari();
            Car mercedes = new Mercedec();


            araba.Sur();
            ferrari.Sur();
            mercedes.Sur();


            Object obj = new Ferrari();
            ((Ferrari)obj).Sur();

            Personel personel = new Personel { peradi="Abdullah", perıd=1 };//object ini...
            Musteri musteri = new Musteri{ MusAdi="Usame", MusId=2 }; 
            Console.WriteLine(personel);
            Console.WriteLine(musteri);

            Perso personel1 = new Perso() { PerAdi = "Usame", PerId = 4 };
            Musto musteri1 = new Musto() { MusAdi = "Yusuf", MusId = 5 };
            Console.WriteLine(personel1);
            Console.WriteLine(musteri1);

            Object obj1 = new object();
            Console.WriteLine(obj1);

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
            Console.WriteLine("********************************************************************");
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine("*******************************************************************");
            Queue queue = new Queue();
            queue.Enqueue(12);
            queue.Enqueue(22);
            queue.Enqueue(32);

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine("*******************************************************************");
            Hashtable hashtable = new Hashtable();
            hashtable.Add(34, "İstanbul");
            hashtable.Add(06, "Ankara");
            Console.WriteLine(hashtable[06]);

            Console.WriteLine("**********************************************************************");
            SortedList sortedList = new SortedList();
            sortedList.Add(34, "İst");
            sortedList.Add(06, "Ank");
            Console.WriteLine(sortedList.GetByIndex(0));

            //sortedList;
        }
    }
}
