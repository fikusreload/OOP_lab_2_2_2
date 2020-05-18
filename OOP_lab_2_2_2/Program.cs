using System;

namespace OOP_lab_2_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1;

            while (x <= 6)
            {
                double y = Math.Log10(x);

                Console.WriteLine("x = {0:f1}, y = {1:f4}", x, y);

                x += 0.2;
            }
        }
    }
}
