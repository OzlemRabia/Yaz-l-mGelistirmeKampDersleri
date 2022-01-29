using System;
using System.Collections.Generic;
using System.Text;

namespace Der3odev_classMetotDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("Müsteri eklendi => " + customer.FirstName);
        }

        public void CustomerDeletion(Customer customer)
        {
            Console.WriteLine("Müsteri silindi => " + customer.FirstName);
        }

        public void CustomerList(Customer[] customer)
        {
            foreach (Customer customers in customer)
            {
                Console.WriteLine("Müşteri Başarıyla Listelendi " + " => " + customers.Tc + " " + customers.FirstName + " " + customers.Surname + " " + customers.CardType + " " + customers.CardNo);
            }
        }

    }
}
