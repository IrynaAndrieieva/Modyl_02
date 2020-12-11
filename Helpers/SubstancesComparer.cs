namespace Modyl_02.Helpers
{
    using System.Collections;
    using Modyl_02.Models;

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
