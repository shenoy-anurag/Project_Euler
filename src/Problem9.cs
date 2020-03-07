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
            int a = 3, b = 4, c = 5, sum = 0, product = 1;
            int[] Triplets = new int[3];
            string result;
            
            bool CheckPythagoreanTriplet(int x, int y, int h)
            {
                int square_big = 1, square_side1 = 1, square_side2 = 1;
                if (x > y)
                {
                    if (x > h)
                    {
                        square_big = x * x;
                        square_side1 = y * y;
                        square_side2 = h * h;
                    }
                    else
                    {
                        square_big = h * h;
                        square_side1 = y * y;
                        square_side2 = x * x;
                    }
                }
                else if (y > h)
                {
                    square_big = y * y;
                    square_side1 = h * h;
                    square_side2 = x * x;
                } 
                else
                {
                    square_big = h * h;
                    square_side1 = x * x;
                    square_side2 = y * y;
                }
                if (square_big == (square_side1 + square_side2))
                    return true;
                else
                    return false;
            }
            for (int i = 3; i < 100; i++)
            {
                int square, side1, side2;
                
                if(i % 2 == 0)
                {
                    FindPythagoreanTripletEven(i);
                    void FindPythagoreanTripletEven(int x)
                    {
                        bool? isTrue = null;
                        square = x * x;
                        side1 = ((square - 2) / 2);
                        side2 = side1 + 2;
                        isTrue = CheckPythagoreanTriplet(x, side1, side2);
                        if(isTrue == true)
                        {
                            sum = x + side1 + side2;
                            if (sum == 1000)
                            {
                                product = x * side1 * side2;
                                Triplets[0] = x;
                                Triplets[1] = side1;
                                Triplets[2] = side2;
                                Console.WriteLine(product);
                            }
                        }
                    }
                }
                else
                {
                    FindPythagoreanTripletOdd(i);
                    void FindPythagoreanTripletOdd(int x)
                    {
                        bool? isTrue = null;
                        square = x * x;
                        side1 = ((square - 1) / 2);
                        side2 = side1 + 1;
                        isTrue = CheckPythagoreanTriplet(x, side1, side2);
                        if (isTrue == true)
                        {
                            sum = x + side1 + side2;
                            if (sum == 1000)
                            {
                                product = x * side1 * side2;
                                Triplets[0] = x;
                                Triplets[1] = side1;
                                Triplets[2] = side2;
                            }
                        }
                    }
                }
                
            }

            bool isTriplet = CheckPythagoreanTriplet(a, b, c);
            result = isTriplet ? "Is a Triplet" : "Not a triplet";

            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}