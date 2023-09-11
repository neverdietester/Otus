

using Homework_9;

class Program
{
    public static void Main()
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
        imageDownloud.Download();
       

        Console.WriteLine("Нажмите любую клавишу");
        Console.ReadLine();

    }
}