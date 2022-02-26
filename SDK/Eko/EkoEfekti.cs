using System;
using SDK;
namespace Eko
{
    public class EkoEfekti : ISDK
    {
        public string EklentiAdi { get => "Eko Efekti"; }

        public string Islem(string str)
        {
            string strYeni = "";

            for (int i = 0; i < 3; i++)
            {
                strYeni += str + "";
                
            }
            return strYeni;
        }
    }
}
