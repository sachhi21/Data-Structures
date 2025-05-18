using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class LinksHeight
    {
        public static int Height(int[] A , int index)
        {
            if (A[index] == -1)
            {
                return 1;
            }

            return 1 + Height(A, A[index]); 
        }
       
    }
}
