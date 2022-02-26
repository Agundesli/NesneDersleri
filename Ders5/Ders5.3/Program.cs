using System;

namespace Ders5._3
{
    public enum Gunler : byte { none,Pazartesi,Sali,Carsamba,Persembe,Cuma,Cumartesi,Pazar};
    class Hafta
    {
        public Gunler Gun { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 16; i++)
            {
                Console.ForegroundColor = (ConsoleColor)i;
                Console.WriteLine("Merhaba");
            }
            Console.WriteLine((int)Gunler.Pazar);
            Hafta hafta = new Hafta();
            hafta.Gun = Gunler.Pazar;
            hafta.Gun = (Gunler)1;
        }
    }
}
