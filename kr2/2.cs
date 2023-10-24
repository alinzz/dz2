using System;
namespace kr2
{
    internal class z2
    {
        public static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8};

            int length = array.Length;
            int halfLength = length/ 2;

            for (int i = 0; i < halfLength; i++)
            {
                (array[i], array[i + halfLength]) = (array[i + halfLength], array[i]);
            }

            Console.WriteLine("Перемещенный массив:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
    }
}