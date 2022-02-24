using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2102_Учебные_задания
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано целое число в диапазоне от 10 до 40,\nопределяющих количество учебных заданий (число вводит пользователь или функция случайных чисел) по некоторой теме.\nВывести строку описания указанного количество заданий, обеспечив\nправильное согласование числа со словами.");
            while (true)
            {
                Console.WriteLine("Чтобы выйти, нажмите Ctrl + C");
                Random rnd = new Random(); // создаем экземпляр класса Random()
                string end1 = "ых";
                string end2 = "ий";
                int q = rnd.Next(10, 40); // количество учебных заданий, выбранное случайным образом
                if ((q >= 22) & (q <= 24) | (q >= 32) & (q <= 34))
                {
                    end2 = "ия";
                }
                else
                {
                    switch (q)
                    {
                        case 21:
                        case 31:
                            {
                                end1 = "ое";
                                end2 = "ие";
                            }
                            break;
                    }
                }
                Console.WriteLine($"{q} учебн{end1} задан{end2}");
                Console.ReadKey();
            }

        }
    }
}
