using System;

namespace Program
{
    class ReverseArray
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the array length: ");
            int arrLength = Convert.ToInt32(Console.ReadLine());
            int[] numbers = GenerateNumbers(arrLength);

            Console.Write($"Before reversing: ");
            PrintNumbers(numbers);

            Reverse(numbers);
            Console.WriteLine();

            Console.Write($"After reversing: ");
            PrintNumbers(numbers);

            Console.WriteLine();

            Console.ReadLine();
        }

        public static int[] GenerateNumbers(int length)
        {
            int[] randNumber = new int[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                randNumber[i] = random.Next(1, 10);
            }
            return randNumber;
        }

        public static void Reverse(int[] numbers)
        {
            int start = 0;
            int end = numbers.Length - 1;

            //swap using two pointer
            while (start < end)
            {
                int temp = numbers[start];
                numbers[start] = numbers[end];
                numbers[end] = temp;
                start++;
                end--;
            }
        }

        public static void PrintNumbers(int[] numbers)
        {

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}