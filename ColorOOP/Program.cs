using System;

namespace ColorOOP
{
    class Program
    {
        public static void Main()
        {
            //instantiate and print the values
            Ball firstBall = new (5, 12, 32, 12, 5);
            Console.WriteLine("First Ball: ");
            Console.WriteLine("Size = " + firstBall.BallSize);
            Console.WriteLine("Red = " + firstBall.Red);
            Console.WriteLine("Green = "+ firstBall.Green);
            Console.WriteLine("Blue = "+ firstBall.Blue);
            Console.WriteLine("First Ball thrown " + firstBall.TimesBallThrown + " times");
            Console.WriteLine();

            Ball secondBall = new(6, 124, 232, 57, 55);
            Console.WriteLine("Second Ball: ");
            Console.WriteLine("Size = " + secondBall.BallSize);
            Console.WriteLine("Red = " + secondBall.Red);
            Console.WriteLine("Green = " + secondBall.Green);
            Console.WriteLine("Blue = " + secondBall.Blue);
            Console.WriteLine("Second Ball thrown " + secondBall.TimesBallThrown + " times");
            Console.WriteLine();

            Ball thirdBall = new(98, 12, 32, 200, 43);
            Console.WriteLine("Third Ball: ");
            Console.WriteLine("Size = " + thirdBall.BallSize);
            Console.WriteLine("Red = " + thirdBall.Red);
            Console.WriteLine("Green = " + thirdBall.Green);
            Console.WriteLine("Blue = " + thirdBall.Blue);
            Console.WriteLine("Third Ball thrown " + thirdBall.TimesBallThrown + " times");
            Console.WriteLine();

            Console.WriteLine("After throwing the ball around and poping we should see different values for Ballthrown.");

            //throw the ball around
            firstBall.ThrowBall();
            secondBall.ThrowBall();
            firstBall.ThrowBall();
            thirdBall.ThrowBall();
            firstBall.Pop();
            firstBall.ThrowBall();
            secondBall.Pop();
            thirdBall.ThrowBall();
            Console.WriteLine();

            Console.WriteLine("First Ball thrown " + firstBall.TimesBallThrown + " times");
            Console.WriteLine("Second Ball thrown " + secondBall.TimesBallThrown + " times");
            Console.WriteLine("Third Ball thrown " + thirdBall.TimesBallThrown + " times");

            Console.ReadLine();
        }
    }
}
