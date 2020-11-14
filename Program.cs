using System;

namespace FillwordMenu
{
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
        static void Main(string[] args)
        {
            string[] menu = Menu();
            for (int i=0;i<menu.Length;i++)
            {
                Console.WriteLine(menu[i]);
            }
        }
    }
}
