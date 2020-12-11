﻿using Modyl_02.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modyl_02.Models.Drugs
{
    public class Sedariston : Substances
    {
        public override int NumberRecipe => 1;

        public override string NameDrugs => "Sedariston";

        public override string Compositionem => "Menta, Valeriana Officinalic";

        public override TypeOfSubstances TypeOfSubstances => TypeOfSubstances.Lagena;
    }
}
