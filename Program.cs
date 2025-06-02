﻿using DSA.Sorting_Algorithms;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubble = new BubbleSort();
            SelectionSort selection = new SelectionSort();
            InsertionSort insertion = new InsertionSort();

            int[] nums = [1,2,5,6,3,4,2,8];

            insertion.sort(nums);
            foreach(int i in nums)
                Console.WriteLine(i);
        }
    }
}
