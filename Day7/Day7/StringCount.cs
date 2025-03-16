using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    static class StringCount
    {
        public static int GetWordCount(this string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                string[] str = s.Split(' ');
                return str.Count();

            }
            else
            {
                return 0;
            }
        }
    }
}
