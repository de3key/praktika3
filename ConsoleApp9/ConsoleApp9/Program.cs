using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int x = Convert.ToInt32(Console.ReadLine());
            int a = x / 100;
            int b = x % 100 / 10;
            int c = x % 10;
            int g = a + b + c;
            if (g % 5 == 0)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
            Console.ReadKey();
        }
    }
}
