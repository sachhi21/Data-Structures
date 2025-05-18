using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class DutchNationalFlagSort
    {

        public static void swap(int i ,int j,int[] nums)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        public static int[] SortFlags(int[] nums)
        {
            int i = -1;
            int j = nums.Length;
            int k = 0;

            while(k < j)
            {
                if(nums[k] == 2)
                {
                    j--;
                    swap(j, k , nums);
                }

                if (nums[k] == 0) {
                    i++;
                    swap(i, k , nums);
                    k++;
                }

                if (nums[k] == 1) {
                    k++;
                }
            }


            return nums;
        }
    }
}
