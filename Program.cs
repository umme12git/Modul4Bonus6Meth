using System;

namespace Modul4Bonus6Meth
{
    class Program
    {
        public static void PrintNum1000()
        {
            for (int i = 1000; i >= -1000; i--)
                Console.WriteLine($"numbers in decreasing order {i}");
            Console.WriteLine();
        }

        public static void PrintNum3To999()
        {

            for (int i = 3; i <= 999; i += 3)
                Console.WriteLine($"next number by 3 {i}");
            Console.WriteLine();
        }

        public static void NumbersEqual()
        {
            Console.WriteLine("Please enter integer number one");
            var chknumber1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter integer number two");
            var chknumber2 = int.Parse(Console.ReadLine());

            if (chknumber1 == chknumber2)
                Console.WriteLine($"Numbers {chknumber1} and {chknumber2} are equal");
            else
                Console.WriteLine($"Numbers {chknumber1} and {chknumber2} are not equal");

            Console.WriteLine();

        }

        public static void NumberEvenOdd()
        {
            Console.WriteLine("Please enter integer number to check even or odd");
            var numEvenOdd = int.Parse(Console.ReadLine());

            if (numEvenOdd % 2 == 0)
                Console.WriteLine("number is even");
            else
                Console.WriteLine("number is odd");

            Console.WriteLine();
        }

        public static void NumberPosNegative()
        {
            Console.WriteLine("Please enter integer number to check positive or negative");
            var numPosOrN = int.Parse(Console.ReadLine());

            if (numPosOrN > 0)
                Console.WriteLine("number is positive");
            else if (numPosOrN < 0)
                Console.WriteLine("number is negative");
            else
                Console.WriteLine("number is 0");

            Console.WriteLine();
        }

        public static void VoterCheck()
        {
            int agevalue;
            Console.WriteLine("Please enter your age to determine voting age");
            var age = Console.ReadLine();
            if (int.TryParse(age, out agevalue))
                {
                if (agevalue >= 18)
                    Console.WriteLine("valid voter");
                else
                    Console.WriteLine("not valid voter age");
                }
        }
        public static void RangeCheck()
        {
            Console.WriteLine("Please enter a number to check if it is within the range of -10 - 10");
            var num = int.Parse(Console.ReadLine());
            if (num >= -10 && num < 10)
                Console.WriteLine($"{num} is within the range of -10 - 10");
            else
                Console.WriteLine($"{num} is not within the range of -10 - 10");

        }

        public static void MultTable()
        {
            int[] colArray = new int[12]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] rowArray = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            
            Console.WriteLine("Multiplication Table for numbers 1 through 12");
            Console.WriteLine();

            Console.WriteLine("  |1   2   3   4   5   6   7   8   9   10  11  12");
            Console.WriteLine("__________________________________________________");

            int value;
            string number;
            

            for (int i = 0; i < rowArray.Length; i++)
            {
                if (i < 9)
                    Console.Write($"{i + 1} |");
                else
                    Console.Write($"{i + 1}|");
                for (int j = 0; j < colArray.Length; j++)
                {
                    value = rowArray[i] * colArray[j];
                    number = value.ToString();
                    if (number.Length == 1)
                        Console.Write($"{value}   ");
                    else if (number.Length == 2)
                        Console.Write($"{value}  ");
                    else if (number.Length == 3)
                        Console.Write($"{value} ");
                    
                       
                }
                Console.WriteLine();
                

            }

        }
            


        static void Main(string[] args)
        {

            PrintNum1000();

            PrintNum3To999();

            NumbersEqual();

            NumberEvenOdd();

            NumberPosNegative();

            VoterCheck();

            RangeCheck();

            MultTable();

        }
    }
}
