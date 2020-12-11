using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modyl_02.Models.Drugs;
using System.Collections;
using System.Threading.Tasks;
using Modyl_02.Models;

namespace Modyl_02.Helpers
{  
    public class SubstancesComparer : IComparer
    {

        public int Compare(object first, object second)
        {
            var x = first as Substances;
            var y = second as Substances;

            if (x.NumberRecipe > y.NumberRecipe)
            {
                return 1;
            }
            else if (x.NumberRecipe < y.NumberRecipe)
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
