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

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomArrayLength.Next(1,10);
                Console.Write(array[i]+" ");
            }
            
            Console.WriteLine("\nИндекс какого числа вы ищите?");
            int desiredNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length ; i++)
            {
                if (array[i] == desiredNumber)
                {
                    Console.WriteLine($"Индекс числа {desiredNumber}: {i}");
                    break;
                }
                
                else if (desiredNumber != array[i])
                {
                    Console.WriteLine("Число не найдено");
                    break;
                }
            }
            
        }
    }
}