//Palindrome the hard, messy but smart and efficient way.

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
            int factor1 = 999, factor2 = 991, product = 0, digitNew = 9, digitOld = 9, result = 0;
            while (factor1 > 99)
            {
                while (factor2 > 99)
                {
                    product = factor1 * factor2;
                    digitNew = factor2 / 100;
                    if ((digitOld - digitNew) == 1)
                    {
                        factor2--;
                        digitOld = digitNew;
                    }
                    if(product > 99999)
                    result = Palindrome(product);
                    Display();
                    if (result == 1) break;
                    factor2 -= 10;
                }
                factor1 -= 10;
                factor2 = 991;
                
            }
            void Display()
            {
                if (result == 1) Console.WriteLine("{0} is the largest Palindrome made from product of two 3 digit numbers!", product);
            }
            //Palindrome(9009); Testing of local function.
            int Palindrome(int x)
            {
                int y=0, digit=0, num;
                num = x;
                while (x > 1)
                {
                    digit = (x % 10);
                    x /= 10;
                    y = y * 10 + digit;
                }
                if(y - num == 0)
                {
                    //Console.WriteLine("Is a Palindrome!");
                    return 1;
                }
                else
                {
                    //Console.WriteLine("Is NOT a Palindrome.");
                    return 0;
                }

            }

            //Console.WriteLine("");

            Console.ReadKey();
        }//END   Factors
    }
}
