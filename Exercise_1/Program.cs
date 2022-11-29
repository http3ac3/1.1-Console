using System;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            while (true)
            {
                try
                {
                    Console.Write("Введите первое число: ");
                    a = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод! Доступен только ввод цифр, запятой и знака \"минус\"\n");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Введите второе число: ");
                    b = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод! Доступен только ввод цифр, запятой и знака \"минус\"\n");
                }
            }
            double aCube = a * a * a;
            double bCube = b * b * b;
            Console.WriteLine
                ($"Куб числа {a} равен {aCube}, " +
                 $"куб числа {b} равен {bCube}, " +
                 $"среднее арифметическое кубов чисел {a} и {b} равно {(aCube + bCube) / 2.0}");
        }
    }
}
