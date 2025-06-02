using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class MergeSortedArray
    {

        public class Solution
        {
            public void Merge(int[] nums1, int m, int[] nums2, int n)
            {
                int p1 = m - 1;
                int p2 = n - 1;
                int i = m + n;

                while (p2 >= 0)
                {
                    if (p1 >= 0 && nums1[p1] > nums2[p2])
                    {
                        nums1[i--] = nums1[p1--];
                    }
                    else
                    {
                        nums1[i--] = nums2[p2--];
                    }
                }
            }
        }
    }
}
