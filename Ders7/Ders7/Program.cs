using System;
namespace Ders7
{
    class Program
    {
        delegate void Temsilci();
        static public void Mesaj()
        {
            Console.WriteLine("Mesaj");
        }
        static public void Gunaydin()
        {
            Console.WriteLine("Gunaydın");
        }
        static public void Merhaba(string str)
        {
            Console.WriteLine("Merhaba"+str);
        }
        static public string Hi()
        {
            return Hi();
        }
        static void Main(string[] args)
        {   //Temsilci metotları taşımak için kullanılır. Fonksiyon pointer= fonk. adresi tutuyor.
            //c# da ki gelege koleksiyon yani bir veya birden fazla metodu taşımada kullanılır.
            //hangi metotları taşır: imzası(parametre sayısı ve parametre tipi)  ve return type aynı olan metotları taşır,tutar.
            //(overload) metotların imzaları farklı olmak şartı ile n tane metot yazabilirim
            //Function<>,Actionc<> ana 2 delege
            Temsilci temsilci = new Temsilci(Mesaj);
            temsilci += Gunaydin;
            temsilci += Mesaj;
            //temsilci += Hi;//return type yanlış
            //temsilci += Merhaba;//return type yanlış
            temsilci();
            //temsilci -= Mesaj;
            Console.WriteLine("------------------------------------------------");
           // temsilci();
            Console.WriteLine("------------------------------------------");
            foreach (Delegate item in temsilci.GetInvocationList())
            {
                //q2wConsole.WriteLine(item.Method.Name);
                if (item.Method.Name != "Mesaj") 
                {
                    item.DynamicInvoke();
                }
            } 
        }
    }
}
