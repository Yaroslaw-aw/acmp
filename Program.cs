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
            int[] array(int _a)
            {
                int[] array_of_minutes = new int[_a];
                int minutes;

                for (int i = 0; i < array_of_minutes.Length; i++)
                {
                    minutes = new Random().Next(10, 301);
                    array_of_minutes[i] = minutes - minutes % 10;
                }
                return array_of_minutes;
            }

            (int sum5, int sum3, int count5, int count3) result_5_3(int[] _array)
            {
                int sum5 = 0, sum3 = 0, sum_sum5 = 0, sum_sum3 = 0;
                int count5 = 0, count3 = 0;

                for (int i = 0; i < _array.Length; i++)
                {
                    sum5 += _array[i];

                    sum3 += _array[_array.Length - 1 - i];

                    if (sum_sum5 + sum5 <= 300)
                    {
                        sum_sum5 += sum5;
                        count5++;
                    }

                    if (sum_sum3 + sum3 <= 300)
                    {
                        sum_sum3 += sum3;
                        count3++;
                    }

                    if (sum_sum5 > 300 && sum_sum3 > 300)
                    {
                        break;
                    }
                }
                return (sum_sum5, sum_sum3, count5, count3);
            }

             void sort_to_max(int[] _tasks)
             {
                 int length = _tasks.Length;
                 int max_index, max, length2 = length, temp;

                 for (int i = 0; i < length2 - 1; i++)
                 {
                     max_index = length - 1;
                     max = _tasks[length - 1];

                     for (int j = 0; j < length; j++)
                     {
                         if (_tasks[j] > max)
                         {
                             max = _tasks[j];
                             max_index = j;
                         }
                     }
                     temp = _tasks[length - 1];
                     _tasks[length - 1] = _tasks[max_index];
                     _tasks[max_index] = temp;
                    
                    length--;
                 }
             }

             (int sum1, int count1) result_1(int[] _tasks)
             {
                 int sum1 = 0, count1 = 0, sum_sum1 = 0;

                 for (int i = 0; i < _tasks.Length; i++)
                 {
                     sum1 += _tasks[i];

                     if (sum_sum1 + sum1 <= 300)
                     {
                         sum_sum1 += sum1;
                         count1++;
                     }

                     if (sum_sum1 > 300)
                     {
                         break;
                     }
                 }
                 return (sum_sum1, count1);
             }            

            int N = new Random().Next(1, 11);

            int[] tasks = array(N);                        

            var tasks_5_3 = result_5_3(tasks);          
            
            sort_to_max(tasks);                   
                      
            var tasks_1 = result_1(tasks);

            int sum5 = tasks_5_3.sum5, count5 = tasks_5_3.count5,
                sum3 = tasks_5_3.sum3, count3 = tasks_5_3.count3;

            int sum1 = tasks_1.sum1, count1 = tasks_1.count1;

            int winner = 1;

            if (count3 > count1 || count3 == count1 && sum3 < sum1)
            {
                winner = 3;
            }
            if (count5 > count1 || count5 == count1 && sum5 < sum1)
            {
                winner = 5;
            }
            Console.WriteLine(winner);
        }
    }
}

