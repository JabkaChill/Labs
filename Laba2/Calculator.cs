namespace Lab2
{
    class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Sqrt(double a)
        {
            if (a < 0)
                throw new ArgumentException("Нельзя извлечь корень из отрицательного числа");
            return Math.Sqrt(a);
        }

        public double Exp(double a)
        {
            return Math.Exp(a);
        }

        public double Sin(double rad)
        {
            return Math.Sin(rad);
        }

        public double Cos(double rad)
        {
            return Math.Cos(rad);
        }

        public double Tan(double rad)
        {
            return Math.Tan(rad);
        }

        public double Cot(double rad)
        {
            if (Math.Tan(rad) == 0)
                throw new DivideByZeroException("Невозможно вычислить котангенс");
            return 1 / Math.Tan(rad);
        }

        public double Log(double a, double Base)
        {
            if (a <= 0 || Base <= 0 || Base == 1)
                throw new ArgumentException("Некорректные значения для логарифма");
            return Math.Log(a, Base);
        }

        public double Ln(double a)
        {
            if (a <= 0)
                throw new ArgumentException("Число должно быть больше 0");
            return Math.Log(a);
        }
    }
}
