using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class BottomUpStairCaseProblem
    {
        public static int FindWays(int n)
        {
            if (n == 0 || n == 1) return 1;
            int prev0 = 1, prev1 = 1;
            for (int i = 2; i <= n; i++)
            {
                int current = prev0 + prev1;
                prev0 = prev1;
                prev1 = current;
            }

            return prev1;
        }
    }
}
