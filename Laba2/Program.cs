using System;
using Lab2.CalcManager;

namespace Lab2
{
    class Program
    {
        static void Main()
        {
            CalcManager manager = new CalcManager();

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите выражение (пример: 5 + 3 или sqrt 9):");
                    string input = Console.ReadLine().Trim();

                    string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length < 2)
                    {
                        Console.WriteLine("Неверный формат ввода!");
                        continue;
                    }

                    string operand = parts[1];
                    double a = Convert.ToDouble(parts[0]);
                    double b = 0;
                    if (parts.Length  > 2)
                    {
                        b = Convert.ToDouble(parts[2])
                    }

                    double result = manager.Manage(operand, a, b);
                    Console.WriteLine($"Результат: {result}");

                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Деление на ноль!");
                }
                catch
                {
                    Console.WriteLine("Введен неправильный оператор или число!");
                }
            }
        }
    }
}