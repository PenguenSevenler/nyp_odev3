using System;

namespace Workspace
{
    internal class Program
    {
        internal static void Main()
        {
            bool[] seats = new bool[10];
            for(int i = 0; i<10; i++)
            {
                seats[i] = false;
            }

            char tekrarKontrol = 'Y';
            while(tekrarKontrol == 'Y')
            {
                int sinifKontrol;
                int koltukNumarasi;
                Console.Write("Please Type '1' for First Class\nPlease Type '2' for Economy Class\n:");
                sinifKontrol = Convert.ToInt32(Console.ReadLine());
                
                if(sinifKontrol == 1)
                {
                    for (koltukNumarasi= 0; koltukNumarasi<5; koltukNumarasi++)
                    {
                        if(seats[koltukNumarasi] == false)
                        {
                            Console.Write("\nPurchase Complete");
                            Console.Write("\nSection: First Class\nSeat NO: {0}\n",koltukNumarasi+1);
                            seats[koltukNumarasi] = true;
                            break;
                        }
                        if(koltukNumarasi == 4)
                        {
                            Console.WriteLine("\nFirst Class is Full\nWould you like to take Economy Class? (2)");
                            sinifKontrol = Convert.ToInt32(Console.ReadLine());
                            if(sinifKontrol != 2)
                            {
                                Console.Write("\nNext flight leaves in 3 hours");
                            }
                        }
                    }

                }

                if(sinifKontrol == 2)
                {
                    for (koltukNumarasi = 5; koltukNumarasi<10; koltukNumarasi++)
                    {
                        if(seats[koltukNumarasi] == false)
                        {
                            Console.Write("\nPurchase Complete");
                            Console.Write("\nSection: Economy Class\nSeat NO: {0}\n",koltukNumarasi+1);
                            seats[koltukNumarasi] = true;
                            break;
                        }
                        if(koltukNumarasi == 9)
                        {
                            Console.WriteLine("\nEconomy Class is Full\nWould you like to take First Class (1)");
                            sinifKontrol = Convert.ToInt32(Console.ReadLine());
                            if(sinifKontrol != 1)
                            {
                                Console.Write("\n Next flight leaves in 3 hours");
                            }
                        }
                    }
                }

                Console.WriteLine("\nTo Buy Tickets Again 'Y': \n");
                tekrarKontrol = Convert.ToChar(Console.ReadLine());
            }

        }
        
    }
}


