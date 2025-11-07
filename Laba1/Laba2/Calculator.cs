using System;

namespace Laba2
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
                throw new ArgumentException();
            return Math.Sqrt(a);
        }
        public double Sqrt(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException();
            if (a < 0)
                throw new ArgumentException();
            return Math.Pow(a, 1.0 / b);
        }

        public double Exp(double a)
        {
            return Math.Exp(a);
        }

        public double Sin(double deg)
        {
            return Math.Sin(deg * Math.PI / 180);
        }

        public double Cos(double deg)
        {
            return Math.Cos(deg * Math.PI / 180);
        }

        public double Tan(double deg)
        {
            return Math.Tan(deg * Math.PI / 180);
        }

        public double Cot(double deg)
        {
            if (Math.Tan(deg * Math.PI / 180) == 0)
                throw new DivideByZeroException();
            return 1 / Math.Tan(deg * Math.PI / 180);
        }

        public double Log(double a, double Base)
        {
            if (a <= 0 || Base <= 0 || Base == 1)
                throw new ArgumentException();
            return Math.Log(a, Base);
        }

        public double Ln(double a)
        {
            if (a <= 0)
                throw new ArgumentException();
            return Math.Log(a);
        }
    }
}
