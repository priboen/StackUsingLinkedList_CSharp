using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackUsingLinkedList_CSharp
{
    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }
    class Stack
    {
        Node top;
        public Stack()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push(int element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + "pushed");
        }
        public void pop()
        {
            Console.WriteLine("\n The poped elements is : " + top.info);
            top = top.next;
        }
        public void display()
        {
            Node tmp;
            if (empty())
            {
                Console.WriteLine("\nStack Empty");
            }
            else
            {
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
