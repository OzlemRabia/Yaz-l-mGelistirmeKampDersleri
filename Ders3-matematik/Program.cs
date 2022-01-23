 using System;

namespace Ders3_matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6); // 5-6, 10,5 parametrelerimiz. DortIslem classında değişken türü olarak int olduğu için int türünde girdik.

            dortIslem.Topla(10, 5);


            Console.WriteLine("----------\nSAYFA SONU");
        }
    }
}
