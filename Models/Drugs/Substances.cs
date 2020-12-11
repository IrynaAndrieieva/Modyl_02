using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modyl_02.Enums;
using Modyl_02.Models.Drugs;
using System.Threading.Tasks;

namespace Modyl_02.Models
{ 
    public abstract class Substances : Signatyre
    {     
        public abstract TypeOfSubstances TypeOfSubstances { get; }
    }
}
