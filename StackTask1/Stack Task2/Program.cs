using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string contains = "";
            Console.WriteLine("Enter values for the stack/n");
            Stack s1 = new Stack();
            Console.WriteLine("Enter Stack number value");
            s1.Push(Console.ReadLine());
            Console.WriteLine("Enter next Stack number value");
            s1.Push(Console.ReadLine());
            Console.WriteLine("Enter next Stack number value");
            s1.Push(Console.ReadLine());
            Console.WriteLine("Enter next Stack number value");
            s1.Push(Console.ReadLine());
            Console.WriteLine("Enter next Stack number value");
            s1.Push(Console.ReadLine());
            Console.WriteLine("Enter a value to see if it is in the stack");
            contains = Console.ReadLine();


            if (s1.Contains(contains) == true)
            {
                while (s1.Peek().ToString() != contains)
                {
                    s1.Pop();
                }
            }

            else
            {
                Console.WriteLine("Does not contain " + contains);
            }
            Console.WriteLine($"Contains: {s1.Peek()}");
            Console.ReadLine();


        }
    }
}
    }
}
