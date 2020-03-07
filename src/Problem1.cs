using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0, lowerLimit, upperLimit;
            Console.WriteLine("Enter the lower limit of your range:");
            lowerLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the upper limit of your range:");
            upperLimit = int.Parse(Console.ReadLine());
            for (i = lowerLimit; i < upperLimit; i++)
            {
                if (i % 15 == 0)
                {
                    sum = sum + i;
                }
                else if (i % 3 == 0)
                {
                    sum = sum + i;
                }
                else if (i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("The sum of all the multiples of 3,5 between {0} and {1} is: {2}", lowerLimit, upperLimit, sum);
            Console.ReadKey();
        }
    }
}
