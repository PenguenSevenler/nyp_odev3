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
                Console.Write("First Class Bileti Icin '1'\nEkonomi Bileti Icin '2'\n:");
                sinifKontrol = Convert.ToInt32(Console.ReadLine());
                
                if(sinifKontrol == 1)
                {
                    for (koltukNumarasi= 0; koltukNumarasi<5; koltukNumarasi++)
                    {
                        if(seats[koltukNumarasi] == false)
                        {
                            Console.Write("\nKoltuk Numaraniz: {0}\n",koltukNumarasi+1);
                            seats[koltukNumarasi] = true;
                            break;
                        }
                        if(koltukNumarasi == 4)
                        {
                            Console.WriteLine("First Class Dolmustur\nBir Sonraki Ucus 3 Saat Sonradir\nEkonomi Sinifindan Bilet Almak Ister Misiniz? (2)");
                            sinifKontrol = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                }

                if(sinifKontrol == 2)
                {
                    for (koltukNumarasi = 5; koltukNumarasi<10; koltukNumarasi++)
                    {
                        if(seats[koltukNumarasi] == false)
                        {
                            Console.Write("\nKoltuk Numaraniz: {0}\n",koltukNumarasi+1);
                            seats[koltukNumarasi] = true;
                            break;
                        }
                        if(koltukNumarasi == 9)
                        {
                            Console.WriteLine("Ekonomi Sinifi Dolmustur\nBir Sonraki Ucus 3 Saat Sonradir");
                        }
                    }
                }

                Console.WriteLine("\nTekrar Islem Yapmak Icin 'Y': \n");
                tekrarKontrol = Convert.ToChar(Console.ReadLine());
            }

        }
        
    }
}


