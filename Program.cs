using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheParityOutlier
{
    class Program
    {
        //You are given an array (which will have a length of at least 3, but could be very large) containing integers.
        //The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N.
        //Write a method that takes the array as an argument and returns this "outlier" N.
        
        static void Main(string[] args)
        {
            int[] integers = { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
            Console.WriteLine(Find(integers));
            Console.ReadLine();
        }
        public static int Find(int[] integers)
        {
            int odd = 0;
            int even = 0;
            int outliereven = 0;
            int outlierodd = 0;
            foreach (var i in integers)
            {
                if (i % 2 == 0)
                {
                    even++;
                    if (even == 1)
                    {
                        outliereven = i;
                    }
                }
                else
                {
                    odd++;
                    if (odd == 1)
                    {
                        outlierodd = i;
                    }
                }
            }
            if (even > odd)
            {
                return outlierodd;
            }
            else
            {
                return outliereven;
            }
        }
        public static int BestPractice(int[] integers)
        {
            var evenNumbers = integers.Where(integer => integer % 2 == 0);
            var oddNumbers = integers.Where(integer => integer % 2 == 1);
            return evenNumbers.Count() == 1 ? evenNumbers.First() : oddNumbers.First();
        }
    }
}
