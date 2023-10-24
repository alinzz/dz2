using System;
namespace kr2
{
    internal class z3
    {
        static Random rnd = new Random();

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите размер первого массива: ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер второго массива: ");
            int size2 = Convert.ToInt32(Console.ReadLine());
            int[] array1 = InitializeArray(size1);
            int[] array2 = InitializeArray(size2);

            Console.WriteLine("Массив 1:");
            PrintArray(array1);

            Console.WriteLine("Массив 2:");
            PrintArray(array2);

            Console.WriteLine("Поэлементное сложение массивов:");
            if (array1.Length == array2.Length)
            {
                int[] sumArray = SumArrays(array1, array2);
                PrintArray(sumArray);
            }
            else  Console.WriteLine("Невозможно выполнить, размеры массивов не равны");

            Console.WriteLine("Введите число для умножения на массивы:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Поэлементное умножение массива 1 на число:");
            int[] mulArray1 = MultiplyArray(array1, num);
            PrintArray(mulArray1);

            Console.WriteLine("Поэлементное умножение массива 2 на число:");
            int[] mulArray2 = MultiplyArray(array2, num);
            PrintArray(mulArray2);

            Console.WriteLine("Общие значения в массиве 1 и массиве 2:");
            int[] commonValues = FindCommonValues(array1, array2);
            PrintArray(commonValues);

            Console.WriteLine("Массив 1 в порядке убывания:");
            OrderArrayDescending(array1);
            PrintArray(array2);

            Console.WriteLine("Массив 2 в порядке убывания:");
            OrderArrayDescending(array2);
            PrintArray(array2);

            Console.WriteLine("Минимальное значение в массиве 1: " + FindMinValue(array1));
            Console.WriteLine("Максимальное значение в массиве 1: " + FindMaxValue(array1));
            Console.WriteLine("Среднее значение в массиве 1: " + FindAverageValue(array1));

            Console.WriteLine("Минимальное значение в массиве 2: " + FindMinValue(array2));
            Console.WriteLine("Максимальное значение в массиве 2: " + FindMaxValue(array2));
            Console.WriteLine("Среднее значение в массиве 2: " + FindAverageValue(array2));
        }

        static int[] InitializeArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(1, 100); // случайное число от 1 до 100
            }

            return array;
        }

        static int[] SumArrays(int[] array1, int[] array2)
        {
            int size = Math.Min(array1.Length, array2.Length);
                int[] sumArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    sumArray[i] = array1[i] + array2[i];
                }

                return sumArray;
        }

        static int[] MultiplyArray(int[] array, int a)
        {
            int size = array.Length;
            int[] mulArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                mulArray[i] = array[i] * a;
            }

            return mulArray;
        }

        static int[] FindCommonValues(int[] array1, int[] array2)
        {
            int size = Math.Min(array1.Length, array2.Length);
            int[] commonValues = new int[size];
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        commonValues[count] = array1[i];
                        count++;
                        break;
                    }
                }
            }
            Array.Resize(ref commonValues, count);
            return commonValues;
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }

        static void OrderArrayDescending(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
        }

        static int FindMinValue (int [] array)
        {
            int min = array [0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <min)
                    min = array[i];
            }
            return min;
        }

        static int FindMaxValue (int [] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        static double FindAverageValue (int [] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double avg = (double) sum/array.Length;
            return avg;
        }
    }
}