using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class HashTest
    {
        string test = "abcdef";
        new int[] hash = { 0 };

        public void printAscii()
        {
            foreach(char c in test)
            {
                Console.WriteLine(c-'a');
            }

        }
    }
}
