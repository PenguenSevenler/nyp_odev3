using System;

namespace Airline
{
    internal class Ticket
    {
        internal protected bool[] Seat;
        internal Ticket(uint seat_amount)
        {
            Seat = new bool[seat_amount];
            for (uint i = 0; i < seat_amount; i++)
            {
                Seat[i] = false;
            }
        }

        internal static void Main(string[] args)
        {
            Ticket vendor = new Ticket(10);
            Console.WriteLine("Airline Ticket Vendor");
            vendor.VendingPrompt();
        }

        internal int VendingPrompt()
        {
            beginning:
            if (PlaneIsFull())
            {
                Console.WriteLine("There are no seats available on this flight");
                Console.WriteLine("Next flight leaves in 3 hours.");
                return -1;
            }

            short selection = 0;

            while (selection <= 0 || selection > 2)
            {
                Console.WriteLine("Please type 1 for First Class");
                Console.WriteLine("Please type 2 for Economy");

                Console.Write("> ");
                try
                {
                    selection = short.Parse(Console.ReadLine());
                    if (selection <= 0 || selection > 2)
                    {
                        Console.WriteLine("You can only select either 1 or 2\n");
                    }
                }
                catch
                {
                    Console.WriteLine("You can only select either 1 or 2\n");
                }
            }

            uint seat_choice = 0;
            switch(selection)
            {
                case 1:
                    if (FirstClassIsFull())
                    {
                        Console.WriteLine("There are no seats available in First Class.");
                        Console.WriteLine("Would you like to book from Economy Class instead? (y/n)");
                        Console.Write("> ");
                        if (Console.ReadLine() == "y")
                        {
                            selection = 2;
                            goto case 2;
                        }
                        else
                        {
                            Console.WriteLine("Next flight leaves in 3 hours.");
                            return -1;
                        }
                    }
                    else
                    {
                        Console.Write("Available First Class seats are:\n");
                        ListAvailableSeats(true);
                        seat_choice = 0;
                        while(seat_choice == 0 || Seat[seat_choice-1])
                        {
                            Console.Write("Choose a seat to book.\n> ");
                            try
                            {
                                seat_choice = uint.Parse(Console.ReadLine());
                                if (seat_choice > Seat.Length/2 || seat_choice < 1 || Seat[seat_choice-1])
                                {
                                    seat_choice = 0;
                                    Console.WriteLine("You can only choose an available seat.");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("You can only choose an available seat.");
                            }
                        }
                    }
                    break;

                case 2:
                    if (EconomyClassIsFull())
                    {
                        Console.WriteLine("There are no seats available in Economy Class.");
                        Console.WriteLine("Would you like to book from First Class instead? (y/n)");
                        Console.Write("> ");
                        if (Console.ReadLine() == "y")
                        {
                            selection = 1;
                            goto case 1;
                        }
                        else
                        {
                            Console.WriteLine("Next flight leaves in 3 hours.");
                            return -1;
                        }
                    }
                    else
                    {
                        Console.Write("Available Economy Class seats are:\n");
                        ListAvailableSeats(false);
                        seat_choice = 0;
                        while(seat_choice == 0 || Seat[seat_choice-1])
                        {
                            Console.Write("Choose a seat to book.\n> ");
                            try
                            {
                                seat_choice = uint.Parse(Console.ReadLine());
                                if (seat_choice > Seat.Length || seat_choice <= Seat.Length/2 || Seat[seat_choice-1])
                                {
                                    seat_choice = 0;
                                    Console.WriteLine("You can only choose an available seat.");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("You can only choose an available seat.");
                            }
                        }
                    }
                    break;
            }

            Seat[seat_choice-1] = true;

            Console.WriteLine("Seat {0} is successfully booked.", seat_choice);
            Console.Write("Would you like to book another seat? (y/n)\n> ");
            if (Console.ReadLine() == "y")
                goto beginning;
            else
                return (Convert.ToInt32(seat_choice)-1);
        }

        internal void ListAvailableSeats(bool IsFirstClass)
        {
            if (IsFirstClass)
            {
                for (uint i = 0; i < (Seat.Length/2); i++)
                {
                    if (!Seat[i])
                    {
                        Console.WriteLine((i+1));
                    }
                }
            }
            else
            {
                for (uint i = ((uint)Seat.Length/2); i < Seat.Length; i++)
                {
                    if (!Seat[i])
                    {
                        Console.WriteLine((i+1));
                    }
                }
            }
        }

        internal bool FirstClassIsFull()
        {
            int empty_counter = 0;
            for (uint i = 0; i < (Seat.Length/2); i++)
            {
                if (!Seat[i])
                {
                    empty_counter++;
                }
            }
            return (empty_counter == 0);
        }
        internal bool EconomyClassIsFull()
        {
            int empty_counter = 0;
            for (uint i = ((uint)Seat.Length/2); i < Seat.Length; i++)
            {
                if (!Seat[i])
                {
                    empty_counter++;
                }
            }
            return (empty_counter == 0);
        }
        internal bool PlaneIsFull()
        {
            int empty_counter = 0;
            for (uint i = 0; i < Seat.Length; i++)
            {
                if (!Seat[i])
                {
                    empty_counter++;
                }
            }
            return (empty_counter == 0);
        }
    }
}