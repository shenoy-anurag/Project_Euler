//https://github.com/kkmonlee/Project-Euler-Solutions/blob/master/C%23/Problem4.cs

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

            bool found = false;
            int half = 998;
            int palin = 0;
            int[] factors = new int[2];

            while (!found)
            {
                half--;
                palin = MakePalindrome(half);
                for (int i = 999; i > 99; i--)
                {
                    if ((palin / i) > 999 || i * i < palin)
                    {
                        break;
                    }

                    if ((palin % i == 0))
                    {
                        found = true;
                        factors[0] = palin / i;
                        factors[1] = i;
                        break;
                    }
                }
            }

            Console.WriteLine("Palindome: " + palin);
            Console.ReadKey();
        }
        static private int MakePalindrome(int half)
        {
            char[] reversed = half.ToString().Reverse().ToArray();
            return Convert.ToInt32(half + new string(reversed));
        }
    }
}