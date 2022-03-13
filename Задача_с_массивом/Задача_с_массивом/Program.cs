using System;

namespace Задача_с_массивом
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] mas = new int[8];
            int[] new_mas = new int[8];
            for (uint i = 0; i <= 7; i++)
            {
                mas[i] = rnd.Next(1, 20);
                Console.Write(mas[i] + ", ");
            }
            Console.WriteLine("\n+6 ко всем элементам массива");
            for (uint i = 0; i <= 7; i++)
            {
                new_mas[i] = mas[i] + 6;
                Console.Write(new_mas[i] + ", ");
            }
            Console.ReadKey();
        }
    }
}
