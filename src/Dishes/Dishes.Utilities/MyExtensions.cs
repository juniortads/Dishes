using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes.Utilities
{
    public static class MyExtensions
    {
        public static string ConvertToString<T>(this List<T> list, Func<T, string> selector)
        {
            return string.Join(",", list.Select(selector).ToArray());
        }
    }
}
