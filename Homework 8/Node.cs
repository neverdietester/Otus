using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
        public class Node
        {
        public int Salary { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public string Name { get; set; }

        public void AddNode(Node root, Node toAdd)
        {
            if (toAdd.Salary < root.Salary)
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

        public (Node node, int level) FindNode(Node root, int number, int level)
        {
            if (number < root.Salary)
            {
                //ищем в левом поддереве
                if (root.Left != null)
                {
                    return FindNode(root.Left, number, level + 1);
                }
                return (null, -1);
            }
            if (number > root.Salary)
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

        public void Traverse(Node originiNode)
        {
            if (originiNode.Left != null)
            {
                Traverse(originiNode.Left);
            }

            Console.WriteLine(originiNode.Salary);
            Console.WriteLine(originiNode.Name);

            if (originiNode.Right != null)
            {
                Traverse(originiNode.Right);
            }
        }
    }
}
