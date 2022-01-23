using System;

namespace ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string kategoriEtikti = "Kategori";
            Console.WriteLine(kategoriEtikti);
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;



            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalan buton");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artan buton");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }
            bool sistemeGirisYapilmismi = true;
            // boolen matematiği kullanılıyor yani doğru mu yanlışmı.
            if (sistemeGirisYapilmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }





            Console.WriteLine("--------------------------\nBYE BYE!");
        }
    }
}

