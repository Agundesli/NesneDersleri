using System;

namespace Ders2
{
     class Program
     {
        static void Main(string[] args)
        {
            Personel personel = new Personel();
            personel.PerId = 1;
            personel.PerName = "Abdullah";
            personel.Salary = 123;
             //parametresiz çalıştı



            Personel personel1 = new Personel(12, "Okan", 123);
            //parametreli çalıştı

            Personel personel2 = new Personel()
            {
                PerId = 2,
                PerName = "Usame",
                Salary = 4555
            };
            //parametresiz çalıştı

            Personel personel3 = new Personel();
            //parametresiz çalıştı


            Customer customer = new Customer { CusId = 23, CusName = "Abdullah", ChequingAccount = 123 };
            Customer customer1 = new Customer() { CusId = 23, CusName = "Abdullah", ChequingAccount = 123 };//.object inisilation
            Customer customer2 = new Customer();
            Customer customer3 = new Customer
            {
                CusId = 23,
                CusName = "Abdullah",
                ChequingAccount = 123
            };


            Customer1 c1 = new Customer1(12, "fdhufh", "bdjb");
            //Customer1 c2 = new Customer1();

            //Automobile arac = new Automobile("12sa12");
            Automobile arac1 = new Automobile();
            arac1.Plaka = "fgfd";

            Automobile arac2 = new Automobile() { Plaka = "hgruıgh" };

            Automobile arac3 = new Automobile
            {
                Plaka = "gfgıjf"
            };

        }
     }
}
