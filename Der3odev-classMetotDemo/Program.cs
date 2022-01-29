//REF-OUT= Değer yerine adresini gönderiyoruz.
//Normalde ref anahtar kelimesini kullandığımız zaman değişkeni oluştururken ona bir default değeri atamamız gerekir ama out anahtar kelimesini kullandığımızda default değer atamamıza gerek yoktur. Aralarındaki fark budur.
using System;

namespace Der3odev_classMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Banka müşteri takibi
            //Class müsteri özellikleri Tc-İsim-Soyisim v.s.
            //Müsteri manager sinifi oluştur.Müsteri parametresi olarak Müsteri ekleme, listeleme, siilme gibi parametreleri simule etme.
            Console.WriteLine("Hello World!");

            Customer customer1 = new Customer();
            customer1.Tc = 1;
            customer1.FirstName = "Ahmet";
            customer1.Surname = "Tehha";
            customer1.CardType = "Banka";
            customer1.CardNo = 11111;

            Customer customer2 = new Customer();
            customer2.Tc = 2;
            customer2.FirstName = "Mehmet";
            customer2.Surname = "Temhem";
            customer2.CardType = "Kredi";
            customer2.CardNo = 22222;

            Customer customer3 = new Customer();
            customer3.Tc = 3;
            customer3.FirstName = "Ayşe";
            customer3.Surname = "Eşya";
            customer3.CardType = "Banka";
            customer3.CardNo = 33333;

            Customer customer4 = new Customer();
            customer4.Tc = 4;
            customer4.FirstName = "Kenan";
            customer4.Surname = "Nanek";
            customer4.CardType = "Kredi";
            customer4.CardNo = 44444;

            Customer customer5 = new Customer();
            customer5.Tc = 5;
            customer5.FirstName = "Hogo";
            customer5.Surname = "Oguh";
            customer5.CardType = "Kredi";
            customer5.CardNo = 55555;

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5 };
            CustomerManager customerManager = new CustomerManager();

            customerManager.CustomerAdd(customer4);
            customerManager.CustomerDeletion(customer2);
            customerManager.CustomerList(customers);
        }
    }
}
