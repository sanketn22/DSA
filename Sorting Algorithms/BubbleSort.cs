using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting_Algorithms
{
    public class BubbleSort
    {

        public void sort(int[] nums)
        {
            for (int i = nums.Length-1; i >0; i--)
            {
                for (int j = 0; j < i-1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        (nums[j + 1], nums[j]) = (nums[j], nums[j + 1]);
                    }
                }
            }
        }

    }
}
