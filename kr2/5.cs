using System;

namespace kr2
{
    public class z5
    {

        static void Main(string[] args)
        {
            int size = 1000;
            int[,] m1 = new int[1000, 1000];
            int[,] m2 = new int[1000, 1000];

            int[] storage1 = new int[1000 * 1000];
            int[] storage2 = new int[1000 * 1000];
            storage1 = Getnumbers(storage1);
            storage2 = Getnumbers(storage2);

            int[] Getnumbers(int[] storage)
            {
                Random r = new Random();
                for (int i = 0; i < 1000000; i++)
                {
                    storage[i] = r.Next(0, 10);
                }
                return storage;
            }
            
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    m1[i, j] = storage1[i * 1000 + j];
                }
            }
            
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    m2[i, j] = storage2[i * 1000 + j];
                }
            }

            int[,] resm = new int[1000, 1000];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        resm[i, j] = m1[i,k] * m1[k,j];
                    }
                }
            }
            
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(resm[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
} 

