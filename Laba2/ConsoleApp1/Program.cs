// See https://aka.ms/new-console-template for more information
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
                    Console.WriteLine("Введите арифметическое выражение с пробелами между числами и оператором():");
                    string exp = "";
                    exp = Console.ReadLine();
                    string[] dig = exp.Split(' ');
                    double dig1 = Convert.ToDouble(dig[0]);
                    double dig2 = Convert.ToDouble(dig[2]);
                    string operand = dig[1];
                    double ans = 0;

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
                            ans = dig1 / dig2;
                            break;
                        case "^":
                            ans = Math.Pow(dig1, dig2);
                            break;
                        case "sqrt":
                            ans = Math.Pow(dig1, 1 / dig2);
                            break;
                        case "log":
                            ans = Math.Log(dig1, dig2);
                            break;
                        case "ln":
                            ans = Math.Log(dig1);
                            break;
                    }
                    Console.WriteLine("\n Ответ: " + exp + " = " + Convert.ToString(ans));
                }
                catch
                {
                    Console.WriteLine("Введен неправильный оператор или число!");
                }
            }
        }

    }

}

