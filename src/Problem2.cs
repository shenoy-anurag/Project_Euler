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
            int currentNum = 2, previousNum = 1, temp;
            long evenSum = 0;
            while(currentNum <= 4000000) /*4000000*/
            {
                temp = currentNum;
                //Console.WriteLine("{0} ", previousNum); For displaying the Fibonacci Sequence
                if(currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }
                currentNum += previousNum;
                previousNum = temp;
            }
            Console.WriteLine("The sum of all even Fibonacci terms less than 4,000,000 is: {0}", evenSum);
            Console.ReadKey();
        }
    }
}
