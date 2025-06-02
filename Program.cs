using DSA.Sorting_Algorithms;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubble = new BubbleSort();
            SelectionSort selection = new SelectionSort();

            int[] nums = [1,2,5,6,3,4,2,8];

            selection.sort(nums);
            foreach(int i in nums)
                Console.WriteLine(i);
        }
    }
}
