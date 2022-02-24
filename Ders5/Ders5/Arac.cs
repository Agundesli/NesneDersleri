using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static Ders5.Interfaces;

namespace Ders5
{
     abstract class Arac
    {
        public ConsoleColor Renk { get; set; }
        public Arac()
        {
            Random random = new Random();
            Thread.Sleep(100);
            Renk = (ConsoleColor)random.Next(1, 15);
        }
    }
     class Boyahane
    {
        public void Boya(Arac _arac, ConsoleColor _renk)
        {
            Arac arac = (Arac)_arac;
            arac.Renk = _renk;
            Console.ForegroundColor = arac.Renk;
            Console.WriteLine(arac.GetType().Name+"Boyandı");
        }
    }
     class Ferrari:Arac,IBoyahane
    {
        public Ferrari()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("Ferrari");
        }
    }
     class Mustang:Arac,IBoyahane
    {
        public Mustang()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("Mustang");
        }
    }
     class BMX : Arac
    {
        public BMX()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("BMX");
        }
    }
}

