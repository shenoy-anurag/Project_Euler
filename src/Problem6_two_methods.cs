using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0, sum2 = 0;
            long squared = 0, squared2 = 0;
            long result = 0, result2 = 0;

            const int N = 100;

            sum = N * (N + 1) / 2;
            squared = (N * (N + 1) * (2 * N + 1)) / 6;

            for(int i = 1; i <= 100; i++)
            {
                sum2 += i;
                squared2 = squared2 + i * i;
            }
            result2 = sum2 * sum2 - squared2;

            result = sum * sum - squared;
            Console.WriteLine("The Difference is : {0}, {1}", result, result2);
            Console.ReadKey();
        }

    }
}