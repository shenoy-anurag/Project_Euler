using System;
//using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Brute force solution. 
            long number = 2520;
            void Display()
            {
                Console.WriteLine("The Smallest number divisible by the digits from 1 to 20 is: {0}", number);
                //Console.ReadKey();
            }
            while(number > 1)
            {
                int divisor;
                for (divisor = 2; divisor <= 20; divisor++)
                    if (number % divisor != 0)
                        break;
                if (divisor != 21)
                    number++;
                else if (divisor == 21)
                {
                    break;
                }
            }
            Display();
        }

    }
}
