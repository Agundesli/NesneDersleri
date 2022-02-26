using System;
using SDK;
namespace BuyukHarfeCevir
{
    public class BuyukHarfeCevir : ISDK
    {
        public string EklentiAdi =>"Buyuk Harfe Cevir Efekti...";

        public string Islem(string str)
        {
            return str.ToUpper();
        }
    }
}
