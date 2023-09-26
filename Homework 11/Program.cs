// See https://aka.ms/new-console-template for more information

using Homework_11;

Console.WriteLine("Hello, World!");

OtusDictionary otusDictionary = new OtusDictionary();

otusDictionary.Add(1, "Olga");
otusDictionary.Add(2, "Oleg");
otusDictionary.Add(3, "Vollga");

var result = otusDictionary.Get(2);

Console.WriteLine(result);