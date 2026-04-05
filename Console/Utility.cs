using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    internal static class Utility
    {
        public static string handleQoute(string[] arr)
        {
            string tmp = string.Empty;

            if (arr[0].Contains('"'))
            {
                tmp = string.Join(" ", arr.Skip(1));
                tmp = tmp.Trim('"');
            }

            return tmp;
        }
    }
}
