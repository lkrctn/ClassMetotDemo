using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        { 
            Console.WriteLine("---------------TEBRİKLER---------------\n" +
                customer.Id + " Id'ye sahip" + " " + customer.FirtName + " " + customer.LastName + " sistemimize eklenmiştir.\n");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("---------------DİKKAT!---------------\n" + customer.Id + 
                " Id'ye sahip" + " " + customer.FirtName + " " + customer.LastName + " sistemimizden silinmiştir.\n");
        }

        public void Update(Customer customer)
        {            
            Console.WriteLine("---------------GÜNCELLEME---------------\n" + customer.Id + " Id'ye sahip müşterinin bilgileri güncellenmiştir.");
            Console.WriteLine("         GÜNCELLEME BAŞARILI\n");
        }

        public void Listing(Customer[] customers)
        {
            Console.WriteLine("_______________Müşteri Listesi_____________________");
            foreach (var c in customers)
            {
                Console.WriteLine("Müşteri Id : " + " " + c.Id);
                Console.WriteLine("Müşteri Adı ve Soyadı : " + " " + c.FirtName + " " + c.LastName + "\n");
            }

        }
    }
}
