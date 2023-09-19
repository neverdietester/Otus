

using System.Threading.Channels;
using System.Threading.Tasks;
using Homework_9;

class Program
{
    static void Main()
    {
        void SubscribeStart()
        {
            Console.WriteLine("Скачивание файла началось");
        }
        void SubscribeStop()
        {
            Console.WriteLine("Скачивание файла закончилось");
        }

        ImageDownloud imageDownloud = new ImageDownloud();
        imageDownloud.onImageStarted += SubscribeStart;
        imageDownloud.onImageCompleted += SubscribeStop;
        var task = imageDownloud.Download();


        Console.WriteLine("Нажмите клавишу А для выхода или любую другую клавишу для проверки статуса скачивания\" ");
        var key = Console.ReadKey().Key;
        Console.WriteLine();
        if (char.ToUpperInvariant((char)key) == 'A')
        {
            Environment.Exit(0);
        }
        else
        {
           Console.WriteLine($"State: {task.IsCompleted}");
        }
    }
}