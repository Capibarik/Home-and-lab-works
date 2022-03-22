using System;

class Program
{
    static void Main(string[] args)
    {
        int n; // размерность массива
        do
        {
            Console.Write("Введите натуральное нечетное число:");
            n = Convert.ToInt32(Console.ReadLine());
        }
        while (n <= 0 | n % 2 == 0);
        double[,] mas = new double[n, n]; // объявление двумерного массива

        int num = 1;
        for (int i = 0; i <= n / 2; i++)
        {
            mas[n / 2 - i, n / 2 + i] = Math.Pow(num, 2);
            num += 2;
        }
        int count = 0;
        for (int i = 0; i <= n / 2; i++)
        {
            for (int j = (n - 1) - count - 1; j >= count; j--)
            {
                mas[i, j] = mas[i, j + 1] - 1;
            }
            count++;
        }
        count = 1;
        for (int j = 0; j < n / 2; j++)
        {
            for (int i = count; i <= n - count; i++)
            {
                mas[i, j] = mas[i - 1, j] - 1;
            }
            count++;
        }
        count = 1;
        for (int i = n - 1; i > n / 2; i--)
        {
            for (int j = count; j <= n - count; j++)
            {
                mas[i, j] = mas[i, j - 1] - 1;
            }
            count++;
        }
        count = 2;
        for (int j = n - 1; j > n / 2; j--)
        {
            for (int i = n - count; i >= count - 1; i--)
            {
                mas[i, j] = mas[i + 1, j] - 1;
            }
            count++;
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
                if (mas[i, j] >= 1 & mas[i, j] < 10)
                    Console.Write(mas[i, j] + "   ");
                else if (mas[i, j] >= 10 & mas[i, j] < 99)
                    Console.Write(mas[i, j] + "  ");
                else
                    Console.Write(mas[i, j] + " ");
            }
            Console.WriteLine(" ");
        }
    }
}