using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting_Algorithms
{
    internal class SelectionSort
    {
        public void sort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int min = i;
                for (int j = i; j < nums.Length - 1; j++)
                {
                    if (nums[j] < nums[min])
                    {
                        min = j;
                    }
                }
                (nums[i], nums[min]) = (nums[min], nums[i]);
            }
        }
    }
}
