using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Class1
    {
        static void Main()
        {

            int X = 17;
            int Y = 22;
            double N = 30.23;
            double M = 40.46;

            double A = Convert.ToDouble(X);
            double B = Convert.ToDouble(Y);

            Console.WriteLine(X + Y);
            Console.WriteLine(X - Y);
            Console.WriteLine(X * Y);
            Console.WriteLine(X / Y);
            Console.WriteLine(X % Y);
            Console.WriteLine(N + M);
            Console.WriteLine(N - M);
            Console.WriteLine(N * M);
            Console.WriteLine(N / M);
            Console.WriteLine(N % M);
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(A + B + X + Y);
            Console.WriteLine(A * B * X * Y);



        }

    }
}
