//05:52:00 с#
using System;
namespace LearningDefaultSln
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomArrayLength = new Random();
            int[] array =  new int[randomArrayLength.Next(10, 15)];

            Console.WriteLine("Массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomArrayLength.Next(1,10);
                Console.Write(array[i]+" ");
            }
            
            Console.WriteLine("\nИндекс какого числа вы ищите?");
            int desiredNumber = int.Parse(Console.ReadLine());
            IndexOf(array, desiredNumber);

        }

        static int IndexOf(int[] array, int desiredNumber)
        {
            for (int i = 0; i < array.Length ; i++)
            {
                if (array[i] == desiredNumber)
                {
                    Console.WriteLine($"Индекс числа {desiredNumber}: {i}");
                    return i;
                }
            }
            Console.WriteLine("Число не найдено");
            return -1;
        }
    }
}