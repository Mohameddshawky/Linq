using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal static class IntExtention
    {
        //exstention method must add in static class and non generic
        //cant change already exist function [override]
        public static int ReverseNum(this int x)
        {
            int rem = 0, rev = 0;
            while (x != 0)
            {
                rem = x % 10;
                rev = rev * 10 + rem;
                x /= 10;
            }
            return rev;
        }
        public static long ReverseNum(this long x)
        {
            long rem = 0, rev = 0;
            while (x != 0)
            {
                rem = x % 10;
                rev = rev * 10 + rem;
                x /= 10;
            }
            return rev;
        }
        //public static long ReverseNum(this IEnumerable x)
        //{
        //    long rem = 0, rev = 0;
        //    while (x != 0)
        //    {
        //        rem = x % 10;
        //        rev = rev * 10 + rem;
        //        x /= 10;
        //    }
        //    return rev;
        //}
        

    }
}
