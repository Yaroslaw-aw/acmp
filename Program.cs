using System;
namespace acmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ABC = Console.ReadLine();

            string[] numbers = ABC.Split();

            uint A = (uint)Convert.ToInt32(numbers[0]);
            uint B = (uint)Convert.ToInt32(numbers[1]);
            uint C = (uint)Convert.ToInt32(numbers[2]);

            uint max = A;
            uint min = B;

            if (B > A)
            {
                max = B;
                min = A;
            }

            if (C > max)
                max = C;
            if (C < min)
                min = C;
            Console.WriteLine(max - min);

        }
    }
}