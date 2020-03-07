using System;

namespace Project_Euler
{
    class Problem
    {
        static void Main(string[] args)
        {
            string numbers = "08022297381500400075040507785212507791084949994017811857608717409843694804566200814931735579142993714067538830034913366552709523046011426924685601325671370236912231167151676389419236542240402866331380244732609903450244753353783684203517125032988128642367102638406759547066183864706726206802621220956394396308409166499421245558056673992697177878968314883489637221362309750076442045351400613397343133957817532822753167159403800462161409535692163905429635314755588824001754243629855786560048357189070544443744602158515417581980816805944769287392138652177704895540045208839735991607975732162626793327986688366887576220720346336746551232639353690442167338253911249472180846293240627636206936417230238834629969826759857404361620733529783190017431497148868116235705540170547183515469169233486143520189196748";
            int i = 0, j, number, length = numbers.Length;
            long product = 1, largestProduct = 1;
            int[,] array = new int[20, 20];
            char ch;
            Console.WriteLine(length);

            //string[] strArr = null;
            //char[] splitchar = { ' ' };
            //strArr = numbers.Split(splitchar);
            //Console.WriteLine(strArr.Length);
            i = 0;
            j = 0;
            for (int count = 0; count < numbers.Length; count++)
            {
                
                //Console.WriteLine(strArr[count]);
                ch = numbers[count];
                //Console.Write(str + " ");
                number = 10 * Convert.ToInt32(Char.GetNumericValue(ch));
                number = number + Convert.ToInt32(Char.GetNumericValue(ch));
                array[i, j] = number;
                i++;
                if (i == 19)
                {
                    j++;
                    i = 0;
                }
                if (j == 20)
                    break;
             }
                //i += 2;
                
                //if (k % 19 == 0)
                //{
                //    j++;
                //}
                //k++;

            Print2DArray(array);
            //for (i = 0; i < length - 12; i++)
            //{
            //    for (j = 0; j < 13; j++)
            //    {
            //        product = product * array[j + i];
            //    }
            //    if (product > largestProduct)
            //        largestProduct = product;
            //    product = 1;
            //}
            Console.ReadKey();
        }
        public static void Print2DArray(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[j,i] + " ");
                    //if (j % 19 == 0)
                    //    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
