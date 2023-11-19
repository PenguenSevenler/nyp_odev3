using System;
using System.Reflection.Metadata.Ecma335;

public class diamond
{
    public int number;

    public void showDiamond(int number)
    {
        for (int i = 1;  i <= number; i++)
        {
            for (int j = 1; j <= (number - i) / 2; j++)
                Console.Write(" ");

            for (int j = 1; j <= i; j++)
                Console.Write("*");

            for (int j = 1; j <= (number - i) / 2; j++)
                Console.Write(" ");

            Console.WriteLine();

            i++;
        }

        for (int i = number-2; i >=1; i--)
        {
            for (int j = (number - i) / 2; j >= 1; j--)
                Console.Write(" ");

            for (int j = i; j >=1; j--)
                Console.Write("*");

            for (int j = (number - i) / 2; j >= 1; j--)
                Console.Write(" ");

            Console.WriteLine();

            i--;
        }



    }
}





class Program
{ 
    static void Main(string[] args)
    {

      while (true)
        {
            int number;
            Console.Write("input number to diamond : ");
            number = Convert.ToInt32(Console.ReadLine());



            if (number % 2 == 0)
            {
                Console.WriteLine("diamond creation error. the number must be odd.");

                Console.Write("press 1 to continue, press any key to exit : ");
                int control;
                control = Convert.ToInt32(Console.ReadLine());

                if (control == 1)
                    continue;
                else
                    break;

            }
            else
            {
                diamond diamond = new diamond();
                diamond.number = number;

                diamond.showDiamond(number);


                Console.Write("press 1 to continue, press any key to exit : ");
                int control;
                control = Convert.ToInt32(Console.Read());

                if (control == 1)
                    continue;
                else
                    break;



            }






        }







    }
}


