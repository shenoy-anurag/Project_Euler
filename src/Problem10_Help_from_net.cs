//https://stackoverflow.com/questions/18157322/find-the-sum-of-all-the-primes-below-two-million-project-euler-c
//https://projecteuler.net/problem=10
/*
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.

Answer:
142913828922
Completed on Wed, 11 Jul 2018, 08:25
*/
using System;

namespace Project_Euler
{
    class Problem
    {
        static void Main(string[] args)
        {
            //int prime;
            long sum = 0;
            //bool isPrime;
            for(int i = 2; i <= 2000000; i++)
            {
                if (PrimeFinder(i) == 1)
                {
                    sum = sum + i;
                }//isPrime = PrimeFinder(i);
            }

            Console.WriteLine("The Sum of all Primes below 2 Million is: {0}", sum);
            Console.ReadKey();
        }
        public static int PrimeFinder(int x)
        {
            int count = 0, number;
            number = x;
            for (int k = 2; k <= Math.Sqrt(x); k++)
            {
                if (x % k == 0)
                {
                    return 0;
                }
                else {
                    ;
                }
            }
            return 1;
        }
    }
}
