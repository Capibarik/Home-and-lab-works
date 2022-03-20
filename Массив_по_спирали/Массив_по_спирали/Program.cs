using System;

namespace Массив_по_спирали
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; // размерность массива
            do
            {
                Console.Write("Введите положительную нечетную размерность массива:");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while ((n <= 0) | (n % 2 == 0));
            double[,] mas = new double[n, n]; // объявление двумерного массива

            int num = 1;
            for (int i = 0; i <= n / 2; i++)
            {
                mas[n / 2 - i, n / 2 + i] = Math.Pow(num, 2);
                num += 2;
            }

            WriteMassive(mas, n);
            Console.ReadKey();
        }
        static void WriteMassive(double[,] mas, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
