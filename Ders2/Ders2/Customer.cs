using System;
using System.Collections.Generic;
using System.Text;

namespace Ders2
{
    class Customer
    {
        public int CusId { get; set; }
        public string CusName { get; set; }
        public decimal ChequingAccount { get; set; }
    }
    //yukarıdaki class da ben tanımlamasamda default olarak bir ctor oluştu. Bu sınıfı ben new ile inşa edebilirim.
    //Ama parametreli var edemem çünkü parametreli ctor tanımlamadım
    class Customer1
    {
        public int CusId { get; set; }
        public string CusName { get; set; }
        public string Address { get; set; }


        //public Customer(string ad, string adres)
        //{
        //    MusAdi = ad;
        //    Adress = adres;
        //}
        public Customer1(string ad, string adres) : this(1, ad, adres)
        {

        }
        public Customer1(int id, string ad, string adres)
        {
            CusId = id;
            CusName = ad;
            Address = adres;
        }
     //yukarıdaki ise class da ben default olarak tanımlanan ctor'a müdahele ettim. Bu sınıfı ben new ile inşa edebilirim. ama benden parametre değerleri isteyecek. 
    }
}
