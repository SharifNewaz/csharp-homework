using System;
namespace ColorOOP
{
	public class Colors
	{
        public Colors(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Colors(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }

        public int grayscaleValue()
        {
            return (Red + Green + Blue) / 3;
        }
    }

	public class Ball : Colors
    {
        public Ball(int ballSize, byte red, byte green, byte blue, byte alpha):base(red, green,blue, alpha)
        {
            BallSize = ballSize;
            TimesBallThrown = 0;
        }

        public int BallSize;
        public int TimesBallThrown { get; set; }

        public void Pop()
        {
            BallSize = 0;
        }

        public void ThrowBall()
        {
            if(BallSize > 0)
            {
                TimesBallThrown++;
            }
        }
    }
}

