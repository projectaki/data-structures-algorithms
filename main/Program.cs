using System;
using ArraysAndStrings;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "abcd";
            string two = "dcba";
            Console.WriteLine(Permutation.isPermutation(one, two, 26));
        }
    }
}
