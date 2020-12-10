using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modyl_02.Models
{
    public interface IRecipe
    {
        int NumberRecipe { get; }

        string NameDrugs { get; }

        string Compositionem { get; }
    }
}
