namespace Lab_1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите выражение с пробелами между числами и оператором(например: 22 + 30):");
                    string exp = Console.ReadLine().Trim();
                    string[] parts = exp.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length < 2)
                    {
                        Console.WriteLine("Ошибка: неверный формат ввода!");
                        continue;
                    }

                    string operand = parts[1];
                    double ans = 0;
                    double dig1 = 0;
                    double dig2 = 0;

                    if (parts.Length == 3)
                    {
                        dig1 = Convert.ToDouble(parts[0]);
                        dig2 = Convert.ToDouble(parts[2]);
                    }
                    else if (parts.Length == 2)
                    {
                        dig1 = Convert.ToDouble(parts[0]);
                    }

                    switch (operand)
                    {
                        case "+":
                            ans = dig1 + dig2;
                            break;
                        case "-":
                            ans = dig1 - dig2;
                            break;
                        case "*":
                            ans = dig1 * dig2;
                            break;
                        case "/":
                            if (dig2 == 0)
                                throw new DivideByZeroException();
                            ans = dig1 / dig2;
                            break;
                        case "^":
                            ans = Math.Pow(dig1, dig2);
                            break;
                        case "sqrt":
                            ans = Math.Pow(dig1, 1.0 / dig2);
                            break;
                        case "log":
                            ans = Math.Log(dig1, dig2);
                            break;
                        case "ln":
                            ans = Math.Log(dig1);
                            break;
                        default:
                            Console.WriteLine("Неизвестный оператор!");
                            continue;
                    }

                    Console.WriteLine($"\nОтвет: {exp} = {ans}");
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

