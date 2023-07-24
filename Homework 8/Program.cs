using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Homework_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter salary. Enter an empty string for finish.");
            Node root = null;

            while (true)
            {
                var employee_data = new Node();
                Console.WriteLine("Enter employee name:");
                var line = Console.ReadLine();

                employee_data.Name = line;

                if (string.IsNullOrWhiteSpace(employee_data.Name))
                {
                    break;
                }

                Console.WriteLine("Enter employee salary:");
                var sum = Console.ReadLine();
                if (int.TryParse(sum, out var salary))
                {
                    employee_data.Salary = salary;
                }
                else
                {
                    Console.WriteLine("The entered number is not an integer.");
                    continue;
                }

                if (root == null)
                {
                    root = new Node()
                    {
                        Salary = employee_data.Salary,
                        Name = employee_data.Name
                    };
                }
                else
                {
                    root.AddNode(root, new Node
                    {
                        Salary = employee_data.Salary,
                        Name = employee_data.Name


                    }); ;
                }
            }

            Console.WriteLine("Sorted numbers:");
            root.Traverse(root);

            while (true)

            {
                Console.WriteLine("What number to find?  Use 0 for finish.");
                try
                {
                    var line = Console.ReadLine();

                    var element = Convert.ToInt32(line);

                    if (element == 0)
                    {
                        break;
                    }
                    var (node, level) = root.FindNode(root, element, level: 1);
                    if (node == null)
                    {
                        Console.WriteLine("Not found.");
                    }
                    else
                    {
                        Console.WriteLine($"Find {node.Salary}");
                    }
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine($"The string must not be empty: {ex.Message}");
                }
            }
        }
    }
}
