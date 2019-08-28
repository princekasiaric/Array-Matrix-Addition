using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace C__VS
{
    class Program
    {
        static void Main(string[] args)
        {
            MultidimensionalArray();
        }

        static void MultidimensionalArray(){
            int[,] twoDimensionalArray1 = new int[4, 4]{{4,3,4,3}, {5,2,5,2}, {4,3,4,3}, {5,2,5,2}};
            int[,] twoDimensionalArray2 = new int[4, 4]{{4,4,4,4}, {5,5,5,5}, {6,6,6,6}, {7,7,7,7}};

            var matrix1 = new List<int>();
            var matrix2 = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix1.Add(twoDimensionalArray1[i, j]);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix2.Add(twoDimensionalArray2[i, j]);
                }
            }

            var counter = 0;
            var arrayResult = new int[16];
            var array1 = matrix1.ToArray();
            var array2 = matrix2.ToArray();

            while (counter < 16)
            {
                arrayResult[counter] = array1[counter] + array2[counter];
                counter++;
            }
            
            foreach (var item in arrayResult)
            {
                WriteLine(item);
            }
        }
    }
}









































































































