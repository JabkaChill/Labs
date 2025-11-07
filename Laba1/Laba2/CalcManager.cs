using System;
using System.Data;
using System.Text.RegularExpressions;

namespace Laba2
{
    class CalcManager
    {
        private Calculator calc = new Calculator();

        public double Manage(string input)
        {
            input = input.Replace(',', '.');

            if (Regex.IsMatch(input, @"[a-z]+\s*\("))
            {
                input = ConvertExpression(input);
            }

            if (input.Contains("(") || input.Contains(")"))
            {
                return DTExpression(input);
            }

            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 2)
                throw new ArgumentException();

            string operand = parts[1];
            double a = Convert.ToDouble(parts[0]);
            double b = 0;
            if (parts.Length > 2)
            {
                b = Convert.ToDouble(parts[2]);
            }

            switch (operand)
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
                case "sqrt" when parts.Length == 2:
                    return calc.Sqrt(a);
                case "sqrt" when parts.Length == 3:
                    return calc.Sqrt(a, b);
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
                    throw new Exception();
            }
        }
        private string ConvertExpression(string expression)
        {
            bool found = true;

            while (found)
            {
                found = false;

                var match = Regex.Match(expression, @"(?<func>sin|cos|tan|cot|sqrt|ln|exp|log)\s*\((?<args>[^()]+)\)");
                if (match.Success)
                {
                    found = true;

                    string func = match.Groups["func"].Value;
                    string args = match.Groups["args"].Value;
                    double result = 0;

                    if (Regex.IsMatch(args, @"[a-z]+\s*\("))
                    {
                        args = ConvertExpression(args);
                    }

                    string[] parts = args.Split(',', StringSplitOptions.RemoveEmptyEntries);

                    double a = Convert.ToDouble(parts[0]);
                    double b = 0;
                    if (parts.Length > 1)
                    {
                        b = Convert.ToDouble(parts[1]);
                    }
                    switch (func)
                    {
                        case "sqrt" when parts.Length == 1:
                            result = calc.Sqrt(a); break;
                        case "sqrt" when parts.Length == 2:
                            result = calc.Sqrt(a, b); break;
                        case "sin":
                            result = calc.Sin(a); break;
                        case "cos":
                            result = calc.Cos(a); break;
                        case "tan":
                            result = calc.Tan(a); break;
                        case "cot":
                            result = calc.Cot(a); break;
                        case "log":
                            result = calc.Log(a, b); break;
                        case "ln":
                            result = calc.Ln(a); break;
                        case "exp":
                            result = calc.Exp(a); break;
                    }
                    expression = expression.Replace(match.Value, result.ToString());
                }
            }
        return expression;
        }
        private double DTExpression(string expression)
        {
            using (var table = new DataTable())
            {
                try
                {
                    var result = table.Compute(expression, "");

                    return Convert.ToDouble(result);
                }
                catch (Exception)
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}