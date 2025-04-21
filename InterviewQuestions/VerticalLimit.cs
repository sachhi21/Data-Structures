using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public  class VerticalLimit
    {
        public static int SolveVerticalLimit(List<int> ar, int k)
        {
            int crossings = 0;
            ar.Sort((a,b) =>b.CompareTo(a));
            int totakwieght = 0;
            int i = 0;
            int j= ar.Count - 1;

            while (i <= j)
            {
                if (ar[i] + ar[j] <= k)
                {
                    crossings++;
                    i++;
                    j--;

                }
                else if (ar[i] <= k)
                {
                    crossings++;
                    i++;
                }else 
                {
                    crossings++;
                    j--;
                }

            }

           
            return crossings;
        }
    }
}
