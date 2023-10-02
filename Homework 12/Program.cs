using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Homework_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Customer customer = new Customer();

            shop.Items.CollectionChanged += customer.OnItemChanged;

            Console.WriteLine("Нажмите клавишу A, чтобы добавить товар");
            Console.WriteLine("Нажмите клавишу D, чтобы удалить товар");
            Console.WriteLine("Нажмите клавишу X, чтобы выйти из программы");

            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.A)
                {
                    Console.WriteLine("\nВведите имя товара:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите идентификатор товара:");
                    int id = int.Parse(Console.ReadLine());

                    Item newItem = new Item { Name = name, Id = id };
                    shop.Add(newItem);
                }
                else if (keyInfo.Key == ConsoleKey.D)
                {
                    Console.WriteLine("\nВведите идентификатор товара для удаления:");
                    int idToRemove = int.Parse(Console.ReadLine());

                    Item itemToRemove = shop.Items.FirstOrDefault(i => i.Id == idToRemove);
                    if (itemToRemove != null)
                    {
                        shop.Remove(itemToRemove);
                    }
                }
            }
            while (keyInfo.Key != ConsoleKey.X);
        }
    }
}