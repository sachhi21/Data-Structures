using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class Search2dMatrix
    {
        public static bool searchmatrix(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return false;

            int m = matrix.Length;      // Number of rows
            int n = matrix[0].Length;   // Number of columns

            int row = 0;  
            int col = n - 1;

            while (row < m && col >= 0)
            {
                if (matrix[row][col] == target)
                    return true;  
                else if (matrix[row][col] > target)
                    col--;  
                else
                    row++;  
            }

            return false;
        }
    }
}
