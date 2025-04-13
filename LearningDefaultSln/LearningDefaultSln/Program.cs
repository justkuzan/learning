//02:39:18
//while, когда мы не знаем четкие границы цикла. Когда мы точно можем посчитать кол-во шагов и размер цикла, то мы используем for
using System;
using System.Text;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int rightPassword = 1234;
            int triesCount = 3;
            string userInput;
            
            for (int i = 0; i < triesCount; i++)
            {
                Console.WriteLine("Введите пароль");
                userInput = Console.ReadLine();
                
                if (Convert.ToInt32(userInput) == rightPassword)
                {
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Неверный пароль. У вас осталось {triesCount - (i+1)} попытки");
                }
            }
            Console.WriteLine("Попытки закончились. Доступ заблокирован.");
        }
    }
}