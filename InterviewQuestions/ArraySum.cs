using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class ArraySum
    {

        public static int Sum(List<int> list)
        {
            int sum = 0;
            foreach (int item in list)
            {
                sum += item;
            }
            return sum; 
        }
    }
}
