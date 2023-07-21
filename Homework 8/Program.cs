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
            Node data = null;


            while (true)
            {
                var employee_data = new EmployeeData();
                var _line = Console.ReadLine();

                employee_data.Name = _line;

                if (string.IsNullOrWhiteSpace(employee_data.Name))
                {
                    break;
                }

                data = new Node()
                {
                    Data = employee_data.Name
                };
                var _sum = Console.ReadLine();
                employee_data.Salary = Convert.ToInt32(_sum);

                if (root == null)
                {
                    root = new Node()
                    {
                        Value = employee_data.Salary,
                        Data = employee_data.Name
                    };
                }
                else
                {
                    AddNode(root, new Node
                    {
                        Value = employee_data.Salary,
                        Data = employee_data.Name


                    }); ;
                }
            }

            Console.WriteLine("Sorted numbers:");
            Traverse(root, data);

            Console.WriteLine("What number to find?  Use 0 for finish.");
            while (true)
            {
                var line = Console.ReadLine();
                var element = Convert.ToInt32(line);
                if (element == 0)
                {
                    break;
                }
                var (node, level) = FindNode(root, element, level: 1);
                if (node == null)
                {
                    Console.WriteLine("Not found.");
                }
                else
                {
                    Console.WriteLine($"Find {node.Value}, level: {level}");
                }
            }

            static void AddNode(Node root, Node toAdd)
            {
                if (toAdd.Value < root.Value)
                {
                    //Идем в левое поддерево
                    if (root.Left != null)
                    {
                        AddNode(root.Left, toAdd);
                    }
                    else
                    {
                        root.Left = toAdd;
                    }
                }
                else
                {
                    //Идем в правое поддерево
                    if (root.Right != null)
                    {
                        AddNode(root.Right, toAdd);
                    }
                    else
                    {
                        root.Right = toAdd;
                    }
                }
            }

            static (Node node, int level) FindNode(Node root, int number, int level)
            {
                if (number < root.Value)
                {
                    //ищем в левом поддереве
                    if (root.Left != null)
                    {
                        return FindNode(root.Left, number, level + 1);
                    }
                    return (null, -1);
                }
                if (number > root.Value)
                {
                    //ищем в правом поддереве
                    if (root.Right != null)
                    {
                        return FindNode(root.Right, number, level + 1);
                    }
                    return (null, -1);
                }
                return (root, level);
            }

            static void Traverse(Node originiNode, Node data)
            {
                if (originiNode.Left != null)
                {
                    Traverse(originiNode.Left,data);
                }

                Console.WriteLine(originiNode.Value);
                Console.WriteLine(data.Data);

                if (originiNode.Right != null)
                {
                    Traverse(originiNode.Right,data);
                }
            }
        }
    }
}
