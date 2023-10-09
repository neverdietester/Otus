using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib;
using Npgsql;

namespace Homework_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работа с БД!");

            IEnumerable<Customers> customers = Dapper.GetCustomers();

            foreach (Customers customer in customers)
            {
                Console.WriteLine($"Customer - ID: {customer.Id}, Name: {customer.FirstName} {customer.LastName}, Age: {customer.Age}");
            }

            Console.WriteLine();

            string pattern = "Петров";
            IEnumerable<Customers> filteredCustomers = Dapper.GetCustomers(pattern);
            foreach (Customers customer in filteredCustomers)
            {
                Console.WriteLine($"Customer - ID: {customer.Id}, Name: {customer.FirstName} {customer.LastName}, Age: {customer.Age}");
            }

            Console.WriteLine();

            int customerId = 11;
            Customers customerById = Dapper.GetCustomerById(customerId);
            if (customerById != null)
            {
                Console.WriteLine($"CustomerID: {customerById.Id}, Name: {customerById.FirstName} {customerById.LastName}, Age: {customerById.Age}");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }

            Console.WriteLine();

            Customers newCustomer = new Customers
            {
                Id = 14,
                FirstName = "Андрей",
                LastName = "Павлов",
                Age = 65
            };
            Dapper.Insert(newCustomer);
            //Console.WriteLine("Добавлен новый клиент");
            Console.WriteLine($"Добавлен новый клиент: \nCustomerID: {newCustomer.Id}, Name: {newCustomer.FirstName} {newCustomer.LastName}, Age: {newCustomer.Age}");

            Console.ReadLine();
        }
    }
}
