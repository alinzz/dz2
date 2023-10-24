using System;
namespace kr2
{
    public class z4
        {
            static int Tickets(int[,] Seating, int k)
            {
                int row = Seating.GetLength(0);
                int seat = Seating.GetLength(1);
                
                for (int r = 0; r < row; r++)
                {
                    int poslmesta = 0;

                    for (int s = 0; s <seat; s++)
                    {
                        if (Seating[r, s] == 0)
                        {
                            poslmesta++;
                    
                            if (poslmesta == k)
                                return k;
                        }
                        else
                        {
                            poslmesta = 0;
                        }
                    }
                }
                return 0;
            }

            static void Main()
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                int[,] Seating = new int[n,m];
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Seating[i, j] = r.Next(0, 2);
                    }
                }
                
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("{0}\t", Seating[i,j].ToString());
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                int k = Convert.ToInt32(Console.ReadLine());

                int canSell = Tickets (Seating, k);
                Console.WriteLine(canSell);
            }
        }
    }