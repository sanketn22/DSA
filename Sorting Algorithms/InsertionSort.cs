using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting_Algorithms
{
    public class InsertionSort
    {
        /*
         * take an element and place it in its correct position
         * checks the first element and consider it as in its correct position
         * increase the window and start checking from the last element of the window if they are in the correct postion.
         * if not, swap with the adjacent element till they are in the correct position
         * 
         * eg. [2,4,1,5,3]
         */
        public void sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;
                
                while (j>0 && arr[j-1]>arr[j])
                {
                    int temp = arr[j-1];
                    arr[j-1] = arr[j];
                    arr[j] = temp;
                    j--;
                }
            }
        }
       
    }
}
