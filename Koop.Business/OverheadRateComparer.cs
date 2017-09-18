using System;
using System.Collections;
using System.Linq;

namespace Koop.Business
{
    public class OverheadRateComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            bool flag = !(x is Overhead);
            Overhead r1;
            if (flag)
            {
                throw new ArgumentException("x is not a valid Overhead Object");
            }
            else
            {
                r1 = (Overhead)x;
            }

            flag = !(y is Overhead);
            Overhead r2;
            if (flag)
            {
                throw new ArgumentException("y is not a valid Overhead Object");
            }
            else
            {
                r2 = (Overhead)y;
            }

            flag = r1.Range >= r2.Range;
            int result;
            if (flag)
            {
                flag = r1.Range <= r2.Range;
                result = flag ? 0 : 1;
            }
            else
            {
                result = -1;
            }

            return result;
        }

        public OverheadRateComparer()
        {
        }
    }
}
