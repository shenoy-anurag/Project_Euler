using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            const long num = 600851475143;
            long num2 = num, i = 2, largest_prime_factor = 1;
            //long[] prime_factors = new long[1000];
            //Program prog = new Program();
            //num2 = long.Parse(Console.ReadLine());
            while(i*i <= num2)
            {
                if(num2 % i == 0)
                {
                    num2 /= i;
                    largest_prime_factor = i;
                }
                else
                {
                    if (i == 2)
                        i = 3;
                    else
                        i += 2;
                }
            }
            if (num2 > largest_prime_factor)
            { // the remainder is a prime number
                largest_prime_factor = num2;
            }
            if (largest_prime_factor == 1) Console.WriteLine("Error");
            Console.WriteLine("Largest Prime Factor of {0} is: {1}", num, largest_prime_factor);

            Console.ReadKey();
        }//END   Factors
    }
}
