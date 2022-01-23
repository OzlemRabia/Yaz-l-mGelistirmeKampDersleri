using System;

namespace Ders3_degervereferanstipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // sayısal veri tipleri ( int, decimal, bool, float) = değer tip.
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;  // sayı2 degerini sayi1 e atar. sayi2 de değer değişikliği yok sadece değerini sayi1 e aktardı ve bağları koptu.
            sayi2 = 65; // sayı2 yeni değeri program yukarıdan aşağı çalıştığı için sayi1 ile işimiz yok bu satırda.
            Console.WriteLine(sayi1); // =30
            Console.WriteLine(sayi2); // = 65

            //array, class, interfare = referans tip yani adres tutuyor. Bir evin adresi belli onlar yerine yenisi gelince yeni değerler yaşıyor orda :D

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; //sayi1 adresleri artık sayi2 nin adreslerinde. yani sayi1 de ki istenen her verinin adresi sayi2 deki adreslere gidecek.
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]); //9999    sayi2[0] in adresindeki veriyi alıyor.
            Console.WriteLine(sayilar1[1]); //200     sayi2[1] in adresindeki veriyi alıyor.
            Console.WriteLine(sayilar1[2]); //300     sayi2[2] in adresindeki veriyi alıyor.
            Console.WriteLine(sayilar2[0]); //999
            Console.WriteLine(sayilar2[1]); //200
            Console.WriteLine(sayilar2[2]); //300
        }
    }
}
