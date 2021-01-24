using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer müşteri1 = new  Customer
            {
                Id = 1 ,
                Name= " Gaye Nur";
                Surname = " Uyar ";
                Address = " Yozgat";
            }

            Customer müşteri2 = new  Customer
            {
                Id = 2 ,
                Name = " Gönül  ";
                Surname= "Uyar ";
                Adres = " Kayseri";
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Müşteri Ekle(müşteri1 );
            customerManager.Müşteri Ekle(müşteri2 );

            customerManager.ListCustomer(Customer1);
            customerManager.ListCustomer(customer2);

            customerManager.DelCustomer(Customer1);
            customerManager.DelCustomer(customer2);

        }
    }
}
