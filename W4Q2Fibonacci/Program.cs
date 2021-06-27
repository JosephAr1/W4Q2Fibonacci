using System;

namespace W4Q2Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Please Enter a Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            Fibo(num);
        }

        static void Fibo(int num)
        {
            int a = 0, b = 1, c = 0;

            Console.WriteLine("{0} {1}", a, b);

            for(int i = 2; i < num; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }

        }
    }
}
