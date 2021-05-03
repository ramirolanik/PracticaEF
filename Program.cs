using ClassLibrary1.Data;
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
            Console.WriteLine("TABLA CATEGORIES:");
            CategoriesLogic categoriesLogic = new CategoriesLogic();

            foreach (Categories categories in categoriesLogic.GetAll())
            {


                Console.WriteLine($"{categories.CategoryName} - {categories.Description} ");


            }


            CustomersLogic customersLogic = new CustomersLogic();


            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("TABLA CUSTOMERS:");


            foreach (Customers customers in customersLogic.GetAll())
            {


                Console.WriteLine($"{customers.CompanyName} - {customers.ContactName} - {customers.Phone}"); /* Muestro por pantalla la tabla Customers por defecto*/


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
            Console.WriteLine("TABLA CUSTOMERS:");
            foreach (Customers customers in customersLogic.GetAll())
            {


                Console.WriteLine($"{customers.CompanyName} - {customers.ContactName} - {customers.Phone}"); /* Muestro por pantalla la tabla Customers con columnas agregadas*/


            }



            customersLogic.Delete("TEST");

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("TABLA CUSTOMERS:");

            foreach (Customers customers in customersLogic.GetAll())
            {


                Console.WriteLine($"{customers.CompanyName} - {customers.ContactName} - {customers.Phone}"); /* Muestro por pantalla la tabla Customers con las columnas eliminadas*/


            }

            customersLogic.Update(new Customers
            {
            ContactName= "TEST UPDATED",
            CustomerID="TEST2"


            });

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("TABLA ACTUALIZADA:");


            foreach (Customers customers in customersLogic.GetAll())
            {


                Console.WriteLine($"{customers.CompanyName} - {customers.ContactName} - {customers.Phone}"); /* Muestro por pantalla la tabla Customers con el update de columnas*/


            }


            Console.ReadLine();




        }
    }
}
