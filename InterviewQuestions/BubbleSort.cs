using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public static class BubbleSort
    {
        public static int[] BubbleSortDemo(int[] numbers)
        {
            
            for (int i = 0; i< numbers.Length - 1; i++)
            {
                bool swap = false;
                for(int j = 0; j < numbers.Length -i- 1; j++)
                {
                    if(numbers[j] > numbers[j + 1])
                    {
                     
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        swap = true;
                        
                    }

                    //if (numbers[j] < numbers[j + 1])
                    //{
                    //    // Swap
                    //    int temp = numbers[j];
                    //    numbers[j] = numbers[j + 1];
                    //    numbers[j + 1] = temp;
                    //}
                }

                if (!swap)
                {
                    Console.WriteLine("No swaps in this pass — early exit!");
                    break;
                }
            }


            return numbers;
        }
    }
}
