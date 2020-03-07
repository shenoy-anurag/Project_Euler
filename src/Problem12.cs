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
            bool has500Factors = false;
            long number = 0, sum = 0, factors = 0;
            int i = 0, j = 0, k = 0, count;
            while(!has500Factors)
            {
                //number = TriangleNumber(k);
                //factors = NumberOfFactors(number);
                factors = NumberOfFactors(k);
                if (factors > 500)
                {
                    has500Factors = true;
                    number = sum;
                }  
                k++;
            }
            int NumberOfFactors(int n)
            {
                sum = 0;
                count = 0;
                sum = (n * (n + 1)) / 2;
                int sqrt = (int)Math.Sqrt(sum);

                for (i = 1; i <= sqrt; i++)
                {
                    if (sum % i == 0)
                    {
                        count += 2;
                    }
                }
                //Correction if the number is a perfect square
                if (sqrt * sqrt == sum)
                {
                    count--;
                }
                return count;
            }
            /*
            long TriangleNumber(int x)
            {
                sum = 0;
                for (i = 1; i <= x; i++)
                {
                    sum += i;
                }
                return sum;
            }
            int NumberOfFactors(long x)
            {
                count = 0;
                for (j = 1; j <= x; j++)
                {
                    if (x % j == 0)
                        count++;
                }
                return count;
            }
            */

            Console.WriteLine("Value of first triangle number to have more than 500 factors is: {0}", number);
            Console.ReadKey();
        }

    }
}