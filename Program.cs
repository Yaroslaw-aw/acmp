// Требуется сложить два целых числа А и В.
// Входные данные
// В единственной строке входного файла INPUT.TXT записаны два натуральных числа через пробел. Значения чисел не превышают 10^9.

// Выходные данные
// В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число — сумму чисел А и В.

namespace acmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите два числа через пробел");
            string AB = Console.ReadLine();

            string[] numbers = AB.Split();

            uint A = (uint)Convert.ToInt32(numbers[0]);
            uint B = (uint)Convert.ToInt32(numbers[1]);

            Console.WriteLine(A + B);
        }
    }
}