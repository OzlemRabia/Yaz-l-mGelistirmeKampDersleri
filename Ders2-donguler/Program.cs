
using System;

namespace Ders2_classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs(); // Class değişkenlerini böyle tanımlıyoruz.
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs(); // Class değişkenlerini böyle tanımlıyoruz.
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.İzlenmeOrani = 64;

            Kurs kurs3 = new Kurs(); // Class değişkenlerini böyle tanımlıyoruz.
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay";
            kurs3.İzlenmeOrani = 80;

            Kurs kurs4 = new Kurs(); // Class değişkenlerini böyle tanımlıyoruz.
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat";
            kurs4.İzlenmeOrani = 100;


            //Console.WriteLine(kurs1.KursAdi +" : "+kurs1.Egitmen);
            Kurs[] Kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 }; // string olan degişten türümüz kurs oldu.
            //Kurs[] = değişken türü. İnt-string gibi
            //Kurslar = Oluşan dizinin adı

            foreach (var kurs in Kurslar) // forech içindeki 2. yazılan takma ad.
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }


        class Kurs // Class tanımlamak için bunu yapıyoruz.
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int İzlenmeOrani { get; set; }
        }
    }
}
