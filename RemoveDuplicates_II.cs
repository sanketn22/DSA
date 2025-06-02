using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class RemoveDuplicates_II
    {

        public int RemoveDuplicates(int[] nums)
        {
            int k = 2;

            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] != nums[k-2])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
