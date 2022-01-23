using System;

namespace Ders3_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // METOTLAR = tekrar tekrar kullanıla bilirliği sağlayan kod bloklarıdır.
            //Clean Code- Best Practice

            string[] meyveler = new string[] { };

            Product product1 = new Product(); // class tanımı,
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu.";

            Product[] products = new Product[] { product1, product2 }; // veri kaynağından geiyor. Arrayler genelde bi veri kaynağından geliyor. 
            //tip güvenli = çalışacagı veri tipini bilmek istiyor.
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama + "\n.................");
            }

            Console.WriteLine("----------Metotlar----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1); // SepetManager içindeki Ekle metotunu çağırıyoruz.
            sepetManager.Ekle(product2);// her biri farklı sayfada çağırılan sepete ekle gibi düşün. (reusubility= tekrar tekrar kullana bilme imkanı sağlama)
                                        //sepetManager.Ekle();
                                        // void Ekle(Product product) bu imzaya uygun parantez içi doldurulur

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 30);
            sepetManager.Ekle2("Elma", "Kırmızı Elma", 6, 50);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 5, 29);


            Console.WriteLine("------------\n#SAYFA SONU#");
        }
    }
}
