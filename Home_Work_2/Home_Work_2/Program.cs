using System;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double x = -6; x <= 12; x += 0.2)
            {
                if (x <= -4)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1());
                }
                else if (x >= -4 && x <= 0)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x));
                }
                else if (x >= 0 && x <= 2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment3(x));
                }
                else if (x >= 2 && x <= 12)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment4(x));
                }
            }

        }
        static double segment1()
        {
            double y = -2;
            return y;
        }
        static double segment2(double x)
        {
            double y = x / 4.0;
            return y;
        }
        static double segment3(double x)
        {
            if (x >= 0)
            {
                double y = Math.Pow(x, 2);
                return y;
            }
            else
            {
                double y = 0;
                return y;
            }
        }
        static double segment4(double x)
        {
            double y = -0.5 * x + 5;
            return y;
        }
    }
}
