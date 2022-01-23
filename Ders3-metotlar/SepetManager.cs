using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3_metotlar
{
    //Name convensiyon = yazım kuralı
    class SepetManager
    {
        // bir classın içinde birden fazla metot olabilir.
        public void Ekle(Product product)//  Product= veri tipi (string, int gibi.
                                         //  product= aşagıda kullandığımızda kullanacağımız isim.
                                         //  () görürsek bir operasyonu ifade ediyor.- Operasyonun yapacağı iş süslü parantezler arasına yazılıyor.
        {
            Console.WriteLine("TEBRİKLER!!! \nSepete Eklendi = " + product.Adi);
        }

        public void Ekle2(string productAdi, string aciklama, double fiyat, int stokAdedi)// bu şekilde en ufak değişiklikte bulundugu sayfalara gidip değişiklik yapmak gerekiyor.
        {
            Console.WriteLine("TEBRİKLER!!! \nSepete Eklendi = " + productAdi);

        }
    }
}
