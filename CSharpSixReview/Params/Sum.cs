using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSixReview.Params
{
    class Sum
    {
        public static int Sum5(params int[] data)
        {
            var sum = 0;
            foreach (var item in data) sum += item;
            return sum;
        }

        //public static int Sum6(params IEnumerable<int> data)
        //{
        //    var sum = 0;
        //    foreach (var item in data) sum += item;
        //    return sum;
        //}
    }
}
