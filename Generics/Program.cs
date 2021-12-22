using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> yasAd = new MyDictionary<int, string>();
            yasAd.Add(18, "Emirhan");
            yasAd.Add(21, "Oğuzhan");
            yasAd.Add(24, "Ulaş");
            yasAd.Add(16, "Ebrar");

        }
    }
}
