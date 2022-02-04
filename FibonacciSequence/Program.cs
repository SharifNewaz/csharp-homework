using System;

namespace Program
{
    class FibonacciSequence
    {
        public static void Main(string [] args)
        {
            Console.Write("Enter a num: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fibNum = Fibonacci(num);
            Console.WriteLine(fibNum);

            Console.ReadLine();
        }

        public static int Fibonacci(int num)
        {
            if (num < 2)
                return num;

            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }

    }
}