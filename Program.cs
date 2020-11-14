using System;

namespace menu
{
    public class Menu
    {
        public Menu(int i)
        {
            if (i == 1)
            {
                NewGame();
            }
            else if (i == 2)
            {
                Continue();
            }
            else if (i == 3)
            {
                Rating();
            }
            else if (i == 4)
            {
                Exit();
            }
        }
        private static void NewGame()
        {
            Console.Clear();
            Console.WriteLine("Введите имя:");
            Console.ReadLine();
        }
        private static void Continue()
        {
            Console.Clear();
            Console.WriteLine("Функция <<продолжить>> скоро появится");
        }
        private static void Rating()
        {
            Console.Clear();
            Console.WriteLine("Функция <<рейтинг>> скоро появится");
        }
        private static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Функция <<выход>> скоро появится");
        }
    }
    class Program
    {
        private static string[] Menu()
        {
            string[] menu = new string[5];
            menu[0] = "       Игра <<Филворды>>";
            menu[1] = "          новая игра";
            menu[2] = "          продолжить";
            menu[3] = "           рейтинг";
            menu[4] = "            выход";
            return menu;
        }

        private static void GetMenuItem(string[] array)
        {
            ConsoleKeyInfo key;
            int y = 1;

            do
            {
                Console.Clear();
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }

                Console.SetCursorPosition(0, y);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(array[y]);
                Console.ForegroundColor = ConsoleColor.Gray;

                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                    y--;
                if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                    y++;
                if (key.Key == ConsoleKey.Enter)
                {
                    var action = new Menu(y);
                }

                if (y < 1) y = 4;
                if (y > 4) y = 1;

            }
            while (key.Key != ConsoleKey.Enter);
        }

        static void Main(string[] args)
        {
            string[] menu = Menu();
            GetMenuItem(menu);
        }
    }
}
