using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class CompareTriplets
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int aliceScore = 0;
            int bobScore = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    aliceScore++;  
                }
                else if (b[i] > a[i])
                {
                    bobScore++;  
                }
            }

            return new List<int> { aliceScore, bobScore };
        }

    }
}

