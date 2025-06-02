using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class RemoveElementSolution
    {

        public int RemoveElement(int[] nums, int val)
        {
            int total = 0;
            foreach (int i in nums)
            {
                {
                    if (i != val)
                    {
                        nums[total] = i;
                        total++;
                    }
                }
            }
            return total;
        }
    }
}
