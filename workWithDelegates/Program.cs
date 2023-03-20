using System;

namespace Assignment8ex2
{
    public class MathSolutions
    {
        delegate double MyDelegate(double a, double b);

        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            Console.WriteLine($" {num1} + {num2} = {answer.GetSum(num1, num2)}");
            Console.WriteLine($" {num1} * {num2} = {answer.GetProduct(num1, num2)}");
            answer.GetSmaller(num1, num2);

            // Action Delegate
            Action<double, double> action = new Action<double, double>(answer.GetSmaller);
            action(num1, num2);

            // func Delegate
            Func<double, double, double> func = new Func<double, double, double>(answer.GetProduct);
            double result = func(num1, num2);
            Console.WriteLine($" {num1} * {num2} = {result}");

            // custom Delegate
            MyDelegate del = new MyDelegate(answer.GetSum);
            result = del(num1, num2);
            Console.WriteLine($" {num1} + {num2} = {result}");
        }
    }
}