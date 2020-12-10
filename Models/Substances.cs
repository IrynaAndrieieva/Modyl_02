using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modyl_02.Enums;
using System.Threading.Tasks;

namespace Modyl_02.Models
{ 
    public abstract class Substances : Magnoliophyta //Отдел Цветковые
    {
        protected Substances(string medicinal, string zone)
            : base(medicinal, zone)
        {
        }

        public abstract TypeOfSubstances TypeOfSubstances { get; }      
    }
}
