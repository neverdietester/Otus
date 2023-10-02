// See https://aka.ms/new-console-template for more information
using System.IO;
using System.IO.Enumeration;
using System.Text;

Console.WriteLine("Work with file");
Console.WriteLine();

var path = Path.Combine(Environment.SystemDirectory, "C:", "course", "Otus");
Directory.CreateDirectory(Path.Combine(path, "TestDir1"));
Directory.CreateDirectory(Path.Combine(path, "TestDir2"));

var pathTestDir1 = Path.Combine(path, "TestDir1");
var pathTestDir2 = Path.Combine(path, "TestDir2");

for (int i = 1; i <= 10; i++)
{
    string fileName = $"File{i}.txt";
    var exist = Directory.Exists(Path.Combine(pathTestDir1, fileName));
    
    if (!exist)
    {
        using var stream = File.CreateText(Path.Combine(pathTestDir1, fileName));
        {
            Encoding utf8 = Encoding.UTF8;
            byte[] fileNameBytes = Encoding.UTF8.GetBytes(fileName);
            foreach (var utf8Byte in fileNameBytes)
                stream.WriteLine("{0:X2} ", utf8Byte);
        }
    }
    string date = DateTime.Now.ToString();
    File.AppendAllText(Path.Combine(pathTestDir1, fileName), date);

    using var stream = File.OpenText(Path.Combine(pathTestDir1, fileName));
    {
        Console.WriteLine($"Name:{fileName}");
        Console.WriteLine();
        while (!stream.EndOfStream)
        {
            var s = stream.ReadLine();
            Console.WriteLine(s);
            Console.WriteLine();
        }
    }
}
for (int i = 1; i <= 10; i++)
{
    string fileName = $"File{i}.txt";
    var exist = Directory.Exists(Path.Combine(pathTestDir2, fileName));

    if (!exist)
    {
        using (var stream = File.CreateText(Path.Combine(pathTestDir2, fileName)))
        {
            Encoding utf8 = Encoding.UTF8;
            byte[] fileNameBytes = Encoding.UTF8.GetBytes(fileName);
            foreach (var utf8Byte in fileNameBytes)
                stream.WriteLine("{0:X2} ", utf8Byte);
        }
    }
    string date = DateTime.Now.ToString();
    File.AppendAllText(Path.Combine(pathTestDir2, fileName), date);

    using (var stream = File.OpenText(Path.Combine(pathTestDir2, fileName)))
    {
        Console.WriteLine($"Name:{fileName}");
        Console.WriteLine();
        while (!stream.EndOfStream)
        {
            var s = stream.ReadLine();
            Console.WriteLine(s);
            Console.WriteLine();
        }
    }
}