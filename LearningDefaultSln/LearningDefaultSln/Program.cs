//04:13:00 с#
using System;
namespace LearningDefaultSln
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели {input}");
        }
    }
}