using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class SelectionSortDemo
    {
        public static int[] SelectionSort(int[] ints)
        {
            for (int i = 0; i < ints.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < ints.Length; j++)
                {
                    if (ints[j] < ints[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the current element with the minimum found
                int temp = ints[i];
                ints[i] = ints[minIndex];
                ints[minIndex] = temp;
            }

            return ints;
        }

    }
}
