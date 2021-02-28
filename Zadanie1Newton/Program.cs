using System;

namespace Zadanie1Newton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine(SqrtN(n, A));
            Console.ReadKey();
        }


        static double SqrtN(double n, double A, double eps = 0.0001)
        {
            var x0 = A / n;
            var x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, n - 1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, n - 1));
            }

            return x1;
        }
    }
}