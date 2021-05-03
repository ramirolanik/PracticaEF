using ClassLibrary1.Entities;
using ClassLibrary1.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomersLogic customersLogic = new CustomersLogic();

            Console.WriteLine("-----------------------------------------------------------------------------");
            foreach (Customers customers in customersLogic.GetAll())
            {


                Console.WriteLine($"{customers.CompanyName} - {customers.ContactName} - {customers.Phone}");


            }

            customersLogic.Add(new Customers
            {
                CustomerID = "TEST",
                CompanyName = "TEST",
                ContactName = "Ramiro Lanik",
                Phone = "48486262"

            });

            customersLogic.Add(new Customers
            {
                CustomerID = "TEST2",
                CompanyName = "TEST2",
                ContactName = "Ramiro Lanik2",
                Phone = "55555555"

            });

            Console.WriteLine("-----------------------------------------------------------------------------");
            foreach (Customers customers in customersLogic.GetAll())
            {


                Console.WriteLine($"{customers.CompanyName} - {customers.ContactName} - {customers.Phone}");


            }



            customersLogic.Delete("TEST");

            Console.WriteLine("-----------------------------------------------------------------------------");
            foreach (Customers customers in customersLogic.GetAll())
            {


                Console.WriteLine($"{customers.CompanyName} - {customers.ContactName} - {customers.Phone}");


            }

            customersLogic.Update(new Customers
            {
            ContactName= "TEST UPDATED",
            CustomerID="TEST2"


            });

            Console.WriteLine("-----------------------------------------------------------------------------");
            foreach (Customers customers in customersLogic.GetAll())
            {


                Console.WriteLine($"{customers.CompanyName} - {customers.ContactName} - {customers.Phone}");


            }


            Console.ReadLine();




        }
    }
}
