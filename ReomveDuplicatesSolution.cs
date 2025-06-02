using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class ReomveDuplicatesSolution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int total = 0;
            int currentnumber = int.MinValue;
            foreach (int x in nums) 
            {
                if(currentnumber!=x)
                {
                    total++;
                    nums[total - 1] = x;
                }
            }
            return total;


        }
    }
}
