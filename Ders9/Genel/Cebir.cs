using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genel
{//dll de default internaldır
    //dll de main olmaz
    //dll doğrudan çalıştırılamaz mutlka bir exe dosyaya ihtiyaç duyar. 
    public class Cebir
    {
        public int Kare(int sayi)
        {
            return sayi * sayi;
        }
        public int KupAl(int sayi)
        {
            return sayi * sayi * sayi;
        }
    }
}
