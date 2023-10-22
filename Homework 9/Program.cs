

using System.Threading.Channels;
using System.Threading.Tasks;
using Homework_9;

class Program
{
    static void Main()
    {
        downloader.onImageStarted += () =>
        {
            Console.WriteLine("Скачивание файла началось");
        };
        downloader.onImageCompleted += () =>
        {
            Console.WriteLine("Скачивание файла закончилось");
        };

        string remoteUri = "https://stsci-opo.org/STScI-01H7TER35PBNVGAV23W63WE2GX.png";
        string fileName = "bigimage.png";

        Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", fileName, remoteUri);

        var downloadTask = downloader.Download(remoteUri, fileName);

        Console.WriteLine("Нажмите клавишу A для выхода или любую другую клавишу для проверки статуса скачивания");
        if (Console.ReadKey().Key == ConsoleKey.A)
        {
            return;
        }

        bool isCompleted = downloadTask.IsCompleted;
        Console.WriteLine("Статус скачивания: {0}", isCompleted);

        Console.WriteLine("Нажмите любую клавишу для выхода");
        Console.ReadKey();
    }
}