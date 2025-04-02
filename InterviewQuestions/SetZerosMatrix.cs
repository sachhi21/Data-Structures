using System;

namespace Data_Structures.InterviewQuestions
{
    public class SetZerosMatrix
    {
        public static int[][] SetZeroes(int[][] matrix)
        {
            int m = matrix.Length;     
            int n = matrix[0].Length;  

            bool[] zeroRows = new bool[m];
            bool[] zeroCols = new bool[n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        zeroRows[i] = true;
                        zeroCols[j] = true;
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                if (zeroRows[i])  
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            for (int j = 0; j < n; j++)
            {
                if (zeroCols[j])  
                {
                    for (int i = 0; i < m; i++)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            return matrix;
        }

        public static void PrintMatrix(int[][] matrix)
        {
            int m = matrix.Length;     // Number of rows
            int n = matrix[0].Length;  // Number of columns

            // Loop through each row
            for (int i = 0; i < m; i++)
            {
                // Loop through each column in the row
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i][j] + " "); // Print the element followed by a space
                }
                Console.WriteLine(); // Move to the next line after printing each row
            }
        }

      
    }
}
