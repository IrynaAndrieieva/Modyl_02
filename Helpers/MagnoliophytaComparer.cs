using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Modyl_02
{
    public class MagnoliophytaComparer : IComparer
    {

        public int Compare(object first, object second)
        {
            var x = first as Magnoliophyta;
            var y = second as Magnoliophyta;

            if (x.Name.Length < y.Name.Length)
            {
                return 1;
            }
            else if (x.Name.Length > y.Name.Length)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
