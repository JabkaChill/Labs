using System;

namespace Laba2
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
                    Console.WriteLine("Введите выражение (пример: 5 + 3 или 9 sqrt):");
                    string input = Console.ReadLine().Trim();


                    double result = manager.Manage(input);
                    Console.WriteLine($"Результат: {result}");

                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Деление на ноль!");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Введен неправильный аргумент, проверте правильность написания выражения");
                }
                catch
                {
                    Console.WriteLine("Введен неправильный оператор или число!");
                }
            }
        }
    }
}