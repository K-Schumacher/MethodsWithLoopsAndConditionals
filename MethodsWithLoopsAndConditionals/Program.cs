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

            int userNumberOne = GetUserNumber();
            int userNumberTwo = GetUserNumber();
            bool areEqual = EqualChecker(userNumberOne, userNumberTwo);
            Console.WriteLine($"{userNumberOne} is equal to {userNumberTwo}: {areEqual}.");
            PressEnter();

            int userNumberThree = GetUserNumber();
            EvenOrOdd(userNumberThree);
            PressEnter();

            Console.WriteLine($"Give me a number and I'll tell you if it's between -10 and 10.");
            int userNumberFour = GetUserNumber();
            BewtweenTens(userNumberFour);
            PressEnter();

            Table();
            PressEnter();
        }

        private static void Table()
        {
            int product;
            int userInput;

            Console.WriteLine("Pick a number between 1 and 12.");

            userInput = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                product = userInput * i;
                Console.WriteLine($"{userInput} * {i} = {product}");
            }
        }

        private static bool BewtweenTens(int i)
        {
            if (i <= 10 && i >= -10)
            {
                Console.WriteLine($"{i} is between -10 and 10.");
                return true;
            }
            Console.WriteLine($"{i} is not between -10 and 10.");
            return false;
        }

        private static void EvenOrOdd(int userNumber)
        {
            if (userNumber % 2 == 0)
            {
                Console.WriteLine($"{userNumber} is even.");
            }else if(userNumber % 2 != 0)
            {
                Console.WriteLine($"{userNumber} is odd.");
            }else if(userNumber == 0)
            {
                Console.WriteLine($"You could really just use Google, you know....");
            }
        }

        private static int GetUserNumber()
        {
            Console.Write($"Give me a number: ");
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;
        }

        private static bool EqualChecker(int num1, int num2)
        {
            return num1 == num2;
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
