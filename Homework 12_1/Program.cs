using System;
using System.Collections.Concurrent;
using System.Threading;

class Program
{
    static ConcurrentDictionary<string, int> books = new ConcurrentDictionary<string, int>();

    static void Main(string[] args)
    {
        Thread backgroundThread = new Thread(UpdateProgress);
        backgroundThread.IsBackground = true;
        backgroundThread.Start();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1 - добавить книгу; 2 - вывести список непрочитанного; 3 - выйти");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    PrintBooks();
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Недопустимая команда. Попробуйте еще раз.");
                    break;
            }
        }
    }

    static void AddBook()
    {
        Console.WriteLine("Введите название книги:");
        string title = Console.ReadLine();

        if (books.TryAdd(title, 0))
        {
            Console.WriteLine("Книга успешно добавлена.");
        }
        else
        {
            Console.WriteLine("Книга с таким названием уже добавлена.");
        }
    }

    static void PrintBooks()
    {
        Console.WriteLine("Список непрочитанных книг:");

        foreach (var book in books)
        {
            Console.WriteLine($"{book.Key} - {book.Value}%");
        }
    }

    static void UpdateProgress()
    {
        while (true)
        {
            foreach (var book in books)
            {
                books.TryUpdate(book.Key, book.Value + 1, book.Value);
                if (book.Value >= 100)
                {
                    books.TryRemove(book.Key, out _);
                }
            }

            Thread.Sleep(1000);
        }
    }
}