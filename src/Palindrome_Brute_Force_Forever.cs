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
            //int factor1 = 999, factor2 = 999, product = 0, largestPalindrome = 0, result = 0;
            int product = 0, largestPalindrome = 0, result = 0;
            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 99; j--)
                {
                    product = i * j;
                    if(product > 99999)
                    result = Palindrome(product);
                    if (result == 1)
                    {
                        if (largestPalindrome < product)
                            largestPalindrome = product;
                    }
                }
            }
            Display();
            void Display()
            {
                if (result == 1) Console.WriteLine("{0} is the largest Palindrome made from product of two 3 digit numbers!", largestPalindrome);
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
