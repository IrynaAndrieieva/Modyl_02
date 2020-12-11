namespace Modyl_02
{
    using System.Collections;

    public class MagnoliophytaComparer : IComparer
    {
        public int Compare(object first, object second)
        {
            var x = first as Magnoliophyta;
            var y = second as Magnoliophyta;

            if (x.Name.Length > y.Name.Length)
            {
                return 1;
            }
            else if (x.Name.Length < y.Name.Length)
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
