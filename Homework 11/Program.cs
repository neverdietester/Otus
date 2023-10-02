// See https://aka.ms/new-console-template for more information

using Homework_11;

Console.WriteLine("Hello, World!");

OtusDictionary otusDictionary = new OtusDictionary();

otusDictionary.Add(1, "Olga");
otusDictionary.Add(2, "Ol");
otusDictionary.Add(3, "Vollga");
otusDictionary.Add(3, "Vol");

var result = otusDictionary.Get(4);

Console.WriteLine(result);