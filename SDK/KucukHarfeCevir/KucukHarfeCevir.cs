using System;
using SDK;
namespace KucukHarfeCevir
{
    public class KucukHarfeCevir : ISDK
    {
        public string EklentiAdi => "Kucuk Harfe Cevir Efekti";

        public string Islem(string str)
        {
           return str.ToLower();
        }
    }
}
