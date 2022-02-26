using System;

namespace SDK
{
    public interface ISDK
    {
        string EklentiAdi { get; }
        string Islem(string str);
    }
}
