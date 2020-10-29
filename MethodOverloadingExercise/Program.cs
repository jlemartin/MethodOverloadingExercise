using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Overloading Exercise");
            Console.WriteLine();

            // declare and initialize variables
            var intA = 2;
            var intB = 3;
            var decC = 4.1m;
            var decD = 1.5m;
            var intE = 7;
            var intF = 8;
            var yesDollars = true;
            var noDollars = false;
            var intH = 0;
            var intI = 1;

            var add1 = Add(intA, intB);
            Console.WriteLine($"The sum of integers {intA} and {intB} is {add1}.");

            var add2 = Add(decC, decD);
            Console.WriteLine($"The sum of decimals {decC} and {decD} is {add2}.");
            Console.WriteLine();

            var add3 = Add(intE, intF, yesDollars);
            Console.WriteLine("The result below should use the dollars label.");
            Console.WriteLine($"The sum of {intE} and {intF} is {add3}.");
            Console.WriteLine();

            var add4 = Add(intE, intF, noDollars);
            Console.WriteLine("The result below should NOT label as dollars.");
            Console.WriteLine($"The sum of {intE} and {intF} is {add4}.");
            Console.WriteLine();

            var add5 = Add(intH, intI, yesDollars);
            Console.WriteLine("The result below should be a single dollar designation.");
            Console.WriteLine($"The sum of {intH} and {intI} is {add5}.");


        }

        // Create a method named Add, that accepts two integers and returns the sum of those two integers
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Now create an overload of the Add method to account for being able to add two decimals together
        public static decimal Add(decimal c, decimal d)
        {
            return c + d;
        }

        // Now create an overload of the Add method that returns a string
        // and accepts 3 parameters: 2 integers and 1 boolean
        // If the boolean parameter is equal to true, the Add method will return
        //  the sum of the 2 numbers plus the word “dollars” at the end of the string.
        // You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
        public static string Add(int e, int f, bool g)
        {
            var sum = e + f;
            var theString = "";

            if (g && sum > 1)
            {
                theString = $"{sum} dollars";
            }
            else if (g && sum == 1)
            {
                theString = $"{sum} dollar";
            }
            else if (g && sum < 1)
            {
                theString = $"{sum} dollars";
            }
            else
            {
                theString = sum.ToString();

            }

            return theString;
        }
    }
}
