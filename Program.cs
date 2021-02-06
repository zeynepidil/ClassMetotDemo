using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {   string Name="Zeynep İdil";
            string Surname = "Erkal";
            double Age = 21;
            double Number = 888;

            Customer customer1 = new Customer();
            customer1.CustomerName= "Zeynep İdil";
            customer1.CustomerSurname = "Erkal";
            customer1.CustomerAge = 21;
            customer1 .CustomerNumber = 888;

            Customer customer2 = new Customer();
            customer2.CustomerName = "İrem";
            customer2.CustomerSurname = "Erkal";
            customer2.CustomerAge = 29;
            customer2.CustomerNumber = 446;


            Customer customer3 = new Customer();
            customer3.CustomerName = "Dilay";
            customer3.CustomerSurname = "Yıldırım";
            customer3.CustomerAge = 20;
            customer3.CustomerNumber = 555;

            Customer []customers= new Customer []{ customer1, customer2, customer3 };
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CustomerName);
                Console.WriteLine(customer.CustomerSurname);
                Console.WriteLine(customer.CustomerAge);
                Console.WriteLine(customer.CustomerNumber);
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.Delete(customer2);
            customerManager.Add(customer2);
            customerManager.Delete(customer1);
            customerManager.Add(customer3);
            customerManager.Delete(customer2);











        }
    }
}
