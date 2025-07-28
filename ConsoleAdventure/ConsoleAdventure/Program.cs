using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.CursorVisible = false;
        char[,] map =
        {
            // 1    2    3    4    5    6    7    8    9    10
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }, // 1
            { '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#' }, // 2
            { '#', ' ', '#', 'x', ' ', ' ', ' ', '#', 'x', '#' }, // 3
            { '#', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', '#' }, // 4
            { '#', ' ', '#', '#', ' ', ' ', ' ', ' ', ' ', '#' }, // 5
            { '#', 'x', ' ', ' ', ' ', ' ', ' ', ' ', 'x', '#' }, // 6
            { '#', ' ', ' ', '#', ' ', ' ', '#', '#', ' ', '#' }, // 7
            { '#', ' ', ' ', '#', '#', ' ', '#', ' ', ' ', '#' }, // 8
            { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', 'x', '#' }, // 9
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }, // 10
        };

        int userX = 1, userY = 1;

        while (true)
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }

                Console.WriteLine();
            }

            Console.SetCursorPosition(userY, userX);
            Console.Write('@');

            ConsoleKeyInfo charKey = Console.ReadKey();
            switch (charKey.Key)
            {
                case ConsoleKey.UpArrow:
                    if (map[userX - 1, userY] != '#')
                    {
                        userX--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (map[userX + 1, userY] != '#')
                    {
                        userX++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (map[userX, userY-1] != '#')
                    {
                        userY--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (map[userX, userY+1] != '#')
                    {
                        userY++;
                    }
                    break;
            }
            
            Console.Clear();
        }
    }
}