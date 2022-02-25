using System;
using Genel;
namespace Ders9
{
    class Program
    {
        static void Main(string[] args)
        {
            Cebir cebir = new Cebir();

            Console.WriteLine(cebir.Kare(4)); ;
            Console.WriteLine(cebir.KupAl(cebir.Kare(4)));
        }
    }
}
