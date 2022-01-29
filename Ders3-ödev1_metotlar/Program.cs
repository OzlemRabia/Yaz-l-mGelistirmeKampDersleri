using System;
using System.Linq;

namespace Ders3_ödev1_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            var result = Add2(5, 6);
            Console.WriteLine(result);

            int number31 = 20;
            int number32 = 100;
            var result3 = Add3(ref number31, number32); //var result3 = Add3( number31, number32);
            // buradaki ref referans tip seklinde gönderim yapıyor.
            Console.WriteLine(result3); // ref- out yazılmadığında 20 olur. Değer tip(Değer tutuyor) referans tip = adres gönerir.
            // ref-out yazılırsa result31 adres-ref değeri değiştiği için sn değeri yani 30 u alır.
            //ref alternatifi out'dur. (ref yazılan yerlere out yazılır.) Ref değerinde ref edilecek değişkenin önceden tanımlanmış olması gerekirken out'ta buna gerek yoktur.Ayrıca out edilen değişkenin ilk değeri önemsizdir(okumaz).
            Console.WriteLine("number31 = " + number31);


            Console.WriteLine("2 li = "+Multiply( 2, 4));

            Console.WriteLine("3 li = " + Multiply(2, 4, 6));

            Console.WriteLine(Add4(1,2,3,4,5,6));

            Console.ReadLine();  //Uygulama dursun diye yazıyoruz.
            
        }
        static void Add() // voidlerde return kullanılmaz. intlerde return kullanılır.
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1+number2;
            return result;
            //Console.WriteLine(number1+number2);
        }

        static int Add3(ref int number31, int number32)
        {
            number31 = 30;
            var result3 = number31 + number32;
            return result3;
        }

        static int Multiply(int numberM1, int numberM2)
        {
            return numberM1 * numberM2;
        }

        static int Multiply(int numberM1, int numberM2, int numberM3) // metotları aynı isimle isimlendirdik FAKAT imzaları farklı olduğu için imzasına uygun olan metot çalışacak. M   ETOTLARIN OVERLOAD'ı denir.
        {
            return numberM1 * numberM2 * numberM3;
        }

        static int Add4(params int[] numbers)
        {   // 5 sayıyla yada 10 sayıyla aynı işlemi yapmak istediğimizde her biri için ayrı ayrı overload kullanmak yerine PARAMS kewordundan yazarlanacağız.
            return numbers.Sum(); //.sum toplama
        }

    }
}
