using System;
using System.ComponentModel.Design.Serialization;
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

            //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!



            Console.Write($"Enter range min.");
            var rangeMin = int.Parse(Console.ReadLine());
            Console.Write($"Enter range max.");
            var rangeMax = int.Parse(Console.ReadLine());
            Console.Clear();
            Count(rangeMin, rangeMax);

            MoveOn();

            Console.Write($"Increase by 3, ");
            PressEnter();
            CountByThree();

            MoveOn();

            AreEqual();

            MoveOn();



            Console.WriteLine($"Enter a number to see if it's even or odd.");
            var evenOddInput = int.Parse(Console.ReadLine());
            Console.Clear();
            EvenOrOdd(evenOddInput);

            MoveOn();

            Console.WriteLine($"Enter a number to see if it's positive or negative.");
            var posNegInput = int.Parse(Console.ReadLine());
            Console.Clear();
            PositiveOrNegative(posNegInput);

            MoveOn();

            Console.WriteLine("Please tell me your age and I will tell you if you can vote.");
            int age;
            while(!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Could not compute, try again.");
            }
            AgeChecker(age);
        }

        public static void PressEnter()
        {
            Console.Write("press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static void MoveOn()
        {
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Count(int min, int max)
        {
            var thousand = min;
            while (thousand <= max)
            {
                Console.WriteLine(thousand++);
            }
        }

        public static void CountByThree()
        {
            for (var byThrees = 3; byThrees <= 999; byThrees += 3)
            {
                Console.WriteLine(byThrees);
            }
        }

        public static void AreEqual()
        {
            Console.WriteLine($"Enter the first number to be compared.");
            var responseOne = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Enter the second number to be compared.");
            var responseTwo = Console.ReadLine();

            Console.Clear();

            if (responseOne == responseTwo)
            {
                Console.WriteLine($"{responseOne} and {responseTwo} are equal!");
            } else if (int.Parse(responseOne) > int.Parse(responseTwo))
            {
                Console.WriteLine($"{responseOne} is greater than {responseTwo}");
            } else
            {
                Console.WriteLine($"{responseOne} is less than {responseTwo}");
            }
        }
        public static void EvenOrOdd(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is even.");
            }else
            {
                Console.WriteLine($"{x} is odd.");
            }
        }
        public static void PositiveOrNegative(int posInput)
        {
            if (posInput >= 1)
            {
                Console.WriteLine($"{posInput} is positive.");
            }else if(posInput == 0)
            {
                Console.WriteLine($"I was too lazy to Google the answer.");
            }else
            {
                Console.WriteLine($"{posInput} is negative.");
            }
        }

        public static void AgeChecker(int userAge)
        {
            if (userAge >= 18)
            {
                Console.WriteLine($"You may vote.");
            }else
            {
                Console.WriteLine($"Sorry, you are too young to vote.");
            }
        }
    }
}
