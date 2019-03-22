using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("..... Queues .....");
            Queue q1 = new Queue();
            //for(int x = 0; x<5; x++)
            //{
                
            //}
            //for (int x = 0; x < 5; x++)
            //{
            //    Console.WriteLine("\nDequeued Element: " + q1.Dequeue());
                
            //}
            string input;
            Console.WriteLine("\nToo stop adding names enter stop");
            do
            {

                Console.WriteLine("\nEnter a name to add to the queue");
                input = Console.ReadLine();
                if (input != "stop")
                {
                    q1.Enqueue(input);
                }
                
                
            }
            while (input != "stop");

            do
            {
                Console.WriteLine("\nName: " + q1.Dequeue());
            }
            while (q1.Count != 0);



            Console.ReadLine();
        }
    }
}
