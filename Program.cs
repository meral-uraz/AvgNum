using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvgNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, count = 0;
            while (true)
            {
                Console.WriteLine("Enter numbers (Type '-1' to calculate average): ");          
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == -1) break;
                else
                {
                    sum += num;
                    count++;
                }
            }
            double avgNum = sum / count;
            Console.WriteLine("Average of the entered numbers: " + avgNum 
                + "\nNumber of entered digits: " + count 
                + "\nSum of entered numbers: " + sum);
            Console.ReadKey();
        }
    }
}