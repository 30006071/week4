using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTask1
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
            


            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.ReadLine();
        }
    }
}
