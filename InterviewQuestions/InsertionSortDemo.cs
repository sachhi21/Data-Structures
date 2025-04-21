using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class InsertionSortDemo
    {
        public static int[] InsertionSort(int[] numbers)
        {

            for (int i = 1; i < numbers.Length; i++)
            {
                int j = i - 1, key = numbers[i];


                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }


            return numbers;

        }
    }
}

