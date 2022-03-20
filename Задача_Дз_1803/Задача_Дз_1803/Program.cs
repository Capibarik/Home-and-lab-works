using System;

namespace Задача_Дз_1803
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            double S = 0;
            do
            {
                Console.Write("Введите положительное n:");
                n = Convert.ToDouble(Console.ReadLine());
            }
            while (n <= 0);
            for (int i = 0; i <= n; i++)
            {
                S += Math.Pow(n + i, 2);
            }
            Console.WriteLine($"Ответ {S}");
            Console.ReadKey();
        }
    }
}
