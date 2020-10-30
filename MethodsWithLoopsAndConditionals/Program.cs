using System;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Tracing;
using System.Net;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that will print to the console all numbers 1000 through -1000. - DONE

            //Write a method that will print to the console numbers 3 through 999 by 3 each time. - DONE

            //Write a method to accept two integers as parameters and check whether they are equal or not. - DONE

            //Write a method to check whether a given number is even or odd. - DONE

            //Write a method to check whether a given number is positive or negative. - DONE

            //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!! - DONE

            Console.WriteLine($"Prepare to count.");
            PressEnter();
            Counter();
            PressEnter();

            Console.WriteLine("Prepare to count by three.");
            PressEnter();
            CounterThree();
            PressEnter();
        }

        private static void CounterThree()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        private static void PressEnter()
        {
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        private static void Counter()
        {
            var goal = 1000;
            for (int i = -1000; i <= goal; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
