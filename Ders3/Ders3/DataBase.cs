using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3
{
    static class DataBase
    {
        public static void Kaydet()//static class içindeki herşey static olmalıdır
        {
            DataBase.Kaydet();
            Baglan baglan = new Baglan();
            //baglan.ConnectionString yok deği
            Baglan.ConnectionString("nfejfbej");

            int[] sayılar = { 45, 45, 78, 78 };
            //sayılar.sort
            //Array.Sort//static sınıf o yüzden metotlar class üzerinden çağırılır
            //StreamWriter
        }
        class Baglan
        {
            public static void ConnectionString(string str)
            {

            }
        }
    }
}
