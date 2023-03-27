using System;

namespace Conditionals_Dallas
{
    class Program
    {
        static void Main(string[] args)
        {   
            //asks the user to pick a number
            Console.WriteLine("enter a whole number here, please");
            int myWholeNum = Convert.ToInt32(Console.ReadLine());

            //checks if the number is neg or pos
            if (myWholeNum >= 0)
            {
                Console.WriteLine($"{myWholeNum} is a positvie number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is a negative number!");
            }

            //checks if even or odd
            if(myWholeNum % 2 == 0)
            {
                Console.WriteLine($"{myWholeNum} is an even number!");
            }
            else 
            {
                Console.WriteLine($"{myWholeNum} is an odd number!");
            }
            
            // Creates two more integer numbers
            int num1 = 6;
            int num2 = 99;
            // Gets first max
            int firstMax = Math.Max(myWholeNum, num1);
            // Gets maximum number
            int max = Math.Max(firstMax, num2);

            //prints max to console
            Console.WriteLine($"The maximum number of {myWholeNum}, {num1}, and {num2}, is {max}!");

            Console.WriteLine("enter a grade (A, B, C, D, F)!");
            char grade = Console.ReadKey().KeyChar;

            //Prints description based on grade vaule
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("\nSuperior");
                    break;
                case 'B':
                    Console.WriteLine("\nVery Good");
                    break;
                case 'C':
                    Console.WriteLine("\nAverage");
                    break;
                case 'D':
                    Console.WriteLine("\nBelow Average");
                    break;
                case 'F':
                    Console.WriteLine("\nFail");
                    break;
                default:
                    Console.WriteLine("\nYou did not enter a valid grade!");
                    break;
            }
        }
    }
}
