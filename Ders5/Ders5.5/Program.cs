using System;
using System.Threading;

namespace Ders5._5
{
    public interface IBoyanabilir
    {

    }
    class Boyahane
    {
        public void Boya(IBoyanabilir _arac,ConsoleColor _yeniRenk)
        {
            Arac arac = (Arac)_arac;
            arac.Renk = _yeniRenk;
            Console.ForegroundColor = arac.Renk;
            Console.WriteLine(arac.GetType().Name+" boyandi...");
        }
    }
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
    class Ferrari : Arac, IBoyanabilir
    {
        public Ferrari()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("Ferrari");
        }
    }
    class Mercedes:Arac,IBoyanabilir
    {
        public Mercedes()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("Mersedes");
        }
    }
    class BMX:Arac
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
            IBoyanabilir ferrari = new Ferrari();
            IBoyanabilir mercedes = new Mercedes();
            Arac bmx = new BMX();

            Boyahane boyahane = new Boyahane();
            boyahane.Boya(ferrari, ConsoleColor.Red);
            boyahane.Boya(mercedes, ConsoleColor.Yellow);
            boyahane.Boya(bmx, ConsoleColor.Blue);

            Arac ferrari1 = new Ferrari();
            Arac mercedes1 = new Mercedes();

            boyahane.Boya(ferrari1, ConsoleColor.Black);

        }
    }
}
