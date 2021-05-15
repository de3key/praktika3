using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи сюда свой z");
            double z = Convert.ToDouble(Console.ReadLine());
            double a = 0;
            if (z > 0)
            {
                a = 1;
            }
            if (z == 0)
            {
                a = 0;
            }
            if (z < 0)
            {
                a = -1;
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
