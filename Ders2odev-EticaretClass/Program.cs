
using System;

namespace Ders2_classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            // class oluşturup e-ticaretteki ürünleri listele
            // for, forecah ve while döngüdü ile ekrana yazdır

            Product product1 = new Product();
            product1.productAdi = "Kazak";
            product1.fiyati = 25;
            product1.agirligi = 1.56;
            product1.ozellikleri = "Kalin kislik kazak.";

            Product product2= new Product();
            product2.productAdi = "Pantolon";
            product2.fiyati = 63;
            product2.agirligi = 2.45;
            product2.ozellikleri = "Inca kumas pantolon.";

            Product product3 = new Product();
            product3.productAdi = "Deri ceket";
            product3.fiyati = 340;
            product3.agirligi = 3.56;
            product3.ozellikleri = "Gerçek deri ici polarli.";

            Product product4 = new Product();
            product4.productAdi = "Canta";
            product4.fiyati = 30;
            product4.agirligi = 1.6;
            product4.ozellikleri = "Su gecirmez.";

            Product product5 = new Product();
            product5.productAdi = "Saat";
            product5.fiyati = 40;
            product5.agirligi = 3;
            product5.ozellikleri = "Suya dayanıklı. ";

            Product[] Products = new Product[] { product1, product2, product3, product4, product5 };
           
            Console.WriteLine("-----for-----");
            
            for (int i = 0; i < Products.Length; i++)
            {
            Console.WriteLine("Urunun adı = "+ Products[i].productAdi);
            Console.WriteLine("UFiyati = " + Products[i].fiyati);
            Console.WriteLine("Agirliği = " + Products[i].agirligi);
            Console.WriteLine("Ozellik = " + Products[i].ozellikleri);
            Console.WriteLine("----------");
            }

            Console.WriteLine("-----foreach-----");

            foreach (var product in Products)
            {
            Console.WriteLine("Urunun adı = " + product.productAdi);
            Console.WriteLine("UFiyati = " + product.fiyati);
            Console.WriteLine("Agirliği = " + product.agirligi);
            Console.WriteLine("Ozellik = " + product.ozellikleri);
                Console.WriteLine("----------");
            }
           
            Console.WriteLine("-----while-----");
            int sayi = 0;
            while (sayi < Products.Length)
            {
            Console.WriteLine("Urunun adı = " + Products[sayi].productAdi);
            Console.WriteLine("UFiyati = " + Products[sayi].fiyati);
            Console.WriteLine("Agirliği = " + Products[sayi].agirligi);
            Console.WriteLine("Ozellik = " + Products[sayi].ozellikleri);
            sayi++;
            Console.WriteLine("----------");
                  }
            
        }


        class Product
        {
            public string productAdi { get; set; }
            public int fiyati { get; set; }
            public double agirligi { get; set; }
            public string ozellikleri { get; set; }
        }
    }
}