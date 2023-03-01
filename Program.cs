using System;

namespace acmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ABC = Console.ReadLine();

            string[] numbers = ABC.Split();

            int A = Convert.ToInt32(numbers[0]);
            int B = Convert.ToInt32(numbers[1]);
            int C = Convert.ToInt32(numbers[2]);

            bool yes = A * B == C;

            bool ok = A <= 100 && B <= 100;

            if (!ok)
            {
                Console.WriteLine("NO");
            }

            if (yes)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }           

        }
    }
}