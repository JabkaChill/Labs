using System;
using Lab2;

namespace Lab2.CalcManager
{
    class CalcManager
    {
        private Calculator calc = new Calculator();

        public double Manage(string command, double a, double b = 0)
        {
            switch (command)
            {
                case "+":
                    return calc.Add(a, b);
                case "-":
                    return calc.Subtract(a, b);
                case "*":
                    return calc.Multiply(a, b);
                case "/":
                    return calc.Divide(a, b);
                case "^":
                    return calc.Power(a, b);
                case "sqrt":
                    return calc.Sqrt(a);
                case "sin":
                    return calc.Sin(a);
                case "cos":
                    return calc.Cos(a);
                case "tan":
                    return calc.Tan(a);
                case "cot":
                    return calc.Cot(a);
                case "log":
                    return calc.Log(a, b);
                case "ln":
                    return calc.Ln(a);
                case "exp":
                    return calc.Exp(a);
                default:
                    throw new Exception("Неизвестный оператор");
            }
        }
    }
}