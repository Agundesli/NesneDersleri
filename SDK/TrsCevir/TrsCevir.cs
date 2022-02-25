using System;
using SDK;
namespace TrsCevir
{
    public class TrsCevir : ISDK
    {
        public string EklentiAdi => "Tes Cevirme Efekti...";

        public string Islem(string str)
        {
            string strYeni = "";
            for (int i = str.Length-1; i >= 0; i--)
            {
                strYeni += str[i];
            }
            return strYeni;
        }
    }
}
