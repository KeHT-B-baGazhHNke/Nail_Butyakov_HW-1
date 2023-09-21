using System;
using System.Globalization;

namespace Nail_Butyakov_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Задача №1, Вывод Мир Труд Май");
                Console.WriteLine("Мир Труд Май");
                Console.WriteLine("Мир\n  Труд\n      Май");
                Console.ReadKey();
            }

            {
                Console.WriteLine("\nЗадача №2, Смена мест переменных");
                NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
                {
                    NumberDecimalSeparator = ".",
                };
                Console.WriteLine("Введите первое число:");
                string Number1 = Console.ReadLine();
                Console.WriteLine("Введите второе число:");
                string Number2 = Console.ReadLine();
                try
                {
                    bool dot = Number1.Contains(".") ^ Number2.Contains(".");
                    if (dot)
                    {
                        double b = Convert.ToDouble(Number1, numberFormatInfo);
                        double a = Convert.ToDouble(Number2, numberFormatInfo);
                        Console.WriteLine($"{a}, {b}");
                    }
                    else
                    {
                        double b = Convert.ToDouble(Number1);
                        double a = Convert.ToDouble(Number2);
                        Console.WriteLine($"{a}, {b}");
                    }
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка! Введены неверные данные");
                    Console.ReadKey();
                }
            }

            {
                Console.WriteLine("\nЗадача №3, Нахождение радиуса окружности и площади круга");
                Console.WriteLine("Введите радиус окружности:");
                string Rstr = Console.ReadLine();
                double R = Convert.ToDouble(Rstr);
                double L = 2 * Math.PI * R;
                double S = Math.PI * R * R;
                Console.WriteLine($"Длина окружности L = {L}");
                Console.WriteLine($"Площадь круга S = {S}");
                Console.ReadKey();
            }

            {

                Console.WriteLine("\nЗадача №4, Нахождение значения y = cos(x)");
                Console.WriteLine("Введите угол x в радианах");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Math.Cos(x);
                Console.WriteLine($"Косинус x = {y}");
                Console.ReadKey();
            }

            {
                Console.WriteLine("\nЗадача №5, Решение квадратного уравнения");
                Console.Write("Введите коэффциенты a b c квадратного уравнения\nВведите a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите с: ");
                double c = Convert.ToDouble(Console.ReadLine());
                double D = b * b - 4 * a * c;
                if (D == 0)
                {
                    double x = (b * (-1)) / 2;
                    Console.WriteLine($"Корень уравнения x = {x}");
                }
                if (D > 0)
                {
                    double x1 = (b * (-1) + Math.Sqrt(D)) / 2;
                    double x2 = (b * (-1) - Math.Sqrt(D)) / 2;
                    Console.WriteLine($"Корни уравнения x1 = {x1}, x2 = {x2}");
                }
                if (D < 0)
                {
                    Console.WriteLine("Нет корней");
                }
                Console.ReadKey();

            }

            {
                Console.WriteLine("\nЗадача №6, Обмен значениями трех переменных двум схемам");
                Console.Write("Введите значения переменных\nВведите a: ");
                string a = Console.ReadLine();
                Console.Write("Введите b: ");
                string b = Console.ReadLine();
                Console.Write("Введите c: ");
                string c = Console.ReadLine();
                Console.WriteLine("Первая схема:");
                string p1 = b;
                string p2 = a;
                b = c;
                a = p1;
                c = p2;
                Console.WriteLine($"а = {a}, b = {b}, c = {c}");
                Console.WriteLine("Вторая схема:");
                p1 = b;
                b = c;
                c = a;
                a = p1;
                Console.WriteLine($"а = {a}, b = {b}, c = {c}");
                Console.ReadKey();
            }

            {
                Console.WriteLine("\nЗадача №7, Вывод «столбиком» четырех случайных чисел");
                Random rnd = new Random();
                int n1 = rnd.Next();
                int n2 = rnd.Next();
                int n3 = rnd.Next();
                int n4 = rnd.Next();
                Console.WriteLine($"{n1}\n{n2}\n{n3}\n{n4}");
                Console.ReadKey();
            }

            {
                Console.WriteLine("\nЗадача №8, работа со строками");
                Console.Write("Введите трехзначное число: ");
                string n = Console.ReadLine();
                Console.WriteLine(n[2] + n.Remove(2));
                Console.ReadKey();
            }

            {
                Console.WriteLine("\nЗадача №9, Нахождение стоимости покупки");
                Console.Write("Введите стоимость 1 кг конфет: ");
                double candies = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите стоимость 1 кг печенья: ");
                double cookies = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите стоимость 1 кг яблок: ");
                double apples = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите массу конфет в кг: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите массу печенья в кг: ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите массу яблок в кг: ");
                double z = Convert.ToDouble(Console.ReadLine());
                double cost = candies * x + cookies * y + apples * z;
                Console.WriteLine($"Стоимость покупки равна: {cost}");
                Console.ReadKey();
            }
        }
    }
}