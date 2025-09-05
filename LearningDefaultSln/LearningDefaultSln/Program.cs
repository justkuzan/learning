//05:52:00 с#
using System;
namespace LearningDefaultSln
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomArrayLength = new Random();
            int[] array =  new int[randomArrayLength.Next(10, 50)];

            Console.WriteLine("Массив: ");
            
            foreach (var i in array)
            {
                array[i] = randomArrayLength.Next(1,10);
                Console.Write(array[i]+" ");
            }

            Console.WriteLine("\nИндекс какого числа вы ищите?");
            int desiredNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i != desiredNumber ; i++)
            {
                if (i == array.Length)
                {
                    Console.WriteLine("Число не найдено");
                }
                else
                {
                    Console.WriteLine($"Индекс числа {desiredNumber}: {array[i]}");
                }
            }
            
            // Console.WriteLine($"Число {number} находится под индексом {desiredIndex}");
        }
    }
}