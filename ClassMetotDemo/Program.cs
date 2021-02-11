using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // İlk önce örnek bir veri seti oluşturduk. 
            Customer customer1 = new Customer();
            customer1.Id = 101;
            customer1.FirtName = "İlker";
            customer1.LastName = "Paşa";
            customer1.City = "Ankara";

            Customer customer2 = new Customer();
            customer2.Id = 102;
            customer2.FirtName = "Elif";
            customer2.LastName = "Betese";
            customer2.City = "Ankara";

            Customer customer3 = new Customer();
            customer3.Id = 103;
            customer3.FirtName = "Gizem";
            customer3.LastName = "Sırlı";
            customer3.City = "Adana";

            Customer customer4 = new Customer();
            customer4.Id = 104;
            customer4.FirtName = "Merve";
            customer4.LastName = "Sultan";
            customer4.City = "Kahramanmaraş";


            ////Customerları biz dizi içerisine aldık.
            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            foreach (var c in customers)
            {
                Console.WriteLine("Müşteri Id : " + " " + c.Id);
                Console.WriteLine("Müşteri Adı ve Soyadı : " + " " + c.FirtName + " " + c.LastName);
                Console.WriteLine("Müşterinin Yaşadığı Şehir : " + " " + c.City);
                Console.WriteLine("_____________________________________________");
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer3);
            customerManager.Delete(customer4);
            customerManager.Update(customer2);
            customerManager.Listing(customers);
            
                            
        }
    }
}
