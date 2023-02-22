using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Formatters;
using System.Threading;
using System.Threading.Tasks;

namespace acmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = new Random().Next(0, int.MaxValue);
            int b = new Random().Next(0, int.MaxValue);

            if (a > b)
            {
                Console.WriteLine(">");
            }
            if (b > a)
            {
                Console.WriteLine("<");
            }
            if (a == b)
            {
                Console.WriteLine("="); 
            }
        }
    }
}