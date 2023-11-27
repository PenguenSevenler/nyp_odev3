using System;

namespace soru6_23
{
    internal class Diamond
    {
        internal static void Main(string[] args)
        {
            int asterisk = 1;

            for (int row = 4; row >= 0; row--)
            {
                for (int space = 0; space < (row%5); space++)
                {
                    Console.Write(" ");
                }
                for (int a = 0; a < asterisk; a++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                asterisk += 2;
            }
            asterisk -= 4;
            for (int row = 1; row < 5; row++)
            {
                for (int space = 0; space < (row%5); space++)
                {
                    Console.Write(" ");
                }
                for (int a = 0; a < asterisk; a++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                asterisk -= 2;
            }
        }
    }
}