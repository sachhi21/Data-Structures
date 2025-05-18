using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class MergeIntervalsOverlap
    {
        public static int[][] MergeIntervals(int[][] intervals)
        {
            if(intervals.Length == 1)
            {
                return intervals;
            }

           List<int[]> merged = new List<int[]>();
           Array.Sort(intervals,(a,b) => a[0].CompareTo(b[0]));

            foreach (var interval in intervals)
            {
                if (merged.Count == 0 || merged[merged.Count - 1][1] < interval[0])
                {
                    merged.Add(interval);
                }
                else
                {
                    merged[merged.Count - 1][1] = Math.Max(merged[merged.Count - 1][1], interval[1]);

                }
            }

            return merged.ToArray();
        }
    }
}
