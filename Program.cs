using System;
namespace acmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            string result = Convert.ToString(number + "9" + (9 - number % 100));

            Console.WriteLine(result);
        }
    }
}

