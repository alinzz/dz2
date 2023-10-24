using System;

 namespace kr2
{
    internal class z1
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] newElements = { 6, 7, 8 };
            Console.WriteLine("Введите число k (от 1 до 5)");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            int[] newArray = new int[array.Length + newElements.Length];
            Array.Copy(array, newArray, k);
            Array.Copy(newElements, 0, newArray, k, newElements.Length);
            Array.Copy(array, k, newArray, k + newElements.Length, array.Length - k);
            foreach (int elem in newArray)
            {
                Console.WriteLine(elem + " ");
            }
        }
    }
}