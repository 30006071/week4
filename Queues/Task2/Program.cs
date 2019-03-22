using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("..... Queues .....");
            Queue q1 = new Queue(); 
            string input;
            string input1;
            Console.WriteLine("\nToo stop adding names enter stop");

            do
            {
                Console.WriteLine("\nEnter a name to add to the queue");
                input = Console.ReadLine();
                if (input != "stop")
                {
                    q1.Enqueue(input);
                }
            } while (input != "stop");

            string[] queueArr = new string[q1.Count]; //instantiating an array to store the values from the Queue (q1). Using q1.Count to create the length of the array according to the number of elements in the queue.
            q1.CopyTo(queueArr, 0); //Copying the values in q1 to the queue array, starting from index 0 which is the first element in the array.

            do
            {
                Console.WriteLine("\nName: " + q1.Dequeue());
            } while (q1.Count != 0);

            Console.WriteLine("\nEnter a name to see if its in the queue\n");
            input1 = Console.ReadLine();
            Console.WriteLine("\n" + input1 + " is in the queue array (true or false)\n" + queueArr.Contains(input1));

            Array.Sort(queueArr);

            for (int x = 0; x < queueArr.Length; x++)
            {
                Console.WriteLine("\nName: " + queueArr[x]);
            }
            
            Console.ReadLine();


        


        
        }
    }
}










//if (q1.Contains(input1))
//{

//    while (q1.Peek().ToString() != input1)
//    {
//        q1.Dequeue();
//    }
//}

//else
//{
//    Console.WriteLine("Does not contain " + contains);
//}
//Console.WriteLine($"Contains: {q1.Peek()}");


//for(int x = 0; x<5; x++)
//{

//}
//for (int x = 0; x < 5; x++)
//{
//    Console.WriteLine("\nDequeued Element: " + q1.Dequeue());

//}
