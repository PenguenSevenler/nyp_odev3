using System;

namespace Number
{
    internal class Digits
    {
        internal static void Main(string[] args)
        {
            Console.Write("Enter a natural number: ");
            uint number = 0;
            try
            {
                number = uint.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You must enter a natural number.");
                return;
            }

            Console.WriteLine("Sum of {0}'s digits is: {1}", number, SumOfDigits(number));
        }

        internal static int SumOfDigits(uint number)
        {
            if (number < 10)
                return (int)number;
            
            return (int)(number%10) + SumOfDigits(number/10);
        }
    }
}