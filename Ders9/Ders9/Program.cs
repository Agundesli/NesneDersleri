using System;
using Genel;
using Kimya;
namespace Ders9
{
    class Program
    {
        static void Main(string[] args)
        {
            Cebir cebir = new Cebir();

            Console.WriteLine(cebir.Kare(4)); ;
            Console.WriteLine(cebir.KupAl(cebir.Kare(4)));
            OrganikKimya organikKimya = new OrganikKimya();
            organikKimya.KovalentBaglar();
            organikKimya.IyonikBaglar();
        }
    }
}
