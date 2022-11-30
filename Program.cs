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
            Console.WriteLine("\nPress Enter to Continue.");
            Console.ReadKey();
        }
        public void pop()
        {
            Console.WriteLine("\n The poped elements is : " + top.info);
            top = top.next;
            Console.WriteLine("\nPress Enter to Continue.");
            Console.ReadKey();
        }
        public void display()
        {
            Node tmp;
            if (empty())
            {
                Console.WriteLine("\nStack Empty");
                Console.WriteLine("\nPress Enter to Continue.");
                Console.ReadKey();
            }
            else
            {
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine("\nPress Enter to Continue.");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            Stack s = new Stack();
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\n ***Stack Menu***\n");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\n Enter your choice : ");
                string input = Console.ReadLine();
                char ch = Convert.ToChar(input == "" ? "0" : input);
                switch (ch)
                {
            
                    case '1':
                        Console.Clear();
                        Console.Write("\n Enter a number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;

                    case '2':
                        Console.Clear();
                        if (s.empty())
                        {
                            Console.WriteLine("\nStack Empty");
                            break;
                        }
                        s.pop();
                        break;

                    case '3':
                        Console.Clear();
                        s.display();
                        break;

                    case '4':
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n Invalid Choice");
                        break;
                }
            }
        } 
    }
}
